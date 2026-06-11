using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            string sql = "SELECT * FROM Sach WHERE " +
                         "MaSach LIKE N'%" + keyword + "%' OR " +
                         "TenSach LIKE N'%" + keyword + "%'";

            dgv_QuanLyMuonTra.DataSource = DataAcess.GetTable(sql);
        }

        private void dgv_QuanLyMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_QuanLyMuonTra.RowTemplate.Height = 45;
            dgv_QuanLyMuonTra.DataSource = DataAcess.GetTable("SELECT * FROM Sach");
            dgv_QuanLyMuonTra.Columns[0].HeaderText = "Ma Sach";
            dgv_QuanLyMuonTra.Columns[1].HeaderText = "Ten Sach";
            dgv_QuanLyMuonTra.Columns[2].HeaderText = "TacGia";
            dgv_QuanLyMuonTra.Columns[3].HeaderText = "NamXB";
            dgv_QuanLyMuonTra.Columns[4].HeaderText = "SoLuong";

            dgv_QuanLyMuonTra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_QuanLyMuonTra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_QuanLyMuonTra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_QuanLyMuonTra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_QuanLyMuonTra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienEautDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienEautDataSet.Sach);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
