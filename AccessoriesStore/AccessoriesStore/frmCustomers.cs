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
    public partial class frmCustomers : Form
    {
        Repository repo = new Repository();
        public int customerId = 0;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }
        private void GetCustomers()
        {
            DataTable dt = repo.GetCustomers();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 300;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCustomer FrmAddCustomer = new FrmAddCustomer();
            FrmAddCustomer.customerId = 0;
            FrmAddCustomer.ShowDialog();
            DataTable dt = repo.GetCustomers();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {


                int cId = (int)dataGridView1.CurrentRow.Cells["CustomerID"].Value;

                FrmAddCustomer FrmAddCustomer = new FrmAddCustomer();
                FrmAddCustomer.customerId = cId;
                FrmAddCustomer.ShowDialog();
                DataTable dt = repo.GetCustomers();
                dataGridView1.DataSource = dt;
            }
            if (e.ColumnIndex == 1)
            {
                string cName = dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure you want to delete the customer " + cName + "?", "Warning", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int cId = (int)dataGridView1.CurrentRow.Cells["CustomerID"].Value;
                    using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
                    {
                        String querydelete = "DELETE FROM Customers WHERE CustomerID = @customerId";

                        using (SqlCommand command = new SqlCommand(querydelete, connection))
                        {
                            command.Parameters.AddWithValue("@customerId", cId);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result > 0)
                            {
                                MessageBox.Show("The Customer has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("Error deleting customer from  Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                int customerID = (int)dataGridView1.CurrentRow.Cells["CustomerID"].Value;
                using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
                {
                    String query = "";
                    if (customerID != 0)
                    {
                        query = "INSERT INTO [dbo].[Orders] ([CustomerID],[OrderDate]) VALUES (@customerID,@orderDate)";
                        
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cId",Convert.ToInt32(customerID));
                        if (customerID != 0)
                        {
                            command.Parameters.AddWithValue("@customerId", customerID);
                            command.Parameters.AddWithValue("@orderDate", DateTime.Now);
                        }
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result > 0)
                        {
                            MessageBox.Show("The order has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                        
                        else
                        {
                            MessageBox.Show("Error inserting data into Database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            this.Close();
                        }
                    }
                }
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
             txtCustomerName.Clear();
            
            DataTable dt = repo.GetCustomers();
            dataGridView1.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String query = "Select * From Customers where 0 = 0";
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                query += " and CustomerName  like '%" + txtCustomerName.Text + "%'";
            }
            DataTable dt2 = repo.GetCustomersByQuery(query);
            dataGridView1.DataSource = dt2;
        }
    }
}
