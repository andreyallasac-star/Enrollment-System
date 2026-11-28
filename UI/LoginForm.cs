using BusinessLogic.Controller;
using System;
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
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter the account's username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter the account's password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AuthController authController = new AuthController();
            var result = authController.Login(txtUsername.Text.Trim(), txtPassword.Text);

            if (result.Success)
            {
                if (result.Role == "Admin" || result.Role == "Registrar" || result.Role == "Cashier")
                {
                    DashboardForm dashboard = new DashboardForm(result.Username, result.Role);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Unrecognized user role: {result.Role}. Please contact the Administrator.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}