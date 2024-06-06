using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Lake_Camping_Managemant_System.All_usercontrol
{
    public partial class UC_Booking : UserControl
    {
        OleDbConnection con;
        OleDbCommand cmd;
        
        public UC_Booking()
        {
            InitializeComponent();
        }
        private void maxid()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
            cmd = new OleDbCommand();
            con.Open();
            OleDbCommand maxCommand = new OleDbCommand("SELECT max(id) from booking", con);
            Int32 max = (Int32)maxCommand.ExecuteScalar();
            labelid.Text = (max + 1).ToString();
        }


        private void registrer_Click(object sender, EventArgs e)
        {
          

            if (isvlid_name(txtname.Text)&& isvlid_phone(txtphoneno.Text)&& isvlid_gender(txtgender.Text)&& isvlid_city(txtcity.Text)&& isvlid_plan(txtplan.Text))
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO booking(name,phoneno,gender,city,plan) VALUES ('" + txtname.Text + "','" + txtphoneno.Text + "','" + txtgender.Text + "','" + txtcity.Text + "','" + txtplan.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered succesful");
                txtname.Clear();
                txtgender.SelectedIndex = -1;

                txtphoneno.Clear();
                txtcity.Clear();
                txtplan.SelectedIndex = -1;
                maxid();


            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            maxid();
        }

        private void txtplan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool isvlid_name(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtname, " invalid Name");
                return valid;

            }
        }
        public bool isvlid_phone(string n)
        {
            Regex check = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtphoneno, " invalid Phone Number");
                return valid;

            }
        }
        public bool isvlid_gender(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtgender, " invalid ");
                return valid;

            }


        }
        public bool isvlid_city(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtcity, " invalid City");
                return valid;

            }
        }
        public bool isvlid_plan(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtplan, " invalid ");
                return valid;

            }


        }
    }
}
