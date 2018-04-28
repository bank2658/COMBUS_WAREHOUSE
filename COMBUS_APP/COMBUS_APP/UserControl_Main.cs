using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMBUS_APP.Data;
using DATA_LAYER.Service_Main;
using DATA_LAYER;

namespace COMBUS_APP
{
    public partial class UserControl_Main : UserControl
    {
        #region Variable
        //private Master_Main master;
        #endregion
        #region Function

        private void CheckUserandPassword(bool check)
        {
            if (!check)
            {
                panelUsername.BackColor = Color.FromArgb(213, 0, 0);
                
                panelPassword.BackColor = Color.FromArgb(213, 0, 0);
                lbEnter.Visible = true;
            }
            else
            {
                panelUsername.BackColor = Color.FromArgb(0, 157, 252);
                panelPassword.BackColor = Color.FromArgb(0, 157, 252);
                lbEnter.Visible = false;
            }
        }

        private void OnFormLoad()
        {
            if(AppCrash.StatusLogin == "T")
            {
                panelLogin.Visible = false;
                BtnLogin.Text = "LOGOUT";
                BtnLogin.BackColor = Color.Red;

            }
            else{
                panelLogin.Visible = true;
            }
        }
        #endregion
        #region Event

        public UserControl_Main()
        {
            InitializeComponent();

            panelLogin.BackColor = Color.FromArgb(175, Color.White);
            
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == " Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = " Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == " Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            //master = new Master_Main();
            //List<Main_CheckLogin_Result> result = master.check_Login(txtUsername.Text.Trim());
            //foreach(Main_CheckLogin_Result re in result)
            //{
            //    if(re.password == txtPassword.Text.Trim())
            //    {
            //        CheckUserandPassword(true);
            //        if (this.btnLoginClick != null)
            //        {
            //            this.btnLoginClick(this, e);
            //        }
            //        panelLogin.Visible = false;
            //        AppCrash.StatusLogin = "T";
            //        return;

            //    }
            //}
            //CheckUserandPassword(false);
        }

        private void lbForgot_MouseMove(object sender, MouseEventArgs e)
        {
            lbForgot.ForeColor = Color.Red;
        }

        private void lbForgot_MouseLeave(object sender, EventArgs e)
        {
            lbForgot.ForeColor = Color.Silver;
        }

        private void lbForgot_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void UserControl_Main_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
