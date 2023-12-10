using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    internal class ConsumeService
    {
        private QuanLi_DormitoryEntities db;

        public ConsumeService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<HaoPhi> SearchConsume(string searchConsume)
        {
            try
            {
                return db.HaoPhis
                    .Where(c => c.MaThietBi.ToString().Contains(searchConsume)
                             || c.MaPhong.ToString().Contains(searchConsume))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for Consume. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<HaoPhi>();
            }
        }
        public bool AddConsume(string maThietBi, string maPhong, string tienBaoTriTB, string tienBaoTriPhong, string ngayHaoPhi)
        {
            try
            {
                if (!DateTime.TryParse(ngayHaoPhi, out DateTime parsedNgayHaoPhi))
                {
                    MessageBox.Show("Invalid date format for NgaySinh. Please enter a valid date.", "Invalid NgaySinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(maPhong, out int parsedMaPhong))
                {
                    MessageBox.Show("Invalid MaPhong. Please enter a valid integer.", "Invalid MaPhong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!int.TryParse(maThietBi, out int parsedMaTB))
                {
                    MessageBox.Show("Invalid MaThietBi. Please enter a valid integer.", "Invalid MaThietBi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(tienBaoTriTB, out decimal parsedTienBaoTriThietBi) ||
                    !decimal.TryParse(tienBaoTriPhong, out decimal parsedTienBaoTriPhong))
                {
                    MessageBox.Show("Invalid Consume amount. Please enter a valid decimal number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                HaoPhi newConsume = new HaoPhi
                {
                    MaPhong = parsedMaPhong,
                    MaThietBi = parsedMaTB,
                    TienBaoTriPhong = parsedTienBaoTriPhong,
                    TienBaoTriThietBi = parsedTienBaoTriThietBi,
                    NgayHaoPhi = parsedNgayHaoPhi,
                };

                db.HaoPhis.Add(newConsume);
                db.SaveChanges();

                MessageBox.Show("Consume added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Consume. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateConsume(string maThietBi, string maPhong, string tienBaoTriTB, string tienBaoTriPhong, string ngayHaoPhi)
        {
            try
            {
                if (!int.TryParse(maPhong, out int parsedMaPhong) || !int.TryParse(maThietBi, out int parsedMaThietBi))
                {
                    MessageBox.Show("Invalid MaPhong or MaThietBi. Please enter valid integers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                HaoPhi ConsumeToUpdate = db.HaoPhis.FirstOrDefault(Consume => Consume.MaPhong == parsedMaPhong && Consume.MaThietBi == parsedMaThietBi);

                if (ConsumeToUpdate == null)
                {
                    MessageBox.Show("Consume not found for the given MaPhong and MaThietBi.", "Consume Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!DateTime.TryParse(ngayHaoPhi, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayHaoPhi))
                {
                    MessageBox.Show("Invalid date format. Please enter a date in the format dd/MM/yyyy.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(tienBaoTriTB, out decimal parsedTienBaoTriTB) || !decimal.TryParse(tienBaoTriPhong, out decimal parsedTienBaoTriPhong))
                {
                    MessageBox.Show("Invalid Consume amount. Please enter valid decimal numbers.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ConsumeToUpdate.NgayHaoPhi = parsedNgayHaoPhi;
                ConsumeToUpdate.TienBaoTriPhong = parsedTienBaoTriPhong;
                ConsumeToUpdate.TienBaoTriThietBi = parsedTienBaoTriTB;

                db.SaveChanges();

                MessageBox.Show("Consume updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the Consume. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteConsume(string maThietBi, string maPhong)
        {
            try
            {
                if (!int.TryParse(maPhong, out int parsedMaPhong) || !int.TryParse(maThietBi, out int parsedMaThietBi))
                {
                    MessageBox.Show("Invalid MaPhong or MaThietBi. Please enter valid integers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                HaoPhi consumeToDelete = db.HaoPhis.FirstOrDefault(consume => consume.MaPhong == parsedMaPhong && consume.MaThietBi == parsedMaThietBi);

                if (consumeToDelete == null)
                {
                    MessageBox.Show("Consume not found for the given MaPhong and MaThietBi.", "Consume Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.HaoPhis.Remove(consumeToDelete);
                db.SaveChanges();

                MessageBox.Show("Consume deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the Consume. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
