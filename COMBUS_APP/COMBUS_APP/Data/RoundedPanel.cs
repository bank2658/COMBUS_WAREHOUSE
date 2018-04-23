using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;

namespace COMBUS_APP.Data
{
    class RoundedPanel : Panel
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 10);
            this.Region = new Region(GraphPath);

            //color line
            //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            //{
            //    pen.Alignment = PenAlignment.Inset;
            //    e.Graphics.DrawPath(pen, GraphPath);
            //}
        }
    }
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 10);
            this.Region = new Region(GraphPath);

            //color line
            //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            //{
            //    pen.Alignment = PenAlignment.Inset;
            //    e.Graphics.DrawPath(pen, GraphPath);
            //}
        }
    }
    //class RoundedTextBox : TextBox
    //{
    //    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    //    {
    //        float r2 = radius / 2f;
    //        GraphicsPath GraphPath = new GraphicsPath();

    //        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius,
    //                            Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
    //        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);

    //        GraphPath.CloseFigure();
    //        return GraphPath;
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        base.OnPaint(e);
    //        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
    //        GraphicsPath GraphPath = GetRoundPath(Rect, 30);
    //        this.Region = new Region(GraphPath);

    //        //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
    //        //{
    //        //    pen.Alignment = PenAlignment.Inset;
    //        //    e.Graphics.DrawPath(pen, GraphPath);
    //        //}



    //        //GraphicsPath GraphPath = new GraphicsPath();
    //        //GraphPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        //this.Region = new Region(GraphPath);
    //        //base.OnPaint(e);
    //    }

    //}
    class RoundedProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }

    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }

    //public class ExTextBox : TextBox
    //{
    //    [DllImport("user32")]
    //    private static extern IntPtr GetWindowDC(IntPtr hwnd);
    //    private const int WM_NCPAINT = 0x85;
    //    protected override void WndProc(ref Message m)
    //    {
    //        base.WndProc(ref m);
    //        if (m.Msg == WM_NCPAINT && this.Focused)
    //        {
    //            using (Graphics g = Graphics.FromHdc(dc))
    //            {
    //                g.DrawRectangle(Pens.SkyBlue, 0, 0, Width - 1, Height - 1);
    //            }
    //        }
    //        //else
    //        //{
    //        //    var dc = GetWindowDC(Handle);
    //        //    using (Graphics g = Graphics.FromHdc(dc))
    //        //    {
    //        //        g.DrawRectangle(Pens.Silver, 0, 0, Width - 1, Height - 1);
    //        //    }
    //        //}
    //    }
    //}
    public class MyTextBox : TextBox
    {
        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        Color borderColor = Color.Silver;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }

    //dataGridView1.BorderStyle = BorderStyle.None;
    //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
    //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
    //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
    //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
    //dataGridView1.BackgroundColor = Color.White;

    //dataGridView1.EnableHeadersVisualStyles = false;
    //dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
    //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
    //dataGridView1.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
    //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    class GradientDataGridView : DataGridView
    {
        //public Color ColorTop { get; set; }
        //public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            //LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            //Graphics g = e.Graphics;
            //g.FillRectangle(lgb, this.ClientRectangle);
            DataGridView Dgv = new DataGridView();
            base.OnPaint(e);
            Dgv.BorderStyle = BorderStyle.None;
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            Dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Dgv.BackgroundColor = Color.White;

            Dgv.EnableHeadersVisualStyles = false;
            Dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            Dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            Dgv.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            Dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
