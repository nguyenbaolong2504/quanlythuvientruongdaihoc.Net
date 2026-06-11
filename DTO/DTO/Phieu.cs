using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieu
    {
        public string MaPhieu { get; set; }
        public string MaSV { get; set; }
        public string MaSach { get; set; }
        public string TenSV { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public int Sdt { get; set; }

        public string TrangThai { get; set; }
    }
}
