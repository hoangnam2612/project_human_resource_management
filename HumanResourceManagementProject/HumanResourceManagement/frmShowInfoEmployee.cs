using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class frmShowInfoEmployee : Form
    {
        public frmShowInfoEmployee()
        {
            InitializeComponent();
        }


        public void LoadInfoEmployee()
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var e = context.Employees.Include(x => x.Department).Include(x => x.Position).Include(x => x.Skill)
                    .FirstOrDefault(x => x.EmployeeId == EmployeeSession.EmployeeID);
                var user = context.Users.FirstOrDefault(x => x.Username == UserSession.Username);
                if (user != null)
                {
                    int role = user.RoleId.Value;
                    if (role != 1)
                    {
                        txtSkill.ReadOnly = true;
                        txtDepartment.ReadOnly = true;
                        txtPosition.ReadOnly = true;
                        txtSalary.ReadOnly = true;
                    }
                }

                txtName.Text = e.FullName;
                txtGender.Text = e.Gender;
                dtpDOB.Text = e.Dob.ToString();
                txtPhone.Text = e.Phone;
                txtAdress.Text = e.Address;
                txtEmail.Text = e.Email;
                txtIDCart.Text = e.Idcart;
                txtSkill.Text = e.Skill.SkillName;
                txtEmployeeID.Text = e.EmployeeId.ToString();
                txtDepartment.Text = e.Department.DepartmentName;
                txtPosition.Text = e.Position.PositionName;
                txtSalary.Text = e.Salary.ToString();
            }
        }


        private void frmShowInfoEmployee_Load(object sender, EventArgs e)
        {
            LoadInfoEmployee();
            using(HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var userRole = context.Users.FirstOrDefault(x => x.Username == UserSession.Username).RoleId;
                if(userRole != 1)
                {
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
            this.Hide();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var employee = context.Employees.FirstOrDefault(x => x.EmployeeId == EmployeeSession.EmployeeID);

                int skillId = context.Skills.FirstOrDefault(x => x.SkillName == txtSkill.Text).SkillId;
                int departmentId = context.Departments.FirstOrDefault(x => x.DepartmentName == txtDepartment.Text).DepartmentId;
                int positionId = context.Positions.FirstOrDefault(x => x.PositionName == txtPosition.Text).PositionId;

                employee.Phone = txtPhone.Text;
                employee.Address = txtAdress.Text;
                employee.Dob = dtpDOB.Value;
                employee.Email = txtEmail.Text;
                employee.SkillId = skillId;
                employee.DepartmentId = departmentId;
                employee.PositionId = positionId;
                employee.Salary = int.Parse(txtSalary.Text);

                context.Employees.Update(employee);
                context.SaveChanges();

                MessageBox.Show("Edit successful", "Notify");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (HumanResourceManagementContext context = new HumanResourceManagementContext())
                {
                    var employee = context.Employees.FirstOrDefault(x => x.EmployeeId == EmployeeSession.EmployeeID);

                    if (employee != null)
                    {
                        context.Employees.Remove(employee);
                        context.SaveChanges();

                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmMain main = new frmMain();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
