using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class ThemSanPhamPage : ContentPage
    {
        private string tenFileAnh = "dotnet_bot.png";
        private bool isEditMode = false;
        private string maSP = "";

        // Mock data cho danh mục và loại sản phẩm
        private readonly List<string> danhMucList = new List<string>
        {
            "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện", "Đồng hồ thông minh"
        };

        private readonly Dictionary<string, List<string>> loaiSanPham = new Dictionary<string, List<string>>
        {
            { "Điện thoại", new List<string> { "iPhone", "Samsung", "Xiaomi", "OPPO" } },
            { "Laptop", new List<string> { "MacBook", "Dell", "HP", "Lenovo" } },
            { "Máy tính bảng", new List<string> { "iPad", "Samsung Tablet", "Xiaomi Tablet" } },
            { "Phụ kiện", new List<string> { "Tai nghe", "Sạc dự phòng", "Ốp lưng" } },
            { "Đồng hồ thông minh", new List<string> { "Apple Watch", "Samsung Galaxy Watch", "Xiaomi Mi Band" } }
        };

        // Constructor cho thêm mới sản phẩm
        public ThemSanPhamPage()
        {
            InitializeComponent();
            isEditMode = false;
        }

        // Constructor cho cập nhật sản phẩm
        public ThemSanPhamPage(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
            isEditMode = true;
            Title = "Cập nhật sản phẩm";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadDanhMuc();

            if (isEditMode)
            {
                await LoadDuLieuSanPham();
            }
        }

        private async Task LoadDanhMuc()
        {
            try
            {
                pickerDanhMuc.ItemsSource = danhMucList;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải danh mục: {ex.Message}", "OK");
            }
        }

        private async void pickerDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerDanhMuc.SelectedItem == null)
                return;

            string danhMuc = pickerDanhMuc.SelectedItem.ToString();
            await LoadLoaiSanPhamTheoDanhMuc(danhMuc);
        }

        private async Task LoadLoaiSanPhamTheoDanhMuc(string danhMuc)
        {
            try
            {
                if (loaiSanPham.ContainsKey(danhMuc))
                {
                    var loaiList = loaiSanPham[danhMuc];
                    pickerLoaiSP.ItemsSource = loaiList;
                    pickerLoaiSP.IsEnabled = loaiList.Count > 0;
                }
                else
                {
                    pickerLoaiSP.ItemsSource = new List<string>();
                    pickerLoaiSP.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải loại sản phẩm: {ex.Message}", "OK");
            }
        }

        private async Task LoadDuLieuSanPham()
        {
            try
            {
                // Mock data cho sản phẩm cần cập nhật
                var mockSanPham = new
                {
                    TenSP = "iPhone 15 Pro Max",
                    DonGia = 35000000,
                    SoLuongTon = 10,
                    MoTa = "iPhone 15 Pro Max với chip A17 Pro mạnh mẽ",
                    HinhAnh = "iphone15.jpg",
                    TenDanhMuc = "Điện thoại",
                    TenLoai = "iPhone"
                };

                entryTenSP.Text = mockSanPham.TenSP;
                entryGiaBan.Text = mockSanPham.DonGia.ToString();
                entrySoLuong.Text = mockSanPham.SoLuongTon.ToString();
                editorMoTa.Text = mockSanPham.MoTa;
                tenFileAnh = mockSanPham.HinhAnh;

                // Hiển thị hình ảnh
                if (!string.IsNullOrEmpty(tenFileAnh))
                {
                    imgSanPham.Source = tenFileAnh;
                }

                // Load danh mục & loại sản phẩm
                pickerDanhMuc.SelectedItem = mockSanPham.TenDanhMuc;
                await LoadLoaiSanPhamTheoDanhMuc(mockSanPham.TenDanhMuc);
                pickerLoaiSP.SelectedItem = mockSanPham.TenLoai;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải thông tin sản phẩm: {ex.Message}", "OK");
            }
        }

        private async void btnChonAnh_Clicked(object sender, EventArgs e)
        {
            // Chức năng chọn ảnh sẽ được phát triển sau
            await DisplayAlert("Thông báo", "Chức năng chọn ảnh đang được phát triển", "OK");
        }

        private async void btnLuu_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrWhiteSpace(entryTenSP.Text))
                {
                    await DisplayAlert("Lỗi", "Vui lòng nhập tên sản phẩm", "OK");
                    return;
                }

                if (pickerDanhMuc.SelectedItem == null || pickerLoaiSP.SelectedItem == null)
                {
                    await DisplayAlert("Lỗi", "Vui lòng chọn danh mục và loại sản phẩm", "OK");
                    return;
                }

                if (string.IsNullOrWhiteSpace(entryGiaBan.Text) || !decimal.TryParse(entryGiaBan.Text, out decimal giaBan))
                {
                    await DisplayAlert("Lỗi", "Vui lòng nhập giá bán hợp lệ", "OK");
                    return;
                }

                if (string.IsNullOrWhiteSpace(entrySoLuong.Text) || !int.TryParse(entrySoLuong.Text, out int soLuong))
                {
                    await DisplayAlert("Lỗi", "Vui lòng nhập số lượng hợp lệ", "OK");
                    return;
                }

                string tenLoai = pickerLoaiSP.SelectedItem.ToString();
                string moTa = editorMoTa.Text ?? "";

                if (isEditMode)
                {
                    // Cập nhật sản phẩm
                    await DisplayAlert("Thông báo", "Cập nhật sản phẩm thành công! (Mock data)", "OK");
                }
                else
                {
                    // Thêm mới sản phẩm
                    await DisplayAlert("Thông báo", "Thêm sản phẩm thành công! (Mock data)", "OK");
                }

                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể lưu sản phẩm: {ex.Message}", "OK");
            }
        }

        private async void btnHuy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private string GenerateMaSP()
        {
            string rand = Path.GetRandomFileName().Replace(".", "").Substring(0, 3).ToUpper();
            return $"SP{DateTime.Now:ddMyy}{rand}";
        }
    }
}