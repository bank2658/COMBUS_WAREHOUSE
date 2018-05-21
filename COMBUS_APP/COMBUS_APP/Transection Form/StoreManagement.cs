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
        string ModeSubmit = string.Empty;
        int _StockID;
        List<Store_GetListrock_Result> ListRock = new List<Store_GetListrock_Result>();
        List<Store_GetListbank_Result> Listbank = new List<Store_GetListbank_Result>();
        List<Store_GetListcompany_Result> Listcompany = new List<Store_GetListcompany_Result>();
        List<Store_GetListproduct_Result> Listproduct = new List<Store_GetListproduct_Result>();
        List<Store_GetListproductNULL_Result> ListproductNULL = new List<Store_GetListproductNULL_Result>();
        //Dictionary<string, Companyy> dic = new Dictionary<string, Companyy>();
        //string Rack = string.Empty;
        #endregion

        #region function
        void BtnAddmode()
        {
            ModeSubmit = "ADD";
            BtnAdd.Enabled = false;

            CbbCompany.Enabled = true;
            CbbCompany.SelectedIndex = 0;
            CbbProduct.Enabled = true;
            txtDuration.Enabled = true;
            txtDuration.Text = "0";
            DpkFrom.Enabled = true;
            DpkTo.Enabled = true;
            txtBy.Text = AppCrash.Login;

            BtnSubmit.Enabled = true;
            BtnCancel.Enabled = true;

            BtnRackmode(false);
        }
        void BtnEditmode()
        {
            ModeSubmit = "EDIT";
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

            CbbCompany.Enabled = true;
            CbbProduct.Enabled = true;
            txtDuration.Enabled = true;
            DpkFrom.Enabled = true;
            DpkTo.Enabled = true;

            BtnSubmit.Enabled = true;
            BtnCancel.Enabled = true;

            BtnRackmode(false);
        }

        void BtnRackmode(bool b)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Button btn = this.Controls.Find("BTN" + i.ToString("0#") + j.ToString("#"), true).First() as Button;
                    btn.Enabled = b;
                }
            }
            CbbRock.Enabled = b;
            //Dictionary<int, string> List = new Dictionary<int, string>();

            //if (b)
            //{
            //    foreach (Store_GetListproduct_Result re in Listproduct)
            //    {
            //        List.Add(re.productID
            //                    ,re.productName);
            //    }
            //}
            //else
            //{
            //    foreach (Store_GetListproductNULL_Result re in ListproductNULL)
            //    {
            //        List.Add(re.productID
            //                    , re.productName);
            //    }
            //}
            //CbbProduct.DataSource = new BindingSource(List, null);
            //CbbProduct.DisplayMember = "Value";
            //CbbProduct.ValueMember = "Key";
            //CbbProduct.SelectedIndex = -1;
            //List.Clear();
        }
        void EventSubmit()
        {
            Master = new Master_StoreManagement();
            if (ModeSubmit == "ADD")
            {
                if (CbbProduct.SelectedIndex != -1)
                {
                    Master.Add_Stock((int)CbbProduct.SelectedValue
                                        , Listbank[CbbRock.SelectedIndex].bankID
                                        , Convert.ToInt32(txtRack.Text.Substring(1, 2))
                                        , Convert.ToInt32(txtRack.Text.Substring(3))
                                        , null
                                        , DpkFrom.Value.ToString()
                                        , DpkTo.Value.ToString()
                                        , AppCrash.Login);
                    setfalse();
                    CbbRock_SelectedIndexChanged((object)CbbRock, null);
                    Button btn = this.Controls.Find("BTN" + txtRack.Text.Substring(1), true).First() as Button;
                    BtnRockClick((object)btn, null);
                    BtnRackmode(true);
                }
                else
                {
                    MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน !!!",Messge.CM_Confirm);
                }
            }
            else if (ModeSubmit == "EDIT")
            {
                if (CbbProduct.SelectedIndex != -1)
                {
                    Master.Edit_Stock(_StockID
                                        , (int)CbbProduct.SelectedValue
                                        , Listbank[CbbRock.SelectedIndex].bankID
                                        , Convert.ToInt32(txtRack.Text.Substring(1, 2))
                                        , Convert.ToInt32(txtRack.Text.Substring(3))
                                        , null
                                        , DpkFrom.Value.ToString()
                                        , DpkTo.Value.ToString()
                                        , AppCrash.Login);
                    
                    setfalse();
                    CbbRock_SelectedIndexChanged((object)CbbRock, null);
                    Button btn = this.Controls.Find("BTN" + txtRack.Text.Substring(1), true).First() as Button;
                    BtnRockClick((object)btn, null);
                    BtnRackmode(true);

                }
            }
        }
        void EventDelete()
        {
            if (MessageBox.Show(Messge.CM_Delete,Messge.CM_Confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Master.Del_Stock(_StockID);
                setfalse();
                CbbRock_SelectedIndexChanged((object)CbbRock,null);
                Button btn = this.Controls.Find("BTN" + txtRack.Text.Substring(1), true).First() as Button;
                BtnRockClick((object)btn, null);
            }
        }
        void setfalse()
        {
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

            CbbCompany.Enabled = false;
            CbbProduct.Enabled = false;
            txtDuration.Enabled = false;
            DpkFrom.Enabled = false;
            DpkTo.Enabled = false;

            BtnSubmit.Enabled = false;
            BtnCancel.Enabled = false;

            CbbCompany.SelectedIndex = -1;
            CbbProduct.SelectedIndex = -1;

            ModeSubmit = string.Empty;
        }
        void BtnRockClick(object sender,EventArgs e)
        {
            Button RackName = (Button)sender;
            List<Store_GetListrock_Result> Listtmp = GetListRock(RackName.Name.Replace("BTN", ""));
            if(Listtmp.Count > 0)
            {
                foreach (Store_GetListrock_Result re in Listtmp)
                {
                    _StockID = re.stockID;
                    txtRack.Text = CbbRock.Text + re.Rack.ToString();
                    CbbCompany.Text = re.companyName;
                    CbbProduct.Text = re.productName;
                    txtDuration.Text = re.Duration.ToString();
                    DpkFrom.Value = re.dateIN.Value;
                    DpkTo.Value = re.dateOut.Value;
                    txtBy.Text = re.createBy;
                    txtStatus.Text = re.statusInStock;
                }
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                txtRack.Text = CbbRock.Text + RackName.Name.Replace("BTN", "");
                CbbCompany.SelectedIndex = -1;
                CbbProduct.SelectedIndex = -1;
                //CbbProduct.Text = "-";
                txtDuration.Text = "-";
                DpkFrom.Value = DateTime.Now;
                DpkTo.Value = DateTime.Now;
                txtBy.Text = "-";
                txtStatus.Text = "-";

                BtnAdd.Enabled = true;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
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
        void LoadCbbProduct()
        {
            int bankid = Listbank[CbbRock.SelectedIndex].bankID;
            Listproduct.Clear();
            ListproductNULL.Clear();
            List<Store_GetListproduct_Result> resultListproduct = Master.Get_Listproduct(bankid);
            foreach (Store_GetListproduct_Result re in resultListproduct)
            {
                Listproduct.Add(new Store_GetListproduct_Result()
                {
                    productID = (int)re.productID,
                    companyID = (int)re.companyID,
                    productName = (string)re.productName,
                    Duration = re.Duration,
                    dateIN = re.dateIN,
                    dateOut = re.dateOut
                });
            }
            List<Store_GetListproductNULL_Result> resultListproductNULL = Master.Get_ListproductNULL(bankid);
            foreach (Store_GetListproductNULL_Result re in resultListproductNULL)
            {
                ListproductNULL.Add(new Store_GetListproductNULL_Result()
                {
                    productID = (int)re.productID,
                    companyID = (int)re.companyID,
                    productName = (string)re.productName,
                    Duration = re.Duration,
                    dateIN = re.dateIN,
                    dateOut = re.dateOut
                });
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
                DgvType.Rows.Add(re.instandName,re.bankName);
            }
            CbbRock.DataSource = new BindingSource(List, null);
            CbbRock.DisplayMember = "Value";
            CbbRock.ValueMember = "Key";
            List.Clear();

            LoadCbbProduct();

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
        private List<Store_GetListproduct_Result> GetTimeproduct(int id)
        {
            return Listproduct.Where(line => line.productID == id).ToList();
        }
        private List<Store_GetListproduct_Result> GetIDproduct(int id)
        {
            return Listproduct.Where(line => line.companyID == id).ToList();
        }
        private List<Store_GetListproduct_Result> GetIDproductBeforEdit(int id,int idp)
        {
            return Listproduct.Where(line => line.companyID == id && line.productID == idp).ToList();
        }
        private List<Store_GetListproductNULL_Result> GetIDproductNULL(int id)
        {
            return ListproductNULL.Where(line => line.companyID == id).ToList();
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
            Dictionary<int, string> List = new Dictionary<int, string>();
            if(CbbCompany.SelectedIndex != -1)
            {
                int id = Listcompany[CbbCompany.SelectedIndex].companyID;
                if(ModeSubmit == string.Empty)
                {
                    foreach(Store_GetListproduct_Result re in GetIDproduct(id))
                    {
                        List.Add(re.productID
                                    ,re.productName);
                    }
                }
                else if(ModeSubmit == "ADD")
                {
                    foreach (Store_GetListproductNULL_Result re in GetIDproductNULL(id))
                    {
                        List.Add(re.productID
                                    , re.productName);
                    }
                }
                else
                {
                    foreach (Store_GetListproductNULL_Result re in GetIDproductNULL(id))
                    {
                        List.Add(re.productID
                                    , re.productName);
                    }
                }
                CbbProduct.DataSource = null;
                if(List.Count > 0)
                {
                    CbbProduct.DataSource = new BindingSource(List, null);
                    CbbProduct.DisplayMember = "Value";
                    CbbProduct.ValueMember = "Key";
                    CbbProduct.SelectedIndex = -1;
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
                    stockID = re.stockID,
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
            if(DpkTo.Value > DpkFrom.Value)
            {
                TimeSpan ts = (DpkTo.Value - DpkFrom.Value);
                txtDuration.Text = ts.Days.ToString();
            }
            else
            {
                DpkTo.Value = DpkFrom.Value;
                txtDuration.Text = "0";
            }
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDuration.Text) > 0)
            {
                DpkTo.Value = DpkFrom.Value.AddDays(Convert.ToInt32(txtDuration.Text));
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnAddmode();
            LoadCbbProduct();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnEditmode();
            LoadCbbProduct();
            int id = Listcompany[CbbCompany.SelectedIndex].companyID;
            string tmp = CbbProduct.SelectedValue.ToString().Replace("[","");
            string[] tmp2 = tmp.Split(',');
            foreach (Store_GetListproduct_Result re in GetIDproductBeforEdit(id,Convert.ToInt32(tmp2[0])))
            {
                ListproductNULL.Add(new Store_GetListproductNULL_Result(){
                            productID = re.productID
                            ,Duration = re.Duration
                            ,companyID = re.companyID
                            ,productName = re.productName
                            ,dateIN = re.dateIN
                            ,dateOut = re.dateOut
                });
            }
            CbbCompany_SelectedIndexChanged((object)CbbCompany,null);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EventDelete();
            LoadCbbProduct();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            EventSubmit();
            LoadCbbProduct();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            setfalse();
            Button btn = this.Controls.Find("BTN" + txtRack.Text.Substring(1), true).First() as Button;
            BtnRockClick((object)btn,(EventArgs)e);

            BtnRackmode(true);
            LoadCbbProduct();
        }

        private void DpkFrom_Leave(object sender, EventArgs e)
        {
            if (DpkFrom.Value > DpkTo.Value) DpkTo.Value = DpkFrom.Value;
            TimeSpan ts = (DpkTo.Value - DpkFrom.Value);
            txtDuration.Text = ts.Days.ToString();
        }

        private void CbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbProduct.SelectedIndex != -1)
            {
                string[] tmp = CbbProduct.SelectedValue.ToString().Split(',');
                int id = Convert.ToInt32(tmp[0].Replace("[",""));
                foreach (Store_GetListproduct_Result re in GetTimeproduct(id))
                {
                    txtDuration.Text = re.Duration.ToString();
                    DpkFrom.Value = re.dateIN.Value;
                    DpkTo.Value = re.dateOut.Value;
                }
            }
        }
    }
}
