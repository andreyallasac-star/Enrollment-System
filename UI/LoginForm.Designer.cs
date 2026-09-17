namespace UI
{
    partial class LoginForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtbUsername = new TextBox();
            txtbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(58, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(130, 31);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(58, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(124, 31);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password: ";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtbUsername
            // 
            txtbUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbUsername.Location = new Point(194, 53);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(249, 38);
            txtbUsername.TabIndex = 2;
            // 
            // txtbPassword
            // 
            txtbPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbPassword.Location = new Point(194, 112);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(249, 38);
            txtbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(224, 202);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 330);
            Controls.Add(btnLogin);
            Controls.Add(txtbPassword);
            Controls.Add(txtbUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtbUsername;
        private TextBox txtbPassword;
        private Button btnLogin;
    }
}