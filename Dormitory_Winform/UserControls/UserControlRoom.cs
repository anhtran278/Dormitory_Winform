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
        private void RoomService_RoomDeleted(string maPhong)
        {
            RefreshDataGridView();
            UpdateRelatedControls();
        }
        private void UserControlRooms_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddLoaiPhongRoom.SelectedIndex = -1;
        }


        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.PHONGs.ToList();

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
                bindingSource.DataSource = null;
                db.SaveChanges();
                loadDataIntoDataGridView();
                var data = db.PHONGs.ToList();
                bindingSource.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Clear()
        {
            txtAddGiaPhongRoom.Clear();
            txtAddKiHieuPhongRoom.Clear();
            cbBoxAddLoaiPhongRoom.SelectedIndex = -1;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void Clear1()
        {
            txtUpAndDeGiaPhongRoom.Clear();
            txtUpAndDeMaPhongRoom.Clear();
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearchMaPhongRoom_Leave(object sender, EventArgs e)
        {
            txtSearchRoom.Clear();
        }

        private void tabPageUpDeRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            string searchMaPhong = txtSearchRoom.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaPhong))
            {
                List<PHONG> searchResult = roomService.SearchRoom(searchMaPhong);
                bindingSource.DataSource = searchResult;
            }
            else
            {
                RefreshDataGridView();
            }
        }
        private void UpdateRelatedControls()
        {
            var intoRoomControl = FindForm().Controls.Find("userControlIntoRoom1", true).FirstOrDefault() as UserControlIntoRoom;
            intoRoomControl?.GetMaSVIntoComboBox();
            var intoIDRoomControl = FindForm().Controls.Find("userControlIntoRoom1", true).FirstOrDefault() as UserControlIntoRoom;
            intoIDRoomControl?.GetMaPhongIntoComboBox();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddKiHieuPhongRoom.Text) &&
                !string.IsNullOrEmpty(txtAddGiaPhongRoom.Text))
            {
                string kiHieuPhong = txtAddKiHieuPhongRoom.Text.Trim();
                string giaPhong = txtAddGiaPhongRoom.Text.Trim();
                string loaiPhong = cbBoxAddLoaiPhongRoom.SelectedItem.ToString();

                string maPhong = loaiPhong + kiHieuPhong;

                bool check = roomService.AddRoom(maPhong, giaPhong, "Trống");
                if (check)
                {
                    Clear();
                    RefreshDataGridView();
                    UpdateRelatedControls();
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string maPhong = txtUpAndDeMaPhongRoom.Text.Trim();
            string giaPhong = txtUpAndDeGiaPhongRoom.Text.Trim();

            if (!string.IsNullOrEmpty(maPhong) && !string.IsNullOrEmpty(giaPhong))
            {
                bool check = roomService.UpdateRoom(maPhong, giaPhong);

                if (check)
                {
                    Clear1();
                    RefreshDataGridView();
                    UpdateRelatedControls();
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
                    string maPhong = txtUpAndDeMaPhongRoom.Text.Trim();

                    bool checkDeleteRoom = roomService.DeleteRoom(maPhong);
                    if (checkDeleteRoom)
                    {
                        Clear1();
                        RefreshDataGridView();
                        UpdateRelatedControls();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the room. It might be due to existing students or other constraints.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a room number to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                txtUpAndDeMaPhongRoom.Text = row.Cells[0].Value.ToString();
                txtUpAndDeGiaPhongRoom.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}