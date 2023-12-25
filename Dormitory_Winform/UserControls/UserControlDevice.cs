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
        private void UpdateConsumeControl()
        {
            var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
            if (consumesControl != null)
            {
                consumesControl.GetMaThietBiIntoComboBox();
            }
        }
        private void btnAddDevices_Click(object sender, EventArgs e)
        {
            try
            {
                string tenThietBi = txtAddTenTBDevice.Text.Trim();
                string soLuong = txtAddSoLuongDevice.Text.Trim();
                string tinhTrang = rdbAddHoatDongDevice.Checked ? "Hoat Dong" : (rdbAddHongDevice.Checked ? "Hong" : "Bao Tri");

                if (!string.IsNullOrEmpty(tenThietBi) && int.TryParse(soLuong, out int parsedSoLuong) && parsedSoLuong > 0)
                {
                    bool isAdded = devicesService.AddDevice(tenThietBi, parsedSoLuong, tinhTrang);

                    if (isAdded)
                    {
                        Clear();
                        RefreshDataGridView();
                        UpdateConsumeControl();
                        MessageBox.Show("Device added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while adding the device. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields and enter valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDevices_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtUpAndDeMaThietBiDevice.Text.Trim(), out int maThietBi))
                {
                    string tenThietBi = txtUpAndDeTenTBDevice.Text.Trim();
                    string soLuong = txtUpAndDeSoLuongDevice.Text.Trim();
                    string tinhTrang = rdbUpAndDeHoatDongDevice.Checked ? "Hoat Dong" : (rdbUpAndDeHongDevice.Checked ? "Hong" : "Bao Tri");

                    if (!string.IsNullOrEmpty(tenThietBi) && !string.IsNullOrEmpty(soLuong) && int.TryParse(soLuong, out int parsedSoLuong) && parsedSoLuong > 0)
                    {
                        bool isUpdated = devicesService.UpdateDevice(maThietBi, tenThietBi, parsedSoLuong, tinhTrang);

                        if (isUpdated)
                        {
                            Clear1();
                            RefreshDataGridView();
                            UpdateConsumeControl();
                            MessageBox.Show("Device updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while updating the device. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill out all required fields and enter valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Device ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while updating the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDevices_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtUpAndDeMaThietBiDevice.Text.Trim(), out int maThietBi))
                {
                    bool isDeleted = devicesService.DeleteDevice(maThietBi);

                    if (isDeleted)
                    {
                        Clear1();
                        RefreshDataGridView();
                        UpdateConsumeControl();
                        MessageBox.Show("Device deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Device deletion failed or the device was not found.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Device ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while deleting the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtUpAndDeMaThietBiDevice.Text = row.Cells[0].Value.ToString();
                tabControlDevices.SelectedTab = tabPageUpDeDevices;
            }
        }
    }
}
