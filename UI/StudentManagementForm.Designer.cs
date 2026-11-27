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
            label1 = new Label();
            label4 = new Label();
            lblStudentId = new Label();
            lblFname = new Label();
            lblLname = new Label();
            lblMname = new Label();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            dgvStudentRecords = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnActivate = new Button();
            gbStudentInfo = new GroupBox();
            txtLRN = new TextBox();
            lblLRN = new Label();
            cmbStudentType = new ComboBox();
            lblStudentType = new Label();
            txtPostal = new TextBox();
            lblPostal = new Label();
            txtProvince = new TextBox();
            lblProvince = new Label();
            txtMunicipality = new TextBox();
            lblMunicipality = new Label();
            txtBarangay = new TextBox();
            lblBarangay = new Label();
            lblHouseno = new Label();
            txtHouseNo = new TextBox();
            gbGuardianInfo = new GroupBox();
            txtGpostal = new TextBox();
            lblGpostal = new Label();
            txtGprovince = new TextBox();
            lblGprovince = new Label();
            txtGmunicipality = new TextBox();
            lblGmunicipality = new Label();
            txtGbarangay = new TextBox();
            lblGbarangay = new Label();
            txtGhouseno = new TextBox();
            lblGhouseno = new Label();
            cmbGgender = new ComboBox();
            lblGgender = new Label();
            txtGrelationship = new TextBox();
            lblGrelationship = new Label();
            lblGcontact = new Label();
            txtGcontact = new TextBox();
            txtGlname = new TextBox();
            txtGmname = new TextBox();
            lblGlname = new Label();
            lblGmname = new Label();
            txtGfname = new TextBox();
            lblGfname = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            gbStudentInfo.SuspendLayout();
            gbGuardianInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(324, 41);
            label1.TabIndex = 1;
            label1.Text = "Student Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 590);
            label4.Name = "label4";
            label4.Size = new Size(200, 32);
            label4.TabIndex = 4;
            label4.Text = "Student Records";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(21, 61);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(122, 28);
            lblStudentId.TabIndex = 3;
            lblStudentId.Text = "Student ID*";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.BackColor = Color.Transparent;
            lblFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFname.ForeColor = Color.Black;
            lblFname.Location = new Point(21, 141);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(124, 28);
            lblFname.TabIndex = 4;
            lblFname.Text = "First Name*";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.BackColor = Color.Transparent;
            lblLname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLname.ForeColor = Color.Black;
            lblLname.Location = new Point(496, 141);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(121, 28);
            lblLname.TabIndex = 5;
            lblLname.Text = "Last Name*";
            // 
            // lblMname
            // 
            lblMname.AutoSize = true;
            lblMname.BackColor = Color.Transparent;
            lblMname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMname.ForeColor = Color.Black;
            lblMname.Location = new Point(262, 141);
            lblMname.Name = "lblMname";
            lblMname.Size = new Size(140, 28);
            lblMname.TabIndex = 6;
            lblMname.Text = "Middle Name";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.Black;
            lblDateOfBirth.Location = new Point(21, 226);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(146, 28);
            lblDateOfBirth.TabIndex = 7;
            lblDateOfBirth.Text = "Date of Birth*";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(424, 226);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 28);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtStudentID.Location = new Point(21, 93);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(305, 35);
            txtStudentID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtFirstName.Location = new Point(21, 173);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(188, 35);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMiddleName.Location = new Point(259, 173);
            txtMiddleName.Margin = new Padding(3, 4, 3, 4);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(188, 35);
            txtMiddleName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtLastName.Location = new Point(496, 173);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(188, 35);
            txtLastName.TabIndex = 13;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtpDateofBirth.Location = new Point(21, 258);
            dtpDateofBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(346, 34);
            dtpDateofBirth.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(424, 256);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(260, 36);
            cmbGender.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(766, 510);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 49);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(948, 510);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 49);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Firebrick;
            btnDeactivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = SystemColors.Control;
            btnDeactivate.Location = new Point(1132, 508);
            btnDeactivate.Margin = new Padding(3, 4, 3, 4);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(168, 50);
            btnDeactivate.TabIndex = 19;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.AllowUserToAddRows = false;
            dgvStudentRecords.AllowUserToResizeColumns = false;
            dgvStudentRecords.AllowUserToResizeRows = false;
            dgvStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentRecords.BackgroundColor = Color.White;
            dgvStudentRecords.ColumnHeadersHeight = 29;
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudentRecords.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvStudentRecords.Location = new Point(14, 626);
            dgvStudentRecords.Margin = new Padding(3, 4, 3, 4);
            dgvStudentRecords.Name = "dgvStudentRecords";
            dgvStudentRecords.RowHeadersVisible = false;
            dgvStudentRecords.RowHeadersWidth = 51;
            dgvStudentRecords.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRecords.Size = new Size(1504, 291);
            dgvStudentRecords.TabIndex = 20;
            dgvStudentRecords.CellClick += dgvStudentRecords_CellClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Student ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Full Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date of Birth";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Account Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Enrollment Status";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Guardian Name";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Guardian Contact";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Green;
            btnActivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivate.ForeColor = SystemColors.Control;
            btnActivate.Location = new Point(1336, 510);
            btnActivate.Margin = new Padding(3, 4, 3, 4);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(149, 50);
            btnActivate.TabIndex = 21;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // gbStudentInfo
            // 
            gbStudentInfo.Controls.Add(txtLRN);
            gbStudentInfo.Controls.Add(lblLRN);
            gbStudentInfo.Controls.Add(cmbStudentType);
            gbStudentInfo.Controls.Add(lblStudentType);
            gbStudentInfo.Controls.Add(txtPostal);
            gbStudentInfo.Controls.Add(lblPostal);
            gbStudentInfo.Controls.Add(txtProvince);
            gbStudentInfo.Controls.Add(lblProvince);
            gbStudentInfo.Controls.Add(txtMunicipality);
            gbStudentInfo.Controls.Add(lblMunicipality);
            gbStudentInfo.Controls.Add(txtBarangay);
            gbStudentInfo.Controls.Add(lblBarangay);
            gbStudentInfo.Controls.Add(lblHouseno);
            gbStudentInfo.Controls.Add(txtHouseNo);
            gbStudentInfo.Controls.Add(lblDateOfBirth);
            gbStudentInfo.Controls.Add(dtpDateofBirth);
            gbStudentInfo.Controls.Add(lblGender);
            gbStudentInfo.Controls.Add(cmbGender);
            gbStudentInfo.Controls.Add(lblStudentId);
            gbStudentInfo.Controls.Add(txtStudentID);
            gbStudentInfo.Controls.Add(lblFname);
            gbStudentInfo.Controls.Add(txtFirstName);
            gbStudentInfo.Controls.Add(lblMname);
            gbStudentInfo.Controls.Add(txtMiddleName);
            gbStudentInfo.Controls.Add(txtLastName);
            gbStudentInfo.Controls.Add(lblLname);
            gbStudentInfo.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbStudentInfo.Location = new Point(24, 74);
            gbStudentInfo.Margin = new Padding(3, 4, 3, 4);
            gbStudentInfo.Name = "gbStudentInfo";
            gbStudentInfo.Padding = new Padding(3, 4, 3, 4);
            gbStudentInfo.Size = new Size(710, 497);
            gbStudentInfo.TabIndex = 22;
            gbStudentInfo.TabStop = false;
            gbStudentInfo.Text = "Student Information";
            // 
            // txtLRN
            // 
            txtLRN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtLRN.Location = new Point(379, 93);
            txtLRN.Margin = new Padding(3, 4, 3, 4);
            txtLRN.Multiline = true;
            txtLRN.Name = "txtLRN";
            txtLRN.Size = new Size(305, 35);
            txtLRN.TabIndex = 30;
            // 
            // lblLRN
            // 
            lblLRN.AutoSize = true;
            lblLRN.BackColor = Color.Transparent;
            lblLRN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLRN.ForeColor = Color.Black;
            lblLRN.Location = new Point(379, 61);
            lblLRN.Name = "lblLRN";
            lblLRN.Size = new Size(60, 28);
            lblLRN.TabIndex = 29;
            lblLRN.Text = "LRN*";
            // 
            // cmbStudentType
            // 
            cmbStudentType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbStudentType.FormattingEnabled = true;
            cmbStudentType.Location = new Point(262, 450);
            cmbStudentType.Margin = new Padding(3, 4, 3, 4);
            cmbStudentType.Name = "cmbStudentType";
            cmbStudentType.Size = new Size(209, 36);
            cmbStudentType.TabIndex = 28;
            // 
            // lblStudentType
            // 
            lblStudentType.AutoSize = true;
            lblStudentType.BackColor = Color.Transparent;
            lblStudentType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentType.ForeColor = Color.Black;
            lblStudentType.Location = new Point(265, 418);
            lblStudentType.Name = "lblStudentType";
            lblStudentType.Size = new Size(137, 28);
            lblStudentType.TabIndex = 27;
            lblStudentType.Text = "Student Type";
            // 
            // txtPostal
            // 
            txtPostal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPostal.Location = new Point(21, 450);
            txtPostal.Margin = new Padding(3, 4, 3, 4);
            txtPostal.Multiline = true;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(150, 35);
            txtPostal.TabIndex = 26;
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = Color.Transparent;
            lblPostal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostal.ForeColor = Color.Black;
            lblPostal.Location = new Point(21, 418);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(161, 28);
            lblPostal.TabIndex = 25;
            lblPostal.Text = "Postal/ZIP Code";
            // 
            // txtProvince
            // 
            txtProvince.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtProvince.Location = new Point(544, 361);
            txtProvince.Margin = new Padding(3, 4, 3, 4);
            txtProvince.Multiline = true;
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(140, 35);
            txtProvince.TabIndex = 24;
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.BackColor = Color.Transparent;
            lblProvince.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProvince.ForeColor = Color.Black;
            lblProvince.Location = new Point(544, 329);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(94, 28);
            lblProvince.TabIndex = 23;
            lblProvince.Text = "Province";
            // 
            // txtMunicipality
            // 
            txtMunicipality.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMunicipality.Location = new Point(340, 361);
            txtMunicipality.Margin = new Padding(3, 4, 3, 4);
            txtMunicipality.Multiline = true;
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.Size = new Size(164, 35);
            txtMunicipality.TabIndex = 22;
            // 
            // lblMunicipality
            // 
            lblMunicipality.AutoSize = true;
            lblMunicipality.BackColor = Color.Transparent;
            lblMunicipality.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMunicipality.ForeColor = Color.Black;
            lblMunicipality.Location = new Point(340, 329);
            lblMunicipality.Name = "lblMunicipality";
            lblMunicipality.Size = new Size(177, 28);
            lblMunicipality.TabIndex = 21;
            lblMunicipality.Text = "City/Municipality";
            // 
            // txtBarangay
            // 
            txtBarangay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtBarangay.Location = new Point(163, 361);
            txtBarangay.Margin = new Padding(3, 4, 3, 4);
            txtBarangay.Multiline = true;
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(138, 35);
            txtBarangay.TabIndex = 20;
            // 
            // lblBarangay
            // 
            lblBarangay.AutoSize = true;
            lblBarangay.BackColor = Color.Transparent;
            lblBarangay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangay.ForeColor = Color.Black;
            lblBarangay.Location = new Point(163, 329);
            lblBarangay.Name = "lblBarangay";
            lblBarangay.Size = new Size(101, 28);
            lblBarangay.TabIndex = 19;
            lblBarangay.Text = "Barangay";
            // 
            // lblHouseno
            // 
            lblHouseno.AutoSize = true;
            lblHouseno.BackColor = Color.Transparent;
            lblHouseno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouseno.ForeColor = Color.Black;
            lblHouseno.Location = new Point(21, 329);
            lblHouseno.Name = "lblHouseno";
            lblHouseno.Size = new Size(110, 28);
            lblHouseno.TabIndex = 18;
            lblHouseno.Text = "House No.";
            // 
            // txtHouseNo
            // 
            txtHouseNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtHouseNo.Location = new Point(21, 361);
            txtHouseNo.Margin = new Padding(3, 4, 3, 4);
            txtHouseNo.Multiline = true;
            txtHouseNo.Name = "txtHouseNo";
            txtHouseNo.Size = new Size(101, 35);
            txtHouseNo.TabIndex = 17;
            // 
            // gbGuardianInfo
            // 
            gbGuardianInfo.Controls.Add(txtGpostal);
            gbGuardianInfo.Controls.Add(lblGpostal);
            gbGuardianInfo.Controls.Add(txtGprovince);
            gbGuardianInfo.Controls.Add(lblGprovince);
            gbGuardianInfo.Controls.Add(txtGmunicipality);
            gbGuardianInfo.Controls.Add(lblGmunicipality);
            gbGuardianInfo.Controls.Add(txtGbarangay);
            gbGuardianInfo.Controls.Add(lblGbarangay);
            gbGuardianInfo.Controls.Add(txtGhouseno);
            gbGuardianInfo.Controls.Add(lblGhouseno);
            gbGuardianInfo.Controls.Add(cmbGgender);
            gbGuardianInfo.Controls.Add(lblGgender);
            gbGuardianInfo.Controls.Add(txtGrelationship);
            gbGuardianInfo.Controls.Add(lblGrelationship);
            gbGuardianInfo.Controls.Add(lblGcontact);
            gbGuardianInfo.Controls.Add(txtGcontact);
            gbGuardianInfo.Controls.Add(txtGlname);
            gbGuardianInfo.Controls.Add(txtGmname);
            gbGuardianInfo.Controls.Add(lblGlname);
            gbGuardianInfo.Controls.Add(lblGmname);
            gbGuardianInfo.Controls.Add(txtGfname);
            gbGuardianInfo.Controls.Add(lblGfname);
            gbGuardianInfo.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbGuardianInfo.Location = new Point(766, 74);
            gbGuardianInfo.Margin = new Padding(3, 4, 3, 4);
            gbGuardianInfo.Name = "gbGuardianInfo";
            gbGuardianInfo.Padding = new Padding(3, 4, 3, 4);
            gbGuardianInfo.Size = new Size(719, 396);
            gbGuardianInfo.TabIndex = 23;
            gbGuardianInfo.TabStop = false;
            gbGuardianInfo.Text = "Guardian Information";
            // 
            // txtGpostal
            // 
            txtGpostal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGpostal.Location = new Point(267, 347);
            txtGpostal.Margin = new Padding(3, 4, 3, 4);
            txtGpostal.Multiline = true;
            txtGpostal.Name = "txtGpostal";
            txtGpostal.Size = new Size(186, 35);
            txtGpostal.TabIndex = 27;
            // 
            // lblGpostal
            // 
            lblGpostal.AutoSize = true;
            lblGpostal.BackColor = Color.Transparent;
            lblGpostal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGpostal.ForeColor = Color.Black;
            lblGpostal.Location = new Point(267, 315);
            lblGpostal.Name = "lblGpostal";
            lblGpostal.Size = new Size(161, 28);
            lblGpostal.TabIndex = 27;
            lblGpostal.Text = "Postal/ZIP Code";
            // 
            // txtGprovince
            // 
            txtGprovince.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGprovince.Location = new Point(21, 347);
            txtGprovince.Margin = new Padding(3, 4, 3, 4);
            txtGprovince.Multiline = true;
            txtGprovince.Name = "txtGprovince";
            txtGprovince.Size = new Size(177, 35);
            txtGprovince.TabIndex = 27;
            // 
            // lblGprovince
            // 
            lblGprovince.AutoSize = true;
            lblGprovince.BackColor = Color.Transparent;
            lblGprovince.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGprovince.ForeColor = Color.Black;
            lblGprovince.Location = new Point(21, 315);
            lblGprovince.Name = "lblGprovince";
            lblGprovince.Size = new Size(94, 28);
            lblGprovince.TabIndex = 27;
            lblGprovince.Text = "Province";
            // 
            // txtGmunicipality
            // 
            txtGmunicipality.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGmunicipality.Location = new Point(509, 260);
            txtGmunicipality.Margin = new Padding(3, 4, 3, 4);
            txtGmunicipality.Multiline = true;
            txtGmunicipality.Name = "txtGmunicipality";
            txtGmunicipality.Size = new Size(177, 35);
            txtGmunicipality.TabIndex = 27;
            // 
            // lblGmunicipality
            // 
            lblGmunicipality.AutoSize = true;
            lblGmunicipality.BackColor = Color.Transparent;
            lblGmunicipality.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmunicipality.ForeColor = Color.Black;
            lblGmunicipality.Location = new Point(509, 226);
            lblGmunicipality.Name = "lblGmunicipality";
            lblGmunicipality.Size = new Size(177, 28);
            lblGmunicipality.TabIndex = 27;
            lblGmunicipality.Text = "City/Municipality";
            // 
            // txtGbarangay
            // 
            txtGbarangay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGbarangay.Location = new Point(267, 260);
            txtGbarangay.Margin = new Padding(3, 4, 3, 4);
            txtGbarangay.Multiline = true;
            txtGbarangay.Name = "txtGbarangay";
            txtGbarangay.Size = new Size(186, 35);
            txtGbarangay.TabIndex = 27;
            // 
            // lblGbarangay
            // 
            lblGbarangay.AutoSize = true;
            lblGbarangay.BackColor = Color.Transparent;
            lblGbarangay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGbarangay.ForeColor = Color.Black;
            lblGbarangay.Location = new Point(267, 226);
            lblGbarangay.Name = "lblGbarangay";
            lblGbarangay.Size = new Size(101, 28);
            lblGbarangay.TabIndex = 27;
            lblGbarangay.Text = "Barangay";
            // 
            // txtGhouseno
            // 
            txtGhouseno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGhouseno.Location = new Point(21, 260);
            txtGhouseno.Margin = new Padding(3, 4, 3, 4);
            txtGhouseno.Multiline = true;
            txtGhouseno.Name = "txtGhouseno";
            txtGhouseno.Size = new Size(177, 35);
            txtGhouseno.TabIndex = 27;
            // 
            // lblGhouseno
            // 
            lblGhouseno.AutoSize = true;
            lblGhouseno.BackColor = Color.Transparent;
            lblGhouseno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGhouseno.ForeColor = Color.Black;
            lblGhouseno.Location = new Point(21, 226);
            lblGhouseno.Name = "lblGhouseno";
            lblGhouseno.Size = new Size(110, 28);
            lblGhouseno.TabIndex = 27;
            lblGhouseno.Text = "House No.";
            // 
            // cmbGgender
            // 
            cmbGgender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbGgender.FormattingEnabled = true;
            cmbGgender.Location = new Point(509, 173);
            cmbGgender.Margin = new Padding(3, 4, 3, 4);
            cmbGgender.Name = "cmbGgender";
            cmbGgender.Size = new Size(188, 36);
            cmbGgender.TabIndex = 27;
            // 
            // lblGgender
            // 
            lblGgender.AutoSize = true;
            lblGgender.BackColor = Color.Transparent;
            lblGgender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGgender.ForeColor = Color.Black;
            lblGgender.Location = new Point(509, 141);
            lblGgender.Name = "lblGgender";
            lblGgender.Size = new Size(80, 28);
            lblGgender.TabIndex = 27;
            lblGgender.Text = "Gender";
            // 
            // txtGrelationship
            // 
            txtGrelationship.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGrelationship.Location = new Point(267, 173);
            txtGrelationship.Margin = new Padding(3, 4, 3, 4);
            txtGrelationship.Multiline = true;
            txtGrelationship.Name = "txtGrelationship";
            txtGrelationship.Size = new Size(188, 35);
            txtGrelationship.TabIndex = 35;
            // 
            // lblGrelationship
            // 
            lblGrelationship.AutoSize = true;
            lblGrelationship.BackColor = Color.Transparent;
            lblGrelationship.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrelationship.ForeColor = Color.Black;
            lblGrelationship.Location = new Point(267, 141);
            lblGrelationship.Name = "lblGrelationship";
            lblGrelationship.Size = new Size(130, 28);
            lblGrelationship.TabIndex = 34;
            lblGrelationship.Text = "Relationship";
            // 
            // lblGcontact
            // 
            lblGcontact.AutoSize = true;
            lblGcontact.BackColor = Color.Transparent;
            lblGcontact.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGcontact.ForeColor = Color.Black;
            lblGcontact.Location = new Point(21, 141);
            lblGcontact.Name = "lblGcontact";
            lblGcontact.Size = new Size(177, 28);
            lblGcontact.TabIndex = 33;
            lblGcontact.Text = "Guardian Contact";
            // 
            // txtGcontact
            // 
            txtGcontact.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGcontact.Location = new Point(21, 174);
            txtGcontact.Margin = new Padding(3, 4, 3, 4);
            txtGcontact.Multiline = true;
            txtGcontact.Name = "txtGcontact";
            txtGcontact.Size = new Size(188, 35);
            txtGcontact.TabIndex = 27;
            // 
            // txtGlname
            // 
            txtGlname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGlname.Location = new Point(509, 93);
            txtGlname.Margin = new Padding(3, 4, 3, 4);
            txtGlname.Multiline = true;
            txtGlname.Name = "txtGlname";
            txtGlname.Size = new Size(188, 35);
            txtGlname.TabIndex = 32;
            // 
            // txtGmname
            // 
            txtGmname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGmname.Location = new Point(267, 93);
            txtGmname.Margin = new Padding(3, 4, 3, 4);
            txtGmname.Multiline = true;
            txtGmname.Name = "txtGmname";
            txtGmname.Size = new Size(188, 35);
            txtGmname.TabIndex = 31;
            // 
            // lblGlname
            // 
            lblGlname.AutoSize = true;
            lblGlname.BackColor = Color.Transparent;
            lblGlname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGlname.ForeColor = Color.Black;
            lblGlname.Location = new Point(509, 61);
            lblGlname.Name = "lblGlname";
            lblGlname.Size = new Size(112, 28);
            lblGlname.TabIndex = 30;
            lblGlname.Text = "Last Name";
            // 
            // lblGmname
            // 
            lblGmname.AutoSize = true;
            lblGmname.BackColor = Color.Transparent;
            lblGmname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmname.ForeColor = Color.Black;
            lblGmname.Location = new Point(267, 61);
            lblGmname.Name = "lblGmname";
            lblGmname.Size = new Size(140, 28);
            lblGmname.TabIndex = 29;
            lblGmname.Text = "Middle Name";
            // 
            // txtGfname
            // 
            txtGfname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtGfname.Location = new Point(21, 93);
            txtGfname.Margin = new Padding(3, 4, 3, 4);
            txtGfname.Multiline = true;
            txtGfname.Name = "txtGfname";
            txtGfname.Size = new Size(188, 35);
            txtGfname.TabIndex = 27;
            // 
            // lblGfname
            // 
            lblGfname.AutoSize = true;
            lblGfname.BackColor = Color.Transparent;
            lblGfname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGfname.ForeColor = Color.Black;
            lblGfname.Location = new Point(21, 61);
            lblGfname.Name = "lblGfname";
            lblGfname.Size = new Size(115, 28);
            lblGfname.TabIndex = 27;
            lblGfname.Text = "First Name";
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1518, 918);
            Controls.Add(gbGuardianInfo);
            Controls.Add(gbStudentInfo);
            Controls.Add(btnActivate);
            Controls.Add(dgvStudentRecords);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            Load += StudentManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            gbStudentInfo.ResumeLayout(false);
            gbStudentInfo.PerformLayout();
            gbGuardianInfo.ResumeLayout(false);
            gbGuardianInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label lblStudentId;
        private Label lblFname;
        private Label lblLname;
        private Label lblMname;
        private Label lblDateOfBirth;
        private Label lblGender;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private DateTimePicker dtpDateofBirth;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDeactivate;
        private DataGridView dgvStudentRecords;
        private Button btnActivate;
        private GroupBox gbStudentInfo;
        private TextBox txtProvince;
        private Label lblProvince;
        private TextBox txtMunicipality;
        private Label lblMunicipality;
        private TextBox txtBarangay;
        private Label lblBarangay;
        private Label lblHouseno;
        private TextBox txtHouseNo;
        private TextBox txtPostal;
        private Label lblPostal;
        private GroupBox gbGuardianInfo;
        private TextBox txtGfname;
        private Label lblGfname;
        private Label lblGcontact;
        private TextBox txtGcontact;
        private TextBox txtGlname;
        private TextBox txtGmname;
        private Label lblGlname;
        private Label lblGmname;
        private TextBox txtGpostal;
        private Label lblGpostal;
        private TextBox txtGprovince;
        private Label lblGprovince;
        private TextBox txtGmunicipality;
        private Label lblGmunicipality;
        private TextBox txtGbarangay;
        private Label lblGbarangay;
        private TextBox txtGhouseno;
        private Label lblGhouseno;
        private ComboBox cmbGgender;
        private Label lblGgender;
        private TextBox txtGrelationship;
        private Label lblGrelationship;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox cmbStudentType;
        private Label lblStudentType;
        private TextBox txtLRN;
        private Label lblLRN;
    }
}