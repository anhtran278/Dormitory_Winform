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

        public List<THIETBI> SearchDevice(string searchDevice)
        {
            try
            {
                return db.THIETBIs
                    .Where(t => t.TenThietBi.Contains(searchDevice)
                             || t.TinhTrang.Contains(searchDevice))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for devices. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<THIETBI>();
            }
        }
        public bool AddDevice(string tenThietBi, int soLuong, string tinhTrang)
        {
            try
            {
                THIETBI existingDevice = db.THIETBIs.FirstOrDefault(d => d.TenThietBi.Equals(tenThietBi, StringComparison.OrdinalIgnoreCase));

                if (existingDevice != null)
                {
                    MessageBox.Show("Device with the same name already exists.", "Duplicate Device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                THIETBI newDevice = new THIETBI
                {
                    TenThietBi = tenThietBi,
                    SoLuong = soLuong,
                    TinhTrang = tinhTrang
                };

                db.THIETBIs.Add(newDevice);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool UpdateDevice(int maThietBi, string tenThietBi, int soLuong, string tinhTrang)
        {
            try
            {
                THIETBI deviceToUpdate = db.THIETBIs.FirstOrDefault(d => d.MaThietBi == maThietBi);

                if (deviceToUpdate == null)
                {
                    MessageBox.Show("Device not found for the given ID.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                deviceToUpdate.TenThietBi = tenThietBi;
                deviceToUpdate.SoLuong = soLuong;
                deviceToUpdate.TinhTrang = tinhTrang;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the device. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool DeleteDevice(int maThietBi)
        {
            try
            {
                THIETBI deviceToDelete = db.THIETBIs.FirstOrDefault(d => d.MaThietBi == maThietBi);

                if (deviceToDelete == null)
                {
                    MessageBox.Show("Device not found for the given ID.", "Device Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.THIETBIs.Remove(deviceToDelete);
                db.SaveChanges();

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