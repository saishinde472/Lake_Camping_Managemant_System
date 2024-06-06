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
    public partial class UC_Staff : UserControl
    {
        OleDbConnection con;
        OleDbCommand cmd;
        
        public UC_Staff()
        {
            InitializeComponent();
        }
        private void maxid()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
            cmd = new OleDbCommand();
            con.Open();
            OleDbCommand maxCommand = new OleDbCommand("SELECT max(id) from Emp", con);
            Int32 max = (Int32)maxCommand.ExecuteScalar();
            labelid.Text = (max + 1).ToString();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (isvlid_name(txtname.Text) && isvlid_dep(txtdepartment.Text) && isvlid_phone(txtphone.Text) && isvlid_Username(txtusername.Text) && isvlid_Password(txtpassword.Text))
            {

                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Emp(name,department,phoneno,username,pass) VALUES ('" + txtname.Text + "','" + txtdepartment.Text + "','" + txtphone.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("registered succesful");
                txtname.Clear();
                txtdepartment.SelectedIndex = -1;

                txtphone.Clear();
                txtusername.Clear();
                txtpassword.Clear();
                maxid();


            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            con.Close();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Staff_Load(object sender, EventArgs e)
        {
            maxid();
        }

        private void staffdetails_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtidd.Text != "")
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");



                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Emp WHERE ID = " + txtidd.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidd.Clear();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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
                errorProvider1.SetError(this.txtphone, " invalid Phone Number");
                return valid;

            }
        }
        public bool isvlid_dep(string n)
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
                errorProvider1.SetError(this.txtdepartment, " invalid Department");
                return valid;

            }


        }
        public bool isvlid_Username(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtusername, " invalid Username");
                return valid;

            }


        }
        public bool isvlid_Password(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtpassword, " invalid Password");
                return valid;

            }


        }

        private void Staff_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}

