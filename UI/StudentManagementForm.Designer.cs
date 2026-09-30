namespace UI
{
    partial class StudentManagementForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            dgvStudentRecords = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 1;
            label1.Text = "Student Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 3;
            label3.Text = "Student Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 531);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Student Records";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 153);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 3;
            label5.Text = "Student ID*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 231);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 4;
            label6.Text = "First Name*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(21, 387);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 5;
            label7.Text = "Last Name*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(21, 309);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 6;
            label8.Text = "Middle Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(435, 153);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 7;
            label9.Text = "Date of Birth*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(435, 231);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 8;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(435, 309);
            label11.Name = "label11";
            label11.Size = new Size(70, 21);
            label11.TabIndex = 9;
            label11.Text = "Address";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(21, 177);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(365, 36);
            txtStudentID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(21, 255);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(365, 36);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(21, 333);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(365, 36);
            txtMiddleName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(21, 411);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(365, 36);
            txtLastName.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(435, 333);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 114);
            txtAddress.TabIndex = 14;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(435, 177);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(219, 23);
            dtpDateofBirth.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(435, 255);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(219, 23);
            cmbGender.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(21, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 33);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(141, 470);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 33);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Firebrick;
            btnDeactivate.ForeColor = SystemColors.Control;
            btnDeactivate.Location = new Point(268, 470);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(121, 33);
            btnDeactivate.TabIndex = 19;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRecords.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvStudentRecords.Location = new Point(12, 563);
            dgvStudentRecords.Name = "dgvStudentRecords";
            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRecords.Size = new Size(801, 172);
            dgvStudentRecords.TabIndex = 20;
            dgvStudentRecords.CellClick += dgvStudentRecords_CellClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Student ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "First Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Middle Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Last Name";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Date of Birth";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Gender";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Address";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Azure;
            ClientSize = new Size(834, 747);
            Controls.Add(dgvStudentRecords);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(dtpDateofBirth);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            Load += StudentManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private DateTimePicker dtpDateofBirth;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDeactivate;
        private DataGridView dgvStudentRecords;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}