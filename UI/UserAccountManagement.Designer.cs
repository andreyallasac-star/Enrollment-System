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
            panel1 = new Panel();
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
            panel1.BackColor = Color.Transparent;
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
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 650);
            panel1.TabIndex = 0;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Columns.AddRange(new DataGridViewColumn[] { dtvUser, dgvUsername, dgvRole, dgvStatus });
            dgvStudentInfo.GridColor = Color.Gray;
            dgvStudentInfo.Location = new Point(0, 358);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.RowHeadersWidth = 51;
            dgvStudentInfo.Size = new Size(856, 292);
            dgvStudentInfo.TabIndex = 10;
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
            btnDeactivate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(437, 284);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(159, 45);
            btnDeactivate.TabIndex = 9;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Red;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(241, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Green;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(27, 284);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 45);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(146, 205);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(224, 39);
            cmbRoles.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(146, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 38);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(146, 99);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 38);
            txtUsername.TabIndex = 4;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoles.Location = new Point(18, 213);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(73, 31);
            lblRoles.TabIndex = 3;
            lblRoles.Text = "Roles:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(18, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 31);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(18, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(122, 31);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblUserAccount
            // 
            lblUserAccount.AutoSize = true;
            lblUserAccount.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserAccount.Location = new Point(18, 18);
            lblUserAccount.Name = "lblUserAccount";
            lblUserAccount.Size = new Size(454, 46);
            lblUserAccount.TabIndex = 0;
            lblUserAccount.Text = "User Account Management";
            // 
            // UserAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 659);
            Controls.Add(panel1);
            Name = "UserAccountManagement";
            Text = "UserAccountManagement";
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
    }
}