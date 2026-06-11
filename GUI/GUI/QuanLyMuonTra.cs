using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class QuanLyMuonTra : Form
    {
        MuonBLL muonBLL = new MuonBLL();
        SachBLL sachBLL = new SachBLL();
        DataTable table_muon = new DataTable();

        public QuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySachReport quanLySachReport = new QuanLySachReport();
            quanLySachReport.Show();
        }

        private void QuanLyMuonTra_Load(object sender, EventArgs e)
        {
            this.phieuTableAdapter.Fill(this.quanLyThuVienEautDataSet1.Phieu);
            loadmuon();
        }

        private void loadmuon()
        {
            table_muon = muonBLL.GetAllMuon();
            dgv_QuanLyMuonTra.DataSource = table_muon;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) ||
                string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaSach.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtSDT.Text, out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            if (!sachBLL.KiemTraSachTonTai(txtMaSach.Text.Trim(), txtTenSach.Text.Trim()))
            {
                MessageBox.Show("Không có sách này trong kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngayMuon = dtNgayMuon.Value.ToString("dd/MM/yyyy");
            string ngayTra = dtNgayTra.Value.ToString("dd/MM/yyyy");

            try
            {
                if (muonBLL.AddMuon(txtMaPhieu.Text, txtMaSV.Text, txtMaSach.Text,
                                    txtTenSV.Text, txtTenSach.Text, ngayMuon,
                                    ngayTra, txtSDT.Text, txtTrangThai.Text))
                {
                    dgv_QuanLyMuonTra.DataSource = muonBLL.GetAllMuon();
                    MessageBox.Show("Đã thêm phiếu mượn!");
                }
                else
                {
                    MessageBox.Show("Không thêm được phiếu mượn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) ||
                string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaSach.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtSDT.Text, out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            string ngayMuon = dtNgayMuon.Value.ToString("dd/MM/yyyy");
            string ngayTra = dtNgayTra.Value.ToString("dd/MM/yyyy");

            try
            {
                if (muonBLL.UpdateMuon(txtMaPhieu.Text, txtMaSV.Text, txtMaSach.Text,
                                       txtTenSV.Text, txtTenSach.Text, ngayMuon,
                                       ngayTra, txtSDT.Text, txtTrangThai.Text))
                {
                    dgv_QuanLyMuonTra.DataSource = muonBLL.GetAllMuon();
                    MessageBox.Show("Đã cập nhật phiếu mượn!");
                }
                else
                {
                    MessageBox.Show("Không cập nhật được phiếu mượn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (muonBLL.DeleteMuon(txtMaPhieu.Text))
            {
                dgv_QuanLyMuonTra.DataSource = muonBLL.GetAllMuon();
                MessageBox.Show("Đã xóa phiếu mượn!");
            }
            else
            {
                MessageBox.Show("Không xóa được phiếu mượn!");
            }
        }

        private void dgv_QuanLyMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QuanLyMuonTra.CurrentRow != null)
            {
                txtMaPhieu.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[0].Value.ToString();
                txtMaSV.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[1].Value.ToString();
                txtMaSach.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[2].Value.ToString();
                txtTenSV.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[3].Value.ToString();
                txtTenSach.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[4].Value.ToString();
                dtNgayMuon.Value = Convert.ToDateTime(dgv_QuanLyMuonTra.CurrentRow.Cells[5].Value);
                dtNgayTra.Value = Convert.ToDateTime(dgv_QuanLyMuonTra.CurrentRow.Cells[6].Value);
                txtSDT.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[7].Value.ToString();
                txtTrangThai.Text = dgv_QuanLyMuonTra.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void export2Excel(DataGridView g, string DuongDan, string tenTap)
        {
            // Export to Excel code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            export2Excel(dgv_QuanLyMuonTra, @"D:\", "quanlymuontra");
        }

        private void dgv_QuanLyMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTrangThai.Checked)
            {
                if (dgv_QuanLyMuonTra.CurrentRow != null)
                {
                    string maPhieu = dgv_QuanLyMuonTra.CurrentRow.Cells[0].Value.ToString();
                    string maSach = dgv_QuanLyMuonTra.CurrentRow.Cells[2].Value.ToString();

                    bool updated = muonBLL.UpdateTrangThaiPhieu(maPhieu, "Đã Mượn");
                    bool giamSoLuong = sachBLL.GiamSoLuongSach(maSach, -1);

                    if (updated && giamSoLuong)
                    {
                        MessageBox.Show(" Đã cập nhật trạng thái và giảm số lượng sách.");
                        loadmuon();
                    }
                    else
                    {
                        MessageBox.Show(" Cập nhật thất bại. Kiểm tra lại mã phiếu hoặc mã sách.");
                    }
                }
                else
                {
                    MessageBox.Show(" Vui lòng chọn một dòng trong danh sách.");
                }
            }
        }
    }
}

