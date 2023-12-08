using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Winform.Class
{
    internal class FeeService
    {
        private QuanLi_DormitoryEntities db;

        public FeeService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }
    }
}
