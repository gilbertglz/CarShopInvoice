namespace CarShop
{
    partial class InputDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputDialog = new System.Windows.Forms.TextBox();
            this.submitInputDialog = new System.Windows.Forms.Button();
            this.cancelInputDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Item";
            // 
            // txtInputDialog
            // 
            this.txtInputDialog.BackColor = System.Drawing.SystemColors.Window;
            this.txtInputDialog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputDialog.Location = new System.Drawing.Point(12, 53);
            this.txtInputDialog.Name = "txtInputDialog";
            this.txtInputDialog.Size = new System.Drawing.Size(302, 27);
            this.txtInputDialog.TabIndex = 1;
            // 
            // submitInputDialog
            // 
            this.submitInputDialog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitInputDialog.Location = new System.Drawing.Point(35, 86);
            this.submitInputDialog.Name = "submitInputDialog";
            this.submitInputDialog.Size = new System.Drawing.Size(79, 33);
            this.submitInputDialog.TabIndex = 2;
            this.submitInputDialog.Text = "Submit";
            this.submitInputDialog.UseVisualStyleBackColor = true;
            this.submitInputDialog.Click += new System.EventHandler(this.submitInputDialog_Click);
            // 
            // cancelInputDialog
            // 
            this.cancelInputDialog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInputDialog.Location = new System.Drawing.Point(216, 86);
            this.cancelInputDialog.Name = "cancelInputDialog";
            this.cancelInputDialog.Size = new System.Drawing.Size(79, 33);
            this.cancelInputDialog.TabIndex = 3;
            this.cancelInputDialog.Text = "Cancel";
            this.cancelInputDialog.UseVisualStyleBackColor = true;
            // 
            // InputDialog
            // 
            this.AcceptButton = this.submitInputDialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelInputDialog;
            this.ClientSize = new System.Drawing.Size(326, 143);
            this.Controls.Add(this.cancelInputDialog);
            this.Controls.Add(this.submitInputDialog);
            this.Controls.Add(this.txtInputDialog);
            this.Controls.Add(this.label1);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input New Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputDialog_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtInputDialog;
        private Button submitInputDialog;
        private Button cancelInputDialog;
    }
}