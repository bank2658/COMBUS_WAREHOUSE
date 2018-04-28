namespace COMBUS_APP.Master_Form
{
    partial class TransectionError
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransectionError));
            this.dgvMonitor = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPullFromTo = new System.Windows.Forms.CheckBox();
            this.cbPullFrom = new System.Windows.Forms.CheckBox();
            this.cbPullAll = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonitor
            // 
            this.dgvMonitor.AllowUserToAddRows = false;
            this.dgvMonitor.AllowUserToDeleteRows = false;
            this.dgvMonitor.AllowUserToResizeColumns = false;
            this.dgvMonitor.AllowUserToResizeRows = false;
            this.dgvMonitor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.TransectionID,
            this.TransectionName,
            this.screenName,
            this.userName,
            this.createDate});
            this.dgvMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonitor.Location = new System.Drawing.Point(0, 0);
            this.dgvMonitor.MultiSelect = false;
            this.dgvMonitor.Name = "dgvMonitor";
            this.dgvMonitor.ReadOnly = true;
            this.dgvMonitor.RowHeadersVisible = false;
            this.dgvMonitor.RowTemplate.Height = 25;
            this.dgvMonitor.RowTemplate.ReadOnly = true;
            this.dgvMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitor.Size = new System.Drawing.Size(1061, 519);
            this.dgvMonitor.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // TransectionID
            // 
            this.TransectionID.HeaderText = "TransectionID";
            this.TransectionID.Name = "TransectionID";
            this.TransectionID.ReadOnly = true;
            this.TransectionID.Visible = false;
            // 
            // TransectionName
            // 
            this.TransectionName.HeaderText = "TransectionName";
            this.TransectionName.Name = "TransectionName";
            this.TransectionName.ReadOnly = true;
            this.TransectionName.Width = 521;
            // 
            // screenName
            // 
            this.screenName.HeaderText = "screenName";
            this.screenName.Name = "screenName";
            this.screenName.ReadOnly = true;
            this.screenName.Width = 200;
            // 
            // userName
            // 
            this.userName.HeaderText = "userName";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // createDate
            // 
            this.createDate.HeaderText = "CreateDate";
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            this.createDate.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSECTION ERROR";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvMonitor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1061, 519);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 669);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbPullFromTo);
            this.panel3.Controls.Add(this.cbPullFrom);
            this.panel3.Controls.Add(this.cbPullAll);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DtpTo);
            this.panel3.Controls.Add(this.DtpFrom);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 150);
            this.panel3.TabIndex = 1;
            this.panel3.Tag = "TransectionError";
            // 
            // cbPullFromTo
            // 
            this.cbPullFromTo.AutoSize = true;
            this.cbPullFromTo.Location = new System.Drawing.Point(569, 109);
            this.cbPullFromTo.Name = "cbPullFromTo";
            this.cbPullFromTo.Size = new System.Drawing.Size(105, 17);
            this.cbPullFromTo.TabIndex = 59;
            this.cbPullFromTo.Text = "ดึงข้อมูล From-To";
            this.cbPullFromTo.UseVisualStyleBackColor = true;
            this.cbPullFromTo.CheckedChanged += new System.EventHandler(this.cbPullFromTo_CheckedChanged);
            // 
            // cbPullFrom
            // 
            this.cbPullFrom.AutoSize = true;
            this.cbPullFrom.Location = new System.Drawing.Point(680, 109);
            this.cbPullFrom.Name = "cbPullFrom";
            this.cbPullFrom.Size = new System.Drawing.Size(120, 17);
            this.cbPullFrom.TabIndex = 58;
            this.cbPullFrom.Text = "ดึงข้อมูลเฉพาะ From";
            this.cbPullFrom.UseVisualStyleBackColor = true;
            this.cbPullFrom.CheckedChanged += new System.EventHandler(this.cbPullFrom_CheckedChanged);
            // 
            // cbPullAll
            // 
            this.cbPullAll.AutoSize = true;
            this.cbPullAll.Checked = true;
            this.cbPullAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPullAll.Location = new System.Drawing.Point(806, 109);
            this.cbPullAll.Name = "cbPullAll";
            this.cbPullAll.Size = new System.Drawing.Size(96, 17);
            this.cbPullAll.TabIndex = 57;
            this.cbPullAll.Text = "ดึงข้อมูลทั้งหมด";
            this.cbPullAll.UseVisualStyleBackColor = true;
            this.cbPullAll.CheckedChanged += new System.EventHandler(this.cbPullAll_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "From";
            // 
            // DtpTo
            // 
            this.DtpTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTo.Location = new System.Drawing.Point(579, 77);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(323, 26);
            this.DtpTo.TabIndex = 50;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFrom.Location = new System.Drawing.Point(579, 36);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(323, 26);
            this.DtpFrom.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(928, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 90);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TransectionError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TransectionError";
            this.Size = new System.Drawing.Size(1061, 669);
            this.Load += new System.EventHandler(this.TransectionError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbPullAll;
        private System.Windows.Forms.CheckBox cbPullFrom;
        private System.Windows.Forms.CheckBox cbPullFromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
    }
}
