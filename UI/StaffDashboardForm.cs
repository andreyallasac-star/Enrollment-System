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
    }
}
