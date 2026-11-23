using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminDashboarchUserControl : UserControl
    {
        private readonly DashboardController _dashboardController = new DashboardController();
        public AdminDashboarchUserControl()
        {
            InitializeComponent();
        }

        private void AdminDashboarchUserControl_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        public void RefreshDashboard()
        {
            try
            {
                var metrics = _dashboardController.GetDashboardMetrics();

                lblNumberOfStudents.Text = metrics.TotalStudents.ToString();
                lblNumberOfCurrentlyEnrolled.Text = metrics.CurrentlyEnrolled.ToString();
                lblNumberOfTotalSection.Text = metrics.TotalSections.ToString();
                lblNumberOfPendingPayment.Text = metrics.PendingPayments.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblNumberOfStudents.Text = "0";
                lblNumberOfCurrentlyEnrolled.Text = "0";
                lblNumberOfTotalSection.Text = "0";
                lblNumberOfPendingPayment.Text = "0";
            }
        }
    }
}
