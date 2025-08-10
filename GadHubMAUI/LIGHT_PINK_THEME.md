# 🎨 Light Pink Theme - GadHub MAUI

## 🌸 **Tổng quan thay đổi**

Đã cập nhật toàn bộ giao diện ứng dụng GadHub MAUI sang **Light Pink Theme** với màu chủ đạo `#FFC0CB`.

## 🎨 **Bảng màu mới**

### **Màu chính:**
- **Primary:** `#FFC0CB` (Light Pink)
- **Secondary:** `#FFB6C1` (Light Pink)
- **Tertiary:** `#FF69B4` (Hot Pink)
- **LightPink:** `#FFC0CB` (Light Pink)
- **PinkAccent:** `#FFB6C1` (Light Pink)
- **SoftPink:** `#FFF0F5` (Lavender Blush)

### **Màu xám (đã điều chỉnh sang tông hồng):**
- **Gray50:** `#FFF0F5` (Lavender Blush)
- **Gray100:** `#FFE4E1` (Misty Rose)
- **Gray200:** `#FFDAB9` (Peach Puff)
- **Gray300:** `#FFC0CB` (Light Pink)
- **Gray400:** `#FFB6C1` (Light Pink)
- **Gray500:** `#FFA07A` (Light Salmon)
- **Gray600:** `#FF8C69` (Salmon)
- **Gray700:** `#FF7F50` (Coral)
- **Gray800:** `#FF6347` (Tomato)
- **Gray900:** `#FF4500` (Orange Red)

### **Màu chức năng:**
- **Success:** `#98FB98` (Pale Green)
- **Warning:** `#FFD700` (Gold)
- **Error:** `#FF6B6B` (Light Coral)
- **Info:** `#87CEEB` (Sky Blue)
- **Magenta:** `#FF69B4` (Hot Pink)

## 🖼️ **Các thành phần đã cập nhật**

### **1. Background chính:**
- **Page:** `{StaticResource LightPink}` (#FFC0CB)
- **Shell:** `{StaticResource LightPink}` (#FFC0CB)
- **NavigationPage:** `{StaticResource LightPink}` (#FFC0CB)

### **2. Background phụ:**
- **TabBar:** `{StaticResource SoftPink}` (#FFF0F5)
- **Flyout:** `{StaticResource SoftPink}` (#FFF0F5)
- **Border:** `{StaticResource SoftPink}` (#FFF0F5)

### **3. Viền và đường kẻ:**
- **Border Stroke:** `{StaticResource PinkAccent}` (#FFB6C1)
- **ListView Separator:** `{StaticResource PinkAccent}` (#FFB6C1)

### **4. Input fields:**
- **Entry Background:** `{StaticResource SoftPink}` (#FFF0F5)
- **SearchBar Background:** `{StaticResource SoftPink}` (#FFF0F5)

### **5. Button:**
- **Background:** `{StaticResource Primary}` (#FFC0CB)
- **Text Color:** `{StaticResource Black}` (#2C2C2C)

## 📱 **Trang đã cập nhật**

### **LoginPage:**
- Background: `#FFC0CB` (Light Pink)
- Đã chuyển đổi Frame → Border
- Đã xóa phần hiển thị tài khoản demo
- Tên admin: "Xuân Trường"
- Tên nhân viên: "Đan Huy"

### **Tất cả các trang khác:**
- Background tự động áp dụng từ global style
- Border và UI elements sử dụng màu light pink

## 🔧 **Cách sử dụng**

### **Trong XAML:**
```xml
<!-- Sử dụng màu có sẵn -->
<Label Text="Tiêu đề" TextColor="{StaticResource Primary}" />
<Border BackgroundColor="{StaticResource SoftPink}" />

<!-- Tùy chỉnh màu -->
<Label Text="Văn bản" TextColor="#FFC0CB" />
```

### **Trong C#:**
```csharp
// Sử dụng màu từ Resources
label.TextColor = (Color)Application.Current.Resources["Primary"];

// Hoặc sử dụng trực tiếp
label.TextColor = Color.FromHex("#FFC0CB");
```

## ✨ **Lợi ích của theme mới**

1. **Giao diện nhất quán:** Tất cả trang đều sử dụng cùng bảng màu
2. **Thân thiện người dùng:** Màu light pink tạo cảm giác dễ chịu, ấm áp
3. **Dễ bảo trì:** Tập trung tất cả màu sắc trong một file Styles.xaml
4. **Tương thích:** Hoạt động tốt trên tất cả platform (iOS, Android, Windows, macOS)

## 🎯 **Kết quả cuối cùng**

Bây giờ toàn bộ ứng dụng GadHub MAUI sẽ có:
- **Background chính:** Light Pink (#FFC0CB)
- **Background phụ:** Soft Pink (#FFF0F5)
- **Viền và accent:** Pink Accent (#FFB6C1)
- **Text:** Dark Gray (#2C2C2C) để dễ đọc
- **Giao diện nhất quán** trên tất cả các trang

Theme mới sẽ tạo ra một trải nghiệm người dùng thân thiện, hiện đại và dễ chịu! 🎉
