using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lake_Camping_Managemant_System
{
    public partial class Dashboard : Form
    {
        public string Username;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            this.Close();
            Loginform ds = new Loginform();
            ds.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
            uC_Staff1.Visible = true;
            uC_payment1.Visible = false;
            uC_Supplier1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDatetime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            MovePanel(btnstaff);
            uC_Staff1.Visible = true;
            uC_payment1.Visible = false;
            uC_Supplier1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            MovePanel(btnbooking);
            this.Close();
            Booking ds = new Booking();
            ds.Show();
            uC_payment1.Visible = false;
            uC_Staff1.Visible = false;
            uC_Supplier1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            MovePanel(btnsupplier);
            uC_Supplier1.Visible = true;
            uC_Staff1.Visible = false;
            uC_payment1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            MovePanel(btnstock);
            uC_stock1.Visible = true;
            uC_Supplier1.Visible = false;
            uC_Staff1.Visible = false;
            uC_payment1.Visible = false;
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            MovePanel(btnpayment);
            uC_payment1.Visible = true;
            uC_Supplier1.Visible = false;
            uC_Staff1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            MovePanel(btnfeedback);
            uC_Supplier1.Visible = false;
            uC_Staff1.Visible = false;
            uC_payment1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void btnreorts_Click(object sender, EventArgs e)
        {
            MovePanel(btnreorts);
            uC_Supplier1.Visible = false;
            uC_Staff1.Visible = false;
            uC_payment1.Visible = false;
            uC_stock1.Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelslide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_stock1_Load(object sender, EventArgs e)
        {

        }
    }
}
