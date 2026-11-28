namespace UI
{
    partial class StudentAccountSearch
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblStudentName = new Label();
            lblStudentID = new Label();
            lblSchoolYear = new Label();
            lblGradeLevel = new Label();
            lblDateofBirth = new Label();
            lblGender = new Label();
            lblAddress = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblTotalAssessment = new Label();
            lblTotalPaid = new Label();
            lblRemainingBalance = new Label();
            label15 = new Label();
            lblSection = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnPrintSOA = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 0;
            label1.Text = "Student Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(22, 82);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(756, 33);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DeepSkyBlue;
            btnSearch.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(809, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍︎ Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(54, 24);
            label2.Name = "label2";
            label2.Size = new Size(223, 30);
            label2.TabIndex = 3;
            label2.Text = "Student Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 134);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 4;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 81);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 5;
            label4.Text = "Student ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 81);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 6;
            label5.Text = "School Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(28, 134);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 7;
            label6.Text = "Grade Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 190);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 8;
            label7.Text = "Date of birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(23, 244);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 9;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(23, 296);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 10;
            label9.Text = "Address:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(175, 134);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(79, 25);
            lblStudentName.TabIndex = 11;
            lblStudentName.Text = "<label>";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.Transparent;
            lblStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.ForeColor = Color.Black;
            lblStudentID.Location = new Point(142, 81);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(79, 25);
            lblStudentID.TabIndex = 12;
            lblStudentID.Text = "<label>";
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.BackColor = Color.Transparent;
            lblSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.ForeColor = Color.Black;
            lblSchoolYear.Location = new Point(158, 81);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(79, 25);
            lblSchoolYear.TabIndex = 13;
            lblSchoolYear.Text = "<label>";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.BackColor = Color.Transparent;
            lblGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevel.ForeColor = Color.Black;
            lblGradeLevel.Location = new Point(158, 134);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(79, 25);
            lblGradeLevel.TabIndex = 14;
            lblGradeLevel.Text = "<label>";
            // 
            // lblDateofBirth
            // 
            lblDateofBirth.AutoSize = true;
            lblDateofBirth.BackColor = Color.Transparent;
            lblDateofBirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateofBirth.ForeColor = Color.Black;
            lblDateofBirth.Location = new Point(157, 190);
            lblDateofBirth.Name = "lblDateofBirth";
            lblDateofBirth.Size = new Size(79, 25);
            lblDateofBirth.TabIndex = 15;
            lblDateofBirth.Text = "<label>";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(113, 244);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(79, 25);
            lblGender.TabIndex = 16;
            lblGender.Text = "<label>";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(119, 296);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 17;
            lblAddress.Text = "<label>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(43, 24);
            label11.Name = "label11";
            label11.Size = new Size(272, 30);
            label11.TabIndex = 19;
            label11.Text = "Financial Account Ledger";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(35, 81);
            label12.Name = "label12";
            label12.Size = new Size(163, 25);
            label12.TabIndex = 20;
            label12.Text = "Total Assessment:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(35, 134);
            label13.Name = "label13";
            label13.Size = new Size(99, 25);
            label13.TabIndex = 21;
            label13.Text = "Total Paid:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(35, 190);
            label14.Name = "label14";
            label14.Size = new Size(179, 25);
            label14.TabIndex = 22;
            label14.Text = "Remaining Balance:";
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.BackColor = Color.Transparent;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.ForeColor = Color.Black;
            lblTotalAssessment.Location = new Point(213, 81);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(79, 25);
            lblTotalAssessment.TabIndex = 23;
            lblTotalAssessment.Text = "<label>";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.BackColor = Color.Transparent;
            lblTotalPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPaid.ForeColor = Color.Black;
            lblTotalPaid.Location = new Point(146, 134);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(79, 25);
            lblTotalPaid.TabIndex = 24;
            lblTotalPaid.Text = "<label>";
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.BackColor = Color.Transparent;
            lblRemainingBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemainingBalance.ForeColor = Color.Black;
            lblRemainingBalance.Location = new Point(228, 190);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(79, 25);
            lblRemainingBalance.TabIndex = 25;
            lblRemainingBalance.Text = "<label>";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(28, 190);
            label15.Name = "label15";
            label15.Size = new Size(80, 25);
            label15.TabIndex = 26;
            label15.Text = "Section:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(118, 190);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(79, 25);
            lblSection.TabIndex = 27;
            lblSection.Text = "<label>";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblStudentID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblStudentName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblDateofBirth);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblAddress);
            panel1.Location = new Point(39, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 430);
            panel1.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnPrintSOA);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(lblTotalAssessment);
            panel3.Controls.Add(lblRemainingBalance);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblTotalPaid);
            panel3.Location = new Point(910, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 430);
            panel3.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DeepSkyBlue;
            label10.Location = new Point(38, 24);
            label10.Name = "label10";
            label10.Size = new Size(281, 30);
            label10.TabIndex = 18;
            label10.Text = "Current Enrollment Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblSchoolYear);
            panel2.Controls.Add(lblSection);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(lblGradeLevel);
            panel2.Location = new Point(477, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 430);
            panel2.TabIndex = 29;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DeepSkyBlue;
            btnClear.Location = new Point(984, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 39);
            btnClear.TabIndex = 31;
            btnClear.Text = "⟳ Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPrintSOA
            // 
            btnPrintSOA.BackColor = Color.DeepSkyBlue;
            btnPrintSOA.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintSOA.ForeColor = SystemColors.Control;
            btnPrintSOA.Location = new Point(43, 309);
            btnPrintSOA.Name = "btnPrintSOA";
            btnPrintSOA.Size = new Size(155, 42);
            btnPrintSOA.TabIndex = 32;
            btnPrintSOA.Text = "Print SOA";
            btnPrintSOA.UseVisualStyleBackColor = false;
            btnPrintSOA.Click += btnPrintSOA_Click;
            // 
            // StudentAccountSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1199, 562);
            Controls.Add(btnClear);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "StudentAccountSearch";
            Text = "StudentAccountSearch";
            Load += StudentAccountSearch_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblStudentName;
        private Label lblStudentID;
        private Label lblSchoolYear;
        private Label lblGradeLevel;
        private Label lblDateofBirth;
        private Label lblGender;
        private Label lblAddress;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblTotalAssessment;
        private Label lblTotalPaid;
        private Label lblRemainingBalance;
        private Label label15;
        private Label lblSection;
        private Panel panel1;
        private Panel panel3;
        private Label label10;
        private Panel panel2;
        private Button btnClear;
        private Button btnPrintSOA;
    }
}