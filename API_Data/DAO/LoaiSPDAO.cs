using API_Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Data.DAO
{
    public class LoaiSPDAO
    {
        private LoaiSPDAO() { }

        private static volatile LoaiSPDAO instance;

        static object key = new object();

        public static LoaiSPDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new LoaiSPDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<LoaiSP> GetList()
        {
            List<LoaiSP> list = new List<LoaiSP>();

            //string query = $"SELECT s.MaSV, s.TenSV, l.TenLop, TenMon, Diem FROM SinhVien s , Lop l, MonHoc m, Diem d WHERE s.MaLop = l.MaLop AND s.MaSV = d.MaSV AND m.MaMon = d.MaMon";
            //DataProvider.Instance.ExecuteNonQuery(query);
            //return list;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LoaiSP");
            foreach (DataRow item in data.Rows)
            {
                LoaiSP obj = new LoaiSP(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string maloaisp, string tenloai)
        {
            string query = $"INSERT INTO LoaiSP(MaLoaiSP, TenLoai) VALUES  ( N'{maloaisp}', N'{tenloai}' )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
