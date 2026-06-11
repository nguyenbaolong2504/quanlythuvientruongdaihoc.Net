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
    public partial class SinhVien : Form
    {
        SinhVienBLL sinhvienBLL = new SinhVienBLL();
        public SinhVien()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SinhVienReport sinhVienReport = new SinhVienReport();
            sinhVienReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtHoTenSV.Text.Trim();
            try
            {
                if (bl_sinhvien.AddSinhVien(txtMaSV.Text, txtHoTenSV.Text, txtLop.Text, txtKhoa.Text))
                {
                    dgv_ThemSV.DataSource = bl_sinhvien.GetTableSinhVien();
                    MessageBox.Show("Đã thêm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thêm được sinh viên: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl_sinhvien.UpdateSinhVien(txtMaSV.Text, txtHoTenSV.Text, txtLop.Text, txtKhoa.Text))
                {
                    dgv_ThemSV.DataSource = bl_sinhvien.GetTableSinhVien();
                    MessageBox.Show("Đã sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được sinh viên: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl_sinhvien.DeleteSinhVien(txtMaSV.Text))
                {
                    dgv_ThemSV.DataSource = bl_sinhvien.GetTableSinhVien();
                    MessageBox.Show("Đã xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được sinh viên: " + ex.Message);
            }
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
             this.sinhVienTableAdapter.Fill(this.quanLyThuVienEautDataSet2.SinhVien);
            Loadsinhvien();
        }
        SinhVienBLL bl_sinhvien = new SinhVienBLL();
        DataTable table_sinhvien = new DataTable();

        private void Loadsinhvien()
        {
            table_sinhvien = bl_sinhvien.GetTableSinhVien();
            dgv_ThemSV.DataSource= table_sinhvien; 
        }

        private void dgv_ThemSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ThemSV.CurrentRow != null)
            {
                txtMaSV.Text = dgv_ThemSV.CurrentRow.Cells[0].Value.ToString();
                txtHoTenSV.Text = dgv_ThemSV.CurrentRow.Cells[1].Value.ToString();
                txtLop.Text = dgv_ThemSV.CurrentRow.Cells[2].Value.ToString();
                txtKhoa.Text = dgv_ThemSV.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
