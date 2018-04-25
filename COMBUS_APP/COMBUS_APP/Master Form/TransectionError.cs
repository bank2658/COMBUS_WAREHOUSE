using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_LAYER.Service_Master;
using DATA_LAYER;

namespace COMBUS_APP.Master_Form
{
    public partial class TransectionError : UserControl
    {
        Master_TransectionError Master = new Master_TransectionError();
        private void design_Dgv()
        {
            //dataGridView1.Rows.Add("1", "aasdasd", "aasd", "qweda");
            //dataGridView1.Rows.Add("2", "aasdwed", "aas", "qweda");
            //dataGridView1.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            //dataGridView1.Rows.Add("4", "dqweda", "awec", "aqwed");
            //dataGridView1.Rows.Add("5", "aqwed", "awec", "qweda");
            //dataGridView1.Rows.Add("6", "aqwed", "weca", "qweda");
            //dataGridView1.Rows.Add("7", "aqwed", "awc", "aqwed");

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        //private void Get_detailDgv(DateTime F,DateTime T)
        //{
        //    List<Get_transectionError_Result> result = Master.Get_TransectionError(F, T).ToList();

        //    foreach (Get_transectionError_Result re in result)
        //    {
        //        //dataGridView1.Rows.Add()
        //    }
        //}
        public TransectionError()
        {
            InitializeComponent();
        }

        private void TransectionError_Load(object sender, EventArgs e)
        {
            design_Dgv();
            //Get_detailDgv(DateTime.Now, DateTime.Now);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
