using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dormitory_Winform.UserControls
{
    public partial class UserControlRooms : UserControl
    {
        QuanLi_DormitoryEntities db;
        RoomService roomService;
        private BindingSource bindingSource;
        public UserControlRooms()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            roomService = new RoomService(db);
            bindingSource = new BindingSource();
            dataGridViewRoom.DataSource = bindingSource;
            dataGridViewRoom.AutoGenerateColumns = false;
        }

        private void UserControlRooms_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddMaSvRoom.SelectedIndex = -1;
            cbBoxAddLoaiPhongRoom.SelectedIndex = 0;
            cbBoxUpAndDeLoaiPhongRoom.SelectedIndex = 0;
            GetMaSVIntoComboBox();
        }
        public void GetMaSVIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maSVList = db.SinhViens
                    .Where(s => s.TrangThaiDki == "Duyet")
                    .Select(s => s.MaSV.ToString())
                    .ToList();

                if (cbBoxAddMaSvRoom == null)
                {
                    return;
                }

                cbBoxAddMaSvRoom.Items.Clear();
                foreach (string maSV in maSVList)
                {
                    cbBoxAddMaSvRoom.Items.Add(maSV);
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

                var data = db.Phongs.ToList();

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
            cbBoxAddMaSvRoom.SelectedIndex = -1;
            txtAddKiHieuRoom.Clear();
            txtAddGiaPhongRoom.Clear();
            txtAddMaPhongRoom.Clear();
            cbBoxAddLoaiPhongRoom.SelectedIndex = 0;
            dateTimeAddNgayVaoRoom.Value = DateTime.Now;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void Clear1()
        {
            txtUpAndDeMaSVRoom.Clear();
            txtUpAndDeKiHieuRoom.Clear();
            txtUpAndDeGiaPhongRoom.Clear();
            txtUpAndDeMaPhongRoom.Clear();
            dateTimeUpAndDeNgayVaoRoom.Value = DateTime.Now;
            cbBoxUpAndDeLoaiPhongRoom.SelectedIndex = 0;
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearchMaPhongRoom_Leave(object sender, EventArgs e)
        {
            txtSearchMaPhongRoom.Clear();
        }

        private void tabPageUpDeRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtSearchMaPhongRoom_TextChanged(object sender, EventArgs e)
        {
            string searchMaPhong = txtSearchMaPhongRoom.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaPhong))
            {
                List<Phong> searchResult = roomService.SearchRoom(searchMaPhong);
                bindingSource.DataSource = searchResult;
            }
            else
            {
                RefreshDataGridView();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAddMaPhongRoom.Text)
                && !string.IsNullOrEmpty(txtAddGiaPhongRoom.Text)
                && !string.IsNullOrEmpty(txtAddKiHieuRoom.Text))
            {
                bool check = roomService.AddRoom(txtAddMaPhongRoom.Text.Trim(),
                    cbBoxAddLoaiPhongRoom.SelectedItem.ToString(),
                    cbBoxAddMaSvRoom.SelectedItem.ToString(),
                    txtAddKiHieuRoom.Text.Trim(),
                    txtAddGiaPhongRoom.Text.Trim(),
                    dateTimeAddNgayVaoRoom.Text.Trim()
                    );
                if (check)
                {
                    Clear();
                    RefreshDataGridView();

                    //device
                    var devicesControl = FindForm().Controls.Find("userControlDevices1", true).FirstOrDefault() as UserControlDevice;
                    if (devicesControl != null)
                    {
                        devicesControl.GetMaPhongIntoComboBox();
                    }

                    //comsume
                    var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                    if (consumesControl != null)
                    {
                        consumesControl.GetMaPhongIntoComboBox();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpAndDeMaPhongRoom.Text)
                && !string.IsNullOrEmpty(txtUpAndDeGiaPhongRoom.Text)
                && !string.IsNullOrEmpty(txtUpAndDeKiHieuRoom.Text))
            {
                bool check = roomService.UpdateRoom(
                    txtUpAndDeMaPhongRoom.Text.Trim(),
                    cbBoxUpAndDeLoaiPhongRoom.SelectedItem.ToString(),
                    txtUpAndDeMaSVRoom.Text.Trim(),
                    txtUpAndDeKiHieuRoom.Text.Trim(),
                    txtUpAndDeGiaPhongRoom.Text.Trim(),
                    dateTimeAddNgayVaoRoom.Text.Trim());

                if (check)
                {
                    Clear1();
                    RefreshDataGridView();

                    // device
                    var devicesControl = FindForm().Controls.Find("userControlDevices1", true).FirstOrDefault() as UserControlDevice;
                    if (devicesControl != null)
                    {
                        devicesControl.GetMaPhongIntoComboBox();
                    }

                    //comsume
                    var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                    if (consumesControl != null)
                    {
                        consumesControl.GetMaPhongIntoComboBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpAndDeMaPhongRoom.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool check = roomService.DeleteRoom(txtUpAndDeMaPhongRoom.Text.Trim());

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                        // device
                        var devicesControl = FindForm().Controls.Find("userControlDevices1", true).FirstOrDefault() as UserControlDevice;
                        devicesControl?.GetMaPhongIntoComboBox();

                        // comsume
                        var consumesControl = FindForm().Controls.Find("userControlConsume1", true).FirstOrDefault() as UserControlConsume;
                        consumesControl?.GetMaPhongIntoComboBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                txtUpAndDeMaPhongRoom.Text = row.Cells[0].Value.ToString();
                txtUpAndDeMaSVRoom.Text = row.Cells[1].Value.ToString();
                txtUpAndDeGiaPhongRoom.Text = row.Cells[2].Value.ToString();
                txtUpAndDeKiHieuRoom.Text = row.Cells[3].Value.ToString();
                cbBoxUpAndDeLoaiPhongRoom.SelectedItem = row.Cells[4].Value.ToString();
                dateTimeUpAndDeNgayVaoRoom.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            }
        }


    }
}
