using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class KhachHangUC : UserControl
    {
        public KhachHangUC()
        {
            InitializeComponent();
            LoadTopKhachHang();
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {

        }
        private void LoadTopKhachHang()
        {
            string sql = @"
        SELECT 
            kh.TenKH,
            COUNT(hd.MaHD) AS SoLanMua,
            SUM(hd.GiaTien) AS TongChiTieu
        FROM KhachHang kh
        JOIN HoaDon hd ON kh.MaKH = hd.MaKH
        GROUP BY kh.TenKH
        ORDER BY TongChiTieu DESC";

            DataTable dt = DatabaseHelper.GetData(sql);
            gridControl1.DataSource = dt;

            // Format tiền
            gridView1.Columns["TongChiTieu"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TongChiTieu"].DisplayFormat.FormatString = "n0";
        }

    }
}
