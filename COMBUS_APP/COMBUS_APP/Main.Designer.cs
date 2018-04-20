namespace COMBUS_APP
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMainmenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.BtnManagement = new System.Windows.Forms.Button();
            this.panelStore = new System.Windows.Forms.Panel();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnCompany = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timerStore = new System.Windows.Forms.Timer(this.components);
            this.timerEmployee = new System.Windows.Forms.Timer(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnEmployeeManagement = new System.Windows.Forms.Button();
            this.BtnStore = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panelMainmenu.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.panelStore.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainmenu
            // 
            this.panelMainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMainmenu.Controls.Add(this.button1);
            this.panelMainmenu.Controls.Add(this.label1);
            this.panelMainmenu.Controls.Add(this.SidePanel);
            this.panelMainmenu.Controls.Add(this.BtnReport);
            this.panelMainmenu.Controls.Add(this.BtnEmployeeManagement);
            this.panelMainmenu.Controls.Add(this.BtnStore);
            this.panelMainmenu.Controls.Add(this.BtnHome);
            this.panelMainmenu.Controls.Add(this.panel5);
            this.panelMainmenu.Controls.Add(this.panelEmployee);
            this.panelMainmenu.Controls.Add(this.panelStore);
            this.panelMainmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainmenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainmenu.Name = "panelMainmenu";
            this.panelMainmenu.Size = new System.Drawing.Size(219, 720);
            this.panelMainmenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "(c)2018 Combus";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(252)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 85);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 58);
            this.SidePanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 85);
            this.panel5.TabIndex = 6;
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.BtnManagement);
            this.panelEmployee.Location = new System.Drawing.Point(0, 607);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(219, 38);
            this.panelEmployee.TabIndex = 15;
            // 
            // BtnManagement
            // 
            this.BtnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManagement.FlatAppearance.BorderSize = 0;
            this.BtnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagement.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagement.ForeColor = System.Drawing.Color.White;
            this.BtnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManagement.Location = new System.Drawing.Point(0, 0);
            this.BtnManagement.Name = "BtnManagement";
            this.BtnManagement.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnManagement.Size = new System.Drawing.Size(219, 38);
            this.BtnManagement.TabIndex = 12;
            this.BtnManagement.Text = "  Management";
            this.BtnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnManagement.UseVisualStyleBackColor = true;
            this.BtnManagement.Click += new System.EventHandler(this.BtnManagement_Click);
            // 
            // panelStore
            // 
            this.panelStore.Controls.Add(this.BtnProduct);
            this.panelStore.Controls.Add(this.BtnCompany);
            this.panelStore.Location = new System.Drawing.Point(1, 504);
            this.panelStore.Name = "panelStore";
            this.panelStore.Size = new System.Drawing.Size(219, 76);
            this.panelStore.TabIndex = 7;
            // 
            // BtnProduct
            // 
            this.BtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduct.FlatAppearance.BorderSize = 0;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduct.ForeColor = System.Drawing.Color.White;
            this.BtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduct.Location = new System.Drawing.Point(0, 38);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnProduct.Size = new System.Drawing.Size(219, 38);
            this.BtnProduct.TabIndex = 14;
            this.BtnProduct.Text = "  Product";
            this.BtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // BtnCompany
            // 
            this.BtnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompany.FlatAppearance.BorderSize = 0;
            this.BtnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompany.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompany.ForeColor = System.Drawing.Color.White;
            this.BtnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompany.Location = new System.Drawing.Point(0, 0);
            this.BtnCompany.Name = "BtnCompany";
            this.BtnCompany.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnCompany.Size = new System.Drawing.Size(219, 38);
            this.BtnCompany.TabIndex = 12;
            this.BtnCompany.Text = "  Company";
            this.BtnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompany.UseVisualStyleBackColor = true;
            this.BtnCompany.Click += new System.EventHandler(this.BtnCompany_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(252)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 85);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ware       ouse.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(252)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 10);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(219, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1061, 669);
            this.panel4.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(192, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 85);
            this.panel7.TabIndex = 8;
            // 
            // timerStore
            // 
            this.timerStore.Interval = 10;
            this.timerStore.Tick += new System.EventHandler(this.timerStore_Tick);
            // 
            // timerEmployee
            // 
            this.timerEmployee.Interval = 10;
            this.timerEmployee.Tick += new System.EventHandler(this.timerEmployee_Tick);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(1246, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(26, 29);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 317);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(219, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = " Transaction\r\n Error";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(0, 259);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnReport.Size = new System.Drawing.Size(219, 58);
            this.BtnReport.TabIndex = 10;
            this.BtnReport.Text = " Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnEmployeeManagement
            // 
            this.BtnEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.BtnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployeeManagement.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.BtnEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployeeManagement.Location = new System.Drawing.Point(0, 201);
            this.BtnEmployeeManagement.Name = "BtnEmployeeManagement";
            this.BtnEmployeeManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnEmployeeManagement.Size = new System.Drawing.Size(219, 58);
            this.BtnEmployeeManagement.TabIndex = 9;
            this.BtnEmployeeManagement.Text = " Employee";
            this.BtnEmployeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmployeeManagement.UseVisualStyleBackColor = true;
            this.BtnEmployeeManagement.Click += new System.EventHandler(this.BtnEmployeeManagement_Click_1);
            // 
            // BtnStore
            // 
            this.BtnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStore.FlatAppearance.BorderSize = 0;
            this.BtnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStore.ForeColor = System.Drawing.Color.White;
            this.BtnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStore.Location = new System.Drawing.Point(0, 143);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnStore.Size = new System.Drawing.Size(219, 58);
            this.BtnStore.TabIndex = 8;
            this.BtnStore.Text = " Store";
            this.BtnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStore.UseVisualStyleBackColor = true;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 85);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(219, 58);
            this.BtnHome.TabIndex = 7;
            this.BtnHome.Text = " Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMainmenu.ResumeLayout(false);
            this.panelMainmenu.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelStore.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainmenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnEmployeeManagement;
        private System.Windows.Forms.Button BtnStore;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStore;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnCompany;
        private System.Windows.Forms.Timer timerStore;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button BtnManagement;
        private System.Windows.Forms.Timer timerEmployee;
        private System.Windows.Forms.Button button1;
    }
}

