namespace Dormitory_Winform.UserControls
{
    partial class UserControlIntoRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlIntoRoom));
            this.tabControlIntoRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddIntoRoom = new System.Windows.Forms.TabPage();
            this.btnAddIntoRoom = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxAddMaSVIntoRoom = new System.Windows.Forms.ComboBox();
            this.dateTimeAddNgayVaoIntoRoom = new System.Windows.Forms.DateTimePicker();
            this.cbBoxAddMaPhongIntoRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxAddLoaiPhongDkiIntoRoom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageSearchIntoRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewIntoRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchIntoRoom = new System.Windows.Forms.TextBox();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeIntoRoom = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBoxUpAndDeMaSVIntoRoom = new System.Windows.Forms.ComboBox();
            this.dateTimeUpAndDeNgayVaoIntoRoom = new System.Windows.Forms.DateTimePicker();
            this.cbBoxUpAndDeMaPhongIntoRoom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteIntoRoom = new System.Windows.Forms.Button();
            this.btnUpdateIntoRoom = new System.Windows.Forms.Button();
            this.tabControlIntoRoom.SuspendLayout();
            this.tabPageAddIntoRoom.SuspendLayout();
            this.tabPageSearchIntoRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntoRoom)).BeginInit();
            this.tabPageUpDeIntoRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlIntoRoom
            // 
            this.tabControlIntoRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlIntoRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlIntoRoom.Controls.Add(this.tabPageAddIntoRoom);
            this.tabControlIntoRoom.Controls.Add(this.tabPageSearchIntoRoom);
            this.tabControlIntoRoom.Controls.Add(this.tabPageUpDeIntoRoom);
            this.tabControlIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlIntoRoom.Location = new System.Drawing.Point(0, 0);
            this.tabControlIntoRoom.Name = "tabControlIntoRoom";
            this.tabControlIntoRoom.SelectedIndex = 0;
            this.tabControlIntoRoom.Size = new System.Drawing.Size(1156, 438);
            this.tabControlIntoRoom.TabIndex = 3;
            // 
            // tabPageAddIntoRoom
            // 
            this.tabPageAddIntoRoom.Controls.Add(this.btnAddIntoRoom);
            this.tabPageAddIntoRoom.Controls.Add(this.label18);
            this.tabPageAddIntoRoom.Controls.Add(this.label3);
            this.tabPageAddIntoRoom.Controls.Add(this.label1);
            this.tabPageAddIntoRoom.Controls.Add(this.cbBoxAddMaSVIntoRoom);
            this.tabPageAddIntoRoom.Controls.Add(this.dateTimeAddNgayVaoIntoRoom);
            this.tabPageAddIntoRoom.Controls.Add(this.cbBoxAddMaPhongIntoRoom);
            this.tabPageAddIntoRoom.Controls.Add(this.label2);
            this.tabPageAddIntoRoom.Controls.Add(this.cbBoxAddLoaiPhongDkiIntoRoom);
            this.tabPageAddIntoRoom.Controls.Add(this.label9);
            this.tabPageAddIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddIntoRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddIntoRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddIntoRoom.Name = "tabPageAddIntoRoom";
            this.tabPageAddIntoRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddIntoRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageAddIntoRoom.TabIndex = 0;
            this.tabPageAddIntoRoom.Text = "Add";
            this.tabPageAddIntoRoom.UseVisualStyleBackColor = true;
            this.tabPageAddIntoRoom.Leave += new System.EventHandler(this.tabPageAddIntoRoom_Leave);
            // 
            // btnAddIntoRoom
            // 
            this.btnAddIntoRoom.BackColor = System.Drawing.Color.Navy;
            this.btnAddIntoRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddIntoRoom.BackgroundImage")));
            this.btnAddIntoRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddIntoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIntoRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIntoRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddIntoRoom.Location = new System.Drawing.Point(244, 258);
            this.btnAddIntoRoom.Name = "btnAddIntoRoom";
            this.btnAddIntoRoom.Size = new System.Drawing.Size(111, 40);
            this.btnAddIntoRoom.TabIndex = 4;
            this.btnAddIntoRoom.Text = "Add";
            this.btnAddIntoRoom.UseVisualStyleBackColor = false;
            this.btnAddIntoRoom.Click += new System.EventHandler(this.btnAddIntoRoom_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(608, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Ngay vao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Into Rooms:";
            // 
            // cbBoxAddMaSVIntoRoom
            // 
            this.cbBoxAddMaSVIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxAddMaSVIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxAddMaSVIntoRoom.FormattingEnabled = true;
            this.cbBoxAddMaSVIntoRoom.Items.AddRange(new object[] {
            "Please select ..."});
            this.cbBoxAddMaSVIntoRoom.Location = new System.Drawing.Point(608, 111);
            this.cbBoxAddMaSVIntoRoom.Name = "cbBoxAddMaSVIntoRoom";
            this.cbBoxAddMaSVIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaSVIntoRoom.TabIndex = 7;
            this.cbBoxAddMaSVIntoRoom.SelectedIndexChanged += new System.EventHandler(this.cbBoxAddMaSVIntoRoom_SelectedIndexChanged);
            // 
            // dateTimeAddNgayVaoIntoRoom
            // 
            this.dateTimeAddNgayVaoIntoRoom.Location = new System.Drawing.Point(608, 190);
            this.dateTimeAddNgayVaoIntoRoom.Name = "dateTimeAddNgayVaoIntoRoom";
            this.dateTimeAddNgayVaoIntoRoom.Size = new System.Drawing.Size(263, 23);
            this.dateTimeAddNgayVaoIntoRoom.TabIndex = 9;
            // 
            // cbBoxAddMaPhongIntoRoom
            // 
            this.cbBoxAddMaPhongIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxAddMaPhongIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxAddMaPhongIntoRoom.FormattingEnabled = true;
            this.cbBoxAddMaPhongIntoRoom.Items.AddRange(new object[] {
            "Please select ..."});
            this.cbBoxAddMaPhongIntoRoom.Location = new System.Drawing.Point(244, 190);
            this.cbBoxAddMaPhongIntoRoom.Name = "cbBoxAddMaPhongIntoRoom";
            this.cbBoxAddMaPhongIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaPhongIntoRoom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phong co san:";
            // 
            // cbBoxAddLoaiPhongDkiIntoRoom
            // 
            this.cbBoxAddLoaiPhongDkiIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxAddLoaiPhongDkiIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxAddLoaiPhongDkiIntoRoom.FormattingEnabled = true;
            this.cbBoxAddLoaiPhongDkiIntoRoom.Items.AddRange(new object[] {
            "Please select ...",
            "A",
            "B"});
            this.cbBoxAddLoaiPhongDkiIntoRoom.Location = new System.Drawing.Point(244, 111);
            this.cbBoxAddLoaiPhongDkiIntoRoom.Name = "cbBoxAddLoaiPhongDkiIntoRoom";
            this.cbBoxAddLoaiPhongDkiIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddLoaiPhongDkiIntoRoom.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loai phong da dang ki:";
            // 
            // tabPageSearchIntoRoom
            // 
            this.tabPageSearchIntoRoom.Controls.Add(this.dataGridViewIntoRoom);
            this.tabPageSearchIntoRoom.Controls.Add(this.txtSearchIntoRoom);
            this.tabPageSearchIntoRoom.Controls.Add(this.lblSearchRoom);
            this.tabPageSearchIntoRoom.Controls.Add(this.label4);
            this.tabPageSearchIntoRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchIntoRoom.Name = "tabPageSearchIntoRoom";
            this.tabPageSearchIntoRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchIntoRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageSearchIntoRoom.TabIndex = 1;
            this.tabPageSearchIntoRoom.Text = "Search";
            this.tabPageSearchIntoRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIntoRoom
            // 
            this.dataGridViewIntoRoom.AllowUserToAddRows = false;
            this.dataGridViewIntoRoom.AllowUserToDeleteRows = false;
            this.dataGridViewIntoRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntoRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewIntoRoom.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewIntoRoom.Name = "dataGridViewIntoRoom";
            this.dataGridViewIntoRoom.ReadOnly = true;
            this.dataGridViewIntoRoom.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewIntoRoom.TabIndex = 6;
            this.dataGridViewIntoRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIntoRoom_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "MaSVVaoPhong";
            this.Column1.HeaderText = "Ma ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "MaSV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "LoaiPhongSVDangKi";
            this.Column3.HeaderText = "Loai phong dang ki";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MaPhong";
            this.Column4.HeaderText = "Ma phong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgayVao";
            this.Column5.HeaderText = "Ngay Vao";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtSearchIntoRoom
            // 
            this.txtSearchIntoRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIntoRoom.Location = new System.Drawing.Point(295, 77);
            this.txtSearchIntoRoom.Name = "txtSearchIntoRoom";
            this.txtSearchIntoRoom.Size = new System.Drawing.Size(263, 23);
            this.txtSearchIntoRoom.TabIndex = 5;
            this.txtSearchIntoRoom.TextChanged += new System.EventHandler(this.txtSearchIntoRoom_TextChanged);
            this.txtSearchIntoRoom.Leave += new System.EventHandler(this.txtSearchIntoRoom_Leave);
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.AutoSize = true;
            this.lblSearchRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRoom.Location = new System.Drawing.Point(295, 43);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.Size = new System.Drawing.Size(69, 16);
            this.lblSearchRoom.TabIndex = 4;
            this.lblSearchRoom.Text = "Tim kiem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Into Room: ";
            // 
            // tabPageUpDeIntoRoom
            // 
            this.tabPageUpDeIntoRoom.Controls.Add(this.label6);
            this.tabPageUpDeIntoRoom.Controls.Add(this.label7);
            this.tabPageUpDeIntoRoom.Controls.Add(this.cbBoxUpAndDeMaSVIntoRoom);
            this.tabPageUpDeIntoRoom.Controls.Add(this.dateTimeUpAndDeNgayVaoIntoRoom);
            this.tabPageUpDeIntoRoom.Controls.Add(this.cbBoxUpAndDeMaPhongIntoRoom);
            this.tabPageUpDeIntoRoom.Controls.Add(this.label8);
            this.tabPageUpDeIntoRoom.Controls.Add(this.cbBoxUpAndDeLoaiPhongDkiIntoRoom);
            this.tabPageUpDeIntoRoom.Controls.Add(this.label10);
            this.tabPageUpDeIntoRoom.Controls.Add(this.label5);
            this.tabPageUpDeIntoRoom.Controls.Add(this.btnDeleteIntoRoom);
            this.tabPageUpDeIntoRoom.Controls.Add(this.btnUpdateIntoRoom);
            this.tabPageUpDeIntoRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeIntoRoom.Name = "tabPageUpDeIntoRoom";
            this.tabPageUpDeIntoRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeIntoRoom.Size = new System.Drawing.Size(1148, 408);
            this.tabPageUpDeIntoRoom.TabIndex = 2;
            this.tabPageUpDeIntoRoom.Text = "Update and Delete ";
            this.tabPageUpDeIntoRoom.UseVisualStyleBackColor = true;
            this.tabPageUpDeIntoRoom.Leave += new System.EventHandler(this.tabPageUpDeIntoRoom_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngay vao:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(625, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ma SV:";
            // 
            // cbBoxUpAndDeMaSVIntoRoom
            // 
            this.cbBoxUpAndDeMaSVIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxUpAndDeMaSVIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxUpAndDeMaSVIntoRoom.FormattingEnabled = true;
            this.cbBoxUpAndDeMaSVIntoRoom.Location = new System.Drawing.Point(625, 128);
            this.cbBoxUpAndDeMaSVIntoRoom.Name = "cbBoxUpAndDeMaSVIntoRoom";
            this.cbBoxUpAndDeMaSVIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeMaSVIntoRoom.TabIndex = 16;
            this.cbBoxUpAndDeMaSVIntoRoom.SelectedIndexChanged += new System.EventHandler(this.cbBoxUpAndDeMaSVIntoRoom_SelectedIndexChanged);
            // 
            // dateTimeUpAndDeNgayVaoIntoRoom
            // 
            this.dateTimeUpAndDeNgayVaoIntoRoom.Location = new System.Drawing.Point(625, 207);
            this.dateTimeUpAndDeNgayVaoIntoRoom.Name = "dateTimeUpAndDeNgayVaoIntoRoom";
            this.dateTimeUpAndDeNgayVaoIntoRoom.Size = new System.Drawing.Size(263, 23);
            this.dateTimeUpAndDeNgayVaoIntoRoom.TabIndex = 19;
            // 
            // cbBoxUpAndDeMaPhongIntoRoom
            // 
            this.cbBoxUpAndDeMaPhongIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxUpAndDeMaPhongIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxUpAndDeMaPhongIntoRoom.FormattingEnabled = true;
            this.cbBoxUpAndDeMaPhongIntoRoom.Location = new System.Drawing.Point(261, 207);
            this.cbBoxUpAndDeMaPhongIntoRoom.Name = "cbBoxUpAndDeMaPhongIntoRoom";
            this.cbBoxUpAndDeMaPhongIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeMaPhongIntoRoom.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phong co san:";
            // 
            // cbBoxUpAndDeLoaiPhongDkiIntoRoom
            // 
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.FormattingEnabled = true;
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.Location = new System.Drawing.Point(261, 128);
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.Name = "cbBoxUpAndDeLoaiPhongDkiIntoRoom";
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeLoaiPhongDkiIntoRoom.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Loai phong da dang ki:";
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
            // btnDeleteIntoRoom
            // 
            this.btnDeleteIntoRoom.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteIntoRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteIntoRoom.BackgroundImage")));
            this.btnDeleteIntoRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteIntoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIntoRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIntoRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIntoRoom.Location = new System.Drawing.Point(402, 275);
            this.btnDeleteIntoRoom.Name = "btnDeleteIntoRoom";
            this.btnDeleteIntoRoom.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteIntoRoom.TabIndex = 9;
            this.btnDeleteIntoRoom.Text = "Delete";
            this.btnDeleteIntoRoom.UseVisualStyleBackColor = false;
            this.btnDeleteIntoRoom.Click += new System.EventHandler(this.btnDeleteIntoRoom_Click);
            // 
            // btnUpdateIntoRoom
            // 
            this.btnUpdateIntoRoom.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateIntoRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateIntoRoom.BackgroundImage")));
            this.btnUpdateIntoRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateIntoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateIntoRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateIntoRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateIntoRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIntoRoom.Location = new System.Drawing.Point(261, 275);
            this.btnUpdateIntoRoom.Name = "btnUpdateIntoRoom";
            this.btnUpdateIntoRoom.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateIntoRoom.TabIndex = 9;
            this.btnUpdateIntoRoom.Text = "Update";
            this.btnUpdateIntoRoom.UseVisualStyleBackColor = false;
            this.btnUpdateIntoRoom.Click += new System.EventHandler(this.btnUpdateIntoRoom_Click);
            // 
            // UserControlIntoRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlIntoRoom);
            this.Name = "UserControlIntoRoom";
            this.Size = new System.Drawing.Size(1156, 438);
            this.Load += new System.EventHandler(this.UserControlIntoRoom_Load);
            this.tabControlIntoRoom.ResumeLayout(false);
            this.tabPageAddIntoRoom.ResumeLayout(false);
            this.tabPageAddIntoRoom.PerformLayout();
            this.tabPageSearchIntoRoom.ResumeLayout(false);
            this.tabPageSearchIntoRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntoRoom)).EndInit();
            this.tabPageUpDeIntoRoom.ResumeLayout(false);
            this.tabPageUpDeIntoRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIntoRoom;
        private System.Windows.Forms.TabPage tabPageAddIntoRoom;
        private System.Windows.Forms.ComboBox cbBoxAddLoaiPhongDkiIntoRoom;
        private System.Windows.Forms.Button btnAddIntoRoom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxAddMaSVIntoRoom;
        private System.Windows.Forms.DateTimePicker dateTimeAddNgayVaoIntoRoom;
        private System.Windows.Forms.TabPage tabPageSearchIntoRoom;
        private System.Windows.Forms.DataGridView dataGridViewIntoRoom;
        private System.Windows.Forms.TextBox txtSearchIntoRoom;
        private System.Windows.Forms.Label lblSearchRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeIntoRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteIntoRoom;
        private System.Windows.Forms.Button btnUpdateIntoRoom;
        private System.Windows.Forms.ComboBox cbBoxAddMaPhongIntoRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeMaSVIntoRoom;
        private System.Windows.Forms.DateTimePicker dateTimeUpAndDeNgayVaoIntoRoom;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeMaPhongIntoRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeLoaiPhongDkiIntoRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
