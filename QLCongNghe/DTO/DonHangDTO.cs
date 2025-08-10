using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongNghe.DTO
{
    public class DonHangDTO
    {
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal GiaTien { get; set; }
    }
}
