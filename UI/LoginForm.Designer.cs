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
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            lblPasswordDisplay = new Label();
            lblUsernameDisplay = new Label();
            lblPlease = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-4, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 428);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(30, 214);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 8);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 174);
            label3.Name = "label3";
            label3.Size = new Size(299, 45);
            label3.TabIndex = 6;
            label3.Text = "Enrollment System";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPasswordDisplay);
            panel2.Controls.Add(lblUsernameDisplay);
            panel2.Controls.Add(lblPlease);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblWelcome);
            panel2.Location = new Point(424, 53);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 332);
            panel2.TabIndex = 6;
            // 
            // lblPasswordDisplay
            // 
            lblPasswordDisplay.AutoSize = true;
            lblPasswordDisplay.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPasswordDisplay.ForeColor = SystemColors.ActiveCaptionText;
            lblPasswordDisplay.Location = new Point(59, 151);
            lblPasswordDisplay.Name = "lblPasswordDisplay";
            lblPasswordDisplay.Size = new Size(97, 25);
            lblPasswordDisplay.TabIndex = 7;
            lblPasswordDisplay.Text = "Password:";
            // 
            // lblUsernameDisplay
            // 
            lblUsernameDisplay.AutoSize = true;
            lblUsernameDisplay.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblUsernameDisplay.ForeColor = SystemColors.ActiveCaptionText;
            lblUsernameDisplay.Location = new Point(59, 93);
            lblUsernameDisplay.Name = "lblUsernameDisplay";
            lblUsernameDisplay.Size = new Size(102, 25);
            lblUsernameDisplay.TabIndex = 6;
            lblUsernameDisplay.Text = "Username:";
            // 
            // lblPlease
            // 
            lblPlease.AutoSize = true;
            lblPlease.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlease.ForeColor = SystemColors.ControlDarkDark;
            lblPlease.Location = new Point(7, 64);
            lblPlease.Name = "lblPlease";
            lblPlease.Size = new Size(310, 13);
            lblPlease.TabIndex = 0;
            lblPlease.Text = "Please sign in with your assigned username and password.";
            lblPlease.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(118, 251);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(85, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ControlDarkDark;
            txtPassword.Location = new Point(64, 179);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLight;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.ControlDarkDark;
            txtUsername.Location = new Point(64, 120);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 29);
            txtUsername.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblWelcome.Location = new Point(103, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(115, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 427);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblPlease;
        private TextBox txtUsername;
        private Label lblWelcome;
        private Button btnLogin;
        private TextBox txtPassword;
        private Panel panel3;
        private Label label3;
        private Label lblUsernameDisplay;
        private Label lblPasswordDisplay;
    }
}