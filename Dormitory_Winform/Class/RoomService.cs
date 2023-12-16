using Dormitory_Winform.Class;
using Dormitory_Winform;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Globalization;

namespace Dormitory_Winform.Class
{
    public class RoomService
    {
        private QuanLi_DormitoryEntities db;

        public RoomService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<PHONG> SearchRoom(string searchRoom)
        {
            try
            {
                return db.PHONGs
                    .Where(r => r.MaPhong.ToString().Contains(searchRoom)
                             || r.GiaPhong.ToString().Contains(searchRoom)
                             || r.TrangThaiPhong.ToString().Contains(searchRoom))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for rooms. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PHONG>();
            }
        }

        public bool AddRoom(string maPhong, string giaPhong, string trangThai)
        {
            try
            {
                PHONG newPhong = new PHONG
                {
                    GiaPhong = decimal.Parse(giaPhong),
                    MaPhong = maPhong,
                    TrangThaiPhong = trangThai,
                };

                db.PHONGs.Add(newPhong);
                db.SaveChanges();

                MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateRoom(string maPhong, string giaPhong)
        {
            try
            {
                // Bỏ qua việc kiểm tra int.TryParse vì maPhong là một chuỗi
                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Please first select a room from the table.", "Selection of Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                PHONG existingRoom = db.PHONGs.FirstOrDefault(p => p.MaPhong == maPhong);

                if (existingRoom == null)
                {
                    MessageBox.Show("Room not found in the database.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                decimal parsedGiaPhong;
                if (!decimal.TryParse(giaPhong, out parsedGiaPhong))
                {
                    MessageBox.Show("Invalid GiaPhong. Please enter a valid decimal number.", "Invalid GiaPhong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingRoom.GiaPhong = parsedGiaPhong;

                db.SaveChanges();

                MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteRoom(string maPhong)
        {
            try
            {
                PHONG roomToDelete = db.PHONGs.FirstOrDefault(p => p.MaPhong == maPhong);

                if (roomToDelete != null)
                {
                    db.PHONGs.Remove(roomToDelete);
                    db.SaveChanges();

                    MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    MessageBox.Show("Room not found in the database.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}