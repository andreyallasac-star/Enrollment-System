namespace UI
{
    partial class StudentEnrollment
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
            label1 = new Label();
            label2 = new Label();
            txtStudentId = new TextBox();
            btnSearch = new Button();
            panelStudentDetails = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblDetailsTitle = new Label();
            lblPhotoPlaceholder = new Label();
            lblStudentId = new Label();
            lblStudentName = new Label();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblGradeLevel = new Label();
            lblSection = new Label();
            label15 = new Label();
            cmbSchoolYear = new ComboBox();
            label16 = new Label();
            cmbGradeLevel = new ComboBox();
            label17 = new Label();
            cmbSection = new ComboBox();
            btnClear = new Button();
            btnEnroll = new Button();
            lnkResetPassword = new LinkLabel();
            lnkRequestAccess = new LinkLabel();
            panel1.SuspendLayout();
            panelStudentDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(panelStudentDetails);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(cmbSchoolYear);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(cmbGradeLevel);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(cmbSection);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnEnroll);
            panel1.Controls.Add(lnkResetPassword);
            panel1.Controls.Add(lnkRequestAccess);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(25, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1510, 940);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(434, 50);
            label1.TabIndex = 0;
            label1.Text = "Enrollment Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(35, 140);
            txtStudentId.Margin = new Padding(3, 4, 3, 4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(1260, 36);
            txtStudentId.TabIndex = 2;
            txtStudentId.Text = "Enter ID or Name (e.g., ST2023-001)";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 204);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1315, 138);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 40);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelStudentDetails
            // 
            panelStudentDetails.BackColor = Color.FromArgb(241, 245, 249);
            panelStudentDetails.BorderStyle = BorderStyle.FixedSingle;
            panelStudentDetails.Controls.Add(label3);
            panelStudentDetails.Controls.Add(label4);
            panelStudentDetails.Controls.Add(label5);
            panelStudentDetails.Controls.Add(label6);
            panelStudentDetails.Controls.Add(label7);
            panelStudentDetails.Controls.Add(label8);
            panelStudentDetails.Controls.Add(lblDetailsTitle);
            panelStudentDetails.Controls.Add(lblPhotoPlaceholder);
            panelStudentDetails.Controls.Add(lblStudentId);
            panelStudentDetails.Controls.Add(lblStudentName);
            panelStudentDetails.Controls.Add(lblDateOfBirth);
            panelStudentDetails.Controls.Add(lblGender);
            panelStudentDetails.Controls.Add(lblGradeLevel);
            panelStudentDetails.Controls.Add(lblSection);
            panelStudentDetails.Location = new Point(35, 200);
            panelStudentDetails.Name = "panelStudentDetails";
            panelStudentDetails.Size = new Size(1435, 430);
            panelStudentDetails.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(53, 63);
            label3.Name = "label3";
            label3.Size = new Size(166, 38);
            label3.TabIndex = 8;
            label3.Text = "Student ID: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(51, 65, 85);
            label4.Location = new Point(53, 160);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 9;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(51, 65, 85);
            label5.Location = new Point(53, 338);
            label5.Name = "label5";
            label5.Size = new Size(196, 38);
            label5.TabIndex = 10;
            label5.Text = "Date of Birth: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(51, 65, 85);
            label6.Location = new Point(53, 258);
            label6.Name = "label6";
            label6.Size = new Size(118, 38);
            label6.TabIndex = 11;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(51, 65, 85);
            label7.Location = new Point(734, 65);
            label7.Name = "label7";
            label7.Size = new Size(174, 38);
            label7.TabIndex = 12;
            label7.Text = "Grade Level:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(51, 65, 85);
            label8.Location = new Point(734, 160);
            label8.Name = "label8";
            label8.Size = new Size(125, 38);
            label8.TabIndex = 13;
            label8.Text = "Section: ";
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblDetailsTitle.Location = new Point(20, 15);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(147, 25);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Student Details";
            // 
            // lblPhotoPlaceholder
            // 
            lblPhotoPlaceholder.BackColor = Color.FromArgb(203, 213, 225);
            lblPhotoPlaceholder.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhotoPlaceholder.ForeColor = Color.FromArgb(71, 85, 105);
            lblPhotoPlaceholder.Location = new Point(1095, 138);
            lblPhotoPlaceholder.Name = "lblPhotoPlaceholder";
            lblPhotoPlaceholder.Size = new Size(318, 273);
            lblPhotoPlaceholder.TabIndex = 1;
            lblPhotoPlaceholder.Text = "JD";
            lblPhotoPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.FromArgb(51, 65, 85);
            lblStudentId.Location = new Point(225, 63);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(50, 38);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "---";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblStudentName.ForeColor = Color.FromArgb(51, 65, 85);
            lblStudentName.Location = new Point(211, 160);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(50, 38);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "---";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.FromArgb(51, 65, 85);
            lblDateOfBirth.Location = new Point(255, 338);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(50, 38);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "---";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(51, 65, 85);
            lblGender.Location = new Point(177, 258);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(50, 38);
            lblGender.TabIndex = 5;
            lblGender.Text = "---";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblGradeLevel.ForeColor = Color.FromArgb(51, 65, 85);
            lblGradeLevel.Location = new Point(914, 65);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(50, 38);
            lblGradeLevel.TabIndex = 6;
            lblGradeLevel.Text = "---";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblSection.ForeColor = Color.FromArgb(51, 65, 85);
            lblSection.Location = new Point(865, 160);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(50, 38);
            lblSection.TabIndex = 7;
            lblSection.Text = "---";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(51, 65, 85);
            label15.Location = new Point(35, 633);
            label15.Name = "label15";
            label15.Size = new Size(123, 25);
            label15.TabIndex = 36;
            label15.Text = "School Year *";
            // 
            // cmbSchoolYear
            // 
            cmbSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchoolYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSchoolYear.Location = new Point(35, 668);
            cmbSchoolYear.Margin = new Padding(3, 4, 3, 4);
            cmbSchoolYear.Name = "cmbSchoolYear";
            cmbSchoolYear.Size = new Size(700, 36);
            cmbSchoolYear.TabIndex = 16;
            cmbSchoolYear.SelectedIndexChanged += FilterSections;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(51, 65, 85);
            label16.Location = new Point(770, 633);
            label16.Name = "label16";
            label16.Size = new Size(124, 25);
            label16.TabIndex = 37;
            label16.Text = "Grade Level *";
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGradeLevel.Location = new Point(770, 668);
            cmbGradeLevel.Margin = new Padding(3, 4, 3, 4);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(700, 36);
            cmbGradeLevel.TabIndex = 18;
            cmbGradeLevel.SelectedIndexChanged += FilterSections;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(51, 65, 85);
            label17.Location = new Point(35, 723);
            label17.Name = "label17";
            label17.Size = new Size(87, 25);
            label17.TabIndex = 38;
            label17.Text = "Section *";
            // 
            // cmbSection
            // 
            cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSection.Items.AddRange(new object[] { "Bronze", "Silver", "Gold", "Platinum", "Titinium", "Diamond" });
            cmbSection.Location = new Point(35, 758);
            cmbSection.Margin = new Padding(3, 4, 3, 4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(1435, 36);
            cmbSection.TabIndex = 20;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(1160, 858);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 50);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(0, 102, 204);
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Location = new Point(1325, 858);
            btnEnroll.Margin = new Padding(3, 4, 3, 4);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(145, 50);
            btnEnroll.TabIndex = 22;
            btnEnroll.Text = "ENROLL";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // lnkResetPassword
            // 
            lnkResetPassword.AutoSize = true;
            lnkResetPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkResetPassword.LinkColor = Color.FromArgb(0, 102, 204);
            lnkResetPassword.Location = new Point(35, 840);
            lnkResetPassword.Name = "lnkResetPassword";
            lnkResetPassword.Size = new Size(142, 25);
            lnkResetPassword.TabIndex = 39;
            lnkResetPassword.TabStop = true;
            lnkResetPassword.Text = "Reset Password?";
            // 
            // lnkRequestAccess
            // 
            lnkRequestAccess.AutoSize = true;
            lnkRequestAccess.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkRequestAccess.LinkColor = Color.FromArgb(0, 102, 204);
            lnkRequestAccess.Location = new Point(185, 840);
            lnkRequestAccess.Name = "lnkRequestAccess";
            lnkRequestAccess.Size = new Size(130, 25);
            lnkRequestAccess.TabIndex = 40;
            lnkRequestAccess.TabStop = true;
            lnkRequestAccess.Text = "Request access";
            // 
            // StudentEnrollment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 990);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentEnrollment";
            Text = "School Enrollment System - Enroll Student";
            Load += StudentEnrollment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelStudentDetails.ResumeLayout(false);
            panelStudentDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtStudentId;
        private Button btnSearch;
        private Panel panelStudentDetails;
        private Label lblDetailsTitle;
        private Label lblPhotoPlaceholder;
        private Label lblStudentId;
        private Label lblStudentName;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblGradeLevel;
        private Label lblSection;
        private Label label15;
        private ComboBox cmbSchoolYear;
        private Label label16;
        private ComboBox cmbGradeLevel;
        private Label label17;
        private ComboBox cmbSection;
        private Button btnClear;
        private Button btnEnroll;
        private LinkLabel lnkResetPassword;
        private LinkLabel lnkRequestAccess;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}