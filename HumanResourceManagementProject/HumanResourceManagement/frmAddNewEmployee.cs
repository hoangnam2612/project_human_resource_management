using HumanResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class frmAddNewEmployee : Form
    {
        public frmAddNewEmployee()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var department = context.Departments.ToList();
                cbDepartment.DataSource = department;
                cbDepartment.ValueMember = "DepartmentId";
                cbDepartment.DisplayMember = "DepartmentName";
                var position = context.Positions.ToList();
                cbPosition.DataSource = position;
                cbPosition.ValueMember = "PositionId";
                cbPosition.DisplayMember = "PositionName";
                var skill = context.Skills.ToList();
                cbSkill.DataSource = skill;
                cbSkill.ValueMember = "SkillId";
                cbSkill.DisplayMember = "SkillName";
            }
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        static bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra sự phù hợp với biểu thức chính quy
            if (!Regex.IsMatch(email, pattern))
            {
                return false; // Trả về false nếu không khớp với biểu thức chính quy
            }

            // Nếu qua được tất cả các kiểm tra trên, trả về true
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var employee = context.Employees.ToList();
                string name = txtName.Text;
                string dob = dtpDOB.Text;
                string email = txtEmail.Text;
                if(!IsValidEmail(email))
                {
                    MessageBox.Show("Email is not exist", "Notify");
                    return;
                }
                string phone = txtPhone.Text;
                if(phone.Length != 10)
                {
                    MessageBox.Show("Phone number is invalid", "Notify");
                    return;
                }
                string gender = cbGender.Text;
                string address = txtAdress.Text;
                string idcart = txtIDCart.Text;
                if (idcart.Length != 12)
                {
                    MessageBox.Show("Cart ID is invalid", "Notify");
                    return;
                }
                int skill = (cbSkill.SelectedItem as Skill).SkillId;
                int position = (cbPosition.SelectedItem as Position).PositionId;
                int department = (cbDepartment.SelectedItem as Department).DepartmentId;
                int salary = int.Parse(txtSalary.Text);

                foreach (var item in employee)
                {
                    if (item.FullName == name && item.Dob.ToString() == dob && item.Email == email && item.Phone == phone)
                    {
                        MessageBox.Show("This employee is exist", "Notify");
                        return;
                    }
                }

                Employee em = new Employee();
                em.FullName = name;
                DateTime emDob;
                if (DateTime.TryParseExact(dob, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out emDob))
                {
                    em.Dob = emDob;
                }
                else
                {
                    MessageBox.Show("Invalid DOB", "Notify");
                    return;
                }
                em.Email = email;
                em.Phone = phone;
                em.Gender = gender;
                em.Address = address;
                em.Idcart = idcart;
                em.SkillId = skill;
                em.PositionId = position;
                em.DepartmentId = department;
                em.Salary = salary;

                context.Employees.Add(em);
                context.SaveChanges();
                MessageBox.Show("Add Successful", "Notify");
            }
        }

        private void frmAddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
