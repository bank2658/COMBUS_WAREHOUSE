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

namespace COMBUS_APP.Transection_Form
{
    public partial class EmployeeManagement : UserControl
    {
        private enum EEmployee
        {
            No
                ,EmpID
                ,FirstName
                ,LastName
                ,Age
                ,Address
                ,Permistion
                ,Username
                ,Password
        };

        private void design_Dgv()
        {
            //grdEmp.Rows.Add("1", "aasdasd", "aasd", "qweda");
            //grdEmp.Rows.Add("2", "aasdwed", "aas", "qweda");
            //grdEmp.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            //grdEmp.Rows.Add("4", "dqweda", "awec", "aqwed");
            //grdEmp.Rows.Add("5", "aqwed", "awec", "qweda");
            //grdEmp.Rows.Add("6", "aqwed", "weca", "qweda");
            //grdEmp.Rows.Add("7", "aqwed", "awc", "aqwed");

            grdEmp.BorderStyle = BorderStyle.None;
            grdEmp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdEmp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdEmp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            grdEmp.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdEmp.BackgroundColor = Color.White;

            grdEmp.EnableHeadersVisualStyles = false;
            grdEmp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdEmp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            grdEmp.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            grdEmp.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            grdEmp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            grdEmp.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            design_Dgv();
        }

        private Master_Employee master;
        private int Check = 0;

        private void ViewMode()
        {
            txtFname.ReadOnly = true;
            txtLname.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;

            cbbPermistion.Enabled = false;

            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            Check = 0;
        }

        private void AddMode()
        {
            txtFname.ReadOnly = false;
            txtLname.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;

            cbbPermistion.Enabled = true;

            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

            cbbPermistion.Text = string.Empty;
        }

        private void EditMode()
        {
            txtFname.ReadOnly = false;
            txtLname.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;

            cbbPermistion.Enabled = true;

            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void OnSearchName()
        {
            grdEmp.Rows.Clear();
            master = new Master_Employee();
            List<Employee_GetEmpName_Result> result = master.Get_EmpName(txtSearch.Text);
            foreach(Employee_GetEmpName_Result re in result)
            {
                grdEmp.Rows.Add(grdEmp.Rows.Count + 1
                                    , re.employeeID
                                    , re.firstName
                                    , re.lastName
                                    , re.age
                                    , re.address
                                    , re.permissionLoginSystem
                                    , re.userName
                                    , re.password);
            }
            if(result.Count > 0)
            {
                GrdEmpClick(0);
            }
        }

        private void OnEdit()
        {
            master = new Master_Employee();
            master.Edit_Emp(Convert.ToInt32(txtID.Text)
                            , txtFname.Text
                            , txtLname.Text
                            , Convert.ToInt32(txtAge.Text)
                            , txtAddress.Text
                            , cbbPermistion.Text
                            , txtUsername.Text
                            , txtPassword.Text);
            MessageBox.Show(Messge.INF_Edit, Messge.CM_Confirm);
        }

        private void OnDelete()
        {
            master = new Master_Employee();
            DialogResult dialog = MessageBox.Show(Messge.CM_Delete, Messge.CM_Confirm, MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                master.Del_Emp(Convert.ToInt32(txtID.Text));
                MessageBox.Show(Messge.INF_Delete, Messge.CM_Confirm);
            }
            else
            {
                MessageBox.Show(Messge.INF_Cancel, Messge.CM_Confirm);
            }
        }

        private void GrdEmpClick(int index)
        {
            txtID.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.EmpID].Value.ToString();
            txtFname.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.FirstName].Value.ToString();
            txtLname.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.LastName].Value.ToString();
            txtAge.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.Age].Value.ToString();
            txtAddress.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.Address].Value.ToString();
            txtUsername.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.Username].Value.ToString();
            txtPassword.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.Password].Value.ToString();
            cbbPermistion.Text = grdEmp.CurrentRow.Cells[(int)EEmployee.Permistion].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {           
                OnSearchName();           
        }

        private void grdEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GrdEmpClick(0);
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
            GrdEmpClick(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete();
            OnSearchName();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Check == 2)
            {
                OnEdit();
            }
            ViewMode();
            OnSearchName();
        }
    }
}
