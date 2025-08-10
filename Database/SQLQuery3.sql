--Khách hàng doanh số cao nhất tháng
SELECT TOP 1 kh.MaKH, kh.TenKH, SUM(hd.GiaTien) AS Tong
FROM HoaDon hd
JOIN KhachHang kh ON hd.MaKH = kh.MaKH
WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
GROUP BY kh.MaKH, kh.TenKH
ORDER BY Tong DESC

--Doanh thu tháng hiện tại & tháng trước
-- Tháng hiện tại
SELECT ISNULL(SUM(GiaTien), 0)
FROM HoaDon
WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())

-- Tháng trước
SELECT ISNULL(SUM(GiaTien), 0)
FROM HoaDon
WHERE MONTH(NgayLap) = MONTH(DATEADD(MONTH, -1, GETDATE()))
AND YEAR(NgayLap) = YEAR(DATEADD(MONTH, -1, GETDATE()))

--Nhân viên năng suất nhất tháng
SELECT TOP 1 nv.MaNV, nv.TenNV, COUNT(*) AS SoDon, SUM(hd.GiaTien) AS TongTien
FROM HoaDon hd
JOIN NhanVien nv ON nv.MaNV = hd.MaNV
WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
GROUP BY nv.MaNV, nv.TenNV
ORDER BY SoDon DESC

--Biểu đồ số lượng loại sản phẩm bán ra
SELECT sp.LoaiSP, SUM(cthd.SoLuong) AS SoLuong
FROM ChiTietHoaDon cthd
JOIN SanPham sp ON sp.MaSP = cthd.MaSP
JOIN HoaDon hd ON hd.MaHD = cthd.MaHD
WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
GROUP BY sp.LoaiSP

--Biểu đồ top 5 sản phẩm bán chạy nhất
SELECT TOP 5 sp.TenSP, SUM(cthd.SoLuong) AS SoLuong
FROM ChiTietHoaDon cthd
JOIN SanPham sp ON sp.MaSP = cthd.MaSP
JOIN HoaDon hd ON hd.MaHD = cthd.MaHD
WHERE MONTH(hd.NgayLap) = MONTH(GETDATE()) AND YEAR(hd.NgayLap) = YEAR(GETDATE())
GROUP BY sp.TenSP
ORDER BY SoLuong DESC
