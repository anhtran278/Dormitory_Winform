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

        private void UserControlFee_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddMaSVFee.SelectedIndex = -1;
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

                List<string> maSVList = db.SINHVIENs
                    .Where(s => s.TrangThaiDki == "Duyet")
                    .Select(s => s.MaSV.ToString())
                    .ToList();

                if (cbBoxAddMaSVFee == null)
                {
                    return;
                }

                cbBoxAddMaSVFee.Items.Clear();
                foreach (string maSV in maSVList)
                {
                    cbBoxAddMaSVFee.Items.Add(maSV);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while populating the ComboBox. Error details: " + ex.Message);
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

                var data = db.KHOANPHIs.ToList();

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
            txtAddTienPhongFee.Clear();
            txtAddTienDienNuocFee.Clear();
            txtAddTienInternetFee.Clear();
            txtAddTienGuiXeFee.Clear();
            dateTimeAddNgayThanhToanFee.Value = DateTime.Now;
            tabControlFee.SelectedTab = tabPageAddFee;
        }

        private void Clear1()
        {
            txtUpAndDeMaSVFee.Clear();
            txtUpAndDeTienPhongFee.Clear();
            txtUpAndDeTienDienNuocFee.Clear();
            txtUpAndDeTienInternetFee.Clear();
            txtUpAndDeTienGuiXeFee.Clear();
            dateTimeAddNgayThanhToanFee.Value = DateTime.Now;
        }

        private void tabPageAddFee_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearchMaKPFee_Leave(object sender, EventArgs e)
        {
            txtSearchMaKPFee.Clear();
        }

        private void tabPageUpDeFee_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtSearchMaKPFee_TextChanged(object sender, EventArgs e)
        {
            string searchKhoanPhi = txtSearchMaKPFee.Text.Trim();

            if (!string.IsNullOrEmpty(searchKhoanPhi))
            {
                List<KHOANPHI> searchResult = feeService.SearchFee(searchKhoanPhi);
                bindingSource.DataSource = searchResult;
            }
            else
            {
                RefreshDataGridView();
            }
        }
        private void btnAddFee_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAddTienPhongFee.Text) &&
                !string.IsNullOrEmpty(cbBoxAddMaSVFee.Text) && 
                !string.IsNullOrEmpty(txtAddTienDienNuocFee.Text) &&
                !string.IsNullOrEmpty(txtAddTienInternetFee.Text) && 
                !string.IsNullOrEmpty(txtAddTienGuiXeFee.Text))
            {
                bool check = feeService.AddFee(
                    dateTimeAddNgayThanhToanFee.Text.Trim(),
                    txtAddTienPhongFee.Text.Trim(), 
                    cbBoxAddMaSVFee.Text.Trim(), 
                    txtAddTienDienNuocFee.Text.Trim(), 
                    txtAddTienInternetFee.Text.Trim(), 
                    txtAddTienGuiXeFee.Text.Trim());
                if (check)
                {
                    Clear(); 
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnUpdateFee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dateTimeUpAndDeNgayThanhToanFee.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienPhongFee.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeMaSVFee.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienDienNuocFee.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienInternetFee.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienGuiXeFee.Text))
            {
                bool check = feeService.UpdateFee(
                    txtUpAndDeMaSVFee.Text.Trim(),
                    dateTimeUpAndDeNgayThanhToanFee.Text.Trim(),
                    txtUpAndDeTienPhongFee.Text.Trim(),
                    txtUpAndDeTienInternetFee.Text.Trim(),
                    txtUpAndDeTienGuiXeFee.Text.Trim(),
                    txtUpAndDeTienDienNuocFee.Text.Trim());

                if (check)
                {
                    Clear1();
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteFee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpAndDeMaSVFee.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Fee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool check = feeService.DeleteFee(txtUpAndDeMaSVFee.Text.Trim());

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a fee to delete.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewFee.Rows[e.RowIndex];
                txtUpAndDeMaSVFee.Text = row.Cells[1].Value.ToString();
                dateTimeUpAndDeNgayThanhToanFee.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txtUpAndDeTienPhongFee.Text = row.Cells[3].Value.ToString();
                txtUpAndDeTienInternetFee.Text = row.Cells[4].Value.ToString();
                txtUpAndDeTienGuiXeFee.Text= row.Cells[5].Value.ToString();
                txtUpAndDeTienDienNuocFee.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
