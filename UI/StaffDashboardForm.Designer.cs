namespace UI
{
    partial class StaffDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblWelcomeStaff = new Label();
            lblStaffDashboardMenu = new Label();
            panel2 = new Panel();
            btnDashboard = new Button();
            btnLogOut = new Button();
            btnPaymentHistory = new Button();
            btnPaymentandCashiering = new Button();
            btnStudentsAccSearch = new Button();
            btnStudentEnrollment = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(lblWelcomeStaff);
            panel1.Controls.Add(lblStaffDashboardMenu);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1585, 110);
            panel1.TabIndex = 0;
            // 
            // lblWelcomeStaff
            // 
            lblWelcomeStaff.AutoSize = true;
            lblWelcomeStaff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStaff.ForeColor = Color.White;
            lblWelcomeStaff.Location = new Point(1779, 28);
            lblWelcomeStaff.Name = "lblWelcomeStaff";
            lblWelcomeStaff.Size = new Size(48, 41);
            lblWelcomeStaff.TabIndex = 1;
            lblWelcomeStaff.Text = "W";
            // 
            // lblStaffDashboardMenu
            // 
            lblStaffDashboardMenu.AutoSize = true;
            lblStaffDashboardMenu.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffDashboardMenu.ForeColor = Color.White;
            lblStaffDashboardMenu.Location = new Point(65, 34);
            lblStaffDashboardMenu.Name = "lblStaffDashboardMenu";
            lblStaffDashboardMenu.Size = new Size(379, 46);
            lblStaffDashboardMenu.TabIndex = 0;
            lblStaffDashboardMenu.Text = "Staff Dashboard Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnPaymentHistory);
            panel2.Controls.Add(btnPaymentandCashiering);
            panel2.Controls.Add(btnStudentsAccSearch);
            panel2.Controls.Add(btnStudentEnrollment);
            panel2.Location = new Point(-2, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 1317);
            panel2.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Azure;
            btnDashboard.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnDashboard.Location = new Point(25, 36);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(299, 81);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Azure;
            btnLogOut.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnLogOut.Location = new Point(25, 571);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(299, 81);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = Color.Azure;
            btnPaymentHistory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnPaymentHistory.Location = new Point(25, 465);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(299, 81);
            btnPaymentHistory.TabIndex = 3;
            btnPaymentHistory.Text = "Payment History and Receipts";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Click += btnPaymentHistory_Click;
            // 
            // btnPaymentandCashiering
            // 
            btnPaymentandCashiering.BackColor = Color.Azure;
            btnPaymentandCashiering.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnPaymentandCashiering.Location = new Point(25, 360);
            btnPaymentandCashiering.Name = "btnPaymentandCashiering";
            btnPaymentandCashiering.Size = new Size(299, 81);
            btnPaymentandCashiering.TabIndex = 2;
            btnPaymentandCashiering.Text = "Payment and Cashiering";
            btnPaymentandCashiering.UseVisualStyleBackColor = false;
            btnPaymentandCashiering.Click += btnPaymentandCashiering_Click;
            // 
            // btnStudentsAccSearch
            // 
            btnStudentsAccSearch.BackColor = Color.Azure;
            btnStudentsAccSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnStudentsAccSearch.Location = new Point(25, 252);
            btnStudentsAccSearch.Name = "btnStudentsAccSearch";
            btnStudentsAccSearch.Size = new Size(299, 81);
            btnStudentsAccSearch.TabIndex = 1;
            btnStudentsAccSearch.Text = "Student Account Search";
            btnStudentsAccSearch.UseVisualStyleBackColor = false;
            btnStudentsAccSearch.Click += btnStudentsAccSearch_Click;
            // 
            // btnStudentEnrollment
            // 
            btnStudentEnrollment.BackColor = Color.Azure;
            btnStudentEnrollment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnStudentEnrollment.Location = new Point(25, 145);
            btnStudentEnrollment.Name = "btnStudentEnrollment";
            btnStudentEnrollment.Size = new Size(299, 81);
            btnStudentEnrollment.TabIndex = 0;
            btnStudentEnrollment.Text = "Student Enrollment";
            btnStudentEnrollment.UseVisualStyleBackColor = false;
            btnStudentEnrollment.Click += btnStudentEnrollment_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(366, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1824, 1318);
            panel3.TabIndex = 2;
            // 
            // StaffDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1536, 965);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboardForm";
            Load += StaffDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblStaffDashboardMenu;
        private Label lblWelcomeStaff;
        private Panel panel2;
        private Button btnStudentEnrollment;
        private Button btnStudentsAccSearch;
        private Button btnLogOut;
        private Button btnPaymentHistory;
        private Button btnPaymentandCashiering;
        private Panel panel3;
        private Button btnDashboard;
    }
}