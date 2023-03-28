using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarShop
{

    public partial class MainForm : Form
    {
        private string[,] dropDownItems = { };
        private int dropDownRows = 0;
        public bool updatedDropDown = false;
        public string pwd = "C:\\Users\\gilbe\\OneDrive\\Desktop\\Scripts\\gilbertglz\\CarShopInvoice";
        public List<string> invoiceList = new();
        public MainForm()
        {
            InitializeComponent();
            populateListDropDown();
            comboBox1.SelectedIndex = 0;
        }
        private void populateListDropDown()
        {
            //get dropdown items from txt file (no server) \CarShop\Items.txt     
            string txtPath = this.pwd + "\\Items.txt";
            string[] lines = File.ReadAllLines(txtPath);
            int rows = lines.Count(), columns = 2;
            string[,] table = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                var s = lines[i].Split("\t");
                table[i, 0] = s[0];
                table[i, 1] = s[1];
                if (i > 0)
                {
                    comboBox1.Items.Add(s[1]);
                }
            }
            setTableItems(table, rows);
        }
        private void setTableItems(string[,] items, int rows)
        {
            this.dropDownItems = items;
            this.dropDownRows = rows;
        }
        private void updateItemList(string newItemAdded)
        {
            comboBox1.Items.Add(newItemAdded);
            int addRow = this.dropDownRows;
            string[,] updatedItems = new string[addRow + 1, 2];
            for (int i = 0; i < addRow; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    updatedItems[i, j] = this.dropDownItems[i, j];
                }
            }
            updatedItems[addRow, 0] = addRow.ToString();
            updatedItems[addRow, 1] = newItemAdded;
            setTableItems(updatedItems, addRow + 1);
            this.updatedDropDown = true;
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Error: Empty Input on Item Selection");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //TODO: Check if added Item is already in list & ask if it should be selected
                this.Hide();
                string userInput = "";
                while (string.IsNullOrEmpty(userInput))
                {
                    userInput = Microsoft.VisualBasic.Interaction.InputBox("Please enter new item name:", "Input Required");

                    // Check if the user clicked the Cancel button or closed the dialog
                    if (string.IsNullOrEmpty(userInput))
                    {
                        MessageBox.Show("Operation cancelled.");
                        break;
                    }
                }
                if (userInput != "")
                {
                    updateItemList(userInput);
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                    addItem_Click(sender, e);
                }
                this.Show();
            }
            else
            {
                string itemSold = (string)comboBox1.SelectedItem;
                var quantity = textBox1.Text.Trim();
                var price = textBox2.Text.Trim();
                //No inputs
                if (quantity == "" || price == "")
                {
                    var error = quantity == null ? "Quantity" : "Price Per Item";
                    MessageBox.Show("Error: Empty Input on " + error);
                }
                else
                {
                    //Simple Multiplication for Total of Row
                    double a = double.Parse(quantity), b = Math.Round(double.Parse(price), 2), total = a * b;
                    //Monetary decimal format
                    price = "$" + b.ToString("#.00");
                    string strTotal = "$" + Math.Round(total, 2).ToString("#.00");
                    //push to data table in strings only
                    dataGridView1.Rows.Add(itemSold, quantity, price, strTotal);
                    int dataGridRows = dataGridView1.Rows.Count - 2;
                    dataGridView1.Rows[dataGridRows].HeaderCell.Value = "X";
                    //dataGridView1.Rows[dataGridRows].HeaderCell.
                    //clear the selections from above
                    clearFinishedSelection();
                }
            }
        }
        private void clearFinishedSelection()
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void deleteRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this Row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //remove row if approved
                int h = (int)e.RowIndex;
                dataGridView1.Rows.RemoveAt(h);
                dataGridView1.Update();
            }
        }
        private void MainFormClose(object sender, EventArgs e)
        {
            if (updatedDropDown)
                updateTxtCacheFile(this.dropDownItems, this.dropDownRows);
        }
        private void updateTxtCacheFile(string[,] saveTable, int rows)
        {
            StreamWriter s = new(this.pwd + "\\Items.txt");
            using (s)
            {
                for (int i = 0; i < rows; i++)
                {
                    s.WriteLine(saveTable[i, 0] + "\t" + saveTable[i, 1]);
                }
            }
            s.Close();
        }
        private List<Item> generateInvoiceList()
        {
            List<Item> rows = new List<Item>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Item s = new Item();
                int count = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        break;
                    switch (count)
                    {
                        case 0:
                            s.Name = cell.Value.ToString().Trim();
                            count++;
                            break;
                        case 1:
                            s.Amount = cell.Value.ToString().Trim();
                            count++;
                            break;
                        case 2:
                            s.PricePerItem = cell.Value.ToString().Trim();
                            count++;
                            break;
                        case 3:
                            s.PriceTotal = cell.Value.ToString().Trim();
                            count++;
                            break;
                        default:
                            break;
                    }
                }
                rows.Add(s);
            }
            rows.RemoveAt(rows.Count - 1);
            return rows;
        }
        private void print_Click(object sender, EventArgs e)
        {


            List<Item> itemList = generateInvoiceList();
            // Create a new PDF document
            Document doc = new Document();

            // Create a new PDF writer that writes to a memory stream
            MemoryStream memStream = new MemoryStream();
            PdfWriter.GetInstance(doc, memStream);

            // Open the document for writing
            doc.Open();
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(pwd + "\\example-logo-png-1.png");
            logo.ScaleToFit(100f, 100f);
            doc.Add(logo);
            Paragraph invoiceHeader = new Paragraph();
            invoiceHeader.Add(new Chunk("INVOICE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,24f,iTextSharp.text.Font.BOLD)));

            // Add a table to the document with columns for item name, amount, and price
            PdfPTable table = new PdfPTable(4);
            table.AddCell("Item Name");
            table.AddCell("Amount");
            table.AddCell("Price per Item");
            table.AddCell("Total");

            // Loop through the list of items and add a row for each item to the table
            foreach (Item item in itemList)
            {
                table.AddCell(item.Name);
                table.AddCell(item.Amount);
                table.AddCell(item.PricePerItem);
                table.AddCell(item.PriceTotal);
            }

            doc.Add(invoiceHeader);
            // Add the table to the document
            doc.Add(table);

            // Close the document
            doc.Close();

            File.WriteAllBytes(pwd + "\\Invoice.pdf", memStream.ToArray());
            MessageBox.Show("Done");
            // Save the PDF invoice to a file
            //File.WriteAllBytes("Invoice.pdf", memStream.ToArray());

        }
    }
    class Item
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public string PricePerItem { get; set; }
        public string PriceTotal { get; set; }

        public Item(string name, string amount, string pricePerItem)
        {
            Name = name;
            Amount = amount;
            PricePerItem = pricePerItem;
        }

        public Item()
        {
        }
    }
}