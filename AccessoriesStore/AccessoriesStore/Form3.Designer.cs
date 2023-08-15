namespace AccessoriesStore
{
    partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxAddCategory = new System.Windows.Forms.PictureBox();
            this.pbxAddBrand = new System.Windows.Forms.PictureBox();
            this.pbxAddCompany = new System.Windows.Forms.PictureBox();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.nudUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(204, 262);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(199, 31);
            this.txtProductName.TabIndex = 20;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.Location = new System.Drawing.Point(16, 42);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(174, 28);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryName.Location = new System.Drawing.Point(21, 116);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(170, 28);
            this.lblCategoryName.TabIndex = 6;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(31, 267);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(159, 28);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Product Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitPrice.Location = new System.Drawing.Point(71, 339);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(115, 28);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitInStock.Location = new System.Drawing.Point(45, 414);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(144, 28);
            this.lblUnitInStock.TabIndex = 9;
            this.lblUnitInStock.Text = "Unit In Stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbxAddCategory);
            this.panel1.Controls.Add(this.pbxAddBrand);
            this.panel1.Controls.Add(this.pbxAddCompany);
            this.panel1.Controls.Add(this.pbxPhoto);
            this.panel1.Controls.Add(this.txtPhoto);
            this.panel1.Controls.Add(this.lblPhoto);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtMaterial);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblMaterial);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbBrandName);
            this.panel1.Controls.Add(this.lblBrandName);
            this.panel1.Controls.Add(this.nudUnitInStock);
            this.panel1.Controls.Add(this.cmbCategoryName);
            this.panel1.Controls.Add(this.cmbCompanyName);
            this.panel1.Controls.Add(this.nudUnitPrice);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblUnitInStock);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 844);
            this.panel1.TabIndex = 10;
            // 
            // pbxAddCategory
            // 
            this.pbxAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddCategory.Image")));
            this.pbxAddCategory.Location = new System.Drawing.Point(409, 116);
            this.pbxAddCategory.Name = "pbxAddCategory";
            this.pbxAddCategory.Size = new System.Drawing.Size(34, 33);
            this.pbxAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddCategory.TabIndex = 35;
            this.pbxAddCategory.TabStop = false;
            this.pbxAddCategory.Click += new System.EventHandler(this.pbxAddCategory_Click);
            // 
            // pbxAddBrand
            // 
            this.pbxAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddBrand.Image")));
            this.pbxAddBrand.Location = new System.Drawing.Point(409, 188);
            this.pbxAddBrand.Name = "pbxAddBrand";
            this.pbxAddBrand.Size = new System.Drawing.Size(34, 33);
            this.pbxAddBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddBrand.TabIndex = 34;
            this.pbxAddBrand.TabStop = false;
            this.pbxAddBrand.Click += new System.EventHandler(this.pbxAddBrand_Click);
            // 
            // pbxAddCompany
            // 
            this.pbxAddCompany.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddCompany.Image")));
            this.pbxAddCompany.Location = new System.Drawing.Point(409, 37);
            this.pbxAddCompany.Name = "pbxAddCompany";
            this.pbxAddCompany.Size = new System.Drawing.Size(34, 33);
            this.pbxAddCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddCompany.TabIndex = 33;
            this.pbxAddCompany.TabStop = false;
            this.pbxAddCompany.Click += new System.EventHandler(this.pbxAddCompany_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(470, 37);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(281, 294);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 32;
            this.pbxPhoto.TabStop = false;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(449, 414);
            this.txtPhoto.Multiline = true;
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(219, 40);
            this.txtPhoto.TabIndex = 31;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoto.Location = new System.Drawing.Point(449, 383);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(73, 28);
            this.lblPhoto.TabIndex = 30;
            this.lblPhoto.Text = "Photo";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(204, 713);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 118);
            this.txtDescription.TabIndex = 26;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(204, 644);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(199, 31);
            this.txtMaterial.TabIndex = 25;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(204, 570);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(199, 31);
            this.txtColor.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(55, 719);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 28);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterial.Location = new System.Drawing.Point(82, 646);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(100, 28);
            this.lblMaterial.TabIndex = 25;
            this.lblMaterial.Text = "Material";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(102, 572);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 28);
            this.lblColor.TabIndex = 24;
            this.lblColor.Text = "Color";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(88, 493);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(87, 28);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unisex"});
            this.cmbGender.Location = new System.Drawing.Point(204, 488);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(199, 33);
            this.cmbGender.TabIndex = 23;
            this.cmbGender.Text = "Select Gender";
            // 
            // cmbBrandName
            // 
            this.cmbBrandName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBrandName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(204, 188);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(199, 33);
            this.cmbBrandName.TabIndex = 19;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrandName.Location = new System.Drawing.Point(47, 193);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(140, 28);
            this.lblBrandName.TabIndex = 20;
            this.lblBrandName.Text = "Brand Name";
            // 
            // nudUnitInStock
            // 
            this.nudUnitInStock.Location = new System.Drawing.Point(204, 410);
            this.nudUnitInStock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudUnitInStock.Name = "nudUnitInStock";
            this.nudUnitInStock.Size = new System.Drawing.Size(199, 31);
            this.nudUnitInStock.TabIndex = 22;
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(204, 114);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(199, 33);
            this.cmbCategoryName.TabIndex = 18;
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(204, 37);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(199, 33);
            this.cmbCompanyName.TabIndex = 17;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(204, 335);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(199, 31);
            this.nudUnitPrice.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(612, 741);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 90);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(470, 741);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 90);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.Location = new System.Drawing.Point(674, 414);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(43, 40);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(776, 844);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtProductName;
        private Label lblCompanyName;
        private Label lblCategoryName;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblUnitInStock;
        private Panel panel1;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnUpload;
        private NumericUpDown nudUnitPrice;
        private ComboBox cmbCategoryName;
        private ComboBox cmbCompanyName;
        private NumericUpDown nudUnitInStock;
        private ComboBox cmbBrandName;
        private Label lblBrandName;
        private TextBox txtMaterial;
        private TextBox txtColor;
        private Label lblDescription;
        private Label lblMaterial;
        private Label lblColor;
        private Label lblGender;
        private ComboBox cmbGender;
        private TextBox txtDescription;
        private OpenFileDialog openFileDialog1;
        private TextBox txtPhoto;
        private Label lblPhoto;
        private PictureBox pbxPhoto;
        private PictureBox pbxAddCompany;
        private PictureBox pbxAddCategory;
        private PictureBox pbxAddBrand;
    }
}