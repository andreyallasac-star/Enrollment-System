using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

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

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = 0;

            cmbGgender.Items.Add("Male");
            cmbGgender.Items.Add("Female");
            cmbGgender.SelectedIndex = 0;
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newStudent = new Student
            {
                StudentId = txtStudentID.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateofBirth.Value,
                Gender = cmbGender.SelectedItem?.ToString(),

                HouseNo = txtHouseNo.Text,
                Barangay = txtBarangay.Text,
                Municipality = txtMunicipality.Text,
                Province = txtProvince.Text,
                PostalCode = txtPostal.Text,

                GuardianFirstName = txtGfname.Text,
                GuardianMiddleName = txtGmname.Text,
                GuardianLastName = txtGlname.Text,
                GuardianContact = txtGcontact.Text,
                GuardianRelationship = txtGrelationship.Text,
                GuardianGender = cmbGgender.SelectedItem?.ToString(),

                GuardianHouseNo = txtGhouseno.Text,
                GuardianBarangay = txtGbarangay.Text,
                GuardianMunicipality = txtGmunicipality.Text,
                GuardianProvince = txtGprovince.Text,
                GuardianPostalCode = txtGpostal.Text
            };

            string result = _studentController.CreateStudent(newStudent);

            if (result == "Success")
            {
                MessageBox.Show("Student created!");
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
            if (string.IsNullOrWhiteSpace(_selectedStudentId)) return;
            var updatedStudent = new Student
            {
                StudentId = _selectedStudentId,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateofBirth.Value,
                Gender = cmbGender.SelectedItem?.ToString(),

                HouseNo = txtHouseNo.Text,
                Barangay = txtBarangay.Text,
                Municipality = txtMunicipality.Text,
                Province = txtProvince.Text,
                PostalCode = txtPostal.Text,

                GuardianFirstName = txtGfname.Text,
                GuardianMiddleName = txtGmname.Text,
                GuardianLastName = txtGlname.Text,
                GuardianContact = txtGcontact.Text,
                GuardianRelationship = txtGrelationship.Text,
                GuardianGender = cmbGgender.SelectedItem?.ToString(),

                GuardianHouseNo = txtGhouseno.Text,
                GuardianBarangay = txtGbarangay.Text,
                GuardianMunicipality = txtGmunicipality.Text,
                GuardianProvince = txtGprovince.Text,
                GuardianPostalCode = txtGpostal.Text
            };

            if (_studentController.UpdateStudent(updatedStudent) == "Success")
            {
                ClearForm();
                RefreshGrid();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedStudentId)) return;

            if (_studentController.DeactivateStudent(_selectedStudentId) == "Success")
            {
                ClearForm();
                RefreshGrid();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvStudentRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the grid to activate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStudentId = dgvStudentRecords.SelectedRows[0].Cells[0].Value.ToString();

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
                DataGridViewRow row = dgvStudentRecords.Rows[e.RowIndex];
                _selectedStudentId = row.Cells[0].Value?.ToString();

                Student s = _studentController.GetStudentById(_selectedStudentId);

                if (s != null)
                {
                    txtStudentID.Text = s.StudentId;
                    txtFirstName.Text = s.FirstName;
                    txtMiddleName.Text = s.MiddleName;
                    txtLastName.Text = s.LastName;
                    dtpDateofBirth.Value = s.DateOfBirth;
                    cmbGender.SelectedItem = s.Gender;

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
        }

        private void RefreshGrid()
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

        private void ClearForm()
        {
            _selectedStudentId = "";
            txtStudentID.Text = _studentController.GetNextStudentId();

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

            txtStudentID.Enabled = false;
        }
    }
}