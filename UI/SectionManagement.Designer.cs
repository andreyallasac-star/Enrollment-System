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
            dgvInfo = new DataGridView();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvGrade = new DataGridViewTextBoxColumn();
            dgvYear = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
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
            lblCap = new Label();
            txtCapacity = new TextBox();
            dgvCapacity = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
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
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 724);
            panel1.TabIndex = 0;
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
            dgvInfo.Location = new Point(24, 422);
            dgvInfo.Margin = new Padding(3, 2, 3, 2);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.ReadOnly = true;
            dgvInfo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.Size = new Size(1318, 302);
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
            // btnActivate
            // 
            btnActivate.BackColor = Color.Lime;
            btnActivate.BackgroundImageLayout = ImageLayout.Stretch;
            btnActivate.FlatAppearance.BorderColor = Color.Green;
            btnActivate.FlatAppearance.BorderSize = 3;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnActivate.ForeColor = Color.Green;
            btnActivate.Location = new Point(642, 342);
            btnActivate.Margin = new Padding(3, 2, 3, 2);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(243, 62);
            btnActivate.TabIndex = 15;
            btnActivate.Text = "ACTIVATE";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.BorderStyle = BorderStyle.FixedSingle;
            txtSchoolYear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtSchoolYear.Location = new Point(742, 198);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.PlaceholderText = "e.g. 2026-2027";
            txtSchoolYear.Size = new Size(221, 35);
            txtSchoolYear.TabIndex = 14;
            // 
            // cmbGradeLevel
            // 
            cmbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeLevel.FlatStyle = FlatStyle.System;
            cmbGradeLevel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            cmbGradeLevel.FormattingEnabled = true;
            cmbGradeLevel.Location = new Point(209, 198);
            cmbGradeLevel.Name = "cmbGradeLevel";
            cmbGradeLevel.Size = new Size(235, 37);
            cmbGradeLevel.TabIndex = 13;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(255, 128, 0);
            btnDeactivate.FlatAppearance.BorderColor = Color.Maroon;
            btnDeactivate.FlatAppearance.BorderSize = 3;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.Maroon;
            btnDeactivate.Location = new Point(932, 342);
            btnDeactivate.Margin = new Padding(3, 2, 3, 2);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(243, 62);
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
            btnUpdate.Location = new Point(354, 342);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(243, 62);
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
            btnAdd.Location = new Point(69, 342);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(243, 62);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSectionName
            // 
            txtSectionName.BorderStyle = BorderStyle.FixedSingle;
            txtSectionName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtSectionName.Location = new Point(742, 130);
            txtSectionName.Margin = new Padding(3, 2, 3, 2);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(221, 35);
            txtSectionName.TabIndex = 6;
            // 
            // txtSectionCode
            // 
            txtSectionCode.BorderStyle = BorderStyle.FixedSingle;
            txtSectionCode.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtSectionCode.ForeColor = SystemColors.WindowText;
            txtSectionCode.Location = new Point(209, 133);
            txtSectionCode.Margin = new Padding(3, 2, 3, 2);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(235, 35);
            txtSectionCode.TabIndex = 5;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblSchoolYear.ForeColor = Color.Black;
            lblSchoolYear.Location = new Point(552, 201);
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
            lblGradeLevel.Location = new Point(24, 201);
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
            lblSectionName.Location = new Point(552, 135);
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
            lblSectionCode.Location = new Point(24, 135);
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
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblCap.ForeColor = Color.Black;
            lblCap.Location = new Point(24, 264);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(120, 29);
            lblCap.TabIndex = 17;
            lblCap.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtCapacity.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtCapacity.ForeColor = SystemColors.WindowText;
            txtCapacity.Location = new Point(209, 264);
            txtCapacity.Margin = new Padding(3, 2, 3, 2);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(235, 35);
            txtCapacity.TabIndex = 18;
            txtCapacity.Text = "40";
            // 
            // dgvCapacity
            // 
            dgvCapacity.HeaderText = "Capacity";
            dgvCapacity.Name = "dgvCapacity";
            dgvCapacity.ReadOnly = true;
            // 
            // SectionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
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
        private TextBox txtSchoolYear;
        private Button btnActivate;
        private DataGridViewTextBoxColumn Column1;
        private Label lblCap;
        private TextBox txtCapacity;
        private DataGridViewTextBoxColumn dgvCapacity;
    }
}