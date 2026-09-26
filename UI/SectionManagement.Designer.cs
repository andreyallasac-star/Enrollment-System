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
            lblSectionManagement = new Label();
            lblSectionCode = new Label();
            lblSectionName = new Label();
            lblGradeLevel = new Label();
            lblSchoolYear = new Label();
            txtSectionCode = new TextBox();
            txtSectionName = new TextBox();
            txtGradeLevel = new TextBox();
            txtSchoolYear = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            dgvInfo = new DataGridView();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvGrade = new DataGridViewTextBoxColumn();
            dgvYear = new DataGridViewTextBoxColumn();
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
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 574);
            panel1.TabIndex = 0;
            // 
            // lblSectionManagement
            // 
            lblSectionManagement.AutoSize = true;
            lblSectionManagement.BackColor = Color.Transparent;
            lblSectionManagement.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionManagement.ForeColor = Color.Black;
            lblSectionManagement.Location = new Point(27, 16);
            lblSectionManagement.Name = "lblSectionManagement";
            lblSectionManagement.Size = new Size(359, 46);
            lblSectionManagement.TabIndex = 0;
            lblSectionManagement.Text = "Section Management";
            // 
            // lblSectionCode
            // 
            lblSectionCode.AutoSize = true;
            lblSectionCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionCode.Location = new Point(27, 102);
            lblSectionCode.Name = "lblSectionCode";
            lblSectionCode.Size = new Size(153, 31);
            lblSectionCode.TabIndex = 1;
            lblSectionCode.Text = "Section Code:";
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionName.Location = new Point(27, 156);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(161, 31);
            lblSectionName.TabIndex = 2;
            lblSectionName.Text = "Section Name:";
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevel.Location = new Point(27, 208);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(139, 31);
            lblGradeLevel.TabIndex = 3;
            lblGradeLevel.Text = "Grade Level:";
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.Location = new Point(27, 261);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(136, 31);
            lblSchoolYear.TabIndex = 4;
            lblSchoolYear.Text = "School Year:";
            // 
            // txtSectionCode
            // 
            txtSectionCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionCode.Location = new Point(198, 99);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(341, 38);
            txtSectionCode.TabIndex = 5;
            // 
            // txtSectionName
            // 
            txtSectionName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionName.Location = new Point(198, 153);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(341, 38);
            txtSectionName.TabIndex = 6;
            // 
            // txtGradeLevel
            // 
            txtGradeLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeLevel.Location = new Point(198, 208);
            txtGradeLevel.Name = "txtGradeLevel";
            txtGradeLevel.Size = new Size(341, 38);
            txtGradeLevel.TabIndex = 7;
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(198, 261);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.Size = new Size(341, 38);
            txtSchoolYear.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(622, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 43);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(622, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 43);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(192, 0, 0);
            btnDeactivate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(606, 249);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(150, 43);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Columns.AddRange(new DataGridViewColumn[] { dgvCode, dgvName, dgvGrade, dgvYear });
            dgvInfo.Location = new Point(0, 337);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.Size = new Size(858, 234);
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
            // SectionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 579);
            Controls.Add(panel1);
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