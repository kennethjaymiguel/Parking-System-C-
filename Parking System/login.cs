using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parking_System
{
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public login()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=ZXYNETHJEIGN\SQLEXPRESS;Initial Catalog=DB_PARKSYSTEM;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txuserEnter(object sender, EventArgs e)
        {
            if (txtUsermame.Text.Equals("Username"))
            {
                txtUsermame.Text = "";
            }

        }

        private void txuserLeave(object sender, EventArgs e)
        {
            if (txtUsermame.Text.Equals(""))
            {
                txtUsermame.Text = "Username";
            }
        }

      

        private void txpassEnter(object sender, EventArgs e)
        {
            if (txpass.Text.Equals("Password"))
            {
                txpass.Text = "";
            }
        }

        private void txpassLeave(object sender, EventArgs e)
        {
            if (txpass.Text.Equals(""))
            {
                txpass.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUsermame.Text;
            string pass = txpass.Text;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM db_admin where username='" + txtUsermame.Text + "' AND password='" + txpass.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login sucess!");
                this.Hide();
                empdashboard s = new empdashboard();
                s.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox.Checked){txpass.isPassword = false;} else { txpass.isPassword = true;}

        }
    }
}
