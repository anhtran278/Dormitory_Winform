using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform
{
    public partial class UserControlAdmin : UserControl 
        
    {
        private string ID = "";
        QuanLi_DormitoryEntities db; 
        AdminService adminService;
        private BindingSource bindingSource;

        public UserControlAdmin()
        {
            InitializeComponent();
            db = new QuanLi_DormitoryEntities(); 
            adminService = new AdminService(db);
            bindingSource = new BindingSource();
            dataGridViewUser.DataSource = bindingSource;
        }

        private void UserControlAdmins_Load(object sender, EventArgs e)
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
                var data = db.ADMINS.ToList();

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

        private void RefreshData()
        {
            db.SaveChanges();
            RefreshDataGridView(); 
        }

        public void Clear ()
        {
            txtAddUerName.Clear();
            txtAddPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        public void Clear1()
        {
            txtUpAndDeUser.Clear();
            txtUpAndDePassword.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            txtSearchUsername.Clear();
        }

        private void tabPageUpDeUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchUsername.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
            }
            else
            {
                var searchResult = adminService.SearchUsers(searchText);
                bindingSource.DataSource = searchResult;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtAddUerName.Text.Trim() == string.Empty || txtAddPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = adminService.AddUser(txtAddUerName.Text.Trim(), txtAddPassword.Text.Trim());
                if (check)
                    Clear();
                RefreshData();
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtUpAndDeUser.Text = row.Cells[1].Value.ToString();
                txtUpAndDePassword.Text = row.Cells[2].Value.ToString();
                tabControlUser.SelectedTab = tabPageUpDeUser;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtUpAndDeUser.Text.Trim() == string.Empty || txtUpAndDePassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                {
                    check = adminService.UpdateUser(ID, txtUpAndDeUser.Text.Trim(), txtUpAndDePassword.Text.Trim());
                    if (check)
                    {
                        Clear1();
                        RefreshData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fisrt select row form table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
            bool check;
            if (ID != "")
            {
                if (txtUpAndDeUser.Text.Trim() == string.Empty || txtUpAndDePassword.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this User ?", "User Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = adminService.DeleteUser(ID);
                        if (check)
                        {
                            Clear1();
                            RefreshData();
                        }

                        DataGridViewRow rowToDelete = dataGridViewUser.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => row.Cells[0].Value.ToString() == ID);
                        if (rowToDelete != null)
                        {
                            dataGridViewUser.Rows.Remove(rowToDelete);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fisrt select row form table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
