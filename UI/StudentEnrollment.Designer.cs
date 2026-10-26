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
            btnSearch = new Button();
            lblGender = new Label();
            btnClear = new Button();
            btnEnroll = new Button();
            cmbSection = new ComboBox();
            label17 = new Label();
            cmbGradeLevel = new ComboBox();
            label16 = new Label();
            cmbSchoolYear = new ComboBox();
            label15 = new Label();
            lblSection = new Label();
            lblGradeLevel = new Label();
            lblDateOfBirth = new Label();
            lblStudentId = new Label();
            lblStudentName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtStudentId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnEnroll);
            panel1.Controls.Add(cmbSection);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(cmbGradeLevel);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(cmbSchoolYear);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(lblSection);
            panel1.Controls.Add(lblGradeLevel);
            panel1.Controls.Add(lblDateOfBirth);
            panel1.Controls.Add(lblStudentId);
            panel1.Controls.Add(lblStudentName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 557);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(633, 94);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 32);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(161, 226);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(83, 25);
            lblGender.TabIndex = 24;
            lblGender.Text = "<Label>";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(427, 505);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 36);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.Blue;
            btnEnroll.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnroll.Location = new Point(594, 505);
            btnEnroll.Margin = new Padding(3, 2, 3, 2);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(133, 36);
            btnEnroll.TabIndex = 22;
            btnEnroll.Text = "ENROLL";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(20, 438);
            cmbSection.Margin = new Padding(3, 2, 3, 2);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(607, 33);
            cmbSection.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(20, 412);
            label17.Name = "label17";
            label17.Size = new Size(87, 25);
            label17.TabIndex = 19;
            label17.Text = "Section *";
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Location = new Point(20, 370);
            cmbGradeLevel.Margin = new Padding(3, 2, 3, 2);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(607, 33);
            cmbGradeLevel.TabIndex = 18;
            cmbGradeLevel.SelectedIndexChanged += FilterSections;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(20, 345);
            label16.Name = "label16";
            label16.Size = new Size(124, 25);
            label16.TabIndex = 17;
            label16.Text = "Grade Level *";
            // 
            // cmbSchoolYear
            // 
            cmbSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSchoolYear.FormattingEnabled = true;
            cmbSchoolYear.Location = new Point(20, 306);
            cmbSchoolYear.Margin = new Padding(3, 2, 3, 2);
            cmbSchoolYear.Name = "cmbSchoolYear";
            cmbSchoolYear.Size = new Size(607, 33);
            cmbSchoolYear.TabIndex = 16;
            cmbSchoolYear.SelectedIndexChanged += FilterSections;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(20, 280);
            label15.Name = "label15";
            label15.Size = new Size(123, 25);
            label15.TabIndex = 15;
            label15.Text = "School Year *";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(505, 229);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(83, 25);
            lblSection.TabIndex = 14;
            lblSection.Text = "<Label>";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevel.ForeColor = Color.Black;
            lblGradeLevel.Location = new Point(534, 194);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(83, 25);
            lblGradeLevel.TabIndex = 13;
            lblGradeLevel.Text = "<Label>";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.Black;
            lblDateOfBirth.Location = new Point(534, 159);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(83, 25);
            lblDateOfBirth.TabIndex = 12;
            lblDateOfBirth.Text = "<Label>";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(161, 194);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(83, 25);
            lblStudentId.TabIndex = 10;
            lblStudentId.Text = "<Label>";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(161, 159);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 25);
            lblStudentName.TabIndex = 9;
            lblStudentName.Text = "<Label>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 194);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 8;
            label8.Text = "Student ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(413, 229);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 7;
            label7.Text = "Section:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(413, 194);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 6;
            label6.Text = "Grade Level:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(413, 159);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 5;
            label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 226);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 159);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 3;
            label3.Text = "Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 69);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(20, 94);
            txtStudentId.Margin = new Padding(3, 2, 3, 2);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(607, 32);
            txtStudentId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 0;
            label1.Text = "Enrollment Information";
            // 
            // StudentEnrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(757, 558);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentEnrollment";
            Text = "StudentEnrollment";
            Load += StudentEnrollment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStudentId;
        private Label label7;
        private Label label6;
        private Label lblStudentName;
        private Label label8;
        private Label label15;
        private Label lblSection;
        private Label lblGradeLevel;
        private Label lblDateOfBirth;
        private Label lblStudentId;
        private ComboBox cmbSchoolYear;
        private ComboBox cmbSection;
        private Label label17;
        private ComboBox cmbGradeLevel;
        private Label label16;
        private Button btnEnroll;
        private Button btnClear;
        private Label lblGender;
        private Button btnSearch;
    }
}