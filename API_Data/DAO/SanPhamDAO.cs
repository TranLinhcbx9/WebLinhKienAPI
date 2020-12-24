using API_Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Data.DAO
{
    public class SanPhamDAO
    {
        private SanPhamDAO() { }

        private static volatile SanPhamDAO instance;

        static object key = new object();

        public static SanPhamDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new SanPhamDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<SanPham> GetList()
        {
            List<SanPham> list = new List<SanPham>();

            //string query = $"SELECT s.MaSV, s.TenSV, l.TenLop, TenMon, Diem FROM SinhVien s , Lop l, MonHoc m, Diem d WHERE s.MaLop = l.MaLop AND s.MaSV = d.MaSV AND m.MaMon = d.MaMon";
            //DataProvider.Instance.ExecuteNonQuery(query);
            //return list;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM SanPham");
            foreach (DataRow item in data.Rows)
            {
                SanPham obj = new SanPham(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string masp, string tensp, int soluong, string dongia, string mota, string giakm, string maloaisp)
        {
            string query = $"INSERT INTO SanPham(MaSP, TenSP, SoLuong, DonGia, MoTa, GiaKm, MaLoaiSP) VALUES  ( N'{masp}', N'{tensp}', N'{soluong}',  N'{dongia}',  N'{mota}', N'{giakm}', N'{maloaisp}' )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        public int Update(string masp, string tensp, int soluong, string dongia, string mota, string giakm, string maloaisp)
        {
            string query = $"UPDATE SanPham SET TenSP = N'{tensp}', SoLuong = N'{soluong}', DonGia = N'{dongia}', MoTa =  N'{mota}', GiaKm = N'{giakm}', MaLoaiSP = N'{maloaisp}' WHERE MaSP = N'{masp}' ";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }



    }
}
