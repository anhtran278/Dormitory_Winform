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
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.THIETBIs.ToList();

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
            txtAddTenTBDevice.Clear();
            txtAddSoLuongDevice.Clear();
            rdbAddHoatDongDevice.Checked = false;
            rdbAddHongDevice.Checked = false;
            rdbAddBaoTriDevice.Checked = false;
            tabControlDevices.SelectedTab = tabPageAddDevices;
        }

        private void Clear1()
        {
            txtUpAndDeTenTBDevice.Clear();
            txtUpAndDeSoLuongDevice.Clear();
            rdbUpAndDeHoatDongDevice.Checked = false;
            rdbUpAndDeHongDevice.Checked = false;
            rdbUpAndDeBaoTriDevice.Checked = false;
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
                List<THIETBI> searchResult = devicesService.SearchDevice(searchDevice);
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
            string hongBaotri = rdbUpAndDeHongDevice.Checked ? "Hong" : (rdbUpAndDeBaoTriDevice.Checked ? "Bao Tri" : "Hoat Dong");

            if (!string.IsNullOrEmpty(txtUpAndDeTenTBDevice.Text) && 
                !string.IsNullOrEmpty(txtUpAndDeSoLuongDevice.Text))
            {
                if (!int.TryParse(txtUpAndDeSoLuongDevice.Text.Trim(), out int soLuongDevices))
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
                    txtUpAndDeTenTBDevice.Text.Trim(),
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
            string deviceNameToDelete = txtUpAndDeTenTBDevice.Text.Trim();

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
                txtUpAndDeTenTBDevice.Text = row.Cells[1].Value.ToString();
                txtUpAndDeSoLuongDevice.Text = row.Cells[2].Value.ToString();
                TinhTrang = row.Cells[3].Value.ToString();

                if (TinhTrang == "Hoat Dong")
                    rdbUpAndDeHoatDongDevice.Checked = true;

                if (TinhTrang == "Hong")
                    rdbUpAndDeHongDevice.Checked = true;

                if (TinhTrang == "Bao Tri")
                    rdbUpAndDeBaoTriDevice.Checked = true;
            }
        }
    }
}
