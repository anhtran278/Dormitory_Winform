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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadStudentChart = new System.Windows.Forms.Button();
            this.StudentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageStudentStatistics = new System.Windows.Forms.TabPage();
            this.btnLoadFeeChart = new System.Windows.Forms.Button();
            this.FeeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadConsumeChart = new System.Windows.Forms.Button();
            this.ConsumeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlStatistics.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentChart)).BeginInit();
            this.tabPageStudentStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumeChart)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btnLoadStudentChart);
            this.tabPage1.Controls.Add(this.StudentChart);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoadStudentChart
            // 
            this.btnLoadStudentChart.Location = new System.Drawing.Point(1017, 318);
            this.btnLoadStudentChart.Name = "btnLoadStudentChart";
            this.btnLoadStudentChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoadStudentChart.Size = new System.Drawing.Size(106, 38);
            this.btnLoadStudentChart.TabIndex = 1;
            this.btnLoadStudentChart.Text = "Load";
            this.btnLoadStudentChart.UseVisualStyleBackColor = true;
            this.btnLoadStudentChart.Click += new System.EventHandler(this.btnLoadStudentChart_Click);
            // 
            // StudentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.StudentChart.ChartAreas.Add(chartArea1);
            this.StudentChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.StudentChart.Legends.Add(legend1);
            this.StudentChart.Location = new System.Drawing.Point(3, 3);
            this.StudentChart.Name = "StudentChart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Tổng số sinh viên";
            series1.Name = "Series3";
            this.StudentChart.Series.Add(series1);
            this.StudentChart.Size = new System.Drawing.Size(1142, 394);
            this.StudentChart.TabIndex = 0;
            this.StudentChart.Text = "chart1";
            // 
            // tabPageStudentStatistics
            // 
            this.tabPageStudentStatistics.Controls.Add(this.btnLoadFeeChart);
            this.tabPageStudentStatistics.Controls.Add(this.FeeChart);
            this.tabPageStudentStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageStudentStatistics.Location = new System.Drawing.Point(4, 4);
            this.tabPageStudentStatistics.Name = "tabPageStudentStatistics";
            this.tabPageStudentStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentStatistics.Size = new System.Drawing.Size(1148, 400);
            this.tabPageStudentStatistics.TabIndex = 1;
            this.tabPageStudentStatistics.Text = "Fee";
            this.tabPageStudentStatistics.UseVisualStyleBackColor = true;
            // 
            // btnLoadFeeChart
            // 
            this.btnLoadFeeChart.Location = new System.Drawing.Point(1017, 318);
            this.btnLoadFeeChart.Name = "btnLoadFeeChart";
            this.btnLoadFeeChart.Size = new System.Drawing.Size(106, 38);
            this.btnLoadFeeChart.TabIndex = 3;
            this.btnLoadFeeChart.Text = "Load";
            this.btnLoadFeeChart.UseVisualStyleBackColor = true;
            this.btnLoadFeeChart.Click += new System.EventHandler(this.btnLoadFeeChart_Click);
            // 
            // FeeChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FeeChart.ChartAreas.Add(chartArea2);
            this.FeeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.FeeChart.Legends.Add(legend2);
            this.FeeChart.Location = new System.Drawing.Point(3, 3);
            this.FeeChart.Name = "FeeChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.FeeChart.Series.Add(series2);
            this.FeeChart.Size = new System.Drawing.Size(1142, 394);
            this.FeeChart.TabIndex = 2;
            this.FeeChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadConsumeChart);
            this.tabPage2.Controls.Add(this.ConsumeChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 400);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Consume";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadConsumeChart
            // 
            this.btnLoadConsumeChart.Location = new System.Drawing.Point(1017, 318);
            this.btnLoadConsumeChart.Name = "btnLoadConsumeChart";
            this.btnLoadConsumeChart.Size = new System.Drawing.Size(106, 38);
            this.btnLoadConsumeChart.TabIndex = 5;
            this.btnLoadConsumeChart.Text = "Load";
            this.btnLoadConsumeChart.UseVisualStyleBackColor = true;
            this.btnLoadConsumeChart.Click += new System.EventHandler(this.btnLoadConsumeChart_Click);
            // 
            // ConsumeChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ConsumeChart.ChartAreas.Add(chartArea3);
            this.ConsumeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.ConsumeChart.Legends.Add(legend3);
            this.ConsumeChart.Location = new System.Drawing.Point(3, 3);
            this.ConsumeChart.Name = "ConsumeChart";
            this.ConsumeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.ConsumeChart.Series.Add(series3);
            this.ConsumeChart.Size = new System.Drawing.Size(1142, 394);
            this.ConsumeChart.TabIndex = 4;
            this.ConsumeChart.Text = "chart2";
            // 
            // UserControlStatistical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlStatistics);
            this.Name = "UserControlStatistical";
            this.Size = new System.Drawing.Size(1156, 438);
            this.tabControlStatistics.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentChart)).EndInit();
            this.tabPageStudentStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeeChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStudentStatistics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadStudentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentChart;
        private System.Windows.Forms.Button btnLoadFeeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FeeChart;
        private System.Windows.Forms.Button btnLoadConsumeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ConsumeChart;
    }
}
