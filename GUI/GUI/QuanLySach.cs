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
using BLL;
using DAL;

namespace GUI
{
    public partial class QuanLySach : Form
    {

        public QuanLySach()
        {
            InitializeComponent();
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienEautDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienEautDataSet.Sach);
            loadSach();
        }
      SachBLL SachBLL = new SachBLL();
        DataTable table_sach = new DataTable();
        private void loadSach()
        {
            table_sach = SachBLL.GetTableSach();
            dgv_ThuVienSach.DataSource = table_sach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = SachBLL.InsertSach(
                    txtMaSach.Text,
                    txtTenSach.Text,
                    txtTacGia.Text,
                    int.Parse(txtNamXB.Text),
                    int.Parse(txtSoLuong.Text)
                );

                if (result)
                {
                    loadSach();
                    MessageBox.Show("Đã thêm sách!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm sách.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = SachBLL.UpdateSach(
                    txtMaSach.Text,
                    txtTenSach.Text,
                    txtTacGia.Text,
                    int.Parse(txtNamXB.Text),
                    int.Parse(txtSoLuong.Text)
                );

                if (result)
                {
                    loadSach();
                    MessageBox.Show("Đã cập nhật sách!");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật sách.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = SachBLL.DeleteSach(txtMaSach.Text);

                if (result)
                {
                    loadSach();
                    MessageBox.Show("Đã xóa sách!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa sách.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
            }
        }


        private void dgv_ThuVienSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_ThuVienSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ThuVienSach.CurrentRow != null)
            {
                txtMaSach.Text = dgv_ThuVienSach.CurrentRow.Cells[0].Value.ToString();
                txtTenSach.Text = dgv_ThuVienSach.CurrentRow.Cells[1].Value.ToString();
                txtTacGia.Text = dgv_ThuVienSach.CurrentRow.Cells[2].Value.ToString();
                txtNamXB.Text = dgv_ThuVienSach.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dgv_ThuVienSach.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoReport baoCaoReport = new BaoCaoReport();
            baoCaoReport.Show();
        }
    }
} 
