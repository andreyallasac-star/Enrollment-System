namespace UI
{
    partial class StudentManagementForm
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            panel4 = new Panel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(47, 32);
            label2.TabIndex = 1;
            label2.Text = "👤";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(65, 11);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 1;
            label1.Text = "Student Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.Azure;
            panel2.Location = new Point(12, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 48);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 3;
            label3.Text = "Student Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(label4);
            panel3.ForeColor = Color.Azure;
            panel3.Location = new Point(12, 528);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 48);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Student Records";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 153);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 3;
            label5.Text = "Student ID*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 231);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 4;
            label6.Text = "First Name*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 387);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 5;
            label7.Text = "Last Name*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 309);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 6;
            label8.Text = "Middle Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(435, 153);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 7;
            label9.Text = "Date of Birth*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(435, 231);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 8;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(435, 309);
            label11.Name = "label11";
            label11.Size = new Size(70, 21);
            label11.TabIndex = 9;
            label11.Text = "Address";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(21, 177);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(365, 36);
            txtStudentID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(21, 255);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(365, 36);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(21, 333);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(365, 36);
            txtMiddleName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(21, 411);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(365, 36);
            txtLastName.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(435, 333);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 114);
            txtAddress.TabIndex = 14;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(435, 177);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(219, 23);
            dtpDateofBirth.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(435, 255);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(219, 23);
            cmbGender.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(21, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 33);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(141, 470);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 33);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Firebrick;
            btnDeactivate.ForeColor = SystemColors.Control;
            btnDeactivate.Location = new Point(268, 470);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(121, 33);
            btnDeactivate.TabIndex = 19;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.ForeColor = Color.Azure;
            panel4.Location = new Point(12, 582);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 28);
            panel4.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(3, 7);
            label12.Name = "label12";
            label12.Size = new Size(74, 17);
            label12.TabIndex = 21;
            label12.Text = "Student ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(88, 7);
            label13.Name = "label13";
            label13.Size = new Size(75, 17);
            label13.TabIndex = 22;
            label13.Text = "First Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(176, 7);
            label14.Name = "label14";
            label14.Size = new Size(91, 17);
            label14.TabIndex = 22;
            label14.Text = "Middle Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(282, 7);
            label15.Name = "label15";
            label15.Size = new Size(73, 17);
            label15.TabIndex = 22;
            label15.Text = "Last Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(391, 7);
            label16.Name = "label16";
            label16.Size = new Size(88, 17);
            label16.TabIndex = 22;
            label16.Text = "Date of Birth";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(520, 7);
            label17.Name = "label17";
            label17.Size = new Size(52, 17);
            label17.TabIndex = 22;
            label17.Text = "Gender";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(627, 7);
            label18.Name = "label18";
            label18.Size = new Size(57, 17);
            label18.TabIndex = 22;
            label18.Text = "Address";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(658, 7);
            label19.Name = "label19";
            label19.Size = new Size(0, 17);
            label19.TabIndex = 22;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(742, 7);
            label20.Name = "label20";
            label20.Size = new Size(46, 17);
            label20.TabIndex = 23;
            label20.Text = "Status";
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 747);
            Controls.Add(panel4);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(dtpDateofBirth);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private DateTimePicker dtpDateofBirth;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDeactivate;
        private Panel panel4;
        private Label label12;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}