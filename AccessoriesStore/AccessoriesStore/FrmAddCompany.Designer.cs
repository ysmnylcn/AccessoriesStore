namespace AccessoriesStore
{
    partial class FrmAddCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCompany));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.mbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(25, 88);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(185, 28);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name :";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(43, 154);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(167, 28);
            this.lblContactName.TabIndex = 2;
            this.lblContactName.Text = "Contact Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(122, 227);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 28);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(104, 294);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(106, 28);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(220, 85);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(282, 36);
            this.txtCompanyName.TabIndex = 5;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(220, 154);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(282, 36);
            this.txtContactName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(220, 294);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(282, 91);
            this.txtAddress.TabIndex = 8;
            // 
            // mbxPhone
            // 
            this.mbxPhone.Location = new System.Drawing.Point(220, 227);
            this.mbxPhone.Mask = "(999) 000-0000";
            this.mbxPhone.Name = "mbxPhone";
            this.mbxPhone.Size = new System.Drawing.Size(282, 36);
            this.mbxPhone.TabIndex = 7;
            // 
            // FrmAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(583, 504);
            this.Controls.Add(this.mbxPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Company";
            this.Load += new System.EventHandler(this.FrmAddCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label lblCompanyName;
        private Label lblContactName;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtAddress;
        private MaskedTextBox mbxPhone;
    }
}