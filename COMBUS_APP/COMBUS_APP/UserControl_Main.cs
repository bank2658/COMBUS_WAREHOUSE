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
using System.Text.RegularExpressions;
using System.Reflection;

namespace COMBUS_APP
{
    public partial class UserControl_Main : UserControl
    {
        public UserControl_Main()
        {
            
            InitializeComponent();
            
            
        }
        
        private Master_Main master;
        public EventHandler btnLoginClick = null;
        
        public void showObjectLoad()
        {
            if (AppCrash.StatusLogin == "T")
            {
                panelLogin.Visible = false;
            }
            else {

                panelLogin.Visible = true;

                //txtUsername.Text = string.Empty;
                //txtPassword.Text = string.Empty;
            }
                panelLogin.BackColor = Color.FromArgb(175, Color.White);
        }

        private bool CheckUserandPassword()
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty
                    || txtUsername.Text == " Username" || txtPassword.Text == " Password")
            {
                if (txtUsername.Text == string.Empty
                    || txtUsername.Text == " Username")
                {
                    panelUsername.BackColor = Color.FromArgb(213, 0, 0);
                }
                if (txtPassword.Text == string.Empty
                    || txtPassword.Text == " Password")
                {
                    panelPassword.BackColor = Color.FromArgb(213, 0, 0);
                }
                txtUsername.Focus();
                lbWrong.Visible = true;
                return false;
            }
            return true;
        }

        private void CheckEnterChar()
        {

        }

        private void OnFormLoad()
        {
            showObjectLoad();
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
                txtPassword.PasswordChar = '●';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = (Char)0;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUserandPassword())
            {
                master = new Master_Main();
                List<Main_CheckLogin_Result> result = master.Check_Login(txtUsername.Text);
                foreach (Main_CheckLogin_Result re in result)
                {
                    if (re.password == txtPassword.Text.Trim())
                    {
                        if (this.btnLoginClick != null)
                        {
                            this.btnLoginClick(this, e);
                        }
                        AppCrash.StatusLogin = "T";
                        AppCrash.Login = re.userName;
                        showObjectLoad();
                        return;
                    }
                }
                txtPassword.Text = string.Empty;
                CheckUserandPassword();
            }
            
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
            var regex = new Regex(@"[^a-zA-Z0-9\b]");
            if (e.KeyChar == (char)13)
            {
                BtnLogin_Click(sender, e);
            }
            else if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            else
            {
                panelPassword.BackColor = Color.FromArgb(0, 157, 252);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b]");
            if (e.KeyChar == (char)13)
            {
                BtnLogin_Click(sender, e);
            }
            else if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            else
            {
                panelUsername.BackColor = Color.FromArgb(0, 157, 252);
            }
        }
        
    }
}
