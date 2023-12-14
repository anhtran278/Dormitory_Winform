using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.Class
{
    internal class IntoRoomService
    {
        private QuanLi_DormitoryEntities db;

        public IntoRoomService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
        public List<SINHVIENVAOPHONG> SearchIntoRoom(string searchIntoRoom)
        {
            try
            {
                return db.SINHVIENVAOPHONGs
                    .Where(r => r.MaPhong.ToString().Contains(searchIntoRoom)
                             || r.MaSV.ToString().Contains(searchIntoRoom))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for Fees. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SINHVIENVAOPHONG>();
            }
        }
    }
}
