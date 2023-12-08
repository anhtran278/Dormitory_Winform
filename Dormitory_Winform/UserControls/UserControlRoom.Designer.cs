namespace Dormitory_Winform.UserControls
{
    partial class UserControlRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRooms));
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBoxAddLoaiPhongRoom = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtAddGiaPhongRoom = new System.Windows.Forms.TextBox();
            this.txtAddKiHieuRoom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddMaPhongRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxAddMaSvRoom = new System.Windows.Forms.ComboBox();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMaPhongRoom = new System.Windows.Forms.TextBox();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeRoom = new System.Windows.Forms.TabPage();
            this.cbBoxUpAndDeLoaiPhongRoom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpAndDeGiaPhongRoom = new System.Windows.Forms.TextBox();
            this.txtUpAndDeKiHieuRoom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaPhongRoom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaSVRoom = new System.Windows.Forms.TextBox();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpDeRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpDeRoom);
            this.tabControlRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRoom.Location = new System.Drawing.Point(5, 15);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1156, 438);
            this.tabControlRoom.TabIndex = 2;
            this.tabControlRoom.Leave += new System.EventHandler(this.tabPageUpDeRoom_Leave);
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.label8);
            this.tabPageAddRoom.Controls.Add(this.label7);
            this.tabPageAddRoom.Controls.Add(this.cbBoxAddLoaiPhongRoom);
            this.tabPageAddRoom.Controls.Add(this.btnAddRoom);
            this.tabPageAddRoom.Controls.Add(this.txtAddGiaPhongRoom);
            this.tabPageAddRoom.Controls.Add(this.txtAddKiHieuRoom);
            this.tabPageAddRoom.Controls.Add(this.label9);
            this.tabPageAddRoom.Controls.Add(this.label16);
            this.tabPageAddRoom.Controls.Add(this.txtAddMaPhongRoom);
            this.tabPageAddRoom.Controls.Add(this.label6);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Controls.Add(this.cbBoxAddMaSvRoom);
            this.tabPageAddRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "(Phong loai B: 4 giuong, 1 may lanh, 4 tu, 4 ban, 1 TV, 1 bep, 2 nha vs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(452, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "(Phong loai A: 2 giuong, 1 may lanh, 2 tu, 2 ban, 1 TV, 1 bep, 1 nha vs)";
            // 
            // cbBoxAddLoaiPhongRoom
            // 
            this.cbBoxAddLoaiPhongRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxAddLoaiPhongRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxAddLoaiPhongRoom.FormattingEnabled = true;
            this.cbBoxAddLoaiPhongRoom.Items.AddRange(new object[] {
            "Please select ...",
            "A",
            "B"});
            this.cbBoxAddLoaiPhongRoom.Location = new System.Drawing.Point(558, 119);
            this.cbBoxAddLoaiPhongRoom.Name = "cbBoxAddLoaiPhongRoom";
            this.cbBoxAddLoaiPhongRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddLoaiPhongRoom.TabIndex = 7;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Navy;
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(194, 276);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(111, 41);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtAddGiaPhongRoom
            // 
            this.txtAddGiaPhongRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddGiaPhongRoom.Location = new System.Drawing.Point(558, 294);
            this.txtAddGiaPhongRoom.Name = "txtAddGiaPhongRoom";
            this.txtAddGiaPhongRoom.Size = new System.Drawing.Size(263, 23);
            this.txtAddGiaPhongRoom.TabIndex = 3;
            // 
            // txtAddKiHieuRoom
            // 
            this.txtAddKiHieuRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddKiHieuRoom.Location = new System.Drawing.Point(558, 200);
            this.txtAddKiHieuRoom.Name = "txtAddKiHieuRoom";
            this.txtAddKiHieuRoom.Size = new System.Drawing.Size(263, 23);
            this.txtAddKiHieuRoom.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loai phong:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(558, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Gia Phong:";
            // 
            // txtAddMaPhongRoom
            // 
            this.txtAddMaPhongRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddMaPhongRoom.Location = new System.Drawing.Point(194, 121);
            this.txtAddMaPhongRoom.Name = "txtAddMaPhongRoom";
            this.txtAddMaPhongRoom.Size = new System.Drawing.Size(263, 23);
            this.txtAddMaPhongRoom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ki hieu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma phong:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rooms:";
            // 
            // cbBoxAddMaSvRoom
            // 
            this.cbBoxAddMaSvRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxAddMaSvRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxAddMaSvRoom.FormattingEnabled = true;
            this.cbBoxAddMaSvRoom.Items.AddRange(new object[] {
            "Please select ..."});
            this.cbBoxAddMaSvRoom.Location = new System.Drawing.Point(194, 200);
            this.cbBoxAddMaSvRoom.Name = "cbBoxAddMaSvRoom";
            this.cbBoxAddMaSvRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaSvRoom.TabIndex = 7;
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.txtSearchMaPhongRoom);
            this.tabPageSearchRoom.Controls.Add(this.lblSearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.label4);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridViewRoom.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewRoom.TabIndex = 6;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaPhong";
            this.Column1.HeaderText = "Ma Phong";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "MaSV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GiaPhong";
            this.Column5.HeaderText = "Gia Phong";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "KiHieu";
            this.Column3.HeaderText = "Ki Hieu Phong";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "LoaiPhong";
            this.Column4.HeaderText = "Loai Phong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtSearchMaPhongRoom
            // 
            this.txtSearchMaPhongRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaPhongRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaPhongRoom.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaPhongRoom.Name = "txtSearchMaPhongRoom";
            this.txtSearchMaPhongRoom.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaPhongRoom.TabIndex = 5;
            this.txtSearchMaPhongRoom.TextChanged += new System.EventHandler(this.txtSearchMaPhongRoom_TextChanged);
            this.txtSearchMaPhongRoom.Leave += new System.EventHandler(this.txtSearchMaPhongRoom_Leave);
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.AutoSize = true;
            this.lblSearchRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRoom.Location = new System.Drawing.Point(295, 43);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.Size = new System.Drawing.Size(76, 16);
            this.lblSearchRoom.TabIndex = 4;
            this.lblSearchRoom.Text = "Ma Phong:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Room: ";
            // 
            // tabPageUpDeRoom
            // 
            this.tabPageUpDeRoom.Controls.Add(this.cbBoxUpAndDeLoaiPhongRoom);
            this.tabPageUpDeRoom.Controls.Add(this.label10);
            this.tabPageUpDeRoom.Controls.Add(this.label11);
            this.tabPageUpDeRoom.Controls.Add(this.txtUpAndDeGiaPhongRoom);
            this.tabPageUpDeRoom.Controls.Add(this.txtUpAndDeKiHieuRoom);
            this.tabPageUpDeRoom.Controls.Add(this.label17);
            this.tabPageUpDeRoom.Controls.Add(this.txtUpAndDeMaSVRoom);
            this.tabPageUpDeRoom.Controls.Add(this.txtUpAndDeMaPhongRoom);
            this.tabPageUpDeRoom.Controls.Add(this.label13);
            this.tabPageUpDeRoom.Controls.Add(this.label14);
            this.tabPageUpDeRoom.Controls.Add(this.label15);
            this.tabPageUpDeRoom.Controls.Add(this.label5);
            this.tabPageUpDeRoom.Controls.Add(this.btnDeleteRoom);
            this.tabPageUpDeRoom.Controls.Add(this.btnUpdateRoom);
            this.tabPageUpDeRoom.Controls.Add(this.label12);
            this.tabPageUpDeRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeRoom.Name = "tabPageUpDeRoom";
            this.tabPageUpDeRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageUpDeRoom.TabIndex = 2;
            this.tabPageUpDeRoom.Text = "Update and Delete ";
            this.tabPageUpDeRoom.UseVisualStyleBackColor = true;
            // 
            // cbBoxUpAndDeLoaiPhongRoom
            // 
            this.cbBoxUpAndDeLoaiPhongRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxUpAndDeLoaiPhongRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxUpAndDeLoaiPhongRoom.FormattingEnabled = true;
            this.cbBoxUpAndDeLoaiPhongRoom.Items.AddRange(new object[] {
            "Please select ...",
            "A",
            "B"});
            this.cbBoxUpAndDeLoaiPhongRoom.Location = new System.Drawing.Point(558, 117);
            this.cbBoxUpAndDeLoaiPhongRoom.Name = "cbBoxUpAndDeLoaiPhongRoom";
            this.cbBoxUpAndDeLoaiPhongRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeLoaiPhongRoom.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(690, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(449, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "(Phong loai B: 4 giuong, 1 may lanh, 4 tu, 4 ban, 1 TV, 1 bep, 2 nha vs)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(690, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(452, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "(Phong loai A: 2 giuong, 1 may lanh, 2 tu, 2 ban, 1 TV, 1 bep, 1 nha vs)";
            // 
            // txtUpAndDeGiaPhongRoom
            // 
            this.txtUpAndDeGiaPhongRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeGiaPhongRoom.Location = new System.Drawing.Point(558, 293);
            this.txtUpAndDeGiaPhongRoom.Name = "txtUpAndDeGiaPhongRoom";
            this.txtUpAndDeGiaPhongRoom.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeGiaPhongRoom.TabIndex = 15;
            // 
            // txtUpAndDeKiHieuRoom
            // 
            this.txtUpAndDeKiHieuRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeKiHieuRoom.Location = new System.Drawing.Point(558, 201);
            this.txtUpAndDeKiHieuRoom.Name = "txtUpAndDeKiHieuRoom";
            this.txtUpAndDeKiHieuRoom.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeKiHieuRoom.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(558, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Gia Phong:";
            // 
            // txtUpAndDeMaPhongRoom
            // 
            this.txtUpAndDeMaPhongRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaPhongRoom.Location = new System.Drawing.Point(194, 121);
            this.txtUpAndDeMaPhongRoom.Name = "txtUpAndDeMaPhongRoom";
            this.txtUpAndDeMaPhongRoom.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaPhongRoom.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(558, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ki hieu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(194, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Ma SV:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(194, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Ma phong:";
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
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.BackgroundImage")));
            this.btnDeleteRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(335, 276);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteRoom.TabIndex = 9;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateRoom.BackgroundImage")));
            this.btnUpdateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Location = new System.Drawing.Point(194, 276);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateRoom.TabIndex = 9;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(558, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Loai phong:";
            // 
            // txtUpAndDeMaSVRoom
            // 
            this.txtUpAndDeMaSVRoom.BackColor = System.Drawing.Color.White;
            this.txtUpAndDeMaSVRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaSVRoom.Location = new System.Drawing.Point(194, 201);
            this.txtUpAndDeMaSVRoom.Name = "txtUpAndDeMaSVRoom";
            this.txtUpAndDeMaSVRoom.ReadOnly = true;
            this.txtUpAndDeMaSVRoom.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaSVRoom.TabIndex = 16;
            // 
            // UserControlRooms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlRooms";
            this.Size = new System.Drawing.Size(1166, 461);
            this.Load += new System.EventHandler(this.UserControlRooms_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpDeRoom.ResumeLayout(false);
            this.tabPageUpDeRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtAddKiHieuRoom;
        private System.Windows.Forms.TextBox txtAddMaPhongRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TextBox txtSearchMaPhongRoom;
        private System.Windows.Forms.Label lblSearchRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.ComboBox cbBoxAddMaSvRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpAndDeKiHieuRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpAndDeMaPhongRoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddGiaPhongRoom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUpAndDeGiaPhongRoom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbBoxAddLoaiPhongRoom;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeLoaiPhongRoom;
        private System.Windows.Forms.TextBox txtUpAndDeMaSVRoom;
    }
}
