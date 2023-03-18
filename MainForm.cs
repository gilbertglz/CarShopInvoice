namespace CarShop
{
    public partial class MainForm : Form
    {
        private string[,] tableItems = { };
        private int tableRows = 0;
        public bool updatedItemsFlag = false;
        public string pwd = "C:\\Users\\gilbe\\OneDrive\\Desktop\\Scripts\\CarShop";
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
            this.tableItems = items;
            this.tableRows = rows;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateItemList(string newItemAdded)
        {
            comboBox1.Items.Add(newItemAdded);
            int addRow = this.tableRows;
            string[,] updatedItems = new string[addRow + 1, 2];
            for (int i = 0; i < addRow; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    updatedItems[i, j] = this.tableItems[i, j];
                }
            }
            updatedItems[addRow, 0] = addRow.ToString();
            updatedItems[addRow, 1] = newItemAdded;
            setTableItems(updatedItems, addRow + 1);
            this.updatedItemsFlag = true;
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            InputDialog s = new InputDialog(this);
            if (comboBox1.SelectedIndex == 1)
            {
                //MessageBox.Show("Selected Not ON List");
                this.Hide();
                s.ShowDialog();
            }
            updateItemList(s.getNewItem());
        }
        private void MainFormClose(object sender, EventArgs e)
        {
            if(updatedItemsFlag)
                updateTxtCacheFile(this.tableItems, this.tableRows);
        }
        private void updateTxtCacheFile(string[,] saveTable, int rows)
        {
            StreamWriter s = new StreamWriter(this.pwd + "\\Items.txt");
            using (s)
            {
                for (int i = 0; i < rows; i++)
                {
                    s.WriteLine(saveTable[i, 0] + "\t" + saveTable[i, 1]);
                }
            }
            s.Close();
        }
    }
}