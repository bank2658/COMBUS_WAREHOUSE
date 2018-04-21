using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUS_APP.Master_Form
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = " Rack/Product";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == " Rack/Product")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}
