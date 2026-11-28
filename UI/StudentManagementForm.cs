using BusinessLogic.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class StudentManagementForm : Form
    {
        private readonly StudentController _studentController = new StudentController();
        private string _selectedStudentId = "";

        public StudentManagementForm()
        {
            InitializeComponent();
            dgvStudentRecords.DefaultCellStyle.ForeColor = Color.Black;
            dgvStudentRecords.DefaultCellStyle.BackColor = Color.White;

            dgvStudentRecords.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvStudentRecords.RowsDefaultCellStyle.BackColor = Color.White;

            dgvStudentRecords.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvStudentRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            txtStudentID.PlaceholderText = "Auto-generated or previous campus ID";
            txtLRN.PlaceholderText = "12-digit LRN";

            dgvStudentRecords.ReadOnly = true;
            dgvStudentRecords.AllowUserToAddRows = false;

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGgender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentType.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpDateofBirth.Format = DateTimePickerFormat.Short;
            dtpDateofBirth.MinDate = new DateTime(1990, 1, 1);
            dtpDateofBirth.MaxDate = DateTime.Today;
            dtpDateofBirth.Value = DateTime.Today.AddYears(-13);

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = 0;

            cmbGgender.Items.Add("Male");
            cmbGgender.Items.Add("Female");
            cmbGgender.SelectedIndex = 0;

            cmbStudentType.Items.Add("New");
            cmbStudentType.Items.Add("Old");
            cmbStudentType.Items.Add("Transferee");
            cmbStudentType.SelectedIndexChanged += cmbStudentType_SelectedIndexChanged;
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearForm();
        }

        private void cmbStudentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_selectedStudentId)) return;

            string selectedType = cmbStudentType.SelectedItem?.ToString();
            if (selectedType == "Transferee")
            {
                txtStudentID.Clear();
                txtStudentID.Enabled = true;
                txtStudentID.Focus();
            }
            else if (!string.IsNullOrWhiteSpace(selectedType) && string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                try
                {
                    txtStudentID.Text = _studentController.GetNextStudentId();
                    txtStudentID.Enabled = true;
                }
                catch
                {

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_selectedStudentId))
            {
                MessageBox.Show($"Student '{_selectedStudentId}' is already selected. Click Update to save changes.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentId = txtStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please enter a Student ID (or previous campus ID for transferees).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to add student {txtFirstName.Text.Trim()} {txtLastName.Text.Trim()} ({studentId})?",
                "Confirm Add Student",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var newStudent = new Student
            {
                StudentId = studentId,
                LRN = txtLRN.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateofBirth.Value,
                Gender = cmbGender.SelectedItem?.ToString(),
                StudentType = cmbStudentType.SelectedItem?.ToString(),

                HouseNo = txtHouseNo.Text.Trim(),
                Barangay = txtBarangay.Text.Trim(),
                Municipality = txtMunicipality.Text.Trim(),
                Province = txtProvince.Text.Trim(),
                PostalCode = txtPostal.Text.Trim(),

                GuardianFirstName = txtGfname.Text.Trim(),
                GuardianMiddleName = txtGmname.Text.Trim(),
                GuardianLastName = txtGlname.Text.Trim(),
                GuardianContact = txtGcontact.Text.Trim(),
                GuardianRelationship = txtGrelationship.Text.Trim(),
                GuardianGender = cmbGgender.SelectedItem?.ToString(),

                GuardianHouseNo = txtGhouseno.Text.Trim(),
                GuardianBarangay = txtGbarangay.Text.Trim(),
                GuardianMunicipality = txtGmunicipality.Text.Trim(),
                GuardianProvince = txtGprovince.Text.Trim(),
                GuardianPostalCode = txtGpostal.Text.Trim()
            };

            string result = _studentController.CreateStudent(newStudent);

            if (result == "Success")
            {
                MessageBox.Show("Student created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedStudentId))
            {
                MessageBox.Show("Please select a student from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to update Student ID: {_selectedStudentId}?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var updatedStudent = new Student
            {
                StudentId = _selectedStudentId,
                LRN = txtLRN.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDateofBirth.Value,
                Gender = cmbGender.SelectedItem?.ToString(),
                StudentType = cmbStudentType.SelectedItem?.ToString(),

                HouseNo = txtHouseNo.Text.Trim(),
                Barangay = txtBarangay.Text.Trim(),
                Municipality = txtMunicipality.Text.Trim(),
                Province = txtProvince.Text.Trim(),
                PostalCode = txtPostal.Text.Trim(),

                GuardianFirstName = txtGfname.Text.Trim(),
                GuardianMiddleName = txtGmname.Text.Trim(),
                GuardianLastName = txtGlname.Text.Trim(),
                GuardianContact = txtGcontact.Text.Trim(),
                GuardianRelationship = txtGrelationship.Text.Trim(),
                GuardianGender = cmbGgender.SelectedItem?.ToString(),

                GuardianHouseNo = txtGhouseno.Text.Trim(),
                GuardianBarangay = txtGbarangay.Text.Trim(),
                GuardianMunicipality = txtGmunicipality.Text.Trim(),
                GuardianProvince = txtGprovince.Text.Trim(),
                GuardianPostalCode = txtGpostal.Text.Trim()
            };

            string result = _studentController.UpdateStudent(updatedStudent);

            if (result == "Success")
            {
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedStudentId))
            {
                MessageBox.Show("Please select a student from the grid to deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to deactivate Student ID: {_selectedStudentId}?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            string result = _studentController.DeactivateStudent(_selectedStudentId);
            if (result == "Success")
            {
                MessageBox.Show("Student deactivated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result, "Deactivation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the grid to activate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStudentId = dgvStudentRecords.SelectedRows[0].Cells[0].Value?.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to activate Student ID: {selectedStudentId}?", "Confirm Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string result = _studentController.ActivateStudent(selectedStudentId);

                if (result == "Success")
                {
                    MessageBox.Show("Student activated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show(result, "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStudentRecords_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStudentRecords.Rows[e.RowIndex];
                    if (row.IsNewRow || row.Cells[0].Value == null) return;

                    _selectedStudentId = row.Cells[0].Value?.ToString();

                    Student s = _studentController.GetStudentById(_selectedStudentId);

                    if (s != null)
                    {
                        txtStudentID.Text = s.StudentId;
                        txtLRN.Text = s.LRN;
                        txtFirstName.Text = s.FirstName;
                        txtMiddleName.Text = s.MiddleName;
                        txtLastName.Text = s.LastName;
                        dtpDateofBirth.Value = (s.DateOfBirth >= dtpDateofBirth.MinDate && s.DateOfBirth <= dtpDateofBirth.MaxDate) ? s.DateOfBirth : DateTime.Today.AddYears(-13);
                        cmbGender.SelectedItem = s.Gender;
                        cmbStudentType.SelectedItem = s.StudentType;

                        txtHouseNo.Text = s.HouseNo;
                        txtBarangay.Text = s.Barangay;
                        txtMunicipality.Text = s.Municipality;
                        txtProvince.Text = s.Province;
                        txtPostal.Text = s.PostalCode;

                        txtGfname.Text = s.GuardianFirstName;
                        txtGmname.Text = s.GuardianMiddleName;
                        txtGlname.Text = s.GuardianLastName;
                        txtGcontact.Text = s.GuardianContact;
                        txtGrelationship.Text = s.GuardianRelationship;
                        cmbGgender.SelectedItem = s.GuardianGender;

                        txtGhouseno.Text = s.GuardianHouseNo;
                        txtGbarangay.Text = s.GuardianBarangay;
                        txtGmunicipality.Text = s.GuardianMunicipality;
                        txtGprovince.Text = s.GuardianProvince;
                        txtGpostal.Text = s.GuardianPostalCode;
                    }

                    txtStudentID.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshGrid()
        {
            try
            {
                dgvStudentRecords.Rows.Clear();
                foreach (var s in _studentController.GetAllStudents())
                {
                    string fullName = $"{s.FirstName} {s.MiddleName} {s.LastName}".Replace("  ", " ").Trim();
                    string guardianName = $"{s.GuardianFirstName} {s.GuardianLastName}".Trim();

                    dgvStudentRecords.Rows.Add(
                        s.StudentId,
                        fullName,
                        s.DateOfBirth.ToString("yyyy-MM-dd"),
                        s.Gender,
                        s.Status,
                        s.EnrollmentStatus,
                        guardianName,
                        s.GuardianContact
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            try
            {
                _selectedStudentId = "";
                cmbStudentType.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbGgender.SelectedIndex = -1;

                txtStudentID.Text = _studentController.GetNextStudentId();
                txtStudentID.Enabled = true;
                txtLRN.Clear();
                dtpDateofBirth.Value = DateTime.Today.AddYears(-13);

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();

                txtHouseNo.Clear();
                txtBarangay.Clear();
                txtMunicipality.Clear();
                txtProvince.Clear();
                txtPostal.Clear();

                txtGfname.Clear();
                txtGmname.Clear();
                txtGlname.Clear();
                txtGcontact.Clear();
                txtGrelationship.Clear();

                txtGhouseno.Clear();
                txtGbarangay.Clear();
                txtGmunicipality.Clear();
                txtGprovince.Clear();
                txtGpostal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Student ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Enabled = true;
            }
        }
    }
}