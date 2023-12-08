namespace Dormitory_Winform.UserControls
{
    partial class UserControlStatistical
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
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageStudentStatistics = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStatistics
            // 
            this.tabControlStatistics.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlStatistics.Controls.Add(this.tabPage1);
            this.tabControlStatistics.Controls.Add(this.tabPageStudentStatistics);
            this.tabControlStatistics.Controls.Add(this.tabPage2);
            this.tabControlStatistics.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStatistics.ItemSize = new System.Drawing.Size(48, 22);
            this.tabControlStatistics.Location = new System.Drawing.Point(0, 4);
            this.tabControlStatistics.Name = "tabControlStatistics";
            this.tabControlStatistics.SelectedIndex = 0;
            this.tabControlStatistics.Size = new System.Drawing.Size(1156, 430);
            this.tabControlStatistics.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageStudentStatistics
            // 
            this.tabPageStudentStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageStudentStatistics.Location = new System.Drawing.Point(4, 4);
            this.tabPageStudentStatistics.Name = "tabPageStudentStatistics";
            this.tabPageStudentStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentStatistics.Size = new System.Drawing.Size(1148, 400);
            this.tabPageStudentStatistics.TabIndex = 1;
            this.tabPageStudentStatistics.Text = "Fee";
            this.tabPageStudentStatistics.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 400);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Consume";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserControlStatistical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlStatistics);
            this.Name = "UserControlStatistical";
            this.Size = new System.Drawing.Size(1156, 438);
            this.tabControlStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStudentStatistics;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
