using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;

namespace QLCongNghe.Forms
{
    public partial class FormTaoHoaDon : Form
    {
        List<ChiTietHoaDonDTO> gioHang = new List<ChiTietHoaDonDTO>();

        public FormTaoHoaDon()
        {
            InitializeComponent();
        }

        private void FormTaoHoaDon_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = Session.MaNhanVien;
            txtTenNV.Text = Session.TenNhanVien;

            txtMaKH.Text = GenerateMaKH();
            txtMaKH.ReadOnly = true;

            dateNgay.EditValue = DateTime.Now;
            txtSoHD.Text = GenerateSoHoaDon();
            lblTongTien.Visible = false; // ✅ Ẩn tổng tiền ban đầu

            LoadSanPham();
        }

        private string GenerateMaKH()
        {
            string rand = Path.GetRandomFileName().Replace(".", "").Substring(0, 2).ToUpper();
            return $"KH{DateTime.Now:ddMM}{rand}";
        }

        private string GenerateSoHoaDon()
        {
            string rand = Path.GetRandomFileName().Replace(".", "").Substring(0, 2).ToUpper();
            return $"HD{DateTime.Now:ddMMyy}{rand}";
        }

        private void LoadSanPham()
        {
            var dt = DatabaseHelper.GetData("SELECT MaSP, TenSP, DonGia, SoLuongTon FROM SanPham");
            lookupSP.Properties.DataSource = dt;
            lookupSP.Properties.DisplayMember = "TenSP";
            lookupSP.Properties.ValueMember = "MaSP";
        }

        private void lookupSP_EditValueChanged(object sender, EventArgs e)
        {
            string maSP = lookupSP.EditValue?.ToString();
            if (string.IsNullOrEmpty(maSP)) return;

            DataTable dt = DatabaseHelper.GetData($"SELECT DonGia, SoLuongTon FROM SanPham WHERE MaSP = '{maSP}'");
            int tonKho = Convert.ToInt32(dt.Rows[0]["SoLuongTon"]); 
            if (dt.Rows.Count > 0)
            {
                decimal donGia = Convert.ToDecimal(dt.Rows[0]["DonGia"]);
                txtDonGia.Text = donGia.ToString("N0");
                // ✅ Cập nhật đơn giá
                txtDonGia.Text = donGia.ToString("N0");

                // ✅ Cập nhật giới hạn số lượng
                spinSoLuong.Properties.MinValue = 1;
                spinSoLuong.Properties.MaxValue = tonKho;
                spinSoLuong.Value = 1; // đảm bảo hợp lệ
                                       // ✅ Cho phép hoặc không cho nhập số lượng nếu hết hàng
                spinSoLuong.Enabled = tonKho > 0;

                // ✅ Enable nút thêm nếu có hàng
                btnThem.Enabled = tonKho > 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = lookupSP.EditValue?.ToString();
            if (string.IsNullOrEmpty(maSP))
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            int soLuong = Convert.ToInt32(spinSoLuong.Value);
            //  Không được thêm nếu số lượng <= 0
            if (soLuong <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập số lượng lớn hơn 0.");
                return;
            }
            DataTable dt = DatabaseHelper.GetData($"SELECT DonGia, SoLuongTon FROM SanPham WHERE MaSP = '{maSP}'");

            if (dt.Rows.Count == 0) return;

            int tonKho = Convert.ToInt32(dt.Rows[0]["SoLuongTon"]);
            decimal donGia = Convert.ToDecimal(dt.Rows[0]["DonGia"]);

            int daChon = gioHang.Where(x => x.MaSP == maSP).Sum(x => x.SoLuong);

            if (soLuong + daChon > tonKho)
            {
                XtraMessageBox.Show($"Sản phẩm còn {tonKho - daChon} trong kho, vui lòng nhập lại.");
                return;
            }

            var existing = gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = maSP,
                    TenSP = lookupSP.Text,
                    DonGia = donGia,
                    SoLuong = soLuong
                });
            }

            gridControl1.DataSource = null;
            gridControl1.DataSource = gioHang;

            CapNhatTongTien(); // ✅ Cập nhật tổng tiền
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView == null || gridView.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            var item = gridView.GetRow(gridView.FocusedRowHandle) as ChiTietHoaDonDTO;
            if (item != null)
            {
                gioHang.Remove(item);
                gridControl1.DataSource = null;
                gridControl1.DataSource = gioHang;

                CapNhatTongTien(); // ✅ Cập nhật lại tổng tiền sau khi xóa
            }
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = gioHang.Sum(x => x.SoLuong * x.DonGia);
            if (gioHang.Count == 0)
            {
                lblTongTien.Visible = false;
            }
            else
            {
                lblTongTien.Visible = true;
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }
            if (gioHang.Any(sp => sp.SoLuong <= 0))
            {
                XtraMessageBox.Show("Một số sản phẩm có số lượng không hợp lệ (<= 0). Vui lòng kiểm tra lại.");
                return;
            }
            if (gioHang.Count == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn ít nhất một sản phẩm vào giỏ hàng trước khi thanh toán.");
                return;
            }

            string sqlKH = $"INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi) VALUES " +
                           $"('{txtMaKH.Text}', N'{txtTenKH.Text}', '', '')";
            DatabaseHelper.Execute(sqlKH);

            string maHD = txtSoHD.Text;
            string maNV = Session.MaNhanVien;
            DateTime ngay = Convert.ToDateTime(dateNgay.EditValue);
            decimal tongTien = gioHang.Sum(x => x.ThanhTien);

            string sqlHD = $@"
                            INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayLap, GiaTien)
                            VALUES('{maHD}', '{txtMaKH.Text}', '{maNV}', '{ngay:yyyy-MM-dd}', {tongTien})";
                                        DatabaseHelper.Execute(sqlHD);

            foreach (var item in gioHang)
            {
                string sqlCT = $@"
                            INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                            VALUES('{maHD}', '{item.MaSP}', {item.SoLuong}, {item.DonGia})";
                                            DatabaseHelper.Execute(sqlCT);

                string sqlUpdateSP = $@"
                            UPDATE SanPham SET SoLuongTon = SoLuongTon - {item.SoLuong}
                            WHERE MaSP = '{item.MaSP}'";
                                            DatabaseHelper.Execute(sqlUpdateSP);
            }

            XtraMessageBox.Show("Lập hóa đơn thành công!");
            this.Close();
        }
    }
}
