using BusinessLogic.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public class DashboardController
    {
        private readonly DashboardRepository _repo = new DashboardRepository();

        public (int TotalStudents, int CurrentlyEnrolled, int TotalSections, int PendingPayments) GetDashboardMetrics()
        {
            return _repo.GetMetrics();
        }
    }
}
