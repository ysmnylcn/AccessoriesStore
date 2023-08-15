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
    public partial class FrmAddCustomer : Form
    {
        Repository repo = new Repository();
        public int customerId = 0;
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                DataTable dtcustomers = repo.GetCustomersByCustomerID(customerId);
                txtName.Text = dtcustomers.Rows[0]["CustomerName"].ToString();
                txtSurname.Text = dtcustomers.Rows[0]["CustomerSurname"].ToString();
                maskbxPhone.Text = dtcustomers.Rows[0]["Phone"].ToString();
                txtAddress.Text = dtcustomers.Rows[0]["Address"].ToString();

                this.Text = "Update Custome";
                btnAdd.Text = "Update";
            }    
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Please enter a Surname!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskbxPhone.Text))
            {
                MessageBox.Show("Please enter a Phone number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
            {
                String query = "";
                string msgError = "";
                string msgSuccess = "";
                if (customerId == 0)
                {
                    query = "INSERT INTO [dbo].[Customers] ([CustomerName], [CustomerSurname], [Phone], [Address])" +
                    " VALUES (@cName, @cSurname, @phone, @address)";
                    msgError = "Error inserting Customer Information into Database";
                    msgSuccess = "The Customer has been successfully added!";
                }
                else
                {
                    query = "UPDATE Customers SET [CustomerName] = @cName, [CustomerSurname] = @cSurname, [Phone] = @phone," +
                        " [Address] = @address Where CustomerID = @cId";
                    msgError = "Error updating Customer Information into Database";
                    msgSuccess = "The Customer has been successfully updated!";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cName", txtName.Text);
                    command.Parameters.AddWithValue("@cSurname", txtSurname.Text);
                    command.Parameters.AddWithValue("@phone", maskbxPhone.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);


                    if (customerId != 0)
                    {
                        command.Parameters.AddWithValue("@cId", customerId);
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
}   }
