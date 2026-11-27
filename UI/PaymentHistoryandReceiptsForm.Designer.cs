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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label13 = new Label();
            btnPrint = new Button();
            lblAmountPaid = new Label();
            lblSection = new Label();
            lblStudentName = new Label();
            lblStudentID = new Label();
            lblDate = new Label();
            lblReceiptID = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dtpDateTo = new DateTimePicker();
            label5 = new Label();
            dtpDateFrom = new DateTimePicker();
            txtReceiptId = new TextBox();
            txtStudentId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
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
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 965);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(993, 33);
            label13.Name = "label13";
            label13.Size = new Size(272, 35);
            label13.TabIndex = 26;
            label13.Text = "---OFFICIAL RECEIPT---";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Green;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1271, 21);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(138, 61);
            btnPrint.TabIndex = 25;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.BackColor = Color.Transparent;
            lblAmountPaid.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountPaid.ForeColor = Color.Black;
            lblAmountPaid.Location = new Point(1092, 410);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(108, 35);
            lblAmountPaid.TabIndex = 24;
            lblAmountPaid.Text = "<Label>";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.ForeColor = Color.Black;
            lblSection.Location = new Point(1028, 344);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(108, 35);
            lblSection.TabIndex = 23;
            lblSection.Text = "<Label>";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.Black;
            lblStudentName.Location = new Point(1106, 284);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(108, 35);
            lblStudentName.TabIndex = 22;
            lblStudentName.Text = "<Label>";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.Transparent;
            lblStudentID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.ForeColor = Color.Black;
            lblStudentID.Location = new Point(1064, 224);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(108, 35);
            lblStudentID.TabIndex = 21;
            lblStudentID.Text = "<Label>";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(996, 165);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 35);
            lblDate.TabIndex = 20;
            lblDate.Text = "<Label>";
            // 
            // lblReceiptID
            // 
            lblReceiptID.AutoSize = true;
            lblReceiptID.BackColor = Color.Transparent;
            lblReceiptID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceiptID.ForeColor = Color.Black;
            lblReceiptID.Location = new Point(1059, 101);
            lblReceiptID.Name = "lblReceiptID";
            lblReceiptID.Size = new Size(108, 35);
            lblReceiptID.TabIndex = 19;
            lblReceiptID.Text = "<Label>";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(916, 410);
            label12.Name = "label12";
            label12.Size = new Size(170, 35);
            label12.TabIndex = 18;
            label12.Text = "Amount Paid:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(916, 344);
            label11.Name = "label11";
            label11.Size = new Size(106, 35);
            label11.TabIndex = 17;
            label11.Text = "Section:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(916, 284);
            label10.Name = "label10";
            label10.Size = new Size(184, 35);
            label10.TabIndex = 16;
            label10.Text = "Student Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(916, 224);
            label9.Name = "label9";
            label9.Size = new Size(142, 35);
            label9.TabIndex = 15;
            label9.Text = "Student ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(916, 165);
            label8.Name = "label8";
            label8.Size = new Size(74, 35);
            label8.TabIndex = 14;
            label8.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(916, 101);
            label6.Name = "label6";
            label6.Size = new Size(137, 35);
            label6.TabIndex = 12;
            label6.Text = "Receipt ID:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Snow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(608, 479);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 54);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DeepSkyBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(402, 479);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 54);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 616);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1512, 303);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Receipt ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Student ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Student Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Section";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Amount Paid";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // dtpDateTo
            // 
            dtpDateTo.CalendarFont = new Font("Segoe UI Symbol", 12F);
            dtpDateTo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTo.Location = new Point(370, 361);
            dtpDateTo.Margin = new Padding(3, 4, 3, 4);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(414, 41);
            dtpDateTo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(256, 367);
            label5.Name = "label5";
            label5.Size = new Size(108, 35);
            label5.TabIndex = 7;
            label5.Text = "Date To:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarFont = new Font("Segoe UI Symbol", 12F);
            dtpDateFrom.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFrom.Location = new Point(402, 278);
            dtpDateFrom.Margin = new Padding(3, 4, 3, 4);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(382, 41);
            dtpDateFrom.TabIndex = 6;
            // 
            // txtReceiptId
            // 
            txtReceiptId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceiptId.Location = new Point(402, 199);
            txtReceiptId.Margin = new Padding(3, 4, 3, 4);
            txtReceiptId.Name = "txtReceiptId";
            txtReceiptId.Size = new Size(382, 41);
            txtReceiptId.TabIndex = 5;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(402, 123);
            txtStudentId.Margin = new Padding(3, 4, 3, 4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(382, 41);
            txtStudentId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(256, 284);
            label4.Name = "label4";
            label4.Size = new Size(140, 35);
            label4.TabIndex = 3;
            label4.Text = "Date From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(259, 205);
            label3.Name = "label3";
            label3.Size = new Size(137, 35);
            label3.TabIndex = 2;
            label3.Text = "Receipt ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(254, 123);
            label2.Name = "label2";
            label2.Size = new Size(142, 35);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(542, 50);
            label1.TabIndex = 0;
            label1.Text = "Payment History and Receipts";
            // 
            // PaymentHistoryandReceiptsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 918);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
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