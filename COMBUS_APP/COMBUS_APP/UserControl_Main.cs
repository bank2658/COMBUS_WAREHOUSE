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
using DATA;
using DATA.Service_Main;

namespace COMBUS_APP
{
    public partial class UserControl_Main : UserControl
    {
        
        private Master_Main master;
        public EventHandler btnLoginClick;
        


        private void CheckUserandPassword(bool check)
        {
            if (!check)
            {
                panelUsername.BackColor = Color.FromArgb(213, 0, 0);
                
                panelPassword.BackColor = Color.FromArgb(213, 0, 0);
                lbEnter.Visible = true;
                txtPassword.Text = string.Empty;
                //txtPassword.Focus();
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
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
                BtnLogin.Focus();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            master = new Master_Main();
            List<Main_CheckLogin_Result> result = master.Check_Login(txtUsername.Text);
            foreach (Main_CheckLogin_Result re in result)
            {
                if (re.password == txtPassword.Text.Trim())
                {
                    CheckUserandPassword(true);
                    if (this.btnLoginClick != null)
                    {
                        this.btnLoginClick(this, e);
                    }
                    panelLogin.Visible = false;
                    AppCrash.StatusLogin = "T";
                    return;

                }

            }
            CheckUserandPassword(false);
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnLogin_Click(sender, e);
            }
        }
        
    }
}
