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

    public partial class FrmOrders : Form
    {
        Repository repo = new Repository();
        public int orderId = 0;
        DataTable dtBasket = new DataTable();
        public FrmOrders()
        {
            dtBasket.Columns.Add("ProductId", typeof(int));
            dtBasket.Columns.Add("ProductName", typeof(string));
            dtBasket.Columns.Add("UnitPrice", typeof(decimal));
            dtBasket.Columns.Add("Quantity", typeof(int));
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            

            lblOrderId.Text = orderId.ToString();
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

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[4].Width = 100;
            //dataGridView2.Columns[2].Width = 100;
            //dataGridView2.Columns[1].Width = 100;
            //dataGridView2.Columns[4].Width = 100;

        }
        DataTable dtProducts;
        private void GetProducts()
        {
            dtProducts = repo.GetProduts();
            dataGridView1.DataSource = dtProducts;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataTable dt2 = repo.GetProduts();
            dataGridView2.Rows.Add(dt2);

            //dataGridView2.Columns[1].Width = 110;
            //dataGridView2.Columns[5].Width = 110;

            //dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void GetOrders()
        {
            DataTable dt = repo.GetOrders();
            dataGridView1.DataSource = dt;
        }
        private decimal CalculateBasketTotalValue()
        {
            decimal totalValue = 0;

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                decimal total = Convert.ToInt32(dr.Cells[4].Value) * Convert.ToDecimal(dr.Cells[3].Value);
                totalValue += total;
            }
            return totalValue;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow dr = dataGridView2.Rows[e.RowIndex];
                DataGridViewRow dr1 = dataGridView1.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString() == dr.Cells[1].Value.ToString()).FirstOrDefault();
                if (Convert.ToInt32(dr.Cells[4].Value) == 1)
                {
                    dr1.Cells[4].Value = Convert.ToInt32(dr1.Cells[4].Value) + 1;
                    dataGridView2.Rows.RemoveAt(e.RowIndex);

                }
                else
                {
                    dr1.Cells[4].Value = Convert.ToInt32(dr1.Cells[4].Value) + 1;
                    dr.Cells[4].Value = Convert.ToInt32(dr.Cells[4].Value) - 1;
                }
                decimal total = CalculateBasketTotalValue();
                txtBasketTotal.Text = total.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCategories.SelectedValue) == 0 && Convert.ToInt32(cmbBrands.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select Category or Brand!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //string query = "Select ProductID, ProductName,BrandName,c.CategoryName,UnitInStock,UnitPrice,s.CompanyName " +
            //" From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s " +
            //" on p.SupplierID = s.SupplierID inner join Brands on brands.BrandID = p.BrandID where 0 = 0";
            
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            string searchQuery = "";
            if (Convert.ToInt32(cmbCategories.SelectedValue) > 0)
            {
                searchQuery = dataGridView1.Columns["CategoryName"].HeaderText.ToString() + " = '" + cmbCategories.Text + "'";
                bs.Filter = searchQuery;
                //query += " and p.CategoryID=" + Convert.ToInt32(cmbCategories.SelectedValue);
            }
            if (Convert.ToInt32(cmbBrands.SelectedValue) > 0)
            {
                if (string.IsNullOrEmpty(searchQuery))
                {
                    searchQuery = dataGridView1.Columns["BrandName"].HeaderText.ToString() + " = '" + cmbBrands.Text + "'";
                }
                else
                {
                    searchQuery +=" and " + dataGridView1.Columns["BrandName"].HeaderText.ToString() + " = '" + cmbBrands.Text + "'";
                }
                
                bs.Filter = searchQuery; 
                //query += " and p.BrandID=" + cmbBrands.SelectedValue;
            }
            //DataTable dt2 = repo.GetProductsByQuery(query);
            dataGridView1.DataSource = bs;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSearchFilter();

        }

        private void ClearSearchFilter()
        {
            cmbBrands.SelectedIndex = 0;
            cmbCategories.SelectedIndex = 0;
            dataGridView1.DataSource = dtProducts;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {

                int productId = Convert.ToInt32(dr.Cells[1].Value);
                DataTable dtProduct = repo.GetProdutsByProductID(productId);
                int unitInStock = Convert.ToInt32(dtProduct.Rows[0]["UnitInStock"]);
                decimal unitPrice = Convert.ToDecimal(dr.Cells[3].Value);
                int quantity = Convert.ToInt32(dr.Cells[4].Value);
                using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
                {
                    SqlTransaction myTransaction = null;
                    try
                    {
                        connection.Open();
                        myTransaction = connection.BeginTransaction();
                        String query = "";
                        String query2 = "";

                        query = "INSERT INTO [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES " +
                            " (@orderid, @productid, @unitPrice, @quantity)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@orderid", orderId);
                        command.Parameters.AddWithValue("@productid", productId);
                        command.Parameters.AddWithValue("@unitPrice", unitPrice);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Transaction = myTransaction;
                        query2 = "Update [Products] Set [UnitInStock] = @unitInStock Where [ProductID] = @productid";

                        SqlCommand command2 = new SqlCommand(query2, connection);
                        command2.Parameters.AddWithValue("@productid", productId);
                        command2.Parameters.AddWithValue("@unitInStock", unitInStock - quantity);
                        command2.Transaction = myTransaction;
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        myTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Nedeni ile işlmeler iptal edildi");
                        myTransaction.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                        MessageBox.Show("The order has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) > 0)
                {
                    bool varMı = dtBasket.Select().ToList().Exists(v => v[0].ToString() == row.Cells[0].Value.ToString());
                    if (varMı)
                    {
                        DataRow dataRow = dtBasket.Select().ToList().Where(v => v[0].ToString() == row.Cells[0].Value.ToString()).FirstOrDefault();
                        dataRow[3] = Convert.ToInt32(dataRow[3]) + 1;
                        row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value.ToString()) - 1;
                    }
                    else
                    {
                        DataRow dr = dtBasket.NewRow();
                        dr[0] = row.Cells[0].Value;
                        dr[1] = row.Cells[1].Value;
                        dr[2] = row.Cells[5].Value;
                        dr[3] = 1;
                        dtBasket.Rows.Add(dr);
                        row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value.ToString()) - 1;
                    }
                }
                else
                {
                    MessageBox.Show(row.Cells[1].Value.ToString() + " product is out of stock.");
                }

            }
            dataGridView2.DataSource = dtBasket;
            decimal total = CalculateBasketTotalValue();
            txtBasketTotal.Text = total.ToString();
            //ClearSearchFilter();
        }

    }
}
