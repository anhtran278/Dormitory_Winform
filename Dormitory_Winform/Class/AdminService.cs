using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform
{
    
    public class AdminService
    {
        private QuanLi_DormitoryEntities db;
        public AdminService(QuanLi_DormitoryEntities dbContext)
        {
            db = dbContext;
        }

        public List<ADMIN> SearchUsers(string searchText)
        {
            try
            {
                var searchResult = db.ADMINS.Where(u => u.Ten.Contains(searchText)).ToList();

                return searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for users. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ADMIN>();
            }
        }

        public bool AddUser(string username, string password)
        {
            try
            {
                if (db.ADMINS.Any(u => u.Ten == username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ADMIN newUser = new ADMIN
                {
                    Ten = username,
                    MatKhau = password
                };

                db.ADMINS.Add(newUser);

                db.SaveChanges();

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the user. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateUser(string id, string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please first select a row from the table.", "Selection of Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                ADMIN existingUser = db.ADMINS.Find(int.Parse(id));

                if (existingUser == null)
                {
                    MessageBox.Show("User not found in the database.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingUser.Ten = username;
                existingUser.MatKhau = password;

                db.SaveChanges();

                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteUser(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please first select a row from the table.", "Selection of Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                ADMIN userToDelete = db.ADMINS.Find(int.Parse(id));

                if (userToDelete == null)
                {
                    MessageBox.Show("User not found in the database.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                db.ADMINS.Remove(userToDelete);

                db.SaveChanges();

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}

