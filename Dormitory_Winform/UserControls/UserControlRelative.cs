
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
            txtAddMaNTRelatives.Clear();
            txtAddTenRelatives.Clear();
            txtAddDiaChiRelatives.Clear();
            txtAddSoDTRelatives.Clear();
        }
        private void btnAddRelatives_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddMaNTRelatives.Text) || string.IsNullOrWhiteSpace(txtAddTenRelatives.Text) || string.IsNullOrWhiteSpace(txtAddDiaChiRelatives.Text) || string.IsNullOrWhiteSpace(txtAddDiaChiRelatives.Text) || string.IsNullOrWhiteSpace(txtAddSoDTRelatives.Text))
                {
                    MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (int.TryParse(cbBoxAddMaSvRelatives.SelectedItem?.ToString(), out int maSinhVien))
                {
                    bool check = relativesService.AddRelative(
                        txtAddMaNTRelatives.Text.Trim(),
                        maSinhVien,
                        dateTimeAddNgayThamRelatives.Value,
                        txtAddTenRelatives.Text.Trim(),
                        txtAddDiaChiRelatives.Text.Trim(),
                        txtAddSoDTRelatives.Text.Trim()
                    );

                    if (check)
                    {
                        MessageBox.Show("Relative added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add relative. Please check the values and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid MaSv value.", "Invalid MaSv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchMaNTRelatives_Leave(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void txtSearchMaNTRelatives_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMaNTRelatives.Text.Trim();

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
            bool check;

            if (!string.IsNullOrEmpty(txtUpAndDeMaNTRelatives.Text) && !string.IsNullOrEmpty(txtAddTenRelatives.Text))
            {
                if (!string.IsNullOrEmpty(txtUpAndDeMaSVRelatives.Text))
                {
                    try
                    {
                        if (IsDataValid())
                        {
                            check = relativesService.UpdateRelative(
                                txtUpAndDeMaNTRelatives.Text.Trim(),
                                txtUpAndDeMaSVRelatives.Text.Trim(),
                                dateTimeUpAnDeNgayThamRelatives.Value,
                                txtAddTenRelatives.Text.Trim(),
                                txtUpAndDeDiaChiRelatives.Text.Trim(),
                                txtUpAndDeSDTRelatives.Text.Trim()
                            );

                            if (check)
                            {
                                ClearFields();
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
                        MessageBox.Show("An error occurred during the update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid MaSv value.", "Invalid MaSv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool check;

            if (!string.IsNullOrEmpty(txtUpAndDeMaNTRelatives.Text))
            {
                check = relativesService.DeleteRelative(txtUpAndDeMaNTRelatives.Text.Trim());

                if (check)
                {
                    ClearFields();
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please enter a Relative ID to delete.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRelatives_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRelatives.Rows[e.RowIndex];
                txtUpAndDeMaNTRelatives.Text = row.Cells[0].Value.ToString();
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