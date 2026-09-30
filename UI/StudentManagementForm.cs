using BusinessLogic.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            this.Load += StudentManagementForm_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            dgvStudentRecords.CellClick += dgvStudentRecords_CellClick_1;
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
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
                Address = txtAddress.Text
            };

            string result = _studentController.CreateStudent(newStudent);

            if (result == "Success")
            {
                MessageBox.Show("Student created!"); ClearForm(); RefreshGrid();
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
                Address = txtAddress.Text
            };

            if (_studentController.UpdateStudent(updatedStudent) == "Success")
            {
                ClearForm(); RefreshGrid();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedStudentId)) return;

            if (_studentController.DeactivateStudent(_selectedStudentId) == "Success")
            {
                ClearForm(); RefreshGrid();
            }
        }

        private void dgvStudentRecords_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudentRecords.Rows[e.RowIndex];
                _selectedStudentId = row.Cells[0].Value?.ToString();
                txtStudentID.Text = _selectedStudentId;
                txtFirstName.Text = row.Cells[1].Value?.ToString();
                txtMiddleName.Text = row.Cells[2].Value?.ToString();
                txtLastName.Text = row.Cells[3].Value?.ToString();
                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime dob)) dtpDateofBirth.Value = dob;
                cmbGender.SelectedItem = row.Cells[5].Value?.ToString();
                txtAddress.Text = row.Cells[6].Value?.ToString();
                txtStudentID.Enabled = false;
            }
        }

        private void RefreshGrid()
        {
            dgvStudentRecords.Rows.Clear();
            foreach (var s in _studentController.GetAllStudents())
                dgvStudentRecords.Rows.Add(
                    s.StudentId,
                    s.FirstName,
                    s.MiddleName,
                    s.LastName,
                    s.DateOfBirth.ToString("yyyy-MM-dd"),
                    s.Gender,
                    s.Address,
                    s.Status);
        }

        private void ClearForm()
        {
            _selectedStudentId = "";
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtStudentID.Enabled = true;
        }

        
    }
}
