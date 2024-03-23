using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HumanResourceManagement
{
    public partial class frmMain : Form
    {
        HumanResourceManagementContext context = new HumanResourceManagementContext();

        public frmMain()
        {
            InitializeComponent();
        }

        #region Function Logic
        private void Logout()
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }
        #endregion

        #region Events
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notify", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
        }

        private void LoadEmployee()
        {
            var list = context.Employees.Include(x => x.Department).Include(x => x.Position).Select(x => new
            {
                EmployeeID = x.EmployeeId,
                Name = x.FullName,
                DOB = x.Dob,
                Gender = x.Gender,
                Department = x.Department.DepartmentName,
                Position = x.Position.PositionName,
            }).ToList();
            dgvEmployeeData.DataSource = list;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var user = context.Users.FirstOrDefault(u => u.Username == UserSession.Username && u.Password == UserSession.Password);
            if (user != null)
            {
                if (user.RoleId != 1)
                {
                    tsmiAccount.Enabled = tsmiEmployee.Enabled = tsmiDepartment.Enabled = msStatistic.Enabled = false;
                }
            }
            LoadEmployee();

        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee employee = new frmAddNewEmployee();
            employee.ShowDialog();
        }

        private void tsmiAccount_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.ShowDialog();
        }

        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment department = new frmDepartment();
            department.ShowDialog();
        }


        private void dgvEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dgvEmployeeData.Rows.Count)
            {
                var employee1 = context.Employees.FirstOrDefault(x => x.EmployeeId == int.Parse(dgvEmployeeData.Rows[e.RowIndex].Cells[0].Value.ToString()));
                var u = context.Users.FirstOrDefault(x => x.Username == UserSession.Username);
                if (employee1 != null && u != null)
                {
                    if (u.RoleId != 1 && employee1.EmployeeId != u.EmployeeId)
                    {
                        MessageBox.Show("You may not view other people's information");
                        return;
                    }

                    if (employee1.EmployeeId == u.EmployeeId || u.RoleId == 1)
                    {
                        EmployeeSession.EmployeeID = int.Parse(dgvEmployeeData.Rows[e.RowIndex].Cells[0].Value.ToString());
                        frmShowInfoEmployee employee = new frmShowInfoEmployee();
                        employee.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void FilterEmployeeData(string id, string name, string gender)
        {
            var query = context.Employees
                            .Include(x => x.Department)
                            .Include(x => x.Position)
                            .AsQueryable();

            if (!string.IsNullOrWhiteSpace(id))
            {
                int employeeId;
                if (int.TryParse(id, out employeeId))
                {
                    query = query.Where(x => x.EmployeeId == employeeId);
                }
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(x => x.FullName.Contains(name));
            }

            if (!string.IsNullOrWhiteSpace(gender))
            {
                query = query.Where(x => x.Gender == gender);
            }

            var filteredList = query.Select(x => new
            {
                EmployeeID = x.EmployeeId,
                Name = x.FullName,
                DOB = x.Dob,
                Gender = x.Gender,
                Department = x.Department.DepartmentName,
                Position = x.Position.PositionName,
            }).ToList();

            dgvEmployeeData.DataSource = filteredList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string gender = "";

            if (rdMale.Checked)
            {
                gender = "Male";
            }
            else if (rdFemale.Checked)
            {
                gender = "Female";
            }
            else if (rdOther.Checked)
            {
                gender = "Other";
            }

            FilterEmployeeData(id, name, gender);
        }
    }
}
