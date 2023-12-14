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
            cbBoxAddLoaiPhongRoom.SelectedIndex = 0;
            cbBoxAddTrangThaiRoom.SelectedIndex = 0;
            cbBoxUpAndDeTrangThaiRoom.SelectedIndex = 0;
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
            txtAddGiaPhongRoom.Clear();
            txtAddMaPhongRoom.Clear();
            cbBoxAddLoaiPhongRoom.SelectedIndex = 0;
            cbBoxAddTrangThaiRoom.SelectedIndex = 0;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void Clear1()
        {
            txtUpAndDeGiaPhongRoom.Clear();
            txtUpAndDeMaPhongRoom.Clear();
            cbBoxAddTrangThaiRoom.SelectedIndex = 0;
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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAddMaPhongRoom.Text)
                && !string.IsNullOrEmpty(txtAddGiaPhongRoom.Text))
            {
                bool check = roomService.AddRoom(
                    txtAddMaPhongRoom.Text.Trim(),
                    txtAddGiaPhongRoom.Text.Trim(),
                    cbBoxAddLoaiPhongRoom.SelectedItem.ToString(),
                    cbBoxAddTrangThaiRoom.SelectedIndex.ToString()
                    );
                if (check)
                {
                    Clear();
                    RefreshDataGridView();
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
                && !string.IsNullOrEmpty(txtUpAndDeGiaPhongRoom.Text))
            {
                bool check = roomService.UpdateRoom(
                    txtUpAndDeMaPhongRoom.Text.Trim(),
                    txtUpAndDeGiaPhongRoom.Text.Trim(),
                    cbBoxUpAndDeTrangThaiRoom.SelectedIndex.ToString()
                    );

                if (check)
                {
                    Clear1();
                    RefreshDataGridView();

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
                txtUpAndDeGiaPhongRoom.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
