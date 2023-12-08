namespace Dormitory_Winform.UserControls
{
    partial class UserControlStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudents));
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.dateTimeAddNgaySinhStudent = new System.Windows.Forms.DateTimePicker();
            this.rdbAddChuaDuyetStudent = new System.Windows.Forms.RadioButton();
            this.rdbAddDuyetStudent = new System.Windows.Forms.RadioButton();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddDiaChiStudent = new System.Windows.Forms.TextBox();
            this.txtAddTenStudent = new System.Windows.Forms.TextBox();
            this.txtAddDTStudent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddMaSVStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchStudent = new System.Windows.Forms.TabPage();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpDeStudent = new System.Windows.Forms.TabPage();
            this.dateTimeUpAndDeNgaySinhStudent = new System.Windows.Forms.DateTimePicker();
            this.rdbUpAndDeChuaDuyetStudent = new System.Windows.Forms.RadioButton();
            this.rdbUpAndDeDuyetStudent = new System.Windows.Forms.RadioButton();
            this.txtUpAndDeDiaChiStudent = new System.Windows.Forms.TextBox();
            this.txtUpAndDeTenStudent = new System.Windows.Forms.TextBox();
            this.txtUpAndDeDTStudent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpAndDeMaSVStudent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlStudent.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.tabPageSearchStudent.SuspendLayout();
            this.tabPageUpDeStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlStudent.Controls.Add(this.tabPageSearchStudent);
            this.tabControlStudent.Controls.Add(this.tabPageUpDeStudent);
            this.tabControlStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStudent.Location = new System.Drawing.Point(-1, 3);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(1156, 438);
            this.tabControlStudent.TabIndex = 1;
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.Controls.Add(this.dateTimeAddNgaySinhStudent);
            this.tabPageAddStudent.Controls.Add(this.rdbAddChuaDuyetStudent);
            this.tabPageAddStudent.Controls.Add(this.rdbAddDuyetStudent);
            this.tabPageAddStudent.Controls.Add(this.btnAddStudent);
            this.tabPageAddStudent.Controls.Add(this.txtAddDiaChiStudent);
            this.tabPageAddStudent.Controls.Add(this.txtAddTenStudent);
            this.tabPageAddStudent.Controls.Add(this.txtAddDTStudent);
            this.tabPageAddStudent.Controls.Add(this.label9);
            this.tabPageAddStudent.Controls.Add(this.label7);
            this.tabPageAddStudent.Controls.Add(this.label8);
            this.tabPageAddStudent.Controls.Add(this.txtAddMaSVStudent);
            this.tabPageAddStudent.Controls.Add(this.label6);
            this.tabPageAddStudent.Controls.Add(this.label3);
            this.tabPageAddStudent.Controls.Add(this.label2);
            this.tabPageAddStudent.Controls.Add(this.label1);
            this.tabPageAddStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(1148, 408);
            this.tabPageAddStudent.TabIndex = 0;
            this.tabPageAddStudent.Text = "Add";
            this.tabPageAddStudent.UseVisualStyleBackColor = true;
            this.tabPageAddStudent.Leave += new System.EventHandler(this.tabPageAddStudent_Leave);
            // 
            // dateTimeAddNgaySinhStudent
            // 
            this.dateTimeAddNgaySinhStudent.Location = new System.Drawing.Point(626, 150);
            this.dateTimeAddNgaySinhStudent.Name = "dateTimeAddNgaySinhStudent";
            this.dateTimeAddNgaySinhStudent.Size = new System.Drawing.Size(286, 22);
            this.dateTimeAddNgaySinhStudent.TabIndex = 7;
            // 
            // rdbAddChuaDuyetStudent
            // 
            this.rdbAddChuaDuyetStudent.AutoSize = true;
            this.rdbAddChuaDuyetStudent.Location = new System.Drawing.Point(629, 282);
            this.rdbAddChuaDuyetStudent.Name = "rdbAddChuaDuyetStudent";
            this.rdbAddChuaDuyetStudent.Size = new System.Drawing.Size(94, 21);
            this.rdbAddChuaDuyetStudent.TabIndex = 6;
            this.rdbAddChuaDuyetStudent.TabStop = true;
            this.rdbAddChuaDuyetStudent.Text = "Chua duyet";
            this.rdbAddChuaDuyetStudent.UseVisualStyleBackColor = true;
            // 
            // rdbAddDuyetStudent
            // 
            this.rdbAddDuyetStudent.AutoSize = true;
            this.rdbAddDuyetStudent.Location = new System.Drawing.Point(629, 243);
            this.rdbAddDuyetStudent.Name = "rdbAddDuyetStudent";
            this.rdbAddDuyetStudent.Size = new System.Drawing.Size(61, 21);
            this.rdbAddDuyetStudent.TabIndex = 5;
            this.rdbAddDuyetStudent.TabStop = true;
            this.rdbAddDuyetStudent.Text = "Duyet";
            this.rdbAddDuyetStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Navy;
            this.btnAddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.BackgroundImage")));
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(626, 352);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(111, 41);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddDiaChiStudent
            // 
            this.txtAddDiaChiStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddDiaChiStudent.Location = new System.Drawing.Point(264, 243);
            this.txtAddDiaChiStudent.Multiline = true;
            this.txtAddDiaChiStudent.Name = "txtAddDiaChiStudent";
            this.txtAddDiaChiStudent.Size = new System.Drawing.Size(263, 150);
            this.txtAddDiaChiStudent.TabIndex = 3;
            // 
            // txtAddTenStudent
            // 
            this.txtAddTenStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddTenStudent.Location = new System.Drawing.Point(626, 68);
            this.txtAddTenStudent.Name = "txtAddTenStudent";
            this.txtAddTenStudent.Size = new System.Drawing.Size(286, 22);
            this.txtAddTenStudent.TabIndex = 3;
            // 
            // txtAddDTStudent
            // 
            this.txtAddDTStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddDTStudent.Location = new System.Drawing.Point(264, 150);
            this.txtAddDTStudent.Name = "txtAddDTStudent";
            this.txtAddDTStudent.Size = new System.Drawing.Size(263, 22);
            this.txtAddDTStudent.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(626, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Trang thai dang ki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngay sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dia chi: ";
            // 
            // txtAddMaSVStudent
            // 
            this.txtAddMaSVStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddMaSVStudent.Location = new System.Drawing.Point(264, 68);
            this.txtAddMaSVStudent.Name = "txtAddMaSVStudent";
            this.txtAddMaSVStudent.Size = new System.Drawing.Size(263, 22);
            this.txtAddMaSVStudent.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dien thoai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MaSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student:";
            // 
            // tabPageSearchStudent
            // 
            this.tabPageSearchStudent.Controls.Add(this.dataGridViewStudent);
            this.tabPageSearchStudent.Controls.Add(this.txtSearchStudent);
            this.tabPageSearchStudent.Controls.Add(this.lblSearchStudent);
            this.tabPageSearchStudent.Controls.Add(this.label4);
            this.tabPageSearchStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSearchStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchStudent.Name = "tabPageSearchStudent";
            this.tabPageSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchStudent.Size = new System.Drawing.Size(1148, 408);
            this.tabPageSearchStudent.TabIndex = 1;
            this.tabPageSearchStudent.Text = "Search";
            this.tabPageSearchStudent.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudent.Location = new System.Drawing.Point(295, 77);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(263, 23);
            this.txtSearchStudent.TabIndex = 5;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            this.txtSearchStudent.Leave += new System.EventHandler(this.txtSearchStudent_Leave);
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(295, 43);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(96, 16);
            this.lblSearchStudent.TabIndex = 4;
            this.lblSearchStudent.Text = "Ma Sinh Vien:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Student: ";
            // 
            // tabPageUpDeStudent
            // 
            this.tabPageUpDeStudent.Controls.Add(this.dateTimeUpAndDeNgaySinhStudent);
            this.tabPageUpDeStudent.Controls.Add(this.rdbUpAndDeChuaDuyetStudent);
            this.tabPageUpDeStudent.Controls.Add(this.rdbUpAndDeDuyetStudent);
            this.tabPageUpDeStudent.Controls.Add(this.txtUpAndDeDiaChiStudent);
            this.tabPageUpDeStudent.Controls.Add(this.txtUpAndDeTenStudent);
            this.tabPageUpDeStudent.Controls.Add(this.txtUpAndDeDTStudent);
            this.tabPageUpDeStudent.Controls.Add(this.label10);
            this.tabPageUpDeStudent.Controls.Add(this.label11);
            this.tabPageUpDeStudent.Controls.Add(this.label12);
            this.tabPageUpDeStudent.Controls.Add(this.txtUpAndDeMaSVStudent);
            this.tabPageUpDeStudent.Controls.Add(this.label13);
            this.tabPageUpDeStudent.Controls.Add(this.label14);
            this.tabPageUpDeStudent.Controls.Add(this.label15);
            this.tabPageUpDeStudent.Controls.Add(this.label5);
            this.tabPageUpDeStudent.Controls.Add(this.btnDeleteStudent);
            this.tabPageUpDeStudent.Controls.Add(this.btnUpdateStudent);
            this.tabPageUpDeStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUpDeStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDeStudent.Name = "tabPageUpDeStudent";
            this.tabPageUpDeStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDeStudent.Size = new System.Drawing.Size(1148, 408);
            this.tabPageUpDeStudent.TabIndex = 2;
            this.tabPageUpDeStudent.Text = "Update and Delete ";
            this.tabPageUpDeStudent.UseVisualStyleBackColor = true;
            this.tabPageUpDeStudent.Leave += new System.EventHandler(this.tabPageUpDeStudent_Leave);
            // 
            // dateTimeUpAndDeNgaySinhStudent
            // 
            this.dateTimeUpAndDeNgaySinhStudent.Location = new System.Drawing.Point(626, 150);
            this.dateTimeUpAndDeNgaySinhStudent.Name = "dateTimeUpAndDeNgaySinhStudent";
            this.dateTimeUpAndDeNgaySinhStudent.Size = new System.Drawing.Size(286, 22);
            this.dateTimeUpAndDeNgaySinhStudent.TabIndex = 25;
            // 
            // rdbUpAndDeChuaDuyetStudent
            // 
            this.rdbUpAndDeChuaDuyetStudent.AutoSize = true;
            this.rdbUpAndDeChuaDuyetStudent.Location = new System.Drawing.Point(629, 282);
            this.rdbUpAndDeChuaDuyetStudent.Name = "rdbUpAndDeChuaDuyetStudent";
            this.rdbUpAndDeChuaDuyetStudent.Size = new System.Drawing.Size(94, 21);
            this.rdbUpAndDeChuaDuyetStudent.TabIndex = 24;
            this.rdbUpAndDeChuaDuyetStudent.TabStop = true;
            this.rdbUpAndDeChuaDuyetStudent.Text = "Chua duyet";
            this.rdbUpAndDeChuaDuyetStudent.UseVisualStyleBackColor = true;
            // 
            // rdbUpAndDeDuyetStudent
            // 
            this.rdbUpAndDeDuyetStudent.AutoSize = true;
            this.rdbUpAndDeDuyetStudent.Location = new System.Drawing.Point(629, 243);
            this.rdbUpAndDeDuyetStudent.Name = "rdbUpAndDeDuyetStudent";
            this.rdbUpAndDeDuyetStudent.Size = new System.Drawing.Size(61, 21);
            this.rdbUpAndDeDuyetStudent.TabIndex = 23;
            this.rdbUpAndDeDuyetStudent.TabStop = true;
            this.rdbUpAndDeDuyetStudent.Text = "Duyet";
            this.rdbUpAndDeDuyetStudent.UseVisualStyleBackColor = true;
            // 
            // txtUpAndDeDiaChiStudent
            // 
            this.txtUpAndDeDiaChiStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeDiaChiStudent.Location = new System.Drawing.Point(264, 243);
            this.txtUpAndDeDiaChiStudent.Multiline = true;
            this.txtUpAndDeDiaChiStudent.Name = "txtUpAndDeDiaChiStudent";
            this.txtUpAndDeDiaChiStudent.Size = new System.Drawing.Size(263, 150);
            this.txtUpAndDeDiaChiStudent.TabIndex = 18;
            // 
            // txtUpAndDeTenStudent
            // 
            this.txtUpAndDeTenStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeTenStudent.Location = new System.Drawing.Point(626, 68);
            this.txtUpAndDeTenStudent.Name = "txtUpAndDeTenStudent";
            this.txtUpAndDeTenStudent.Size = new System.Drawing.Size(286, 22);
            this.txtUpAndDeTenStudent.TabIndex = 19;
            // 
            // txtUpAndDeDTStudent
            // 
            this.txtUpAndDeDTStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeDTStudent.Location = new System.Drawing.Point(264, 150);
            this.txtUpAndDeDTStudent.Name = "txtUpAndDeDTStudent";
            this.txtUpAndDeDTStudent.Size = new System.Drawing.Size(263, 22);
            this.txtUpAndDeDTStudent.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(626, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Trang thai dang ki:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(626, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ngay sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Dia chi: ";
            // 
            // txtUpAndDeMaSVStudent
            // 
            this.txtUpAndDeMaSVStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpAndDeMaSVStudent.Location = new System.Drawing.Point(264, 68);
            this.txtUpAndDeMaSVStudent.Name = "txtUpAndDeMaSVStudent";
            this.txtUpAndDeMaSVStudent.Size = new System.Drawing.Size(263, 22);
            this.txtUpAndDeMaSVStudent.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(264, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Dien thoai";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(626, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ten:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(264, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "MaSV:";
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
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.BackgroundImage")));
            this.btnDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(767, 352);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteStudent.TabIndex = 9;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudent.BackgroundImage")));
            this.btnUpdateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(626, 352);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(111, 41);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AutoGenerateColumns = global::Dormitory_Winform.Properties.Settings.Default.False;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewStudent.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::Dormitory_Winform.Properties.Settings.Default, "False", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridViewStudent.Location = new System.Drawing.Point(63, 135);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1030, 265);
            this.dataGridViewStudent.TabIndex = 6;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "MaSV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 165;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Ten";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 164;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "DienThoai";
            this.Column3.HeaderText = "SDT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngay Sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 164;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Dia Chi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 165;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "TrangThaiDki";
            this.Column6.HeaderText = "Trang thai dang ki";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 164;
            // 
            // UserControlStudents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlStudent);
            this.Name = "UserControlStudents";
            this.Size = new System.Drawing.Size(1156, 445);
            this.Load += new System.EventHandler(this.UserControlStudents_Load);
            this.tabControlStudent.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.PerformLayout();
            this.tabPageSearchStudent.ResumeLayout(false);
            this.tabPageSearchStudent.PerformLayout();
            this.tabPageUpDeStudent.ResumeLayout(false);
            this.tabPageUpDeStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtAddTenStudent;
        private System.Windows.Forms.TextBox txtAddMaSVStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpDeStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txtAddDiaChiStudent;
        private System.Windows.Forms.TextBox txtAddDTStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbAddDuyetStudent;
        private System.Windows.Forms.RadioButton rdbAddChuaDuyetStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbUpAndDeChuaDuyetStudent;
        private System.Windows.Forms.RadioButton rdbUpAndDeDuyetStudent;
        private System.Windows.Forms.TextBox txtUpAndDeDiaChiStudent;
        private System.Windows.Forms.TextBox txtUpAndDeTenStudent;
        private System.Windows.Forms.TextBox txtUpAndDeDTStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpAndDeMaSVStudent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimeAddNgaySinhStudent;
        private System.Windows.Forms.DateTimePicker dateTimeUpAndDeNgaySinhStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
