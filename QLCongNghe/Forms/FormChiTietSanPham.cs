using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class FormChiTietSanPham : Form
    {
        
        private string maSP; // lưu mã sản phẩm để truy vấn
        private string tenFileAnh = ""; // lưu tên file ảnh mới nếu có đổi
        public FormChiTietSanPham(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP; // Gán giá trị
            
            string sql = $"SELECT * FROM SanPham WHERE MaSP = '{maSP}'";
            DataTable dt = DatabaseHelper.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTenSP.Text = row["TenSP"].ToString();
                lblLoai.Text = $"Loại sản phẩm: {LayTenLoaiSP(row["MaLoai"].ToString())}";
                lblSoLuong.Text = $"Số lượng: {row["SoLuongTon"]}";
                lblGia.Text = string.Format("{0:N0} VNĐ", row["DonGia"]);
                
                lblMoTa.Text = row["MoTa"].ToString();
                tenFileAnh = row["HinhAnh"].ToString();
                picSanPham.Image = Image.FromFile(Application.StartupPath + @"\Images\" + tenFileAnh);
            }
        }
        
        private string LayTenLoaiSP(string maLoai)
        {
            string sql = $"SELECT TenLoai FROM LoaiSP WHERE MaLoai = '{maLoai}'";
            var dt = DatabaseHelper.GetData(sql);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TenLoai"].ToString();
            return "";
        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xoá sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM SanPham WHERE MaSP = '{maSP}'";
                DatabaseHelper.Execute(sql);
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FormThemSanPham frm = new FormThemSanPham(maSP);
            frm.FormClosed += (s, args) => this.Close(); // Đóng form chi tiết sau khi cập nhật
            frm.ShowDialog();
        }
    }
}
