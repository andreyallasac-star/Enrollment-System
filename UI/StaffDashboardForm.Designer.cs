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
            lblStaffDashboardMenu = new Label();
            lblStaff = new Label();
            panel2 = new Panel();
            btnStudentEnrollment = new Button();
            btnStudentsAccSearch = new Button();
            btnPaymentandCashiering = new Button();
            btnPaymentHistory = new Button();
            btnLogOut = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(lblStaff);
            panel1.Controls.Add(lblStaffDashboardMenu);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 88);
            panel1.TabIndex = 0;
            // 
            // lblStaffDashboardMenu
            // 
            lblStaffDashboardMenu.AutoSize = true;
            lblStaffDashboardMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffDashboardMenu.ForeColor = Color.White;
            lblStaffDashboardMenu.Location = new Point(69, 23);
            lblStaffDashboardMenu.Name = "lblStaffDashboardMenu";
            lblStaffDashboardMenu.Size = new Size(336, 41);
            lblStaffDashboardMenu.TabIndex = 0;
            lblStaffDashboardMenu.Text = "Staff Dashboard Menu";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaff.ForeColor = Color.White;
            lblStaff.Location = new Point(887, 20);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(88, 46);
            lblStaff.TabIndex = 1;
            lblStaff.Text = "Staff";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnPaymentHistory);
            panel2.Controls.Add(btnPaymentandCashiering);
            panel2.Controls.Add(btnStudentsAccSearch);
            panel2.Controls.Add(btnStudentEnrollment);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 369);
            panel2.TabIndex = 1;
            // 
            // btnStudentEnrollment
            // 
            btnStudentEnrollment.BackColor = Color.Azure;
            btnStudentEnrollment.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentEnrollment.Location = new Point(3, 3);
            btnStudentEnrollment.Name = "btnStudentEnrollment";
            btnStudentEnrollment.Size = new Size(254, 66);
            btnStudentEnrollment.TabIndex = 0;
            btnStudentEnrollment.Text = "Student Enrollment";
            btnStudentEnrollment.UseVisualStyleBackColor = false;
            // 
            // btnStudentsAccSearch
            // 
            btnStudentsAccSearch.BackColor = Color.Azure;
            btnStudentsAccSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentsAccSearch.Location = new Point(3, 75);
            btnStudentsAccSearch.Name = "btnStudentsAccSearch";
            btnStudentsAccSearch.Size = new Size(254, 66);
            btnStudentsAccSearch.TabIndex = 1;
            btnStudentsAccSearch.Text = "Student Account Search";
            btnStudentsAccSearch.UseVisualStyleBackColor = false;
            // 
            // btnPaymentandCashiering
            // 
            btnPaymentandCashiering.BackColor = Color.Azure;
            btnPaymentandCashiering.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaymentandCashiering.Location = new Point(3, 147);
            btnPaymentandCashiering.Name = "btnPaymentandCashiering";
            btnPaymentandCashiering.Size = new Size(254, 66);
            btnPaymentandCashiering.TabIndex = 2;
            btnPaymentandCashiering.Text = "Payment and Cashiering";
            btnPaymentandCashiering.UseVisualStyleBackColor = false;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = Color.Azure;
            btnPaymentHistory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaymentHistory.Location = new Point(3, 219);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(254, 66);
            btnPaymentHistory.TabIndex = 3;
            btnPaymentHistory.Text = "Payment History and Receipts";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Azure;
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(3, 291);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(254, 66);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(278, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 369);
            panel3.TabIndex = 2;
            // 
            // StaffDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1108, 481);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StaffDashboardForm";
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
        private Label lblStaff;
        private Panel panel2;
        private Button btnStudentEnrollment;
        private Button btnStudentsAccSearch;
        private Button btnLogOut;
        private Button btnPaymentHistory;
        private Button btnPaymentandCashiering;
        private Panel panel3;
    }
}