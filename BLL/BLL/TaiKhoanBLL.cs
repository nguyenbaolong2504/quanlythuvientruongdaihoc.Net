using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess taikkhoandatabase = new TaiKhoanAccess();
        public string Checklogic(TaiKhoan taiKhoan)
        {
            if (taiKhoan.sTaiKhoan == "") {
                return "Reqiued_TaiKHoan";
                    }
            else if(taiKhoan.sMatKhau == "")
            {
                return "Reqiued_MatKhau ";
            }
            string info  =taikkhoandatabase.Checklogic(taiKhoan);
            return info;
        }
    }
}
