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

