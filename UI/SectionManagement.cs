using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class SectionManagement : Form
    {
        private readonly SectionController _sectionController = new SectionController();
        private string _selectedCode = "";
        public SectionManagement()
        {
            InitializeComponent();
            dgvInfo.DefaultCellStyle.ForeColor = Color.Black;
            dgvInfo.DefaultCellStyle.BackColor = Color.White;

            dgvInfo.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvInfo.RowsDefaultCellStyle.BackColor = Color.White;

            dgvInfo.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            cmbGradeLevel.Items.AddRange(new string[] { "Grade 7", "Grade 8", "Grade 9", "Grade 10" });
        }

        private void SectionManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private bool IsValidSchoolYear(string input, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "School Year is required. Please enter in format: YYYY-YYYY (e.g. 2026-2027).";
                return false;
            }

            if (!Regex.IsMatch(input.Trim(), @"^\d{4}-\d{4}$"))
            {
                errorMessage = "Invalid School Year format. Please use YYYY-YYYY (e.g. 2026-2027).";
                return false;
            }

            string[] parts = input.Trim().Split('-');
            int startYear = int.Parse(parts[0]);
            int endYear = int.Parse(parts[1]);

            if (endYear != startYear + 1)
            {
                errorMessage = "The end year must be exactly one year after the start year (e.g. 2026-2027).";
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidSchoolYear(txtSchoolYear.Text, out string yearError))
            {
                MessageBox.Show(yearError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var section = new Section
            {
                SectionCode = txtSectionCode.Text,
                SectionName = txtSectionName.Text,
                GradeLevel = cmbGradeLevel.SelectedItem?.ToString(),
                SchoolYear = txtSchoolYear.Text.Trim(),
            };

            string result = _sectionController.CreateSection(section);

            if (result == "Success")
            {
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedCode)) return;

            if (!IsValidSchoolYear(txtSchoolYear.Text, out string yearError))
            {
                MessageBox.Show(yearError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var section = new Section
            {
                SectionCode = _selectedCode,
                SectionName = txtSectionName.Text,
                GradeLevel = cmbGradeLevel.SelectedItem?.ToString(),
                SchoolYear = txtSchoolYear.Text.Trim(),
            };

            string result = _sectionController.UpdateSection(section);
            if (result == "Success")
            {
                MessageBox.Show("Section updated successfully!");
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Failed to update: " + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedCode)) return;
            if (_sectionController.DeactivateSection(_selectedCode) == "Success")
            {
                ClearForm(); RefreshGrid();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            
            if (dgvInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a section from the grid to activate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSectionCode = dgvInfo.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to activate Section: {selectedSectionCode}?", "Confirm Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string result = _sectionController.ActivateSection(selectedSectionCode);

                if (result == "Success")
                {
                    MessageBox.Show("Section activated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show(result, "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvInfo.Rows[e.RowIndex];
                _selectedCode = row.Cells[0].Value?.ToString();
                txtSectionCode.Text = _selectedCode;
                txtSectionName.Text = row.Cells[1].Value?.ToString();
                cmbGradeLevel.SelectedItem = row.Cells[2].Value?.ToString();
                txtSchoolYear.Text = row.Cells[3].Value?.ToString();
                txtSectionCode.Enabled = false;
            }
        }

        private void RefreshGrid()
        {
            try
            {
                dgvInfo.Rows.Clear();
                foreach (var s in _sectionController.GetAllSections())
                {
                    dgvInfo.Rows.Add(s.SectionCode, s.SectionName, s.GradeLevel, s.SchoolYear, s.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sections: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _selectedCode = "";
            txtSectionCode.Clear();
            txtSectionName.Clear();
            cmbGradeLevel.SelectedIndex = -1;
            txtSchoolYear.Clear();
            txtSectionCode.Enabled = true;
        }
    }
}
