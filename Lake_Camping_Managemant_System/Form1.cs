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

namespace Lake_Camping_Managemant_System
{
    public partial class Loginform : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Loginform()
        {
            InitializeComponent();
        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/saish/source/repos/Lake_Camping_Managemant_System/Lake_Camping_Managemant_System/bin/Debug/demo.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Emp where username='" + txtusername.Text + "' AND pass='" + txtpassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelerror.Visible = false;
                Dashboard ds = new Dashboard();
                ds.Username = txtusername.Text;

                txtusername.Clear();
                txtpassword.Clear();
                this.Hide();
                ds.Show();

            }
            else
            {
                labelerror.Visible = true;
                txtpassword.Clear();
            }

            con.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Loginform_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
