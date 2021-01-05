
namespace Winform_LK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaLoaiMay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaLoaiLinhKien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThoiGianBaoHanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThongSoKiThuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLinhKien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLinhKien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDisplaySanPham = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplaySanPham)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÍ LINH KIỆN";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(738, 310);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(55, 23);
            this.btnHienThi.TabIndex = 22;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(661, 339);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(739, 339);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(584, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaLoaiMay
            // 
            this.txtMaLoaiMay.Location = new System.Drawing.Point(689, 220);
            this.txtMaLoaiMay.Name = "txtMaLoaiMay";
            this.txtMaLoaiMay.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiMay.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã loại máy";
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(689, 194);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhaCungCap.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã nhà cung cấp";
            // 
            // txtMaLoaiLinhKien
            // 
            this.txtMaLoaiLinhKien.Location = new System.Drawing.Point(689, 168);
            this.txtMaLoaiLinhKien.Name = "txtMaLoaiLinhKien";
            this.txtMaLoaiLinhKien.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiLinhKien.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã loại linh kiện";
            // 
            // txtThoiGianBaoHanh
            // 
            this.txtThoiGianBaoHanh.Location = new System.Drawing.Point(689, 142);
            this.txtThoiGianBaoHanh.Name = "txtThoiGianBaoHanh";
            this.txtThoiGianBaoHanh.Size = new System.Drawing.Size(100, 20);
            this.txtThoiGianBaoHanh.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thời gian bảo hành";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(689, 116);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá bán";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(689, 90);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 20);
            this.txtMoTa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mô tả";
            // 
            // txtThongSoKiThuat
            // 
            this.txtThongSoKiThuat.Location = new System.Drawing.Point(689, 64);
            this.txtThongSoKiThuat.Name = "txtThongSoKiThuat";
            this.txtThongSoKiThuat.Size = new System.Drawing.Size(100, 20);
            this.txtThongSoKiThuat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thông số kĩ thuật";
            // 
            // txtTenLinhKien
            // 
            this.txtTenLinhKien.Location = new System.Drawing.Point(689, 38);
            this.txtTenLinhKien.Name = "txtTenLinhKien";
            this.txtTenLinhKien.Size = new System.Drawing.Size(100, 20);
            this.txtTenLinhKien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên linh kiện";
            // 
            // txtMaLinhKien
            // 
            this.txtMaLinhKien.Location = new System.Drawing.Point(689, 12);
            this.txtMaLinhKien.Name = "txtMaLinhKien";
            this.txtMaLinhKien.ReadOnly = true;
            this.txtMaLinhKien.Size = new System.Drawing.Size(100, 20);
            this.txtMaLinhKien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã linh kiện";
            // 
            // dtgDisplaySanPham
            // 
            this.dtgDisplaySanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplaySanPham.Location = new System.Drawing.Point(6, 6);
            this.dtgDisplaySanPham.Name = "dtgDisplaySanPham";
            this.dtgDisplaySanPham.Size = new System.Drawing.Size(572, 356);
            this.dtgDisplaySanPham.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHienThi);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.txtMaLoaiMay);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtMaNhaCungCap);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtMaLoaiLinhKien);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtThoiGianBaoHanh);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtGiaBan);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtMoTa);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtThongSoKiThuat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTenLinhKien);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMaLinhKien);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtgDisplaySanPham);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Linh kiện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 394);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplaySanPham)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaLoaiMay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaLoaiLinhKien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThoiGianBaoHanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThongSoKiThuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLinhKien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLinhKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgDisplaySanPham;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

