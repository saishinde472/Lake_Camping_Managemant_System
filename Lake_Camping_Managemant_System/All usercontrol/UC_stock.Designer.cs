
namespace Lake_Camping_Managemant_System.All_usercontrol
{
    partial class UC_stock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtdepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtdate1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registrer = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtdepartment
            // 
            this.txtdepartment.BackColor = System.Drawing.Color.Transparent;
            this.txtdepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepartment.FocusedState.Parent = this.txtdepartment;
            this.txtdepartment.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtdepartment.ForeColor = System.Drawing.Color.Black;
            this.txtdepartment.HoverState.Parent = this.txtdepartment;
            this.txtdepartment.ItemHeight = 30;
            this.txtdepartment.Items.AddRange(new object[] {
            "Food",
            "Drinks",
            "Tent",
            ""});
            this.txtdepartment.ItemsAppearance.Parent = this.txtdepartment;
            this.txtdepartment.Location = new System.Drawing.Point(80, 331);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.ShadowDecoration.Parent = this.txtdepartment;
            this.txtdepartment.Size = new System.Drawing.Size(405, 36);
            this.txtdepartment.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtdepartment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Department";
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(78, 183);
            this.txtname.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "\r\nEnter Product Name";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(405, 56);
            this.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtname.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product Name";
            // 
            // txtdate
            // 
            this.txtdate.CheckedState.Parent = this.txtdate;
            this.txtdate.FillColor = System.Drawing.Color.White;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.Location = new System.Drawing.Point(82, 439);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(401, 36);
            this.txtdate.TabIndex = 32;
            this.txtdate.Value = new System.DateTime(2021, 10, 27, 9, 46, 42, 653);
            this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
            // 
            // txtdate1
            // 
            this.txtdate1.CheckedState.Parent = this.txtdate1;
            this.txtdate1.FillColor = System.Drawing.Color.White;
            this.txtdate1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate1.HoverState.Parent = this.txtdate1;
            this.txtdate1.Location = new System.Drawing.Point(82, 549);
            this.txtdate1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate1.Name = "txtdate1";
            this.txtdate1.ShadowDecoration.Parent = this.txtdate1;
            this.txtdate1.Size = new System.Drawing.Size(403, 36);
            this.txtdate1.TabIndex = 33;
            this.txtdate1.Value = new System.DateTime(2021, 10, 27, 9, 46, 45, 182);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date of Purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 503);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date of Expiry";
            // 
            // txtquantity
            // 
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.DefaultText = "";
            this.txtquantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtquantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtquantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.DisabledState.Parent = this.txtquantity;
            this.txtquantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.FocusedState.Parent = this.txtquantity;
            this.txtquantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtquantity.ForeColor = System.Drawing.Color.Black;
            this.txtquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.HoverState.Parent = this.txtquantity;
            this.txtquantity.Location = new System.Drawing.Point(660, 183);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "\r\nEnter Quantity";
            this.txtquantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtquantity.SelectedText = "";
            this.txtquantity.ShadowDecoration.Parent = this.txtquantity;
            this.txtquantity.Size = new System.Drawing.Size(405, 56);
            this.txtquantity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtquantity.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Quantity";
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.Parent = this.txtprice;
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.FocusedState.Parent = this.txtprice;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.HoverState.Parent = this.txtprice;
            this.txtprice.Location = new System.Drawing.Point(662, 311);
            this.txtprice.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "\r\nEnter Price";
            this.txtprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtprice.SelectedText = "";
            this.txtprice.ShadowDecoration.Parent = this.txtprice;
            this.txtprice.Size = new System.Drawing.Size(405, 56);
            this.txtprice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtprice.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Price";
            // 
            // txtdescription
            // 
            this.txtdescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescription.DefaultText = "";
            this.txtdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescription.DisabledState.Parent = this.txtdescription;
            this.txtdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescription.FocusedState.Parent = this.txtdescription;
            this.txtdescription.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtdescription.ForeColor = System.Drawing.Color.Black;
            this.txtdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescription.HoverState.Parent = this.txtdescription;
            this.txtdescription.Location = new System.Drawing.Point(662, 418);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.PasswordChar = '\0';
            this.txtdescription.PlaceholderText = "Enter Description";
            this.txtdescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdescription.SelectedText = "";
            this.txtdescription.ShadowDecoration.Parent = this.txtdescription;
            this.txtdescription.Size = new System.Drawing.Size(405, 91);
            this.txtdescription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtdescription.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Description";
            // 
            // registrer
            // 
            this.registrer.BorderRadius = 26;
            this.registrer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.registrer.BorderThickness = 1;
            this.registrer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.registrer.CheckedState.FillColor = System.Drawing.Color.SkyBlue;
            this.registrer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.registrer.CheckedState.Parent = this.registrer;
            this.registrer.CustomImages.Parent = this.registrer;
            this.registrer.FillColor = System.Drawing.Color.White;
            this.registrer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrer.ForeColor = System.Drawing.Color.Black;
            this.registrer.HoverState.Parent = this.registrer;
            this.registrer.Location = new System.Drawing.Point(851, 549);
            this.registrer.Margin = new System.Windows.Forms.Padding(4);
            this.registrer.Name = "registrer";
            this.registrer.ShadowDecoration.Parent = this.registrer;
            this.registrer.Size = new System.Drawing.Size(235, 59);
            this.registrer.TabIndex = 42;
            this.registrer.Text = "Registrer";
            this.registrer.Click += new System.EventHandler(this.registrer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.registrer);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdate1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_stock";
            this.Size = new System.Drawing.Size(1355, 697);
            this.Load += new System.EventHandler(this.UC_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private Guna.UI2.WinForms.Guna2ComboBox txtdepartment;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtdescription;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button registrer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
