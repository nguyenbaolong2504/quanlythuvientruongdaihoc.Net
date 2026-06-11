using System;
using System.Data;
using System.Globalization;
using DAL;

namespace BLL
{
    public class MuonBLL
    {
        DALMuon dal_muon = new DALMuon();

        public DataTable GetAllMuon()
        {
            return dal_muon.LoadDanhSachMuon();
        }

        public bool AddMuon(string MaPhieu, string MaSV, string MaSach,
                            string TenSV, string TenSach, string NgayMuon,
                            string NgayTra, string SDT, string TrangThai)
        {
            if (!DateTime.TryParseExact(NgayMuon, "dd/MM/yyyy", null,
                DateTimeStyles.None, out DateTime ngayMuon) ||
                !DateTime.TryParseExact(NgayTra, "dd/MM/yyyy", null,
                DateTimeStyles.None, out DateTime ngayTra) ||
                !int.TryParse(SDT, out int sdt))
            {
                return false;
            }

            return dal_muon.InsertMuon(MaPhieu, MaSV, MaSach, TenSV, TenSach,
                                      ngayMuon, ngayTra, sdt, TrangThai) > 0;
        }

        public bool UpdateMuon(string MaPhieu, string MaSV, string MaSach,
                               string TenSV, string TenSach, string NgayMuon,
                               string NgayTra, string SDT, string TrangThai)
        {
            if (!DateTime.TryParseExact(NgayMuon, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayMuon) ||
                !DateTime.TryParseExact(NgayTra, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayTra) ||
                !int.TryParse(SDT, out int sdt))
            {
                return false;
            }

            return dal_muon.UpdateMuon(MaPhieu, MaSV, MaSach, TenSV, TenSach, ngayMuon, ngayTra, sdt, TrangThai) > 0;
        }

        public bool DeleteMuon(string maPhieu)
        {
            return  dal_muon.DeleteMuon(maPhieu) >0;
        }

        public bool UpdateTrangThaiPhieu(string maPhieu, string trangThai)
        {
            return dal_muon.UpdateTrangThai(maPhieu, trangThai) > 0;
        }
    }
}
