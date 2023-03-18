namespace CarShop
{
    public partial class InputDialog : Form
    {
        public MainForm MainForm;
        public string Item;
        public InputDialog(MainForm referenceMain)
        {
            MainForm = referenceMain;
            InitializeComponent();
        }
        private void InputDialog_Close(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }
        private void setNewItem(string newItem)
        {
            this.Item = newItem;
        }
        public string getNewItem()
        {
            return this.Item;
        }
        private void submitInputDialog_Click(object sender, EventArgs e)
        {
            var itemInput = this.txtInputDialog.Text.Trim();
            if (itemInput.Length == 0)
            {
                InputDialog_Close(sender, e);
            }
            else
            {
                setNewItem(itemInput);
                InputDialog_Close(sender, e);
            }
        }
    }
}
