using COMBUS_APP.Master_Form;
using COMBUS_APP.Report;
using COMBUS_APP.Transection_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUS_APP
{
    public partial class Main : Form
    {
        int panelStoreHeight, panelEmployeeHeight;
        bool HiddenStore, HiddenEmployee;
        public Main()
        {
            InitializeComponent();

            panelStoreHeight = panelStore.Height;
            panelEmployeeHeight = panelEmployee.Height;
            panelStore.Height = panelEmployee.Height = 0;
            HiddenStore = HiddenEmployee = true;

            SidePanel.Height = BtnHome.Height;

            //panel3.BackColor = Color.FromArgb(150, Color.FromArgb(0, 157, 252));
        }

        void toggle(object sender, int panelLocation)
        {
            //sender is button click
            //pannelLocation is button in panel 
            SidePanel.Height = ((Button)sender).Height;
            SidePanel.Top = ((Button)sender).Top + panelLocation;

            BtnHome.BackColor = Color.FromArgb(41, 39, 40);
            BtnStore.BackColor = Color.FromArgb(41, 39, 40);
            BtnCompany.BackColor = Color.FromArgb(41, 39, 40);
            BtnProduct.BackColor = Color.FromArgb(41, 39, 40);
            BtnEmployeeManagement.BackColor = Color.FromArgb(41, 39, 40);
            BtnManagement.BackColor = Color.FromArgb(41, 39, 40);
            BtnReport.BackColor = Color.FromArgb(41, 39, 40);
            BtnTransactionError.BackColor = Color.FromArgb(41, 39, 40);
            //RGB not hover 41, 39, 40 
            //RGB hover 49, 46, 48
            ((Button)sender).BackColor = Color.FromArgb(49, 46, 48);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toggle(BtnHome, panelMainmenu.Top);
            panel4.Controls.Clear();

            UserControl_Main user_main = new UserControl_Main();
            panel4.Controls.Add(user_main);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            toggle(sender, panelMainmenu.Top);
            panel4.Controls.Clear();

            UserControl_Main user_main = new UserControl_Main();
            panel4.Controls.Add(user_main);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            panelStore.Top = BtnEmployeeManagement.Top;
            timerStore.Start();

            toggle(sender, panelMainmenu.Top);
            panel4.Controls.Clear();

            StoreManagement user_store = new StoreManagement();
            panel4.Controls.Add(user_store);
        }
        private void BtnCompany_Click(object sender, EventArgs e)
        {
            toggle(sender, panelStore.Top);
            panel4.Controls.Clear();

            Company user_product = new Company();
            panel4.Controls.Add(user_product);
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            toggle(sender, panelStore.Top);
            panel4.Controls.Clear();

            Product user_product = new Product();
            panel4.Controls.Add(user_product);
        }
        private void BtnEmployeeManagement_Click_1(object sender, EventArgs e)
        {
            panelEmployee.Top = BtnReport.Top;
            timerEmployee.Start();

            toggle(sender, panelMainmenu.Top);
            panel4.Controls.Clear();

            EmployeeManagement user_employee = new EmployeeManagement();
            panel4.Controls.Add(user_employee);
        }
        private void BtnManagement_Click(object sender, EventArgs e)
                    //Masterform employee
        {
            toggle(sender, panelEmployee.Top);
            panel4.Controls.Clear();

            Employee user_employee = new Employee();
            panel4.Controls.Add(user_employee);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            toggle(sender, panelMainmenu.Top);
            panel4.Controls.Clear();

            MasterReport user_report = new MasterReport();
            panel4.Controls.Add(user_report);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTransactionError_Click(object sender, EventArgs e)
        {
            toggle(sender, panelMainmenu.Top);
            panel4.Controls.Clear();

            //MasterReport user_report = new MasterReport();
            //panel4.Controls.Add(user_report);
        }

        private void BtnClose_MouseMove(object sender, MouseEventArgs e)
        {
            BtnClose.Image = ((System.Drawing.Image)(Properties.Resources.cancel_red));
        }

        private void BtnClose_MouseLeave_1(object sender, EventArgs e)
        {
            BtnClose.Image = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMinus_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMinus.Image = ((System.Drawing.Image)(Properties.Resources.minus_blue));
        }

        private void BtnMinus_MouseLeave(object sender, EventArgs e)
        {
            BtnMinus.Image = ((System.Drawing.Image)(Properties.Resources.minus));
        }

        private void timerStore_Tick(object sender, EventArgs e)
        {
            if (HiddenStore)
            {
                panelStore.Height = panelStore.Height + 8;
                BtnEmployeeManagement.Top = BtnEmployeeManagement.Top + 8;
                BtnReport.Top = BtnReport.Top + 8;
                BtnTransactionError.Top += 8;
                panelEmployee.Top = panelEmployee.Top + 8;
                if(panelStore.Height >= panelStoreHeight)
                {
                    timerStore.Stop();
                    HiddenStore = false;
                    this.Refresh();
                }
            }
            else
            {
                panelStore.Height = panelStore.Height - 8;
                BtnEmployeeManagement.Top = BtnEmployeeManagement.Top - 8;
                BtnReport.Top = BtnReport.Top - 8;
                BtnTransactionError.Top -= 8;
                panelEmployee.Top = panelEmployee.Top - 8;
                if (panelStore.Height <= 0)
                {
                    timerStore.Stop();
                    HiddenStore = true;
                    this.Refresh();
                }
            }
        }

        private void timerEmployee_Tick(object sender, EventArgs e)
        {
            if (HiddenEmployee)
            {
                panelEmployee.Height = panelEmployee.Height + 5;
                BtnReport.Top = BtnReport.Top + 5;
                BtnTransactionError.Top += 5;
                if (panelEmployee.Height >= panelEmployeeHeight)
                {
                    timerEmployee.Stop();
                    HiddenEmployee = false;
                    this.Refresh();
                }
            }
            else
            {
                panelEmployee.Height = panelEmployee.Height - 5;
                BtnReport.Top = BtnReport.Top - 5;
                BtnTransactionError.Top -= 5;
                if (panelEmployee.Height <= 0)
                {
                    timerEmployee.Stop();
                    HiddenEmployee = true;
                    this.Refresh();
                }
            }
        }
    }
}
