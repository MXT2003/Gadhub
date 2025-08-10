using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class ChiTietKhachHangPage : ContentPage
    {
        private string maKH;
        private KhachHangDTO khachHang;

        public ChiTietKhachHangPage(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadChiTietKhachHang();
            await LoadLichSuMuaHang();
        }

        private async Task LoadChiTietKhachHang()
        {
            try
            {
                // Mock data cho khách hàng
                khachHang = new KhachHangDTO
                {
                    MaKH = maKH,
                    TenKH = "Nguyễn Văn An",
                    SDT = "0901234567",
                    DiaChi = "123 Đường ABC, Quận 1, TP.HCM"
                };

                // Hiển thị thông tin khách hàng
                lblMaKH.Text = khachHang.MaKH;
                lblTenKH.Text = khachHang.TenKH;
                lblSDT.Text = khachHang.SDT;
                lblDiaChi.Text = khachHang.DiaChi;

                // Hiển thị chữ cái đầu của tên
                lblInitials.Text = GetInitials(khachHang.TenKH);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải thông tin khách hàng: {ex.Message}", "OK");
            }
        }

        private async Task LoadLichSuMuaHang()
        {
            try
            {
                // Mock data cho lịch sử mua hàng
                List<HoaDonDTO> lichSuMuaHang = new List<HoaDonDTO>
                {
                    new HoaDonDTO
                    {
                        MaHD = "HD001",
                        NgayLap = DateTime.Now.AddDays(-1),
                        GiaTien = 35000000
                    },
                    new HoaDonDTO
                    {
                        MaHD = "HD003",
                        NgayLap = DateTime.Now.AddDays(-5),
                        GiaTien = 45000000
                    }
                };

                cvLichSuMuaHang.ItemsSource = lichSuMuaHang;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải lịch sử mua hàng: {ex.Message}", "OK");
            }
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return "?";

            var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
                return "?";

            if (parts.Length == 1)
                return parts[0][0].ToString().ToUpper();

            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void btnSua_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng sửa thông tin khách hàng đang được phát triển", "OK");
            // Tại đây có thể mở trang sửa thông tin khách hàng
            // await Navigation.PushAsync(new SuaKhachHangPage(maKH));
        }

        private async void btnXoa_Clicked(object sender, EventArgs e)
        {
            bool xacNhan = await DisplayAlert("Xác nhận", 
                $"Bạn có chắc chắn muốn xóa khách hàng {khachHang.TenKH}?", 
                "Xóa", "Hủy");

            if (xacNhan)
            {
                try
                {
                    // Mock data - kiểm tra xem khách hàng có hóa đơn không
                    bool coHoaDon = true; // Mock: giả sử có hóa đơn

                    if (coHoaDon)
                    {
                        await DisplayAlert("Lỗi", 
                            "Không thể xóa khách hàng này vì đã có hóa đơn trong hệ thống", 
                            "OK");
                        return;
                    }

                    // Mock: xóa thành công
                    await DisplayAlert("Thành công", "Đã xóa khách hàng (Mock data)", "OK");
                    await Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Lỗi", $"Không thể xóa khách hàng: {ex.Message}", "OK");
                }
            }
        }
    }
}