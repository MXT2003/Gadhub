using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;


namespace QLCongNghe.Forms
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }
        
        private void DashboardUC_Load(object sender, EventArgs e)
        {
            dateEditNgay.EditValue = DateTime.Today;
            LoadDashboardData((DateTime)dateEditNgay.EditValue);
            
        }
        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEditNgay.EditValue != null)
            {
                DateTime selectedDate = Convert.ToDateTime(dateEditNgay.EditValue);
                LoadDashboardData(selectedDate);
            }
        }
        private void LoadDashboardData(DateTime selectedDate)
        {
            string ngay = selectedDate.ToString("yyyy-MM-dd");

            // Doanh thu
            string sqlDoanhThu = $"SELECT ISNULL(SUM(GiaTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = '{ngay}'";
            lblDoanhThu.Text = $"Doanh thu trong {Environment.NewLine}ngày:{Environment.NewLine}{DatabaseHelper.ExecuteScalar(sqlDoanhThu):n0} VNĐ";

            // Số đơn
            string sqlSoDon = $"SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS DATE) = '{ngay}'";
            lblSoDon.Text = $"Số đơn bán ra {Environment.NewLine}trong ngày:{Environment.NewLine}{DatabaseHelper.ExecuteScalar(sqlSoDon)}";

            // Số sản phẩm đã bán
            string sqlSP = $@"
        SELECT ISNULL(SUM(ct.SoLuong), 0)
        FROM ChiTietHoaDon ct
        JOIN HoaDon hd ON hd.MaHD = ct.MaHD
        WHERE CAST(hd.NgayLap AS DATE) = '{ngay}'";
            lblSoSanPham.Text = $"Số sản phẩm bán {Environment.NewLine}trong ngày:{Environment.NewLine}{DatabaseHelper.ExecuteScalar(sqlSP)}";
            lblSoSanPham.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblSoSanPham.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

            // Load dữ liệu vào biểu đồ nếu có
            LoadChart(ngay);
        }
        private void LoadChart(string ngay)
        {
            string sql = $@"
    SELECT sp.TenSP, SUM(ct.SoLuong) AS Tong
    FROM ChiTietHoaDon ct
    JOIN HoaDon hd ON hd.MaHD = ct.MaHD
    JOIN SanPham sp ON sp.MaSP = ct.MaSP
    WHERE CAST(hd.NgayLap AS DATE) = '{ngay}'
    GROUP BY sp.TenSP";

            DataTable dt = DatabaseHelper.GetData(sql);


            chartBanHang.Series.Clear();

            var series = new DevExpress.XtraCharts.Series("Sản phẩm", DevExpress.XtraCharts.ViewType.Bar);

            // Ép kiểu view và set thuộc tính màu sắc
            var view = series.View as DevExpress.XtraCharts.BarSeriesView;
            if (view != null)
            {
                view.ColorEach = true; // mỗi cột 1 màu
            }

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True; // hiện số lên cột
            series.LegendTextPattern = "{A}";

            foreach (DataRow row in dt.Rows)
            {
                string tenSP = row["TenSP"].ToString();
                int soLuong = Convert.ToInt32(row["Tong"]);
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(tenSP, soLuong));
            }

            chartBanHang.Series.Add(series);
            chartBanHang.Refresh();
            chartBanHang.Update();


        }
        
    }
}
