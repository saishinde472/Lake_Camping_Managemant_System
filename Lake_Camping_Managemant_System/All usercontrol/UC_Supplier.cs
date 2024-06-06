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
    public partial class UC_Supplier : UserControl
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public UC_Supplier()
        {
            InitializeComponent();
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrer_Click(object sender, EventArgs e)
        {
            if (isvlid_name(txtname.Text) && isvlid_dep(txtdepartment.Text) && isvlid_phone(txtphoneno.Text) && isvlid_address(txtaddress.Text) && isvlid_des(txtdescription.Text))
            {

                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO supplier(name,pno,address,dep,des) VALUES ('" + txtname.Text + "','" + txtdepartment.Text + "','" + txtaddress.Text + "','" + txtdepartment.Text + "','" + txtdescription.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered succesful");
                txtname.Clear();
                txtdepartment.SelectedIndex = -1;

                txtphoneno.Clear();
                txtdescription.Clear();
                txtaddress.Clear();
                


            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


           
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
        public bool isvlid_address(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\s,-]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtaddress, " invalid ");
                return valid;

            }


        }
        public bool isvlid_des(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\s,-]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtdescription, " invalid ");
                return valid;

            }


        }
    }
}
