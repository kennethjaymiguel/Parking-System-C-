using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_System
{
    public partial class empdashboard : Form
    {
        public empdashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "LOGOUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                this.Hide();
                login s = new login();
                s.Show();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled by the user");
            }

        }

        private void empdashboard_Load(object sender, EventArgs e)
        {
            
            tmr.Start();

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
