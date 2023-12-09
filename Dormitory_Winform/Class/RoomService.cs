using Dormitory_Winform.Class;
using Dormitory_Winform;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Dormitory_Winform.Class
{
    public class RoomService
    {
        private QuanLi_DormitoryEntities db;

        public RoomService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<Phong> SearchRoom(string searchRoom)
        {
            try
            {
                return db.Phongs
                    .Where(r => r.MaPhong.ToString().Contains(searchRoom)
                             || r.LoaiPhong.Contains(searchRoom)
                             || r.KiHieu.Contains(searchRoom)
                             || r.GiaPhong.ToString().Contains(searchRoom))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for rooms. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Phong>();
            }
        }

        public bool AddRoom(string maPhong, string loaiPhong, string maSV, string kiHieu, string giaPhong)
        {
            try
            {
                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong))
                {
                    MessageBox.Show("Invalid Room ID. Please enter a valid integer.", "Invalid Room ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (db.Phongs.Any(u => u.MaPhong == parsedMaPhong))
                {
                    MessageBox.Show("Room already exists. Please choose a different Room ID.", "Duplicate Room ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                int parsedMaSV;
                if (!int.TryParse(maSV, out parsedMaSV))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                Phong newPhong = new Phong
                {
                    MaPhong = parsedMaPhong,
                    MaSV = parsedMaSV, 
                    KiHieu = kiHieu,
                    LoaiPhong = loaiPhong,
                    GiaPhong = decimal.Parse(giaPhong) 
                };

                db.Phongs.Add(newPhong);
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
        public bool UpdateRoom(string maPhong, string loaiPhong, string maSV, string kiHieu, string giaPhong)
        {
            try
            {
                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong) || parsedMaPhong <= 0)
                {
                    MessageBox.Show("Please first select a room from the table.", "Selection of Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                Phong existingRoom = db.Phongs.Find(parsedMaPhong);

                if (existingRoom == null)
                {
                    MessageBox.Show("Room not found in the database.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingRoom.LoaiPhong = loaiPhong;
                existingRoom.KiHieu = kiHieu;

                int parsedMaSV;
                if (!int.TryParse(maSV, out parsedMaSV))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingRoom.MaSV = parsedMaSV;

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

                Phong roomToDelete = db.Phongs.Find(parsedMaPhong);

                if (roomToDelete == null)
                {
                    MessageBox.Show("Room not found in the database.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.Phongs.Remove(roomToDelete);
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