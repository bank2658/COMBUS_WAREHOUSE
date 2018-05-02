using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA.Service_Master;
using DATA;
using COMBUS_APP.Data;

namespace COMBUS_APP.Master_Form
{
    public partial class Company : UserControl
    {
        private String ScreenName = "TransectionError";
        public void Log_Error(Exception ex)
        {
            Master_TransectionError log = new Master_TransectionError();
            log.Log_Error(ex, ScreenName, AppCrash.Login);
            MessageBox.Show(Messge.WRN_Error, Messge.WRN_ErrorHead);
        }

        private enum ECompany
        {
            No
                ,ID
                ,CompanyName
                ,Contract
                ,Address        
        };

        int Chbtn = 0;

        private void design_Dgv()
        {
            //grdCompany.Rows.Add("1", "aasdasd", "aasd", "qweda");
            //grdCompany.Rows.Add("2", "aasdwed", "aas", "qweda");
            //grdCompany.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            //grdCompany.Rows.Add("4", "dqweda", "awec", "aqwed");
            //grdCompany.Rows.Add("5", "aqwed", "awec", "qweda");
            //grdCompany.Rows.Add("6", "aqwed", "weca", "qweda");
            //grdCompany.Rows.Add("7", "aqwed", "awc", "aqwed");

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
            try
            {
                design_Dgv();
                ViewMode();

            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void ViewMode()
        {
            txtID.ReadOnly = true;
            txtCompany.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;

            btnSubmit.Enabled = false;
            BtnCancel.Enabled = false;
            Chbtn = 0;
        }

        private void EditMode()
        {
            txtID.ReadOnly = true;
            txtCompany.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress.ReadOnly = false;

            btnSubmit.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void AddMode()
        {
            txtID.ReadOnly = true;
            txtCompany.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress.ReadOnly = false;

            btnSubmit.Enabled = true;
            BtnCancel.Enabled = true;

            txtID.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private Master_Company master;

        private void Onsearch()
        {
            try
            {
                grdCompany.Rows.Clear();
                master = new Master_Company();
                List<Company_GetCompany_Result> result = master.Get_Company(txtSearch.Text.Trim());
                foreach (Company_GetCompany_Result re in result)
                {
                    grdCompany.Rows.Add(grdCompany.Rows.Count + 1
                                        , re.companyID
                                        , re.companyName
                                        , re.phone
                                        , re.address);
                }
                if(result.Count > 0)
                {
                    GrdComclick(0);
                }
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void OnAdd()
        {           
            DialogResult dialog = MessageBox.Show(Messge.CM_Add,Messge.CM_Confirm,MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                master = new Master_Company();
                master.Add_Company(txtCompany.Text, txtPhone.Text, txtAddress.Text);
                MessageBox.Show(Messge.INF_Save,Messge.CM_Confirm);
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel,Messge.CM_Confirm);
            }
        }

        private void OnEdit()
        {
            DialogResult dialog = MessageBox.Show(Messge.INF_Edit, Messge.CM_Confirm, MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                master = new Master_Company();
                master.Edit_Company(Convert.ToInt32(txtID.Text), txtCompany.Text, txtPhone.Text, txtAddress.Text);
                MessageBox.Show(Messge.INF_Edit, Messge.CM_Confirm);
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel, Messge.CM_Confirm);
            }
        }

        private void GrdComclick(int i)
        {
            txtID.Text = grdCompany.CurrentRow.Cells[(int)ECompany.ID].Value.ToString();
            txtCompany.Text = grdCompany.CurrentRow.Cells[(int)ECompany.CompanyName].Value.ToString();
            txtPhone.Text = grdCompany.CurrentRow.Cells[(int)ECompany.Contract].Value.ToString();
            txtAddress.Text = grdCompany.CurrentRow.Cells[(int)ECompany.Address].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Onsearch();
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void grdCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GrdComclick(e.RowIndex);
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddMode();
                Chbtn = 1;             
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditMode();
                Chbtn = 2;
            }
            catch (Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ViewMode();
                GrdComclick(grdCompany.CurrentRow.Index);               
            }
            catch (Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(Messge.CM_Delete,Messge.CM_Confirm,MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                master = new Master_Company();
                master.Del_Company(Convert.ToInt32(txtID.Text));
                MessageBox.Show(Messge.INF_Delete,Messge.CM_Confirm);
                Onsearch();
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel,Messge.CM_Confirm);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Chbtn == 1)
            {               
                OnAdd();
            }
            else
            {
                OnEdit();
            }
            ViewMode();
            Onsearch();
        }
    }
}
