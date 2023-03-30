using System.Reflection;

namespace CarShop
{

    public partial class MainForm : Form
    {
        private string[,] dropDownItems = { };
        private int dropDownRows = 0;
        public bool updatedDropDown = false;
        public string pwd = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public List<string> invoiceList = new();
        public double subtotal, taxPercent = .0825, tax, total;
        public MainForm()
        {
            InitializeComponent();
            populateListDropDown();
            comboBox1.SelectedIndex = 0;
            label1.Text = $"Tax set to {(taxPercent * 100).ToString("#0.00")}%";
        }
        private void populateListDropDown()
        {
            //get dropdown items from txt file (no server) \CarShop\Items.txt     
            string txtPath = Path.Combine(pwd, "Items.txt");
            string[] lines = { };
            if (File.Exists(txtPath))
            {
                lines = File.ReadAllLines(txtPath);
                // Process the file contents
            }
            else
            {
                using (File.Create(txtPath)) { }
            }

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
                int w = userInput.Length;
                while (string.IsNullOrEmpty(userInput))
                {
                    userInput = Microsoft.VisualBasic.Interaction.InputBox("Please enter new item name:", "Input Required");

                    // Check if the user clicked the Cancel button or closed the dialog
                    userInput.Trim();
                    w = userInput.Length;
                    if (w == 0)
                    {
                        MessageBox.Show("Operation cancelled.");
                        break;
                    }
                }
                if (w > 0)
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
                    double a = 0, b = 0, total = 0;
                    try
                    {
                        a = double.Parse(quantity);
                        b = Math.Round(double.Parse(price), 2);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("ERROR: Parsing error-only numerical inputs please.\n" + error.Message.ToString());
                        return;
                    }
                    total = a * b;
                    this.subtotal = this.subtotal + total;
                    this.tax = this.subtotal * taxPercent;
                    this.total = this.subtotal + tax;
                    //Monetary decimal format
                    price = "$" + b.ToString("#.00");
                    string strTotal = "$" + Math.Round(total, 2).ToString("#.00");
                    //push to data table in strings only
                    dataGridView1.Rows.Add(itemSold, quantity, price, strTotal);
                    int dataGridRows = dataGridView1.Rows.Count - 2;
                    dataGridView1.Rows[dataGridRows].HeaderCell.Value = "X";
                    //dataGridView1.Rows[dataGridRows].HeaderCell.
                    //clear the selections from above
                    subtotalDoubleLabel.Text = this.subtotal.ToString("#0.00");
                    taxDoubleLabel.Text = this.tax.ToString("#0.00");
                    totalDoubleLabel.Text = this.total.ToString("#0.00");
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
            string filePath = Path.Combine(pwd, "Items.txt");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < rows; i++)
                {
                    writer.WriteLine(saveTable[i, 0] + "\t" + saveTable[i, 1]);
                }

                writer.Flush();
                writer.Close();
            }
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

            InformationDialog dialog = new InformationDialog(itemList, this, pwd, this.taxPercent, this.subtotal, this.total);
            this.Hide();
            dialog.Show();
        }
        private void taxChangeButton(object sender, EventArgs e)
        {
            string inputText = (taxPercent * 100).ToString();
            inputText = Microsoft.VisualBasic.Interaction.InputBox("Please enter new tax in percentage:", "Input Required", inputText);
            int inputLength = inputText.Length;
            if (inputLength > 0)
            {
                try
                {
                    this.taxPercent = double.Parse(inputText) / 100;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            label1.Text = $"Tax set to {(taxPercent * 100).ToString("#0.00")}%";
        }
    }
    public partial class Item
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