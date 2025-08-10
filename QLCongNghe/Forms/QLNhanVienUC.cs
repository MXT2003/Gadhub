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
    public partial class QLNhanVienUC : UserControl
    {
        public QLNhanVienUC()
        {
            InitializeComponent();
            LoadNhanVien();
        }
        private void LoadNhanVien(string keyword = "")
        {
            flowLayoutPanelNhanVien.Controls.Clear();
            string sql = $"SELECT * FROM NhanVien WHERE TenNV LIKE N'%{keyword}%' OR MaNV LIKE '%{keyword}%'";
            DataTable dt = DatabaseHelper.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                var card = new Card(row);
                flowLayoutPanelNhanVien.Controls.Add(card);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadNhanVien(txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien form = new FormThemNhanVien();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVien();
            }
        }
    }
}
