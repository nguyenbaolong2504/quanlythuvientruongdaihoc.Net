using DAL;
using System.Data;

namespace BLL
{
    public class TacGiaBLL
    {

        DALTacGia dal_tacgia = new DALTacGia();
        public DataTable GetTableTacGia()
        {
            return dal_tacgia.LoadDanhSachTacGia();
        }

        public bool AddTacGia(string maTacGia, string tenTacGia, string gioiTinh, string queQuan)
        {
            return dal_tacgia.InsertTacGia(maTacGia, tenTacGia, gioiTinh, queQuan) > 0;
        }

        public bool UpdateTacGia(string maTacGia, string tenTacGia, string gioiTinh, string queQuan)
        {
            return dal_tacgia.UpdateTacGia(maTacGia, tenTacGia, gioiTinh, queQuan)>0;
        }

        public bool DeleteTacGia(string maTacGia)
        {
            return dal_tacgia.DeleteTacGia(maTacGia)>0; 
        }
    }
}

