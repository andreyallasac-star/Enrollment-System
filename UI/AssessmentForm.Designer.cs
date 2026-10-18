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
            cmbPaymentMode = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 5);
            label6.Name = "label6";
            label6.Size = new Size(273, 37);
            label6.TabIndex = 0;
            label6.Text = "Student Assessment";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(cmbPaymentMode);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblTotalAssessment);
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
            panel2.Location = new Point(3, -12);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 489);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.BackColor = Color.Transparent;
            lblTotalAssessment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.Location = new Point(200, 345);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(69, 21);
            lblTotalAssessment.TabIndex = 21;
            lblTotalAssessment.Text = "<Label>";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(166, 213);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 21);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "<Label>";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(166, 174);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(69, 21);
            lblSection.TabIndex = 19;
            lblSection.Text = "<Label>";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.BackColor = Color.Transparent;
            lblGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.Black;
            lblGrade.Location = new Point(166, 138);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(69, 21);
            lblGrade.TabIndex = 18;
            lblGrade.Text = "<Label>";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(166, 99);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(69, 21);
            lblStudentName.TabIndex = 17;
            lblStudentName.Text = "<Label>";
            // 
            // txtOtherFee
            // 
            txtOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtherFee.Location = new Point(151, 295);
            txtOtherFee.Margin = new Padding(3, 2, 3, 2);
            txtOtherFee.Name = "txtOtherFee";
            txtOtherFee.Size = new Size(258, 32);
            txtOtherFee.TabIndex = 15;
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuitionFee.Location = new Point(151, 249);
            txtTuitionFee.Margin = new Padding(3, 2, 3, 2);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.Size = new Size(255, 32);
            txtTuitionFee.TabIndex = 13;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(151, 57);
            txtStudentId.Margin = new Padding(3, 2, 3, 2);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(313, 32);
            txtStudentId.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(209, 396);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.IndianRed;
            btnCompute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(25, 396);
            btnCompute.Margin = new Padding(3, 2, 3, 2);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(127, 40);
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
            labelTotalAssessment.Location = new Point(25, 345);
            labelTotalAssessment.Name = "labelTotalAssessment";
            labelTotalAssessment.Size = new Size(158, 25);
            labelTotalAssessment.TabIndex = 9;
            labelTotalAssessment.Text = "Total Assessment:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(504, 295);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // lblOtherFee
            // 
            lblOtherFee.AutoSize = true;
            lblOtherFee.BackColor = Color.Transparent;
            lblOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtherFee.ForeColor = Color.Black;
            lblOtherFee.Location = new Point(25, 295);
            lblOtherFee.Name = "lblOtherFee";
            lblOtherFee.Size = new Size(98, 25);
            lblOtherFee.TabIndex = 7;
            lblOtherFee.Text = "Other Fee:";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.BackColor = Color.Transparent;
            lblPaymentMode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.ForeColor = Color.Black;
            lblPaymentMode.Location = new Point(504, 254);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(142, 25);
            lblPaymentMode.TabIndex = 6;
            lblPaymentMode.Text = "Payment Mode:";
            // 
            // lblTuitionFee
            // 
            lblTuitionFee.AutoSize = true;
            lblTuitionFee.BackColor = Color.Transparent;
            lblTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuitionFee.ForeColor = Color.Black;
            lblTuitionFee.Location = new Point(25, 254);
            lblTuitionFee.Name = "lblTuitionFee";
            lblTuitionFee.Size = new Size(109, 25);
            lblTuitionFee.TabIndex = 5;
            lblTuitionFee.Text = "Tuition Fee:";
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.BackColor = Color.Transparent;
            labelstatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelstatus.ForeColor = Color.Black;
            labelstatus.Location = new Point(25, 213);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(66, 25);
            labelstatus.TabIndex = 4;
            labelstatus.Text = "Status:";
            // 
            // labelsection
            // 
            labelsection.AutoSize = true;
            labelsection.BackColor = Color.Transparent;
            labelsection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsection.ForeColor = Color.Black;
            labelsection.Location = new Point(25, 174);
            labelsection.Name = "labelsection";
            labelsection.Size = new Size(78, 25);
            labelsection.TabIndex = 3;
            labelsection.Text = "Section:";
            // 
            // labelgrade
            // 
            labelgrade.AutoSize = true;
            labelgrade.BackColor = Color.Transparent;
            labelgrade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelgrade.ForeColor = Color.Black;
            labelgrade.Location = new Point(25, 135);
            labelgrade.Name = "labelgrade";
            labelgrade.Size = new Size(67, 25);
            labelgrade.TabIndex = 2;
            labelgrade.Text = "Grade:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.Transparent;
            lblStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.Black;
            lblStudent.Location = new Point(25, 99);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(135, 25);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student Name:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(25, 62);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(103, 25);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.Font = new Font("Segoe UI", 13.8F);
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Location = new Point(652, 248);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(206, 33);
            cmbPaymentMode.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F);
            dateTimePicker1.Location = new Point(565, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 32);
            dateTimePicker1.TabIndex = 23;
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(994, 479);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblTotalAssessment;
        private Label lblStatus;
        private Label lblSection;
        private Label lblGrade;
        private Label lblStudentName;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbPaymentMode;
    }
}