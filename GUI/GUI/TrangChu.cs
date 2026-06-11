using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{

    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void timKiemSachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiemSach timKiemSach = new TimKiemSach();
            timKiemSach.Show();
        }

        private void phieuMuonTraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLySacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanLySach = new QuanLySach();
            quanLySach.Show();
           
        }

        private void quanLyMuonTraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyMuonTra quanLyMuonTra = new QuanLyMuonTra();
            quanLyMuonTra.Show();
           
        }

        private void quanLySinhVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Show();
        }

        private void tacGiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void muonTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTra quanlytra = new QuanLyTra();
            quanlytra.Show();
        }

        private void muonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileMuon fileMuon = new FileMuon();
            fileMuon.Show();
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatFileTra fileTra = new XuatFileTra();
            fileTra.Show();
        }
    }
}
