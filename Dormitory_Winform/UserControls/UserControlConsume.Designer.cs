namespace Dormitory_Winform.UserControls
{
    partial class UserControlConsume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlConsume));
            this.tabControlConsume = new System.Windows.Forms.TabControl();
            this.tabPageAddConsume = new System.Windows.Forms.TabPage();
            this.cbBoxAddMaThietBiConsume = new System.Windows.Forms.ComboBox();
            this.cbBoxAddMaPhongConsume = new System.Windows.Forms.ComboBox();
            this.btnAddConsume = new System.Windows.Forms.Button();
            this.txtAddTienBaoTriThietBiConsume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddTienBaoTriPhongConsume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddMaHaoPhiConsume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearchConsume = new System.Windows.Forms.TabPage();
            this.dataGridViewConsume = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMaHaoPhiConsum = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeConsume = new System.Windows.Forms.TabPage();
            this.cbBoxUpAndDeMaThietBiConsume = new System.Windows.Forms.ComboBox();
            this.cbBoxUpAndDeMaPhongConsumee = new System.Windows.Forms.ComboBox();
            this.txtUpAndDeTienBaoTriThietBiConsume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpAndDeTienBaoTriPhongConsume = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaHaoPhiConsume = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteConsume = new System.Windows.Forms.Button();
            this.btnUpdateConsume = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.tabControlConsume.SuspendLayout();
            this.tabPageAddConsume.SuspendLayout();
            this.tabPageSearchConsume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsume)).BeginInit();
            this.tabPageUpDeConsume.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DarkBlue;
            label1.Location = new System.Drawing.Point(4, 3);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(117, 18);
            label1.TabIndex = 0;
            label1.Text = "Add Consume:";
            // 
            // tabControlConsume
            // 
            this.tabControlConsume.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlConsume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlConsume.Controls.Add(this.tabPageAddConsume);
            this.tabControlConsume.Controls.Add(this.tabPageSearchConsume);
            this.tabControlConsume.Controls.Add(this.tabPageUpDeConsume);
            this.tabControlConsume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlConsume.Location = new System.Drawing.Point(0, 4);
            this.tabControlConsume.Name = "tabControlConsume";
            this.tabControlConsume.SelectedIndex = 0;
            this.tabControlConsume.Size = new System.Drawing.Size(1156, 430);
            this.tabControlConsume.TabIndex = 6;
            // 
            // tabPageAddConsume
            // 
            this.tabPageAddConsume.Controls.Add(this.cbBoxAddMaThietBiConsume);
            this.tabPageAddConsume.Controls.Add(this.cbBoxAddMaPhongConsume);
            this.tabPageAddConsume.Controls.Add(this.btnAddConsume);
            this.tabPageAddConsume.Controls.Add(this.txtAddTienBaoTriThietBiConsume);
            this.tabPageAddConsume.Controls.Add(this.label6);
            this.tabPageAddConsume.Controls.Add(this.txtAddTienBaoTriPhongConsume);
            this.tabPageAddConsume.Controls.Add(this.label15);
            this.tabPageAddConsume.Controls.Add(this.label7);
            this.tabPageAddConsume.Controls.Add(this.txtAddMaHaoPhiConsume);
            this.tabPageAddConsume.Controls.Add(this.label3);
            this.tabPageAddConsume.Controls.Add(this.label2);
            this.tabPageAddConsume.Controls.Add(label1);
            this.tabPageAddConsume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddConsume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddConsume.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddConsume.Name = "tabPageAddConsume";
            this.tabPageAddConsume.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddConsume.Size = new System.Drawing.Size(1148, 400);
            this.tabPageAddConsume.TabIndex = 0;
            this.tabPageAddConsume.Text = "Add";
            this.tabPageAddConsume.UseVisualStyleBackColor = true;
            // 
            // cbBoxAddMaThietBiConsume
            // 
            this.cbBoxAddMaThietBiConsume.FormattingEnabled = true;
            this.cbBoxAddMaThietBiConsume.Location = new System.Drawing.Point(255, 195);
            this.cbBoxAddMaThietBiConsume.Name = "cbBoxAddMaThietBiConsume";
            this.cbBoxAddMaThietBiConsume.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaThietBiConsume.TabIndex = 7;
            // 
            // cbBoxAddMaPhongConsume
            // 
            this.cbBoxAddMaPhongConsume.FormattingEnabled = true;
            this.cbBoxAddMaPhongConsume.Location = new System.Drawing.Point(624, 115);
            this.cbBoxAddMaPhongConsume.Name = "cbBoxAddMaPhongConsume";
            this.cbBoxAddMaPhongConsume.Size = new System.Drawing.Size(263, 25);
            this.cbBoxAddMaPhongConsume.TabIndex = 7;
            // 
            // btnAddConsume
            // 
            this.btnAddConsume.BackColor = System.Drawing.Color.Navy;
            this.btnAddConsume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddConsume.BackgroundImage")));
            this.btnAddConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConsume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsume.ForeColor = System.Drawing.Color.White;
            this.btnAddConsume.Location = new System.Drawing.Point(624, 278);
            this.btnAddConsume.Name = "btnAddConsume";
            this.btnAddConsume.Size = new System.Drawing.Size(111, 41);
            this.btnAddConsume.TabIndex = 4;
            this.btnAddConsume.Text = "Add";
            this.btnAddConsume.UseVisualStyleBackColor = false;
            // 
            // txtAddTienBaoTriThietBiConsume
            // 
            this.txtAddTienBaoTriThietBiConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienBaoTriThietBiConsume.Location = new System.Drawing.Point(255, 278);
            this.txtAddTienBaoTriThietBiConsume.Name = "txtAddTienBaoTriThietBiConsume";
            this.txtAddTienBaoTriThietBiConsume.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienBaoTriThietBiConsume.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tien bao tri thiet bi:";
            // 
            // txtAddTienBaoTriPhongConsume
            // 
            this.txtAddTienBaoTriPhongConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTienBaoTriPhongConsume.Location = new System.Drawing.Point(624, 195);
            this.txtAddTienBaoTriPhongConsume.Name = "txtAddTienBaoTriPhongConsume";
            this.txtAddTienBaoTriPhongConsume.Size = new System.Drawing.Size(263, 23);
            this.txtAddTienBaoTriPhongConsume.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(255, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ma thiet bi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(624, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tien bao tri phong:";
            // 
            // txtAddMaHaoPhiConsume
            // 
            this.txtAddMaHaoPhiConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddMaHaoPhiConsume.Location = new System.Drawing.Point(255, 115);
            this.txtAddMaHaoPhiConsume.Name = "txtAddMaHaoPhiConsume";
            this.txtAddMaHaoPhiConsume.Size = new System.Drawing.Size(263, 23);
            this.txtAddMaHaoPhiConsume.TabIndex = 3;
            this.txtAddMaHaoPhiConsume.TextChanged += new System.EventHandler(this.txtAddMaHaoPhiConsume_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma phong:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma hao phi:";
            // 
            // tabPageSearchConsume
            // 
            this.tabPageSearchConsume.Controls.Add(this.dataGridViewConsume);
            this.tabPageSearchConsume.Controls.Add(this.txtSearchMaHaoPhiConsum);
            this.tabPageSearchConsume.Controls.Add(this.lblSearch);
            this.tabPageSearchConsume.Controls.Add(this.label4);
            this.tabPageSearchConsume.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchConsume.Name = "tabPageSearchConsume";
            this.tabPageSearchConsume.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchConsume.Size = new System.Drawing.Size(1148, 400);
            this.tabPageSearchConsume.TabIndex = 1;
            this.tabPageSearchConsume.Text = "Search";
            this.tabPageSearchConsume.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsume
            // 
            this.dataGridViewConsume.AllowUserToAddRows = false;
            this.dataGridViewConsume.AllowUserToDeleteRows = false;
            this.dataGridViewConsume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewConsume.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewConsume.Name = "dataGridViewConsume";
            this.dataGridViewConsume.ReadOnly = true;
            this.dataGridViewConsume.Size = new System.Drawing.Size(1030, 244);
            this.dataGridViewConsume.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Consume_MaHaoPhi";
            this.Column1.HeaderText = "Ma Hao Phi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Consume_MaPhong";
            this.Column2.HeaderText = "Ma Phong";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Devices_TenThietBi";
            this.Column3.HeaderText = "Ma Thiet Bi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Consume_TienBaoTriPhong";
            this.Column4.HeaderText = "Tien Bao Tri Phong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Consume_TienBaoTriThietBi";
            this.Column5.HeaderText = "Tien Bao Tri Thiet Bi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtSearchMaHaoPhiConsum
            // 
            this.txtSearchMaHaoPhiConsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMaHaoPhiConsum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaHaoPhiConsum.Location = new System.Drawing.Point(295, 77);
            this.txtSearchMaHaoPhiConsum.Name = "txtSearchMaHaoPhiConsum";
            this.txtSearchMaHaoPhiConsum.Size = new System.Drawing.Size(263, 23);
            this.txtSearchMaHaoPhiConsum.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(295, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(85, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Ma Hao Phi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Consume: ";
            // 
            // tabPageUpDeConsume
            // 
            this.tabPageUpDeConsume.Controls.Add(this.cbBoxUpAndDeMaThietBiConsume);
            this.tabPageUpDeConsume.Controls.Add(this.cbBoxUpAndDeMaPhongConsumee);
            this.tabPageUpDeConsume.Controls.Add(this.txtUpAndDeTienBaoTriThietBiConsume);
            this.tabPageUpDeConsume.Controls.Add(this.label8);
            this.tabPageUpDeConsume.Controls.Add(this.txtUpAndDeTienBaoTriPhongConsume);
            this.tabPageUpDeConsume.Controls.Add(this.label9);
            this.tabPageUpDeConsume.Controls.Add(this.label10);
            this.tabPageUpDeConsume.Controls.Add(this.txtUpAndDeMaHaoPhiConsume);
            this.tabPageUpDeConsume.Controls.Add(this.label11);
            this.tabPageUpDeConsume.Controls.Add(this.label12);
            this.tabPageUpDeConsume.Controls.Add(this.label5);
            this.tabPageUpDeConsume.Controls.Add(this.btnDeleteConsume);
            this.tabPageUpDeConsume.Controls.Add(this.btnUpdateConsume);
            this.tabPageUpDeConsume.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeConsume.Name = "tabPageUpDeConsume";
            this.tabPageUpDeConsume.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeConsume.Size = new System.Drawing.Size(1148, 400);
            this.tabPageUpDeConsume.TabIndex = 2;
            this.tabPageUpDeConsume.Text = "Update and Delete ";
            this.tabPageUpDeConsume.UseVisualStyleBackColor = true;
            // 
            // cbBoxUpAndDeMaThietBiConsume
            // 
            this.cbBoxUpAndDeMaThietBiConsume.FormattingEnabled = true;
            this.cbBoxUpAndDeMaThietBiConsume.Location = new System.Drawing.Point(255, 195);
            this.cbBoxUpAndDeMaThietBiConsume.Name = "cbBoxUpAndDeMaThietBiConsume";
            this.cbBoxUpAndDeMaThietBiConsume.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeMaThietBiConsume.TabIndex = 20;
            // 
            // cbBoxUpAndDeMaPhongConsumee
            // 
            this.cbBoxUpAndDeMaPhongConsumee.FormattingEnabled = true;
            this.cbBoxUpAndDeMaPhongConsumee.Location = new System.Drawing.Point(624, 115);
            this.cbBoxUpAndDeMaPhongConsumee.Name = "cbBoxUpAndDeMaPhongConsumee";
            this.cbBoxUpAndDeMaPhongConsumee.Size = new System.Drawing.Size(263, 25);
            this.cbBoxUpAndDeMaPhongConsumee.TabIndex = 21;
            // 
            // txtUpAndDeTienBaoTriThietBiConsume
            // 
            this.txtUpAndDeTienBaoTriThietBiConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienBaoTriThietBiConsume.Location = new System.Drawing.Point(255, 278);
            this.txtUpAndDeTienBaoTriThietBiConsume.Name = "txtUpAndDeTienBaoTriThietBiConsume";
            this.txtUpAndDeTienBaoTriThietBiConsume.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienBaoTriThietBiConsume.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tien bao tri thiet bi:";
            // 
            // txtUpAndDeTienBaoTriPhongConsume
            // 
            this.txtUpAndDeTienBaoTriPhongConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTienBaoTriPhongConsume.Location = new System.Drawing.Point(624, 195);
            this.txtUpAndDeTienBaoTriPhongConsume.Name = "txtUpAndDeTienBaoTriPhongConsume";
            this.txtUpAndDeTienBaoTriPhongConsume.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeTienBaoTriPhongConsume.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ma thiet bi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(624, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tien bao tri phong:";
            // 
            // txtUpAndDeMaHaoPhiConsume
            // 
            this.txtUpAndDeMaHaoPhiConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaHaoPhiConsume.Location = new System.Drawing.Point(255, 115);
            this.txtUpAndDeMaHaoPhiConsume.Name = "txtUpAndDeMaHaoPhiConsume";
            this.txtUpAndDeMaHaoPhiConsume.Size = new System.Drawing.Size(263, 23);
            this.txtUpAndDeMaHaoPhiConsume.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(624, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ma phong:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ma hao phi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update and Delete Consume:";
            // 
            // btnDeleteConsume
            // 
            this.btnDeleteConsume.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteConsume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteConsume.BackgroundImage")));
            this.btnDeleteConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteConsume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteConsume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConsume.ForeColor = System.Drawing.Color.White;
            this.btnDeleteConsume.Location = new System.Drawing.Point(768, 278);
            this.btnDeleteConsume.Name = "btnDeleteConsume";
            this.btnDeleteConsume.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteConsume.TabIndex = 9;
            this.btnDeleteConsume.Text = "Delete";
            this.btnDeleteConsume.UseVisualStyleBackColor = false;
            // 
            // btnUpdateConsume
            // 
            this.btnUpdateConsume.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateConsume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateConsume.BackgroundImage")));
            this.btnUpdateConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateConsume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateConsume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateConsume.ForeColor = System.Drawing.Color.White;
            this.btnUpdateConsume.Location = new System.Drawing.Point(624, 278);
            this.btnUpdateConsume.Name = "btnUpdateConsume";
            this.btnUpdateConsume.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateConsume.TabIndex = 9;
            this.btnUpdateConsume.Text = "Update";
            this.btnUpdateConsume.UseVisualStyleBackColor = false;
            // 
            // UserControlConsume
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlConsume);
            this.Name = "UserControlConsume";
            this.Size = new System.Drawing.Size(1156, 438);
            this.tabControlConsume.ResumeLayout(false);
            this.tabPageAddConsume.ResumeLayout(false);
            this.tabPageAddConsume.PerformLayout();
            this.tabPageSearchConsume.ResumeLayout(false);
            this.tabPageSearchConsume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsume)).EndInit();
            this.tabPageUpDeConsume.ResumeLayout(false);
            this.tabPageUpDeConsume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConsume;
        private System.Windows.Forms.TabPage tabPageAddConsume;
        private System.Windows.Forms.ComboBox cbBoxAddMaPhongConsume;
        private System.Windows.Forms.Button btnAddConsume;
        private System.Windows.Forms.TextBox txtAddTienBaoTriPhongConsume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddMaHaoPhiConsume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageSearchConsume;
        private System.Windows.Forms.DataGridView dataGridViewConsume;
        private System.Windows.Forms.TextBox txtSearchMaHaoPhiConsum;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeConsume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteConsume;
        private System.Windows.Forms.Button btnUpdateConsume;
        private System.Windows.Forms.ComboBox cbBoxAddMaThietBiConsume;
        private System.Windows.Forms.TextBox txtAddTienBaoTriThietBiConsume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeMaThietBiConsume;
        private System.Windows.Forms.ComboBox cbBoxUpAndDeMaPhongConsumee;
        private System.Windows.Forms.TextBox txtUpAndDeTienBaoTriThietBiConsume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpAndDeTienBaoTriPhongConsume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpAndDeMaHaoPhiConsume;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
