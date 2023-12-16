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
    public partial class UserControlIntoRoom : UserControl
    {
        QuanLi_DormitoryEntities db;
        IntoRoomService intoRoomService;
        private BindingSource bindingSource;

        public UserControlIntoRoom()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            intoRoomService = new IntoRoomService(db);
            bindingSource = new BindingSource();
            dataGridViewIntoRoom.DataSource = bindingSource;
            dataGridViewIntoRoom.AutoGenerateColumns = false;
        }

        private void UserControlIntoRoom_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            GetMaPhongIntoComboBox();
            GetMaPhongIntoUpandDeComboBox();
            GetMaSVIntoComboBox();
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.SINHVIENVAOPHONGs.ToList();

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

                bindingSource.DataSource = db.SINHVIENVAOPHONGs.ToList();

                dataGridViewIntoRoom.DataSource = null;
                dataGridViewIntoRoom.DataSource = bindingSource;

                dataGridViewIntoRoom.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while refreshing DataGridView: " + ex.Message);
            }
        }
        public void Clear()
        {
            cbBoxAddLoaiPhongDkiIntoRoom.SelectedIndex = -1;
            cbBoxAddMaPhongIntoRoom.SelectedIndex = -1;
            cbBoxAddMaSVIntoRoom.SelectedIndex = -1;
            dateTimeAddNgayVaoIntoRoom.Value = DateTime.Now;
            tabControlIntoRoom.SelectedTab = tabPageAddIntoRoom;
        }
        private void Clear1()
        {
            cbBoxUpAndDeLoaiPhongDkiIntoRoom.SelectedIndex = -1;
            cbBoxUpAndDeMaPhongIntoRoom.SelectedIndex = -1;
            cbBoxUpAndDeMaSVIntoRoom.SelectedIndex = -1;
            dateTimeUpAndDeNgayVaoIntoRoom.Value = DateTime.Now;
        }

        private void tabPageAddIntoRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtSearchIntoRoom_Leave(object sender, EventArgs e)
        {
            txtSearchIntoRoom.Clear();
        }
        private void tabPageUpDeIntoRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
        private void txtSearchIntoRoom_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchIntoRoom.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
            }
            else
            {
                var intoRoomhResult = intoRoomService.SearchIntoRoom(searchText);
                bindingSource.DataSource = intoRoomhResult;
            }
        }
        public void GetMaPhongIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maPhongList = db.PHONGs
                    .Select(p => p.MaPhong)
                    .ToList();

                if (cbBoxAddMaPhongIntoRoom == null)
                {
                    return;
                }

                cbBoxAddMaPhongIntoRoom.Items.Clear();
                foreach (string maPhong in maPhongList)
                {
                    Console.WriteLine(maPhong);
                    cbBoxAddMaPhongIntoRoom.Items.Add(maPhong);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }
        public void GetMaSVIntoComboBox()
        {

            try
            {

                if (db == null)
                {
                    return;
                }

                List<string> getMaSVList = db.SINHVIENs
                    .Where(sv => sv.TrangThaiDki == "Duyet")
                    .Select(sv => sv.MaSV.ToString())
                    .ToList();

                if (cbBoxAddMaSVIntoRoom == null)
                {
                    return;
                }

                cbBoxAddMaSVIntoRoom.Items.Clear();
                foreach (string maSV in getMaSVList)
                {
                    cbBoxAddMaSVIntoRoom.Items.Add(maSV);
                }
                //////////////////////////////////////////////////
                List<string> loaiPhongDkiList = db.LOAIPHONGSVDKIs
                    .Select(sv => sv.LoaiPhongSVDangKi.ToString())
                    .ToList();

                if (cbBoxAddLoaiPhongDkiIntoRoom == null)
                {
                    return;
                }

                cbBoxAddLoaiPhongDkiIntoRoom.Items.Clear();
                foreach (string loaiPhongDki in loaiPhongDkiList)
                {
                    cbBoxAddLoaiPhongDkiIntoRoom.Items.Add(loaiPhongDki);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }
        public void GetMaPhongIntoUpandDeComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maPhongList = db.PHONGs
                .Select(p => p.MaPhong)
                    .ToList();

                if (cbBoxUpAndDeMaPhongIntoRoom == null)
                {
                    return;
                }

                cbBoxUpAndDeMaPhongIntoRoom.Items.Clear();
                foreach (string maPhong in maPhongList)
                {
                    Console.WriteLine(maPhong);
                    cbBoxUpAndDeMaPhongIntoRoom.Items.Add(maPhong);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }
        private void UpdateMaPhongUpAndDeComboBox(string loaiPhong)
        {
            using (var context = new QuanLi_DormitoryEntities())
            {
                var danhSachPhong = context.PHONGs
                    .Where(p => p.MaPhong.StartsWith(loaiPhong))
                    .Select(p => p.MaPhong)
                    .ToList();
                cbBoxUpAndDeMaPhongIntoRoom.Items.Clear();
                foreach (var maPhong in danhSachPhong)
                {
                    cbBoxUpAndDeMaPhongIntoRoom.Items.Add(maPhong);
                }
            }
        }
        private void UpdateMaPhongAddComboBox(string loaiPhong)
        {
            using (var context = new QuanLi_DormitoryEntities())
            {
                var danhSachPhong = context.PHONGs
                    .Where(p => p.MaPhong.StartsWith(loaiPhong))
                    .Select(p => p.MaPhong)
                    .ToList();
                cbBoxAddMaPhongIntoRoom.Items.Clear();
                foreach (var maPhong in danhSachPhong)
                {
                    cbBoxAddMaPhongIntoRoom.Items.Add(maPhong);
                }
            }
        }
        private void cbBoxAddMaSVIntoRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxAddMaSVIntoRoom.SelectedItem != null && cbBoxAddMaSVIntoRoom.SelectedItem is string selectedMaSinhVienString)
            {
                if (int.TryParse(selectedMaSinhVienString, out int selectedMaSinhVien))
                {
                    using (var context = new QuanLi_DormitoryEntities())
                    {
                        var sinhVien = context.SINHVIENs.FirstOrDefault(sv => sv.MaSV == selectedMaSinhVien);
                        if (sinhVien != null)
                        {
                            cbBoxAddLoaiPhongDkiIntoRoom.SelectedItem = sinhVien.LoaiPhongSVDangKi;
                            UpdateMaPhongAddComboBox(sinhVien.LoaiPhongSVDangKi);
                        }
                    }
                }
            }
        }
        private void cbBoxUpAndDeMaSVIntoRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxUpAndDeMaSVIntoRoom.SelectedItem != null && cbBoxUpAndDeMaSVIntoRoom.SelectedItem is string selectedMaSinhVienString)
            {
                if (int.TryParse(selectedMaSinhVienString, out int selectedMaSinhVien))
                {
                    using (var context = new QuanLi_DormitoryEntities())
                    {
                        var sinhVien = context.SINHVIENs.FirstOrDefault(sv => sv.MaSV == selectedMaSinhVien);
                        if (sinhVien != null)
                        {
                            cbBoxUpAndDeLoaiPhongDkiIntoRoom.SelectedItem = sinhVien.LoaiPhongSVDangKi;
                            UpdateMaPhongUpAndDeComboBox(sinhVien.LoaiPhongSVDangKi);
                        }
                    }
                }
            }
        }


        private void btnAddIntoRoom_Click(object sender, EventArgs e)
        {
            bool check;

            if (!string.IsNullOrEmpty(cbBoxAddLoaiPhongDkiIntoRoom.Text) &&
                !string.IsNullOrEmpty(cbBoxAddMaPhongIntoRoom.Text) &&
                cbBoxAddMaSVIntoRoom.SelectedItem != null)
            {
                string selectedMaSV = cbBoxAddMaSVIntoRoom.SelectedItem.ToString();

                check = intoRoomService.AddSinhVienVaoPhong(selectedMaSV,
                    cbBoxAddLoaiPhongDkiIntoRoom.Text.Trim(), cbBoxAddMaPhongIntoRoom.Text.Trim(),
                    dateTimeAddNgayVaoIntoRoom.Value);

                if (check)
                {
                    Clear();
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên vào phòng thất bại. Vui lòng kiểm tra đầu vào hoặc thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc.", "Trường bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnUpdateIntoRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbBoxUpAndDeMaSVIntoRoom.Text))
                {
                    int maSinhVien = int.Parse(cbBoxUpAndDeMaSVIntoRoom.Text);
                    string maPhong = cbBoxUpAndDeMaPhongIntoRoom.Text.Trim();
                    DateTime ngayVao = dateTimeUpAndDeNgayVaoIntoRoom.Value;
                    string loaiPhong = cbBoxUpAndDeLoaiPhongDkiIntoRoom.Text.Trim();

                    bool check = intoRoomService.UpdateSinhVienVaoPhong(maSinhVien, maPhong, ngayVao, loaiPhong);

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra đầu vào hoặc thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Sinh viên cần cập nhật.", "Trường bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteIntoRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbBoxUpAndDeMaSVIntoRoom.Text))
                {
                    int maSinhVien = int.Parse(cbBoxUpAndDeMaSVIntoRoom.Text);

                    bool check = intoRoomService.DeleteSinhVienFromPhong(maSinhVien);

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. The student may not exist or there was an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("An error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewIntoRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewIntoRoom.Rows[e.RowIndex];
                cbBoxUpAndDeMaSVIntoRoom.Text = row.Cells[1].Value.ToString();
                cbBoxUpAndDeLoaiPhongDkiIntoRoom.Text = row.Cells[2].Value.ToString();
                cbBoxUpAndDeMaPhongIntoRoom.Text = row.Cells[3].Value.ToString();
                dateTimeUpAndDeNgayVaoIntoRoom.Value = (DateTime)row.Cells[4].Value;

                tabControlIntoRoom.SelectedTab = tabPageUpDeIntoRoom;
            }
        }

        
    }
}