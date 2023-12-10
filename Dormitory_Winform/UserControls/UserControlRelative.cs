
using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dormitory_Winform.UserControls
{

    public partial class UserControlRelative : UserControl
    {
        QuanLi_DormitoryEntities db;
        RelativeService relativesService;
        private BindingSource bindingSource;

        public UserControlRelative()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            relativesService = new RelativeService(db);
            bindingSource = new BindingSource();
            dataGridViewRelatives.DataSource = bindingSource;
            dataGridViewRelatives.AutoGenerateColumns = false;

        }
        private void UserControlRelatives_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            GetMaSVIntoComboBox();
        }
        public void GetMaSVIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maSVList = db.SinhViens
                    .Where(s => s.TrangThaiDki == "Duyet")
                    .Select(s => s.MaSV.ToString())
                    .ToList();

                if (cbBoxAddMaSvRelatives == null)
                {
                    return;
                }

                cbBoxAddMaSvRelatives.Items.Clear();
                foreach (string maSV in maSVList)
                {
                    cbBoxAddMaSvRelatives.Items.Add(maSV);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }
                var data = db.NguoiThans.ToList();

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
            LoadDataIntoDataGridView();
        }
        public void ClearFields()
        {
            txtAddTenRelatives.Clear();
            txtAddDiaChiRelatives.Clear();
            txtAddSoDTRelatives.Clear();
        }
        public void ClearFields1()
        {
            txtUpAndDeTenRelatives.Clear();
            txtUpAndDeDiaChiRelatives.Clear();
            txtAddSoDTRelatives.Clear();
        }
        private void btnAddRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbBoxAddMaSvRelatives.Text) &&
                    !string.IsNullOrEmpty(txtAddTenRelatives.Text) &&
                    !string.IsNullOrEmpty(txtAddDiaChiRelatives.Text) &&
                    !string.IsNullOrEmpty(txtAddSoDTRelatives.Text))
                {
                    int studentID = int.Parse(cbBoxAddMaSvRelatives.Text);
                    DateTime visitDate = dateTimeAddNgayThamRelatives.Value; 
                    string relativeName = txtAddTenRelatives.Text.Trim();
                    string address = txtAddDiaChiRelatives.Text.Trim();
                    string phoneNumber = txtAddSoDTRelatives.Text.Trim();

                    bool check = relativesService.AddRelative(studentID, visitDate, relativeName, address, phoneNumber);

                    if (check)
                    {
                        ClearFields();
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.", "Required Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void txtSearchMaNTRelatives_Leave(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void txtSearchMaNTRelatives_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMaSVRelatives.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
            }
            else
            {
                var searchResult = relativesService.SearchRelatives(searchText);
                bindingSource.DataSource = searchResult;
            }
        }
        private void btnUpdateRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUpAndDeMaSVRelatives.Text) &&
                    !string.IsNullOrEmpty(txtUpAndDeTenRelatives.Text) &&
                    !string.IsNullOrEmpty(txtUpAndDeDiaChiRelatives.Text) &&
                    !string.IsNullOrEmpty(txtUpAndDeSDTRelatives.Text))
                {
                    int maSinhVien = int.Parse(txtUpAndDeMaSVRelatives.Text);
                    DateTime ngayTham = dateTimeUpAnDeNgayThamRelatives.Value;
                    string tenNguoiThan = txtUpAndDeTenRelatives.Text.Trim();
                    string diaChi = txtUpAndDeDiaChiRelatives.Text.Trim();
                    string soDienThoai = txtUpAndDeSDTRelatives.Text.Trim();

                    bool check = relativesService.UpdateRelative(maSinhVien, ngayTham, tenNguoiThan, diaChi, soDienThoai);

                    if (check)
                    {
                        ClearFields1();
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(txtUpAndDeDiaChiRelatives.Text) || string.IsNullOrEmpty(txtUpAndDeSDTRelatives.Text))
            {
                return false;
            }
            return true;
        }

        private void btnDeleteRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUpAndDeMaSVRelatives.Text))
                {
                    int maSinhVien = int.Parse(txtUpAndDeMaSVRelatives.Text);

                    bool check = relativesService.DeleteRelative(maSinhVien.ToString());

                    if (check)
                    {
                        ClearFields1();
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a relative to delete.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void dataGridViewRelatives_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRelatives.Rows[e.RowIndex];
                txtUpAndDeMaSVRelatives.Text = row.Cells[1].Value.ToString();
                txtUpAndDeTenRelatives.Text = row.Cells[2].Value.ToString();
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayTham))
                {
                    dateTimeUpAnDeNgayThamRelatives.Value = ngayTham;
                }
                txtUpAndDeSDTRelatives.Text = row.Cells[4].Value.ToString();
                txtUpAndDeDiaChiRelatives.Text = row.Cells[5].Value.ToString();

            }
        }
    }

}