namespace Dormitory_Winform.UserControls
{
    partial class UserControlFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFee));
            this.tabControlFee = new System.Windows.Forms.TabControl();
            this.tabPageAddFee = new System.Windows.Forms.TabPage();
            this.cbBoxAddMaSVFee = new System.Windows.Forms.ComboBox();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.txtAddTienDienNuocFee = new System.Windows.Forms.TextBox();
            this.txtAddTienGuiXeFee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddTienPhongFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddTienInternetFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeAddNgayThanhToanFee = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewFee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMaKPFee = new System.Windows.Forms.TextBox();
            this.lblSearchFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeFee = new System.Windows.Forms.TabPage();
            this.txtUpAndDeTienDienNuocFee = new System.Windows.Forms.TextBox();
            this.txtUpAndDeTienGuiXeFee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpAndDeTienPhongFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpAndDeTienInternetFee = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaSVFee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteFee = new System.Windows.Forms.Button();
            this.btnUpdateFee = new System.Windows.Forms.Button();
            this.dateTimeUpAndDeNgayThanhToanFee = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControlFee.SuspendLayout();
            this.tabPageAddFee.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).BeginInit();
            this.tabPageUpDeFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFee
            // 
            this.tabControlFee.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlFee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlFee.Controls.Add(this.tabPageAddFee);
            this.tabControlFee.Controls.Add(this.tabPageSearchRoom);
            this.tabControlFee.Controls.Add(this.tabPageUpDeFee);
            this.tabControlFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlFee.Location = new System.Drawing.Point(0, 4);
            this.tabControlFee.Name = "tabControlFee";
            this.tabControlFee.SelectedIndex = 0;
            this.tabControlFee.Size = new System.Drawing.Size(1156, 430);
            this.tabControlFee.TabIndex = 3;
            // 
            // tabPageAddFee
            // 
            this.tabPageAddFee.Controls.Add(this.cbBoxAddMaSVFee);
            this.tabPageAddFee.Controls.Add(this.btnAddFee);
            this.tabPageAddFee.Controls.Add(this.txtAddTienDienNuocFee);
            this.tabPageAddFee.Controls.Add(this.txtAddTienGuiXeFee);
            this.tabPageAddFee.Controls.Add(this.label9);
            this.tabPageAddFee.Controls.Add(this.txtAddTienPhongFee);
            this.tabPageAddFee.Controls.Add(this.label8);
            this.tabPageAddFee.Controls.Add(this.txtAddTienInternetFee);
            this.tabPageAddFee.Controls.Add(this.label7);
            this.tabPageAddFee.Controls.Add(this.label6);
            this.tabPageAddFee.Controls.Add(this.label3);
            this.tabPageAddFee.Controls.Add(this.label1);
            this.tabPageAddFee.Controls.Add(this.dateTimeAddNgayThanhToanFee);
            this.tabPageAddFee.Controls.Add(this.label16);
            this.tabPageAddFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddFee.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddFee.Name = "tabPageAddFee";
            this.tabPageAddFee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddFee.Size = new System.Drawing.Size(1148, 400);
            this.tabPageAddFee.TabIndex = 0;
            this.tabPageAddFee.Text = "Add";
            this.tabPageAddFee.UseVisualStyleBackColor = true;
            this.tabPageAddFee.Leave += new System.EventHandler(this.tabPageAddFee_Leave);
            // 
            // cbBoxAddMaSVFee
            // 
            this.cbBoxAddMaSVFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxAddMaSVFee.FormattingEnabled = true;
            this.cbBoxAddMaSVFee.Location = new System.Drawing.Point(259, 85);
            this.cbBoxAddMaSVFee.Name = "cbBoxAddMaSVFee";
            this.cbBoxAddMaSVFee.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaSVFee.TabIndex = 7;
            // 
            // btnAddFee
            // 
            this.btnAddFee.BackColor = System.Drawing.Color.Navy;
            this.btnAddFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFee.BackgroundImage")));
            this.btnAddFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFee.ForeColor = System.Drawing.Color.White;
            this.btnAddFee.Location = new System.Drawing.Point(259, 303);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(111, 41);
            this.btnAddFee.TabIndex = 4;
            this.btnAddFee.Text = "Add";
            this.btnAddFee.UseVisualStyleBackColor = false;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // txtAddTienDienNuocFee
            // 
            this.txtAddTienDienNuocFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienDienNuocFee.Location = new System.Drawing.Point(627, 245);
            this.txtAddTienDienNuocFee.Name = "txtAddTienDienNuocFee";
            this.txtAddTienDienNuocFee.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienDienNuocFee.TabIndex = 3;
            // 
            // txtAddTienGuiXeFee
            // 
            this.txtAddTienGuiXeFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienGuiXeFee.Location = new System.Drawing.Point(259, 245);
            this.txtAddTienGuiXeFee.Name = "txtAddTienGuiXeFee";
            this.txtAddTienGuiXeFee.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienGuiXeFee.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tien dien va nuoc:";
            // 
            // txtAddTienPhongFee
            // 
            this.txtAddTienPhongFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienPhongFee.Location = new System.Drawing.Point(627, 167);
            this.txtAddTienPhongFee.Name = "txtAddTienPhongFee";
            this.txtAddTienPhongFee.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienPhongFee.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tien gui xe:";
            // 
            // txtAddTienInternetFee
            // 
            this.txtAddTienInternetFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienInternetFee.Location = new System.Drawing.Point(259, 167);
            this.txtAddTienInternetFee.Name = "txtAddTienInternetFee";
            this.txtAddTienInternetFee.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienInternetFee.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tien phong:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tien internet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 58);
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
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Fee:";
            // 
            // dateTimeAddNgayThanhToanFee
            // 
            this.dateTimeAddNgayThanhToanFee.Location = new System.Drawing.Point(627, 87);
            this.dateTimeAddNgayThanhToanFee.Name = "dateTimeAddNgayThanhToanFee";
            this.dateTimeAddNgayThanhToanFee.Size = new System.Drawing.Size(260, 23);
            this.dateTimeAddNgayThanhToanFee.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(627, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ngay thanh toan:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewFee);
            this.tabPageSearchRoom.Controls.Add(this.txtSearchMaKPFee);
            this.tabPageSearchRoom.Controls.Add(this.lblSearchFee);
            this.tabPageSearchRoom.Controls.Add(this.label4);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1148, 400);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFee
            // 
            this.dataGridViewFee.AllowUserToAddRows = false;
            this.dataGridViewFee.AllowUserToDeleteRows = false;
            this.dataGridViewFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewFee.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewFee.Name = "dataGridViewFee";
            this.dataGridViewFee.ReadOnly = true;
            this.dataGridViewFee.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewFee.TabIndex = 6;
            this.dataGridViewFee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFee_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKhoanPhi";
            this.Column1.HeaderText = "Ma Khoan Phi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "Ma SV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NgayThanhToan";
            this.Column3.HeaderText = "Ngay Thanh Toan";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "TienPhong";
            this.Column4.HeaderText = "Tien Phong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 95;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "TienInternet";
            this.Column5.HeaderText = "Tien Internet";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 101;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.DataPropertyName = "TienGuiXe";
            this.Column6.HeaderText = "Tien Gui Xe";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "TienDienVaNuoc";
            this.Column7.HeaderText = "Tien Dien Va Nuoc";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtSearchMaKPFee
            // 
            this.txtSearchMaKPFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaKPFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaKPFee.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaKPFee.Name = "txtSearchMaKPFee";
            this.txtSearchMaKPFee.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaKPFee.TabIndex = 5;
            this.txtSearchMaKPFee.TextChanged += new System.EventHandler(this.txtSearchMaKPFee_TextChanged);
            this.txtSearchMaKPFee.Leave += new System.EventHandler(this.txtSearchMaKPFee_Leave);
            // 
            // lblSearchFee
            // 
            this.lblSearchFee.AutoSize = true;
            this.lblSearchFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFee.Location = new System.Drawing.Point(295, 43);
            this.lblSearchFee.Name = "lblSearchFee";
            this.lblSearchFee.Size = new System.Drawing.Size(100, 16);
            this.lblSearchFee.TabIndex = 4;
            this.lblSearchFee.Text = "Ma Khoan Phi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Fee: ";
            // 
            // tabPageUpDeFee
            // 
            this.tabPageUpDeFee.Controls.Add(this.txtUpAndDeTienDienNuocFee);
            this.tabPageUpDeFee.Controls.Add(this.txtUpAndDeTienGuiXeFee);
            this.tabPageUpDeFee.Controls.Add(this.label10);
            this.tabPageUpDeFee.Controls.Add(this.txtUpAndDeTienPhongFee);
            this.tabPageUpDeFee.Controls.Add(this.label12);
            this.tabPageUpDeFee.Controls.Add(this.txtUpAndDeTienInternetFee);
            this.tabPageUpDeFee.Controls.Add(this.label13);
            this.tabPageUpDeFee.Controls.Add(this.txtUpAndDeMaSVFee);
            this.tabPageUpDeFee.Controls.Add(this.label14);
            this.tabPageUpDeFee.Controls.Add(this.label15);
            this.tabPageUpDeFee.Controls.Add(this.label5);
            this.tabPageUpDeFee.Controls.Add(this.btnDeleteFee);
            this.tabPageUpDeFee.Controls.Add(this.btnUpdateFee);
            this.tabPageUpDeFee.Controls.Add(this.dateTimeUpAndDeNgayThanhToanFee);
            this.tabPageUpDeFee.Controls.Add(this.label11);
            this.tabPageUpDeFee.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeFee.Name = "tabPageUpDeFee";
            this.tabPageUpDeFee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeFee.Size = new System.Drawing.Size(1148, 400);
            this.tabPageUpDeFee.TabIndex = 2;
            this.tabPageUpDeFee.Text = "Update and Delete ";
            this.tabPageUpDeFee.UseVisualStyleBackColor = true;
            this.tabPageUpDeFee.Leave += new System.EventHandler(this.tabPageUpDeFee_Leave);
            // 
            // txtUpAndDeTienDienNuocFee
            // 
            this.txtUpAndDeTienDienNuocFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienDienNuocFee.Location = new System.Drawing.Point(627, 245);
            this.txtUpAndDeTienDienNuocFee.Name = "txtUpAndDeTienDienNuocFee";
            this.txtUpAndDeTienDienNuocFee.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienDienNuocFee.TabIndex = 18;
            // 
            // txtUpAndDeTienGuiXeFee
            // 
            this.txtUpAndDeTienGuiXeFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienGuiXeFee.Location = new System.Drawing.Point(261, 244);
            this.txtUpAndDeTienGuiXeFee.Name = "txtUpAndDeTienGuiXeFee";
            this.txtUpAndDeTienGuiXeFee.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienGuiXeFee.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(627, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tien dien va nuoc:";
            // 
            // txtUpAndDeTienPhongFee
            // 
            this.txtUpAndDeTienPhongFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienPhongFee.Location = new System.Drawing.Point(627, 167);
            this.txtUpAndDeTienPhongFee.Name = "txtUpAndDeTienPhongFee";
            this.txtUpAndDeTienPhongFee.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienPhongFee.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(261, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tien gui xe:";
            // 
            // txtUpAndDeTienInternetFee
            // 
            this.txtUpAndDeTienInternetFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienInternetFee.Location = new System.Drawing.Point(261, 166);
            this.txtUpAndDeTienInternetFee.Name = "txtUpAndDeTienInternetFee";
            this.txtUpAndDeTienInternetFee.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienInternetFee.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(627, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tien phong:";
            // 
            // txtUpAndDeMaSVFee
            // 
            this.txtUpAndDeMaSVFee.BackColor = System.Drawing.Color.White;
            this.txtUpAndDeMaSVFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaSVFee.Location = new System.Drawing.Point(261, 89);
            this.txtUpAndDeMaSVFee.Name = "txtUpAndDeMaSVFee";
            this.txtUpAndDeMaSVFee.ReadOnly = true;
            this.txtUpAndDeMaSVFee.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaSVFee.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(261, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Tien internet:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(261, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ma SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update and Delete Fee:";
            // 
            // btnDeleteFee
            // 
            this.btnDeleteFee.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteFee.BackgroundImage")));
            this.btnDeleteFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFee.Location = new System.Drawing.Point(399, 303);
            this.btnDeleteFee.Name = "btnDeleteFee";
            this.btnDeleteFee.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteFee.TabIndex = 9;
            this.btnDeleteFee.Text = "Delete";
            this.btnDeleteFee.UseVisualStyleBackColor = false;
            this.btnDeleteFee.Click += new System.EventHandler(this.btnDeleteFee_Click);
            // 
            // btnUpdateFee
            // 
            this.btnUpdateFee.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateFee.BackgroundImage")));
            this.btnUpdateFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFee.Location = new System.Drawing.Point(259, 303);
            this.btnUpdateFee.Name = "btnUpdateFee";
            this.btnUpdateFee.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateFee.TabIndex = 9;
            this.btnUpdateFee.Text = "Update";
            this.btnUpdateFee.UseVisualStyleBackColor = false;
            this.btnUpdateFee.Click += new System.EventHandler(this.btnUpdateFee_Click);
            // 
            // dateTimeUpAndDeNgayThanhToanFee
            // 
            this.dateTimeUpAndDeNgayThanhToanFee.Location = new System.Drawing.Point(627, 86);
            this.dateTimeUpAndDeNgayThanhToanFee.Name = "dateTimeUpAndDeNgayThanhToanFee";
            this.dateTimeUpAndDeNgayThanhToanFee.Size = new System.Drawing.Size(263, 23);
            this.dateTimeUpAndDeNgayThanhToanFee.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(627, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ngay thanh toan:";
            // 
            // UserControlFee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlFee);
            this.Name = "UserControlFee";
            this.Size = new System.Drawing.Size(1156, 438);
            this.Load += new System.EventHandler(this.UserControlFee_Load);
            this.tabControlFee.ResumeLayout(false);
            this.tabPageAddFee.ResumeLayout(false);
            this.tabPageAddFee.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).EndInit();
            this.tabPageUpDeFee.ResumeLayout(false);
            this.tabPageUpDeFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFee;
        private System.Windows.Forms.TabPage tabPageAddFee;
        private System.Windows.Forms.ComboBox cbBoxAddMaSVFee;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.TextBox txtAddTienInternetFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.DataGridView dataGridViewFee;
        private System.Windows.Forms.TextBox txtSearchMaKPFee;
        private System.Windows.Forms.Label lblSearchFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteFee;
        private System.Windows.Forms.Button btnUpdateFee;
        private System.Windows.Forms.TextBox txtAddTienDienNuocFee;
        private System.Windows.Forms.TextBox txtAddTienGuiXeFee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddTienPhongFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpAndDeTienDienNuocFee;
        private System.Windows.Forms.TextBox txtUpAndDeTienGuiXeFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpAndDeTienPhongFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpAndDeTienInternetFee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimeAddNgayThanhToanFee;
        private System.Windows.Forms.DateTimePicker dateTimeUpAndDeNgayThanhToanFee;
        private System.Windows.Forms.TextBox txtUpAndDeMaSVFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
