using API_Data.DTO;
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

namespace QLLinhKien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public string baseAddress = "https://localhost:44390";

        List<SanPham> listSanPham = null;
        List<LoaiSP> listLoaiSP = null;

        bool Kt = false;
        bool KtLoaiSP = false;

        public void ErrorSP()
        {

            if (txtmaSP.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống");
            }

            else if (txttenSP.Text == "")
            {
                MessageBox.Show("Tên sản phảm không được để trống");
            }
            //else if (txtsoLuong.Text == "")
            //{
            //    MessageBox.Show("Số lượng sản phẩm không được để trống");
            //}

            else if (txtdonGia.Text == "")
            {
                MessageBox.Show("Đơn giá sản phẩm không được để trống");
            }
            else if (txtmaLoaiSP.Text == "")
            {
                MessageBox.Show("Mã loại sản phẩm không được để trống");
            }
            else
            {
                this.Kt = true;
            }

        }

        public void ErrorLoaiSP()
        {

            if (txtmaLoaiSP2.Text == "")
            {
                MessageBox.Show("Mã loại sản phẩm không được để trống");
            }

            else if (txtenLoaiSP.Text == "")
            {
                MessageBox.Show("Tên loại sản phảm không được để trống");
            }
           
            else
            {
                this.KtLoaiSP = true;
            }

        }

        public void ClearSP()
        {
            txtmaSP.Text = "";
            txttenSP.Text = "";
            txtsoLuong.Text = "";
            txtdonGia.Text = "";
            txtmoTa.Text = "";
            txtgiaKM.Text = "";
            txtmaLoaiSP.Text = "";

        }

        public void ClearLoaiSP()
        {
            txtmaLoaiSP2.Text = "";
            txtenLoaiSP.Text = "";
        }

        private void btnLoadSP_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearSP();
            //HttpClient clint = new HttpClient();
            //clint.BaseAddress = new Uri("https://localhost:44390/api/");
            //HttpResponseMessage response = clint.GetAsync("api/SanPham").Result;
            //var sp = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
            //dataGridView1.DataSource = sp;
        }

        public void LoadData()
        {
            listSanPham = LoadSanPham();
            if (listSanPham != null)
                dataGridView1.DataSource = listSanPham;
            listLoaiSP = LoadLoaiSP();
            if (listLoaiSP != null)
                dtgdisplayLoaiSP.DataSource = listLoaiSP;
        }

        private List<SanPham> LoadSanPham()
        {
            List<SanPham> listSanPham = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listsanpham");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<SanPham>>();
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

        private List<LoaiSP> LoadLoaiSP()
        {
            List<LoaiSP> listLoaiSP = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listloaisp");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LoaiSP>>();
                    readTask.Wait();

                    listLoaiSP = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return listLoaiSP;
        }

        private void tabSP_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ErrorSP();

            string maSP = txtmaSP.Text;
            string tenSP = txttenSP.Text;
            int soLuong = int.Parse(txtsoLuong.Text);
            string donGia = txtdonGia.Text;
            string moTa = txtmoTa.Text;
            string giaKM = txtgiaKM.Text;
            string maLoaiSP = txtmaLoaiSP.Text;

            SanPham sp = new SanPham(maSP, tenSP, soLuong, donGia, moTa, giaKM, maLoaiSP);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<SanPham>("themsanpham", sp);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    ClearSP();
                    LoadData();
                }
                else //web api sent error response 
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");

                }
            }
        }

        private void btnthemLoaiSP_Click(object sender, EventArgs e)
        {
            ErrorLoaiSP();

            string maLoaiSP = txtmaLoaiSP2.Text;
            string tenLoaiSP = txtenLoaiSP.Text;

            LoaiSP lsp = new LoaiSP(maLoaiSP, tenLoaiSP);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<LoaiSP>("themloaisp", lsp);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công");
                    ClearLoaiSP();
                    LoadData();
                }
                else //web api sent error response 
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại");
                    //ClearLoaiSP();
                }
            }
        }

        private void btnloadLoaiSP_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearLoaiSP();
        }
    }
}
