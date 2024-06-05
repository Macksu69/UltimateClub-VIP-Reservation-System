using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateClub_VIP_Reservation_System
{
    public partial class FormDashboard : Form
    { 
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            User_Control.UserControlClient UC = new User_Control.UserControlClient();
            UC.Show();
            this.Hide();
        }
    }
}
