namespace Dormitory_Winform
{
    partial class UserControlAdmins
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdmins));
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddUerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeUser = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpAndDeUser = new System.Windows.Forms.TextBox();
            this.lblUpAndDeUser = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.txtUpAndDePassword = new System.Windows.Forms.TextBox();
            this.lblUpAndDePassword = new System.Windows.Forms.Label();
            this.colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageUpDeUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.tabPageUpDeUser);
            this.tabControlUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUser.Location = new System.Drawing.Point(-1, -1);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1156, 438);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.btnAddUser);
            this.tabPageAddUser.Controls.Add(this.txtAddPassword);
            this.tabPageAddUser.Controls.Add(this.txtAddUerName);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1148, 408);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Navy;
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(264, 216);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 41);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPassword.Location = new System.Drawing.Point(621, 170);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(286, 23);
            this.txtAddPassword.TabIndex = 3;
            // 
            // txtAddUerName
            // 
            this.txtAddUerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddUerName.Location = new System.Drawing.Point(264, 170);
            this.txtAddUerName.Name = "txtAddUerName";
            this.txtAddUerName.Size = new System.Drawing.Size(263, 23);
            this.txtAddUerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUser.Controls.Add(this.txtSearchUsername);
            this.tabPageSearchUser.Controls.Add(this.lblSearchUser);
            this.tabPageSearchUser.Controls.Add(this.label4);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1148, 408);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            this.tabPageSearchUser.Leave += new System.EventHandler(this.tabPageSearchUser_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum1,
            this.colum2,
            this.colum3});
            this.dataGridViewUser.Location = new System.Drawing.Point(95, 135);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.Size = new System.Drawing.Size(941, 216);
            this.dataGridViewUser.TabIndex = 6;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUsername.Location = new System.Drawing.Point(295, 77);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(263, 23);
            this.txtSearchUsername.TabIndex = 5;
            this.txtSearchUsername.TextChanged += new System.EventHandler(this.txtSearchUsername_TextChanged);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.Location = new System.Drawing.Point(295, 43);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(75, 16);
            this.lblSearchUser.TabIndex = 4;
            this.lblSearchUser.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search User: ";
            // 
            // tabPageUpDeUser
            // 
            this.tabPageUpDeUser.Controls.Add(this.label5);
            this.tabPageUpDeUser.Controls.Add(this.txtUpAndDeUser);
            this.tabPageUpDeUser.Controls.Add(this.lblUpAndDeUser);
            this.tabPageUpDeUser.Controls.Add(this.btnDeleteUser);
            this.tabPageUpDeUser.Controls.Add(this.btnUpdateUser);
            this.tabPageUpDeUser.Controls.Add(this.txtUpAndDePassword);
            this.tabPageUpDeUser.Controls.Add(this.lblUpAndDePassword);
            this.tabPageUpDeUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeUser.Name = "tabPageUpDeUser";
            this.tabPageUpDeUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeUser.Size = new System.Drawing.Size(1148, 408);
            this.tabPageUpDeUser.TabIndex = 2;
            this.tabPageUpDeUser.Text = "Update and Delete ";
            this.tabPageUpDeUser.UseVisualStyleBackColor = true;
            this.tabPageUpDeUser.Leave += new System.EventHandler(this.tabPageUpDeUser_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update and Delete:";
            // 
            // txtUpAndDeUser
            // 
            this.txtUpAndDeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAndDeUser.Location = new System.Drawing.Point(264, 170);
            this.txtUpAndDeUser.Name = "txtUpAndDeUser";
            this.txtUpAndDeUser.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeUser.TabIndex = 8;
            // 
            // lblUpAndDeUser
            // 
            this.lblUpAndDeUser.AutoSize = true;
            this.lblUpAndDeUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpAndDeUser.Location = new System.Drawing.Point(264, 136);
            this.lblUpAndDeUser.Name = "lblUpAndDeUser";
            this.lblUpAndDeUser.Size = new System.Drawing.Size(75, 16);
            this.lblUpAndDeUser.TabIndex = 6;
            this.lblUpAndDeUser.Text = "Username:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(405, 216);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.BackgroundImage")));
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(264, 216);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // txtUpAndDePassword
            // 
            this.txtUpAndDePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAndDePassword.Location = new System.Drawing.Point(621, 170);
            this.txtUpAndDePassword.Name = "txtUpAndDePassword";
            this.txtUpAndDePassword.Size = new System.Drawing.Size(286, 23);
            this.txtUpAndDePassword.TabIndex = 7;
            // 
            // lblUpAndDePassword
            // 
            this.lblUpAndDePassword.AutoSize = true;
            this.lblUpAndDePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpAndDePassword.Location = new System.Drawing.Point(620, 136);
            this.lblUpAndDePassword.Name = "lblUpAndDePassword";
            this.lblUpAndDePassword.Size = new System.Drawing.Size(71, 16);
            this.lblUpAndDePassword.TabIndex = 5;
            this.lblUpAndDePassword.Text = "Password:";
            // 
            // colum1
            // 
            this.colum1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colum1.DataPropertyName = "MaAdmins";
            this.colum1.HeaderText = "ID";
            this.colum1.MinimumWidth = 6;
            this.colum1.Name = "colum1";
            this.colum1.ReadOnly = true;
            // 
            // colum2
            // 
            this.colum2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colum2.DataPropertyName = "Ten";
            this.colum2.HeaderText = "Username";
            this.colum2.MinimumWidth = 6;
            this.colum2.Name = "colum2";
            this.colum2.ReadOnly = true;
            // 
            // colum3
            // 
            this.colum3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colum3.DataPropertyName = "MatKhau";
            this.colum3.HeaderText = "Password";
            this.colum3.MinimumWidth = 6;
            this.colum3.Name = "colum3";
            this.colum3.ReadOnly = true;
            // 
            // UserControlAdmins
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlAdmins";
            this.Size = new System.Drawing.Size(1156, 438);
            this.Load += new System.EventHandler(this.UserControlAdmins_Load);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageUpDeUser.ResumeLayout(false);
            this.tabPageUpDeUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddUerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtUpAndDePassword;
        private System.Windows.Forms.TextBox txtUpAndDeUser;
        private System.Windows.Forms.Label lblUpAndDePassword;
        private System.Windows.Forms.Label lblUpAndDeUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum3;
    }
}
