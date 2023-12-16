using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    internal class IntoRoomService
    {
        private QuanLi_DormitoryEntities db;

        public IntoRoomService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<SINHVIENVAOPHONG> SearchIntoRoom(string searchIntoRoom)
        {
            try
            {
                return db.SINHVIENVAOPHONGs
                    .Where(r => r.MaPhong.ToString().Contains(searchIntoRoom)
                             || r.MaSV.ToString().Contains(searchIntoRoom))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for Fees. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SINHVIENVAOPHONG>();
            }
        }
        public bool AddSinhVienVaoPhong(string maSV, string loaiPhong, string maPhong, DateTime ngayVaoPhong)
        {
            try
            {
                int maSVID;
                if (!int.TryParse(maSV, out maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!db.SINHVIENs.Any(s => s.MaSV == maSVID))
                {
                    MessageBox.Show("SinhVien does not exist. Please enter a valid SinhVien ID.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Kiểm tra xem sinh viên đã có trong phòng nào khác chưa
                if (db.SINHVIENVAOPHONGs.Any(sv => sv.MaSV == maSVID && sv.MaPhong == maPhong))
                {
                    MessageBox.Show("This SinhVien is already in the room.", "SinhVien Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SINHVIENVAOPHONG newEntry = new SINHVIENVAOPHONG
                {
                    MaSV = maSVID,
                    LoaiPhongSVDangKi = loaiPhong,
                    MaPhong = maPhong,
                    NgayVao = ngayVaoPhong
                };
                db.SINHVIENVAOPHONGs.Add(newEntry);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
                UpdateRoomStatus(maPhong);
                MessageBox.Show("SinhVien added into the room successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the SinhVien into the room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateSinhVienVaoPhong(int maSinhVien, string maPhong, DateTime ngayVaoPhong, string loaiPhong)
        {
            try
            {
                var sinhVien = db.SINHVIENVAOPHONGs.FirstOrDefault(sv => sv.MaSV == maSinhVien);

                if (sinhVien != null)
                {
                    // Kiểm tra xem có cần thay đổi thông tin không
                    bool needUpdate = false;
                    if (sinhVien.MaPhong != maPhong)
                    {
                        sinhVien.MaPhong = maPhong;
                        needUpdate = true;
                    }
                    if (sinhVien.NgayVao != ngayVaoPhong)
                    {
                        sinhVien.NgayVao = ngayVaoPhong;
                        needUpdate = true;
                    }
                    if (sinhVien.LoaiPhongSVDangKi != loaiPhong)
                    {
                        sinhVien.LoaiPhongSVDangKi = loaiPhong;
                        needUpdate = true;
                    }

                    if (needUpdate)
                    {
                        // Lưu các thay đổi vào cơ sở dữ liệu
                        db.SaveChanges();

                        // Cập nhật thông tin của phòng
                        UpdateRoomStatus(maPhong);

                        MessageBox.Show("Cập nhật thông tin Sinh viên trong phòng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không có sự thay đổi trong thông tin Sinh viên.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại trong phòng.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin Sinh viên trong phòng. Chi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteSinhVienFromPhong(int maSinhVien)
        {
            try
            {
                var sinhVien = db.SINHVIENVAOPHONGs.FirstOrDefault(sv => sv.MaSV == maSinhVien);
                string maPhong = sinhVien?.MaPhong;

                if (sinhVien != null)
                {
                    db.SINHVIENVAOPHONGs.Remove(sinhVien);
                    db.SaveChanges();

                    if (maPhong != null)
                    {
                        UpdateRoomStatus(maPhong);
                    }

                    MessageBox.Show("SinhVien deleted from the room successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("SinhVien does not exist in the room.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the student from the room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void UpdateRoomStatus(string maPhong)
        {
            var room = db.PHONGs.FirstOrDefault(p => p.MaPhong == maPhong);
            if (room != null)
            {
                int studentCount = db.SINHVIENVAOPHONGs.Count(sv => sv.MaPhong == maPhong);

                if (maPhong.StartsWith("A"))
                {
                    if (studentCount == 0)
                        room.TrangThaiPhong = "Trống";
                    else if (studentCount == 1)
                        room.TrangThaiPhong = "1/2";
                    else if (studentCount == 2)
                        room.TrangThaiPhong = "Đầy";
                }
                else if (maPhong.StartsWith("B"))
                {
                    if (studentCount == 0)
                        room.TrangThaiPhong = "Trống";
                    else if (studentCount == 1)
                        room.TrangThaiPhong = "1/4";
                    else if (studentCount == 2)
                        room.TrangThaiPhong = "2/4";
                    else if (studentCount == 3)
                        room.TrangThaiPhong = "3/4";
                    else if (studentCount == 4)
                        room.TrangThaiPhong = "Đầy";
                }
                db.SaveChanges();
            }
        }
    }
}