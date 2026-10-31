namespace UI
{
    partial class AssessmentForm
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
            label6 = new Label();
            btnCompute = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            label1 = new Label();
            lblStudent = new Label();
            txtStudentID = new TextBox();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblGradeYearLevel = new Label();
            txtGradeLevel = new TextBox();
            lblSection = new Label();
            txtSection = new TextBox();
            lblStatus = new Label();
            txtPending = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtTuitionFee = new TextBox();
            label4 = new Label();
            txtOtherFees = new TextBox();
            label5 = new Label();
            cmbPaymentMode = new ComboBox();
            label7 = new Label();
            cmbDate = new ComboBox();
            panel2 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 81);
            panel1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 22);
            label6.Name = "label6";
            label6.Size = new Size(380, 41);
            label6.TabIndex = 0;
            label6.Text = "Student Assessment Form";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(0, 0, 192);
            btnCompute.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.ForeColor = Color.White;
            btnCompute.Location = new Point(941, 960);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(145, 44);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(792, 960);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 44);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(txtPending);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(txtSection);
            panel3.Controls.Add(lblSection);
            panel3.Controls.Add(txtGradeLevel);
            panel3.Controls.Add(lblGradeYearLevel);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(lblStudentName);
            panel3.Controls.Add(txtStudentID);
            panel3.Controls.Add(lblStudent);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(22, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 416);
            panel3.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(300, 31);
            label1.TabIndex = 24;
            label1.Text = "1. STUDENT INFORMATION";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.Transparent;
            lblStudent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.Black;
            lblStudent.Location = new Point(46, 79);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(124, 31);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student ID";
            lblStudent.Click += lblStudent_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.ForeColor = Color.DarkGray;
            txtStudentID.Location = new Point(46, 122);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(430, 38);
            txtStudentID.TabIndex = 24;
            txtStudentID.Text = "Enter Student ID (e.g., 1101)";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(526, 79);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(162, 31);
            lblStudentName.TabIndex = 25;
            lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentName.ForeColor = Color.DarkGray;
            txtStudentName.Location = new Point(526, 122);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(430, 38);
            txtStudentName.TabIndex = 26;
            // 
            // lblGradeYearLevel
            // 
            lblGradeYearLevel.AutoSize = true;
            lblGradeYearLevel.BackColor = Color.Transparent;
            lblGradeYearLevel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradeYearLevel.ForeColor = Color.Black;
            lblGradeYearLevel.Location = new Point(46, 199);
            lblGradeYearLevel.Name = "lblGradeYearLevel";
            lblGradeYearLevel.Size = new Size(202, 31);
            lblGradeYearLevel.TabIndex = 27;
            lblGradeYearLevel.Text = "Grade / Year Level";
            // 
            // txtGradeLevel
            // 
            txtGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeLevel.ForeColor = Color.DarkGray;
            txtGradeLevel.Location = new Point(46, 242);
            txtGradeLevel.Name = "txtGradeLevel";
            txtGradeLevel.Size = new Size(430, 38);
            txtGradeLevel.TabIndex = 28;
            txtGradeLevel.Text = "--";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(526, 199);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(91, 31);
            lblSection.TabIndex = 28;
            lblSection.Text = "Section";
            // 
            // txtSection
            // 
            txtSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSection.ForeColor = Color.DarkGray;
            txtSection.Location = new Point(526, 242);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(430, 38);
            txtSection.TabIndex = 29;
            txtSection.Text = "--";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(46, 313);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(77, 31);
            lblStatus.TabIndex = 30;
            lblStatus.Text = "Status";
            // 
            // txtPending
            // 
            txtPending.BackColor = Color.LightGray;
            txtPending.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPending.ForeColor = Color.DimGray;
            txtPending.Location = new Point(46, 347);
            txtPending.Name = "txtPending";
            txtPending.Size = new Size(279, 38);
            txtPending.TabIndex = 31;
            txtPending.Text = "PENDING SELECTON";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(cmbDate);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(cmbPaymentMode);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtOtherFees);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtTuitionFee);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(22, 486);
            panel4.Name = "panel4";
            panel4.Size = new Size(1064, 445);
            panel4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(25, 30);
            label2.Name = "label2";
            label2.Size = new Size(479, 31);
            label2.TabIndex = 32;
            label2.Text = "2. FEE ASSESSMENT AND PAYMENT DETAILS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 90);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 32;
            label3.Text = "Tuition Fee (₱)";
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuitionFee.ForeColor = Color.DarkGray;
            txtTuitionFee.Location = new Point(46, 135);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.Size = new Size(430, 38);
            txtTuitionFee.TabIndex = 33;
            txtTuitionFee.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(526, 90);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 34;
            label4.Text = "Other Fees (₱)";
            // 
            // txtOtherFees
            // 
            txtOtherFees.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtherFees.ForeColor = Color.DarkGray;
            txtOtherFees.Location = new Point(526, 135);
            txtOtherFees.Name = "txtOtherFees";
            txtOtherFees.Size = new Size(430, 38);
            txtOtherFees.TabIndex = 35;
            txtOtherFees.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(46, 207);
            label5.Name = "label5";
            label5.Size = new Size(170, 31);
            label5.TabIndex = 36;
            label5.Text = "Payment Mode";
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Location = new Point(46, 250);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(430, 31);
            cmbPaymentMode.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(518, 207);
            label7.Name = "label7";
            label7.Size = new Size(63, 31);
            label7.TabIndex = 38;
            label7.Text = "Date";
            // 
            // cmbDate
            // 
            cmbDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDate.FormattingEnabled = true;
            cmbDate.Location = new Point(526, 250);
            cmbDate.Name = "cmbDate";
            cmbDate.Size = new Size(430, 31);
            cmbDate.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCompute);
            panel2.Location = new Point(-5, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1161, 1030);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightBlue;
            panel5.Controls.Add(lblTotal);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(46, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(910, 93);
            panel5.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(23, 24);
            label8.Name = "label8";
            label8.Size = new Size(165, 23);
            label8.TabIndex = 0;
            label8.Text = "TOTAL ASSESSMENT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSlateGray;
            label9.Location = new Point(25, 59);
            label9.Name = "label9";
            label9.Size = new Size(326, 23);
            label9.TabIndex = 1;
            label9.Text = "Calculated tuition and miscellaneous fees";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(769, 24);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(99, 38);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "₱ 0.00";
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1156, 1102);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssessmentForm";
            Text = "AssessmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Button btnCompute;
        private Button btnSave;
        private Panel panel3;
        private TextBox txtPending;
        private Label lblStatus;
        private TextBox txtSection;
        private Label lblSection;
        private TextBox txtGradeLevel;
        private Label lblGradeYearLevel;
        private TextBox txtStudentName;
        private Label lblStudentName;
        private TextBox txtStudentID;
        private Label lblStudent;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private ComboBox cmbDate;
        private Label label7;
        private ComboBox cmbPaymentMode;
        private Label label5;
        private TextBox txtOtherFees;
        private Label label4;
        private TextBox txtTuitionFee;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label lblTotal;
    }
}