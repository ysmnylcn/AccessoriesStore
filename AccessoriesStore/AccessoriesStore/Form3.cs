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
    public partial class FrmAdd : Form
    {
        Repository repo = new Repository();
        public int productId = 0;
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            GetSuppliers();

            getbrands();
            getcategories();
            
            if (productId != 0)
            {
                DataTable dtProduct = repo.GetProdutsByProductID(productId);
                txtProductName.Text = dtProduct.Rows[0]["ProductName"].ToString();
                txtColor.Text = dtProduct.Rows[0]["Color"].ToString();
                txtMaterial.Text = dtProduct.Rows[0]["Material"].ToString();
                txtDescription.Text = dtProduct.Rows[0]["Description"].ToString();
                cmbCompanyName.SelectedValue = dtProduct.Rows[0]["SupplierID"].ToString();
                cmbCategoryName.SelectedValue = dtProduct.Rows[0]["CategoryID"].ToString();
                cmbBrandName.SelectedValue = dtProduct.Rows[0]["BrandID"].ToString();
                cmbGender.SelectedItem = dtProduct.Rows[0]["Gender"].ToString();
                nudUnitInStock.Value = (Int16)dtProduct.Rows[0]["UnitInStock"];
                nudUnitPrice.Value = (decimal)dtProduct.Rows[0]["UnitPrice"];
                pbxPhoto.ImageLocation = dtProduct.Rows[0]["Picture"].ToString();
                txtPhoto.Text = dtProduct.Rows[0]["Picture"].ToString();
                //pcbProductPhoto.Visible = false;


                this.Text = "Update Product";
                btnAdd.Text = "Update";
            }
        }

        private void GetSuppliers()
        {
            DataTable dtsuppliers = repo.GetSuppliers();
            DataRow dr1 = dtsuppliers.NewRow();
            dr1[0] = 0;
            dr1[1] = "Select Company";
            dtsuppliers.Rows.InsertAt(dr1, 0);
            cmbCompanyName.DisplayMember = "CompanyName"; //kolon adi görüntülenecek
            cmbCompanyName.ValueMember = "SupplierID"; //arkaplanda saklanacak veri
            cmbCompanyName.DataSource = dtsuppliers.DefaultView;
        }

        private void getcategories()
        {
            DataTable dt = repo.GetProduts();
            DataTable dtcategories = repo.GetCategories();
            DataRow dr = dtcategories.NewRow();
            dr[0] = 0;
            dr[1] = "Select Category";
            dtcategories.Rows.InsertAt(dr, 0);
            cmbCategoryName.DisplayMember = "CategoryName"; //kolon adi görüntülenecek
            cmbCategoryName.ValueMember = "CategoryID"; //arkaplanda saklanacak veri
            cmbCategoryName.DataSource = dtcategories.DefaultView;
        }
        private void getbrands()
        {
            DataTable dtbrands = repo.GetBrands();
            DataRow dr2 = dtbrands.NewRow();
            dr2[0] = 0;
            dr2[1] = "Select Brand";
            dtbrands.Rows.InsertAt(dr2, 0);
            cmbBrandName.DisplayMember = "BrandName"; //kolon adi görüntülenecek
            cmbBrandName.ValueMember = "BrandID"; //arkaplanda saklanacak veri
            cmbBrandName.DataSource = dtbrands.DefaultView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCompanyName.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select Company", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(cmbCategoryName.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(cmbBrandName.SelectedValue) == 0)
            {
                MessageBox.Show("Please Select a Brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter Product name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Convert.ToInt32(nudUnitPrice.Value) == 0)
            {
                MessageBox.Show("Please enter Unit price value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(nudUnitInStock.Value) == 0)
            {
                MessageBox.Show("Please enter Unit in stock value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGender.Text == "Select Gender")
            {
                MessageBox.Show("Please Select gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("Please enter Color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtMaterial.Text))
            {
                MessageBox.Show("Please enter Material", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please type description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
            {
                String query = "";
                string msgError = "";
                string msgSuccess = "";
                if (productId == 0)
                {
                    query = "INSERT INTO [dbo].[Products] ([ProductName], [BrandID], [UnitInStock], [SupplierID], [UnitPrice]," +
                    " [CategoryID], [Gender], [Color], [Material], [Description], [Picture]) VALUES (@pName, @bId, @uInStock, @sId," +
                    " @uPrice, @cId, @gender, @color, @material, @description, @picture)";
                    msgError = "Error inserting data into Database!";
                    msgSuccess = "The product has been successfully added!";
                }
                else
                {
                    query = "Update Products Set [ProductName] = @pName, [BrandID] = @bID, [UnitInStock] = @uInStock, [SupplierID] = @sId," +
                        " [UnitPrice] = @uPrice, [CategoryID] = @cId, [Gender] = @gender, [Color] = @color ,[Material] = @material ," +
                        " [Description] =  @description, [Picture] = @picture Where ProductID = @pId";
                    msgError = "Error updating data into Database!";
                    msgSuccess = "The product has been successfully updated!";
                }



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pName", txtProductName.Text);
                    command.Parameters.AddWithValue("@bId", Convert.ToInt32(cmbBrandName.SelectedValue));
                    command.Parameters.AddWithValue("@uInStock", Convert.ToInt32(nudUnitInStock.Value));
                    command.Parameters.AddWithValue("@sId", Convert.ToInt32(cmbCompanyName.SelectedValue));
                    command.Parameters.AddWithValue("@uPrice", Convert.ToInt32(nudUnitPrice.Value));
                    command.Parameters.AddWithValue("@cId", Convert.ToInt32(cmbCategoryName.SelectedValue));
                    command.Parameters.AddWithValue("@gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@color", txtColor.Text);
                    command.Parameters.AddWithValue("@material", txtMaterial.Text);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.Parameters.AddWithValue("@picture", txtPhoto.Text);

                    if (productId != 0)
                    {
                        command.Parameters.AddWithValue("@pId", productId);
                    }

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(msgSuccess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        this.Close();
                    }
                }
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbxPhoto.ImageLocation = openFileDialog1.FileName;
            txtPhoto.Text = openFileDialog1.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pbxAddCategory_Click(object sender, EventArgs e)
        {
            if (cmbCategoryName.SelectedIndex == -1 && !string.IsNullOrEmpty(cmbCategoryName.Text))
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES (@categoryName)", connection);
                command.Parameters.AddWithValue("@categoryName", cmbCategoryName.Text);
                try
                {
                    command.ExecuteNonQuery();
                    getcategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Existing record cannot be added.\nCategory Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void pbxAddBrand_Click(object sender, EventArgs e)
        {
            if (cmbBrandName.SelectedIndex == -1 && !string.IsNullOrEmpty(cmbBrandName.Text))
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Brands] ([BrandName]) VALUES (@brandName)", connection);
                command.Parameters.AddWithValue("@brandName", cmbBrandName.Text);
                try
                {
                    command.ExecuteNonQuery();
                    getbrands();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Existing record cannot be added.\nBrand Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void pbxAddCompany_Click(object sender, EventArgs e)
        {
            FrmAddCompany FrmAddCompany = new FrmAddCompany();
            FrmAddCompany.ShowDialog();
            GetSuppliers();
        }
    }
}
