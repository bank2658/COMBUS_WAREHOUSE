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

namespace COMBUS_APP.Transection_Form
{
    public partial class StoreManagement : UserControl
    {
        private Master_StoreManagement Master;
        List<Store_GetListrock_Result> ListRock = new List<Store_GetListrock_Result>();
        List<Store_GetListcompany_Result> Listcompany = new List<Store_GetListcompany_Result>();
        List<Store_GetListproduct_Result> Listproduct = new List<Store_GetListproduct_Result>();
        //Dictionary<string, Companyy> dic = new Dictionary<string, Companyy>();

        string Rack = string.Empty;
        void BtnRockClick(object sender,EventArgs e)
        {
            Button RackName = (Button)sender;
            List<Store_GetListrock_Result> Listtmp = new List<Store_GetListrock_Result>();
            foreach(Store_GetListrock_Result re in GetListRock(RackName.Name.Replace("BTN", "")))
            {

            }
            
            //txtRack.Text = CbbRock.Text + RackName.Name.Replace("BTN","");
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
            }
            CbbRock.DataSource = new BindingSource(List, null);
            CbbRock.DisplayMember = "Value";
            CbbRock.ValueMember = "Key";
            List.Clear();
            
            // List Company combobox
            List<Store_GetListcompany_Result> resultListcompany = Master.Get_Listcompany();
            foreach(Store_GetListcompany_Result re in resultListcompany){
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

            DataTable dt = new DataTable();
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

            #region a

            //List<Store_GetListcompany_Result> resultListcompany = Master.Get_Listcompany();
            //foreach (Store_GetListcompany_Result re in resultListcompany)
            //{
            //    List.Add(re.companyID
            //                , re.companyName.ToString());
            //}
            //CbbCompany.DataSource = new BindingSource(List, null);

            //CbbCompany.DisplayMember = "Value";
            //CbbCompany.ValueMember = "Key";

            //CbbProduct = CbbCompany.SelectedValu;

            //List<Store_GetListCpAndPd_Result> results = Master.Get_ListCpAndPd();
            //List<Productt> l = new List<Productt>();
            //string s = string.Empty;

            //foreach(Store_GetListCpAndPd_Result res in results)
            //{                
            //    if (! dic.ContainsKey(res.companyName))
            //    {
            //        l = new List<Productt>();
            //    }
            //    l.Add(new Productt(res.productID, res.productName));

            //    if (dic.ContainsKey(res.companyName))
            //    {
            //        dic.Remove(res.companyName);
            //        dic.Add(res.companyName, new Companyy(res.companyID, res.companyName, l));
            //    }
            //    else
            //    {
            //        dic.Add(res.companyName, new Companyy(res.companyID, res.companyName, l));
            //    }                              
            //}           

            //CbbCompany.DataSource = new BindingSource(dic.Keys, null);
            #endregion

        }

        private List<Store_GetListproduct_Result> GetIDproduct(int id)
        {
            return Listproduct.Where(line => line.companyID == id).ToList();
        }

        private List<Store_GetListrock_Result> GetListRock(string Rack)
        {
            return ListRock.Where(line => line.Rack == Rack).ToList();
        }

        public StoreManagement()
        {
            InitializeComponent();
            createEventrock();
            LoadComboboxData();
        }

        private void StoreManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void CbbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbProduct.DataSource = null;
            Dictionary<int, string> List = new Dictionary<int, string>();
            int id = Listcompany[CbbCompany.SelectedIndex].companyID;
            //string[] tmp;
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

            //string key = CbbCompany.SelectedValue.ToString();
            //MessageBox.Show(key);
            //CbbProduct.DataSource = new BindingSource(dic[key].getProduct(), null);
            //MessageBox.Show("ID : " + CbbCompany.SelectedValue.ToString() 
            //                        + Environment.NewLine);
        }

        private void CbbRock_SelectedIndexChanged(object sender, EventArgs e)
        {
            Master = new Master_StoreManagement();
            int id = (int)CbbRock.SelectedValue;
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
            }
        }
    }
    //public class Companyy
    //{
    //    private int? id;
    //    private string company_name;
    //    private List<Productt> product;
    //    public Companyy() {
    //        product = new List<Productt>();
    //    }
    //    public Companyy(int? id_com, string name, List<Productt> pro)
    //    {
    //        id = id_com;
    //        company_name = name;
    //        product = pro;
    //    }
    //    public void set(int? id_com, string name, List<Productt> pro)
    //    {
    //        id = id_com;
    //        company_name = name;
    //        product = pro;
    //    }
    //    public int? getIdCompany()
    //    {
    //        return id;
    //    }
    //    public string getCompanyName()
    //    {
    //        return company_name;
    //    }
    //    public List<string> getProduct()
    //    {
    //        List<string> list = new List<string>();
    //        foreach(Productt p in product)
    //        {
    //            list.Add(p.getProductName());
    //        }

    //        return list;
    //    }
    //}
    //public class Productt
    //{
    //    private int id;
    //    private string name;
    //    public Productt(int idd, string namee)
    //    {
    //        id = idd;
    //        name = namee;
    //    }
    //    public string getProductName()
    //    {
    //        return name;
    //    }
    //    public int getIdProduct()
    //    {
    //        return id;
    //    }
    //}
}
