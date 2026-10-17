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
            button12 = new Button();
            label6 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnStudentInfoReport = new Button();
            btnPaymentHistoryReceipts = new Button();
            btnPaymentCashiering = new Button();
            button7 = new Button();
            btnStudentEnrollment = new Button();
            btnSectionManagement = new Button();
            btnStudentManagement = new Button();
            btnUserAccount = new Button();
            btnSearch = new Button();
            button1 = new Button();
            panel3 = new Panel();
            lblWelcome = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            lblNumberOfStudents = new Label();
            panel5 = new Panel();
            lblNumberOfCurrentlyEnrolled = new Label();
            label8 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            lblNumberOfTotalSection = new Label();
            label11 = new Label();
            label12 = new Label();
            panel7 = new Panel();
            lblNumberOfPendingPayment = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 17);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Enrollment System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 61);
            panel1.TabIndex = 1;
            // 
            // button12
            // 
            button12.BackColor = Color.DeepSkyBlue;
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Location = new Point(1125, 9);
            button12.Name = "button12";
            button12.Size = new Size(125, 43);
            button12.TabIndex = 4;
            button12.Text = "Logout";
            button12.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1074, 4);
            label6.Name = "label6";
            label6.Size = new Size(45, 45);
            label6.TabIndex = 4;
            label6.Text = " │";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(64, 45);
            label2.TabIndex = 2;
            label2.Text = "🎓";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(btnStudentInfoReport);
            panel2.Controls.Add(btnPaymentHistoryReceipts);
            panel2.Controls.Add(btnPaymentCashiering);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(btnStudentEnrollment);
            panel2.Controls.Add(btnSectionManagement);
            panel2.Controls.Add(btnStudentManagement);
            panel2.Controls.Add(btnUserAccount);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(2, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 443);
            panel2.TabIndex = 2;
            // 
            // btnStudentInfoReport
            // 
            btnStudentInfoReport.BackColor = Color.Azure;
            btnStudentInfoReport.ForeColor = Color.Black;
            btnStudentInfoReport.Location = new Point(3, 387);
            btnStudentInfoReport.Name = "btnStudentInfoReport";
            btnStudentInfoReport.Size = new Size(194, 36);
            btnStudentInfoReport.TabIndex = 11;
            btnStudentInfoReport.Text = "Student Information Report";
            btnStudentInfoReport.UseVisualStyleBackColor = false;
            btnStudentInfoReport.Click += btnStudentInfoReport_Click;
            // 
            // btnPaymentHistoryReceipts
            // 
            btnPaymentHistoryReceipts.BackColor = Color.Azure;
            btnPaymentHistoryReceipts.ForeColor = Color.Black;
            btnPaymentHistoryReceipts.Location = new Point(3, 345);
            btnPaymentHistoryReceipts.Name = "btnPaymentHistoryReceipts";
            btnPaymentHistoryReceipts.Size = new Size(194, 36);
            btnPaymentHistoryReceipts.TabIndex = 10;
            btnPaymentHistoryReceipts.Text = "Payment History/ Reciepts";
            btnPaymentHistoryReceipts.UseVisualStyleBackColor = false;
            btnPaymentHistoryReceipts.Click += btnPaymentHistoryReceipts_Click;
            // 
            // btnPaymentCashiering
            // 
            btnPaymentCashiering.BackColor = Color.Azure;
            btnPaymentCashiering.ForeColor = Color.Black;
            btnPaymentCashiering.Location = new Point(3, 303);
            btnPaymentCashiering.Name = "btnPaymentCashiering";
            btnPaymentCashiering.Size = new Size(194, 36);
            btnPaymentCashiering.TabIndex = 9;
            btnPaymentCashiering.Text = "Payment/Cashiering";
            btnPaymentCashiering.UseVisualStyleBackColor = false;
            btnPaymentCashiering.Click += btnPaymentCashiering_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Azure;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(3, 261);
            button7.Name = "button7";
            button7.Size = new Size(194, 36);
            button7.TabIndex = 6;
            button7.Text = "Student Assessment";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // btnStudentEnrollment
            // 
            btnStudentEnrollment.BackColor = Color.Azure;
            btnStudentEnrollment.ForeColor = Color.Black;
            btnStudentEnrollment.Location = new Point(3, 219);
            btnStudentEnrollment.Name = "btnStudentEnrollment";
            btnStudentEnrollment.Size = new Size(194, 36);
            btnStudentEnrollment.TabIndex = 7;
            btnStudentEnrollment.Text = "Student Enrollment";
            btnStudentEnrollment.UseVisualStyleBackColor = false;
            btnStudentEnrollment.Click += btnStudentEnrollment_Click;
            // 
            // btnSectionManagement
            // 
            btnSectionManagement.BackColor = Color.Azure;
            btnSectionManagement.ForeColor = Color.Black;
            btnSectionManagement.Location = new Point(3, 177);
            btnSectionManagement.Name = "btnSectionManagement";
            btnSectionManagement.Size = new Size(194, 36);
            btnSectionManagement.TabIndex = 6;
            btnSectionManagement.Text = "Section Management";
            btnSectionManagement.UseVisualStyleBackColor = false;
            btnSectionManagement.Click += btnSectionManagement_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.Azure;
            btnStudentManagement.ForeColor = Color.Black;
            btnStudentManagement.Location = new Point(3, 135);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(194, 36);
            btnStudentManagement.TabIndex = 5;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = false;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // btnUserAccount
            // 
            btnUserAccount.BackColor = Color.Azure;
            btnUserAccount.ForeColor = Color.Black;
            btnUserAccount.Location = new Point(3, 93);
            btnUserAccount.Name = "btnUserAccount";
            btnUserAccount.Size = new Size(194, 36);
            btnUserAccount.TabIndex = 5;
            btnUserAccount.Text = "User Account Management";
            btnUserAccount.UseVisualStyleBackColor = false;
            btnUserAccount.Click += btnUserAccount_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(3, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Student Account Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 9);
            button1.Name = "button1";
            button1.Size = new Size(194, 36);
            button1.TabIndex = 3;
            button1.Text = "Dasboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(209, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 536);
            panel3.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.DeepSkyBlue;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Control;
            lblWelcome.Location = new Point(806, 14);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(31, 32);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(241, 32);
            label3.TabIndex = 0;
            label3.Text = "Dashboard Overview";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblNumberOfStudents);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.ForeColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(20, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 100);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(73, 50);
            label4.TabIndex = 2;
            label4.Text = "👥";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(82, 19);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 3;
            label5.Text = "Total Students";
            // 
            // lblNumberOfStudents
            // 
            lblNumberOfStudents.AutoSize = true;
            lblNumberOfStudents.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfStudents.ForeColor = Color.DodgerBlue;
            lblNumberOfStudents.Location = new Point(116, 45);
            lblNumberOfStudents.Name = "lblNumberOfStudents";
            lblNumberOfStudents.Size = new Size(49, 40);
            lblNumberOfStudents.TabIndex = 4;
            lblNumberOfStudents.Text = "00";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblNumberOfCurrentlyEnrolled);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.ForeColor = SystemColors.ActiveCaption;
            panel5.Location = new Point(282, 78);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 100);
            panel5.TabIndex = 2;
            // 
            // lblNumberOfCurrentlyEnrolled
            // 
            lblNumberOfCurrentlyEnrolled.AutoSize = true;
            lblNumberOfCurrentlyEnrolled.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfCurrentlyEnrolled.ForeColor = Color.LimeGreen;
            lblNumberOfCurrentlyEnrolled.Location = new Point(116, 45);
            lblNumberOfCurrentlyEnrolled.Name = "lblNumberOfCurrentlyEnrolled";
            lblNumberOfCurrentlyEnrolled.Size = new Size(49, 40);
            lblNumberOfCurrentlyEnrolled.TabIndex = 4;
            lblNumberOfCurrentlyEnrolled.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(97, 19);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 3;
            label8.Text = "Currently Enrolled";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LimeGreen;
            label9.Location = new Point(3, 12);
            label9.Name = "label9";
            label9.Size = new Size(101, 50);
            label9.TabIndex = 2;
            label9.Text = "👤✓";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblNumberOfTotalSection);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.ForeColor = SystemColors.ActiveCaption;
            panel6.Location = new Point(541, 78);
            panel6.Name = "panel6";
            panel6.Size = new Size(241, 100);
            panel6.TabIndex = 3;
            // 
            // lblNumberOfTotalSection
            // 
            lblNumberOfTotalSection.AutoSize = true;
            lblNumberOfTotalSection.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfTotalSection.ForeColor = Color.MediumPurple;
            lblNumberOfTotalSection.Location = new Point(116, 45);
            lblNumberOfTotalSection.Name = "lblNumberOfTotalSection";
            lblNumberOfTotalSection.Size = new Size(49, 40);
            lblNumberOfTotalSection.TabIndex = 4;
            lblNumberOfTotalSection.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumPurple;
            label11.Location = new Point(82, 19);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 3;
            label11.Text = "Total Sections";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MediumPurple;
            label12.Location = new Point(3, 12);
            label12.Name = "label12";
            label12.Size = new Size(73, 50);
            label12.TabIndex = 2;
            label12.Text = "🏛";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblNumberOfPendingPayment);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label15);
            panel7.ForeColor = SystemColors.ActiveCaption;
            panel7.Location = new Point(802, 78);
            panel7.Name = "panel7";
            panel7.Size = new Size(241, 100);
            panel7.TabIndex = 4;
            // 
            // lblNumberOfPendingPayment
            // 
            lblNumberOfPendingPayment.AutoSize = true;
            lblNumberOfPendingPayment.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfPendingPayment.ForeColor = Color.DarkOrange;
            lblNumberOfPendingPayment.Location = new Point(116, 45);
            lblNumberOfPendingPayment.Name = "lblNumberOfPendingPayment";
            lblNumberOfPendingPayment.Size = new Size(49, 40);
            lblNumberOfPendingPayment.TabIndex = 4;
            lblNumberOfPendingPayment.Text = "00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkOrange;
            label14.Location = new Point(82, 19);
            label14.Name = "label14";
            label14.Size = new Size(128, 20);
            label14.TabIndex = 3;
            label14.Text = "Pending Payments";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkOrange;
            label15.Location = new Point(3, 12);
            label15.Name = "label15";
            label15.Size = new Size(73, 50);
            label15.TabIndex = 2;
            label15.Text = "👛";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 611);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlLightLight;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private Button button1;
        private Button btnStudentEnrollment;
        private Button btnSectionManagement;
        private Button btnStudentManagement;
        private Button btnUserAccount;
        private Button btnSearch;
        private Button btnStudentInfoReport;
        private Button btnPaymentHistoryReceipts;
        private Button btnPaymentCashiering;
        private Button button7;
        private Button button12;
        private Panel panel3;
        private Label lblWelcome;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label lblNumberOfStudents;
        private Label label5;
        private Panel panel7;
        private Label lblNumberOfPendingPayment;
        private Label label14;
        private Label label15;
        private Panel panel6;
        private Label lblNumberOfTotalSection;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private Label lblNumberOfCurrentlyEnrolled;
        private Label label8;
        private Label label9;
    }
}