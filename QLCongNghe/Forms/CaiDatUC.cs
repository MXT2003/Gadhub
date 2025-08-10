using System;
using System.IO;
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
    public partial class CaiDatUC : UserControl
    {
        public CaiDatUC()
        {
            InitializeComponent();
            LoadThongTinCaNhan();
        }
        private void LoadThongTinCaNhan()
        {
            // Lấy dữ liệu từ DB theo MaNV đang đăng nhập
            string sql = $"SELECT * FROM NhanVien WHERE MaNV = '{Session.MaNhanVien}'";
            DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow nv = dt.Rows[0];

                // Cập nhật Session từ DB (chắc chắn đồng bộ)
                Session.TenNhanVien = nv["TenNV"] != DBNull.Value ? nv["TenNV"].ToString() : "";
                Session.GioiTinh = nv["GioiTinh"] != DBNull.Value ? nv["GioiTinh"].ToString() : "";
                Session.NgaySinh = nv["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(nv["NgaySinh"]) : DateTime.MinValue;
                Session.SDT = nv["SDT"] != DBNull.Value ? nv["SDT"].ToString() : "";
                Session.DiaChi = nv["DiaChi"] != DBNull.Value ? nv["DiaChi"].ToString() : "";
                Session.Email = nv["Email"] != DBNull.Value ? nv["Email"].ToString() : "";


                if (nv["HinhAnh"] != DBNull.Value)
                    Session.HinhAnh = (byte[])nv["HinhAnh"];
                else
                    Session.HinhAnh = null;

                // Gán dữ liệu lên các control
                txtHoTen.Text = Session.TenNhanVien;
                cboGioiTinh.Text = Session.GioiTinh;
                dateNgaySinh.DateTime = Session.NgaySinh;
                txtSDT.Text = Session.SDT;
                txtDiaChi.Text = Session.DiaChi;
                txtEmail.Text = Session.Email;

                if (Session.HinhAnh != null)
                {
                    using (var ms = new MemoryStream(Session.HinhAnh))
                    {
                        picAnh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picAnh.Image = null;
                }
            }

            // Tài khoản
            string sqlTK = $"SELECT TenDangNhap, MatKhau FROM TaiKhoan WHERE MaNV = '{Session.MaNhanVien}'";
            DataTable dtTK = DatabaseHelper.GetData(sqlTK);
            if (dtTK.Rows.Count > 0)
            {
                txtTenDangNhap.Text = dtTK.Rows[0]["TenDangNhap"].ToString();
                txtMatKhau.Text = dtTK.Rows[0]["MatKhau"].ToString();
            }
        }




        private void btnThayDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(ofd.FileName);
                    Session.HinhAnh = File.ReadAllBytes(ofd.FileName); // Lưu dạng byte[]
                }
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql = $@"
    UPDATE NhanVien SET
        TenNV = N'{txtHoTen.Text}',
        GioiTinh = N'{cboGioiTinh.Text}',
        NgaySinh = '{dateNgaySinh.DateTime:yyyy-MM-dd}',
        SDT = '{txtSDT.Text}',
        DiaChi = N'{txtDiaChi.Text}',
        Email = '{txtEmail.Text}'
    WHERE MaNV = '{Session.MaNhanVien}'";

            DatabaseHelper.Execute(sql);
            
            // Cập nhật hình ảnh (nếu có)
            if (Session.HinhAnh != null)
            {
                string sqlAnh = "UPDATE NhanVien SET HinhAnh = @HinhAnh WHERE MaNV = @MaNV";
                DatabaseHelper.Execute(sqlAnh, new Dictionary<string, object>{{ "@HinhAnh", Session.HinhAnh },{ "@MaNV", Session.MaNhanVien }});
            }

            // 🔁 Cập nhật lại Session bằng dữ liệu mới nhất
            string sqlReload = $"SELECT * FROM NhanVien WHERE MaNV = '{Session.MaNhanVien}'";
            DataTable dt = DatabaseHelper.GetData(sqlReload);
            if (dt.Rows.Count > 0)
            {
                DataRow nv = dt.Rows[0];

                Session.TenNhanVien = nv["TenNV"] != DBNull.Value ? nv["TenNV"].ToString() : "";
                Session.GioiTinh = nv["GioiTinh"] != DBNull.Value ? nv["GioiTinh"].ToString() : "";
                Session.NgaySinh = nv["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(nv["NgaySinh"]) : DateTime.MinValue;
                Session.SDT = nv["SDT"] != DBNull.Value ? nv["SDT"].ToString() : "";
                Session.DiaChi = nv["DiaChi"] != DBNull.Value ? nv["DiaChi"].ToString() : "";
                Session.Email = nv["Email"] != DBNull.Value ? nv["Email"].ToString() : "";


                if (nv["HinhAnh"] != DBNull.Value)
                    Session.HinhAnh = (byte[])nv["HinhAnh"];
                else
                    Session.HinhAnh = null;
            }

            // ✅ Cập nhật giao diện bên MainForm
            Form parentForm = this.FindForm();
            MainForm main = parentForm as MainForm;
            if (main != null)
            {
                main.CapNhatThongTinNguoiDung();
                
                // 🟢 THÊM: cập nhật tên bên MainForm
                LabelControl lblTen = main.Controls.Find("lblTenNguoiDung", true).FirstOrDefault() as LabelControl;
                if (lblTen != null)
                    lblTen.Text = Session.TenNhanVien;
            }

            XtraMessageBox.Show("Cập nhật thông tin thành công!");
            LoadThongTinCaNhan();
        }



        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau(Session.MaNhanVien);
            frm.ShowDialog();
        }
    }
}
