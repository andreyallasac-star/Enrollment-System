using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI
{
    public partial class DashboardForm : Form
    {
        private string currentUsername;
        private string currentRole;
        public DashboardForm(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + currentUsername + "   " + "Role: " + currentRole;
        }
    }
}
