using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Data.DTO
{
    public class SanPham
    {
        public string masp { get; set; }

        public string tensp { get; set; }

        public int soluong { get; set; }
        public string  dongia { get; set; }
        public string mota { get; set; }
        public string giakm { get; set; }
        //public string urlanh { get; set; }
        public string maloaisp { get; set; }

        public SanPham()
        {

        }

        public SanPham(string masp, string tensp, int soluong, string dongia, string mota, string giakm, string maloaisp)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.soluong = soluong;
            this.dongia = dongia;
            this.mota = mota;
            this.giakm = giakm;
            //this.urlanh = urlanh;
            this.maloaisp = maloaisp;
        }

        public SanPham(DataRow row)
        {
            this.masp = row["MaSP"].ToString();
            this.tensp = row["TenSP"].ToString();
            this.soluong = int.Parse(row["SoLuong"].ToString());
            //this.dongia = int.Parse(row["DonGia"].ToString());
            this.dongia = row["DonGia"].ToString();
            this.mota = row["MoTa"].ToString();
            //this.giakm = int.Parse(row["GiaKM"].ToString());
            this.giakm = row["GiaKM"].ToString();
            //this.urlanh = row["URLAnh"].ToString();
            this.maloaisp = row["MaLoaiSP"].ToString();
        }
    }
}
