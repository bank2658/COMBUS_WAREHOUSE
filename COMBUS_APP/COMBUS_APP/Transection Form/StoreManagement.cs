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
using DATA.Service_Transection;
using DATA;
using COMBUS_APP.Properties;

namespace COMBUS_APP.Transection_Form
{
    public partial class StoreManagement : UserControl
    {
        #region Variable
        private Master_StoreManagement Master;
        List<Store_GetListrock_Result> ListRock = new List<Store_GetListrock_Result>();
        List<Store_GetListbank_Result> Listbank = new List<Store_GetListbank_Result>();
        List<Store_GetListcompany_Result> Listcompany = new List<Store_GetListcompany_Result>();
        List<Store_GetListproduct_Result> Listproduct = new List<Store_GetListproduct_Result>();
        //Dictionary<string, Companyy> dic = new Dictionary<string, Companyy>();
        //string Rack = string.Empty;
        #endregion

        #region function
        void BtnRockClick(object sender,EventArgs e)
        {
            Button RackName = (Button)sender;
            List<Store_GetListrock_Result> Listtmp = GetListRock(RackName.Name.Replace("BTN", ""));
            if(Listtmp.Count > 0)
            {
                foreach (Store_GetListrock_Result re in Listtmp)
                {
                    txtRack.Text = CbbRock.Text + re.Rack.ToString();
                    CbbCompany.Text = re.companyName;
                    CbbProduct.Text = re.productName;
                    txtDuration.Text = re.Duration.ToString();
                    DpkFrom.Value = re.dateIN.Value;
                    DpkTo.Value = re.dateOut.Value;
                    txtBy.Text = re.createBy;
                    txtStatus.Text = re.statusInStock;
                }
            }
            else
            {
                txtRack.Text = CbbRock.Text + RackName.Name.Replace("BTN", "");
                CbbCompany.SelectedIndex = -1;
                //CbbProduct.Text = "-";
                txtDuration.Text = "-";
                DpkFrom.Value = DateTime.Now;
                DpkTo.Value = DateTime.Now;
                txtBy.Text = "-";
                txtStatus.Text = "-";
            }

            //txtRack.Text = CbbRock.Text + RackName.Name.Replace("BTN", "");
            //MessageBox.Show(s.Name);
        }

        void createEventrock()
        {
            //Success
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Button btn = this.Controls.Find("BTN" + i.ToString("0#") + j.ToString("#"), true).First() as Button;
                    btn.Click += new EventHandler(BtnRockClick);
                }
            }
        }

        void LoadComboboxData()
        {
            Dictionary<int, string> List = new Dictionary<int, string>();
            Master = new Master_StoreManagement();
            // List Rack
            List<Store_GetListbank_Result> resultListbank = Master.Get_Listbank();
            foreach (Store_GetListbank_Result re in resultListbank)
            {
                List.Add(re.bankID
                            , re.instandName.ToString());
                Listbank.Add(new Store_GetListbank_Result()
                {
                    bankID = re.bankID
                    ,bankName = re.bankName
                });
            }
            CbbRock.DataSource = new BindingSource(List, null);
            CbbRock.DisplayMember = "Value";
            CbbRock.ValueMember = "Key";
            List.Clear();

            //DataTable dt = new DataTable();
            List<Store_GetListproduct_Result> resultListproduct = Master.Get_Listproduct();
            foreach (Store_GetListproduct_Result re in resultListproduct)
            {
                Listproduct.Add(new Store_GetListproduct_Result()
                {
                    productID = (int)re.productID,
                    companyID = (int)re.companyID,
                    productName = (string)re.productName
                });
            }

            // List Company combobox
            List<Store_GetListcompany_Result> resultListcompany = Master.Get_Listcompany();
            foreach (Store_GetListcompany_Result re in resultListcompany)
            {
                List.Add(re.companyID
                            , re.companyName);
                Listcompany.Add(new Store_GetListcompany_Result()
                {
                    companyID = (int)re.companyID,
                    companyName = (string)re.companyName
                });
            }
            CbbCompany.DataSource = new BindingSource(List, null);
            CbbCompany.DisplayMember = "Value";
            CbbCompany.ValueMember = "Key";
            List.Clear();

            // List Percent 
            List<Store_GetPercentrock_Result> resultListpercent = Master.Get_Percentrock();
            foreach (Store_GetPercentrock_Result re in resultListpercent)
            {
                ProgressBar Pgb = Controls.Find("Pgb" + re.instandName, true).First() as ProgressBar;
                Label lbPercent = Controls.Find("lbPercent" + re.instandName, true).First() as Label;
                Pgb.Value = (int)re.Percen;
                lbPercent.Text = re.Percen.ToString() + "%";
                if(re.instandName != "Total")
                {
                    TextBox txtTotal = Controls.Find("txtTotal" + re.instandName, true).First() as TextBox; 
                    TextBox txtEmpty = Controls.Find("txtEmpty" + re.instandName, true).First() as TextBox;
                    TextBox txtITT = Controls.Find("txtITT" + re.instandName, true).First() as TextBox;
                    txtTotal.Text = re.Total.ToString();
                    txtEmpty.Text = re.Empty.ToString();
                    txtITT.Text = re.Imminent.ToString();
                }
            }
        }

        private List<Store_GetListproduct_Result> GetIDproduct(int id)
        {
            return Listproduct.Where(line => line.companyID == id).ToList();
        }

        private List<Store_GetListrock_Result> GetListRock(string Rack)
        {
            return ListRock.Where(line => line.Rack == Rack).ToList();
        }
        #endregion

        #region Event
        public StoreManagement()
        {
            InitializeComponent();
            createEventrock();
            LoadComboboxData();

            CbbCompany.SelectedIndex = -1;
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void CbbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbProduct.DataSource = null;
            Dictionary<int, string> List = new Dictionary<int, string>();
            if(CbbCompany.SelectedIndex != -1)
            {
                int id = Listcompany[CbbCompany.SelectedIndex].companyID;
                foreach(Store_GetListproduct_Result re in GetIDproduct(id))
                {
                    List.Add(re.productID
                                ,re.productName);
                }
                if(List.Count > 0)
                {
                    CbbProduct.DataSource = new BindingSource(List, null);
                    CbbProduct.DisplayMember = "Value";
                    CbbProduct.ValueMember = "Key";
                }
                List.Clear();
            }
        }

        private void CbbRock_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRock.Clear();
            Master = new Master_StoreManagement();
            int id = Listbank[CbbRock.SelectedIndex].bankID;
            int[] Checkstatus = new int[130];
            Array.Clear(Checkstatus, 0, Checkstatus.Length);
            List<Store_GetListrock_Result> result = Master.Get_Listrock(id);
            foreach (Store_GetListrock_Result re in result)
            {
                ListRock.Add(new Store_GetListrock_Result()
                {
                    Rack = re.Rack,
                    companyName = re.companyName,
                    productName = re.productName,
                    Duration = (int)re.Duration,
                    dateIN = (DateTime)re.dateIN,
                    dateOut = (DateTime)re.dateOut,
                    createBy = re.createBy,
                    statusInStock = re.statusInStock
                });

                // Check status product in rack and add image
                Checkstatus[Convert.ToInt32(re.Rack)] = 1;
                Button btn = this.Controls.Find("BTN" + re.Rack, true).First() as Button;
                if (re.statusInStock == "normal") btn.Image = Resources.box_store;
                else btn.Image = Resources.box_storeAlert;
            }

            // check add image null to rack empty
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if(Checkstatus[(i * 10) + j] == 0)
                    {
                        Button btn = this.Controls.Find("BTN" + i.ToString("0#") + j.ToString("#"), true).First() as Button;
                        btn.Image = null;
                    }
                }
            }
        }
        #endregion

        private void DpkTo_Leave(object sender, EventArgs e)
        {

        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {

        }
    }
}
