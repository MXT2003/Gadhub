using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadHubMAUI.Models
{
    public class ChiTietHoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TenSP { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}