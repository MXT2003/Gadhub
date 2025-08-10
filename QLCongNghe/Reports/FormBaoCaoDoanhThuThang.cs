using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Reports
{
    public partial class FormBaoCaoDoanhThuThang : Form
    {
        public FormBaoCaoDoanhThuThang()
        {
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            // Lấy đầu tháng và cuối tháng hiện tại
            DateTime now = DateTime.Now;
            DateTime from = new DateTime(now.Year, now.Month, 1);
            DateTime to = from.AddMonths(1).AddDays(-1);

            string query = @"
            SELECT hd.MaHD, hd.NgayLap, kh.TenKH, nv.TenNV, hd.GiaTien
            FROM HoaDon hd
            JOIN KhachHang kh ON hd.MaKH = kh.MaKH
            JOIN NhanVien nv ON nv.MaNV = hd.MaNV
            WHERE hd.NgayLap BETWEEN @From AND @To";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            ReportDataSource rds = new ReportDataSource("DoanhThuThang", dt);
            reportViewer1.LocalReport.ReportPath = "Reports/rptDoanhThuThang.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }

}
