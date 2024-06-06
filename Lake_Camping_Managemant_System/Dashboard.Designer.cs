
namespace Lake_Camping_Managemant_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelslide = new System.Windows.Forms.Panel();
            this.btnreorts = new System.Windows.Forms.Button();
            this.btnfeedback = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnbooking = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btnstock = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.uC_stock1 = new Lake_Camping_Managemant_System.All_usercontrol.UC_stock();
            this.uC_Supplier1 = new Lake_Camping_Managemant_System.All_usercontrol.UC_Supplier();
            this.uC_payment1 = new Lake_Camping_Managemant_System.All_usercontrol.UC_payment();
            this.uC_Staff1 = new Lake_Camping_Managemant_System.All_usercontrol.UC_Staff();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 192);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.panelslide);
            this.panel2.Controls.Add(this.btnreorts);
            this.panel2.Controls.Add(this.btnfeedback);
            this.panel2.Controls.Add(this.btnpayment);
            this.panel2.Controls.Add(this.btnbooking);
            this.panel2.Controls.Add(this.btnsupplier);
            this.panel2.Controls.Add(this.btnstock);
            this.panel2.Controls.Add(this.btnstaff);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 945);
            this.panel2.TabIndex = 1;
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.White;
            this.panelslide.Location = new System.Drawing.Point(37, 223);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(10, 51);
            this.panelslide.TabIndex = 8;
            this.panelslide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelslide_Paint);
            // 
            // btnreorts
            // 
            this.btnreorts.FlatAppearance.BorderSize = 0;
            this.btnreorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreorts.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreorts.ForeColor = System.Drawing.Color.White;
            this.btnreorts.Image = ((System.Drawing.Image)(resources.GetObject("btnreorts.Image")));
            this.btnreorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreorts.Location = new System.Drawing.Point(52, 573);
            this.btnreorts.Name = "btnreorts";
            this.btnreorts.Size = new System.Drawing.Size(194, 49);
            this.btnreorts.TabIndex = 7;
            this.btnreorts.Text = "           Report";
            this.btnreorts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreorts.UseVisualStyleBackColor = true;
            this.btnreorts.Click += new System.EventHandler(this.btnreorts_Click);
            // 
            // btnfeedback
            // 
            this.btnfeedback.FlatAppearance.BorderSize = 0;
            this.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfeedback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfeedback.ForeColor = System.Drawing.Color.White;
            this.btnfeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnfeedback.Image")));
            this.btnfeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfeedback.Location = new System.Drawing.Point(53, 515);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(194, 49);
            this.btnfeedback.TabIndex = 6;
            this.btnfeedback.Text = "           Feedback";
            this.btnfeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfeedback.UseVisualStyleBackColor = true;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.White;
            this.btnpayment.Image = ((System.Drawing.Image)(resources.GetObject("btnpayment.Image")));
            this.btnpayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpayment.Location = new System.Drawing.Point(53, 457);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(194, 49);
            this.btnpayment.TabIndex = 5;
            this.btnpayment.Text = "           Payment";
            this.btnpayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btnbooking
            // 
            this.btnbooking.FlatAppearance.BorderSize = 0;
            this.btnbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.ForeColor = System.Drawing.Color.White;
            this.btnbooking.Image = ((System.Drawing.Image)(resources.GetObject("btnbooking.Image")));
            this.btnbooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbooking.Location = new System.Drawing.Point(52, 283);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(194, 49);
            this.btnbooking.TabIndex = 4;
            this.btnbooking.Text = "           Booking";
            this.btnbooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // btnsupplier
            // 
            this.btnsupplier.FlatAppearance.BorderSize = 0;
            this.btnsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupplier.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.ForeColor = System.Drawing.Color.White;
            this.btnsupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnsupplier.Image")));
            this.btnsupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupplier.Location = new System.Drawing.Point(53, 341);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(194, 49);
            this.btnsupplier.TabIndex = 3;
            this.btnsupplier.Text = "           Supplier";
            this.btnsupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsupplier.UseVisualStyleBackColor = true;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // btnstock
            // 
            this.btnstock.FlatAppearance.BorderSize = 0;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.Image = ((System.Drawing.Image)(resources.GetObject("btnstock.Image")));
            this.btnstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstock.Location = new System.Drawing.Point(52, 399);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(194, 49);
            this.btnstock.TabIndex = 2;
            this.btnstock.Text = "           Stock";
            this.btnstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstock.UseVisualStyleBackColor = true;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.FlatAppearance.BorderSize = 0;
            this.btnstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.Image = ((System.Drawing.Image)(resources.GetObject("btnstaff.Image")));
            this.btnstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstaff.Location = new System.Drawing.Point(53, 225);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(194, 49);
            this.btnstaff.TabIndex = 1;
            this.btnstaff.Text = "           Staff";
            this.btnstaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.labelUsername);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(282, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1426, 189);
            this.panel3.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(1062, 113);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(93, 54);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(121, 136);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(19, 19);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1161, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 23);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.labelDatetime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1426, 100);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1356, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // labelDatetime
            // 
            this.labelDatetime.AutoSize = true;
            this.labelDatetime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatetime.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelDatetime.Location = new System.Drawing.Point(6, 72);
            this.labelDatetime.Name = "labelDatetime";
            this.labelDatetime.Size = new System.Drawing.Size(19, 19);
            this.labelDatetime.TabIndex = 3;
            this.labelDatetime.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uC_stock1);
            this.panel5.Controls.Add(this.uC_Supplier1);
            this.panel5.Controls.Add(this.uC_payment1);
            this.panel5.Controls.Add(this.uC_Staff1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(282, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1426, 756);
            this.panel5.TabIndex = 3;
            // 
            // uC_stock1
            // 
            this.uC_stock1.BackColor = System.Drawing.Color.White;
            this.uC_stock1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_stock1.Location = new System.Drawing.Point(0, 0);
            this.uC_stock1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_stock1.Name = "uC_stock1";
            this.uC_stock1.Size = new System.Drawing.Size(1355, 697);
            this.uC_stock1.TabIndex = 3;
            this.uC_stock1.Load += new System.EventHandler(this.uC_stock1_Load);
            // 
            // uC_Supplier1
            // 
            this.uC_Supplier1.BackColor = System.Drawing.Color.White;
            this.uC_Supplier1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Supplier1.Location = new System.Drawing.Point(0, 0);
            this.uC_Supplier1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Supplier1.Name = "uC_Supplier1";
            this.uC_Supplier1.Size = new System.Drawing.Size(1355, 697);
            this.uC_Supplier1.TabIndex = 2;
            // 
            // uC_payment1
            // 
            this.uC_payment1.BackColor = System.Drawing.Color.White;
            this.uC_payment1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_payment1.Location = new System.Drawing.Point(0, 0);
            this.uC_payment1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_payment1.Name = "uC_payment1";
            this.uC_payment1.Size = new System.Drawing.Size(1355, 697);
            this.uC_payment1.TabIndex = 1;
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.BackColor = System.Drawing.Color.White;
            this.uC_Staff1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Staff1.Location = new System.Drawing.Point(0, 0);
            this.uC_Staff1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(1426, 756);
            this.uC_Staff1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnpayment;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnsupplier;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnstock;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1708, 945);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnreorts;
        private System.Windows.Forms.Button btnfeedback;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatetime;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel5;
        private All_usercontrol.UC_Staff uC_Staff1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_usercontrol.UC_payment uC_payment1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_usercontrol.UC_Supplier uC_Supplier1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_usercontrol.UC_stock uC_stock1;
    }
}