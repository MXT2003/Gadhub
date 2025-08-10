# GadHub MAUI - Hệ thống quản lý cửa hàng

## Mô tả
GadHub MAUI là ứng dụng quản lý cửa hàng được phát triển bằng .NET MAUI, hỗ trợ đa nền tảng (Android, iOS, Windows, macOS).

## Tính năng chính
- 🔐 **Đăng nhập an toàn** với xác thực vai trò (Admin/Nhân viên)
- 📊 **Dashboard** hiển thị tổng quan kinh doanh
- 📦 **Quản lý sản phẩm** với tìm kiếm và lọc theo danh mục
- 👥 **Quản lý khách hàng** 
- 📋 **Quản lý đơn hàng**
- 👨‍💼 **Quản lý nhân viên**

## Tài khoản demo

### Admin
- **Username:** `truong`
- **Password:** `1`
- **Quyền:** Toàn quyền quản lý hệ thống

### Nhân viên
- **Username:** `huy`
- **Password:** `1`
- **Quyền:** Xem và quản lý dữ liệu cơ bản

## Mock Data
Ứng dụng sử dụng mock data thay vì SQL Server để đảm bảo hoạt động trên tất cả các nền tảng:

### Sản phẩm mẫu
- iPhone 15 Pro Max - 35,000,000 VNĐ
- Samsung Galaxy S24 Ultra - 28,000,000 VNĐ
- MacBook Pro M3 - 45,000,000 VNĐ
- iPad Pro 12.9 - 32,000,000 VNĐ
- AirPods Pro 2 - 6,500,000 VNĐ
- Apple Watch Series 9 - 12,000,000 VNĐ

### Khách hàng mẫu
- Nguyễn Văn An
- Trần Thị Bình
- Lê Văn Cường
- Phạm Thị Dung
- Hoàng Văn Em

### Đơn hàng mẫu
- 4 đơn hàng với trạng thái khác nhau (Đã giao, Đang giao, Chờ xử lý)

## Cải tiến giao diện

### Thiết kế sáng sủa
- ✅ Background màu sáng (Gray50)
- ✅ Text màu tối để tăng độ tương phản
- ✅ Card design với shadow và corner radius
- ✅ Tối ưu cho mobile với touch-friendly buttons

### Màu sắc mới
- **Primary:** Blue (#2563EB)
- **Success:** Green (#10B981)
- **Warning:** Orange (#F59E0B)
- **Error:** Red (#EF4444)
- **Gray scale:** Từ Gray50 đến Gray950

## Cấu trúc dự án
```
GadHubMAUI/
├── Services/
│   └── MockDataService.cs     # Mock data service
├── Views/
│   ├── LoginPage.xaml         # Trang đăng nhập
│   ├── DashboardPage.xaml     # Trang tổng quan
│   ├── SanPhamPage.xaml       # Trang sản phẩm
│   └── ...                    # Các trang khác
├── Models/
│   ├── HashHelper.cs          # Helper mã hóa mật khẩu
│   └── ...                    # Các model DTO
└── Resources/
    └── Styles/
        └── Colors.xaml        # Định nghĩa màu sắc
```

## Hướng dẫn chạy ứng dụng

### Yêu cầu hệ thống
- Visual Studio 2022 17.8 trở lên
- .NET 9.0 SDK
- MAUI workload

### Các bước chạy
1. Clone repository
2. Mở solution trong Visual Studio
3. Chọn platform target (Android/iOS/Windows)
4. Build và Run

### Chạy trên Android
1. Kết nối thiết bị Android hoặc sử dụng emulator
2. Chọn "Android" trong dropdown platform
3. Nhấn F5 hoặc "Start Debugging"

## Lưu ý
- Ứng dụng sử dụng mock data nên không cần cấu hình database
- Tất cả dữ liệu sẽ reset khi restart ứng dụng
- Giao diện được tối ưu cho mobile với responsive design
- **Đã loại bỏ hoàn toàn các liên kết database cũ (DatabaseHelper, SQL queries)**

## Tác giả
GadHub Team - 2025
