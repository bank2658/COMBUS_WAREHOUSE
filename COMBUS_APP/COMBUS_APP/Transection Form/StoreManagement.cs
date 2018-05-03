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
//        Button GetBtn(string b)
//        {
//            //Button b = new Button();
//            //b = Controls["Btn11"];
//            return (Button)Controls[b];
//;
//        }
        void BtnDoubleClick(object sender,EventArgs e)
        {
            Button s = (Button)sender;
            MessageBox.Show("111");
        }
        public StoreManagement()
        {
            InitializeComponent();
            //addevent();

            //Success
            //for (int i = 1; i <= 6; i++)
            //{
            //    Button btn = this.Controls.Find("Btn1" + i.ToString(), true).First() as Button;
            //    btn.Click += new EventHandler(this.BtnDoubleClick);
            //}

            //for (int i = 1; i <= 6; i++)
            //{
            //   
            //    //Button Btn = GetBtn("Btn1" + i);
            //    //this.Controls["Btn1"+i.ToString()];
            //    //Controls["Btn11"/* + i.ToString().Trim()*/].DoubleClick += new EventHandler(BtnDoubleClick);
            //}
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 1; i++)
            {
               Controls["Btn1" + i.ToString()].Click += new EventHandler(BtnDoubleClick);
            }
            //addEvent();
        }

        void addEvent()
        {
            //for (int i = 1; i <= 6; i++)
            //{
                //Controls += new EventHandler(BtnDoubleClick);
                //Button Btn = GetBtn("Btn1" + i);
                //this.Controls["Btn1"+i.ToString()];
                //Controls["Btn11"/* + i.ToString().Trim()*/].DoubleClick += new EventHandler(BtnDoubleClick);
            //}
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
