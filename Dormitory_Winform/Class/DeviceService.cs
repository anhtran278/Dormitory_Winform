using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    public class DevicesService
    {
        private QuanLi_DormitoryEntities db;

        public DevicesService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }

        public List<ThietBi> SearchDevice(string keyword)
        {
            try
            {
                return db.ThietBis
                    .Where(t => t.MaThietBi.ToString().Contains(keyword)
                             || t.TenThietBi.Contains(keyword)
                             || t.SoLuong.ToString().Contains(keyword)
                             || t.TinhTrang.Contains(keyword))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for devices. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ThietBi>();
            }
        }

        public bool AddDevice(string maThietBi, string tenThietBi, string maPhong, int soLuong, string tinhTrang)
        {
            try
            {
                int parsedMaThietBi;
                if (!int.TryParse(maThietBi, out parsedMaThietBi))
                {
                    MessageBox.Show("Invalid Device ID. Please enter a valid integer.", "Invalid Device ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (db.ThietBis.Any(u => u.MaThietBi == parsedMaThietBi))
                {
                    MessageBox.Show("Device already exists. Please choose a different Device ID.", "Duplicate Device ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong))
                {
                    MessageBox.Show("Invalid SoLuong. Please enter a valid integer.", "Invalid SoLuong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ThietBi newDevice = new ThietBi
                {
                    MaThietBi = parsedMaThietBi,
                    TenThietBi = tenThietBi,
                    MaPhong = parsedMaPhong,
                    SoLuong = soLuong,
                    TinhTrang = tinhTrang
                };

                db.ThietBis.Add(newDevice);
                db.SaveChanges();

                MessageBox.Show("Device added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateDevice(string maThietBi, string tenThietBi, string maPhong, string soLuong, string tinhTrang)
        {
            try
            {
                int parsedMaThietBi;
                if (!int.TryParse(maThietBi, out parsedMaThietBi) || parsedMaThietBi <= 0)
                {
                    MessageBox.Show("Please first select a device from the table.", "Selection of Device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                ThietBi existingDevice = db.ThietBis.Find(parsedMaThietBi);

                if (existingDevice == null)
                {
                    MessageBox.Show("Device not found in the database.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingDevice.TenThietBi = tenThietBi;
                existingDevice.TinhTrang = tinhTrang;

                int parsedMaPhong;
                if (!int.TryParse(maPhong, out parsedMaPhong))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingDevice.MaPhong = parsedMaPhong;

                int parsedSoLuong;
                if (!int.TryParse(soLuong, out parsedSoLuong))
                {
                    MessageBox.Show("Invalid SoLuong. Please enter a valid decimal number.", "Invalid GiaPhong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existingDevice.SoLuong = parsedSoLuong;

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

        public bool DeleteDevice(string maThietBi)
        {
            try
            {
                int parsedMaThietBi;
                if (!int.TryParse(maThietBi, out parsedMaThietBi) || parsedMaThietBi <= 0)
                {
                    MessageBox.Show("Please first select a device from the table.", "Selection of Device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                ThietBi deviceToDelete = db.ThietBis.Find(parsedMaThietBi);

                if (deviceToDelete == null)
                {
                    MessageBox.Show("Device not found in the database.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                db.ThietBis.Remove(deviceToDelete);
                db.SaveChanges();

                MessageBox.Show("Device deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}