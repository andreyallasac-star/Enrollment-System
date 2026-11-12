using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;

namespace UI
{
    public partial class StudentInformationReport : Form
    {
        private readonly ReportController _reportController = new ReportController();
        private readonly SectionController _sectionController = new SectionController();

        public StudentInformationReport()
        {
            InitializeComponent();

            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            this.Load += StudentInformationReport_Load;
            cmbGradeLevel.SelectedIndexChanged += FilterSections;
            btnGenerateReport.Click += btnGenerateReport_Click;
        }

        private void StudentInformationReport_Load(object sender, EventArgs e)
        {
            cmbGradeLevel.Items.Add("All");
            cmbGradeLevel.Items.AddRange(new string[] { "Grade 7", "Grade 8", "Grade 9", "Grade 10" });
            cmbGradeLevel.SelectedIndex = 0;

            cmbSection.Items.Add("All");
            cmbSection.SelectedIndex = 0;
        }

        private void FilterSections(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            cmbSection.Items.Add("All");

            string selectedGrade = cmbGradeLevel.SelectedItem?.ToString();
            if (selectedGrade == "All" || string.IsNullOrWhiteSpace(selectedGrade))
            {
                cmbSection.SelectedIndex = 0;
                return;
            }

            var sections = _sectionController.GetAllSections()
                .Where(s => s.GradeLevel == selectedGrade && s.Status == "Active")
                .ToList();

            foreach (var sec in sections)
            {
                cmbSection.Items.Add(sec.SectionCode);
            }

            cmbSection.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string gradeLevel = cmbGradeLevel.SelectedItem?.ToString();
            string sectionCode = cmbSection.SelectedItem?.ToString();
            string schoolYear = null;

            DataTable reportData = _reportController.GenerateStudentReport(gradeLevel, sectionCode, schoolYear);

            dataGridView1.Rows.Clear();

            if (reportData != null && reportData.Rows.Count > 0)
            {
                foreach (DataRow row in reportData.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["StudentId"].ToString(),
                        row["FullName"].ToString(),
                        row["GradeLevel"].ToString(),
                        row["Section"].ToString()
                    );
                }
            }
            else
            {
                MessageBox.Show("No enrolled students found for the selected filters.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}