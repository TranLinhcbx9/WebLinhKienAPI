
using API_Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_LK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public string baseAddress = "https://localhost:44390/";

        List<LinhKien> listLinhKien = null;

        public void LoadData()
        {
            listLinhKien = LoadSanPham();
            if (listLinhKien != null)
                dtgDisplaySanPham.DataSource = listLinhKien;
            //listLoaiSP = LoadLoaiSP();
            //if (listLoaiSP != null)
            //    dtgdisplayLoaiSP.DataSource = listLoaiSP;
        }

        public void ErrorLinhKien()
        {

        }

        public void ClearLinhKien()
        {
            txtMaLinhKien.Text = "";
            txtMaLoaiLinhKien.Text = "";
            txtMaLoaiMay.Text = "";
            txtMaNhaCungCap.Text = "";
            txtTenLinhKien.Text = "";
            txtThongSoKiThuat.Text = "";
            txtMoTa.Text = "";
            //txtMoTa.Text = "";
            txtGiaBan.Text = "";
            txtThoiGianBaoHanh.Text = "";
        }
        private List<LinhKien> LoadSanPham()
        {
            List<LinhKien> listSanPham = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listlinhkien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LinhKien>>();
                    readTask.Wait();

                    listSanPham = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return listSanPham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ErrorLinhKien();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            int maLoaiLinhKien = int.Parse(txtMaLoaiLinhKien.Text);
            int maNhaCungCap = int.Parse(txtMaNhaCungCap.Text);
            int maLoaiMay = int.Parse(txtMaLoaiMay.Text);
            string tenLinhKien = txtTenLinhKien.Text;
            string thongSoKiThuat = txtThongSoKiThuat.Text;
            string moTa = txtMoTa.Text;
            float giaBan = float.Parse(txtGiaBan.Text);
            string thoiGianBaoHanh = txtThoiGianBaoHanh.Text;
            LinhKien lk = new LinhKien();
            lk.
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<LinhKien>("themlinhkien", lk);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    ClearLinhKien();
                    LoadData();
                }
                else //web api sent error response 
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");

                }
            }
        }
    }
}
