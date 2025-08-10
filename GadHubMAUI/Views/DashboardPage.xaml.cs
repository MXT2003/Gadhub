using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class DashboardPage : ContentPage
    {
        private List<HoaDonDTO> recentOrders;

        public DashboardPage()
        {
            InitializeComponent();
            InitializeSampleData();
        }

        private void InitializeSampleData()
        {
            // Tạo dữ liệu mẫu cho đơn hàng gần đây
            recentOrders = new List<HoaDonDTO>
            {
                new HoaDonDTO
                {
                    MaHD = "HD001",
                    MaKH = "KH001",
                    MaNV = "NV001",
                    NgayLap = DateTime.Now.AddDays(-1),
                    GiaTien = 2500000,
                    TenKH = "Nguyễn Văn An",
                    TenNV = "Xuân Trường"
                },
                new HoaDonDTO
                {
                    MaHD = "HD002",
                    MaKH = "KH002",
                    MaNV = "NV002",
                    NgayLap = DateTime.Now.AddDays(-2),
                    GiaTien = 1800000,
                    TenKH = "Trần Thị Bình",
                    TenNV = "Đan Huy"
                },
                new HoaDonDTO
                {
                    MaHD = "HD003",
                    MaKH = "KH003",
                    MaNV = "NV001",
                    NgayLap = DateTime.Now.AddDays(-3),
                    GiaTien = 3200000,
                    TenKH = "Lê Văn Cường",
                    TenNV = "Xuân Trường"
                },
                new HoaDonDTO
                {
                    MaHD = "HD004",
                    MaKH = "KH004",
                    MaNV = "NV002",
                    NgayLap = DateTime.Now.AddDays(-4),
                    GiaTien = 950000,
                    TenKH = "Phạm Thị Dung",
                    TenNV = "Đan Huy"
                },
                new HoaDonDTO
                {
                    MaHD = "HD005",
                    MaKH = "KH005",
                    MaNV = "NV001",
                    NgayLap = DateTime.Now.AddDays(-5),
                    GiaTien = 4100000,
                    TenKH = "Hoàng Văn Em",
                    TenNV = "Xuân Trường"
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // Hiển thị tên người dùng
            lblWelcome.Text = $"Xin chào, {Session.TenNhanVien}";

            // Dữ liệu tĩnh cho dashboard
            lblDoanhThu.Text = "15,500,000 VNĐ";
            lblDonHang.Text = "8";
            lblSanPham.Text = "6";
            lblKhachHang.Text = "5";

            // Hiển thị đơn hàng gần đây
            cvRecentOrders.ItemsSource = recentOrders;
        }
    }
}