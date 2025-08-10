using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class SanPhamPage : ContentPage
    {
        private List<SanPhamDTO> allSanPham = new List<SanPhamDTO>();
        private List<LoaiSPDTO> allLoaiSP = new List<LoaiSPDTO>();

        public SanPhamPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadDanhMuc();
            LoadDanhSachSanPham();
        }

        private void LoadDanhMuc()
        {
            // Dữ liệu tĩnh cho danh mục
            List<string> danhMucList = new List<string> { "Tất cả", "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện", "Đồng hồ thông minh" };
            pickerDanhMuc.ItemsSource = danhMucList;
            pickerDanhMuc.SelectedIndex = 0;

            // Dữ liệu tĩnh cho loại sản phẩm
            allLoaiSP = new List<LoaiSPDTO>
            {
                new LoaiSPDTO { MaLoai = "L001", TenLoai = "iPhone", TenDanhMuc = "Điện thoại" },
                new LoaiSPDTO { MaLoai = "L002", TenLoai = "Samsung", TenDanhMuc = "Điện thoại" },
                new LoaiSPDTO { MaLoai = "L003", TenLoai = "MacBook", TenDanhMuc = "Laptop" },
                new LoaiSPDTO { MaLoai = "L004", TenLoai = "iPad", TenDanhMuc = "Máy tính bảng" },
                new LoaiSPDTO { MaLoai = "L005", TenLoai = "AirPods", TenDanhMuc = "Phụ kiện" },
                new LoaiSPDTO { MaLoai = "L006", TenLoai = "Apple Watch", TenDanhMuc = "Đồng hồ thông minh" }
            };
        }

        private void LoadDanhSachSanPham(string tenLoai = "")
        {
            // Dữ liệu tĩnh cho sản phẩm
            allSanPham = new List<SanPhamDTO>
            {
                new SanPhamDTO { MaSP = "SP001", MaLoai = "L001", TenSP = "iPhone 15 Pro Max", DonGia = 35000000, SoLuongTon = 50, MoTa = "iPhone 15 Pro Max 256GB Titan tự nhiên", HinhAnh = "dotnet_bot.png" },
                new SanPhamDTO { MaSP = "SP002", MaLoai = "L002", TenSP = "Samsung Galaxy S24 Ultra", DonGia = 28000000, SoLuongTon = 45, MoTa = "Samsung Galaxy S24 Ultra 256GB Titanium Gray", HinhAnh = "dotnet_bot.png" },
                new SanPhamDTO { MaSP = "SP003", MaLoai = "L003", TenSP = "MacBook Pro M3", DonGia = 45000000, SoLuongTon = 30, MoTa = "MacBook Pro 14 inch M3 Pro 512GB", HinhAnh = "dotnet_bot.png" },
                new SanPhamDTO { MaSP = "SP004", MaLoai = "L004", TenSP = "iPad Pro 12.9", DonGia = 32000000, SoLuongTon = 25, MoTa = "iPad Pro 12.9 inch M2 256GB WiFi", HinhAnh = "dotnet_bot.png" },
                new SanPhamDTO { MaSP = "SP005", MaLoai = "L005", TenSP = "AirPods Pro 2", DonGia = 6500000, SoLuongTon = 100, MoTa = "AirPods Pro 2 với chống ồn chủ động", HinhAnh = "dotnet_bot.png" },
                new SanPhamDTO { MaSP = "SP006", MaLoai = "L006", TenSP = "Apple Watch Series 9", DonGia = 12000000, SoLuongTon = 60, MoTa = "Apple Watch Series 9 GPS 45mm", HinhAnh = "dotnet_bot.png" }
            };

            // Lọc theo loại sản phẩm nếu có
            if (!string.IsNullOrWhiteSpace(tenLoai))
            {
                var loaiSP = allLoaiSP.FirstOrDefault(l => l.TenLoai == tenLoai);
                if (loaiSP != null)
                {
                    allSanPham = allSanPham.Where(sp => sp.MaLoai == loaiSP.MaLoai).ToList();
                }
            }

            cvSanPham.ItemsSource = allSanPham;
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ThucHienTimKiem(searchBar.Text);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                cvSanPham.ItemsSource = allSanPham;
            }
        }

        private void ThucHienTimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                cvSanPham.ItemsSource = allSanPham;
                return;
            }

            var ketQua = allSanPham.Where(sp => 
                sp.TenSP.ToLower().Contains(tuKhoa.ToLower()) ||
                sp.MoTa.ToLower().Contains(tuKhoa.ToLower())
            ).ToList();

            cvSanPham.ItemsSource = ketQua;
        }

        private void pickerDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerDanhMuc.SelectedIndex == 0)
            {
                LoadDanhSachSanPham();
            }
            else
            {
                string danhMuc = pickerDanhMuc.SelectedItem.ToString();
                var loaiSPList = allLoaiSP.Where(l => l.TenDanhMuc == danhMuc).ToList();
                
                List<string> tenLoaiList = new List<string> { "Tất cả" };
                tenLoaiList.AddRange(loaiSPList.Select(l => l.TenLoai));
                
                pickerLoaiSP.ItemsSource = tenLoaiList;
                pickerLoaiSP.SelectedIndex = 0;
            }
        }

        private void pickerLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerLoaiSP.SelectedIndex == 0)
            {
                LoadDanhSachSanPham();
            }
            else
            {
                string tenLoai = pickerLoaiSP.SelectedItem.ToString();
                LoadDanhSachSanPham(tenLoai);
            }
        }

        private async void SanPham_Tapped(object sender, TappedEventArgs e)
        {
            var sanPham = e.Parameter as SanPhamDTO;
            if (sanPham != null)
            {
                await Shell.Current.GoToAsync($"ChiTietSanPhamPage?MaSP={sanPham.MaSP}");
            }
        }

        private async void btnThem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ThemSanPhamPage");
        }
    }
}