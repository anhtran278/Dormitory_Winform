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
    public partial class UserControlIntoRoom : UserControl
    {
        QuanLi_DormitoryEntities db;
        IntoRoomService intoRoomService;
        private BindingSource bindingSource;

        public UserControlIntoRoom()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            intoRoomService = new IntoRoomService(db);
            bindingSource = new BindingSource();
            dataGridViewIntoRoom.DataSource = bindingSource;
            dataGridViewIntoRoom.AutoGenerateColumns = false;
        }
        private void UserControlIntoRoom_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            GetMaSVIntoComboBox();
            GetMaPhongIntoComboBox();
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.SINHVIENVAOPHONGs.ToList();

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
        public void GetMaSVIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maSVList = db.SINHVIENs
                    .Where(s => s.TrangThaiDki == "Duyet")
                    .Select(s => s.MaSV.ToString() + " - " + s.LoaiPhongSVDangKi)
                    .ToList();

                if (cbBoxAddMaSVIntoRoom == null)
                {
                    return;
                }

                cbBoxAddMaSVIntoRoom.Items.Clear();
                foreach (string maSV in maSVList)
                {
                    cbBoxAddMaSVIntoRoom.Items.Add(maSV);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }
        public void GetMaPhongIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maSVList = db.SINHVIENs
                    .Where(s => s.TrangThaiDki == "Duyet")
                    .Select(s => s.MaSV.ToString())
                    .ToList();

                if (cbBoxAddMaSVIntoRoom == null)
                {
                    return;
                }

                cbBoxAddMaSVIntoRoom.Items.Clear();
                foreach (string maSV in maSVList)
                {
                    cbBoxAddMaSVIntoRoom.Items.Add(maSV);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            db.SaveChanges();
            loadDataIntoDataGridView();
        }

        public void Clear()
        {
            cbBoxAddLoaiPhongDkiIntoRoom.SelectedIndex = 0;
            cbBoxAddMaPhongIntoRoom.SelectedIndex = 0;
            cbBoxAddMaSVIntoRoom.SelectedIndex = 0;
            dateTimeAddNgayVaoIntoRoom.Value = DateTime.Now;
            tabControlIntoRoom.SelectedTab = tabPageAddIntoRoom;
        }
        private void Clear1()
        {
            cbBoxUpAndDeLoaiPhongDkiIntoRoom.SelectedIndex = 0;
            cbBoxUpAndDeMaPhongIntoRoom.SelectedIndex = 0;
            cbBoxUpAndDeMaSVIntoRoom.SelectedIndex = 0;
            dateTimeUpAndDeNgayVaoIntoRoom.Value = DateTime.Now;
        }

        private void tabPageAddIntoRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtSearchIntoRoom_Leave(object sender, EventArgs e)
        {
            txtSearchIntoRoom.Clear();
        }
        private void tabPageUpDeIntoRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
        private void txtSearchIntoRoom_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchIntoRoom.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
            }
            else
            {
                var intoRoomhResult = intoRoomService.SearchIntoRoom(searchText);
                bindingSource.DataSource = intoRoomhResult;
            }
        }
    }
}
