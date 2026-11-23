using BusinessLogic.Controller;

namespace UI
{
    public partial class StaffDashboardForm : Form

    {
        private string currentUsername;
        private string currentRole;
        private System.Windows.Forms.Timer timer;
        private readonly UserController _userController = new UserController();
        private Button _activeButton;

        public StaffDashboardForm(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += SessionCheckTimer_Tick;
            timer.Start();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_activeButton != (Button)btnSender)
                {
                    if (_activeButton != null)
                    {
                        _activeButton.Enabled = true;
                    }
                    _activeButton = (Button)btnSender;
                    _activeButton.Enabled = false;

                    panel1.Focus();
                }
            }
        }

        private void SessionCheckTimer_Tick(object sender, EventArgs e)
        {
            var currentUser = _userController.GetAllUsers()
                .Find(u => u.Username.Equals(currentUsername, StringComparison.OrdinalIgnoreCase));

            if (currentUser.Status == "Inactive")
            {
                timer.Stop();

                MessageBox.Show("Your account has been deactivated. You have been logged out for security reasons.", "Session Terminated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeStaff.Text = "Welcome, " + currentUsername + "   " + "Role: " + currentRole;
            UserControl_Load(new AdminDashboarchUserControl());
        }

        private void btnStudentEnrollment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            StudentEnrollment enrollment = new StudentEnrollment();
            enrollment.TopLevel = false;
            enrollment.FormBorderStyle = FormBorderStyle.None;

            enrollment.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(enrollment);
            enrollment.Show();
        }

        private void btnStudentsAccSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            StudentAccountSearch search = new StudentAccountSearch();
            search.TopLevel = false;
            search.FormBorderStyle = FormBorderStyle.None;

            search.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(search);
            search.Show();
        }

        private void btnPaymentandCashiering_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            PaymentandCashieringForm payment = new PaymentandCashieringForm();
            payment.TopLevel = false;
            payment.FormBorderStyle = FormBorderStyle.None;

            payment.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(payment);
            payment.Show();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            PaymentHistoryandReceiptsForm paymentHistory = new PaymentHistoryandReceiptsForm();
            paymentHistory.TopLevel = false;
            paymentHistory.FormBorderStyle = FormBorderStyle.None;

            paymentHistory.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(paymentHistory);
            paymentHistory.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UserControl_Load(new AdminDashboarchUserControl());
        }

        private void UserControl_Load(UserControl userControl)
        {
            panel3.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}

