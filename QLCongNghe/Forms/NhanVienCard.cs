using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongNghe.Forms
{
    public partial class Card : UserControl
    {
        private string maNV;
        public Card(DataRow row)
        {
            InitializeComponent();
            maNV = row["MaNV"].ToString();
            lblTen.Text = row["TenNV"].ToString();
            lblSDT.Text = "SDT: " + row["SDT"].ToString();
            lblDiaChi.Text = "ĐC: " + row["DiaChi"].ToString();

            // ✅ Load ảnh nếu có
            if (row.Table.Columns.Contains("HinhAnh") && row["HinhAnh"] != DBNull.Value)
            {
                byte[] imageData = row["HinhAnh"] as byte[];
                using (var ms = new MemoryStream(imageData))
                {
                    picAnh.Image = Image.FromStream(ms);  // ⚠️ picAnh là PictureBox bạn cần đặt đúng tên
                }
            }
            else
            {
                picAnh.Image = null; // hoặc ảnh mặc định
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            FormThongTinNV form = new FormThongTinNV(maNV); // Truyền mã NV để xem chi tiết
            form.ShowDialog();
        }
    }
}
