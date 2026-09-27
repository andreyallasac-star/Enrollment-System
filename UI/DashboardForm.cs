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

        private void button7_Click(object sender, EventArgs e)
        {

            AssessmentForm ass = new AssessmentForm();
            ass.TopLevel = false;
            ass.FormBorderStyle = FormBorderStyle.None;

            ass.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(ass);
            ass.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentAccountSearch search = new StudentAccountSearch();
            search.TopLevel = false;
            search.FormBorderStyle = FormBorderStyle.None;

            search.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(search);
            search.Show();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountManagement user = new UserAccountManagement();
            user.TopLevel = false;
            user.FormBorderStyle = FormBorderStyle.None;

            user.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(user);
            user.Show();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagementForm student = new StudentManagementForm();
            student.TopLevel = false;
            student.FormBorderStyle = FormBorderStyle.None;

            student.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(student);
            student.Show();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            SectionManagement section = new SectionManagement();
            section.TopLevel = false;
            section.FormBorderStyle = FormBorderStyle.None;

            section.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(section);
            section.Show();
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

        private void btnPaymentCashiering_Click(object sender, EventArgs e)
        {
            PaymentandCashieringForm payment = new PaymentandCashieringForm();
            payment.TopLevel = false;
            payment.FormBorderStyle = FormBorderStyle.None;

            payment.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(payment);
            payment.Show();
        }

        private void btnPaymentHistoryReceipts_Click(object sender, EventArgs e)
        {
            PaymentHistoryandReceiptsForm paymentHistory = new PaymentHistoryandReceiptsForm();
            paymentHistory.TopLevel = false;
            paymentHistory.FormBorderStyle = FormBorderStyle.None;

            paymentHistory.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(paymentHistory);
            paymentHistory.Show();
        }

        private void btnStudentInfoReport_Click(object sender, EventArgs e)
        {
            StudentInformationReport report = new StudentInformationReport();
            report.TopLevel = false;
            report.FormBorderStyle = FormBorderStyle.None;

            report.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(report);
            report.Show();
        }

        
    }
}
