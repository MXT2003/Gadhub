using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadHubMAUI.Models
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string MaLoai { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
    }
}