using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_LAYER.Service_Master;
using DATA_LAYER;

namespace COMBUS_APP.Master_Form
{
    public partial class Company : UserControl
    {
        private Master_Company master;

        private void design_Dgv()
        {
            grdCompany.Rows.Add("1", "aasdasd", "aasd", "qweda");
            grdCompany.Rows.Add("2", "aasdwed", "aas", "qweda");
            grdCompany.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            grdCompany.Rows.Add("4", "dqweda", "awec", "aqwed");
            grdCompany.Rows.Add("5", "aqwed", "awec", "qweda");
            grdCompany.Rows.Add("6", "aqwed", "weca", "qweda");
            grdCompany.Rows.Add("7", "aqwed", "awc", "aqwed");

            grdCompany.BorderStyle = BorderStyle.None;
            grdCompany.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdCompany.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdCompany.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            grdCompany.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdCompany.BackgroundColor = Color.White;

            grdCompany.EnableHeadersVisualStyles = false;
            grdCompany.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdCompany.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            grdCompany.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            grdCompany.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            grdCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
            grdCompany.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public Company()
        {
            InitializeComponent();
            //exTextBox1.Bordercol
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = " Company/Address";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == " Company/Address")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            design_Dgv();
        }

        private void Onsearch()
        {
            grdCompany.Rows.Clear();
            master = new Master_Company();
            List<Get_Company_Result> result = master.Get_Company();
            foreach(Get_Company_Result re in result)
            {
                grdCompany.Rows.Add(grdCompany.RowCount + 1
                                    , re.companyName
                                    , re.phone
                                    , re.address);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Onsearch();
        }
    }
}
