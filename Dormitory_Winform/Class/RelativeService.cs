//RelativeService.cs

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Dormitory_Winform.Class
{
    public class RelativeService
    {
        private QuanLi_DormitoryEntities db;

        public RelativeService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }

        public List<NguoiThan> SearchRelatives(string searchText)
        {
            try
            {
                var searchResult = db.NguoiThans
                    .Where(r => r.MaNT.ToString().Contains(searchText))
                    .ToList();
                return searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for relatives. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<NguoiThan>();
            }
        }


        public bool AddRelative(string maNguoiThan, int maSinhVien, DateTime ngayTham, string tenNguoiThan, string diaChi, string soDienThoai)
        {
            try
            {
                int maNguoiThanID;

                if (!int.TryParse(maNguoiThan, out maNguoiThanID))
                {
                    MessageBox.Show("Invalid Relative ID. Please enter a valid integer.", "Invalid Relative ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (db.NguoiThans.Any(r => r.MaNT == maNguoiThanID))
                {
                    MessageBox.Show("Relative already exists. Please choose a different Relative ID.", "Duplicate Relative ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                NguoiThan newRelative = new NguoiThan
                {
                    MaNT = maNguoiThanID,
                    MaSV = maSinhVien,
                    NgayTham = ngayTham,
                    Ten = tenNguoiThan,
                    DiaChi = diaChi,
                    DienThoai = soDienThoai
                };

                db.NguoiThans.Add(newRelative);
                db.SaveChanges();

                MessageBox.Show("Relative added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool UpdateRelative(string maNguoiThan, string maSinhVien, DateTime ngayTham, string tenNguoiThan, string diaChi, string soDienThoai)
        {
            try
            {
                int maNguoiThanID;

                if (!int.TryParse(maNguoiThan, out maNguoiThanID))
                {
                    MessageBox.Show("Invalid Relative ID. Please enter a valid integer.", "Invalid Relative ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                NguoiThan existingRelative = db.NguoiThans.FirstOrDefault(r => r.MaNT == maNguoiThanID);

                if (existingRelative == null)
                {
                    MessageBox.Show("Relative not found in the database.", "Relative Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int parsedMaSinhVien;

                if (!int.TryParse(maSinhVien, out parsedMaSinhVien))
                {
                    MessageBox.Show("Invalid Relative MaSV. Please enter a valid integer.", "Invalid Relative MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingRelative.MaSV = parsedMaSinhVien;
                existingRelative.NgayTham = ngayTham;
                existingRelative.Ten = tenNguoiThan;
                existingRelative.DiaChi = diaChi;
                existingRelative.DienThoai = soDienThoai;

                db.SaveChanges();

                MessageBox.Show("Relative updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the Relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRelative(string maNguoiThan)
        {
            try
            {
                if (string.IsNullOrEmpty(maNguoiThan))
                {
                    MessageBox.Show("Please enter a Relative ID to delete.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                int maNguoiThanID;

                if (!int.TryParse(maNguoiThan, out maNguoiThanID))
                {
                    MessageBox.Show("Invalid Relative ID. Please enter a valid integer.", "Invalid Relative ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                NguoiThan relativeToDelete = db.NguoiThans.FirstOrDefault(r => r.MaNT == maNguoiThanID);

                if (relativeToDelete == null)
                {
                    MessageBox.Show("Relative not found in the database.", "Relative Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.NguoiThans.Remove(relativeToDelete);
                db.SaveChanges();
                MessageBox.Show("Relative deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the Relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}