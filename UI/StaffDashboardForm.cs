using BusinessLogic.Controller;

namespace UI
{
    public partial class StaffDashboardForm : Form

    {
        private string currentUsername;
        private string currentRole;
        private System.Windows.Forms.Timer timer;
        private readonly UserController _userController = new UserController();
    
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

        public StaffDashboardForm(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;
            InitializeComponent();
            currentUsername = username;
            currentRole = role;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += SessionCheckTimer_Tick;
            timer.Start();
        }
        

        private void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeStaff.Text = "Welcome, " + currentUsername + "   " + "Role: " + currentRole;
        }

        private void btnStudentEnrollment_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        }
    }

