using Dormitory_Winform.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;



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
            cbBoxAddLoaiPhongDkiStudent.SelectedIndex = -1;
            cbBoxUpAndDeLoaiPhongDkiStudent.SelectedIndex = -1;
            GetLoaiPhongSVDkiIntoComboBox();
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
        public void GetLoaiPhongSVDkiIntoComboBox()
        {
            try
            {
                if (db == null)
                {
                    return;
                }

                List<string> loaiPhongDkiList = db.LOAIPHONGSVDKIs 
                    .Select(s => s.LoaiPhongSVDangKi)
                    .ToList();

                if (cbBoxAddLoaiPhongDkiStudent == null)
                {
                    return;
                }
                cbBoxAddLoaiPhongDkiStudent.Items.Clear();
                foreach (string loaiPhongDki in loaiPhongDkiList)
                {
                    cbBoxAddLoaiPhongDkiStudent.Items.Add(loaiPhongDki);
                }
                ///////////////////////////////////////
                if(cbBoxUpAndDeLoaiPhongDkiStudent == null)
                {
                    return;
                }
                cbBoxUpAndDeLoaiPhongDkiStudent.Items.Clear();
                foreach (string loaiPhongDki in loaiPhongDkiList)
                {
                    cbBoxUpAndDeLoaiPhongDkiStudent.Items.Add(loaiPhongDki);
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
            txtAddMaSVStudent.Clear();
            txtAddTenStudent.Clear();
            txtAddDTStudent.Clear();
            dateTimeAddNgaySinhStudent.Value = DateTime.Now;
            txtAddDiaChiStudent.Clear();
            cbBoxAddLoaiPhongDkiStudent.SelectedIndex = -1;
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
            cbBoxUpAndDeLoaiPhongDkiStudent.SelectedIndex = -1;
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
        private void UpdateRelatedControls()
        {
            var intoRoomControl = FindForm().Controls.Find("userControlIntoRoom1", true).FirstOrDefault() as UserControlIntoRoom;
            intoRoomControl?.GetMaSVIntoComboBox();

            var relativesControl = FindForm().Controls.Find("userControlRelatives1", true).FirstOrDefault() as UserControlRelative;
            relativesControl?.GetMaSVIntoComboBox();

            var feesControl = FindForm().Controls.Find("userControlFee1", true).FirstOrDefault() as UserControlFee;
            feesControl?.GetMaSVIntoComboBox();
        }
        public void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtAddMaSVStudent.Text.Trim();
                string ten = txtAddTenStudent.Text.Trim();
                string dt = txtAddDTStudent.Text.Trim();
                string diaChi = txtAddDiaChiStudent.Text.Trim();
                string loaiPhongDki = cbBoxAddLoaiPhongDkiStudent.SelectedItem?.ToString(); 
                string trangThaiDki = rdbAddChuaDuyetStudent.Checked ? "Chua Duyet" : "Duyet";
                DateTime ngaySinh = dateTimeAddNgaySinhStudent.Value;
                if (ngaySinh == DateTime.Today)
                {
                    ngaySinh = DateTime.MinValue;
                }

                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Please fill out all required fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool check = studentService.AddSinhVien(maSV, ten, dt, ngaySinh.ToString("yyyy-MM-dd"), diaChi, loaiPhongDki, trangThaiDki);
                if (check)
                {
                    Clear();
                    RefreshDataGridView();

                    UpdateRelatedControls();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while adding the student. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtUpAndDeMaSVStudent.Text.Trim();
                string ten = txtUpAndDeTenStudent.Text.Trim();
                string dt = txtUpAndDeDTStudent.Text.Trim();
                string ngaySinh = dateTimeUpAndDeNgaySinhStudent.Value.ToString("yyyy-MM-dd");
                string diaChi = txtUpAndDeDiaChiStudent.Text.Trim();
                string loaiPhongDki = cbBoxUpAndDeLoaiPhongDkiStudent.SelectedItem?.ToString();
                string trangThaiDki = rdbUpAndDeChuaDuyetStudent.Checked ? "Chua Duyet" : "Duyet";

                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Please select a student to update.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool check = studentService.UpdateSinhVien(maSV, ten, dt, ngaySinh, diaChi, loaiPhongDki, trangThaiDki);
                if (check)
                {
                    Clear1();
                    RefreshDataGridView();

                    UpdateRelatedControls();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while updating the student. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        UpdateRelatedControls();
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
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                txtUpAndDeMaSVStudent.Text = row.Cells[0].Value.ToString();
                txtUpAndDeTenStudent.Text = row.Cells[1].Value.ToString();
                txtUpAndDeDTStudent.Text = row.Cells[2].Value.ToString();
                dateTimeUpAndDeNgaySinhStudent.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtUpAndDeDiaChiStudent.Text = row.Cells[4].Value.ToString();
                cbBoxUpAndDeLoaiPhongDkiStudent.Text = row.Cells[5].Value.ToString();
                TrangThaiDki = row.Cells[6].Value.ToString();

                if (TrangThaiDki == "Duyet")
                    rdbUpAndDeDuyetStudent.Checked = true;

                if (TrangThaiDki == "Chua Duyet")
                    rdbUpAndDeChuaDuyetStudent.Checked = true;
                tabControlStudent.SelectedTab = tabPageUpDeStudent;

            }
        }
        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<SINHVIEN> sINHVIENs = new List<SINHVIEN>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SINHVIEN sINHVIEN = new SINHVIEN();
                    sINHVIEN.MaSV = int.Parse(dt.Rows[i]["MaSV"].ToString());
                    sINHVIEN.Ten = dt.Rows[i]["Ten"].ToString();
                    sINHVIEN.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    sINHVIEN.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                    sINHVIEN.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    sINHVIEN.TrangThaiDki = dt.Rows[i]["TrangThaiDki"].ToString();
                    sINHVIEN.LoaiPhongSVDangKi = dt.Rows[i]["LoaiPhongSVDangKi"].ToString();
                    sINHVIENs.Add(sINHVIEN);



                }
                bindingSource.DataSource = sINHVIENs;

            }


        }
        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook |*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);

                        } 
                    }
                }
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                List<SINHVIEN> sinhViens = bindingSource.DataSource as List<SINHVIEN>;
                if (sinhViens != null)
                {
                    foreach (var sinhVien in sinhViens)
                    {
                        var existingRecord = db.SINHVIENs.Find(sinhVien.MaSV);
                        if (existingRecord != null)
                        {
                            existingRecord.Ten = sinhVien.Ten;
                            existingRecord.DiaChi = sinhVien.DiaChi;
                            existingRecord.NgaySinh = sinhVien.NgaySinh;
                            existingRecord.DienThoai = sinhVien.DienThoai;
                            existingRecord.TrangThaiDki = sinhVien.TrangThaiDki;
                        }
                        else
                        {
                            db.SINHVIENs.Add(sinhVien);
                        }
                    }
                    db.SaveChanges();
                    RefreshDataGridView(); 
                    MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException.InnerException != null)
                {
                    innerException = innerException.InnerException;
                }
                MessageBox.Show($"Error importing data: {innerException.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}