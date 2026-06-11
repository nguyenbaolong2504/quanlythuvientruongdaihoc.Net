using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess:DataBaseAccess
    {
        public string Checklogic(TaiKhoan taiKhoan)
        {
            string info = ChecklogicDTO(taiKhoan);
            return info;
        }
    }
}
