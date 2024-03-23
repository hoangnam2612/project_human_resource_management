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

namespace HumanResourceManagement
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void LoadListUser()
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var list = context.Users.Include(x => x.Role).Select(x => new
                {
                    Username = x.Username,
                    Password = x.Password,
                    Type = x.Role.RoleName
                }).ToList();
                dgvData.DataSource = list;
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadListUser();
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                cbType.DataSource = context.Roles.ToList();
                cbType.ValueMember = "RoleId";
                cbType.DisplayMember = "RoleName";
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtUsername.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPassword.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbType.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                var list = context.Users.Include(x => x.Role).ToList();
                int roleID = (cbType.SelectedItem as Role).RoleId;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                foreach (var item in list)
                {
                    if (item.Username == username)
                    {
                        MessageBox.Show("Username is exist", "Notify");
                        return;
                    }
                }

                User u = new User();
                u.Username = username;
                u.Password = password;
                u.RoleId = roleID;
                context.Users.Add(u);
                context.SaveChanges();
                MessageBox.Show("Add successful", "Notify");
                LoadListUser();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                string username = txtUsername.Text.Trim();
                User u = context.Users.FirstOrDefault(x => x.Username == username);
                if (u != null)
                {
                    if (u.RoleId == 1)
                    {
                        MessageBox.Show("Cannot delete admin account");
                        return;
                    }
                    if (MessageBox.Show("Are you sure want to delete this account?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Users.Remove(u);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Delete Successful", "Notify");
                        }
                    }
                    LoadListUser();
                }
                else
                {
                    MessageBox.Show("Account is not exist", "Notify");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (HumanResourceManagementContext context = new HumanResourceManagementContext())
            {
                string username = txtUsername.Text.Trim();
                var user = context.Users.FirstOrDefault(x => x.Username == username);

                if (user != null)
                {
                    if(user.RoleId == 1)
                    {
                        MessageBox.Show("Cannot change role of Admin", "Notify");
                        return;
                    }
                    int roleID = (cbType.SelectedItem as Role).RoleId;
                    string newPassword = txtPassword.Text.Trim();

                    // Cập nhật thông tin tài khoản
                    user.Password = newPassword;
                    user.RoleId = roleID;

                    context.Users.Update(user);
                    context.SaveChanges();

                    MessageBox.Show("Edit successful", "Notify");
                    LoadListUser();
                }
                else
                {
                    MessageBox.Show("Cannot edit username", "Notify");
                }
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
