using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;

namespace QLCongNghe.Forms
{
    public partial class ThongKeUC : UserControl
    {
        public ThongKeUC()
        {
            InitializeComponent();
        }

        private void ThongKeUC_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            try
            {
                // 🔶 1. Khách hàng có doanh số cao nhất trong tháng hiện tại
                string sqlKH = @"
            SELECT TOP 1 kh.MaKH, kh.TenKH, SUM(hd.GiaTien) AS Tong
            FROM HoaDon hd
            JOIN KhachHang kh ON hd.MaKH = kh.MaKH
            WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
            GROUP BY kh.MaKH, kh.TenKH
            ORDER BY Tong DESC";

                DataTable dtKH = DatabaseHelper.GetData(sqlKH);
                if (dtKH.Rows.Count > 0)
                    lblKhachHangTop.Text = $"Khách hàng doanh số {Environment.NewLine}cao nhất tháng:{Environment.NewLine}{dtKH.Rows[0]["MaKH"]} - {dtKH.Rows[0]["TenKH"]}";
                else
                    lblKhachHangTop.Text = "Không có dữ liệu";

                // 🔷 2. Doanh thu tháng này và tháng trước
                string sqlThangNay = @"
            SELECT ISNULL(SUM(GiaTien), 0)
            FROM HoaDon
            WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())";

                string sqlThangTruoc = @"
            SELECT ISNULL(SUM(GiaTien), 0)
            FROM HoaDon
            WHERE MONTH(NgayLap) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                  AND YEAR(NgayLap) = YEAR(DATEADD(MONTH, -1, GETDATE()))";

                decimal doanhThuNay = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(sqlThangNay));
                decimal doanhThuTruoc = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(sqlThangTruoc));
                decimal chenhlech = doanhThuNay - doanhThuTruoc;

                lblDoanhThuChenhLech.Text = $"Doanh thu so với tháng trước:{Environment.NewLine}{chenhlech.ToString("N0") + " VNĐ"}";

                // 🟩 3. Nhân viên năng suất nhất
                string sqlNV = @"
            SELECT TOP 1 nv.MaNV, nv.TenNV, nv.HinhAnh, COUNT(*) AS SoDon, SUM(hd.GiaTien) AS TongTien
            FROM HoaDon hd
            JOIN NhanVien nv ON nv.MaNV = hd.MaNV
            WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
            GROUP BY nv.MaNV, nv.TenNV, nv.HinhAnh
            ORDER BY SoDon DESC";


                DataTable dtNV = DatabaseHelper.GetData(sqlNV);
                if (dtNV.Rows.Count > 0)
                {
                    lblNhanVienTop.Text = $"Nhân viên năng suất nhất: {Environment.NewLine}{dtNV.Rows[0]["MaNV"]}-{dtNV.Rows[0]["TenNV"]}";

                    if (dtNV.Rows[0]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] hinhAnhBytes = (byte[])dtNV.Rows[0]["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(hinhAnhBytes))
                        {
                            picNhanVien.Image = Image.FromStream(ms); // picNhanVien là PictureBox trên form
                        }
                    }
                    else
                    {
                        picNhanVien.Image = null;
                    }
                }
                else
                {
                    lblNhanVienTop.Text = "Không có dữ liệu";
                    picNhanVien.Image = null;
                }

                // 🟦 4. Biểu đồ số lượng loại sản phẩm bán ra
                string sqlLoaiSP = @"
            SELECT l.TenLoai AS LoaiSP, SUM(cthd.SoLuong) AS SoLuong
            FROM ChiTietHoaDon cthd
            JOIN SanPham sp ON sp.MaSP = cthd.MaSP
            JOIN LoaiSP l ON sp.MaLoai = l.MaLoai
            JOIN HoaDon hd ON hd.MaHD = cthd.MaHD
            WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
            GROUP BY l.TenLoai";

                DataTable dtLoai = DatabaseHelper.GetData(sqlLoaiSP);
                chartLoaiSP.Series[0].Points.Clear();
                foreach (DataRow row in dtLoai.Rows)
                {
                    chartLoaiSP.Series[0].Points.AddPoint(row["LoaiSP"].ToString(), Convert.ToDouble(row["SoLuong"]));
                }

                // ✏️ Thêm nhãn cho biểu đồ loại SP
                chartLoaiSP.Series[0].Label.TextPattern = "{A}:  {VP:P0}"; // A: tên loại, VP: phần trăm
                

                // 🟪 5. Biểu đồ top 5 sản phẩm bán chạy nhất
                string sqlTopSP = @"
            SELECT TOP 5 sp.TenSP, SUM(cthd.SoLuong) AS SoLuong
            FROM ChiTietHoaDon cthd
            JOIN SanPham sp ON sp.MaSP = cthd.MaSP
            JOIN HoaDon hd ON hd.MaHD = cthd.MaHD
            WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
            GROUP BY sp.TenSP
            ORDER BY SoLuong DESC";

                DataTable dtTopSP = DatabaseHelper.GetData(sqlTopSP);
                chartTopSP.Series[0].Points.Clear();
                foreach (DataRow row in dtTopSP.Rows)
                {
                    chartTopSP.Series[0].Points.AddPoint(row["TenSP"].ToString(), Convert.ToDouble(row["SoLuong"]));
                }

                // ✏️ Thêm nhãn cho biểu đồ sản phẩm
                chartTopSP.Series[0].Label.TextPattern = "{A}: {V} ({VP:P0})"; // A: tên SP, V: số lượng, VP: phần trăm
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
