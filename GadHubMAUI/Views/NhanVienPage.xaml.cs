using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class NhanVienPage : ContentPage
    {
        private List<NhanVienDTO> allNhanVien = new List<NhanVienDTO>();

        public NhanVienPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            // Dữ liệu tĩnh cho nhân viên
            allNhanVien = new List<NhanVienDTO>
            {
                new NhanVienDTO { MaNV = "NV001", TenNV = "Trương Văn Admin", SDT = "0901234567", DiaChi = "123 Đường ABC, Quận 1, TP.HCM", HinhAnh = "default_avatar.png" },
                new NhanVienDTO { MaNV = "NV002", TenNV = "Nguyễn Văn Huy", SDT = "0912345678", DiaChi = "456 Đường XYZ, Quận 2, TP.HCM", HinhAnh = "default_avatar.png" },
                new NhanVienDTO { MaNV = "NV003", TenNV = "Lê Thị Mai", SDT = "0923456789", DiaChi = "789 Đường DEF, Quận 3, TP.HCM", HinhAnh = "default_avatar.png" },
                new NhanVienDTO { MaNV = "NV004", TenNV = "Phạm Văn Nam", SDT = "0934567890", DiaChi = "321 Đường GHI, Quận 4, TP.HCM", HinhAnh = "default_avatar.png" },
                new NhanVienDTO { MaNV = "NV005", TenNV = "Hoàng Thị Lan", SDT = "0945678901", DiaChi = "654 Đường JKL, Quận 5, TP.HCM", HinhAnh = "default_avatar.png" }
            };

            cvNhanVien.ItemsSource = allNhanVien;
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ThucHienTimKiem(searchBar.Text);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                cvNhanVien.ItemsSource = allNhanVien;
            }
        }

        private void ThucHienTimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                cvNhanVien.ItemsSource = allNhanVien;
                return;
            }

            var ketQua = allNhanVien.Where(nv => 
                nv.TenNV.ToLower().Contains(tuKhoa.ToLower()) ||
                nv.SDT.Contains(tuKhoa) ||
                nv.DiaChi.ToLower().Contains(tuKhoa.ToLower()))
                .ToList();

            cvNhanVien.ItemsSource = ketQua;
        }

        private async void NhanVien_Tapped(object sender, TappedEventArgs e)
        {
            string maNV = e.Parameter.ToString();
            var nhanVien = allNhanVien.FirstOrDefault(nv => nv.MaNV == maNV);
            
            if (nhanVien != null)
            {
                await DisplayAlert("Thông tin nhân viên", 
                    $"Mã NV: {nhanVien.MaNV}\n" +
                    $"Tên: {nhanVien.TenNV}\n" +
                    $"SĐT: {nhanVien.SDT}\n" +
                    $"Địa chỉ: {nhanVien.DiaChi}", 
                    "Đóng");
            }
        }

        private async void btnSua_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string maNV = button.CommandParameter.ToString();
            await DisplayAlert("Thông báo", $"Chức năng sửa thông tin nhân viên {maNV} đang được phát triển", "OK");
        }

        private async void btnXoa_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string maNV = button.CommandParameter.ToString();
            await DisplayAlert("Thông báo", $"Chức năng xóa nhân viên {maNV} đang được phát triển", "OK");
        }

        private async void btnThem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng thêm nhân viên đang được phát triển", "OK");
        }
    }
}