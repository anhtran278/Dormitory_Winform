using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Winform.Class
{
    internal class ConsumeService
    {
        private QuanLi_DormitoryEntities db;
        public ConsumeService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
    }
}
