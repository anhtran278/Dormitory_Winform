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
    public partial class UserControlFee : UserControl
    {
        QuanLi_DormitoryEntities db;
        FeeService feeService;
        private BindingSource bindingSource;
        public UserControlFee()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            feeService = new FeeService(db);
            bindingSource = new BindingSource();
            dataGridViewFee.DataSource = bindingSource;
            dataGridViewFee.AutoGenerateColumns = false;
        }

        private void UserControlRooms_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddMaSVFee.SelectedIndex = -1;
            GetMaSVIntoComboBox();
        }
        public void GetMaSVIntoComboBox()
        {
            List<string> maSVList = db.SinhViens
            .Where(s => s.TrangThaiDki == "Duyet")
            .Select(s => s.MaSV.ToString())
            .ToList();

            cbBoxAddMaSVFee.Items.Clear();
            foreach (string maSV in maSVList)
            {
                cbBoxAddMaSVFee.Items.Add(maSV);
            }
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                if (dataGridViewFee == null)
                {
                    return;
                }

                var data = db.KhoanPhis.ToList();

                if (data == null)
                {
                    return;
                }

                bindingSource.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                db.SaveChanges();
                loadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Clear()
        {
            cbBoxAddMaSVFee.SelectedIndex = -1;
            txtAddMaKPFee.Clear();
            txtAddTienPhongFee.Clear();
            txtAddTienDienNuocFee.Clear();
            txtAddMaKPFee.Clear();
            dateTimeAddNgayThanhToanFee.Value = DateTime.Now;
            tabControlFee.SelectedTab = tabPageAddFee;
        }





        
    }
}
