﻿
namespace Lake_Camping_Managemant_System.All_usercontrol
{
    partial class UC_Drinks
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.registrer = new Guna.UI2.WinForms.Guna2Button();
            this.txtdtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtplan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.registrer.Location = new System.Drawing.Point(899, 341);
            this.registrer.Margin = new System.Windows.Forms.Padding(4);
            this.registrer.Name = "registrer";
            this.registrer.ShadowDecoration.Parent = this.registrer;
            this.registrer.Size = new System.Drawing.Size(235, 59);
            this.registrer.TabIndex = 37;
            this.registrer.Text = "Registrer";
            this.registrer.Click += new System.EventHandler(this.registrer_Click);
            // 
            // txtdtype
            // 
            this.txtdtype.BackColor = System.Drawing.Color.Transparent;
            this.txtdtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtdtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdtype.FocusedState.Parent = this.txtdtype;
            this.txtdtype.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtdtype.ForeColor = System.Drawing.Color.Black;
            this.txtdtype.HoverState.Parent = this.txtdtype;
            this.txtdtype.ItemHeight = 30;
            this.txtdtype.Items.AddRange(new object[] {
            "Tea",
            "Milk",
            "Coffee",
            "Juice drinks",
            "Soft drinks",
            "Beer",
            "Wine",
            "Whiskey",
            "Vodka"});
            this.txtdtype.ItemsAppearance.Parent = this.txtdtype;
            this.txtdtype.Location = new System.Drawing.Point(149, 364);
            this.txtdtype.Margin = new System.Windows.Forms.Padding(4);
            this.txtdtype.Name = "txtdtype";
            this.txtdtype.ShadowDecoration.Parent = this.txtdtype;
            this.txtdtype.Size = new System.Drawing.Size(405, 36);
            this.txtdtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtdtype.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Drinks Type";
            // 
            // txtplan
            // 
            this.txtplan.BackColor = System.Drawing.Color.Transparent;
            this.txtplan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtplan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtplan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtplan.FocusedState.Parent = this.txtplan;
            this.txtplan.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtplan.ForeColor = System.Drawing.Color.Black;
            this.txtplan.HoverState.Parent = this.txtplan;
            this.txtplan.ItemHeight = 30;
            this.txtplan.Items.AddRange(new object[] {
            "COUPLES",
            "FAMILIES",
            "BACHELORS"});
            this.txtplan.ItemsAppearance.Parent = this.txtplan;
            this.txtplan.Location = new System.Drawing.Point(729, 254);
            this.txtplan.Margin = new System.Windows.Forms.Padding(4);
            this.txtplan.Name = "txtplan";
            this.txtplan.ShadowDecoration.Parent = this.txtplan;
            this.txtplan.Size = new System.Drawing.Size(405, 36);
            this.txtplan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtplan.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Plan";
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(153, 232);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "Enter ID";
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(405, 56);
            this.txtid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtid.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Drinks";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrer);
            this.Controls.Add(this.txtdtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtplan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Drinks";
            this.Size = new System.Drawing.Size(1355, 697);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button registrer;
        private Guna.UI2.WinForms.Guna2ComboBox txtdtype;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txtplan;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
