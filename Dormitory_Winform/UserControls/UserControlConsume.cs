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
        private void UserControlConsume_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
            cbBoxAddMaThietBiConsume.SelectedIndex = -1;
            cbBoxAddMaPhongConsume.SelectedIndex = -1;
            GetMaThietBiIntoComboBox();
            GetMaPhongIntoComboBox();
        }
        public void GetMaThietBiIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> maThietBiList = db.THIETBIs
                    .Select(s => s.MaThietBi.ToString())
                    .ToList();

                if (cbBoxAddMaThietBiConsume == null)
                {
                    return;
                }

                cbBoxAddMaThietBiConsume.Items.Clear();
                foreach (string maTB in maThietBiList)
                {
                    cbBoxAddMaThietBiConsume.Items.Add(maTB);
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

                List<string> maPhongList = db.PHONGs
                    .Select(s => s.MaPhong.ToString())
                    .ToList();

                if (cbBoxAddMaPhongConsume == null)
                {
                    return;
                }

                cbBoxAddMaPhongConsume.Items.Clear();
                foreach (string maPhong in maPhongList)
                {
                    cbBoxAddMaPhongConsume.Items.Add(maPhong);
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

                var data = db.HAOPHIs.ToList();

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
            cbBoxAddMaPhongConsume.SelectedIndex = -1;
            cbBoxAddMaThietBiConsume.SelectedIndex = -1;
            txtAddTienBaoTriPhongConsume.Clear();
            txtAddTienBaoTriThietBiConsume.Clear();
            tabControlConsume.SelectedTab = tabPageAddConsume;
        }

        private void Clear1()
        {
            txtUpAndDeMaPhongConsume.Clear();
            txtUpAndDeMaThietBiConsume.Clear();
            txtUpAndDeTienBaoTriPhongConsume.Clear();
            txtUpAndDeTienBaoTriThietBiConsume.Clear();
        }

        private void tabPageAddConsume_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearchMaThietBiPhongConsume_Leave(object sender, EventArgs e)
        {
            txtSearchMaThietBiPhongConsume.Clear();
        }

        private void tabPageUpDeConsume_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtSearchMaThietBiPhongConsum_TextChanged(object sender, EventArgs e)
        {
            string searchMaTBPhong = txtSearchMaThietBiPhongConsume.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaTBPhong))
            {
                List<HAOPHI> searchResult = consumeService.SearchConsume(searchMaTBPhong);
                bindingSource.DataSource = searchResult;
            }
            else
            {
                RefreshDataGridView();
            }
        }
        private void btnAddConsume_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbBoxAddMaPhongConsume.Text) &&
                !string.IsNullOrEmpty(cbBoxAddMaThietBiConsume.Text) && 
                !string.IsNullOrEmpty(txtAddTienBaoTriPhongConsume.Text) &&
                !string.IsNullOrEmpty(txtAddTienBaoTriThietBiConsume.Text))
            {
                bool check = consumeService.AddConsume(
                    cbBoxAddMaPhongConsume.Text.Trim(),
                    cbBoxAddMaThietBiConsume.Text.Trim(),
                    txtAddTienBaoTriPhongConsume.Text.Trim(),
                    txtAddTienBaoTriThietBiConsume.Text.Trim(),
                    dateTimeAddNgayHaoPhiConsume.Text.Trim());
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

        private void btnUpdateConsume_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpAndDeMaPhongConsume.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeMaThietBiConsume.Text) &&
                !string.IsNullOrEmpty(dateTimeUpAndDeNgayHaoPhiConsume.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienBaoTriPhongConsume.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeTienBaoTriThietBiConsume.Text))
            {
                bool check = consumeService.UpdateConsume(
                    txtUpAndDeMaPhongConsume.Text.Trim(),
                    txtUpAndDeMaThietBiConsume.Text.Trim(),
                    txtUpAndDeTienBaoTriPhongConsume.Text.Trim(),
                    txtUpAndDeTienBaoTriThietBiConsume.Text.Trim(),
                    dateTimeUpAndDeNgayHaoPhiConsume.Text.Trim());

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

        private void btnDeleteConsume_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUpAndDeMaPhongConsume.Text) &&
                !string.IsNullOrEmpty(txtUpAndDeMaThietBiConsume.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this consume?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool check = consumeService.DeleteConsume(txtUpAndDeMaThietBiConsume.Text.Trim(),
                    txtUpAndDeMaPhongConsume.Text.Trim());

                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a consume record to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewConsume_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewConsume.Rows[e.RowIndex];
                txtUpAndDeMaPhongConsume.Text = row.Cells[1].Value.ToString();
                txtUpAndDeMaThietBiConsume.Text = row.Cells[2].Value.ToString();
                txtUpAndDeTienBaoTriPhongConsume.Text = row.Cells[3].Value.ToString();
                txtUpAndDeTienBaoTriThietBiConsume.Text = row.Cells[4].Value.ToString();
                dateTimeUpAndDeNgayHaoPhiConsume.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            }
        }
    }
}