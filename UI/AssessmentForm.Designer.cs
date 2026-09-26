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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDate = new TextBox();
            txtOtherFee = new TextBox();
            txtPaymentMode = new TextBox();
            txtTuitionFee = new TextBox();
            txtStudentId = new TextBox();
            btnSave = new Button();
            btnCompute = new Button();
            lblTotalAssessment = new Label();
            lblDate = new Label();
            lblOtherFee = new Label();
            lblPaymentMode = new Label();
            lblTuitionFee = new Label();
            lblStatus = new Label();
            lblSection = new Label();
            lblGrade = new Label();
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
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(txtOtherFee);
            panel2.Controls.Add(txtPaymentMode);
            panel2.Controls.Add(txtTuitionFee);
            panel2.Controls.Add(txtStudentId);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCompute);
            panel2.Controls.Add(lblTotalAssessment);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(lblOtherFee);
            panel2.Controls.Add(lblPaymentMode);
            panel2.Controls.Add(lblTuitionFee);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblSection);
            panel2.Controls.Add(lblGrade);
            panel2.Controls.Add(lblStudent);
            panel2.Controls.Add(lblStudentId);
            panel2.Location = new Point(3, -12);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 489);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(200, 345);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 21;
            label5.Text = "<Label>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(151, 213);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 20;
            label4.Text = "<Label>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(151, 174);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 19;
            label3.Text = "<Label>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(151, 137);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 18;
            label2.Text = "<Label>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(151, 102);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 17;
            label1.Text = "<Label>";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(568, 295);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(258, 32);
            txtDate.TabIndex = 16;
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
            // txtPaymentMode
            // 
            txtPaymentMode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentMode.Location = new Point(661, 249);
            txtPaymentMode.Margin = new Padding(3, 2, 3, 2);
            txtPaymentMode.Name = "txtPaymentMode";
            txtPaymentMode.Size = new Size(265, 32);
            txtPaymentMode.TabIndex = 14;
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
            btnSave.Location = new Point(436, 396);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.IndianRed;
            btnCompute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(239, 396);
            btnCompute.Margin = new Padding(3, 2, 3, 2);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(127, 40);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.BackColor = Color.Transparent;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.ForeColor = Color.Black;
            lblTotalAssessment.Location = new Point(25, 345);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(158, 25);
            lblTotalAssessment.TabIndex = 9;
            lblTotalAssessment.Text = "Total Assessment:";
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(25, 213);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(25, 174);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(78, 25);
            lblSection.TabIndex = 3;
            lblSection.Text = "Section:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.BackColor = Color.Transparent;
            lblGrade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.Black;
            lblGrade.Location = new Point(25, 135);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(67, 25);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "Grade:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.Transparent;
            lblStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.ForeColor = Color.Black;
            lblStudent.Location = new Point(25, 99);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(80, 25);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student:";
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
        private Label lblStatus;
        private Label lblSection;
        private Label lblGrade;
        private Label lblStudent;
        private Label lblOtherFee;
        private Label lblPaymentMode;
        private Label lblTuitionFee;
        private Button btnCompute;
        private Label lblTotalAssessment;
        private Label lblDate;
        private Button btnSave;
        private TextBox txtOtherFee;
        private TextBox txtPaymentMode;
        private TextBox txtTuitionFee;
        private TextBox txtStudentId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDate;
    }
}