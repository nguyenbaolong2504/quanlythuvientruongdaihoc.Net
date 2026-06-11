using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrangChu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void muonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra quanlymuon = new QuanLyMuonTra();
            quanlymuon.MdiParent = this;
            quanlymuon.Show();
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanlysach = new QuanLySach();
            quanlysach.MdiParent = this;
            quanlysach.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void sinhVienTrongTruongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MdiParent = this;
            sinhVien.Show();
        }

        private void timKiemSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemSach timkiemsach = new TimKiemSach();
            timkiemsach.MdiParent = this;
            timkiemsach.Show();
        }

        private void thongTinTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia tacgia = new TacGia();
             tacgia.MdiParent = this;
            tacgia.Show();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
