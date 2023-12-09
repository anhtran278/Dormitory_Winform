using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.UserControls
{
    public partial class UserControlDevice : UserControl
    {
        QuanLi_DormitoryEntities db;
        DevicesService devicesService;
        private BindingSource bindingSource;
        public UserControlDevice()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            devicesService = new DevicesService(db);
            bindingSource = new BindingSource();
            dataGridViewDevices.DataSource = bindingSource;
            dataGridViewDevices.AutoGenerateColumns = false;
        }

    }
}