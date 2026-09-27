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
            label12 = new Label();
            panel3 = new Panel();
            lblReceipt = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lblSection = new Label();
            LabelSection = new Label();
            btnClear = new Button();
            dtpPayment = new DateTimePicker();
            lblPaid = new Label();
            label1 = new Label();
            btnConfirm = new Button();
            btnSearchID = new Button();
            txtSearchStudent = new TextBox();
            lblSearch = new Label();
            cmbPaymentMethod = new ComboBox();
            lblRemaining = new Label();
            txtPaymentAmount = new TextBox();
            lblBalance = new Label();
            lblAssessment = new Label();
            lblName = new Label();
            lblID = new Label();
            label6 = new Label();
            lblPaymentDate = new Label();
            lblPaymentMethod = new Label();
            lblPaymentAmount = new Label();
            lblCurrentBalance = new Label();
            lblTotalAssessment = new Label();
            lblStudentName = new Label();
            lblStudentID = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(29, 0);
            label12.Name = "label12";
            label12.Size = new Size(291, 37);
            label12.TabIndex = 0;
            label12.Text = "Payment / Cashiering";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(lblReceipt);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(lblSection);
            panel3.Controls.Add(LabelSection);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(dtpPayment);
            panel3.Controls.Add(lblPaid);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnConfirm);
            panel3.Controls.Add(btnSearchID);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtSearchStudent);
            panel3.Controls.Add(lblSearch);
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
            panel3.Location = new Point(2, 1);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(991, 589);
            panel3.TabIndex = 2;
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceipt.ForeColor = Color.Black;
            lblReceipt.Location = new Point(783, 12);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(83, 25);
            lblReceipt.TabIndex = 26;
            lblReceipt.Text = "<Label>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(677, 12);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 25;
            label2.Text = "Receipt ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(34, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(886, 218);
            dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Grade";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Section";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Date";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Payment Mode";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Amount Paid";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Receipt ID";
            Column7.Name = "Column7";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(144, 145);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(83, 25);
            lblSection.TabIndex = 23;
            lblSection.Text = "<Label>";
            // 
            // LabelSection
            // 
            LabelSection.AutoSize = true;
            LabelSection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSection.ForeColor = Color.Black;
            LabelSection.Location = new Point(29, 145);
            LabelSection.Name = "LabelSection";
            LabelSection.Size = new Size(78, 25);
            LabelSection.TabIndex = 22;
            LabelSection.Text = "Section:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(749, 283);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 38);
            btnClear.TabIndex = 21;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dtpPayment
            // 
            dtpPayment.Font = new Font("Segoe UI", 12F);
            dtpPayment.Location = new Point(598, 190);
            dtpPayment.Name = "dtpPayment";
            dtpPayment.Size = new Size(273, 29);
            dtpPayment.TabIndex = 20;
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaid.ForeColor = Color.Black;
            lblPaid.Location = new Point(635, 115);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(83, 25);
            lblPaid.TabIndex = 19;
            lblPaid.Text = "<Label>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(460, 115);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 18;
            label1.Text = "Total Paid:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            btnConfirm.Location = new Point(573, 283);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 38);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnSearchID
            // 
            btnSearchID.BackColor = Color.Transparent;
            btnSearchID.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchID.Location = new Point(554, 45);
            btnSearchID.Name = "btnSearchID";
            btnSearchID.Size = new Size(75, 34);
            btnSearchID.TabIndex = 16;
            btnSearchID.Text = "SEARCH";
            btnSearchID.UseVisualStyleBackColor = false;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchStudent.Location = new Point(205, 46);
            txtSearchStudent.Margin = new Padding(3, 2, 3, 2);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(343, 32);
            txtSearchStudent.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(29, 50);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(165, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Student ID:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(205, 225);
            cmbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(218, 33);
            cmbPaymentMethod.TabIndex = 13;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemaining.ForeColor = Color.Black;
            lblRemaining.Location = new Point(299, 289);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(83, 25);
            lblRemaining.TabIndex = 12;
            lblRemaining.Text = "<Label>";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentAmount.Location = new Point(205, 190);
            txtPaymentAmount.Margin = new Padding(3, 2, 3, 2);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(218, 32);
            txtPaymentAmount.TabIndex = 2;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Black;
            lblBalance.Location = new Point(635, 145);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(83, 25);
            lblBalance.TabIndex = 11;
            lblBalance.Text = "<Label>";
            // 
            // lblAssessment
            // 
            lblAssessment.AutoSize = true;
            lblAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssessment.ForeColor = Color.Black;
            lblAssessment.Location = new Point(635, 84);
            lblAssessment.Name = "lblAssessment";
            lblAssessment.Size = new Size(83, 25);
            lblAssessment.TabIndex = 10;
            lblAssessment.Text = "<Label>";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(191, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 25);
            lblName.TabIndex = 9;
            lblName.Text = "<Label>";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(144, 84);
            lblID.Name = "lblID";
            lblID.Size = new Size(83, 25);
            lblID.TabIndex = 8;
            lblID.Text = "<Label>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 289);
            label6.Name = "label6";
            label6.Size = new Size(250, 25);
            label6.TabIndex = 7;
            label6.Text = "NEW REMAINING BALANCE:";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentDate.ForeColor = Color.Black;
            lblPaymentDate.Location = new Point(460, 192);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(132, 25);
            lblPaymentDate.TabIndex = 6;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(29, 225);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(159, 25);
            lblPaymentMethod.TabIndex = 5;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentAmount.ForeColor = Color.Black;
            lblPaymentAmount.Location = new Point(29, 192);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(160, 25);
            lblPaymentAmount.TabIndex = 4;
            lblPaymentAmount.Text = "Payment Amount:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.ForeColor = Color.Black;
            lblCurrentBalance.Location = new Point(460, 145);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(151, 25);
            lblCurrentBalance.TabIndex = 3;
            lblCurrentBalance.Text = "Current Balance:";
            // 
            // lblTotalAssessment
            // 
            lblTotalAssessment.AutoSize = true;
            lblTotalAssessment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessment.ForeColor = Color.Black;
            lblTotalAssessment.Location = new Point(460, 84);
            lblTotalAssessment.Name = "lblTotalAssessment";
            lblTotalAssessment.Size = new Size(158, 25);
            lblTotalAssessment.TabIndex = 2;
            lblTotalAssessment.Text = "Total Assessment:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(29, 115);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(135, 25);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.ForeColor = Color.Black;
            lblStudentID.Location = new Point(29, 84);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(103, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID:";
            // 
            // PaymentandCashieringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(996, 592);
            Controls.Add(panel3);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaymentandCashieringForm";
            Text = "PaymentandCashieringForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Label label12;
        private Button btnSearchID;
        private TextBox txtSearchStudent;
        private Label lblSearch;
        private Button btnConfirm;
        private Label lblSection;
        private Label LabelSection;
        private Button btnClear;
        private DateTimePicker dtpPayment;
        private Label lblPaid;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label lblReceipt;
        private Label label2;
    }
}