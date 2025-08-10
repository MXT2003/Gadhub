using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;   
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class DonHangUC : UserControl
    {
        public DonHangUC()
        {
            InitializeComponent();

        }

        private void DonHangUC_Load(object sender, EventArgs e)
        {
            comboTieuChi.Properties.Items.AddRange(new[] { "Họ tên", "Mã hóa đơn" });
            comboTieuChi.SelectedIndex = 0;
            LoadHoaDon();
        }
        private void LoadHoaDon(string keyword = "", string tieuChi = "Họ tên")
        {
            string sql = @"
        SELECT 
            hd.MaHD, 
            kh.TenKH, 
            hd.NgayLap, 
            hd.GiaTien,
            STUFF((
                SELECT ', ' + sp.TenSP + ' (x' + CAST(ct.SoLuong AS NVARCHAR) + ')'
                FROM ChiTietHoaDon ct
                JOIN SanPham sp ON sp.MaSP = ct.MaSP
                WHERE ct.MaHD = hd.MaHD
                FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS SanPhamDaMua
        FROM HoaDon hd
        JOIN KhachHang kh ON kh.MaKH = hd.MaKH
    ";

            if (!string.IsNullOrEmpty(keyword))
            {
                sql += (tieuChi == "Họ tên")
    ? $" WHERE kh.TenKH COLLATE Latin1_General_CI_AI LIKE N'%{keyword}%'"
    : $" WHERE hd.MaHD COLLATE Latin1_General_CI_AI LIKE N'%{keyword}%'";
            }

            DataTable dt = DatabaseHelper.GetData(sql);

            // 👉 THÔNG BÁO nếu không có dữ liệu
            if (!string.IsNullOrEmpty(keyword) && dt.Rows.Count == 0)
            {
                XtraMessageBox.Show($"Không tìm thấy kết quả với \"{keyword}\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            gridControl1.DataSource = dt;

            var view = gridControl1.MainView as GridView;

            if (view != null)
            {
                view.PopulateColumns();

                // Format và caption cột
                if (view.Columns["GiaTien"] != null)
                {
                    view.Columns["GiaTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    view.Columns["GiaTien"].DisplayFormat.FormatString = "n0";
                    view.Columns["GiaTien"].Caption = "Giá tiền (VNĐ)";
                    view.Columns["GiaTien"].OptionsColumn.AllowEdit = false;
                }

                if (view.Columns["MaHD"] != null)
                    view.Columns["MaHD"].Caption = "Mã hóa đơn";

                if (view.Columns["TenKH"] != null)
                    view.Columns["TenKH"].Caption = "Tên khách hàng";

                if (view.Columns["NgayLap"] != null)
                {
                    view.Columns["NgayLap"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["NgayLap"].DisplayFormat.FormatString = "dd/MM/yyyy";
                    view.Columns["NgayLap"].Caption = "Ngày lập";
                }

                if (view.Columns["SanPhamDaMua"] != null)
                    view.Columns["SanPhamDaMua"].Caption = "Sản phẩm đã mua";

                view.BestFitColumns();
                view.OptionsView.ShowGroupPanel = false;
            }
        }
        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            // Nếu ô tìm kiếm trống thì quay về toàn bộ hóa đơn
            if (string.IsNullOrEmpty(keyword))
            {
                LoadHoaDon(); // Mặc định
            }
            else
            {
                LoadHoaDon(keyword, comboTieuChi.Text);
            }
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadHoaDon(txtTimKiem.Text.Trim(), comboTieuChi.Text);
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            var frm = new FormTaoHoaDon();
            frm.ShowDialog();

        }
    }
}
