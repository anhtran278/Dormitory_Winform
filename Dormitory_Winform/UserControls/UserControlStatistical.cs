using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Winform.UserControls
{
    public partial class UserControlStatistical : UserControl
    {
        public UserControlStatistical()
        {
            InitializeComponent();
        }
        private void btnLoadFeeChart_Click(object sender, EventArgs e)
        {
            DbFeeChartDataContext db = new DbFeeChartDataContext();
            List<vwFee> fees = db.vwFees.ToList();

            FeeChart.DataSource = fees.Select(fee => new
            {
                Ngay = fee.Ngay?.ToString("yyyy-MM-dd"),
                fee.TongPhi
            }).ToList();

            FeeChart.Series["Series1"].XValueMember = "Ngay";
            FeeChart.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            FeeChart.Series["Series1"].YValueMembers = "TongPhi";
            FeeChart.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void btnLoadConsumeChart_Click(object sender, EventArgs e)
        {
            DbFeeConsumeDataContext db = new DbFeeConsumeDataContext();

            var consumeFees = db.vwFeeConsumes.ToList();

            ConsumeChart.DataSource = consumeFees;
            ConsumeChart.Series["Series2"].XValueMember = "MaPhong";
            ConsumeChart.Series["Series2"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String; 
            ConsumeChart.Series["Series2"].YValueMembers = "TongPhiPhong";
            ConsumeChart.Series["Series2"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double; 

            ConsumeChart.Refresh();
        }

        private void btnLoadStudentChart_Click(object sender, EventArgs e)
        {
            DbStudentPerYearDataContext db = new DbStudentPerYearDataContext();
            var students = db.vwStudentPerYears.ToList();

            StudentChart.DataSource = students;
            StudentChart.Series["Series3"].XValueMember = "NamVao";
            StudentChart.Series["Series3"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date; 
            StudentChart.Series["Series3"].YValueMembers = "SoLuongSinhVien";
            StudentChart.Series["Series3"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32; 

            StudentChart.Refresh();
        }
    }
}
