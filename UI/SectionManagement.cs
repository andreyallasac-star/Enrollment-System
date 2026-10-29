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

            cmbSchoolYear.Items.AddRange(new string[] { "2026-2027", "2027-2028" });
        }

        private void SectionManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var section = new Section
            {
                SectionCode = txtSectionCode.Text,
                SectionName = txtSectionName.Text,
                GradeLevel = cmbGradeLevel.SelectedItem?.ToString(),
                SchoolYear = cmbSchoolYear.SelectedItem?.ToString(),
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

            var section = new Section
            {
                SectionCode = _selectedCode,
                SectionName = txtSectionName.Text,
                GradeLevel = cmbGradeLevel.SelectedItem?.ToString(),
                SchoolYear = cmbSchoolYear.SelectedItem?.ToString(),
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

            if (_sectionController.UpdateSection(section) == "Success")
            {
                ClearForm();
                RefreshGrid();
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
                cmbSchoolYear.SelectedItem = row.Cells[3].Value?.ToString();
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
            cmbSchoolYear.SelectedIndex = -1;
            txtSectionCode.Enabled = true;
        }
    }
}
