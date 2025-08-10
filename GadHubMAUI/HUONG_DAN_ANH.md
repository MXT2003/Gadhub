# Hướng dẫn thêm ảnh vào dự án GadHub MAUI

## 📁 Vị trí thêm ảnh

### 1. **Thư mục chính cho ảnh:**
```
GadHubMAUI/
├── Resources/
│   ├── Images/           ← Thêm ảnh vào đây
│   │   ├── logo.png
│   │   ├── avatar.png
│   │   ├── product1.jpg
│   │   └── ...
│   ├── Styles/
│   └── Fonts/
```

### 2. **Cách thêm ảnh:**
1. Copy file ảnh vào thư mục `Resources/Images/`
2. Trong Visual Studio, chuột phải vào thư mục `Images`
3. Chọn "Add" → "Existing Item"
4. Chọn file ảnh cần thêm
5. Đảm bảo thuộc tính "Build Action" = "MauiImage"

### 3. **Sử dụng ảnh trong XAML:**
```xml
<!-- Cách 1: Sử dụng trực tiếp -->
<Image Source="logo.png" />

<!-- Cách 2: Sử dụng với kích thước -->
<Image Source="avatar.png" 
       HeightRequest="100" 
       WidthRequest="100" />

<!-- Cách 3: Sử dụng với thuộc tính khác -->
<Image Source="product1.jpg"
       Aspect="AspectFill"
       HorizontalOptions="Center" />
```

### 4. **Sử dụng ảnh trong C#:**
```csharp
// Trong code-behind
imageControl.Source = "logo.png";

// Hoặc sử dụng ImageSource
imageControl.Source = ImageSource.FromFile("avatar.png");
```

## 🎨 Các loại ảnh được hỗ trợ

- **PNG** (khuyến nghị cho logo, icon)
- **JPG/JPEG** (khuyến nghị cho ảnh sản phẩm)
- **GIF** (cho animation)
- **SVG** (cho vector graphics)

## 📱 Kích thước ảnh khuyến nghị

- **Logo:** 200x200px hoặc 400x400px
- **Avatar:** 100x100px hoặc 200x200px
- **Ảnh sản phẩm:** 300x300px hoặc 600x600px
- **Ảnh banner:** 1200x400px

## ⚠️ Lưu ý quan trọng

1. **Tên file:** Không sử dụng dấu cách, ký tự đặc biệt
2. **Đường dẫn:** Luôn sử dụng đường dẫn tương đối từ thư mục Images
3. **Build Action:** Phải đặt là "MauiImage" để ảnh được đóng gói vào app
4. **Kích thước:** Nên tối ưu hóa ảnh để giảm dung lượng app

## 🔧 Xử lý lỗi thường gặp

### Lỗi "Image not found":
- Kiểm tra tên file có đúng không
- Kiểm tra đường dẫn trong XAML
- Đảm bảo Build Action = "MauiImage"

### Ảnh không hiển thị:
- Kiểm tra kích thước ảnh
- Kiểm tra thuộc tính Aspect
- Kiểm tra thuộc tính IsVisible

## 📝 Ví dụ thực tế

Trong dự án này, bạn có thể thêm:
- `admin_avatar.png` - Ảnh đại diện cho admin Xuân Trường
- `employee_avatar.png` - Ảnh đại diện cho nhân viên Đan Huy
- `product_placeholder.jpg` - Ảnh mặc định cho sản phẩm
- `store_banner.jpg` - Ảnh banner cho cửa hàng
