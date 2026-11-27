namespace UI
{
    partial class UserAccountManagement
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
            btnActivate = new Button();
            dgvStudentInfo = new DataGridView();
            dtvUser = new DataGridViewTextBoxColumn();
            dgvUsername = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            btnDeactivate = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            cmbRoles = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblRoles = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblUserAccount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(dgvStudentInfo);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(cmbRoles);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblRoles);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblUserAccount);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 965);
            panel1.TabIndex = 0;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.ForestGreen;
            btnActivate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivate.ForeColor = SystemColors.Control;
            btnActivate.Location = new Point(733, 381);
            btnActivate.Margin = new Padding(3, 4, 3, 4);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(149, 54);
            btnActivate.TabIndex = 22;
            btnActivate.Text = "ACTIVATE";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Columns.AddRange(new DataGridViewColumn[] { dtvUser, dgvUsername, dgvRole, dgvStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudentInfo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudentInfo.GridColor = Color.Gray;
            dgvStudentInfo.Location = new Point(3, 442);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudentInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudentInfo.RowHeadersWidth = 51;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(1533, 523);
            dgvStudentInfo.TabIndex = 10;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // dtvUser
            // 
            dtvUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtvUser.HeaderText = "User ID";
            dtvUser.MinimumWidth = 6;
            dtvUser.Name = "dtvUser";
            // 
            // dgvUsername
            // 
            dgvUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsername.HeaderText = "Username";
            dgvUsername.MinimumWidth = 6;
            dgvUsername.Name = "dgvUsername";
            // 
            // dgvRole
            // 
            dgvRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRole.HeaderText = "Role";
            dgvRole.MinimumWidth = 6;
            dgvRole.Name = "dgvRole";
            // 
            // dgvStatus
            // 
            dgvStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Red;
            btnDeactivate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(478, 381);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(191, 54);
            btnDeactivate.TabIndex = 9;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(271, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 54);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreate.BackColor = Color.Green;
            btnCreate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(65, 381);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(141, 54);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(131, 279);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(389, 49);
            cmbRoles.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(196, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(526, 47);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(196, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(526, 47);
            txtUsername.TabIndex = 4;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoles.Location = new Point(27, 287);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(98, 41);
            lblRoles.TabIndex = 3;
            lblRoles.Text = "Roles:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(27, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(154, 41);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(27, 126);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(163, 41);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblUserAccount
            // 
            lblUserAccount.AutoSize = true;
            lblUserAccount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserAccount.Location = new Point(27, 29);
            lblUserAccount.Name = "lblUserAccount";
            lblUserAccount.Size = new Size(493, 50);
            lblUserAccount.TabIndex = 0;
            lblUserAccount.Text = "User Account Management";
            // 
            // UserAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1518, 918);
            Controls.Add(panel1);
            Name = "UserAccountManagement";
            Text = "UserAccountManagement";
            Load += UserAccountManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private Label lblUserAccount;
        private Label lblPassword;
        private Label lblRoles;
        private Button btnCreate;
        private ComboBox cmbRoles;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private DataGridView dgvStudentInfo;
        private Button btnDeactivate;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn dtvUser;
        private DataGridViewTextBoxColumn dgvUsername;
        private DataGridViewTextBoxColumn dgvRole;
        private DataGridViewTextBoxColumn dgvStatus;
        private Button btnActivate;
    }
}