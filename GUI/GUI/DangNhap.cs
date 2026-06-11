using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Dang_Nhap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();

        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtMatKhau.Text;
            string getuser = TKBLL.Checklogic(taiKhoan);


            switch (getuser) {
                case "Reqiued_TaiKHoan":
                    MessageBox.Show("Tai Khoan Khong duoc  de trong!");
                    return;
                case "Reqiued_MatKhau":
                    MessageBox.Show("Mat Khau Khong duoc  de trong!");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Dang Nhap Thanh Cong Vao He Thong");
            var TrangChu = new TrangChu();
            TrangChu.Show();
            this.Hide();
        }

        private void Dang_Nhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
