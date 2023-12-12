using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            // Duyệt qua danh sách và chuyển đổi ngày thành dạng chuỗi theo định dạng yyyy-MM-dd
            var convertedFees = fees.Select(fee =>
            {
                DateTime dateValue;
                string formattedDate = string.Empty;

                // Kiểm tra xem chuỗi có thể chuyển đổi thành ngày tháng hợp lệ không
                if (DateTime.TryParseExact(fee.Ngay, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                {
                    // Nếu chuyển đổi thành công, định dạng lại ngày tháng và gán vào biến formattedDate
                    formattedDate = dateValue.ToString("yyyy-MM-dd");
                }
                // Trả về một đối tượng mới với ngày được chuyển đổi (hoặc rỗng nếu không thành công)
                return new { Ngay = formattedDate, fee.TongPhiPhong };
            }).ToList();

            // Sử dụng danh sách sau khi chuyển đổi
            FeeChart.DataSource = convertedFees;
            FeeChart.Series["Series1"].XValueMember = "Ngay";
            FeeChart.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            FeeChart.Series["Series1"].YValueMembers = "TongPhiPhong";
            FeeChart.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }


        private void btnLoadConsumeChart_Click(object sender, EventArgs e)
        {
            DbFeeConsumeDataContext db = new DbFeeConsumeDataContext();

            var consumeFees = db.vwFeeConsumes.ToList();

            ConsumeChart.DataSource = consumeFees;
            ConsumeChart.Series["Series2"].XValueMember = "NgayHaoPhi";
            ConsumeChart.Series["Series2"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date; 
            ConsumeChart.Series["Series2"].YValueMembers = "TongPhiPhong";
            ConsumeChart.Series["Series2"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double; 

           // ConsumeChart.Refresh();
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
