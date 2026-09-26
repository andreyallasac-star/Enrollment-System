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
            panel2 = new Panel();
            lblStudentId = new Label();
            lblStudent = new Label();
            lblGrade = new Label();
            lblSection = new Label();
            lblStatus = new Label();
            lblTuitionFee = new Label();
            lblPaymentMode = new Label();
            lblOtherFee = new Label();
            lblDate = new Label();
            lblTotalAssessment = new Label();
            btnCompute = new Button();
            btnSave = new Button();
            txtStudentId = new TextBox();
            txtTuitionFee = new TextBox();
            txtPaymentMode = new TextBox();
            txtOtherFee = new TextBox();
            txtDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 83);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
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
            panel2.Location = new Point(3, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 552);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentId.Location = new Point(29, 28);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(126, 31);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(29, 78);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(98, 31);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(29, 125);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(81, 31);
            lblGrade.TabIndex = 2;
            lblGrade.Text = "Grade:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(29, 177);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(94, 31);
            lblSection.TabIndex = 3;
            lblSection.Text = "Section:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(29, 229);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 31);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // lblTuitionFee
            // 
            lblTuitionFee.AutoSize = true;
            lblTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuitionFee.Location = new Point(29, 284);
            lblTuitionFee.Name = "lblTuitionFee";
            lblTuitionFee.Size = new Size(131, 31);
            lblTuitionFee.TabIndex = 5;
            lblTuitionFee.Text = "Tuition Fee:";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMode.Location = new Point(576, 284);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(173, 31);
            lblPaymentMode.TabIndex = 6;
            lblPaymentMode.Text = "Payment Mode:";
            // 
            // lblOtherFee
            // 
            lblOtherFee.AutoSize = true;
            lblOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtherFee.Location = new Point(29, 338);
            lblOtherFee.Name = "lblOtherFee";
            lblOtherFee.Size = new Size(118, 31);
            lblOtherFee.TabIndex = 7;
            lblOtherFee.Text = "Other Fee:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(576, 338);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(67, 31);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.Location = new Point(29, 405);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(194, 31);
            lblTotalAssessment.TabIndex = 9;
            lblTotalAssessment.Text = "Total Assessment:";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.IndianRed;
            btnCompute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(273, 473);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(145, 53);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(498, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 53);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(173, 21);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(357, 38);
            txtStudentId.TabIndex = 12;
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuitionFee.Location = new Point(173, 277);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.Size = new Size(291, 38);
            txtTuitionFee.TabIndex = 13;
            // 
            // txtPaymentMode
            // 
            txtPaymentMode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentMode.Location = new Point(755, 277);
            txtPaymentMode.Name = "txtPaymentMode";
            txtPaymentMode.Size = new Size(302, 38);
            txtPaymentMode.TabIndex = 14;
            // 
            // txtOtherFee
            // 
            txtOtherFee.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtherFee.Location = new Point(173, 338);
            txtOtherFee.Name = "txtOtherFee";
            txtOtherFee.Size = new Size(294, 38);
            txtOtherFee.TabIndex = 15;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(649, 338);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(294, 38);
            txtDate.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 81);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 17;
            label1.Text = "<Label>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 18;
            label2.Text = "<Label>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 177);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 19;
            label3.Text = "<Label>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, 229);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 20;
            label4.Text = "<Label>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(229, 405);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 21;
            label5.Text = "<Label>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 20);
            label6.Name = "label6";
            label6.Size = new Size(339, 46);
            label6.TabIndex = 0;
            label6.Text = "Student Assessment";
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 645);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AssessmentForm";
            Text = "AssessmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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