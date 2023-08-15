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
    public partial class FrmOrderDetails : Form
    {
        Repository repo = new Repository();
        public int orderId = 0;
        DataTable dtBasket = new DataTable();
        public FrmOrderDetails()
        {
            InitializeComponent();
        }
        //public DataTable GetOrderDetails()
        //{
        //    DataTable dt = repo.GetOrderDetails();
        //    dataGridView1.DataSource = dt;
        //}
        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetOrderDetails(orderId);

        }
       
        
    }
}
