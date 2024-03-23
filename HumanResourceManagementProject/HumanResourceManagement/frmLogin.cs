using HumanResourceManagement.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class frmLogin : Form
    {
        HumanResourceManagementContext context = new HumanResourceManagementContext();

        #region Variables
        public static string Role = "-1";
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem text box tài khoản và text box mật khẩu đã nhập chưa
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Username has not been entered", "Notify");
                    txtUsername.Focus();
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password has not been entered", "Notify");
                    txtUsername.Focus();
                    return;
                }


                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    UserSession.Username = username;
                    UserSession.Password = password;
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    //không tìm thấy
                    MessageBox.Show("Username or password is not correct", "Notify");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
