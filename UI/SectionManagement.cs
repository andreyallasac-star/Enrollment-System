using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

            this.Load += SectionManagement_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            dgvInfo.CellClick += dgvInfo_CellClick;
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
                GradeLevel = txtGradeLevel.Text,
                SchoolYear = txtSchoolYear.Text,
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
                GradeLevel = txtGradeLevel.Text,
                SchoolYear = txtSchoolYear.Text,
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

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvInfo.Rows[e.RowIndex];
                _selectedCode = row.Cells[0].Value?.ToString();
                txtSectionCode.Text = _selectedCode;
                txtSectionName.Text = row.Cells[1].Value?.ToString();
                txtGradeLevel.Text = row.Cells[2].Value?.ToString();
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
                    dgvInfo.Rows.Add(s.SectionCode, s.SectionName, s.GradeLevel, s.SchoolYear);
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
            txtGradeLevel.Clear(); 
            txtSchoolYear.Clear(); 
            txtSectionCode.Enabled = true;
        }
    }
}
