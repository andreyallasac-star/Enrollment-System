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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtCapacity = new TextBox();
            lblCap = new Label();
            dgvInfo = new DataGridView();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvGrade = new DataGridViewTextBoxColumn();
            dgvYear = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dgvCapacity = new DataGridViewTextBoxColumn();
            btnActivate = new Button();
            txtSchoolYear = new TextBox();
            cmbGradeLevel = new ComboBox();
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
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(txtCapacity);
            panel1.Controls.Add(lblCap);
            panel1.Controls.Add(dgvInfo);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(txtSchoolYear);
            panel1.Controls.Add(cmbGradeLevel);
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
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1551, 989);
            panel1.TabIndex = 0;
            // 
            // txtCapacity
            // 
            txtCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtCapacity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.ForeColor = SystemColors.WindowText;
            txtCapacity.Location = new Point(252, 350);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(287, 47);
            txtCapacity.TabIndex = 18;
            txtCapacity.Text = "40";
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCap.ForeColor = Color.Black;
            lblCap.Location = new Point(27, 352);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(142, 41);
            lblCap.TabIndex = 17;
            lblCap.Text = "Capacity:";
            // 
            // dgvInfo
            // 
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Columns.AddRange(new DataGridViewColumn[] { dgvCode, dgvName, dgvGrade, dgvYear, Column1, dgvCapacity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInfo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInfo.Location = new Point(3, 550);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.ReadOnly = true;
            dgvInfo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.Size = new Size(1531, 412);
            dgvInfo.TabIndex = 12;
            dgvInfo.CellClick += dgvInfo_CellClick;
            // 
            // dgvCode
            // 
            dgvCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCode.HeaderText = "Code";
            dgvCode.MinimumWidth = 6;
            dgvCode.Name = "dgvCode";
            dgvCode.ReadOnly = true;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            dgvName.Width = 125;
            // 
            // dgvGrade
            // 
            dgvGrade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrade.HeaderText = "Grade";
            dgvGrade.MinimumWidth = 6;
            dgvGrade.Name = "dgvGrade";
            dgvGrade.ReadOnly = true;
            // 
            // dgvYear
            // 
            dgvYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvYear.HeaderText = "Year";
            dgvYear.MinimumWidth = 6;
            dgvYear.Name = "dgvYear";
            dgvYear.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Status";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // dgvCapacity
            // 
            dgvCapacity.HeaderText = "Capacity";
            dgvCapacity.MinimumWidth = 6;
            dgvCapacity.Name = "dgvCapacity";
            dgvCapacity.ReadOnly = true;
            dgvCapacity.Width = 125;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.ForestGreen;
            btnActivate.BackgroundImageLayout = ImageLayout.Stretch;
            btnActivate.FlatAppearance.BorderColor = Color.Green;
            btnActivate.FlatAppearance.BorderSize = 3;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivate.ForeColor = Color.White;
            btnActivate.Location = new Point(717, 466);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(226, 65);
            btnActivate.TabIndex = 15;
            btnActivate.Text = "ACTIVATE";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.BorderStyle = BorderStyle.FixedSingle;
            txtSchoolYear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(908, 262);
            txtSchoolYear.Margin = new Padding(3, 4, 3, 4);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.PlaceholderText = "e.g. 2026-2027";
            txtSchoolYear.Size = new Size(279, 47);
            txtSchoolYear.TabIndex = 14;
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeLevel.FlatStyle = FlatStyle.System;
            cmbGradeLevel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Location = new Point(252, 262);
            cmbGradeLevel.Margin = new Padding(3, 4, 3, 4);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(287, 49);
            cmbGradeLevel.TabIndex = 13;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Red;
            btnDeactivate.FlatAppearance.BorderColor = Color.Maroon;
            btnDeactivate.FlatAppearance.BorderSize = 3;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(1004, 466);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(247, 65);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnUpdate.FlatAppearance.BorderSize = 3;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(448, 466);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 65);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(174, 466);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 65);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSectionName
            // 
            txtSectionName.BorderStyle = BorderStyle.FixedSingle;
            txtSectionName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionName.Location = new Point(908, 171);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(279, 47);
            txtSectionName.TabIndex = 6;
            // 
            // txtSectionCode
            // 
            txtSectionCode.BorderStyle = BorderStyle.FixedSingle;
            txtSectionCode.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionCode.ForeColor = SystemColors.WindowText;
            txtSectionCode.Location = new Point(252, 171);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(287, 47);
            txtSectionCode.TabIndex = 5;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSchoolYear.ForeColor = Color.Black;
            lblSchoolYear.Location = new Point(668, 262);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(182, 41);
            lblSchoolYear.TabIndex = 4;
            lblSchoolYear.Text = "School Year:";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradeLevel.ForeColor = Color.Black;
            lblGradeLevel.Location = new Point(27, 268);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(185, 41);
            lblGradeLevel.TabIndex = 3;
            lblGradeLevel.Text = "Grade Level:";
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionName.ForeColor = Color.Black;
            lblSectionName.Location = new Point(668, 177);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(216, 41);
            lblSectionName.TabIndex = 2;
            lblSectionName.Text = "Section Name:";
            // 
            // lblSectionCode
            // 
            lblSectionCode.AutoSize = true;
            lblSectionCode.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionCode.ForeColor = Color.Black;
            lblSectionCode.Location = new Point(27, 177);
            lblSectionCode.Name = "lblSectionCode";
            lblSectionCode.Size = new Size(205, 41);
            lblSectionCode.TabIndex = 1;
            lblSectionCode.Text = "Section Code:";
            // 
            // lblSectionManagement
            // 
            lblSectionManagement.AutoSize = true;
            lblSectionManagement.BackColor = Color.Transparent;
            lblSectionManagement.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionManagement.ForeColor = Color.Black;
            lblSectionManagement.Location = new Point(27, 44);
            lblSectionManagement.Name = "lblSectionManagement";
            lblSectionManagement.Size = new Size(391, 50);
            lblSectionManagement.TabIndex = 0;
            lblSectionManagement.Text = "Section Management";
            // 
            // SectionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 965);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtSchoolYear;
        private Button btnActivate;
        private DataGridViewTextBoxColumn Column1;
        private Label lblCap;
        private TextBox txtCapacity;
        private DataGridViewTextBoxColumn dgvCapacity;
    }
}