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
            panel1 = new Panel();
            dgvInfo = new DataGridView();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvGrade = new DataGridViewTextBoxColumn();
            dgvYear = new DataGridViewTextBoxColumn();
            btnDeactivate = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSchoolYear = new TextBox();
            txtGradeLevel = new TextBox();
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
            panel1.Controls.Add(dgvInfo);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSchoolYear);
            panel1.Controls.Add(txtGradeLevel);
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
            panel1.Size = new Size(751, 430);
            panel1.TabIndex = 0;
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Columns.AddRange(new DataGridViewColumn[] { dgvCode, dgvName, dgvGrade, dgvYear });
            dgvInfo.Location = new Point(0, 253);
            dgvInfo.Margin = new Padding(3, 2, 3, 2);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.Size = new Size(751, 176);
            dgvInfo.TabIndex = 12;
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
            btnDeactivate.BackColor = Color.FromArgb(192, 0, 0);
            btnDeactivate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(530, 187);
            btnDeactivate.Margin = new Padding(3, 2, 3, 2);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(131, 32);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(544, 130);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 32);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(544, 74);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 32);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(173, 196);
            txtSchoolYear.Margin = new Padding(3, 2, 3, 2);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(299, 32);
            txtSchoolYear.TabIndex = 8;
            // 
            // txtGradeLevel
            // 
            txtGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeLevel.Location = new Point(173, 156);
            txtGradeLevel.Margin = new Padding(3, 2, 3, 2);
            txtGradeLevel.Name = "txtGradeLevel";
            txtGradeLevel.Size = new Size(299, 32);
            txtGradeLevel.TabIndex = 7;
            // 
            // txtSectionName
            // 
            txtSectionName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionName.Location = new Point(173, 115);
            txtSectionName.Margin = new Padding(3, 2, 3, 2);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(299, 32);
            txtSectionName.TabIndex = 6;
            // 
            // txtSectionCode
            // 
            txtSectionCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionCode.Location = new Point(173, 74);
            txtSectionCode.Margin = new Padding(3, 2, 3, 2);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(299, 32);
            txtSectionCode.TabIndex = 5;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.ForeColor = Color.Black;
            lblSchoolYear.Location = new Point(24, 196);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(114, 25);
            lblSchoolYear.TabIndex = 4;
            lblSchoolYear.Text = "School Year:";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevel.ForeColor = Color.Black;
            lblGradeLevel.Location = new Point(24, 156);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(115, 25);
            lblGradeLevel.TabIndex = 3;
            lblGradeLevel.Text = "Grade Level:";
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionName.ForeColor = Color.Black;
            lblSectionName.Location = new Point(24, 117);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(133, 25);
            lblSectionName.TabIndex = 2;
            lblSectionName.Text = "Section Name:";
            // 
            // lblSectionCode
            // 
            lblSectionCode.AutoSize = true;
            lblSectionCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionCode.ForeColor = Color.Black;
            lblSectionCode.Location = new Point(24, 76);
            lblSectionCode.Name = "lblSectionCode";
            lblSectionCode.Size = new Size(127, 25);
            lblSectionCode.TabIndex = 1;
            lblSectionCode.Text = "Section Code:";
            // 
            // lblSectionManagement
            // 
            lblSectionManagement.AutoSize = true;
            lblSectionManagement.BackColor = Color.Transparent;
            lblSectionManagement.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionManagement.ForeColor = Color.Black;
            lblSectionManagement.Location = new Point(24, 12);
            lblSectionManagement.Name = "lblSectionManagement";
            lblSectionManagement.Size = new Size(290, 37);
            lblSectionManagement.TabIndex = 0;
            lblSectionManagement.Text = "Section Management";
            // 
            // SectionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 434);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SectionManagement";
            Text = "SectionManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSectionManagement;
        private TextBox txtSchoolYear;
        private TextBox txtGradeLevel;
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
    }
}