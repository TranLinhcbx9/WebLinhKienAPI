
using API_Data.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Data.DAO
{
    public class LinhKienDAO
    {
        Web db = null;
        public LinhKienDAO()
        {
            db = new Web();

        }
        //private LinhKienDAO() { }

        //private static volatile LinhKienDAO instance;

        //static object key = new object();

        //public static LinhKienDAO Instance
        //{
        //    get
        //    {
        //        lock (key)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new LinhKienDAO();
        //            }
        //        }

        //        return instance;
        //    }

        //    private set
        //    {
        //        instance = value;
        //    }
        //}

        public List<LinhKien> GetListLinhKien()
        {
            //List<LinhKien> list = new List<LinhKien>();

            ////string query = $"SELECT s.MaSV, s.TenSV, l.TenLop, TenMon, Diem FROM SinhVien s , Lop l, MonHoc m, Diem d WHERE s.MaLop = l.MaLop AND s.MaSV = d.MaSV AND m.MaMon = d.MaMon";
            ////DataProvider.Instance.ExecuteNonQuery(query);
            ////return list;
            //DataTable data = DataProvider.Instance.ExecuteQuery("select * from LinhKien");
            //foreach (DataRow item in data.Rows)
            //{
            //    LinhKien obj = new LinhKien(item);
            //    list.Add(obj);
            //}
            //return list;
            return db.LinhKiens.ToList();
        }

        //public int CreateLinhKien(int maloailinhkien, int manhacungcap, int maloaimay, string tenlinhkien, string thongsokithuat, string mota, float giaban, string thoigianbaohanh)
        //{
        //    string query = $"INSERT INTO LinhKien(maLoaiLinhKien, maNhaCungCap, maLoaiMay, tenLinhKien, thongSoKiThuat, moTa, giaBan, thoiGianBaoHanh) VALUES  (N'{maloailinhkien}', N'{manhacungcap}',  N'{maloaimay}', N'{tenlinhkien}', N'{thongsokithuat}', N'{mota}', N'{giaban}', N'{thoigianbaohanh}' )";

        //    DataProvider.Instance.ExecuteNonQuery(query);

        //    return 1;
        //}
    }
}
