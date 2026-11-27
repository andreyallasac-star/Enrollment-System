namespace UI
{
    partial class DashboardForm
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
            label1 = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            label6 = new Label();
            lblWelcome = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnStudentInfoReport = new Button();
            btnPaymentHistoryReceipts = new Button();
            btnPaymentCashiering = new Button();
            btnAssessment = new Button();
            btnStudentEnrollment = new Button();
            btnSectionManagement = new Button();
            btnStudentManagement = new Button();
            btnUserAccount = new Button();
            btnSearch = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(453, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Enrollment System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, -4);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 88);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DeepSkyBlue;
            btnLogout.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1748, 18);
            btnLogout.Margin = new Padding(2, 4, 2, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(154, 58);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1978, 12);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 54);
            label6.TabIndex = 4;
            label6.Text = " │";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.DeepSkyBlue;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Control;
            lblWelcome.Location = new Point(1218, 24);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(39, 41);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(28, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 54);
            label2.TabIndex = 2;
            label2.Text = "🎓";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnStudentInfoReport);
            panel2.Controls.Add(btnPaymentHistoryReceipts);
            panel2.Controls.Add(btnPaymentCashiering);
            panel2.Controls.Add(btnAssessment);
            panel2.Controls.Add(btnStudentEnrollment);
            panel2.Controls.Add(btnSectionManagement);
            panel2.Controls.Add(btnStudentManagement);
            panel2.Controls.Add(btnUserAccount);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(12, 88);
            panel2.Margin = new Padding(2, 4, 2, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 990);
            panel2.TabIndex = 2;
            // 
            // btnStudentInfoReport
            // 
            btnStudentInfoReport.BackColor = Color.Azure;
            btnStudentInfoReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfoReport.ForeColor = Color.Black;
            btnStudentInfoReport.Location = new Point(22, 809);
            btnStudentInfoReport.Margin = new Padding(2, 4, 2, 4);
            btnStudentInfoReport.Name = "btnStudentInfoReport";
            btnStudentInfoReport.Size = new Size(286, 68);
            btnStudentInfoReport.TabIndex = 11;
            btnStudentInfoReport.Text = "Student Information Report";
            btnStudentInfoReport.UseVisualStyleBackColor = false;
            btnStudentInfoReport.Click += btnStudentInfoReport_Click;
            // 
            // btnPaymentHistoryReceipts
            // 
            btnPaymentHistoryReceipts.BackColor = Color.Azure;
            btnPaymentHistoryReceipts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentHistoryReceipts.ForeColor = Color.Black;
            btnPaymentHistoryReceipts.Location = new Point(22, 721);
            btnPaymentHistoryReceipts.Margin = new Padding(2, 4, 2, 4);
            btnPaymentHistoryReceipts.Name = "btnPaymentHistoryReceipts";
            btnPaymentHistoryReceipts.Size = new Size(286, 68);
            btnPaymentHistoryReceipts.TabIndex = 10;
            btnPaymentHistoryReceipts.Text = "Payment History/ Receipts";
            btnPaymentHistoryReceipts.UseVisualStyleBackColor = false;
            btnPaymentHistoryReceipts.Click += btnPaymentHistoryReceipts_Click;
            // 
            // btnPaymentCashiering
            // 
            btnPaymentCashiering.BackColor = Color.Azure;
            btnPaymentCashiering.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentCashiering.ForeColor = Color.Black;
            btnPaymentCashiering.Location = new Point(22, 636);
            btnPaymentCashiering.Margin = new Padding(2, 4, 2, 4);
            btnPaymentCashiering.Name = "btnPaymentCashiering";
            btnPaymentCashiering.Size = new Size(286, 68);
            btnPaymentCashiering.TabIndex = 9;
            btnPaymentCashiering.Text = "Payment/Cashiering";
            btnPaymentCashiering.UseVisualStyleBackColor = false;
            btnPaymentCashiering.Click += btnPaymentCashiering_Click;
            // 
            // btnAssessment
            // 
            btnAssessment.BackColor = Color.Azure;
            btnAssessment.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssessment.ForeColor = Color.Black;
            btnAssessment.Location = new Point(22, 548);
            btnAssessment.Margin = new Padding(2, 4, 2, 4);
            btnAssessment.Name = "btnAssessment";
            btnAssessment.Size = new Size(286, 68);
            btnAssessment.TabIndex = 6;
            btnAssessment.Text = "Student Assessment";
            btnAssessment.UseVisualStyleBackColor = false;
            btnAssessment.Click += btnAssessment_Click;
            // 
            // btnStudentEnrollment
            // 
            btnStudentEnrollment.BackColor = Color.Azure;
            btnStudentEnrollment.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentEnrollment.ForeColor = Color.Black;
            btnStudentEnrollment.Location = new Point(22, 460);
            btnStudentEnrollment.Margin = new Padding(2, 4, 2, 4);
            btnStudentEnrollment.Name = "btnStudentEnrollment";
            btnStudentEnrollment.Size = new Size(286, 68);
            btnStudentEnrollment.TabIndex = 7;
            btnStudentEnrollment.Text = "Student Enrollment";
            btnStudentEnrollment.UseVisualStyleBackColor = false;
            btnStudentEnrollment.Click += btnStudentEnrollment_Click;
            // 
            // btnSectionManagement
            // 
            btnSectionManagement.BackColor = Color.Azure;
            btnSectionManagement.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSectionManagement.ForeColor = Color.Black;
            btnSectionManagement.Location = new Point(22, 375);
            btnSectionManagement.Margin = new Padding(2, 4, 2, 4);
            btnSectionManagement.Name = "btnSectionManagement";
            btnSectionManagement.Size = new Size(286, 68);
            btnSectionManagement.TabIndex = 6;
            btnSectionManagement.Text = "Section Management";
            btnSectionManagement.UseVisualStyleBackColor = false;
            btnSectionManagement.Click += btnSectionManagement_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.Azure;
            btnStudentManagement.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentManagement.ForeColor = Color.Black;
            btnStudentManagement.Location = new Point(22, 289);
            btnStudentManagement.Margin = new Padding(2, 4, 2, 4);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(286, 68);
            btnStudentManagement.TabIndex = 5;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = false;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // btnUserAccount
            // 
            btnUserAccount.BackColor = Color.Azure;
            btnUserAccount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserAccount.ForeColor = Color.Black;
            btnUserAccount.Location = new Point(22, 201);
            btnUserAccount.Margin = new Padding(2, 4, 2, 4);
            btnUserAccount.Name = "btnUserAccount";
            btnUserAccount.Size = new Size(286, 68);
            btnUserAccount.TabIndex = 5;
            btnUserAccount.Text = "User Account Management";
            btnUserAccount.UseVisualStyleBackColor = false;
            btnUserAccount.Click += btnUserAccount_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(22, 112);
            btnSearch.Margin = new Padding(2, 4, 2, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(286, 68);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Student Account Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Azure;
            btnDashboard.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(22, 24);
            btnDashboard.Margin = new Padding(2, 4, 2, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(286, 68);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(358, 88);
            panel3.Margin = new Padding(2, 4, 2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1536, 973);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.Location = new Point(6, 81);
            panel4.Margin = new Padding(2, 4, 2, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 1352);
            panel4.TabIndex = 12;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1536, 965);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnStudentEnrollment;
        private Button btnSectionManagement;
        private Button btnStudentManagement;
        private Button btnUserAccount;
        private Button btnSearch;
        private Button btnStudentInfoReport;
        private Button btnPaymentHistoryReceipts;
        private Button btnPaymentCashiering;
        private Button btnAssessment;
        private Button btnLogout;
        private Panel panel3;
        private Label lblWelcome;
        private Panel panel4;
    }
}