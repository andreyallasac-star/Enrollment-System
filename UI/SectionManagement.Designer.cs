namespace UI
{
    partial class SectionManagement
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
            panel1 = new Panel();
            btnActivate = new Button();
            cmbSchoolYear = new ComboBox();
            cmbGradeLevel = new ComboBox();
            dgvInfo = new DataGridView();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvGrade = new DataGridViewTextBoxColumn();
            dgvYear = new DataGridViewTextBoxColumn();
            btnDeactivate = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSectionName = new TextBox();
            txtSectionCode = new TextBox();
            lblSchoolYear = new Label();
            lblGradeLevel = new Label();
            lblSectionName = new Label();
            lblSectionCode = new Label();
            lblSectionManagement = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(cmbSchoolYear);
            panel1.Controls.Add(cmbGradeLevel);
            panel1.Controls.Add(dgvInfo);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSectionName);
            panel1.Controls.Add(txtSectionCode);
            panel1.Controls.Add(lblSchoolYear);
            panel1.Controls.Add(lblGradeLevel);
            panel1.Controls.Add(lblSectionName);
            panel1.Controls.Add(lblSectionCode);
            panel1.Controls.Add(lblSectionManagement);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 1010);
            panel1.TabIndex = 0;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Lime;
            btnActivate.BackgroundImageLayout = ImageLayout.Stretch;
            btnActivate.FlatAppearance.BorderColor = Color.Green;
            btnActivate.FlatAppearance.BorderSize = 3;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnActivate.ForeColor = Color.Green;
            btnActivate.Location = new Point(793, 400);
            btnActivate.Margin = new Padding(3, 2, 3, 2);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(215, 62);
            btnActivate.TabIndex = 15;
            btnActivate.Text = "ACTIVATE";
            btnActivate.UseVisualStyleBackColor = false;
            // 
            // cmbSchoolYear
            // 
            cmbSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchoolYear.FlatStyle = FlatStyle.System;
            cmbSchoolYear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            cmbSchoolYear.FormattingEnabled = true;
            cmbSchoolYear.Location = new Point(856, 254);
            cmbSchoolYear.Name = "cmbSchoolYear";
            cmbSchoolYear.Size = new Size(299, 37);
            cmbSchoolYear.TabIndex = 14;
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeLevel.FlatStyle = FlatStyle.System;
            cmbGradeLevel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Location = new Point(259, 254);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(299, 37);
            cmbGradeLevel.TabIndex = 13;
            // 
            // dgvInfo
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInfo.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Columns.AddRange(new DataGridViewColumn[] { dgvCode, dgvName, dgvGrade, dgvYear });
            dgvInfo.Location = new Point(0, 546);
            dgvInfo.Margin = new Padding(3, 2, 3, 2);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.Size = new Size(1602, 461);
            dgvInfo.TabIndex = 12;
            dgvInfo.CellClick += dgvInfo_CellClick;
            // 
            // dgvCode
            // 
            dgvCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCode.HeaderText = "Code";
            dgvCode.MinimumWidth = 6;
            dgvCode.Name = "dgvCode";
            // 
            // dgvName
            // 
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.Width = 125;
            // 
            // dgvGrade
            // 
            dgvGrade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrade.HeaderText = "Grade";
            dgvGrade.MinimumWidth = 6;
            dgvGrade.Name = "dgvGrade";
            // 
            // dgvYear
            // 
            dgvYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvYear.HeaderText = "Year";
            dgvYear.MinimumWidth = 6;
            dgvYear.Name = "dgvYear";
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(255, 128, 0);
            btnDeactivate.FlatAppearance.BorderColor = Color.Maroon;
            btnDeactivate.FlatAppearance.BorderSize = 3;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.Maroon;
            btnDeactivate.Location = new Point(1117, 400);
            btnDeactivate.Margin = new Padding(3, 2, 3, 2);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(215, 62);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnUpdate.FlatAppearance.BorderSize = 3;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Teal;
            btnUpdate.Location = new Point(482, 400);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 62);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(181, 400);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 62);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSectionName
            // 
            txtSectionName.BorderStyle = BorderStyle.FixedSingle;
            txtSectionName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtSectionName.Location = new Point(856, 168);
            txtSectionName.Margin = new Padding(3, 2, 3, 2);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(299, 35);
            txtSectionName.TabIndex = 6;
            // 
            // txtSectionCode
            // 
            txtSectionCode.BorderStyle = BorderStyle.FixedSingle;
            txtSectionCode.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtSectionCode.ForeColor = SystemColors.WindowText;
            txtSectionCode.Location = new Point(259, 168);
            txtSectionCode.Margin = new Padding(3, 2, 3, 2);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(299, 35);
            txtSectionCode.TabIndex = 5;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSchoolYear.ForeColor = Color.Black;
            lblSchoolYear.Location = new Point(621, 254);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(163, 29);
            lblSchoolYear.TabIndex = 4;
            lblSchoolYear.Text = "School Year:";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblGradeLevel.ForeColor = Color.Black;
            lblGradeLevel.Location = new Point(24, 254);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(162, 29);
            lblGradeLevel.TabIndex = 3;
            lblGradeLevel.Text = "Grade Level:";
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSectionName.ForeColor = Color.Black;
            lblSectionName.Location = new Point(621, 170);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(184, 29);
            lblSectionName.TabIndex = 2;
            lblSectionName.Text = "Section Name:";
            // 
            // lblSectionCode
            // 
            lblSectionCode.AutoSize = true;
            lblSectionCode.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSectionCode.ForeColor = Color.Black;
            lblSectionCode.Location = new Point(24, 170);
            lblSectionCode.Name = "lblSectionCode";
            lblSectionCode.Size = new Size(178, 29);
            lblSectionCode.TabIndex = 1;
            lblSectionCode.Text = "Section Code:";
            // 
            // lblSectionManagement
            // 
            lblSectionManagement.AutoSize = true;
            lblSectionManagement.BackColor = Color.Transparent;
            lblSectionManagement.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionManagement.ForeColor = Color.Black;
            lblSectionManagement.Location = new Point(24, 29);
            lblSectionManagement.Name = "lblSectionManagement";
            lblSectionManagement.Size = new Size(290, 37);
            lblSectionManagement.TabIndex = 0;
            lblSectionManagement.Text = "Section Management";
            // 
            // SectionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 1013);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SectionManagement";
            Text = "SectionManagement";
            Load += SectionManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSectionManagement;
        private TextBox txtSectionName;
        private TextBox txtSectionCode;
        private Label lblSchoolYear;
        private Label lblGradeLevel;
        private Label lblSectionName;
        private Label lblSectionCode;
        private DataGridView dgvInfo;
        private Button btnDeactivate;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridViewTextBoxColumn dgvCode;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvGrade;
        private DataGridViewTextBoxColumn dgvYear;
        private ComboBox cmbGradeLevel;
        private ComboBox cmbSchoolYear;
        private Button btnActivate;
    }
}