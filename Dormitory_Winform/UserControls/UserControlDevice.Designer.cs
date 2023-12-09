namespace Dormitory_Winform.UserControls
{
    partial class UserControlDevice
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDevice));
            this.tabControlDevices = new System.Windows.Forms.TabControl();
            this.tabPageAddDevices = new System.Windows.Forms.TabPage();
            this.cbBoxAddMaPhongDevice = new System.Windows.Forms.ComboBox();
            this.btnAddDevices = new System.Windows.Forms.Button();
            this.txtAdTenTBDevice = new System.Windows.Forms.TextBox();
            this.txtAddSoLuongDevice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbAddHoatDongDevices = new System.Windows.Forms.RadioButton();
            this.rdbAddHongDevices = new System.Windows.Forms.RadioButton();
            this.rdbAddBaoTriDevices = new System.Windows.Forms.RadioButton();
            this.tabPageSearchDevices = new System.Windows.Forms.TabPage();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMaThietBiDevices = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeDevices = new System.Windows.Forms.TabPage();
            this.txtUpAndDeTenTBDevices = new System.Windows.Forms.TextBox();
            this.txtUpAndDeSoLuongDevices = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteDevices = new System.Windows.Forms.Button();
            this.btnUpdateDevices = new System.Windows.Forms.Button();
            this.rdbUpAnDeDevices = new System.Windows.Forms.RadioButton();
            this.rdbUpAndDeHongDevices = new System.Windows.Forms.RadioButton();
            this.rdbUpAndDeBaoTriDevices = new System.Windows.Forms.RadioButton();
            this.txtUpAndDeMaPhongDevice = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.tabControlDevices.SuspendLayout();
            this.tabPageAddDevices.SuspendLayout();
            this.tabPageSearchDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            this.tabPageUpDeDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DarkBlue;
            label1.Location = new System.Drawing.Point(4, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 18);
            label1.TabIndex = 0;
            label1.Text = "Add Devices:";
            // 
            // tabControlDevices
            // 
            this.tabControlDevices.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlDevices.Controls.Add(this.tabPageAddDevices);
            this.tabControlDevices.Controls.Add(this.tabPageSearchDevices);
            this.tabControlDevices.Controls.Add(this.tabPageUpDeDevices);
            this.tabControlDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDevices.Location = new System.Drawing.Point(0, 4);
            this.tabControlDevices.Name = "tabControlDevices";
            this.tabControlDevices.SelectedIndex = 0;
            this.tabControlDevices.Size = new System.Drawing.Size(1156, 430);
            this.tabControlDevices.TabIndex = 5;
            // 
            // tabPageAddDevices
            // 
            this.tabPageAddDevices.Controls.Add(this.cbBoxAddMaPhongDevice);
            this.tabPageAddDevices.Controls.Add(this.btnAddDevices);
            this.tabPageAddDevices.Controls.Add(this.txtAdTenTBDevice);
            this.tabPageAddDevices.Controls.Add(this.txtAddSoLuongDevice);
            this.tabPageAddDevices.Controls.Add(this.label15);
            this.tabPageAddDevices.Controls.Add(this.label7);
            this.tabPageAddDevices.Controls.Add(this.label6);
            this.tabPageAddDevices.Controls.Add(this.label3);
            this.tabPageAddDevices.Controls.Add(label1);
            this.tabPageAddDevices.Controls.Add(this.rdbAddHoatDongDevices);
            this.tabPageAddDevices.Controls.Add(this.rdbAddHongDevices);
            this.tabPageAddDevices.Controls.Add(this.rdbAddBaoTriDevices);
            this.tabPageAddDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddDevices.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddDevices.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddDevices.Name = "tabPageAddDevices";
            this.tabPageAddDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDevices.Size = new System.Drawing.Size(1148, 400);
            this.tabPageAddDevices.TabIndex = 0;
            this.tabPageAddDevices.Text = "Add";
            this.tabPageAddDevices.UseVisualStyleBackColor = true;
            // 
            // cbBoxAddMaPhongDevice
            // 
            this.cbBoxAddMaPhongDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxAddMaPhongDevice.FormattingEnabled = true;
            this.cbBoxAddMaPhongDevice.Location = new System.Drawing.Point(627, 128);
            this.cbBoxAddMaPhongDevice.Name = "cbBoxAddMaPhongDevice";
            this.cbBoxAddMaPhongDevice.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaPhongDevice.TabIndex = 7;
            // 
            // btnAddDevices
            // 
            this.btnAddDevices.BackColor = System.Drawing.Color.Navy;
            this.btnAddDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDevices.BackgroundImage")));
            this.btnAddDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevices.ForeColor = System.Drawing.Color.White;
            this.btnAddDevices.Location = new System.Drawing.Point(258, 261);
            this.btnAddDevices.Name = "btnAddDevices";
            this.btnAddDevices.Size = new System.Drawing.Size(111, 41);
            this.btnAddDevices.TabIndex = 4;
            this.btnAddDevices.Text = "Add";
            this.btnAddDevices.UseVisualStyleBackColor = false;
            // 
            // txtAdTenTBDevice
            // 
            this.txtAdTenTBDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdTenTBDevice.Location = new System.Drawing.Point(258, 129);
            this.txtAdTenTBDevice.Name = "txtAdTenTBDevice";
            this.txtAdTenTBDevice.Size = new System.Drawing.Size(263, 23);
            this.txtAdTenTBDevice.TabIndex = 3;
            // 
            // txtAddSoLuongDevice
            // 
            this.txtAddSoLuongDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddSoLuongDevice.Location = new System.Drawing.Point(627, 209);
            this.txtAddSoLuongDevice.Name = "txtAddSoLuongDevice";
            this.txtAddSoLuongDevice.Size = new System.Drawing.Size(263, 23);
            this.txtAddSoLuongDevice.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(258, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ten thiet bi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "So luong";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tinh trang:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma Phong:";
            // 
            // rdbAddHoatDongDevices
            // 
            this.rdbAddHoatDongDevices.AutoSize = true;
            this.rdbAddHoatDongDevices.Location = new System.Drawing.Point(258, 210);
            this.rdbAddHoatDongDevices.Name = "rdbAddHoatDongDevices";
            this.rdbAddHoatDongDevices.Size = new System.Drawing.Size(98, 21);
            this.rdbAddHoatDongDevices.TabIndex = 12;
            this.rdbAddHoatDongDevices.TabStop = true;
            this.rdbAddHoatDongDevices.Text = "Hoat Dong";
            this.rdbAddHoatDongDevices.UseVisualStyleBackColor = true;
            // 
            // rdbAddHongDevices
            // 
            this.rdbAddHongDevices.AutoSize = true;
            this.rdbAddHongDevices.Location = new System.Drawing.Point(370, 210);
            this.rdbAddHongDevices.Name = "rdbAddHongDevices";
            this.rdbAddHongDevices.Size = new System.Drawing.Size(61, 21);
            this.rdbAddHongDevices.TabIndex = 13;
            this.rdbAddHongDevices.TabStop = true;
            this.rdbAddHongDevices.Text = "Hong";
            this.rdbAddHongDevices.UseVisualStyleBackColor = true;
            // 
            // rdbAddBaoTriDevices
            // 
            this.rdbAddBaoTriDevices.AutoSize = true;
            this.rdbAddBaoTriDevices.Location = new System.Drawing.Point(451, 210);
            this.rdbAddBaoTriDevices.Name = "rdbAddBaoTriDevices";
            this.rdbAddBaoTriDevices.Size = new System.Drawing.Size(67, 21);
            this.rdbAddBaoTriDevices.TabIndex = 13;
            this.rdbAddBaoTriDevices.TabStop = true;
            this.rdbAddBaoTriDevices.Text = "Bao Tri";
            this.rdbAddBaoTriDevices.UseVisualStyleBackColor = true;
            // 
            // tabPageSearchDevices
            // 
            this.tabPageSearchDevices.Controls.Add(this.dataGridViewDevices);
            this.tabPageSearchDevices.Controls.Add(this.txtSearchMaThietBiDevices);
            this.tabPageSearchDevices.Controls.Add(this.lblSearch);
            this.tabPageSearchDevices.Controls.Add(this.label4);
            this.tabPageSearchDevices.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchDevices.Name = "tabPageSearchDevices";
            this.tabPageSearchDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchDevices.Size = new System.Drawing.Size(1148, 400);
            this.tabPageSearchDevices.TabIndex = 1;
            this.tabPageSearchDevices.Text = "Search";
            this.tabPageSearchDevices.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDevices
            // 
            this.dataGridViewDevices.AllowUserToAddRows = false;
            this.dataGridViewDevices.AllowUserToDeleteRows = false;
            this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewDevices.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.ReadOnly = true;
            this.dataGridViewDevices.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewDevices.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Devices_MaThietBi";
            this.Column1.HeaderText = "Ma Thiet Bi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Devices_MaPhong";
            this.Column2.HeaderText = "Ma Phong";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Devices_TenThietBi";
            this.Column3.HeaderText = "Ten Thiet Bi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Devices_SoLuong";
            this.Column4.HeaderText = "So Luong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Devices_TinhTrang";
            this.Column5.HeaderText = "Tinh Trang";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtSearchMaThietBiDevices
            // 
            this.txtSearchMaThietBiDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaThietBiDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaThietBiDevices.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaThietBiDevices.Name = "txtSearchMaThietBiDevices";
            this.txtSearchMaThietBiDevices.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaThietBiDevices.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(295, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Ma Phong Va Ten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Devices: ";
            // 
            // tabPageUpDeDevices
            // 
            this.tabPageUpDeDevices.Controls.Add(this.txtUpAndDeMaPhongDevice);
            this.tabPageUpDeDevices.Controls.Add(this.txtUpAndDeTenTBDevices);
            this.tabPageUpDeDevices.Controls.Add(this.txtUpAndDeSoLuongDevices);
            this.tabPageUpDeDevices.Controls.Add(this.label8);
            this.tabPageUpDeDevices.Controls.Add(this.label9);
            this.tabPageUpDeDevices.Controls.Add(this.label10);
            this.tabPageUpDeDevices.Controls.Add(this.label11);
            this.tabPageUpDeDevices.Controls.Add(this.label5);
            this.tabPageUpDeDevices.Controls.Add(this.btnDeleteDevices);
            this.tabPageUpDeDevices.Controls.Add(this.btnUpdateDevices);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAnDeDevices);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAndDeHongDevices);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAndDeBaoTriDevices);
            this.tabPageUpDeDevices.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeDevices.Name = "tabPageUpDeDevices";
            this.tabPageUpDeDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeDevices.Size = new System.Drawing.Size(1148, 400);
            this.tabPageUpDeDevices.TabIndex = 2;
            this.tabPageUpDeDevices.Text = "Update and Delete ";
            this.tabPageUpDeDevices.UseVisualStyleBackColor = true;
            // 
            // txtUpAndDeTenTBDevices
            // 
            this.txtUpAndDeTenTBDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTenTBDevices.Location = new System.Drawing.Point(258, 129);
            this.txtUpAndDeTenTBDevices.Name = "txtUpAndDeTenTBDevices";
            this.txtUpAndDeTenTBDevices.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTenTBDevices.TabIndex = 17;
            this.txtUpAndDeTenTBDevices.TextChanged += new System.EventHandler(this.txtUpAndDeTenTBDevices_TextChanged);
            // 
            // txtUpAndDeSoLuongDevices
            // 
            this.txtUpAndDeSoLuongDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeSoLuongDevices.Location = new System.Drawing.Point(627, 209);
            this.txtUpAndDeSoLuongDevices.Name = "txtUpAndDeSoLuongDevices";
            this.txtUpAndDeSoLuongDevices.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeSoLuongDevices.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ten thiet bi:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "So luong";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tinh trang:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(627, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ma Phong:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update and Delete Devices:";
            // 
            // btnDeleteDevices
            // 
            this.btnDeleteDevices.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteDevices.BackgroundImage")));
            this.btnDeleteDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDevices.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDevices.Location = new System.Drawing.Point(402, 262);
            this.btnDeleteDevices.Name = "btnDeleteDevices";
            this.btnDeleteDevices.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteDevices.TabIndex = 9;
            this.btnDeleteDevices.Text = "Delete";
            this.btnDeleteDevices.UseVisualStyleBackColor = false;
            this.btnDeleteDevices.Click += new System.EventHandler(this.btnDeleteDevices_Click);
            // 
            // btnUpdateDevices
            // 
            this.btnUpdateDevices.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateDevices.BackgroundImage")));
            this.btnUpdateDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDevices.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDevices.Location = new System.Drawing.Point(258, 262);
            this.btnUpdateDevices.Name = "btnUpdateDevices";
            this.btnUpdateDevices.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateDevices.TabIndex = 9;
            this.btnUpdateDevices.Text = "Update";
            this.btnUpdateDevices.UseVisualStyleBackColor = false;
            this.btnUpdateDevices.Click += new System.EventHandler(this.btnUpdateDevices_Click);
            // 
            // rdbUpAnDeDevices
            // 
            this.rdbUpAnDeDevices.AutoSize = true;
            this.rdbUpAnDeDevices.Location = new System.Drawing.Point(258, 209);
            this.rdbUpAnDeDevices.Name = "rdbUpAnDeDevices";
            this.rdbUpAnDeDevices.Size = new System.Drawing.Size(98, 21);
            this.rdbUpAnDeDevices.TabIndex = 25;
            this.rdbUpAnDeDevices.TabStop = true;
            this.rdbUpAnDeDevices.Text = "Hoat Dong";
            this.rdbUpAnDeDevices.UseVisualStyleBackColor = true;
            this.rdbUpAnDeDevices.CheckedChanged += new System.EventHandler(this.rdbUpAnDeDevices_CheckedChanged);
            // 
            // rdbUpAndDeHongDevices
            // 
            this.rdbUpAndDeHongDevices.AutoSize = true;
            this.rdbUpAndDeHongDevices.Location = new System.Drawing.Point(371, 209);
            this.rdbUpAndDeHongDevices.Name = "rdbUpAndDeHongDevices";
            this.rdbUpAndDeHongDevices.Size = new System.Drawing.Size(61, 21);
            this.rdbUpAndDeHongDevices.TabIndex = 26;
            this.rdbUpAndDeHongDevices.TabStop = true;
            this.rdbUpAndDeHongDevices.Text = "Hong";
            this.rdbUpAndDeHongDevices.UseVisualStyleBackColor = true;
            this.rdbUpAndDeHongDevices.CheckedChanged += new System.EventHandler(this.rdbUpAndDeHongDevices_CheckedChanged);
            // 
            // rdbUpAndDeBaoTriDevices
            // 
            this.rdbUpAndDeBaoTriDevices.AutoSize = true;
            this.rdbUpAndDeBaoTriDevices.Location = new System.Drawing.Point(452, 209);
            this.rdbUpAndDeBaoTriDevices.Name = "rdbUpAndDeBaoTriDevices";
            this.rdbUpAndDeBaoTriDevices.Size = new System.Drawing.Size(67, 21);
            this.rdbUpAndDeBaoTriDevices.TabIndex = 27;
            this.rdbUpAndDeBaoTriDevices.TabStop = true;
            this.rdbUpAndDeBaoTriDevices.Text = "Bao Tri";
            this.rdbUpAndDeBaoTriDevices.UseVisualStyleBackColor = true;
            this.rdbUpAndDeBaoTriDevices.CheckedChanged += new System.EventHandler(this.rdbUpAndDeBaoTriDevices_CheckedChanged);
            // 
            // txtUpAndDeMaPhongDevice
            // 
            this.txtUpAndDeMaPhongDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaPhongDevice.Location = new System.Drawing.Point(627, 129);
            this.txtUpAndDeMaPhongDevice.Name = "txtUpAndDeMaPhongDevice";
            this.txtUpAndDeMaPhongDevice.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaPhongDevice.TabIndex = 17;
            this.txtUpAndDeMaPhongDevice.TextChanged += new System.EventHandler(this.txtUpAndDeTenTBDevices_TextChanged);
            // 
            // UserControlDevice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlDevices);
            this.Name = "UserControlDevice";
            this.Size = new System.Drawing.Size(1156, 438);
            this.tabControlDevices.ResumeLayout(false);
            this.tabPageAddDevices.ResumeLayout(false);
            this.tabPageAddDevices.PerformLayout();
            this.tabPageSearchDevices.ResumeLayout(false);
            this.tabPageSearchDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.tabPageUpDeDevices.ResumeLayout(false);
            this.tabPageUpDeDevices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDevices;
        private System.Windows.Forms.TabPage tabPageAddDevices;
        private System.Windows.Forms.ComboBox cbBoxAddMaPhongDevice;
        private System.Windows.Forms.Button btnAddDevices;
        private System.Windows.Forms.TextBox txtAddSoLuongDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageSearchDevices;
        private System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.TextBox txtSearchMaThietBiDevices;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteDevices;
        private System.Windows.Forms.Button btnUpdateDevices;
        private System.Windows.Forms.TextBox txtAdTenTBDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtUpAndDeTenTBDevices;
        private System.Windows.Forms.TextBox txtUpAndDeSoLuongDevices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbAddHoatDongDevices;
        private System.Windows.Forms.RadioButton rdbAddHongDevices;
        private System.Windows.Forms.RadioButton rdbAddBaoTriDevices;
        private System.Windows.Forms.RadioButton rdbUpAnDeDevices;
        private System.Windows.Forms.RadioButton rdbUpAndDeHongDevices;
        private System.Windows.Forms.RadioButton rdbUpAndDeBaoTriDevices;
        private System.Windows.Forms.TextBox txtUpAndDeMaPhongDevice;
    }
}
