using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dormitory_Winform.FormDashboard;

namespace Dormitory_Winform
{
    public partial class FormLogin : Form
    {
        QuanLi_DormitoryEntities db = new QuanLi_DormitoryEntities();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureClose, "Close");
        }

        private void pictureMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureMinimize, "Minimize");
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string userPassword = txtPassword.Text;

            try
            {
                var user = db.Admins.SingleOrDefault(u => u.Ten == username && u.MatKhau == userPassword);
                
                if (user != null)
                {
                    LoggedInUser.Username = user.Ten;
                    FormDashboard form2 = new FormDashboard();
                    form2.Show();
                    this.Hide();
                }
                else if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out al field.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblFotgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the developer to retrieve your password !!.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
