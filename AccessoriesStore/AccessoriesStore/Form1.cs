
using System.Data;
using System.Data.SqlClient;

namespace AccessoriesStore

{

    public partial class Form1 : Form
    {
        Repository repo = new Repository();
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetOrders();
            
        }

        private void GetOrders()
        {
            string query = "SELECT [OrderID], o.[CustomerID], [CustomerName]+' '+[CustomerSurname] as Customer ,[OrderDate]" +
       " FROM[AccessoriesStoreDB].[dbo].[Orders] o inner join Customers on o.CustomerID = Customers.CustomerID where CONVERT(date, OrderDate)= CONVERT(date,'" + DateTime.Now.ToString("yyyy - MM - dd") + "')";
            DataTable dt = repo.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FrmOrders FrmOrders = new FrmOrders();
            FrmOrders.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int oId = (int)dataGridView1.CurrentRow.Cells["OrderID"].Value;

                FrmOrderDetails frmOrderDetails = new FrmOrderDetails();
                frmOrderDetails.orderId = oId;
                DataTable dt=repo.GetOrderDetails(oId);
                if (dt.Rows.Count>0)
                {
                    frmOrderDetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Order details have not been created.");
                }
              
            }
            else if (e.ColumnIndex == 1)
            {
                int oId = (int)dataGridView1.CurrentRow.Cells["OrderID"].Value;

                FrmOrders frmOrders = new FrmOrders();
                frmOrders.orderId = oId;
                frmOrders.ShowDialog();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            //using (SqlConnection connection = new SqlConnection(Properties.Resources.sqlConnString))
            {
                string query = "SELECT [OrderID], o.[CustomerID], [CustomerName]+' '+[CustomerSurname] as Customer ,[OrderDate]" +
         " FROM[AccessoriesStoreDB].[dbo].[Orders] o inner join Customers on o.CustomerID = Customers.CustomerID where CONVERT(date, OrderDate)= CONVERT(date,'" + dateTimePicker1.Value.ToString("yyyy - MM - dd") + "')";
                DataTable dt=repo.GetDataTable(query);
                if (dt.Rows.Count>0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Kayýt bulunamadý!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    command.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Value));
                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //    this.Close();
                //}
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetOrders();
        }
    }
}