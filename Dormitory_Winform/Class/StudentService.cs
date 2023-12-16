using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dormitory_Winform.Class;

namespace Dormitory_Winform.Class
{
    public class StudentService
    {
        private QuanLi_DormitoryEntities db;

        public StudentService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }

        public List<SINHVIEN> SearchStudents(string searchText)
        {
            try
            {
                var searchResult = db.SINHVIENs.
                    Where(s => s.MaSV.ToString().Contains(searchText))
                    .ToList();
                return searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for students. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SINHVIEN>();
            }
        }

        public bool AddSinhVien(string maSV, string ten, string dt, string ngaySinh, string diaChi, string loaiPhongDki, string trangThaiDki)
        {
            try
            {
                if (!int.TryParse(maSV, out int maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (db.SINHVIENs.Any(s => s.MaSV == maSVID))
                {
                    MessageBox.Show("SinhVien already exists. Please choose a different SinhVien ID.", "Duplicate SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!DateTime.TryParse(ngaySinh, out DateTime ngaySinhDate))
                {
                    MessageBox.Show("Invalid date format for NgaySinh. Please enter a valid date.", "Invalid NgaySinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SINHVIEN newSinhVien = new SINHVIEN
                {
                    MaSV = maSVID,
                    Ten = ten,
                    NgaySinh = ngaySinhDate,
                    DienThoai = dt,
                    DiaChi = diaChi,
                    LoaiPhongSVDangKi = loaiPhongDki,
                    TrangThaiDki = trangThaiDki
                };

                db.SINHVIENs.Add(newSinhVien);
                db.SaveChanges();

                MessageBox.Show("SinhVien added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the SinhVien. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateSinhVien(string maSV, string ten, string dt, string ngaySinh, string diaChi, string loaiPhongDki, string trangThaiDki)
        {
            try
            {
                if (!int.TryParse(maSV, out int maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SINHVIEN existingSinhVien = db.SINHVIENs.FirstOrDefault(s => s.MaSV == maSVID);

                if (existingSinhVien == null)
                {
                    MessageBox.Show("SinhVien not found in the database.", "SinhVien Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingSinhVien.Ten = ten;
                existingSinhVien.DienThoai = dt;

                if (!DateTime.TryParse(ngaySinh, out DateTime ngaySinhDate))
                {
                    MessageBox.Show("Invalid date format for NgaySinh. Please enter a valid date.", "Invalid NgaySinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingSinhVien.NgaySinh = ngaySinhDate;

                existingSinhVien.DiaChi = diaChi;
                existingSinhVien.LoaiPhongSVDangKi = loaiPhongDki;
                existingSinhVien.TrangThaiDki = trangThaiDki;

                db.SaveChanges();

                MessageBox.Show("SinhVien updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the SinhVien. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool DeleteSinhVien(string maSV)
        {
            try
            {
                int maSVID;
                if (!int.TryParse(maSV, out maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SINHVIEN SinhVienToDelete = db.SINHVIENs.FirstOrDefault(s => s.MaSV == maSVID);

                if (SinhVienToDelete == null)
                {
                    MessageBox.Show("SinhVien not found in the database.", "SinhVien Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.SINHVIENs.Remove(SinhVienToDelete);
                db.SaveChanges();

                MessageBox.Show("SinhVien deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the SinhVien. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}