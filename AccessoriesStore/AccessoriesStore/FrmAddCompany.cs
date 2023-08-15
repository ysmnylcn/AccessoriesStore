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
    public partial class FrmAddCompany : Form
    {
        Repository repo = new Repository();
        public int supplierId = 0;
        public FrmAddCompany()
        {
            InitializeComponent();
        }

        private void FrmAddCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("Please enter a Company Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtContactName.Text))
            {
                MessageBox.Show("Please enter a Contact Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(mbxPhone.Text))
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
                String query ="";
                string msgError = "";
                string msgSuccess = "";
                if (supplierId == 0)
                {
                    query = "INSERT INTO [dbo].[Suppliers] ([CompanyName], [ContactName], [Phone], [Address])" +
                    " VALUES (@cName, @contactName, @phone, @address)";
                    msgError = "Error inserting Supplier Information into Database";
                    msgSuccess = "The Supplier has been successfully added!";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cName", txtCompanyName.Text);
                    command.Parameters.AddWithValue("@contactName", txtContactName.Text);
                    command.Parameters.AddWithValue("@phone", mbxPhone.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);


                    if (supplierId != 0)
                    {
                        command.Parameters.AddWithValue("@sId", supplierId);
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
    }
}
