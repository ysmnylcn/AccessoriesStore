namespace AccessoriesStore
{
    partial class FrmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBasketTotal = new System.Windows.Forms.Label();
            this.txtBasketTotal = new System.Windows.Forms.TextBox();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblBrands = new System.Windows.Forms.Label();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1357, 863);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 89);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblBasketTotal
            // 
            this.lblBasketTotal.AutoSize = true;
            this.lblBasketTotal.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBasketTotal.Location = new System.Drawing.Point(343, 872);
            this.lblBasketTotal.Name = "lblBasketTotal";
            this.lblBasketTotal.Size = new System.Drawing.Size(176, 33);
            this.lblBasketTotal.TabIndex = 12;
            this.lblBasketTotal.Text = "Basket Total :";
            // 
            // txtBasketTotal
            // 
            this.txtBasketTotal.BackColor = System.Drawing.Color.Lavender;
            this.txtBasketTotal.Location = new System.Drawing.Point(557, 876);
            this.txtBasketTotal.Name = "txtBasketTotal";
            this.txtBasketTotal.Size = new System.Drawing.Size(202, 31);
            this.txtBasketTotal.TabIndex = 17;
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToBasket.Location = new System.Drawing.Point(188, 314);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(134, 100);
            this.btnAddToBasket.TabIndex = 19;
            this.btnAddToBasket.Text = "Add To Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.dataGridView2.Location = new System.Drawing.Point(359, 459);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1142, 383);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Remove
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle1;
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 8;
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOrderId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.lblBrands);
            this.panel1.Controls.Add(this.cmbBrands);
            this.panel1.Controls.Add(this.btnAddToBasket);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.lblCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 429);
            this.panel1.TabIndex = 23;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderId.Location = new System.Drawing.Point(140, 32);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(99, 28);
            this.lblOrderId.TabIndex = 33;
            this.lblOrderId.Text = "Order Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Order ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 396);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(35, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 34);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(188, 192);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(134, 34);
            this.btnFind.TabIndex = 28;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrands.Location = new System.Drawing.Point(49, 123);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(85, 28);
            this.lblBrands.TabIndex = 27;
            this.lblBrands.Text = "Brands";
            // 
            // cmbBrands
            // 
            this.cmbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(140, 123);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(182, 33);
            this.cmbBrands.TabIndex = 26;
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(140, 73);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(182, 33);
            this.cmbCategories.TabIndex = 25;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.Location = new System.Drawing.Point(12, 73);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(122, 28);
            this.lblCategories.TabIndex = 24;
            this.lblCategories.Text = "Categories";
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1501, 964);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBasketTotal);
            this.Controls.Add(this.lblBasketTotal);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create An Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label lblBasketTotal;
        private TextBox txtBasketTotal;
        private Button btnAddToBasket;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Button btnClear;
        private Button btnFind;
        private Label lblBrands;
        private ComboBox cmbBrands;
        private ComboBox cmbCategories;
        private Label lblCategories;
        private DataGridView dataGridView1;
        private Label lblOrderId;
        private Label label1;
        private DataGridViewButtonColumn Remove;
    }
}