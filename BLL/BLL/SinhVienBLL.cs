using System.Data;
using DAL;

namespace BLL
{
    public class SinhVienBLL
    {
        DALSinhVien dal_sinhvien = new DALSinhVien();

        public DataTable GetTableSinhVien()
        {
            return dal_sinhvien.LoadDanhSachSinhVien();
        }

        public bool AddSinhVien(string maSV, string hoTen, string lop, string khoa)
        {
            return dal_sinhvien.InsertSinhVien(maSV, hoTen, lop, khoa) > 0;
        }

        public bool UpdateSinhVien(string maSV, string hoTen, string lop, string khoa)
        {
            return dal_sinhvien.UpdateSinhVien(maSV, hoTen, lop, khoa)>0 ;
        }

        public bool DeleteSinhVien(string maSV)
        {
            return dal_sinhvien.DeleteSinhVien(maSV)>0;
        }
    }
}
