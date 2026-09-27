namespace UI
{
    partial class DashboardForm
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
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            label6 = new Label();
            lblWelcome = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            btnStudentEnrollment = new Button();
            btnSectionManagement = new Button();
            btnStudentManagement = new Button();
            btnUserAccount = new Button();
            btnSearch = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 17);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Enrollment System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 61);
            panel1.TabIndex = 1;
            // 
            // button12
            // 
            button12.BackColor = Color.DeepSkyBlue;
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Location = new Point(1045, 9);
            button12.Name = "button12";
            button12.Size = new Size(125, 43);
            button12.TabIndex = 4;
            button12.Text = "Logout";
            button12.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(994, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 45);
            label6.TabIndex = 4;
            label6.Text = " │";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.DeepSkyBlue;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Control;
            lblWelcome.Location = new Point(611, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(31, 32);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(64, 45);
            label2.TabIndex = 2;
            label2.Text = "🎓";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(btnStudentEnrollment);
            panel2.Controls.Add(btnSectionManagement);
            panel2.Controls.Add(btnStudentManagement);
            panel2.Controls.Add(btnUserAccount);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(2, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 443);
            panel2.TabIndex = 2;
            // 
            // button11
            // 
            button11.BackColor = Color.Azure;
            button11.ForeColor = Color.Black;
            button11.Location = new Point(3, 387);
            button11.Name = "button11";
            button11.Size = new Size(194, 36);
            button11.TabIndex = 11;
            button11.Text = "Student Information Report";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Azure;
            button10.ForeColor = Color.Black;
            button10.Location = new Point(3, 345);
            button10.Name = "button10";
            button10.Size = new Size(194, 36);
            button10.TabIndex = 10;
            button10.Text = "Payment History/ Reciepts";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Azure;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(3, 303);
            button9.Name = "button9";
            button9.Size = new Size(194, 36);
            button9.TabIndex = 9;
            button9.Text = "Payment/Cashiering";
            button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Azure;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(3, 261);
            button7.Name = "button7";
            button7.Size = new Size(194, 36);
            button7.TabIndex = 6;
            button7.Text = "Student Assessment";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // btnStudentEnrollment
            // 
            btnStudentEnrollment.BackColor = Color.Azure;
            btnStudentEnrollment.ForeColor = Color.Black;
            btnStudentEnrollment.Location = new Point(3, 219);
            btnStudentEnrollment.Name = "btnStudentEnrollment";
            btnStudentEnrollment.Size = new Size(194, 36);
            btnStudentEnrollment.TabIndex = 7;
            btnStudentEnrollment.Text = "Student Enrollment";
            btnStudentEnrollment.UseVisualStyleBackColor = false;
            btnStudentEnrollment.Click += btnStudentEnrollment_Click;
            // 
            // btnSectionManagement
            // 
            btnSectionManagement.BackColor = Color.Azure;
            btnSectionManagement.ForeColor = Color.Black;
            btnSectionManagement.Location = new Point(3, 177);
            btnSectionManagement.Name = "btnSectionManagement";
            btnSectionManagement.Size = new Size(194, 36);
            btnSectionManagement.TabIndex = 6;
            btnSectionManagement.Text = "Section Management";
            btnSectionManagement.UseVisualStyleBackColor = false;
            btnSectionManagement.Click += btnSectionManagement_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.Azure;
            btnStudentManagement.ForeColor = Color.Black;
            btnStudentManagement.Location = new Point(3, 135);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(194, 36);
            btnStudentManagement.TabIndex = 5;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = false;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // btnUserAccount
            // 
            btnUserAccount.BackColor = Color.Azure;
            btnUserAccount.ForeColor = Color.Black;
            btnUserAccount.Location = new Point(3, 93);
            btnUserAccount.Name = "btnUserAccount";
            btnUserAccount.Size = new Size(194, 36);
            btnUserAccount.TabIndex = 5;
            btnUserAccount.Text = "User Account Management";
            btnUserAccount.UseVisualStyleBackColor = false;
            btnUserAccount.Click += btnUserAccount_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(3, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Student Account Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 9);
            button1.Name = "button1";
            button1.Size = new Size(194, 36);
            button1.TabIndex = 3;
            button1.Text = "Dasboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.Location = new Point(209, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 536);
            panel3.TabIndex = 3;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlLightLight;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label lblWelcome;
        private Label label6;
        private Panel panel2;
        private Button button1;
        private Button btnStudentEnrollment;
        private Button btnSectionManagement;
        private Button btnStudentManagement;
        private Button btnUserAccount;
        private Button btnSearch;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button12;
        private Panel panel3;
    }
}