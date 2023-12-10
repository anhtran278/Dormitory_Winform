using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    public class DeviceService
    {
        private QuanLi_DormitoryEntities db;

        public DeviceService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }

        public List<ThietBi> SearchDevice(string searchDevice)
        {
            try
            {
                return db.ThietBis
                    .Where(t => t.TenThietBi.Contains(searchDevice)
                             || t.TinhTrang.Contains(searchDevice))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for devices. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ThietBi>();
            }
        }

        public bool AddDevice(string tenThietBi, string maPhong, string soLuong, string tinhTrang)
        {
            try
            {
                if (!int.TryParse(maPhong, out int parsedMaPhong) || !int.TryParse(soLuong, out int parsedSoLuong))
                {
                    MessageBox.Show("Invalid input. Please enter valid integers for MaPhong and SoLuong.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ThietBi newDevice = new ThietBi
                {
                    TenThietBi = tenThietBi,
                    MaPhong = parsedMaPhong,
                    SoLuong = parsedSoLuong,
                    TinhTrang = tinhTrang
                };

                db.ThietBis.Add(newDevice);
                db.SaveChanges();

                MessageBox.Show("Device added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Device. Error details: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateDevice(string tenThietBi, string maPhong, string soLuong, string tinhTrang)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tenThietBi))
                {
                    MessageBox.Show("Invalid TenThietBi. Please enter a valid device name.");
                    return false;
                }

                if (!int.TryParse(maPhong, out int parsedMaPhong) || !int.TryParse(soLuong, out int parsedSoLuong))
                {
                    MessageBox.Show("Invalid input. Please enter valid integers for MaPhong and SoLuong.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ThietBi deviceToUpdate = db.ThietBis.FirstOrDefault(d => d.TenThietBi == tenThietBi);

                if (deviceToUpdate == null)
                {
                    MessageBox.Show("Device not found for the given name.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                deviceToUpdate.MaPhong = parsedMaPhong;
                deviceToUpdate.SoLuong = parsedSoLuong;
                deviceToUpdate.TinhTrang = tinhTrang;

                db.SaveChanges();

                MessageBox.Show("Device updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the Device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteDevice(string tenThietBi)
        {
            try
            {
                ThietBi deviceToDelete = db.ThietBis.FirstOrDefault(d => d.TenThietBi == tenThietBi);

                if (deviceToDelete == null)
                {
                    MessageBox.Show("Device not found for the given name.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.ThietBis.Remove(deviceToDelete);
                db.SaveChanges();

                MessageBox.Show("Device deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the Device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}