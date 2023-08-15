namespace AccessoriesStore
{
    partial class frmSelectProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectProduct));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.lblBrands = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(989, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Details
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            this.Details.DefaultCellStyle = dataGridViewCellStyle1;
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 8;
            this.Details.Name = "Details";
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.Location = new System.Drawing.Point(12, 12);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(122, 28);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Categories";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(140, 12);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(182, 33);
            this.cmbCategories.TabIndex = 2;
            // 
            // cmbBrands
            // 
            this.cmbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(140, 69);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(182, 33);
            this.cmbBrands.TabIndex = 3;
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrands.Location = new System.Drawing.Point(49, 69);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(85, 28);
            this.lblBrands.TabIndex = 4;
            this.lblBrands.Text = "Brands";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(374, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 34);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(859, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 70);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(374, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblBrands);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectProduct";
            this.Text = "Select Product";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblCategories;
        private ComboBox cmbCategories;
        private ComboBox cmbBrands;
        private Label lblBrands;
        private Button btnFind;
        private Button btnSelect;
        private Button btnClear;
        private DataGridViewButtonColumn Details;
    }
}