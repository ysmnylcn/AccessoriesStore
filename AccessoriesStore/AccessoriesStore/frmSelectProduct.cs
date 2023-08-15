using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccessoriesStore
{

    
    public partial class frmSelectProduct : Form
    {
        Repository repo = new Repository();
        public frmSelectProduct()
        {
            InitializeComponent();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            GetProducts();
            DataTable dtcategories = repo.GetCategories();
            DataRow dr = dtcategories.NewRow();
            dr[0] = 0;
            dr[1] = "Select Category";
            dtcategories.Rows.InsertAt(dr, 0);
            cmbCategories.DisplayMember = "CategoryName"; //kolon adi görüntülenecek
            cmbCategories.ValueMember = "CategoryID"; //arkaplanda saklanacak veri
            cmbCategories.DataSource = dtcategories.DefaultView;

            DataTable dtbrands = repo.GetBrands();
            DataRow dr2 = dtbrands.NewRow();
            dr2[0] = 0;
            dr2[1] = "Select Brand";
            dtbrands.Rows.InsertAt(dr2, 0);
            cmbBrands.DisplayMember = "BrandName"; //kolon adi görüntülenecek
            cmbBrands.ValueMember = "BrandID"; //arkaplanda saklanacak veri
            cmbBrands.DataSource = dtbrands.DefaultView;

        }
        private void GetProducts()
        {
            DataTable dt = repo.GetProduts();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int productId = 0;
                int pId = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;

                FrmDetails FrmDetails = new FrmDetails();
                FrmDetails.productId = pId;
                FrmDetails.ShowDialog();

            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCategories.SelectedValue) == 0 && Convert.ToInt32(cmbBrands.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select Category or Brand!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "Select ProductID, BrandName, ProductName,UnitInStock,UnitPrice,s.CompanyName,c.CategoryName " +
            " From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s " +
            " on p.SupplierID = s.SupplierID inner join Brands on brands.BrandID = p.BrandID where 0 = 0";
            if (Convert.ToInt32(cmbCategories.SelectedValue) > 0)
            {
                query += " and p.CategoryID=" + Convert.ToInt32(cmbCategories.SelectedValue);
            }
            if (Convert.ToInt32(cmbBrands.SelectedValue) > 0)
            {
                query += " and p.BrandID=" + cmbBrands.SelectedValue;
            }
            DataTable dt2 = repo.GetProductsByQuery(query);
            dataGridView1.DataSource = dt2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBrands.SelectedIndex = 0;
            cmbCategories.SelectedIndex = 0;
           
            DataTable dt = repo.GetProduts();
            dataGridView1.DataSource = dt;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
