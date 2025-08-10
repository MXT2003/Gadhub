using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongNghe.DTO
{
    public class Session
    {
        public static string MaNhanVien { get; set; }

        public static string TenNhanVien { get; set; }
        public static string VaiTro { get; set; } // "Admin" hoặc "NV"
        

        // Bổ sung các thông tin cá nhân
        public static byte[] HinhAnh { get; set; }
        public static DateTime NgaySinh { get; set; }
        public static string GioiTinh { get; set; }
        public static string SDT { get; set; }
        public static string DiaChi { get; set; }
        public static string Email { get; set; }
    }
}
