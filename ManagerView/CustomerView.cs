using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerView
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*TestContext context = new TestContext();
            var productbrand = context.Product_Brand.ToList();
            dgvBrand.DataSource = productbrand.ToList();
            dgvBrand.Refresh();*/
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            TestContext context = new TestContext();
            var productbrand = context.Product_Brand.ToList();
            dgvBrand.DataSource = productbrand.ToList();
            dgvBrand.Refresh();
        }
    }
}
