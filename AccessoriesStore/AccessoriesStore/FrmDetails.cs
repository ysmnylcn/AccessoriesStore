using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessoriesStore
{
    public partial class FrmDetails : Form
    {
        Repository repo = new Repository();
        public int productId = 0;
        public FrmDetails()
        {
            InitializeComponent();
        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {
            DataTable dtProduct = repo.GetProdutsByProductID(productId);
            label11.Text = dtProduct.Rows[0]["SupplierID"].ToString();
            label12.Text = dtProduct.Rows[0]["CategoryID"].ToString();
            label13.Text = dtProduct.Rows[0]["BrandID"].ToString();
            label14.Text = dtProduct.Rows[0]["ProductName"].ToString();
            label15.Text = dtProduct.Rows[0]["UnitPrice"].ToString();
            label16.Text = dtProduct.Rows[0]["UnitInStock"].ToString();
            label17.Text = dtProduct.Rows[0]["Gender"].ToString();
            label18.Text = dtProduct.Rows[0]["Color"].ToString();
            label19.Text = dtProduct.Rows[0]["Material"].ToString();
            label20.Text = dtProduct.Rows[0]["Description"].ToString();
            pbxPhoto.ImageLocation = dtProduct.Rows[0]["Picture"].ToString();
            pbxPhoto.Text = dtProduct.Rows[0]["Picture"].ToString();
        }
    }
}
