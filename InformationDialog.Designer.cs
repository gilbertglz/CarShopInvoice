namespace CarShop
{
    partial class InformationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            companyNameLabel = new Label();
            streetLabel = new Label();
            streetTwoLabel = new Label();
            invoiceLabel = new Label();
            dateLabel = new Label();
            dueDateLabel = new Label();
            billToLabel = new Label();
            customerLabel = new Label();
            customerStreetLabel = new Label();
            customerStreetTwoLabel = new Label();
            taxLabel = new Label();
            button1 = new Button();
            companyNameTextBox = new TextBox();
            streetTextBox = new TextBox();
            streetTwoTextBox = new TextBox();
            invoiceTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            customerStreetTextBox = new TextBox();
            customerStreetTwoTextBox = new TextBox();
            taxTextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            companyNameLabel.Location = new Point(6, 27);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(115, 19);
            companyNameLabel.TabIndex = 0;
            companyNameLabel.Text = "Company Name:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetLabel.Location = new Point(6, 69);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(63, 19);
            streetLabel.TabIndex = 1;
            streetLabel.Text = "Street 1:";
            // 
            // streetTwoLabel
            // 
            streetTwoLabel.AutoSize = true;
            streetTwoLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetTwoLabel.Location = new Point(6, 113);
            streetTwoLabel.Name = "streetTwoLabel";
            streetTwoLabel.Size = new Size(63, 19);
            streetTwoLabel.TabIndex = 2;
            streetTwoLabel.Text = "Street 2:";
            // 
            // invoiceLabel
            // 
            invoiceLabel.AutoSize = true;
            invoiceLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            invoiceLabel.Location = new Point(14, 30);
            invoiceLabel.Name = "invoiceLabel";
            invoiceLabel.Size = new Size(97, 19);
            invoiceLabel.TabIndex = 3;
            invoiceLabel.Text = "Invoice # INV:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(14, 72);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 19);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dueDateLabel.Location = new Point(14, 116);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(74, 19);
            dueDateLabel.TabIndex = 5;
            dueDateLabel.Text = "Due Date:";
            // 
            // billToLabel
            // 
            billToLabel.AutoSize = true;
            billToLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            billToLabel.Location = new Point(8, 30);
            billToLabel.Name = "billToLabel";
            billToLabel.Size = new Size(53, 19);
            billToLabel.TabIndex = 6;
            billToLabel.Text = "Bill To:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerLabel.Location = new Point(8, 62);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(117, 19);
            customerLabel.TabIndex = 7;
            customerLabel.Text = "Customer Name:";
            // 
            // customerStreetLabel
            // 
            customerStreetLabel.AutoSize = true;
            customerStreetLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerStreetLabel.Location = new Point(8, 95);
            customerStreetLabel.Name = "customerStreetLabel";
            customerStreetLabel.Size = new Size(63, 19);
            customerStreetLabel.TabIndex = 8;
            customerStreetLabel.Text = "Street 1:";
            // 
            // customerStreetTwoLabel
            // 
            customerStreetTwoLabel.AutoSize = true;
            customerStreetTwoLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerStreetTwoLabel.Location = new Point(8, 131);
            customerStreetTwoLabel.Name = "customerStreetTwoLabel";
            customerStreetTwoLabel.Size = new Size(63, 19);
            customerStreetTwoLabel.TabIndex = 9;
            customerStreetTwoLabel.Text = "Street 2:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taxLabel.Location = new Point(14, 62);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(112, 19);
            taxLabel.TabIndex = 10;
            taxLabel.Text = "Tax Percentage:";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(613, 373);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += submitButtonPrint;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            companyNameTextBox.Location = new Point(160, 27);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(184, 27);
            companyNameTextBox.TabIndex = 12;
            // 
            // streetTextBox
            // 
            streetTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetTextBox.Location = new Point(160, 69);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(184, 27);
            streetTextBox.TabIndex = 13;
            // 
            // streetTwoTextBox
            // 
            streetTwoTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            streetTwoTextBox.Location = new Point(160, 113);
            streetTwoTextBox.Name = "streetTwoTextBox";
            streetTwoTextBox.Size = new Size(184, 27);
            streetTwoTextBox.TabIndex = 14;
            // 
            // invoiceTextBox
            // 
            invoiceTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            invoiceTextBox.Location = new Point(151, 27);
            invoiceTextBox.Name = "invoiceTextBox";
            invoiceTextBox.Size = new Size(161, 27);
            invoiceTextBox.TabIndex = 15;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTextBox.Location = new Point(162, 59);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(184, 27);
            customerNameTextBox.TabIndex = 19;
            // 
            // customerStreetTextBox
            // 
            customerStreetTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerStreetTextBox.Location = new Point(162, 92);
            customerStreetTextBox.Name = "customerStreetTextBox";
            customerStreetTextBox.Size = new Size(184, 27);
            customerStreetTextBox.TabIndex = 20;
            // 
            // customerStreetTwoTextBox
            // 
            customerStreetTwoTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerStreetTwoTextBox.Location = new Point(162, 128);
            customerStreetTwoTextBox.Name = "customerStreetTwoTextBox";
            customerStreetTwoTextBox.Size = new Size(184, 27);
            customerStreetTwoTextBox.TabIndex = 21;
            // 
            // taxTextBox
            // 
            taxTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taxTextBox.Location = new Point(151, 57);
            taxTextBox.Name = "taxTextBox";
            taxTextBox.Size = new Size(97, 27);
            taxTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(streetTwoTextBox);
            groupBox1.Controls.Add(streetTextBox);
            groupBox1.Controls.Add(companyNameTextBox);
            groupBox1.Controls.Add(streetTwoLabel);
            groupBox1.Controls.Add(streetLabel);
            groupBox1.Controls.Add(companyNameLabel);
            groupBox1.Location = new Point(56, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 158);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Company Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(invoiceTextBox);
            groupBox2.Controls.Add(dueDateLabel);
            groupBox2.Controls.Add(dateLabel);
            groupBox2.Controls.Add(invoiceLabel);
            groupBox2.Location = new Point(462, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 158);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Invoice Information";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(151, 113);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(161, 27);
            dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(151, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(customerStreetTwoTextBox);
            groupBox3.Controls.Add(customerStreetTextBox);
            groupBox3.Controls.Add(customerNameTextBox);
            groupBox3.Controls.Add(customerStreetTwoLabel);
            groupBox3.Controls.Add(customerStreetLabel);
            groupBox3.Controls.Add(customerLabel);
            groupBox3.Controls.Add(billToLabel);
            groupBox3.Location = new Point(54, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(364, 176);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Information";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(taxTextBox);
            groupBox4.Controls.Add(taxLabel);
            groupBox4.Location = new Point(462, 176);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(318, 176);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tax Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 57);
            label1.Name = "label1";
            label1.Size = new Size(28, 27);
            label1.TabIndex = 23;
            label1.Text = "%";
            // 
            // InformationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 430);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "InformationDialog";
            Text = "Information Dialog";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label companyNameLabel;
        private Label streetLabel;
        private Label streetTwoLabel;
        private Label invoiceLabel;
        private Label dateLabel;
        private Label dueDateLabel;
        private Label billToLabel;
        private Label customerLabel;
        private Label customerStreetLabel;
        private Label customerStreetTwoLabel;
        private Label taxLabel;
        private Button button1;
        private TextBox companyNameTextBox;
        private TextBox streetTextBox;
        private TextBox streetTwoTextBox;
        private TextBox invoiceTextBox;
        private TextBox customerNameTextBox;
        private TextBox customerStreetTextBox;
        private TextBox customerStreetTwoTextBox;
        private TextBox taxTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}