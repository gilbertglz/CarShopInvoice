using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Org.BouncyCastle.Crypto.Generators;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace CarShop
{
    public partial class InformationDialog : Form
    {
        public MainForm parentVar;
        public string path;
        public List<Item> items;
        public double tax, subtotal, total;
        public InformationDialog(List<Item> list, MainForm parent, string filePath, double tax, double subtotal, double total)
        {
            InitializeComponent();
            this.parentVar = parent;
            this.path = filePath;
            this.items = list;
            this.tax = tax;
            this.subtotal = subtotal;
            this.total = total;
            label4.Text = subtotal.ToString("#0.00");
            label5.Text = total.ToString("#0.00");
            populateTextBox();

        }
        public void populateTextBox()
        {
            DateTime todayDT = DateTime.Now.Date;
            DateTime nextWeekDT = todayDT.AddDays(7);


            Random random = new Random();
            int invoiceNumberGen = random.Next(100, 1000);

            string companyName = "Company Name", addressOne = "123 Main Street", addressTwo = "Anytown, USA 12345";

            string customerName = "John Doe", customerAddress = "456 Park Avenue", customerAddressTwo = "Anytown, USA 12345";
            companyNameTextBox.Text = companyName;
            streetTextBox.Text = addressOne;
            streetTwoTextBox.Text = addressTwo;

            invoiceTextBox.Text = invoiceNumberGen.ToString();
            dateTimePicker1.Value = todayDT;
            dateTimePicker2.Value = nextWeekDT;

            customerNameTextBox.Text = customerName;
            customerStreetTextBox.Text = customerAddress;
            customerStreetTwoTextBox.Text = customerAddressTwo;
            taxTextBox.Text = (this.tax * 100).ToString("#0.00");
        }
        private void submitButtonPrint(object sender, EventArgs e)
        {
            InvoiceTemplate template = new();
            string invoiceNumber, date, dueDate;
            string today = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string nextWeek = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            double updateTax = 8.25;
            bool flagTax = false;
            try { updateTax = double.Parse(taxTextBox.Text); flagTax = true; } catch (Exception error) { MessageBox.Show(error.ToString()); };
            updateTax = updateTax / 100;

            invoiceNumber = $"Invoice # INV{invoiceTextBox.Text}";
            date = $"Date: {today}";
            dueDate = $"Due Date: {nextWeek}";

            // Create a new PDF document
            iTextSharp.text.Document doc = new();

            // Create a new PDF writer that writes to a memory stream
            MemoryStream memStream = new MemoryStream();
            PdfWriter.GetInstance(doc, memStream);

            // Open the document for writing
            doc.Open();

            //Add Logo
            doc.Add(template.invoiceLogo("C:\\Users\\gilbe\\OneDrive\\Desktop\\Scripts\\gilbertglz\\CarShopInvoice\\example-logo-png-1.png"));

            //Add Header/Title
            doc.Add(template.invoiceHeader("Invoice"));
            doc.Add(template.invoiceEnter());

            //Add Table For Top Two Columns
            doc.Add(template.invoiceTwoColumns(companyNameTextBox.Text, streetTextBox.Text, streetTwoTextBox.Text,
                invoiceNumber, date, dueDate));
            doc.Add(template.invoiceEnter());

            //Customer Information
            doc.Add(template.invoiceCustomer(customerNameTextBox.Text, streetTextBox.Text, streetTwoTextBox.Text));
            doc.Add(template.invoiceEnter());

            //Items Invoice Table
            doc.Add(template.invoiceItems(this.items));

            //Invoice comments
            string comments = "";
            doc.Add(template.invoiceComments(comments));

            //Invoice Totals
            string subtotal = this.subtotal.ToString("#00.00");
            if (flagTax)
            {
                this.tax = updateTax * this.subtotal;
                this.total = this.tax + this.subtotal;
            }
            string tax = this.tax.ToString("#00.00"), total = this.total.ToString("#00.00");

            doc.Add(template.invoiceTotals(subtotal, tax, total));
            doc.Add(template.invoiceEnter());

            // Close the document
            doc.Close();

            File.WriteAllBytes(this.path + "\\Invoice.pdf", memStream.ToArray());
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", this.path + "\\Invoice.pdf");

            MainForm newForm = new MainForm();
            newForm.Show();
            this.Close();
        }
        private void taxTextBox_TextChanged(object sender, EventArgs e)
        {
            double taxChange = .00825;
            string taxDef = "0";
            try
            {
                taxDef = taxTextBox.Text;
                if (taxDef == "")
                    taxDef = "0";
                taxChange = double.Parse(taxDef) / 100;
                this.tax = taxChange;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
                return;
            };
            this.total = this.subtotal + (this.subtotal * this.tax);
            label5.Text = this.total.ToString("#0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.parentVar.Show();
            this.Close();
        }
    }
}
