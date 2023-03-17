namespace CarShop
{
    public partial class Form1 : Form
    {
        private string[,] tableItems = { };
        private int tableRows=0;
        public Form1()
        {
            populateListDropDown();
            InitializeComponent(tableItems, tableRows);
            comboBox1.SelectedIndex = 0;
        }
        private void populateListDropDown() 
        {
            //get dropdown items from txt file (no server) \CarShop\Items.txt
            string pwd = "C:\\Users\\gilbe\\OneDrive\\Desktop\\Scripts\\CarShop";
            
            string txtPath = pwd+"\\Items.txt";
            string[] lines = File.ReadAllLines(txtPath);
            int rows = lines.Count(), columns = 2;
            string[,] table= new string[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                var s = lines[i].Split("\t");
                table[i, 0] = s[0];
                table[i, 1] = s[1];
            }
            setTableItems(table, rows);
        }
        private void setTableItems(string[,] items, int rows) 
        {
            tableItems = items;
            tableRows = rows;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}