using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    internal class FeeService
    {
        private QuanLi_DormitoryEntities db;

        public FeeService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<KHOANPHI> SearchFee(string searchFee)
        {
            try
            {
                return db.KHOANPHIs
                    .Where(r => r.MaKhoanPhi.ToString().Contains(searchFee)
                             || r.MaSV.ToString().Contains(searchFee))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for Fees. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<KHOANPHI>();
            }
        }
        public bool AddFee(string ngayThanhToan, string tienPhong, string maSV, string tienDienNuoc, string tienInternet, string tienGuiXe)
        {
            try
            {
                if (!DateTime.TryParse(ngayThanhToan, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayThanhToan))
                {
                    MessageBox.Show("Invalid date format. Please enter a date in the format dd/MM/yyyy.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(maSV, out int parsedMaSV))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(tienPhong, out decimal parsedTienPhong) ||
                    !decimal.TryParse(tienDienNuoc, out decimal parsedTienDienNuoc) ||
                    !decimal.TryParse(tienInternet, out decimal parsedTienInternet) ||
                    !decimal.TryParse(tienGuiXe, out decimal parsedTienGuiXe))
                {
                    MessageBox.Show("Invalid fee amount. Please enter a valid decimal number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                KHOANPHI newFee = new KHOANPHI
                {
                    NgayThanhToan = parsedNgayThanhToan,
                    MaSV = parsedMaSV,
                    TienPhong = parsedTienPhong,
                    TienDienVaNuoc = parsedTienDienNuoc,
                    TienInternet = parsedTienInternet,
                    TienGuiXe = parsedTienGuiXe
                };

                db.KHOANPHIs.Add(newFee);
                db.SaveChanges();

                MessageBox.Show("Fee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the fee. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateFee(string maSV, string ngayThanhToan, string tienPhong, string tienDienNuoc, string tienInternet, string tienGuiXe)
        {
            try
            {
                int parsedMaSV;
                if (!int.TryParse(maSV, out parsedMaSV))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                KHOANPHI feeToUpdate = db.KHOANPHIs.FirstOrDefault(fee => fee.MaSV == parsedMaSV);

                if (feeToUpdate == null)
                {
                    MessageBox.Show("Fee not found for the given MaSV.", "Fee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!DateTime.TryParse(ngayThanhToan, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayThanhToan))
                {
                    MessageBox.Show("Invalid date format. Please enter a date in the format dd/MM/yyyy.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(tienPhong, out decimal parsedTienPhong) || !decimal.TryParse(tienDienNuoc, out decimal parsedTienDienNuoc) ||
                    !decimal.TryParse(tienInternet, out decimal parsedTienInternet) || !decimal.TryParse(tienGuiXe, out decimal parsedTienGuiXe))
                {
                    MessageBox.Show("Invalid fee amount. Please enter a valid decimal number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                feeToUpdate.NgayThanhToan = parsedNgayThanhToan;
                feeToUpdate.TienPhong = parsedTienPhong;
                feeToUpdate.TienDienVaNuoc = parsedTienDienNuoc;
                feeToUpdate.TienInternet = parsedTienInternet;
                feeToUpdate.TienGuiXe = parsedTienGuiXe;

                db.SaveChanges();

                MessageBox.Show("Fee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the fee. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteFee(string maSV)
        {
            try
            {
                if (!int.TryParse(maSV, out int parsedMaSV))
                {
                    MessageBox.Show("Invalid MaSV. Please enter a valid integer.", "Invalid MaSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                KHOANPHI feeToDelete = db.KHOANPHIs.FirstOrDefault(fee => fee.MaSV == parsedMaSV);

                if (feeToDelete == null)
                {
                    MessageBox.Show("Fee not found for the given MaSV.", "Fee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.KHOANPHIs.Remove(feeToDelete);
                db.SaveChanges();

                MessageBox.Show("Fee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the fee. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
    }
}
