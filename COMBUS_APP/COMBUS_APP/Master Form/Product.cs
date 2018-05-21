using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA.Service_Master;
using DATA;
using COMBUS_APP.Data;
using DATA.Service_Transection;

namespace COMBUS_APP.Master_Form
{
    public partial class Product : UserControl
    {

        private Master_Product master;
        private Master_Company masterCom;
        private Master_StoreManagement MasterStore;
        private int Check = 0;

        private enum EProduct
        {
            No
                ,ProductID
                ,ProductName
                ,ProductKg
                ,ProductType
                ,ComID
                ,DateIn
                ,Dateout
        };

        private void design_Dgv()
        {
            //GrdProduct.Rows.Add("1", "aasdasd", "aasd", "qweda");
            //GrdProduct.Rows.Add("2", "aasdwed", "aas", "qweda");
            //GrdProduct.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            //GrdProduct.Rows.Add("4", "dqweda", "awec", "aqwed");
            //GrdProduct.Rows.Add("5", "aqwed", "awec", "qweda");
            //GrdProduct.Rows.Add("6", "aqwed", "weca", "qweda");
            //GrdProduct.Rows.Add("7", "aqwed", "awc", "aqwed");

            GrdProduct.BorderStyle = BorderStyle.None;
            GrdProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GrdProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GrdProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            GrdProduct.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GrdProduct.BackgroundColor = Color.White;

            GrdProduct.EnableHeadersVisualStyles = false;
            GrdProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GrdProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            GrdProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            GrdProduct.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            GrdProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            GrdProduct.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public Product()
        {
            InitializeComponent();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = " Product Name/Type";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == " Product Name/Type")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            design_Dgv();

            masterCom = new Master_Company();
            List<Company_GetCompany_Result> result =  masterCom.Get_Company(string.Empty);
            foreach(Company_GetCompany_Result re in result)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = re.companyName;
                item.Value = re.companyID;

                cbCompany.Items.Add(item);
            }

            MasterStore = new Master_StoreManagement();
            List<Store_GetListbank_Result> result2 = MasterStore.Get_Listbank();
            foreach(Store_GetListbank_Result re2 in result2)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = re2.bankName;
                item.Value = re2.bankID;

                cbbType.Items.Add(item);
            }


            ViewMode();
        }

        private void ViewMode()
        {                  
            txtName.ReadOnly = true;
            txtWeight.ReadOnly = true;
            cbCompany.Enabled = true;

            cbbType.Enabled = false;

            dtpIn.Enabled = false;
            dtpOut.Enabled = false;

            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            Check = 0;
        }

        private void AddMode()
        {
            txtID.Text = "ADD";
            txtName.ReadOnly = false;
            txtWeight.ReadOnly = false;
            cbCompany.Enabled = false;

            cbbType.Enabled = true;

            dtpIn.Enabled = true;
            dtpOut.Enabled = true;

            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            txtName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            cbbType.Text = string.Empty;
            if (cbCompany.Items.Count > 0) cbCompany.SelectedIndex = 0;
            else cbCompany.SelectedIndex = -1;
        }

        private void EditMode()
        {
            //txtID.Text = GrdProduct.CurrentRow.Cells[(int)EProduct.ProductID].Value.ToString();
            txtName.ReadOnly = false;
            txtWeight.ReadOnly = false;
            cbCompany.Enabled = false;

            cbbType.Enabled = true;

            dtpIn.Enabled = true;
            dtpOut.Enabled = true;

            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;          
        }

        private void OnSearchName()
        {
            GrdProduct.Rows.Clear();
            master = new Master_Product();
            List<Product_GetProductName_Result> result = master.Get_ProductName(txtSearch.Text.Trim());
            foreach(Product_GetProductName_Result re in result)
            {
                GrdProduct.Rows.Add(GrdProduct.Rows.Count + 1
                                    , re.productID
                                    , re.productName
                                    , re.productKG
                                    , re.bankID
                                    , re.companyID
                                    , re.dateIN
                                    , re.dateOut);
            }
            if (result.Count > 0)
            {
                GrdProClick(0);
            }
        }

        private void OnSearchTime()
        {
            GrdProduct.Rows.Clear();
            master = new Master_Product();
            List<Product_GetProductTime_Result> result = master.Get_ProductTime(dtpFirst.Value,dtplast.Value);
            foreach(Product_GetProductTime_Result re in result)
            {
                GrdProduct.Rows.Add(GrdProduct.Rows.Count + 1
                                    , re.productID
                                    , re.productName
                                    , re.productKG
                                    , re.bankID
                                    , re.companyID
                                    , re.dateIN
                                    , re.dateOut);
            }
            if (result.Count > 0)
            {
                GrdProClick(0);
            }
        }

        private void OnDelete()
        {
            master = new Master_Product();
            DialogResult dialog = MessageBox.Show(Messge.CM_Delete, Messge.CM_Confirm, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                master.Del_Product(Convert.ToInt32(txtID.Text));
                MessageBox.Show(Messge.INF_Delete, Messge.CM_Confirm);
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel, Messge.CM_Confirm);
            }
            OnSearchName();
        }

        private void OnEdit()
        {
            master = new Master_Product();
            master.Edit_Product(Convert.ToInt32(txtID.Text)
                ,txtName.Text
                ,Convert.ToDecimal(txtWeight.Text)
                , (cbbType.SelectedItem as ComboboxItem).Value
                , dtpIn.Value
                ,dtpOut.Value);
            MessageBox.Show(Messge.INF_Edit,Messge.CM_Confirm);
            OnSearchName();
        }

        private void OnAdd()
        {
            master = new Master_Product();
            DialogResult dialog = MessageBox.Show(Messge.CM_Add, Messge.CM_Confirm, MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                master.Add_Product(txtName.Text
                                , Convert.ToDecimal(txtWeight.Text)
                                , (cbbType.SelectedItem as ComboboxItem).Value
                                , (cbCompany.SelectedItem as ComboboxItem).Value
                                , dtpIn.Value
                                , dtpOut.Value);
                MessageBox.Show(Messge.INF_Save, Messge.CM_Confirm);
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel, Messge.CM_Confirm);
            }
            OnSearchName();
        }

        private void GrdProClick(int index)
        {            
            txtID.Text = GrdProduct.CurrentRow.Cells[(int)EProduct.ProductID].Value.ToString();
            txtName.Text = GrdProduct.CurrentRow.Cells[(int)EProduct.ProductName].Value.ToString();
            txtWeight.Text = GrdProduct.CurrentRow.Cells[(int)EProduct.ProductKg].Value.ToString();

            int intBanktype = Convert.ToInt32( GrdProduct.CurrentRow.Cells[(int)EProduct.ProductType].Value.ToString());
            foreach(ComboboxItem re in cbbType.Items)
            {
                if(intBanktype == re.Value)
                {
                    cbbType.SelectedItem = re;
                    break;
                }
            }



            int intCompany = Convert.ToInt32( GrdProduct.CurrentRow.Cells[(int)EProduct.ComID].Value.ToString());
            foreach(ComboboxItem re in cbCompany.Items)
            {
                if(intCompany == re.Value)
                {
                    cbCompany.SelectedItem = re;
                    break;
                }
            }

            dtpIn.Value = Convert.ToDateTime(GrdProduct.CurrentRow.Cells[(int)EProduct.DateIn].Value.ToString());
            dtpOut.Value = Convert.ToDateTime(GrdProduct.CurrentRow.Cells[(int)EProduct.Dateout].Value.ToString());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {           
            if(rdoSearch.Checked == true)
            {
                OnSearchName();
            }
            else if(rdoTime.Checked == true)
            {
                OnSearchTime();
            }
        }

        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            rdoTime.Checked = false;
        }

        private void rdoTime_CheckedChanged(object sender, EventArgs e)
        {
            rdoSearch.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMode();
            Check = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMode();
            Check = 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ViewMode();
            GrdProClick(0);
        }

        private void GrdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GrdProClick(GrdProduct.CurrentRow.Index);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Check == 1)
            {
                OnAdd();
            }
            else if(Check == 2)
            {
                OnEdit();
            }
            ViewMode();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
