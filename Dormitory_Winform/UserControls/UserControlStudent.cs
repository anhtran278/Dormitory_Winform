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
    public partial class UserControlStudent : UserControl
    {
        QuanLi_DormitoryEntities db;
        StudentService studentService;
        private BindingSource bindingSource;

        private string TrangThaiDki = "";
        public UserControlStudent()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities();
            studentService = new StudentService(db);
            bindingSource = new BindingSource();
            dataGridViewStudent.DataSource = bindingSource;
            dataGridViewStudent.AutoGenerateColumns = false;
        }
        private void UserControlStudents_Load(object sender, EventArgs e)
        {
            loadDataIntoDataGridView();
        }

        private void loadDataIntoDataGridView()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                var data = db.SINHVIENs.ToList();

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
            db.SaveChanges();
            loadDataIntoDataGridView();
        }
        public void Clear()
        {
            txtAddMaSVStudent.Clear();
            txtAddTenStudent.Clear();
            txtAddDTStudent.Clear();
            dateTimeAddNgaySinhStudent.Value = DateTime.Now;
            txtAddDiaChiStudent.Clear();
            rdbAddChuaDuyetStudent.Checked = false;
            rdbAddDuyetStudent.Checked = false;
            tabControlStudent.SelectedTab = tabPageAddStudent;
        }
        private void Clear1()
        {

            txtUpAndDeMaSVStudent.Clear();
            txtUpAndDeTenStudent.Clear();
            txtUpAndDeDTStudent.Clear();
            dateTimeUpAndDeNgaySinhStudent.Value = DateTime.Now;
            txtUpAndDeDiaChiStudent.Clear();
            rdbUpAndDeChuaDuyetStudent.Checked = false;
            rdbUpAndDeDuyetStudent.Checked = false;
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtSearchStudent_Leave(object sender, EventArgs e)
        {
            txtSearchStudent.Clear();
        }
        private void tabPageUpDeStudent_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
            }
            else
            {
                var searchResult = studentService.SearchStudents(searchText);
                bindingSource.DataSource = searchResult;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            bool check;
            bool trangThaiDki = rdbAddDuyetStudent.Checked;
            string chuaDuyet = rdbAddChuaDuyetStudent.Checked ? "Chua Duyet" : "Duyet";

            if (!string.IsNullOrEmpty(txtAddMaSVStudent.Text) && !string.IsNullOrEmpty(txtAddTenStudent.Text))
            {
                check = studentService.AddSinhVien(txtAddMaSVStudent.Text.Trim(), 
                    txtAddTenStudent.Text.Trim(), txtAddDTStudent.Text.Trim(), 
                    dateTimeUpAndDeNgaySinhStudent.Value.ToString(), 
                    txtAddDiaChiStudent.Text.Trim(), 
                    chuaDuyet);
                if (check)
                {
                    Clear();
                    RefreshDataGridView();

                    //rl
                    var relativesControl = FindForm().Controls.Find("userControlRelatives1", true).FirstOrDefault() as UserControlRelative;
                    if (relativesControl != null)
                    {
                        relativesControl.GetMaSVIntoComboBox();
                    }

                    //fee
                    var feesControl = FindForm().Controls.Find("userControlFee1", true).FirstOrDefault() as UserControlFee;
                    if (feesControl != null)
                    {
                        feesControl.GetMaSVIntoComboBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            bool check;
            if (!string.IsNullOrEmpty(txtUpAndDeMaSVStudent.Text))
            {
                bool trangThaiDki = rdbUpAndDeDuyetStudent.Checked;
                string chuaDuyet = rdbUpAndDeChuaDuyetStudent.Checked ? "Chua Duyet" : "Duyet";

                check = studentService.UpdateSinhVien(txtUpAndDeMaSVStudent.Text.Trim(), txtUpAndDeTenStudent.Text.Trim(), txtUpAndDeDTStudent.Text.Trim(), dateTimeUpAndDeNgaySinhStudent.Value.ToString(), txtUpAndDeDiaChiStudent.Text.Trim(), trangThaiDki);
                if (check)
                {
                    Clear1();
                    RefreshDataGridView();


                    //rl
                    var relativesControl = FindForm().Controls.Find("userControlRelatives1", true).FirstOrDefault() as UserControlRelative;
                    if (relativesControl != null)
                    {
                        relativesControl.GetMaSVIntoComboBox();
                    }

                    //fee
                    var feesControl = FindForm().Controls.Find("userControlFee1", true).FirstOrDefault() as UserControlFee;
                    if (feesControl != null)
                    {
                        feesControl.GetMaSVIntoComboBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            bool check;
            if (!string.IsNullOrEmpty(txtUpAndDeMaSVStudent.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    check = studentService.DeleteSinhVien(txtUpAndDeMaSVStudent.Text.Trim());
                    if (check)
                    {
                        Clear1();
                        RefreshDataGridView();

                        //rl
                        var relativesControl = FindForm().Controls.Find("userControlRelatives1", true).FirstOrDefault() as UserControlRelative;
                        if (relativesControl != null)
                        {
                            relativesControl.GetMaSVIntoComboBox();
                        }

                        //fee
                        var feesControl = FindForm().Controls.Find("userControlFee1", true).FirstOrDefault() as UserControlFee;
                        if (feesControl != null)
                        {
                            feesControl.GetMaSVIntoComboBox();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                txtUpAndDeMaSVStudent.Text = row.Cells[0].Value.ToString();
                txtUpAndDeTenStudent.Text = row.Cells[1].Value.ToString();
                txtUpAndDeDTStudent.Text = row.Cells[2].Value.ToString();
                dateTimeUpAndDeNgaySinhStudent.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtUpAndDeDiaChiStudent.Text = row.Cells[4].Value.ToString();
                cbBoxUpAndDeLoaiPhongDkiSudent.Text = row.Cells[5].Value.ToString();
                TrangThaiDki = row.Cells[6].Value.ToString();

                if (TrangThaiDki == "Duyet")
                    rdbUpAndDeDuyetStudent.Checked = true;

                if (TrangThaiDki == "Chua Duyet")
                    rdbUpAndDeChuaDuyetStudent.Checked = true;
            }
        }
    }
}