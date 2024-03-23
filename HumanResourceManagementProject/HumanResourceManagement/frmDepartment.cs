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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HumanResourceManagement
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var list = context.Departments.ToList();
                string department = txtName.Text;

                foreach (var item in list)
                {
                    if (item.DepartmentName == department)
                    {
                        MessageBox.Show("Department is exist", "Notify");
                        return;
                    }
                }

                Department d = new Department();
                d.DepartmentName = department;
                context.Departments.Add(d);
                context.SaveChanges();
                MessageBox.Show("Add successful", "Notify");
                LoadDepartment();
            }
        }

        private void LoadDepartment()
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var list = context.Departments.Select(x => x.DepartmentName).ToList();
                lstDepartment.DataSource = list;
            }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void lstDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstDepartment.SelectedIndex;
            txtName.Text = lstDepartment.Items[index].ToString();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {

            string newDepartmentName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(newDepartmentName))
            {
                MessageBox.Show("Department name cannot be empty.", "Notify");
                return;
            }

            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                string selectedDepartmentName = lstDepartment.SelectedItem.ToString();
                var department = context.Departments.FirstOrDefault(d => d.DepartmentName == selectedDepartmentName);
                if (department != null)
                {
                    if (department.DepartmentName != newDepartmentName)
                    {
                        if (context.Departments.Any(d => d.DepartmentName == newDepartmentName))
                        {
                            MessageBox.Show("Department name already exists.", "Notify");
                            return;
                        }

                        department.DepartmentName = newDepartmentName;
                        context.SaveChanges();
                        MessageBox.Show("Department updated successfully.", "Notify");
                        LoadDepartment(); // Reload danh sách phòng ban sau khi chỉnh sửa
                    }
                    else
                    {
                        MessageBox.Show("No changes detected.", "Notify");
                    }
                }
                else
                {
                    MessageBox.Show("Selected department not found.", "Notify");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var department = context.Departments.Include(d => d.Employees).FirstOrDefault(x => x.DepartmentName == txtName.Text);
                if (department != null)
                {
                    if (MessageBox.Show("Are you sure want to delete this department", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var employee in department.Employees)
                        {
                            var user = context.Users.FirstOrDefault(u => u.EmployeeId == employee.EmployeeId);
                            if (user != null)
                            {
                                context.Users.Remove(user);
                            }
                            context.Employees.Remove(employee);
                        }

                        context.Departments.Remove(department);
                        context.SaveChanges();
                        MessageBox.Show("Delete Successful", "Notify");
                        LoadDepartment();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find department", "Notify");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
