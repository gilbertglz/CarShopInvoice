namespace CarShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            addItem = new Button();
            Total = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Print = new Button();
            subtotalLabel = new Label();
            totalLabel = new Label();
            subtotalDoubleLabel = new Label();
            taxDoubleLabel = new Label();
            totalDoubleLabel = new Label();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Item Not On List" });
            comboBox1.Location = new Point(50, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 27);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(11, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 27);
            textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(67, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 57);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select an item:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(271, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(158, 57);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter Quantity:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(435, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(158, 56);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Enter Price per Item:";
            // 
            // addItem
            // 
            addItem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addItem.Location = new Point(626, 48);
            addItem.Name = "addItem";
            addItem.Size = new Size(81, 25);
            addItem.TabIndex = 6;
            addItem.Text = "Add Item";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Item
            // 
            Item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item.HeaderText = "Item";
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Resizable = DataGridViewTriState.False;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, Price, Total });
            dataGridView1.Location = new Point(71, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(679, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += deleteRow;
            // 
            // Print
            // 
            Print.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Print.Location = new Point(629, 575);
            Print.Name = "Print";
            Print.Size = new Size(115, 39);
            Print.TabIndex = 10;
            Print.Text = "Submit To Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += print_Click;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtotalLabel.Location = new Point(495, 434);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(103, 29);
            subtotalLabel.TabIndex = 11;
            subtotalLabel.Text = "Subtotal:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.Location = new Point(495, 512);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(68, 29);
            totalLabel.TabIndex = 13;
            totalLabel.Text = "Total:";
            // 
            // subtotalDoubleLabel
            // 
            subtotalDoubleLabel.AutoSize = true;
            subtotalDoubleLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtotalDoubleLabel.Location = new Point(661, 434);
            subtotalDoubleLabel.Name = "subtotalDoubleLabel";
            subtotalDoubleLabel.Size = new Size(55, 29);
            subtotalDoubleLabel.TabIndex = 14;
            subtotalDoubleLabel.Text = "0.00";
            subtotalDoubleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taxDoubleLabel
            // 
            taxDoubleLabel.AutoSize = true;
            taxDoubleLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            taxDoubleLabel.Location = new Point(661, 473);
            taxDoubleLabel.Name = "taxDoubleLabel";
            taxDoubleLabel.Size = new Size(55, 29);
            taxDoubleLabel.TabIndex = 15;
            taxDoubleLabel.Text = "0.00";
            taxDoubleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalDoubleLabel
            // 
            totalDoubleLabel.AutoSize = true;
            totalDoubleLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            totalDoubleLabel.Location = new Point(661, 512);
            totalDoubleLabel.Name = "totalDoubleLabel";
            totalDoubleLabel.Size = new Size(55, 29);
            totalDoubleLabel.TabIndex = 16;
            totalDoubleLabel.Text = "0.00";
            totalDoubleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(495, 473);
            button1.Name = "button1";
            button1.Size = new Size(68, 36);
            button1.TabIndex = 17;
            button1.Text = "Tax:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += taxChangeButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 478);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 18;
            label1.Text = "Tax Set to: 8.25%";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 648);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(totalDoubleLabel);
            Controls.Add(taxDoubleLabel);
            Controls.Add(subtotalDoubleLabel);
            Controls.Add(totalLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(Print);
            Controls.Add(addItem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Generator";
            FormClosed += MainFormClose;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button addItem;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Item;
        private DataGridView dataGridView1;
        private Button Print;
        private Label subtotalLabel;
        private Label totalLabel;
        private Label subtotalDoubleLabel;
        private Label taxDoubleLabel;
        private Label totalDoubleLabel;
        private Button button1;
        private Label label1;
    }
}