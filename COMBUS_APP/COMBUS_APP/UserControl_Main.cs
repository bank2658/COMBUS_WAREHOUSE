using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUS_APP
{
    public partial class UserControl_Main : UserControl
    {
        public UserControl_Main()
        {
            InitializeComponent();

            panelLogin.BackColor = Color.FromArgb(175, Color.White);
            
        }
        private void CheckUserandPassword()
        {
            if (txtUsername.Text == " Username" || txtPassword.Text == " Password")
            {
                if (txtUsername.Text == " Username") panelUsername.BackColor = Color.FromArgb(213, 0, 0);
                else panelUsername.BackColor = Color.FromArgb(0, 157, 252);
                if (txtPassword.Text == " Password") panelPassword.BackColor = Color.FromArgb(213, 0, 0);
                else panelPassword.BackColor = Color.FromArgb(0, 157, 252);
                //(txtPassword.Text = " Password") ? panelPassword.BackColor = Color.Red : panelPassword.BackColor = Color.FromArgb(0, 157, 252);
                lbEnter.Visible = true;
            }
            else
            {
                panelUsername.BackColor = Color.FromArgb(0, 157, 252);
                panelPassword.BackColor = Color.FromArgb(0, 157, 252);
                lbEnter.Visible = false;
            }
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
            CheckUserandPassword();
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
    }
}
