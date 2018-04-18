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
        public Main()
        {
            InitializeComponent();
            SidePanel.Height = BtnHome.Height;
        }

        void toggle(object sender)
        {
            SidePanel.Height = ((Button)sender).Height;
            SidePanel.Top = ((Button)sender).Top;

            BtnHome.BackColor = Color.FromArgb(41, 39, 40);
            BtnStore.BackColor = Color.FromArgb(41, 39, 40);
            BtnEmployee.BackColor = Color.FromArgb(41, 39, 40);
            BtnReport.BackColor = Color.FromArgb(41, 39, 40);
            //RGB not hover 41, 39, 40 
            //RGB hover 49, 46, 48
            ((Button)sender).BackColor = Color.FromArgb(49, 46, 48);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toggle(BtnHome);
            panel4.Controls.Clear();
            UserControl_Main user_main = new UserControl_Main();
            panel4.Controls.Add(user_main);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            toggle(sender);
            panel4.Controls.Clear();

            UserControl_Main user_main = new UserControl_Main();
            panel4.Controls.Add(user_main);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            toggle(sender);
            panel4.Controls.Clear();

            StoreManagement user_store = new StoreManagement();
            panel4.Controls.Add(user_store);
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            toggle(sender);
            panel4.Controls.Clear();

            EmployeeManagement user_employee = new EmployeeManagement();
            panel4.Controls.Add(user_employee);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            toggle(sender);
            panel4.Controls.Clear();

            MasterReport user_report = new MasterReport();
            panel4.Controls.Add(user_report);
        }
    }
}
