using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Data.DTO
{
    public class LoaiSP
    {
        public string maloaisp { get; set; }
        public string tenloai { get; set; }

        public LoaiSP()
        {

        }

        public LoaiSP(string maloaisp, string tenloai)
        {
            this.maloaisp = maloaisp;
            this.tenloai = tenloai;
        }

        public LoaiSP(DataRow row)
        {
            this.maloaisp = row["MaLoaiSP"].ToString();
            this.tenloai = row["TenLoai"].ToString();
        }
    }
}
