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
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;

namespace QLCongNghe.Forms
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = GenerateMaNhanVien();  
            txtMaNV.ReadOnly = true;              
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cboVaiTro.SelectedItem.ToString().ToLower();

            // 1. Thêm nhân viên
            string sqlNV = $"INSERT INTO NhanVien (MaNV, TenNV, SDT, DiaChi) " +
                           $"VALUES (N'{maNV}', N'{tenNV}', N'{sdt}', N'{diaChi}')";
            DatabaseHelper.Execute(sqlNV);

            // 2. Băm mật khẩu
            string hashedPassword = HashHelper.ComputeSha256Hash(matKhau);

            // 3. Thêm tài khoản
            string sqlTK = $"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaNV, VaiTro) " +
                           $"VALUES (N'{tenDangNhap}', N'{hashedPassword}', N'{maNV}', N'{vaiTro}')";
            DatabaseHelper.Execute(sqlTK);

            XtraMessageBox.Show("Thêm nhân viên và tài khoản thành công!");
            this.DialogResult = DialogResult.OK;
        }
        private string GenerateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MaNV FROM NhanVien ORDER BY MaNV DESC";
            DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count == 0)
            {
                return prefix + "001";
            }

            string lastMa = dt.Rows[0]["MaNV"].ToString(); // VD: NV015
            int number = int.Parse(lastMa.Substring(2));   // 15
            number++;                                      // 16

            return prefix + number.ToString("D3");         // NV016
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
