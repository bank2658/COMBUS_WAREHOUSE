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

namespace COMBUS_APP.Transection_Form
{
    public partial class StoreManagement : UserControl
    {
        string Rack = string.Empty;
        Array[] arrRack;
        void BtnDoubleClick(object sender,EventArgs e)
        {
            Button RackName = (Button)sender;
            txtRack.Text = RackName.Name.Replace("BTN","");
            //MessageBox.Show(s.Name);
        }

        void createEvent()
        {
            //Success
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    //textBox2.Text = i.ToString("0#")+j.ToString("#");
                    Button btn = this.Controls.Find("BTN" + i.ToString("0#") + j.ToString("#"), true).First() as Button;
                    btn.Click += new EventHandler(this.BtnDoubleClick);
                }
            }
        }
        
        public StoreManagement()
        {
            InitializeComponent();
            createEvent();
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            
        }
    }
}
