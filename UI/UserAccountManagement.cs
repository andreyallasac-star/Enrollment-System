using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class UserAccountManagement : Form
    {

        private readonly UserController _userController = new UserController();
        private int _selectedUserId = 0;
        public UserAccountManagement()
        {
            InitializeComponent();

            cmbRoles.Items.Add("Admin");
            cmbRoles.Items.Add("Staff");
            cmbRoles.SelectedIndex = 0;

            this.Load += UserAccountManagement_Load;
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
        }

        private void UserAccountManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Username = txtUsername.Text,
                PasswordHash = txtPassword.Text,
                Role = cmbRoles.SelectedItem.ToString()
            };

            string result = _userController.CreateUser(newUser);

            if (result == "Success")
            {
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Please select a user from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User updatedUser = new User
            {
                UserId = _selectedUserId,
                PasswordHash = txtPassword.Text,
                Role = cmbRoles.SelectedItem.ToString()
            };

            string result = _userController.UpdateUser(updatedUser);

            if (result == "Success")
            {
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show(result, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Please select a user from the grid to deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this user?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string result = _userController.DeactivateUser(_selectedUserId);
                if (result == "Success")
                {
                    ClearForm();
                    RefreshGrid();
                }
            }
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudentInfo.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells[0].Value);
                txtUsername.Text = row.Cells[1].Value.ToString();
                cmbRoles.SelectedItem = row.Cells[2].Value.ToString();
                txtPassword.Text = "";

                txtUsername.Enabled = false;
            }
        }

        private void RefreshGrid()
        {
            dgvStudentInfo.Rows.Clear();
            var users = _userController.GetAllUsers();

            foreach (var u in users)
            {
                dgvStudentInfo.Rows.Add(u.UserId, u.Username, u.Role, u.Status);
            }
        }

        private void ClearForm()
        {
            _selectedUserId = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRoles.SelectedIndex = 0;
            txtUsername.Enabled = true;
        }
    }
}
