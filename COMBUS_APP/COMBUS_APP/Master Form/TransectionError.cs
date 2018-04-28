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

namespace COMBUS_APP.Master_Form
{
    public partial class TransectionError : UserControl
    {
        Master_TransectionError master;
        public TransectionError()
        {
            InitializeComponent();
        }
        

        private String ScreenName = "TransectionError";
        public void Log_Error(Exception ex)
        {
            Master_TransectionError log = new Master_TransectionError();
            log.Log_Error(ex, ScreenName, AppCrash.Login);
            MessageBox.Show(Messge.WRN_Error, Messge.WRN_ErrorHead);
        }

        private void design_Dgv()
        {
            //dataGridView1.Rows.Add("1", "aasdasd", "aasd", "qweda");
            //dataGridView1.Rows.Add("2", "aasdwed", "aas", "qweda");
            //dataGridView1.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            //dataGridView1.Rows.Add("4", "dqweda", "awec", "aqwed");
            //dataGridView1.Rows.Add("5", "aqwed", "awec", "qweda");
            //dataGridView1.Rows.Add("6", "aqwed", "weca", "qweda");
            //dataGridView1.Rows.Add("7", "aqwed", "awc", "aqwed");

            dgvMonitor.BorderStyle = BorderStyle.None;
            dgvMonitor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMonitor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonitor.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            dgvMonitor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMonitor.BackgroundColor = Color.White;

            dgvMonitor.EnableHeadersVisualStyles = false;
            dgvMonitor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMonitor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvMonitor.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            dgvMonitor.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            dgvMonitor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dgvMonitor.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Get_TransectionError()
        {
            master = new Master_TransectionError();
            List<Main_Get_TransectionError_Result> result = new List<Main_Get_TransectionError_Result>();
            if (cbPullAll.Checked)
            {
                result = master.Get_TranAll();
            }
            else if (cbPullFrom.Checked)
            {
                result = master.Get_TranFrom(DtpFrom.Value);
            }
            else if (cbPullFromTo.Checked)
            {
                result = master.Get_TranFromTo(DtpFrom.Value, DtpTo.Value);
            }

            foreach(Main_Get_TransectionError_Result re in result)
            {
                dgvMonitor.Rows.Add(dgvMonitor.RowCount + 1
                                    , re.transectionName
                                    , re.screenName
                                    , re.userName
                                    , re.createDate);
            }
        }


        private void TransectionError_Load(object sender, EventArgs e)
        {
            try
            {
                design_Dgv();
            }
            catch(Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Get_TransectionError();
            }
            catch (Exception ex)
            {
                Log_Error(ex);
            }
        }

        private void cbPullAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPullAll.Checked)
                {
                    cbPullFrom.Checked = false;
                    cbPullFromTo.Checked = false;
                }
            }
            catch
            {
                //
            }
        }

        private void cbPullFrom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPullFrom.Checked)
                {
                    cbPullAll.Checked = false;
                    cbPullFromTo.Checked = false;
                }
            }
            catch
            {
                //
            }
        }

        private void cbPullFromTo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPullFromTo.Checked)
                {
                    cbPullAll.Checked = false;
                    cbPullFrom.Checked = false;
                }
            }
            catch
            {
                //
            }
        }
    }
}
