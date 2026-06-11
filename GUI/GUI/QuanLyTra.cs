using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class QuanLyTra : Form
    {
        MuonBLL muonBLL = new MuonBLL();
        SachBLL sachBLL = new SachBLL();
        DataTable table_muon = new DataTable();
        public QuanLyTra()
        {
            InitializeComponent();
        }

        private void QuanLyTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienEautDataSet1.Phieu' table. You can move, or remove it, as needed.
            this.phieuTableAdapter.Fill(this.quanLyThuVienEautDataSet1.Phieu);
            dgv_TraSach.RowTemplate.Height = 45;
            dgv_TraSach.DataSource = DataAcess.GetTable("SELECT * FROM Phieu");

            dgv_TraSach.Columns[0].HeaderText = "Ma Phieu";
            dgv_TraSach.Columns[1].HeaderText = "Ma Sinh Vien";
            dgv_TraSach.Columns[2].HeaderText = "Ma Sach";
            dgv_TraSach.Columns[3].HeaderText = "Ten Sinh Vien";
            dgv_TraSach.Columns[4].HeaderText = "Ten Sach";
            dgv_TraSach.Columns[5].HeaderText = "Ngay Muon";
            dgv_TraSach.Columns[6].HeaderText = "Ngay Tra";
            dgv_TraSach.Columns[7].HeaderText = "So Dien Thoai";
            dgv_TraSach.Columns[8].HeaderText = "Trang Thai"; 

            for (int i = 0; i < 8; i++)
                dgv_TraSach.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_TraSach.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Phieu WHERE MaPhieu = N'" + txtPhieu.Text + "'";
            DataAcess.themsuaxoa(sql);
            dgv_TraSach.DataSource = DataAcess.GetTable("SELECT * FROM Phieu");
            MessageBox.Show("Đã xóa!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string keyword = txtPhieu.Text.Trim();
            string sql = "SELECT * FROM Phieu WHERE MaPhieu LIKE N'%" + keyword + "%'";
            dgv_TraSach.DataSource = DataAcess.GetTable(sql);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && dgv_TraSach.CurrentRow != null)
            {
                try
                {
                    string maPhieu = dgv_TraSach.CurrentRow.Cells[0].Value.ToString();
                    string maSach = dgv_TraSach.CurrentRow.Cells[2].Value.ToString();

                    bool updated = muonBLL.UpdateTrangThaiPhieu(maPhieu, "Đã trả");
                    bool tangSoLuong = sachBLL.TangSoLuongSach(maSach,1);

                    if (updated && tangSoLuong)
                    {
                        MessageBox.Show(" Cập nhật trạng thái và số lượng sách thành công!");
                        dgv_TraSach.DataSource = DataAcess.GetTable("SELECT * FROM Phieu");
                    }
                    else
                    {
                        MessageBox.Show(" Cập nhật thất bại. Kiểm tra dữ liệu đầu vào.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(" Vui lòng chọn một dòng!");
            }
        }

        private void dgv_TraSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

