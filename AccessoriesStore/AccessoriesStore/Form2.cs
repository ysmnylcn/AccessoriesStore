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
    public partial class frmProduct : Form
    {
        Repository repo = new Repository();
        public frmProduct()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCategories.SelectedValue) == 0 && Convert.ToInt32(cmbSuppliers.SelectedValue) == 0
                && Convert.ToInt32(cmbBrands.SelectedValue) == 0 && String.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Select Category, Supplier or Brand or type Product Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "Select ProductID, BrandName, ProductName,UnitInStock,UnitPrice,s.CompanyName,c.CategoryName " +
            " From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s " +
            " on p.SupplierID = s.SupplierID inner join Brands on brands.BrandID = p.BrandID where 0 = 0";
            if (Convert.ToInt32(cmbCategories.SelectedValue) > 0)
            {
                query += " and p.CategoryID=" + Convert.ToInt32(cmbCategories.SelectedValue);
            }
            if (Convert.ToInt32(cmbSuppliers.SelectedValue) > 0)
            {
                query += " and s.SupplierID=" + cmbSuppliers.SelectedValue;
            }
            if (Convert.ToInt32(cmbBrands.SelectedValue) > 0)
            {
                query += " and p.BrandID=" + cmbBrands.SelectedValue;
            }
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                query += " and ProductName  like '%" + txtSearch.Text + "%'";
            }
            
            DataTable dt2 = repo.GetProductsByQuery(query);
            dataGridView1.DataSource = dt2;
        }
        
        private void Form2_Load(object sender, EventArgs e)
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


            GetSuppliers();

            DataTable dtbrands = repo.GetBrands();
            DataRow dr2 = dtbrands.NewRow();
            dr2[0] = 0;
            dr2[1] = "Select Brand";
            dtbrands.Rows.InsertAt(dr2, 0);
            cmbBrands.DisplayMember = "BrandName"; //kolon adi görüntülenecek
            cmbBrands.ValueMember = "BrandID"; //arkaplanda saklanacak veri
            cmbBrands.DataSource = dtbrands.DefaultView;
        }

        private void GetSuppliers()
        {
            DataTable dtsuppliers = repo.GetSuppliers();
            DataRow dr1 = dtsuppliers.NewRow();
            dr1[0] = 0;
            dr1[1] = "Select Supplier";
            dtsuppliers.Rows.InsertAt(dr1, 0);
            cmbSuppliers.DisplayMember = "CompanyName"; //kolon adi görüntülenecek
            cmbSuppliers.ValueMember = "SupplierID"; //arkaplanda saklanacak veri
            cmbSuppliers.DataSource = dtsuppliers.DefaultView;
        }

        private void GetProducts()
        {
            DataTable dt = repo.GetProduts();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 400;
            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd FrmAdd = new FrmAdd();
            FrmAdd.productId = 0;
            FrmAdd.ShowDialog();
            DataTable dt = repo.GetProduts();
            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {


                int pId = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
               
                FrmAdd FrmAdd = new FrmAdd();
                FrmAdd.productId = pId;
                FrmAdd.ShowDialog();
                DataTable dt = repo.GetProduts();
                dataGridView1.DataSource = dt;
            }
            if (e.ColumnIndex == 1)
            {
                string pName = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure you want to delete the " + pName + " product?", "Warning", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int pId = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
                    using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
                    {
                        String querydelete = "DELETE FROM Products WHERE ProductID = @productid";

                        using (SqlCommand command = new SqlCommand(querydelete, connection))
                        {
                            command.Parameters.AddWithValue("@productid", pId);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result > 0)
                            {
                                MessageBox.Show("The product has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("Error deleting data from  Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                }
               

            }
            if (e.ColumnIndex == 2)
            {
                int productId = 0;
                int pId = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;

                FrmDetails FrmDetails = new FrmDetails();
                FrmDetails.productId = pId;
                FrmDetails.ShowDialog();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbBrands.SelectedIndex = 0;
            cmbCategories.SelectedIndex = 0;
            cmbSuppliers.SelectedIndex = 0;

            DataTable dt = repo.GetProduts();
            dataGridView1.DataSource = dt;
        }

    }
}
