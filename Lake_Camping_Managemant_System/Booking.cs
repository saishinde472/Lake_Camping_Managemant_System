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
    public partial class Booking : Form
    {
        
        public Booking()
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
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDatetime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uC_Plan1.Visible = true;
            uC_Booking1.Visible = false;
            uC_parking1.Visible = false;
            uC_Food1.Visible = false;
            uC_Drinks1.Visible = false;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            MovePanel(btnplan);
            uC_Plan1.Visible = true;
            uC_Booking1.Visible = false;
            uC_parking1.Visible = false;
            uC_Food1.Visible = false;
            uC_Drinks1.Visible = false;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            MovePanel(btnbooking);
            uC_Booking1.Visible = true;
            uC_parking1.Visible = false;
            uC_Food1.Visible = false;
            uC_Drinks1.Visible = false;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;
        }

        private void btnparking_Click(object sender, EventArgs e)
        {
            MovePanel(btnparking);
            uC_parking1.Visible = true;
            uC_Food1.Visible = false;
            uC_Drinks1.Visible = false;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            MovePanel(btnFood);
            uC_Food1.Visible = true;
            uC_Drinks1.Visible = false;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            MovePanel(btnDrinks);
            uC_Drinks1.Visible = true;
            uC_Tent1.Visible = false;
            uC_Activity1.Visible = false;
        }

        private void btnTent_Click(object sender, EventArgs e)
        {
            MovePanel(btnTent);
            uC_Tent1.Visible = true;
            uC_Activity1.Visible = false;
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            MovePanel(btnActivity);
            uC_Activity1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds = new Dashboard();
            ds.Show();
        }
    }
}
