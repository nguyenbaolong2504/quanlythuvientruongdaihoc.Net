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
    public partial class TacGia : Form
    {
        public TacGia()
        {
            InitializeComponent();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienEautDataSet3.TacGia);
            loadsach();
        }
        TacGiaBLL tacGiaBLL = new TacGiaBLL();
        DataTable table_tacgia = new DataTable();
        private void loadsach()
        {
            table_tacgia = tacGiaBLL.GetTableTacGia();
            dgvTacGia.DataSource = table_tacgia;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tacGiaBLL.AddTacGia(txtMaTG.Text, txtTenTG.Text, txtGioiTinh.Text, txtQueQuan.Text))
            {
                dgvTacGia.DataSource = tacGiaBLL.GetTableTacGia();
                MessageBox.Show("Đã thêm tác giả!");
            }
            else
            {
                MessageBox.Show("Không thêm được tác giả!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tacGiaBLL.UpdateTacGia(txtMaTG.Text, txtTenTG.Text, txtGioiTinh.Text, txtQueQuan.Text))
            {
                dgvTacGia.DataSource = tacGiaBLL.GetTableTacGia();
                MessageBox.Show("Đã cập nhật tác giả!");
            }
            else
            {
                MessageBox.Show("Không cập nhật được tác giả!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tacGiaBLL.DeleteTacGia(txtMaTG.Text))
            {
                dgvTacGia.DataSource = tacGiaBLL.GetTableTacGia();
                MessageBox.Show("Đã xóa tác giả!");
            }
            else
            {
                MessageBox.Show("Không xóa được tác giả!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TacGiaReport tacGiaReport = new TacGiaReport();
            tacGiaReport.Show();
        }
        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTacGia.CurrentRow != null)
            {
                txtMaTG.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
                txtTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvTacGia.CurrentRow.Cells[2].Value.ToString();
                txtQueQuan.Text = dgvTacGia.CurrentRow.Cells[3].Value.ToString();
            }
        }


        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
