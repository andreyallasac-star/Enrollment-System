using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class StaffDashboardForm : Form
    {
        private string currentUsername;
        private string currentRole;
        public StaffDashboardForm(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;
        }

        private void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeStaff.Text = "Welcome, " + currentUsername + "   " + "Role: " + currentRole;
        }
    }
}
