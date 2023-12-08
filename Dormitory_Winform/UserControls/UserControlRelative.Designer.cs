namespace Dormitory_Winform.UserControls
{
    partial class UserControlRelative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRelative));
            this.tabControlRelatives = new System.Windows.Forms.TabControl();
            this.tabPageAddRelatives = new System.Windows.Forms.TabPage();
            this.dateTimeAddNgayThamRelatives = new System.Windows.Forms.DateTimePicker();
            this.cbBoxAddMaSvRelatives = new System.Windows.Forms.ComboBox();
            this.btnAddRelatives = new System.Windows.Forms.Button();
            this.txtAddSoDTRelatives = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddTenRelatives = new System.Windows.Forms.TextBox();
            this.txtAddDiaChiRelatives = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddMaNTRelatives = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearchRelatives = new System.Windows.Forms.TabPage();
            this.dataGridViewRelatives = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMaNTRelatives = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeRelatives = new System.Windows.Forms.TabPage();
            this.dateTimeUpAnDeNgayThamRelatives = new System.Windows.Forms.DateTimePicker();
            this.txtUpAndDeTenRelatives = new System.Windows.Forms.TextBox();
            this.txtUpAndDeSDTRelatives = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpAndDeDiaChiRelatives = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaSVRelatives = new System.Windows.Forms.TextBox();
            this.txtUpAndDeMaNTRelatives = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteRelatives = new System.Windows.Forms.Button();
            this.btnUpdateRelatives = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.tabControlRelatives.SuspendLayout();
            this.tabPageAddRelatives.SuspendLayout();
            this.tabPageSearchRelatives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatives)).BeginInit();
            this.tabPageUpDeRelatives.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DarkBlue;
            label1.Location = new System.Drawing.Point(4, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 18);
            label1.TabIndex = 0;
            label1.Text = "Add Relatives:";
            // 
            // tabControlRelatives
            // 
            this.tabControlRelatives.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRelatives.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRelatives.Controls.Add(this.tabPageAddRelatives);
            this.tabControlRelatives.Controls.Add(this.tabPageSearchRelatives);
            this.tabControlRelatives.Controls.Add(this.tabPageUpDeRelatives);
            this.tabControlRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRelatives.Location = new System.Drawing.Point(0, 4);
            this.tabControlRelatives.Name = "tabControlRelatives";
            this.tabControlRelatives.SelectedIndex = 0;
            this.tabControlRelatives.Size = new System.Drawing.Size(1156, 430);
            this.tabControlRelatives.TabIndex = 4;
            // 
            // tabPageAddRelatives
            // 
            this.tabPageAddRelatives.Controls.Add(this.dateTimeAddNgayThamRelatives);
            this.tabPageAddRelatives.Controls.Add(this.cbBoxAddMaSvRelatives);
            this.tabPageAddRelatives.Controls.Add(this.btnAddRelatives);
            this.tabPageAddRelatives.Controls.Add(this.txtAddSoDTRelatives);
            this.tabPageAddRelatives.Controls.Add(this.label9);
            this.tabPageAddRelatives.Controls.Add(this.label16);
            this.tabPageAddRelatives.Controls.Add(this.txtAddTenRelatives);
            this.tabPageAddRelatives.Controls.Add(this.txtAddDiaChiRelatives);
            this.tabPageAddRelatives.Controls.Add(this.label7);
            this.tabPageAddRelatives.Controls.Add(this.txtAddMaNTRelatives);
            this.tabPageAddRelatives.Controls.Add(this.label6);
            this.tabPageAddRelatives.Controls.Add(this.label3);
            this.tabPageAddRelatives.Controls.Add(this.label2);
            this.tabPageAddRelatives.Controls.Add(label1);
            this.tabPageAddRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddRelatives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddRelatives.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRelatives.Name = "tabPageAddRelatives";
            this.tabPageAddRelatives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRelatives.Size = new System.Drawing.Size(1148, 400);
            this.tabPageAddRelatives.TabIndex = 0;
            this.tabPageAddRelatives.Text = "Add";
            this.tabPageAddRelatives.UseVisualStyleBackColor = true;
            // 
            // dateTimeAddNgayThamRelatives
            // 
            this.dateTimeAddNgayThamRelatives.Location = new System.Drawing.Point(258, 170);
            this.dateTimeAddNgayThamRelatives.Name = "dateTimeAddNgayThamRelatives";
            this.dateTimeAddNgayThamRelatives.Size = new System.Drawing.Size(263, 23);
            this.dateTimeAddNgayThamRelatives.TabIndex = 8;
            // 
            // cbBoxAddMaSvRelatives
            // 
            this.cbBoxAddMaSvRelatives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxAddMaSvRelatives.FormattingEnabled = true;
            this.cbBoxAddMaSvRelatives.Location = new System.Drawing.Point(627, 87);
            this.cbBoxAddMaSvRelatives.Name = "cbBoxAddMaSvRelatives";
            this.cbBoxAddMaSvRelatives.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaSvRelatives.TabIndex = 7;
            // 
            // btnAddRelatives
            // 
            this.btnAddRelatives.BackColor = System.Drawing.Color.Navy;
            this.btnAddRelatives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRelatives.BackgroundImage")));
            this.btnAddRelatives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRelatives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRelatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelatives.ForeColor = System.Drawing.Color.White;
            this.btnAddRelatives.Location = new System.Drawing.Point(258, 307);
            this.btnAddRelatives.Name = "btnAddRelatives";
            this.btnAddRelatives.Size = new System.Drawing.Size(111, 41);
            this.btnAddRelatives.TabIndex = 4;
            this.btnAddRelatives.Text = "Add";
            this.btnAddRelatives.UseVisualStyleBackColor = false;
            this.btnAddRelatives.Click += new System.EventHandler(this.btnAddRelatives_Click);
            // 
            // txtAddSoDTRelatives
            // 
            this.txtAddSoDTRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddSoDTRelatives.Location = new System.Drawing.Point(627, 245);
            this.txtAddSoDTRelatives.Name = "txtAddSoDTRelatives";
            this.txtAddSoDTRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtAddSoDTRelatives.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "So dien thoai:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(258, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ngay tham:";
            // 
            // txtAddTenRelatives
            // 
            this.txtAddTenRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTenRelatives.Location = new System.Drawing.Point(627, 170);
            this.txtAddTenRelatives.Name = "txtAddTenRelatives";
            this.txtAddTenRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtAddTenRelatives.TabIndex = 3;
            // 
            // txtAddDiaChiRelatives
            // 
            this.txtAddDiaChiRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddDiaChiRelatives.Location = new System.Drawing.Point(258, 245);
            this.txtAddDiaChiRelatives.Name = "txtAddDiaChiRelatives";
            this.txtAddDiaChiRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtAddDiaChiRelatives.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ten:";
            // 
            // txtAddMaNTRelatives
            // 
            this.txtAddMaNTRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddMaNTRelatives.Location = new System.Drawing.Point(258, 87);
            this.txtAddMaNTRelatives.Name = "txtAddMaNTRelatives";
            this.txtAddMaNTRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtAddMaNTRelatives.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dia chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma Nguoi Than:";
            // 
            // tabPageSearchRelatives
            // 
            this.tabPageSearchRelatives.Controls.Add(this.dataGridViewRelatives);
            this.tabPageSearchRelatives.Controls.Add(this.txtSearchMaNTRelatives);
            this.tabPageSearchRelatives.Controls.Add(this.lblSearch);
            this.tabPageSearchRelatives.Controls.Add(this.label4);
            this.tabPageSearchRelatives.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRelatives.Name = "tabPageSearchRelatives";
            this.tabPageSearchRelatives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRelatives.Size = new System.Drawing.Size(1148, 400);
            this.tabPageSearchRelatives.TabIndex = 1;
            this.tabPageSearchRelatives.Text = "Search";
            this.tabPageSearchRelatives.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRelatives
            // 
            this.dataGridViewRelatives.AllowUserToAddRows = false;
            this.dataGridViewRelatives.AllowUserToDeleteRows = false;
            this.dataGridViewRelatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataGridViewRelatives.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewRelatives.Name = "dataGridViewRelatives";
            this.dataGridViewRelatives.ReadOnly = true;
            this.dataGridViewRelatives.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewRelatives.TabIndex = 6;
            this.dataGridViewRelatives.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRelatives_CellClick);
            this.dataGridViewRelatives.Leave += new System.EventHandler(this.txtSearchMaNTRelatives_Leave);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaNT";
            this.Column1.HeaderText = "Ma Nguoi Than";
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
            this.Column3.DataPropertyName = "Ten";
            this.Column3.HeaderText = "Ten";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "NgayTham";
            this.Column6.HeaderText = "Ngay Tham";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "So Dien Thoai";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Dia Chi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtSearchMaNTRelatives
            // 
            this.txtSearchMaNTRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaNTRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaNTRelatives.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaNTRelatives.Name = "txtSearchMaNTRelatives";
            this.txtSearchMaNTRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaNTRelatives.TabIndex = 5;
            this.txtSearchMaNTRelatives.TextChanged += new System.EventHandler(this.txtSearchMaNTRelatives_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(295, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(110, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Ma Nguoi Than:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Relatives: ";
            // 
            // tabPageUpDeRelatives
            // 
            this.tabPageUpDeRelatives.Controls.Add(this.dateTimeUpAnDeNgayThamRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.txtUpAndDeTenRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.txtUpAndDeSDTRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.label8);
            this.tabPageUpDeRelatives.Controls.Add(this.label10);
            this.tabPageUpDeRelatives.Controls.Add(this.txtUpAndDeDiaChiRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.label11);
            this.tabPageUpDeRelatives.Controls.Add(this.txtUpAndDeMaSVRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.txtUpAndDeMaNTRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.label12);
            this.tabPageUpDeRelatives.Controls.Add(this.label13);
            this.tabPageUpDeRelatives.Controls.Add(this.label14);
            this.tabPageUpDeRelatives.Controls.Add(this.label5);
            this.tabPageUpDeRelatives.Controls.Add(this.btnDeleteRelatives);
            this.tabPageUpDeRelatives.Controls.Add(this.btnUpdateRelatives);
            this.tabPageUpDeRelatives.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeRelatives.Name = "tabPageUpDeRelatives";
            this.tabPageUpDeRelatives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeRelatives.Size = new System.Drawing.Size(1148, 400);
            this.tabPageUpDeRelatives.TabIndex = 2;
            this.tabPageUpDeRelatives.Text = "Update and Delete ";
            this.tabPageUpDeRelatives.UseVisualStyleBackColor = true;
            // 
            // dateTimeUpAnDeNgayThamRelatives
            // 
            this.dateTimeUpAnDeNgayThamRelatives.Location = new System.Drawing.Point(258, 171);
            this.dateTimeUpAnDeNgayThamRelatives.Name = "dateTimeUpAnDeNgayThamRelatives";
            this.dateTimeUpAnDeNgayThamRelatives.Size = new System.Drawing.Size(263, 23);
            this.dateTimeUpAnDeNgayThamRelatives.TabIndex = 33;
            // 
            // txtUpAndDeTenRelatives
            // 
            this.txtUpAndDeTenRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTenRelatives.Location = new System.Drawing.Point(627, 171);
            this.txtUpAndDeTenRelatives.Name = "txtUpAndDeTenRelatives";
            this.txtUpAndDeTenRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTenRelatives.TabIndex = 32;
            // 
            // txtUpAndDeSDTRelatives
            // 
            this.txtUpAndDeSDTRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeSDTRelatives.Location = new System.Drawing.Point(627, 245);
            this.txtUpAndDeSDTRelatives.Name = "txtUpAndDeSDTRelatives";
            this.txtUpAndDeSDTRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeSDTRelatives.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "So dien thoai:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngay tham:";
            // 
            // txtUpAndDeDiaChiRelatives
            // 
            this.txtUpAndDeDiaChiRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeDiaChiRelatives.Location = new System.Drawing.Point(258, 245);
            this.txtUpAndDeDiaChiRelatives.Name = "txtUpAndDeDiaChiRelatives";
            this.txtUpAndDeDiaChiRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeDiaChiRelatives.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(627, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ten:";
            // 
            // txtUpAndDeMaSVRelatives
            // 
            this.txtUpAndDeMaSVRelatives.BackColor = System.Drawing.Color.White;
            this.txtUpAndDeMaSVRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaSVRelatives.Location = new System.Drawing.Point(627, 87);
            this.txtUpAndDeMaSVRelatives.Name = "txtUpAndDeMaSVRelatives";
            this.txtUpAndDeMaSVRelatives.ReadOnly = true;
            this.txtUpAndDeMaSVRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaSVRelatives.TabIndex = 29;
            // 
            // txtUpAndDeMaNTRelatives
            // 
            this.txtUpAndDeMaNTRelatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaNTRelatives.Location = new System.Drawing.Point(258, 87);
            this.txtUpAndDeMaNTRelatives.Name = "txtUpAndDeMaNTRelatives";
            this.txtUpAndDeMaNTRelatives.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaNTRelatives.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Dia chi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(627, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ma SV:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Ma Nguoi Than:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update and Delete Relatives:";
            // 
            // btnDeleteRelatives
            // 
            this.btnDeleteRelatives.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteRelatives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRelatives.BackgroundImage")));
            this.btnDeleteRelatives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteRelatives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRelatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRelatives.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRelatives.Location = new System.Drawing.Point(399, 307);
            this.btnDeleteRelatives.Name = "btnDeleteRelatives";
            this.btnDeleteRelatives.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteRelatives.TabIndex = 9;
            this.btnDeleteRelatives.Text = "Delete";
            this.btnDeleteRelatives.UseVisualStyleBackColor = false;
            this.btnDeleteRelatives.Click += new System.EventHandler(this.btnDeleteRelatives_Click);
            // 
            // btnUpdateRelatives
            // 
            this.btnUpdateRelatives.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateRelatives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateRelatives.BackgroundImage")));
            this.btnUpdateRelatives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateRelatives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRelatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRelatives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRelatives.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRelatives.Location = new System.Drawing.Point(258, 307);
            this.btnUpdateRelatives.Name = "btnUpdateRelatives";
            this.btnUpdateRelatives.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateRelatives.TabIndex = 9;
            this.btnUpdateRelatives.Text = "Update";
            this.btnUpdateRelatives.UseVisualStyleBackColor = false;
            this.btnUpdateRelatives.Click += new System.EventHandler(this.btnUpdateRelatives_Click);
            // 
            // UserControlRelatives
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRelatives);
            this.Name = "UserControlRelatives";
            this.Size = new System.Drawing.Size(1156, 438);
            this.Load += new System.EventHandler(this.UserControlRelatives_Load);
            this.tabControlRelatives.ResumeLayout(false);
            this.tabPageAddRelatives.ResumeLayout(false);
            this.tabPageAddRelatives.PerformLayout();
            this.tabPageSearchRelatives.ResumeLayout(false);
            this.tabPageSearchRelatives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatives)).EndInit();
            this.tabPageUpDeRelatives.ResumeLayout(false);
            this.tabPageUpDeRelatives.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRelatives;
        private System.Windows.Forms.TabPage tabPageSearchRelatives;
        private System.Windows.Forms.DataGridView dataGridViewRelatives;
        private System.Windows.Forms.TextBox txtSearchMaNTRelatives;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeRelatives;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteRelatives;
        private System.Windows.Forms.Button btnUpdateRelatives;
        private System.Windows.Forms.TextBox txtUpAndDeSDTRelatives;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpAndDeDiaChiRelatives;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpAndDeMaNTRelatives;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPageAddRelatives;
        private System.Windows.Forms.DateTimePicker dateTimeAddNgayThamRelatives;
        private System.Windows.Forms.ComboBox cbBoxAddMaSvRelatives;
        private System.Windows.Forms.Button btnAddRelatives;
        private System.Windows.Forms.TextBox txtAddSoDTRelatives;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddTenRelatives;
        private System.Windows.Forms.TextBox txtAddDiaChiRelatives;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddMaNTRelatives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeUpAnDeNgayThamRelatives;
        private System.Windows.Forms.TextBox txtUpAndDeTenRelatives;
        private System.Windows.Forms.TextBox txtUpAndDeMaSVRelatives;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
