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
    public partial class UserControlConsume : UserControl
    {
        QuanLi_DormitoryEntities db;
        ConsumeService consumeService;
        private BindingSource bindingSource;

        public UserControlConsume()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            consumeService = new ConsumeService(db);
            bindingSource = new BindingSource();
            dataGridViewConsume.DataSource = bindingSource;
            dataGridViewConsume.AutoGenerateColumns = false;
        }

    }
}