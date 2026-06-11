using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SachBLL 
        
    {
        DALSach dal_sach = new DALSach();
        public DataTable GetTableSach()
        {
            return dal_sach.LoadDanhSachSach();
        }
        public bool InsertSach(string MaSach, string TenSach,string TacGia,int NamXB,int SoLuong)
        {
            return dal_sach.InsertSach(MaSach,TenSach,TacGia,NamXB,SoLuong)>0 ;
        }
        public bool UpdateSach(string MaSach, string TenSach, string TacGia, int NamXB, int SoLuong) {
            return dal_sach.UpdateSach(MaSach, TenSach, TacGia, NamXB, SoLuong) > 0;
        }
        public bool DeleteSach(string MaSach) { 
        return dal_sach.DeleteSach(MaSach)>0;
        }
        public bool GiamSoLuongSach(string maSach,int v)
        {
            if (dal_sach.KiemTraSachTonKho(maSach))
            {
                return dal_sach.CapNhatSoLuongSach(maSach, -1) > 0;
            }
            return false;
        }

        public bool TangSoLuongSach(string maSach,int v)
        {
            return dal_sach.CapNhatSoLuongSach(maSach, 1) > 0;
        }
        public bool KiemTraSachTonTai(string maSach, string tenSach)
        {
            return dal_sach.KiemTraSachTonTai(maSach, tenSach);
        }


    }
}
