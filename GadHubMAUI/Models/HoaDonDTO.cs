using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadHubMAUI.Models
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal GiaTien { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
    }
}