namespace UI
{
    partial class PaymentHistoryandReceiptsForm
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
            label3 = new Label();
            label4 = new Label();
            txtStudentId = new TextBox();
            txtReceiptId = new TextBox();
            dtpDateFrom = new DateTimePicker();
            label5 = new Label();
            dtpDateTo = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnClear = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblReceiptID = new Label();
            lblDate = new Label();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblSection = new Label();
            lblAmountPaid = new Label();
            btnPrint = new Button();
            label13 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(lblAmountPaid);
            panel1.Controls.Add(lblSection);
            panel1.Controls.Add(lblStudentName);
            panel1.Controls.Add(lblStudentID);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblReceiptID);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dtpDateTo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpDateFrom);
            panel1.Controls.Add(txtReceiptId);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 449);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 0;
            label1.Text = "Payment History and Receipts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 13F);
            label2.Location = new Point(14, 56);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 13F);
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Receipt ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 13F);
            label4.Location = new Point(14, 128);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Date From:";
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI Symbol", 12F);
            txtStudentId.Location = new Point(117, 56);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(191, 29);
            txtStudentId.TabIndex = 4;
            // 
            // txtReceiptId
            // 
            txtReceiptId.Font = new Font("Segoe UI Symbol", 12F);
            txtReceiptId.Location = new Point(117, 92);
            txtReceiptId.Name = "txtReceiptId";
            txtReceiptId.Size = new Size(191, 29);
            txtReceiptId.TabIndex = 5;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarFont = new Font("Segoe UI Symbol", 12F);
            dtpDateFrom.Font = new Font("Segoe UI Symbol", 12F);
            dtpDateFrom.Location = new Point(117, 128);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(278, 29);
            dtpDateFrom.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 13F);
            label5.Location = new Point(14, 165);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 7;
            label5.Text = "Date To:";
            // 
            // dtpDateTo
            // 
            dtpDateTo.CalendarFont = new Font("Segoe UI Symbol", 12F);
            dtpDateTo.Font = new Font("Segoe UI Symbol", 12F);
            dtpDateTo.Location = new Point(117, 165);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(278, 29);
            dtpDateTo.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(14, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(822, 162);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(17, 223);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(181, 223);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 13F);
            label6.Location = new Point(422, 56);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 12;
            label6.Text = "Receipt ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 13F);
            label7.Location = new Point(348, 212);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 13;
            label7.Text = "Student ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 13F);
            label8.Location = new Point(422, 92);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 14;
            label8.Text = "Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Symbol", 13F);
            label9.Location = new Point(422, 128);
            label9.Name = "label9";
            label9.Size = new Size(101, 25);
            label9.TabIndex = 15;
            label9.Text = "Student ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Symbol", 13F);
            label10.Location = new Point(422, 167);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 16;
            label10.Text = "Student Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Symbol", 13F);
            label11.Location = new Point(422, 206);
            label11.Name = "label11";
            label11.Size = new Size(74, 25);
            label11.TabIndex = 17;
            label11.Text = "Section:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Symbol", 13F);
            label12.Location = new Point(422, 242);
            label12.Name = "label12";
            label12.Size = new Size(120, 25);
            label12.TabIndex = 18;
            label12.Text = "Amount Paid:";
            // 
            // lblReceiptID
            // 
            lblReceiptID.AutoSize = true;
            lblReceiptID.BackColor = Color.Transparent;
            lblReceiptID.Font = new Font("Segoe UI Symbol", 13F);
            lblReceiptID.Location = new Point(559, 56);
            lblReceiptID.Name = "lblReceiptID";
            lblReceiptID.Size = new Size(77, 25);
            lblReceiptID.TabIndex = 19;
            lblReceiptID.Text = "<Label>";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI Symbol", 13F);
            lblDate.Location = new Point(559, 92);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(77, 25);
            lblDate.TabIndex = 20;
            lblDate.Text = "<Label>";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.Transparent;
            lblStudentID.Font = new Font("Segoe UI Symbol", 13F);
            lblStudentID.Location = new Point(559, 128);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(77, 25);
            lblStudentID.TabIndex = 21;
            lblStudentID.Text = "<Label>";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI Symbol", 13F);
            lblStudentName.Location = new Point(559, 167);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(77, 25);
            lblStudentName.TabIndex = 22;
            lblStudentName.Text = "<Label>";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI Symbol", 13F);
            lblSection.Location = new Point(559, 206);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(77, 25);
            lblSection.TabIndex = 23;
            lblSection.Text = "<Label>";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.BackColor = Color.Transparent;
            lblAmountPaid.Font = new Font("Segoe UI Symbol", 13F);
            lblAmountPaid.Location = new Point(559, 242);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(77, 25);
            lblAmountPaid.TabIndex = 24;
            lblAmountPaid.Text = "<Label>";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Green;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(700, 10);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 34);
            btnPrint.TabIndex = 25;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Symbol", 13F);
            label13.Location = new Point(429, 19);
            label13.Name = "label13";
            label13.Size = new Size(196, 25);
            label13.TabIndex = 26;
            label13.Text = "---OFFICIAL RECEIPT---";
            // 
            // Column1
            // 
            Column1.HeaderText = "Receipt ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Date";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Student ID";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Student Name";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Section";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Amount Paid";
            Column6.Name = "Column6";
            // 
            // PaymentHistoryandReceiptsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 456);
            Controls.Add(panel1);
            Name = "PaymentHistoryandReceiptsForm";
            Text = "PaymentHistoryandReceiptsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDateTo;
        private Label label5;
        private DateTimePicker dtpDateFrom;
        private TextBox txtReceiptId;
        private TextBox txtStudentId;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Label lblAmountPaid;
        private Label lblSection;
        private Label lblStudentName;
        private Label lblStudentID;
        private Label lblDate;
        private Label lblReceiptID;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}