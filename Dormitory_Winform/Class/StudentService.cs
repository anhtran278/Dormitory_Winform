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

        public List<SinhVien> SearchStudents(string searchText)
        {
            try
            {
                var searchResult = db.SinhViens.Where(s => s.MaSV.ToString().Contains(searchText)).ToList();
                return searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for students. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SinhVien>();
            }
        }

        public bool AddSinhVien(string maSV, string ten, string dt, string ngaySinh, string diaChi, string trangThaiDki)
        {
            try
            {
                int maSVID;
                if (!int.TryParse(maSV, out maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (db.SinhViens.Any(s => s.MaSV == maSVID))
                {
                    MessageBox.Show("SinhVien already exists. Please choose a different SinhVien ID.", "Duplicate SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                DateTime ngaySinhDate;
                if (!DateTime.TryParse(ngaySinh, out ngaySinhDate))
                {
                    MessageBox.Show("Invalid date format for NgaySinh. Please enter a valid date.", "Invalid NgaySinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SinhVien newSinhVien = new SinhVien
                {
                    MaSV = maSVID,
                    Ten = ten,
                    NgaySinh = ngaySinhDate,
                    DienThoai = dt,
                    DiaChi = diaChi,
                    TrangThaiDki = trangThaiDki
                };

                db.SinhViens.Add(newSinhVien);
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
        public bool UpdateSinhVien(string maSV, string ten, string dt, string ngaySinh, string diaChi, bool trangThaiDki)
        {
            try
            {
                int maSVID;
                if (!int.TryParse(maSV, out maSVID))
                {
                    MessageBox.Show("Invalid SinhVien ID. Please enter a valid integer.", "Invalid SinhVien ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SinhVien existingSinhVien = db.SinhViens.FirstOrDefault(s => s.MaSV == maSVID);

                if (existingSinhVien == null)
                {
                    MessageBox.Show("SinhVien not found in the database.", "SinhVien Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingSinhVien.Ten = ten;
                existingSinhVien.DienThoai = dt;

                DateTime ngaySinhDate;
                if (!DateTime.TryParse(ngaySinh, out ngaySinhDate))
                {
                    MessageBox.Show("Invalid date format for NgaySinh. Please enter a valid date.", "Invalid NgaySinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingSinhVien.NgaySinh = ngaySinhDate;

                existingSinhVien.DiaChi = diaChi;

                existingSinhVien.TrangThaiDki = trangThaiDki ? "Duyet" : "Chua Duyet";

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

                SinhVien SinhVienToDelete = db.SinhViens.FirstOrDefault(s => s.MaSV == maSVID);

                if (SinhVienToDelete == null)
                {
                    MessageBox.Show("SinhVien not found in the database.", "SinhVien Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.SinhViens.Remove(SinhVienToDelete);
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