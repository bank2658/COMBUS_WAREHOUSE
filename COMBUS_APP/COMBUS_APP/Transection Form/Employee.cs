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
using COMBUS_APP.Data;
using DATA;
using DATA.Service_Transection;
using System.Text.RegularExpressions;

namespace COMBUS_APP.Master_Form
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        private Master_Employee baseMaster;
        private Master_EmployeeManagement timeMaster;
        private enum employee
        {
                no
                , employeeID
                , fristName
                , lastName
                , timeIN
                , timeOUT
                , note
        };

        private String ScreenName = "TransactrionEmployee";
        public void Log_Error(Exception ex)
        {
            Master_TransectionError log = new Master_TransectionError();
            log.Log_Error(ex, ScreenName, AppCrash.Login);
            MessageBox.Show(Messge.WRN_Error, Messge.WRN_ErrorHead);
        }

        private void getData_Employee()
        {
            if(dgvEmployee.RowCount > 0)
            {
                dgvEmployee.Rows.Clear();
            }
            baseMaster = new Master_Employee();
            List<Employee_GetEmpName_Result> result = baseMaster.Get_EmpName(string.Empty);
            foreach(Employee_GetEmpName_Result re in result)
            {
                dgvEmployee.Rows.Add(dgvEmployee.RowCount +1
                                        , re.employeeID
                                        , re.firstName
                                        , re.lastName
                                        , string.Empty
                                        , string.Empty
                                        , string.Empty);
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Black;

            dgvEmployee.Columns[(int)employee.timeIN].DefaultCellStyle.BackColor = Color.Yellow;
            dgvEmployee.Columns[(int)employee.timeOUT].DefaultCellStyle.BackColor = Color.Yellow;
            dgvEmployee.Columns[(int)employee.note].DefaultCellStyle.BackColor = Color.Yellow;

            getData_Time();
        }

        private void getData_Time()
        {
            timeMaster = new Master_EmployeeManagement();

            for(int i = 0; i < dgvEmployee.RowCount; i++)
            {
                Employee_GetTimeWork_Result result = timeMaster.Get_TimeWork(
                    dtpDate.Value, 
                    Convert.ToInt32(dgvEmployee.Rows[i].Cells[(int)employee.employeeID].Value.ToString()));
                
                if(result != null)
                {
                    dgvEmployee.Rows[i].Cells[(int)employee.timeIN].Value = result.timeIN;
                    dgvEmployee.Rows[i].Cells[(int)employee.timeOUT].Value = result.timeOUT;
                    dgvEmployee.Rows[i].Cells[(int)employee.note].Value = result.note;

                }
                else
                {
                    dgvEmployee.Rows[i].Cells[(int)employee.timeIN].Value = "-";
                    dgvEmployee.Rows[i].Cells[(int)employee.timeOUT].Value = "-";
                    dgvEmployee.Rows[i].Cells[(int)employee.note].Value = "-";
                }

            }


            
        }

        private void SaveData_Time()
        {
            timeMaster = new Master_EmployeeManagement();
            for (int i = 0; i < dgvEmployee.RowCount; i++)
            {
                timeMaster.Add_TimeWork(dtpDate.Value
                                            , dgvEmployee.Rows[i].Cells[(int)employee.employeeID].Value.ToString()
                                            , dgvEmployee.Rows[i].Cells[(int)employee.timeIN].Value.ToString().Replace(".",":")
                                            , dgvEmployee.Rows[i].Cells[(int)employee.timeOUT].Value.ToString().Replace(".", ":")
                                            , dgvEmployee.Rows[i].Cells[(int)employee.note].Value.ToString()
                                            , AppCrash.Login);
            }
        }

        //private void design_Dgv()
        //{
        //    dgvEmployee.Rows.Add("1", "aasdasd", "aasd", "qweda");
        //    dgvEmployee.Rows.Add("2", "aasdwed", "aas", "qweda");
        //    dgvEmployee.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
        //    dgvEmployee.Rows.Add("4", "dqweda", "awec", "aqwed");
        //    dgvEmployee.Rows.Add("5", "aqwed", "awec", "qweda");
        //    dgvEmployee.Rows.Add("6", "aqwed", "weca", "qweda");
        //    dgvEmployee.Rows.Add("7", "aqwed", "awc", "aqwed");

        //    dgvEmployee.BorderStyle = BorderStyle.None;
        //    dgvEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
        //    dgvEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dgvEmployee.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
        //    dgvEmployee.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        //    dgvEmployee.BackgroundColor = Color.White;

        //    dgvEmployee.EnableHeadersVisualStyles = false;
        //    dgvEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    dgvEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
        //    dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
        //    dgvEmployee.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
        //    dgvEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        //    dgvEmployee.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //}

        private void Employee_Load(object sender, EventArgs e)
        {
            //design_Dgv();
            try
            {
                getData_Employee();
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData_Time();
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void dgvEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[0-9\b\.]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void dgvEmployee_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
