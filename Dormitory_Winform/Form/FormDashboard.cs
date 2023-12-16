using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform
{
    public partial class FormDashboard : Form
    {
        QuanLi_DormitoryEntities db = new QuanLi_DormitoryEntities();

        public FormDashboard()
        {
            InitializeComponent();
        }
        public static class LoggedInUser
        {
            public static string Username { get; set; }
        }
        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUserName.Text = LoggedInUser.Username;
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
        private void movePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MM--yyyy hh:mm:ss tt");
        }

        private void pictureClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            movePanel(btnStudent);
            userControlStudents1.Clear();
            userControlStudents1.Show();
            userControlAdmins1.Hide();
            userControlRooms1.Hide();
            userControlFee1.Hide();
            userControlRelatives1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            movePanel(btnRoom);
            userControlRooms1.Clear();
            userControlRooms1.Show();
            userControlAdmins1.Hide();
            userControlStudents1.Hide();
            userControlFee1.Hide();
            userControlRelatives1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            movePanel(btnFee);
            userControlFee1.Clear();
            userControlFee1.Show();
            userControlAdmins1.Hide();
            userControlRooms1.Hide();
            userControlStudents1.Hide();
            userControlRelatives1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnRelatives_Click(object sender, EventArgs e)
        {
            movePanel(btnRelatives);
            userControlRelatives1.ClearFields();
            userControlRelatives1.Show();
            userControlAdmins1.Hide();
            userControlRooms1.Hide();
            userControlStudents1.Hide();
            userControlFee1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            movePanel(btnStatistical);
            userControlStatistical1.Show();
            userControlAdmins1.Hide();
            userControlRooms1.Hide();
            userControlFee1.Hide();
            userControlStudents1.Hide();
            userControlRelatives1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            movePanel(btnDevice);
            userControlDevices1.Show();
            userControlAdmins1.Hide();
            userControlRooms1.Hide();
            userControlFee1.Hide();
            userControlStudents1.Hide();
            userControlRelatives1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            movePanel(btnAdmin);
            userControlAdmins1.Clear();
            userControlAdmins1.Show();
            userControlStudents1.Hide();
            userControlFee1.Hide();
            userControlRooms1.Hide();
            userControlRelatives1.Hide();
            userControlDevices1.Hide();
            userControlConsume1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnConsume_Click(object sender, EventArgs e)
        {
            movePanel(btnConsume);
            userControlConsume1.Clear();
            userControlConsume1.Show();
            userControlAdmins1.Hide();
            userControlStudents1.Hide();
            userControlRelatives1.Hide();
            userControlFee1.Hide();
            userControlRooms1.Hide();
            userControlDevices1.Hide();
            userControlStatistical1.Hide();
        }

        private void btnIntoRoom_Click(object sender, EventArgs e)
        {
            movePanel(btnIntoRoom);
            userControlIntoRoom1.Clear();
            userControlIntoRoom1.Show();
            userControlAdmins1.Hide();
            userControlStudents1.Hide();
            userControlRelatives1.Hide();
            userControlFee1.Hide();
            userControlRooms1.Hide();
            userControlDevices1.Hide();
            userControlStatistical1.Hide();
            userControlConsume1.Hide();
        }

        private void picInformationShow_Click(object sender, EventArgs e)
        {
            string phongA = "2 giuong, 1 may lanh, 2 tu, 2 ban, 1 TV, 1 bep, 1 nha vs";
            string phongB = "4 giuong, 1 may lanh, 4 tu, 4 ban, 1 TV, 1 bep, 2 nha vs";

            string info = "Thông tin phòng:\n\n";
            info += "Loại A: " + phongA + "\n\n";
            info += "Loại B: " + phongB;

            MessageBox.Show(info, "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}