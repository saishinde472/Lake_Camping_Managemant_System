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
    public partial class UC_stock : UserControl
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public UC_stock()
        {
            InitializeComponent();
        }

        private void registrer_Click(object sender, EventArgs e)
        {
            if (isvlid_name(txtname.Text) && isvlid_dep(txtdepartment.Text) && isvlid_price(txtprice.Text) && isvlid_quantity(txtquantity.Text) && isvlid_des(txtdescription.Text))
            {

                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO stock(pname,dep,datep,datee,quantity,price,des) VALUES ('" + txtname.Text + "','" + txtdepartment.Text + "','" + txtdate.Text + "','" + txtdate1.Text + "','" + txtquantity.Text + "','" + txtprice.Text + "','" + txtdescription.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered succesful");
                txtname.Clear();
                txtdepartment.SelectedIndex = -1;

                txtquantity.Clear();
                txtdescription.Clear();
                txtprice.Clear();



            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
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
                errorProvider1.SetError(this.txtname, " invalid Product Name");
                return valid;

            }
        }
        public bool isvlid_quantity(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\s,-]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtquantity, " invalid Quantity");
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
        public bool isvlid_price(string n)
        {
            Regex check = new Regex(@"^([1-9]|[1-9][0-9]|[1-9][0-9][0-9]|[1-9][0-9][0-9][0-9])$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtprice, " invalid ");
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

        private void UC_stock_Load(object sender, EventArgs e)
        {

        }
    }
}
