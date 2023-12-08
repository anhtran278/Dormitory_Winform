namespace Dormitory_Winform
{
    partial class FormDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnRelatives = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsume = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.userControlStudents1 = new Dormitory_Winform.UserControls.UserControlStudent();
            this.userControlAdmins1 = new Dormitory_Winform.UserControlAdmin();
            this.userControlStatistical1 = new Dormitory_Winform.UserControls.UserControlStatistical();
            this.userControlConsume1 = new Dormitory_Winform.UserControls.UserControlConsume();
            this.userControlDevices1 = new Dormitory_Winform.UserControls.UserControlDevice();
            this.userControlFee1 = new Dormitory_Winform.UserControls.UserControlFee();
            this.userControlRooms1 = new Dormitory_Winform.UserControls.UserControlRooms();
            this.userControlRelatives1 = new Dormitory_Winform.UserControls.UserControlRelative();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnDevice);
            this.panel1.Controls.Add(this.btnStatistical);
            this.panel1.Controls.Add(this.btnRelatives);
            this.panel1.Controls.Add(this.btnFee);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnConsume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 785);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(39, 227);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 41);
            this.panelSlide.TabIndex = 2;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Navy;
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(40, 589);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(229, 49);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "           Admins";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.Color.Navy;
            this.btnDevice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevice.BackgroundImage")));
            this.btnDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevice.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDevice.FlatAppearance.BorderSize = 0;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.Image")));
            this.btnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.Location = new System.Drawing.Point(40, 465);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDevice.Size = new System.Drawing.Size(229, 49);
            this.btnDevice.TabIndex = 1;
            this.btnDevice.Text = "           Devices";
            this.btnDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.UseVisualStyleBackColor = false;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.BackColor = System.Drawing.Color.Navy;
            this.btnStatistical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistical.BackgroundImage")));
            this.btnStatistical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistical.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.Image")));
            this.btnStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.Location = new System.Drawing.Point(40, 650);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStatistical.Size = new System.Drawing.Size(229, 49);
            this.btnStatistical.TabIndex = 1;
            this.btnStatistical.Text = "           Statistical";
            this.btnStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.UseVisualStyleBackColor = false;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnRelatives
            // 
            this.btnRelatives.BackColor = System.Drawing.Color.Navy;
            this.btnRelatives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatives.BackgroundImage")));
            this.btnRelatives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatives.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnRelatives.FlatAppearance.BorderSize = 0;
            this.btnRelatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatives.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatives.ForeColor = System.Drawing.Color.White;
            this.btnRelatives.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatives.Image")));
            this.btnRelatives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatives.Location = new System.Drawing.Point(40, 401);
            this.btnRelatives.Name = "btnRelatives";
            this.btnRelatives.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRelatives.Size = new System.Drawing.Size(229, 49);
            this.btnRelatives.TabIndex = 1;
            this.btnRelatives.Text = "           Relatives";
            this.btnRelatives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatives.UseVisualStyleBackColor = false;
            this.btnRelatives.Click += new System.EventHandler(this.btnRelatives_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.Navy;
            this.btnFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFee.BackgroundImage")));
            this.btnFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFee.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnFee.FlatAppearance.BorderSize = 0;
            this.btnFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.Color.White;
            this.btnFee.Image = ((System.Drawing.Image)(resources.GetObject("btnFee.Image")));
            this.btnFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFee.Location = new System.Drawing.Point(40, 340);
            this.btnFee.Name = "btnFee";
            this.btnFee.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFee.Size = new System.Drawing.Size(229, 49);
            this.btnFee.TabIndex = 1;
            this.btnFee.Text = "           Fees";
            this.btnFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.Navy;
            this.btnRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoom.BackgroundImage")));
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(40, 279);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(229, 49);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "           Rooms";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Navy;
            this.btnStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudent.BackgroundImage")));
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(40, 221);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(10);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(229, 49);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "           Students";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 207);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dormitory Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsume
            // 
            this.btnConsume.BackColor = System.Drawing.Color.Navy;
            this.btnConsume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsume.BackgroundImage")));
            this.btnConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsume.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnConsume.FlatAppearance.BorderSize = 0;
            this.btnConsume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsume.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsume.ForeColor = System.Drawing.Color.White;
            this.btnConsume.Image = ((System.Drawing.Image)(resources.GetObject("btnConsume.Image")));
            this.btnConsume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsume.Location = new System.Drawing.Point(40, 527);
            this.btnConsume.Name = "btnConsume";
            this.btnConsume.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConsume.Size = new System.Drawing.Size(229, 49);
            this.btnConsume.TabIndex = 1;
            this.btnConsume.Text = "           Consume";
            this.btnConsume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsume.UseVisualStyleBackColor = false;
            this.btnConsume.Click += new System.EventHandler(this.btnConsume_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureMinimize);
            this.panel3.Controls.Add(this.pictureClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(268, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1332, 31);
            this.panel3.TabIndex = 1;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(1255, 2);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(23, 29);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 17;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(1293, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(27, 31);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 18;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblLogOut);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(268, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1332, 69);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1127, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(64, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time: ";
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(1187, 31);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(57, 16);
            this.lblLogOut.TabIndex = 1;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.lblUserName);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(268, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1332, 92);
            this.panel6.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(100, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(16, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Welcome, ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(268, 723);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1332, 62);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Copyright © 2023, All Right Reserved. C# OOP GROUP NTP  ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.userControlStudents1);
            this.panel7.Controls.Add(this.userControlAdmins1);
            this.panel7.Controls.Add(this.userControlStatistical1);
            this.panel7.Controls.Add(this.userControlConsume1);
            this.panel7.Controls.Add(this.userControlDevices1);
            this.panel7.Controls.Add(this.userControlFee1);
            this.panel7.Controls.Add(this.userControlRooms1);
            this.panel7.Controls.Add(this.userControlRelatives1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(268, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1332, 531);
            this.panel7.TabIndex = 5;
            // 
            // userControlStudents1
            // 
            this.userControlStudents1.AutoSize = true;
            this.userControlStudents1.BackColor = System.Drawing.Color.White;
            this.userControlStudents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudents1.Location = new System.Drawing.Point(0, 0);
            this.userControlStudents1.Name = "userControlStudents1";
            this.userControlStudents1.Size = new System.Drawing.Size(1332, 531);
            this.userControlStudents1.TabIndex = 1;
            this.userControlStudents1.Load += new System.EventHandler(this.userControlStudents1_Load);
            // 
            // userControlAdmins1
            // 
            this.userControlAdmins1.BackColor = System.Drawing.Color.White;
            this.userControlAdmins1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdmins1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAdmins1.Location = new System.Drawing.Point(0, 0);
            this.userControlAdmins1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAdmins1.Name = "userControlAdmins1";
            this.userControlAdmins1.Size = new System.Drawing.Size(1332, 531);
            this.userControlAdmins1.TabIndex = 0;
            // 
            // userControlStatistical1
            // 
            this.userControlStatistical1.BackColor = System.Drawing.Color.White;
            this.userControlStatistical1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStatistical1.Location = new System.Drawing.Point(0, 0);
            this.userControlStatistical1.Name = "userControlStatistical1";
            this.userControlStatistical1.Size = new System.Drawing.Size(1332, 531);
            this.userControlStatistical1.TabIndex = 7;
            // 
            // userControlConsume1
            // 
            this.userControlConsume1.BackColor = System.Drawing.Color.White;
            this.userControlConsume1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlConsume1.Location = new System.Drawing.Point(0, 0);
            this.userControlConsume1.Name = "userControlConsume1";
            this.userControlConsume1.Size = new System.Drawing.Size(1332, 531);
            this.userControlConsume1.TabIndex = 6;
            // 
            // userControlDevices1
            // 
            this.userControlDevices1.BackColor = System.Drawing.Color.White;
            this.userControlDevices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDevices1.Location = new System.Drawing.Point(0, 0);
            this.userControlDevices1.Name = "userControlDevices1";
            this.userControlDevices1.Size = new System.Drawing.Size(1332, 531);
            this.userControlDevices1.TabIndex = 5;
            // 
            // userControlFee1
            // 
            this.userControlFee1.BackColor = System.Drawing.Color.White;
            this.userControlFee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFee1.Location = new System.Drawing.Point(0, 0);
            this.userControlFee1.Name = "userControlFee1";
            this.userControlFee1.Size = new System.Drawing.Size(1332, 531);
            this.userControlFee1.TabIndex = 4;
            // 
            // userControlRooms1
            // 
            this.userControlRooms1.BackColor = System.Drawing.Color.White;
            this.userControlRooms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRooms1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRooms1.Location = new System.Drawing.Point(0, 0);
            this.userControlRooms1.Name = "userControlRooms1";
            this.userControlRooms1.Size = new System.Drawing.Size(1332, 531);
            this.userControlRooms1.TabIndex = 3;
            // 
            // userControlRelatives1
            // 
            this.userControlRelatives1.BackColor = System.Drawing.Color.White;
            this.userControlRelatives1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRelatives1.Location = new System.Drawing.Point(0, 0);
            this.userControlRelatives1.Name = "userControlRelatives1";
            this.userControlRelatives1.Size = new System.Drawing.Size(1332, 531);
            this.userControlRelatives1.TabIndex = 2;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 785);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnRelatives;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnConsume;
        private System.Windows.Forms.Label label5;
        private UserControlAdmin userControlAdmins1;
        private UserControls.UserControlStudent userControlStudents1;
        private UserControls.UserControlRelative userControlRelatives1;
        private UserControls.UserControlFee userControlFee1;
        private UserControls.UserControlRooms userControlRooms1;
        private UserControls.UserControlDevice userControlDevices1;
        private UserControls.UserControlConsume userControlConsume1;
        private UserControls.UserControlStatistical userControlStatistical1;
    }
}