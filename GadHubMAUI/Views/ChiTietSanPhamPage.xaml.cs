using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class ChiTietSanPhamPage : ContentPage
    {
        private string maSP;
        private SanPhamDTO sanPham;

        public ChiTietSanPhamPage(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadChiTietSanPham();
        }

        private void LoadChiTietSanPham()
        {
            // Dữ liệu tĩnh cho sản phẩm
            var sanPhamData = new Dictionary<string, (SanPhamDTO, string, string)>
            {
                ["SP001"] = (new SanPhamDTO { MaSP = "SP001", TenSP = "iPhone 15 Pro Max", DonGia = 35000000, SoLuongTon = 50, MoTa = "iPhone 15 Pro Max 256GB Titan tự nhiên", HinhAnh = "iphone.jpg" }, "iPhone", "Điện thoại"),
                ["SP002"] = (new SanPhamDTO { MaSP = "SP002", TenSP = "Samsung Galaxy S24 Ultra", DonGia = 28000000, SoLuongTon = 45, MoTa = "Samsung Galaxy S24 Ultra 256GB Titanium Gray", HinhAnh = "iphone.jpg" }, "Samsung", "Điện thoại"),
                ["SP003"] = (new SanPhamDTO { MaSP = "SP003", TenSP = "MacBook Pro M3", DonGia = 45000000, SoLuongTon = 30, MoTa = "MacBook Pro 14 inch M3 Pro 512GB", HinhAnh = "xiaomi.png" }, "MacBook", "Laptop"),
                ["SP004"] = (new SanPhamDTO { MaSP = "SP004", TenSP = "iPad Pro 12.9", DonGia = 32000000, SoLuongTon = 25, MoTa = "iPad Pro 12.9 inch M2 256GB WiFi", HinhAnh = "iphone.jpg" }, "iPad", "Máy tính bảng"),
                ["SP005"] = (new SanPhamDTO { MaSP = "SP005", TenSP = "AirPods Pro 2", DonGia = 6500000, SoLuongTon = 100, MoTa = "AirPods Pro 2 với chống ồn chủ động", HinhAnh = "xiaomi.png" }, "AirPods", "Phụ kiện"),
                ["SP006"] = (new SanPhamDTO { MaSP = "SP006", TenSP = "Apple Watch Series 9", DonGia = 12000000, SoLuongTon = 60, MoTa = "Apple Watch Series 9 GPS 45mm", HinhAnh = "xiaomi.png" }, "Apple Watch", "Đồng hồ thông minh")
            };

            if (sanPhamData.TryGetValue(maSP, out var data))
            {
                sanPham = data.Item1;
                string tenLoai = data.Item2;
                string tenDanhMuc = data.Item3;

                // Hiển thị thông tin sản phẩm
                lblTenSP.Text = sanPham.TenSP;
                lblDonGia.Text = $"{sanPham.DonGia:#,##0} VNĐ";
                lblLoaiSP.Text = $"{tenDanhMuc} > {tenLoai}";
                lblSoLuongTon.Text = sanPham.SoLuongTon.ToString();
                lblMoTa.Text = sanPham.MoTa;

                // Hiển thị hình ảnh
                try
                {
                    string imagePath = sanPham.HinhAnh;
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        imgSanPham.Source = imagePath;
                    }
                    else
                    {
                        imgSanPham.Source = "dotnet_bot.png";
                    }
                }
                catch
                {
                    imgSanPham.Source = "dotnet_bot.png";
                }
            }
            else
            {
                DisplayAlert("Thông báo", "Không tìm thấy thông tin sản phẩm", "OK");
                Navigation.PopAsync();
            }
        }

        private async void btnSua_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng sửa sản phẩm đang được phát triển", "OK");
        }

        private async void btnXoa_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Xác nhận", "Bạn có chắc chắn muốn xóa sản phẩm này?", "Xóa", "Hủy");
            if (answer)
            {
                await DisplayAlert("Thông báo", "Chức năng xóa sản phẩm đang được phát triển", "OK");
            }
        }

        private async void btnThemVaoGio_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng thêm vào giỏ hàng đang được phát triển", "OK");
        }
    }
}