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
            label6 = new Label();
            panel2 = new Panel();
            lblTotalAssessment = new Label();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblStatus = new Label();
            lblSection = new Label();
            lblGrade = new Label();
            lblStudentName = new Label();
            txtOtherFee = new TextBox();
            txtTuitionFee = new TextBox();
            txtStudentId = new TextBox();
            btnSave = new Button();
            btnCompute = new Button();
            labelTotalAssessment = new Label();
            lblDate = new Label();
            lblOtherFee = new Label();
            lblPaymentMode = new Label();
            lblTuitionFee = new Label();
            labelstatus = new Label();
            labelsection = new Label();
            labelgrade = new Label();
            lblStudent = new Label();
            lblStudentId = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 7);
            label6.Name = "label6";
            label6.Size = new Size(339, 46);
            label6.TabIndex = 0;
            label6.Text = "Student Assessment";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(lblTotalAssessment);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblSection);
            panel2.Controls.Add(lblGrade);
            panel2.Controls.Add(lblStudentName);
            panel2.Controls.Add(txtOtherFee);
            panel2.Controls.Add(txtTuitionFee);
            panel2.Controls.Add(txtStudentId);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCompute);
            panel2.Controls.Add(labelTotalAssessment);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(lblOtherFee);
            panel2.Controls.Add(lblPaymentMode);
            panel2.Controls.Add(lblTuitionFee);
            panel2.Controls.Add(labelstatus);
            panel2.Controls.Add(labelsection);
            panel2.Controls.Add(labelgrade);
            panel2.Controls.Add(lblStudent);
            panel2.Controls.Add(lblStudentId);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1136, 639);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.BackColor = Color.Transparent;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F);
            lblTotalAssessment.ForeColor = Color.Black;
            lblTotalAssessment.Location = new Point(200, 509);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(101, 31);
            lblTotalAssessment.TabIndex = 27;
            lblTotalAssessment.Text = "<Label>";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(537, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 43);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F);
            dateTimePicker1.Location = new Point(173, 453);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 38);
            dateTimePicker1.TabIndex = 23;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(190, 284);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 28);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "<Label>";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(190, 232);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(86, 28);
            lblSection.TabIndex = 19;
            lblSection.Text = "<Label>";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.BackColor = Color.Transparent;
            lblGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.Black;
            lblGrade.Location = new Point(190, 184);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(86, 28);
            lblGrade.TabIndex = 18;
            lblGrade.Text = "<Label>";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(190, 132);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(86, 28);
            lblStudentName.TabIndex = 17;
            lblStudentName.Text = "<Label>";
            // 
            // txtOtherFee
            // 
            txtOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtherFee.Location = new Point(173, 393);
            txtOtherFee.Name = "txtOtherFee";
            txtOtherFee.Size = new Size(294, 38);
            txtOtherFee.TabIndex = 15;
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuitionFee.Location = new Point(173, 332);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.Size = new Size(291, 38);
            txtTuitionFee.TabIndex = 13;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(173, 76);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(357, 38);
            txtStudentId.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(240, 567);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 53);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.IndianRed;
            btnCompute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(29, 567);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(145, 53);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // labelTotalAssessment
            // 
            labelTotalAssessment.AutoSize = true;
            labelTotalAssessment.BackColor = Color.Transparent;
            labelTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalAssessment.ForeColor = Color.Black;
            labelTotalAssessment.Location = new Point(29, 509);
            labelTotalAssessment.Name = "labelTotalAssessment";
            labelTotalAssessment.Size = new Size(194, 31);
            labelTotalAssessment.TabIndex = 9;
            labelTotalAssessment.Text = "Total Assessment:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(29, 453);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(67, 31);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // lblOtherFee
            // 
            lblOtherFee.AutoSize = true;
            lblOtherFee.BackColor = Color.Transparent;
            lblOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtherFee.ForeColor = Color.Black;
            lblOtherFee.Location = new Point(29, 393);
            lblOtherFee.Name = "lblOtherFee";
            lblOtherFee.Size = new Size(118, 31);
            lblOtherFee.TabIndex = 7;
            lblOtherFee.Text = "Other Fee:";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.BackColor = Color.Transparent;
            lblPaymentMode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.ForeColor = Color.Black;
            lblPaymentMode.Location = new Point(576, 339);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(0, 31);
            lblPaymentMode.TabIndex = 6;
            // 
            // lblTuitionFee
            // 
            lblTuitionFee.AutoSize = true;
            lblTuitionFee.BackColor = Color.Transparent;
            lblTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuitionFee.ForeColor = Color.Black;
            lblTuitionFee.Location = new Point(29, 339);
            lblTuitionFee.Name = "lblTuitionFee";
            lblTuitionFee.Size = new Size(131, 31);
            lblTuitionFee.TabIndex = 5;
            lblTuitionFee.Text = "Tuition Fee:";
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.BackColor = Color.Transparent;
            labelstatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelstatus.ForeColor = Color.Black;
            labelstatus.Location = new Point(29, 284);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(81, 31);
            labelstatus.TabIndex = 4;
            labelstatus.Text = "Status:";
            // 
            // labelsection
            // 
            labelsection.AutoSize = true;
            labelsection.BackColor = Color.Transparent;
            labelsection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsection.ForeColor = Color.Black;
            labelsection.Location = new Point(29, 232);
            labelsection.Name = "labelsection";
            labelsection.Size = new Size(94, 31);
            labelsection.TabIndex = 3;
            labelsection.Text = "Section:";
            // 
            // labelgrade
            // 
            labelgrade.AutoSize = true;
            labelgrade.BackColor = Color.Transparent;
            labelgrade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelgrade.ForeColor = Color.Black;
            labelgrade.Location = new Point(29, 180);
            labelgrade.Name = "labelgrade";
            labelgrade.Size = new Size(81, 31);
            labelgrade.TabIndex = 2;
            labelgrade.Text = "Grade:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.Transparent;
            lblStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.Black;
            lblStudent.Location = new Point(29, 132);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(165, 31);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student Name:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(29, 83);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(126, 31);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1136, 639);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssessmentForm";
            Text = "AssessmentForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblStudentId;
        private Label labelstatus;
        private Label labelsection;
        private Label labelgrade;
        private Label lblStudent;
        private Label lblOtherFee;
        private Label lblPaymentMode;
        private Label lblTuitionFee;
        private Button btnCompute;
        private Label labelTotalAssessment;
        private Label lblDate;
        private Button btnSave;
        private TextBox txtOtherFee;
        private TextBox txtTuitionFee;
        private TextBox txtStudentId;
        private Label label6;
        private Label lblStatus;
        private Label lblSection;
        private Label lblGrade;
        private Label lblStudentName;
        private DateTimePicker dateTimePicker1;
        private Button btnSearch;
        private Label lblTotalAssessment;
    }
}