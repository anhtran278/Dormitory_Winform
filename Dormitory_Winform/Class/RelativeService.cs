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

        public bool AddRelative(int studentID, DateTime visitDate, string relativeName, string address, string phoneNumber)
        {
            try
            {
                NguoiThan newRelative = new NguoiThan
                {
                    MaSV = studentID,
                    Ten = relativeName,
                    NgayTham = visitDate,
                    DiaChi = address,
                    DienThoai = phoneNumber
                };

                db.NguoiThans.Add(newRelative);
                db.SaveChanges();

                MessageBox.Show("Relative added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateRelative(int maSinhVien, DateTime ngayTham, string tenNguoiThan, string diaChi, string soDienThoai)
        {
            try
            {
                NguoiThan relativeToUpdate = db.NguoiThans.FirstOrDefault(r => r.MaSV == maSinhVien);

                if (relativeToUpdate == null)
                {
                    MessageBox.Show("Relative not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                relativeToUpdate.NgayTham = ngayTham;
                relativeToUpdate.Ten = tenNguoiThan;
                relativeToUpdate.DiaChi = diaChi;
                relativeToUpdate.DienThoai = soDienThoai;

                db.SaveChanges();

                MessageBox.Show("Relative updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteRelative(string maNguoiThan)
        {
            try
            {
                int maSinhVien = int.Parse(maNguoiThan);

                NguoiThan relativeToDelete = db.NguoiThans.FirstOrDefault(r => r.MaSV == maSinhVien);

                if (relativeToDelete == null)
                {
                    MessageBox.Show("Relative not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                db.NguoiThans.Remove(relativeToDelete);
                db.SaveChanges();

                MessageBox.Show("Relative deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the relative. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}