using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Diagnostics;

namespace CarShop
{
    public partial class InformationDialog : Form
    {
        public MainForm parentVar;
        public string path;
        public List<Item> items;
        public InformationDialog(List<Item> list, MainForm parent, string filePath)
        {
            InitializeComponent();
            this.parentVar = parent;
            this.path = filePath;
            this.items = list;
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
        }
        private void submitButtonPrint(object sender, EventArgs e)
        {
            InvoiceTemplate template = new();
            string invoiceNumber, date, dueDate;
            string today = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string nextWeek = dateTimePicker2.Value.ToString("MM/dd/yyyy");

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
            doc.Add(template.invoiceLogo(path + "\\example-logo-png-1.png"));

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
            string subtotal = "", tax = "", total = "";
            doc.Add(template.invoiceTotals(subtotal, tax, total));
            doc.Add(template.invoiceEnter());

            // Close the document
            doc.Close();

            File.WriteAllBytes(this.path + "\\Invoice.pdf", memStream.ToArray());
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", this.path + "\\Invoice.pdf");
        }
    }
}
