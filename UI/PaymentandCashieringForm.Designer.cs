namespace UI
{
    partial class PaymentandCashieringForm
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
            lblSearch = new Label();
            txtSearchStudent = new TextBox();
            panel3 = new Panel();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblTotalAssessment = new Label();
            lblCurrentBalance = new Label();
            lblPaymentAmount = new Label();
            lblPaymentMethod = new Label();
            lblPaymentDate = new Label();
            label6 = new Label();
            lblID = new Label();
            lblName = new Label();
            lblAssessment = new Label();
            lblBalance = new Label();
            txtPaymentAmount = new TextBox();
            lblRemaining = new Label();
            cmbPaymentMethod = new ComboBox();
            cmbPaymentDate = new ComboBox();
            txtProcessPayment = new TextBox();
            txtSearch = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label12);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 73);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(txtSearchStudent);
            panel2.Controls.Add(lblSearch);
            panel2.Location = new Point(4, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 48);
            panel2.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(33, 10);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(270, 31);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Student ID/Name:";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchStudent.Location = new Point(309, 7);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(391, 38);
            txtSearchStudent.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(txtProcessPayment);
            panel3.Controls.Add(cmbPaymentDate);
            panel3.Controls.Add(cmbPaymentMethod);
            panel3.Controls.Add(lblRemaining);
            panel3.Controls.Add(txtPaymentAmount);
            panel3.Controls.Add(lblBalance);
            panel3.Controls.Add(lblAssessment);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblID);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblPaymentDate);
            panel3.Controls.Add(lblPaymentMethod);
            panel3.Controls.Add(lblPaymentAmount);
            panel3.Controls.Add(lblCurrentBalance);
            panel3.Controls.Add(lblTotalAssessment);
            panel3.Controls.Add(lblStudentName);
            panel3.Controls.Add(lblStudentID);
            panel3.Location = new Point(4, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(1130, 412);
            panel3.TabIndex = 2;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(33, 20);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(126, 31);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(33, 62);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(165, 31);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.Location = new Point(526, 20);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(194, 31);
            lblTotalAssessment.TabIndex = 2;
            lblTotalAssessment.Text = "Total Assessment:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(526, 62);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(180, 31);
            lblCurrentBalance.TabIndex = 3;
            lblCurrentBalance.Text = "Current Balance:";
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentAmount.Location = new Point(33, 147);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(195, 31);
            lblPaymentAmount.TabIndex = 4;
            lblPaymentAmount.Text = "Payment Amount:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(33, 191);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(194, 31);
            lblPaymentMethod.TabIndex = 5;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentDate.Location = new Point(526, 147);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(161, 31);
            lblPaymentDate.TabIndex = 6;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 294);
            label6.Name = "label6";
            label6.Size = new Size(303, 31);
            label6.TabIndex = 7;
            label6.Text = "NEW REMAINING BALANCE:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(165, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 31);
            lblID.TabIndex = 8;
            lblID.Text = "<Label>";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(218, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 31);
            lblName.TabIndex = 9;
            lblName.Text = "<Label>";
            // 
            // lblAssessment
            // 
            lblAssessment.AutoSize = true;
            lblAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssessment.Location = new Point(726, 20);
            lblAssessment.Name = "lblAssessment";
            lblAssessment.Size = new Size(101, 31);
            lblAssessment.TabIndex = 10;
            lblAssessment.Text = "<Label>";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(726, 62);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(101, 31);
            lblBalance.TabIndex = 11;
            lblBalance.Text = "<Label>";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentAmount.Location = new Point(234, 144);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(249, 38);
            txtPaymentAmount.TabIndex = 2;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemaining.Location = new Point(342, 294);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(101, 31);
            lblRemaining.TabIndex = 12;
            lblRemaining.Text = "<Label>";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(234, 191);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(249, 39);
            cmbPaymentMethod.TabIndex = 13;
            // 
            // cmbPaymentDate
            // 
            cmbPaymentDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentDate.FormattingEnabled = true;
            cmbPaymentDate.Location = new Point(693, 143);
            cmbPaymentDate.Name = "cmbPaymentDate";
            cmbPaymentDate.Size = new Size(284, 39);
            cmbPaymentDate.TabIndex = 14;
            // 
            // txtProcessPayment
            // 
            txtProcessPayment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProcessPayment.Location = new Point(33, 356);
            txtProcessPayment.Name = "txtProcessPayment";
            txtProcessPayment.Size = new Size(286, 38);
            txtProcessPayment.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(726, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(61, 38);
            txtSearch.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(33, 15);
            label12.Name = "label12";
            label12.Size = new Size(360, 46);
            label12.TabIndex = 0;
            label12.Text = "Payment / Cashiering";
            // 
            // PaymentandCashieringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 552);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PaymentandCashieringForm";
            Text = "PaymentandCashieringForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblSearch;
        private TextBox txtSearchStudent;
        private Panel panel3;
        private Label lblStudentID;
        private Label lblCurrentBalance;
        private Label lblTotalAssessment;
        private Label lblStudentName;
        private Label label6;
        private Label lblPaymentDate;
        private Label lblPaymentMethod;
        private Label lblPaymentAmount;
        private ComboBox cmbPaymentMethod;
        private Label lblRemaining;
        private TextBox txtPaymentAmount;
        private Label lblBalance;
        private Label lblAssessment;
        private Label lblName;
        private Label lblID;
        private TextBox txtProcessPayment;
        private ComboBox cmbPaymentDate;
        private Label label12;
        private TextBox txtSearch;
    }
}