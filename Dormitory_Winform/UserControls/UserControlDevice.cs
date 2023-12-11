using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.UserControls
{
    public partial class UserControlDevice : UserControl
    {
        QuanLi_DormitoryEntities db;
        DeviceService devicesService;
        private BindingSource bindingSource;

        private string TinhTrang = "";
        public UserControlDevice()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            devicesService = new DeviceService(db);
            bindingSource = new BindingSource();
            dataGridViewDevices.DataSource = bindingSource;
            dataGridViewDevices.AutoGenerateColumns = false;
        }
        private void UserControlDevice_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddMaPhongDevice.SelectedIndex = -1;
            GetMaPhongIntoComboBox();
        }
        public void GetMaPhongIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maPhongList = db.Phongs
               .Select(s => s.MaPhong.ToString())
               .ToList();
                if (cbBoxAddMaPhongDevice == null)
                {
                    return;
                }

                cbBoxAddMaPhongDevice.Items.Clear();
                foreach (string maPhong in maPhongList)
                {
                    cbBoxAddMaPhongDevice.Items.Add(maPhong);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.ThietBis.ToList();

                if (data == null)
                {
                    return;
                }

                bindingSource.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                db.SaveChanges();
                loadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Clear()
        {
            cbBoxAddMaPhongDevice.SelectedIndex = -1;
            txtAddTenTBDevice.Clear();
            txtAddSoLuongDevice.Clear();
            rdbAddHoatDongDevice.Checked = false;
            rdbAddHongDevice.Checked = false;
            rdbAddBaoTriDevice.Checked = false;
            tabControlDevices.SelectedTab = tabPageAddDevices;
        }

        private void Clear1()
        {
            txtUpAndDeMaPhongDevice.Clear();
            txtUpAndDeSoLuongDevices.Clear();
            txtUpAndDeTenTBDevices.Clear();
            rdbUpAndDeHoatDongDevices.Checked = false;
            rdbUpAndDeHongDevices.Checked = false;
            rdbUpAndDeBaoTriDevices.Checked = false;
        }

        private void tabPageAddDevices_Leave(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtSearchMaThietBiDevices_Leave(object sender, EventArgs e)
        {
            txtSearchMaThietBiDevices.Clear();
        }

        private void tabPageUpDeDevices_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtSearchMaThietBiDevices_TextChanged(object sender, EventArgs e)
        {
            string searchDevice = txtSearchMaThietBiDevices.Text.Trim();

            if (!string.IsNullOrEmpty(searchDevice))
            {
                List<ThietBi> searchResult = devicesService.SearchDevice(searchDevice);
                bindingSource.DataSource = searchResult;
            }
            else
            {
                loadDataIntoDataGridView();
            }
        }

        private void btnAddDevices_Click(object sender, EventArgs e)
        {
            string hongBaotri = rdbAddHongDevice.Checked ? "Hong" : (rdbAddBaoTriDevice.Checked ? "Bao Tri" : "Hoat Dong");

            if (!string.IsNullOrEmpty(txtAddSoLuongDevice.Text) 
                && !string.IsNullOrEmpty(txtAddTenTBDevice.Text))
            {
                bool check = devicesService.AddDevice(
                    txtAddTenTBDevice.Text.Trim(),
                    cbBoxAddMaPhongDevice.Text.Trim(),
                    txtAddSoLuongDevice.Text.Trim(),
                    hongBaotri);

                if (check)
                {
                    Clear();
                    RefreshDataGridView();
                    // consume
                    var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                    if (consumesControl != null)
                    {
                        consumesControl.GetMaThietBiIntoComboBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateDevices_Click(object sender, EventArgs e)
        {
            string hongBaotri = rdbUpAndDeHongDevices.Checked ? "Hong" : (rdbUpAndDeBaoTriDevices.Checked ? "Bao Tri" : "Hoat Dong");

            if (!string.IsNullOrEmpty(txtUpAndDeTenTBDevices.Text) && 
                !string.IsNullOrEmpty(txtUpAndDeSoLuongDevices.Text))
            {
                if (!int.TryParse(txtUpAndDeSoLuongDevices.Text.Trim(), out int soLuongDevices))
                {
                    MessageBox.Show("Invalid value for So Luong Devices. Please enter a valid integer.", "Invalid So Luong Devices", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (soLuongDevices <= 0)
                {
                    MessageBox.Show("So Luong Devices must be a positive integer.", "Invalid So Luong Devices", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool check = devicesService.UpdateDevice(
                    txtUpAndDeTenTBDevices.Text.Trim(),
                    txtUpAndDeMaPhongDevice.Text.Trim(),
                    soLuongDevices.ToString(),
                    hongBaotri);

                if (check)
                {
                    Clear1();
                    RefreshDataGridView();
                    // consume
                    var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                    if (consumesControl != null)
                    {
                        consumesControl.GetMaThietBiIntoComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Error occurred while updating the device. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values for Ten TB Devices and So Luong Devices.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteDevices_Click(object sender, EventArgs e)
        {
            string deviceNameToDelete = txtUpAndDeTenTBDevices.Text.Trim();

            if (!string.IsNullOrEmpty(deviceNameToDelete))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this device?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool check = devicesService.DeleteDevice(deviceNameToDelete);

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                        // consume
                        var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                        if (consumesControl != null)
                        {
                            consumesControl.GetMaThietBiIntoComboBox();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Device deletion failed or the device was not found.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter the device name to delete.", "Device Name Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewDevices.Rows[e.RowIndex];
                txtUpAndDeMaPhongDevice.Text = row.Cells[1].Value.ToString();
                txtUpAndDeTenTBDevices.Text = row.Cells[2].Value.ToString();
                txtUpAndDeSoLuongDevices.Text = row.Cells[3].Value.ToString();
                TinhTrang = row.Cells[4].Value.ToString();

                if (TinhTrang == "Hoat Dong")
                    rdbUpAndDeHoatDongDevices.Checked = true;

                if (TinhTrang == "Hong")
                    rdbUpAndDeHongDevices.Checked = true;

                if (TinhTrang == "Bao Tri")
                    rdbUpAndDeBaoTriDevices.Checked = true;
            }
        }
    }
}
