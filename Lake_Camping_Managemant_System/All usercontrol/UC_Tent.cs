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
    public partial class UC_Tent : UserControl
    {

        OleDbConnection con;
        OleDbCommand cmd;
        public UC_Tent()
        {
            InitializeComponent();
        }

        private void registrer_Click(object sender, EventArgs e)
        {

            if (isvlid_ID(txtid.Text) && isvlid_type(txtttype.Text) && isvlid_plan(txtplan.Text))
            {

                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Tent(ID,ttype,plan) VALUES ('" + txtid.Text + "','" + txtttype.Text + "','" + txtplan.Text + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("registered succesful");
                txtid.Clear();
                txtttype.SelectedIndex = -1;


                txtplan.SelectedIndex = -1;



            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool isvlid_ID(string n)
        {
            Regex check = new Regex(@"^([0-9]|[1-9][0-9])$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtid, " invalid ID");
                return valid;

            }
        }
        public bool isvlid_type(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z[0-9]|[1-9][0-9]|[1-9][0-9][0-9]]+$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                errorProvider1.Clear();
                return valid;

            }
            else
            {
                errorProvider1.SetError(this.txtttype, " invalid ");
                return valid;

            }


        }
        public bool isvlid_plan(string n)
        {
            Regex check = new Regex(@"^[a-zA-Z[0-9]|[1-9][0-9]|[1-9][0-9][0-9]]+$");
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
