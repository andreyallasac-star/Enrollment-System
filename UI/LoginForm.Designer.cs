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
            btnClear = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblWelcome = new Label();
            lblPlease = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 570);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(60, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 10);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 228);
            label3.Name = "label3";
            label3.Size = new Size(376, 54);
            label3.TabIndex = 6;
            label3.Text = "Enrollment System";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(lblPlease);
            panel2.Location = new Point(485, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 442);
            panel2.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DeepSkyBlue;
            btnClear.Location = new Point(73, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 39);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(200, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ControlDarkDark;
            txtPassword.Location = new Point(73, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 34);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLight;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.ControlDarkDark;
            txtUsername.Location = new Point(73, 160);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 34);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblWelcome.Location = new Point(22, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(275, 38);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, students!";
            // 
            // lblPlease
            // 
            lblPlease.AutoSize = true;
            lblPlease.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlease.ForeColor = SystemColors.ControlDarkDark;
            lblPlease.Location = new Point(22, 98);
            lblPlease.Name = "lblPlease";
            lblPlease.Size = new Size(342, 17);
            lblPlease.TabIndex = 0;
            lblPlease.Text = "Please sign in with your student username and password.";
            lblPlease.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
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
        private Button btnClear;
    }
}