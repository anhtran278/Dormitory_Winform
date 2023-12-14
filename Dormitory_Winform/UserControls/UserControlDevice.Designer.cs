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
            this.btnAddDevices = new System.Windows.Forms.Button();
            this.txtAddTenTBDevice = new System.Windows.Forms.TextBox();
            this.txtAddSoLuongDevice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbAddHoatDongDevice = new System.Windows.Forms.RadioButton();
            this.rdbAddHongDevice = new System.Windows.Forms.RadioButton();
            this.rdbAddBaoTriDevice = new System.Windows.Forms.RadioButton();
            this.tabPageSearchDevices = new System.Windows.Forms.TabPage();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.txtSearchMaThietBiDevices = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeDevices = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteDevices = new System.Windows.Forms.Button();
            this.btnUpdateDevices = new System.Windows.Forms.Button();
            this.txtUpAndDeTenTBDevice = new System.Windows.Forms.TextBox();
            this.txtUpAndDeSoLuongDevice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbUpAndDeHoatDongDevice = new System.Windows.Forms.RadioButton();
            this.rdbUpAndDeHongDevice = new System.Windows.Forms.RadioButton();
            this.rdbUpAndDeBaoTriDevice = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPageAddDevices.Controls.Add(this.btnAddDevices);
            this.tabPageAddDevices.Controls.Add(this.txtAddTenTBDevice);
            this.tabPageAddDevices.Controls.Add(this.txtAddSoLuongDevice);
            this.tabPageAddDevices.Controls.Add(this.label15);
            this.tabPageAddDevices.Controls.Add(this.label7);
            this.tabPageAddDevices.Controls.Add(this.label6);
            this.tabPageAddDevices.Controls.Add(label1);
            this.tabPageAddDevices.Controls.Add(this.rdbAddHoatDongDevice);
            this.tabPageAddDevices.Controls.Add(this.rdbAddHongDevice);
            this.tabPageAddDevices.Controls.Add(this.rdbAddBaoTriDevice);
            this.tabPageAddDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddDevices.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddDevices.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddDevices.Name = "tabPageAddDevices";
            this.tabPageAddDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDevices.Size = new System.Drawing.Size(1148, 400);
            this.tabPageAddDevices.TabIndex = 0;
            this.tabPageAddDevices.Text = "Add";
            this.tabPageAddDevices.UseVisualStyleBackColor = true;
            this.tabPageAddDevices.Leave += new System.EventHandler(this.tabPageAddDevices_Leave);
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
            this.btnAddDevices.Location = new System.Drawing.Point(258, 277);
            this.btnAddDevices.Name = "btnAddDevices";
            this.btnAddDevices.Size = new System.Drawing.Size(111, 41);
            this.btnAddDevices.TabIndex = 4;
            this.btnAddDevices.Text = "Add";
            this.btnAddDevices.UseVisualStyleBackColor = false;
            this.btnAddDevices.Click += new System.EventHandler(this.btnAddDevices_Click);
            // 
            // txtAddTenTBDevice
            // 
            this.txtAddTenTBDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTenTBDevice.Location = new System.Drawing.Point(258, 129);
            this.txtAddTenTBDevice.Name = "txtAddTenTBDevice";
            this.txtAddTenTBDevice.Size = new System.Drawing.Size(263, 23);
            this.txtAddTenTBDevice.TabIndex = 3;
            // 
            // txtAddSoLuongDevice
            // 
            this.txtAddSoLuongDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddSoLuongDevice.Location = new System.Drawing.Point(627, 129);
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
            this.label7.Location = new System.Drawing.Point(627, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "So luong";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tinh trang:";
            // 
            // rdbAddHoatDongDevice
            // 
            this.rdbAddHoatDongDevice.AutoSize = true;
            this.rdbAddHoatDongDevice.Location = new System.Drawing.Point(258, 221);
            this.rdbAddHoatDongDevice.Name = "rdbAddHoatDongDevice";
            this.rdbAddHoatDongDevice.Size = new System.Drawing.Size(98, 21);
            this.rdbAddHoatDongDevice.TabIndex = 12;
            this.rdbAddHoatDongDevice.TabStop = true;
            this.rdbAddHoatDongDevice.Text = "Hoat Dong";
            this.rdbAddHoatDongDevice.UseVisualStyleBackColor = true;
            // 
            // rdbAddHongDevice
            // 
            this.rdbAddHongDevice.AutoSize = true;
            this.rdbAddHongDevice.Location = new System.Drawing.Point(370, 221);
            this.rdbAddHongDevice.Name = "rdbAddHongDevice";
            this.rdbAddHongDevice.Size = new System.Drawing.Size(61, 21);
            this.rdbAddHongDevice.TabIndex = 13;
            this.rdbAddHongDevice.TabStop = true;
            this.rdbAddHongDevice.Text = "Hong";
            this.rdbAddHongDevice.UseVisualStyleBackColor = true;
            // 
            // rdbAddBaoTriDevice
            // 
            this.rdbAddBaoTriDevice.AutoSize = true;
            this.rdbAddBaoTriDevice.Location = new System.Drawing.Point(451, 221);
            this.rdbAddBaoTriDevice.Name = "rdbAddBaoTriDevice";
            this.rdbAddBaoTriDevice.Size = new System.Drawing.Size(67, 21);
            this.rdbAddBaoTriDevice.TabIndex = 13;
            this.rdbAddBaoTriDevice.TabStop = true;
            this.rdbAddBaoTriDevice.Text = "Bao Tri";
            this.rdbAddBaoTriDevice.UseVisualStyleBackColor = true;
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewDevices.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.ReadOnly = true;
            this.dataGridViewDevices.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewDevices.TabIndex = 6;
            this.dataGridViewDevices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevice_CellClick);
            // 
            // txtSearchMaThietBiDevices
            // 
            this.txtSearchMaThietBiDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaThietBiDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaThietBiDevices.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaThietBiDevices.Name = "txtSearchMaThietBiDevices";
            this.txtSearchMaThietBiDevices.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaThietBiDevices.TabIndex = 5;
            this.txtSearchMaThietBiDevices.TextChanged += new System.EventHandler(this.txtSearchMaThietBiDevices_TextChanged);
            this.txtSearchMaThietBiDevices.Leave += new System.EventHandler(this.txtSearchMaThietBiDevices_Leave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(295, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Tim kiem:";
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
            this.tabPageUpDeDevices.Controls.Add(this.txtUpAndDeTenTBDevice);
            this.tabPageUpDeDevices.Controls.Add(this.txtUpAndDeSoLuongDevice);
            this.tabPageUpDeDevices.Controls.Add(this.label2);
            this.tabPageUpDeDevices.Controls.Add(this.label3);
            this.tabPageUpDeDevices.Controls.Add(this.label8);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAndDeHoatDongDevice);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAndDeHongDevice);
            this.tabPageUpDeDevices.Controls.Add(this.rdbUpAndDeBaoTriDevice);
            this.tabPageUpDeDevices.Controls.Add(this.label5);
            this.tabPageUpDeDevices.Controls.Add(this.btnDeleteDevices);
            this.tabPageUpDeDevices.Controls.Add(this.btnUpdateDevices);
            this.tabPageUpDeDevices.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeDevices.Name = "tabPageUpDeDevices";
            this.tabPageUpDeDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeDevices.Size = new System.Drawing.Size(1148, 400);
            this.tabPageUpDeDevices.TabIndex = 2;
            this.tabPageUpDeDevices.Text = "Update and Delete ";
            this.tabPageUpDeDevices.UseVisualStyleBackColor = true;
            this.tabPageUpDeDevices.Leave += new System.EventHandler(this.tabPageUpDeDevices_Leave);
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
            this.btnDeleteDevices.Location = new System.Drawing.Point(407, 271);
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
            this.btnUpdateDevices.Location = new System.Drawing.Point(258, 271);
            this.btnUpdateDevices.Name = "btnUpdateDevices";
            this.btnUpdateDevices.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateDevices.TabIndex = 9;
            this.btnUpdateDevices.Text = "Update";
            this.btnUpdateDevices.UseVisualStyleBackColor = false;
            this.btnUpdateDevices.Click += new System.EventHandler(this.btnUpdateDevices_Click);
            // 
            // txtUpAndDeTenTBDevice
            // 
            this.txtUpAndDeTenTBDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTenTBDevice.Location = new System.Drawing.Point(258, 123);
            this.txtUpAndDeTenTBDevice.Name = "txtUpAndDeTenTBDevice";
            this.txtUpAndDeTenTBDevice.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTenTBDevice.TabIndex = 17;
            // 
            // txtUpAndDeSoLuongDevice
            // 
            this.txtUpAndDeSoLuongDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeSoLuongDevice.Location = new System.Drawing.Point(627, 123);
            this.txtUpAndDeSoLuongDevice.Name = "txtUpAndDeSoLuongDevice";
            this.txtUpAndDeSoLuongDevice.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeSoLuongDevice.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ten thiet bi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "So luong";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tinh trang:";
            // 
            // rdbUpAndDeHoatDongDevice
            // 
            this.rdbUpAndDeHoatDongDevice.AutoSize = true;
            this.rdbUpAndDeHoatDongDevice.Location = new System.Drawing.Point(258, 215);
            this.rdbUpAndDeHoatDongDevice.Name = "rdbUpAndDeHoatDongDevice";
            this.rdbUpAndDeHoatDongDevice.Size = new System.Drawing.Size(98, 21);
            this.rdbUpAndDeHoatDongDevice.TabIndex = 20;
            this.rdbUpAndDeHoatDongDevice.TabStop = true;
            this.rdbUpAndDeHoatDongDevice.Text = "Hoat Dong";
            this.rdbUpAndDeHoatDongDevice.UseVisualStyleBackColor = true;
            // 
            // rdbUpAndDeHongDevice
            // 
            this.rdbUpAndDeHongDevice.AutoSize = true;
            this.rdbUpAndDeHongDevice.Location = new System.Drawing.Point(370, 215);
            this.rdbUpAndDeHongDevice.Name = "rdbUpAndDeHongDevice";
            this.rdbUpAndDeHongDevice.Size = new System.Drawing.Size(61, 21);
            this.rdbUpAndDeHongDevice.TabIndex = 21;
            this.rdbUpAndDeHongDevice.TabStop = true;
            this.rdbUpAndDeHongDevice.Text = "Hong";
            this.rdbUpAndDeHongDevice.UseVisualStyleBackColor = true;
            // 
            // rdbUpAndDeBaoTriDevice
            // 
            this.rdbUpAndDeBaoTriDevice.AutoSize = true;
            this.rdbUpAndDeBaoTriDevice.Location = new System.Drawing.Point(451, 215);
            this.rdbUpAndDeBaoTriDevice.Name = "rdbUpAndDeBaoTriDevice";
            this.rdbUpAndDeBaoTriDevice.Size = new System.Drawing.Size(67, 21);
            this.rdbUpAndDeBaoTriDevice.TabIndex = 22;
            this.rdbUpAndDeBaoTriDevice.TabStop = true;
            this.rdbUpAndDeBaoTriDevice.Text = "Bao Tri";
            this.rdbUpAndDeBaoTriDevice.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaThietBi";
            this.Column1.HeaderText = "Ma Thiet Bi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenThietBi";
            this.Column3.HeaderText = "Ten Thiet Bi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "So Luong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TinhTrang";
            this.Column5.HeaderText = "Tinh Trang";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // UserControlDevice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlDevices);
            this.Name = "UserControlDevice";
            this.Size = new System.Drawing.Size(1156, 438);
            this.Load += new System.EventHandler(this.UserControlDevice_Load);
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
        private System.Windows.Forms.Button btnAddDevices;
        private System.Windows.Forms.TextBox txtAddSoLuongDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageSearchDevices;
        private System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.TextBox txtSearchMaThietBiDevices;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteDevices;
        private System.Windows.Forms.Button btnUpdateDevices;
        private System.Windows.Forms.TextBox txtAddTenTBDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdbAddHoatDongDevice;
        private System.Windows.Forms.RadioButton rdbAddHongDevice;
        private System.Windows.Forms.RadioButton rdbAddBaoTriDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtUpAndDeTenTBDevice;
        private System.Windows.Forms.TextBox txtUpAndDeSoLuongDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbUpAndDeHoatDongDevice;
        private System.Windows.Forms.RadioButton rdbUpAndDeHongDevice;
        private System.Windows.Forms.RadioButton rdbUpAndDeBaoTriDevice;
    }
}
