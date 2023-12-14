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

        public bool AddRoom(string maPhong, string loaiPhong, string giaPhong, string trangThai)
        {
            try
            {
                PHONG newPhong = new PHONG
                {
                    GiaPhong = decimal.Parse(giaPhong),
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
        public bool UpdateRoom(string maPhong, string giaPhong, string trangThai)
        {
            try
            {
                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong) || parsedMaPhong <= 0)
                {
                    MessageBox.Show("Please first select a room from the table.", "Selection of Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                PHONG existingRoom = db.PHONGs.Find(parsedMaPhong);

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
                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong) || parsedMaPhong <= 0)
                {
                    MessageBox.Show("Please first select a room from the table.", "Selection of Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                PHONG roomToDelete = db.PHONGs.Find(parsedMaPhong);

                if (roomToDelete == null)
                {
                    MessageBox.Show("Room not found in the database.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.PHONGs.Remove(roomToDelete);
                db.SaveChanges();

                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the room. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}