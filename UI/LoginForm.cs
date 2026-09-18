using BusinessLogic.Controller;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthController authController = new AuthController();
            var result = authController.Login(txtUsername.Text, txtPassword.Text);

            if (result.Success)
            {
                if (result.Role == "Admin")
                {
                    DashboardForm dashboard = new DashboardForm(result.Username, result.Role);
                    dashboard.Show();
                }
                else if (result.Role == "Staff")
                {
                    StaffDashboardForm dashboard = new StaffDashboardForm(result.Username, result.Role);
                    dashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
