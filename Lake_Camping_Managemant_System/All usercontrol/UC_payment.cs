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
    public partial class UC_payment : UserControl
    {

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public UC_payment()
        {
            InitializeComponent();
        }

        private void txtplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where plan='" + txtplan.Text + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string price = (string)dr["price"].ToString();
                txtprice.Text = price;

            }
            con.Close();
        }

        private void registrer_Click(object sender, EventArgs e)
        {
            
            if (isvlid_ID(txtid.Text) && isvlid_name(txtname.Text) && isvlid_plan(txtplan.Text) )
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Payment(ID,name,plan,price) VALUES ('" + txtid.Text + "','" + txtname.Text + "','" + txtplan.Text + "','" + txtprice.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("registered succesful");
                txtbill.Clear();
                txtbill.Text += "**************************************************************************************\n";
                txtbill.Text += "**                                              Invoice                                            **\n";
                txtbill.Text += "**************************************************************************************\n\n";
                txtbill.Text += "      Date :" + DateTime.Now + "\n\n\n";

                txtbill.Text += "      ID :" + txtid.Text + "\n\n\n";
                txtbill.Text += "      Name :" + txtname.Text + "\n\n\n";
                txtbill.Text += "      Plan :" + txtplan.Text + "\n\n\n\n";
                txtbill.Text += "                                            Amount -" + txtprice.Text + "\n\n\n\n\n\n\n\n";


                txtbill.Text += "\n                                                                        Signature";
                txtid.Clear();
                txtplan.SelectedIndex = -1;
                txtname.Clear();

                txtprice.Clear();



            }
            else
            {

                MessageBox.Show("fill all fields", "waring....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            txtbill.Clear();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtbill.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
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

       