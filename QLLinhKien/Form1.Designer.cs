
namespace QLLinhKien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadSP = new System.Windows.Forms.Button();
            this.tabSanPham = new System.Windows.Forms.TabControl();
            this.tabSP = new System.Windows.Forms.TabPage();
            this.txtmaLoaiSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbloaiSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgiaKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaSP = new System.Windows.Forms.TextBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.tabloaiSP = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtenLoaiSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmaLoaiSP2 = new System.Windows.Forms.TextBox();
            this.btnxoaLoaiSP = new System.Windows.Forms.Button();
            this.btnsuaLoaiSP = new System.Windows.Forms.Button();
            this.btnthemLoaiSP = new System.Windows.Forms.Button();
            this.btnloadLoaiSP = new System.Windows.Forms.Button();
            this.dtgdisplayLoaiSP = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabSanPham.SuspendLayout();
            this.tabSP.SuspendLayout();
            this.tabloaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdisplayLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadSP
            // 
            this.btnLoadSP.Location = new System.Drawing.Point(714, 15);
            this.btnLoadSP.Name = "btnLoadSP";
            this.btnLoadSP.Size = new System.Drawing.Size(161, 37);
            this.btnLoadSP.TabIndex = 1;
            this.btnLoadSP.Text = "Load SP";
            this.btnLoadSP.UseVisualStyleBackColor = true;
            this.btnLoadSP.Click += new System.EventHandler(this.btnLoadSP_Click);
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.tabSP);
            this.tabSanPham.Controls.Add(this.tabloaiSP);
            this.tabSanPham.Controls.Add(this.tabPage3);
            this.tabSanPham.Controls.Add(this.tabPage4);
            this.tabSanPham.Controls.Add(this.tabPage5);
            this.tabSanPham.Location = new System.Drawing.Point(12, 12);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.SelectedIndex = 0;
            this.tabSanPham.Size = new System.Drawing.Size(907, 426);
            this.tabSanPham.TabIndex = 2;
            this.tabSanPham.Tag = "T";
            // 
            // tabSP
            // 
            this.tabSP.Controls.Add(this.txtmaLoaiSP);
            this.tabSP.Controls.Add(this.label7);
            this.tabSP.Controls.Add(this.cbloaiSP);
            this.tabSP.Controls.Add(this.label6);
            this.tabSP.Controls.Add(this.txtgiaKM);
            this.tabSP.Controls.Add(this.label5);
            this.tabSP.Controls.Add(this.txtmoTa);
            this.tabSP.Controls.Add(this.label4);
            this.tabSP.Controls.Add(this.txtdonGia);
            this.tabSP.Controls.Add(this.label3);
            this.tabSP.Controls.Add(this.txtsoLuong);
            this.tabSP.Controls.Add(this.label2);
            this.tabSP.Controls.Add(this.txttenSP);
            this.tabSP.Controls.Add(this.label1);
            this.tabSP.Controls.Add(this.txtmaSP);
            this.tabSP.Controls.Add(this.btnXoaSP);
            this.tabSP.Controls.Add(this.btnSuaSP);
            this.tabSP.Controls.Add(this.btnThemSP);
            this.tabSP.Controls.Add(this.btnLoadSP);
            this.tabSP.Controls.Add(this.dataGridView1);
            this.tabSP.Location = new System.Drawing.Point(4, 22);
            this.tabSP.Name = "tabSP";
            this.tabSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP.Size = new System.Drawing.Size(899, 400);
            this.tabSP.TabIndex = 0;
            this.tabSP.Text = "Sản phẩm";
            this.tabSP.UseVisualStyleBackColor = true;
            this.tabSP.Click += new System.EventHandler(this.tabSP_Click);
            // 
            // txtmaLoaiSP
            // 
            this.txtmaLoaiSP.Location = new System.Drawing.Point(767, 250);
            this.txtmaLoaiSP.Name = "txtmaLoaiSP";
            this.txtmaLoaiSP.Size = new System.Drawing.Size(121, 20);
            this.txtmaLoaiSP.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã loại SP";
            // 
            // cbloaiSP
            // 
            this.cbloaiSP.FormattingEnabled = true;
            this.cbloaiSP.Items.AddRange(new object[] {
            "RAM"});
            this.cbloaiSP.Location = new System.Drawing.Point(767, 223);
            this.cbloaiSP.Name = "cbloaiSP";
            this.cbloaiSP.Size = new System.Drawing.Size(121, 21);
            this.cbloaiSP.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giá KM";
            // 
            // txtgiaKM
            // 
            this.txtgiaKM.Location = new System.Drawing.Point(767, 197);
            this.txtgiaKM.Name = "txtgiaKM";
            this.txtgiaKM.Size = new System.Drawing.Size(121, 20);
            this.txtgiaKM.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mô tả";
            // 
            // txtmoTa
            // 
            this.txtmoTa.Location = new System.Drawing.Point(767, 171);
            this.txtmoTa.Name = "txtmoTa";
            this.txtmoTa.Size = new System.Drawing.Size(121, 20);
            this.txtmoTa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn giá";
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(767, 145);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(121, 20);
            this.txtdonGia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số lượng";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.Location = new System.Drawing.Point(767, 119);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtsoLuong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên SP";
            // 
            // txttenSP
            // 
            this.txttenSP.Location = new System.Drawing.Point(767, 93);
            this.txttenSP.Name = "txttenSP";
            this.txttenSP.Size = new System.Drawing.Size(121, 20);
            this.txttenSP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã SP";
            // 
            // txtmaSP
            // 
            this.txtmaSP.Location = new System.Drawing.Point(767, 67);
            this.txtmaSP.Name = "txtmaSP";
            this.txtmaSP.Size = new System.Drawing.Size(121, 20);
            this.txtmaSP.TabIndex = 5;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(833, 371);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(60, 23);
            this.btnXoaSP.TabIndex = 4;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(767, 371);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(55, 23);
            this.btnSuaSP.TabIndex = 3;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(689, 371);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(62, 23);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // tabloaiSP
            // 
            this.tabloaiSP.Controls.Add(this.label8);
            this.tabloaiSP.Controls.Add(this.txtenLoaiSP);
            this.tabloaiSP.Controls.Add(this.label9);
            this.tabloaiSP.Controls.Add(this.txtmaLoaiSP2);
            this.tabloaiSP.Controls.Add(this.btnxoaLoaiSP);
            this.tabloaiSP.Controls.Add(this.btnsuaLoaiSP);
            this.tabloaiSP.Controls.Add(this.btnthemLoaiSP);
            this.tabloaiSP.Controls.Add(this.btnloadLoaiSP);
            this.tabloaiSP.Controls.Add(this.dtgdisplayLoaiSP);
            this.tabloaiSP.Location = new System.Drawing.Point(4, 22);
            this.tabloaiSP.Name = "tabloaiSP";
            this.tabloaiSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabloaiSP.Size = new System.Drawing.Size(899, 400);
            this.tabloaiSP.TabIndex = 1;
            this.tabloaiSP.Text = "Loại SP";
            this.tabloaiSP.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên Loại SP";
            // 
            // txtenLoaiSP
            // 
            this.txtenLoaiSP.Location = new System.Drawing.Point(767, 93);
            this.txtenLoaiSP.Name = "txtenLoaiSP";
            this.txtenLoaiSP.Size = new System.Drawing.Size(121, 20);
            this.txtenLoaiSP.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã Loại SP";
            // 
            // txtmaLoaiSP2
            // 
            this.txtmaLoaiSP2.Location = new System.Drawing.Point(767, 67);
            this.txtmaLoaiSP2.Name = "txtmaLoaiSP2";
            this.txtmaLoaiSP2.Size = new System.Drawing.Size(121, 20);
            this.txtmaLoaiSP2.TabIndex = 14;
            // 
            // btnxoaLoaiSP
            // 
            this.btnxoaLoaiSP.Location = new System.Drawing.Point(833, 371);
            this.btnxoaLoaiSP.Name = "btnxoaLoaiSP";
            this.btnxoaLoaiSP.Size = new System.Drawing.Size(60, 23);
            this.btnxoaLoaiSP.TabIndex = 13;
            this.btnxoaLoaiSP.Text = "Xóa";
            this.btnxoaLoaiSP.UseVisualStyleBackColor = true;
            // 
            // btnsuaLoaiSP
            // 
            this.btnsuaLoaiSP.Location = new System.Drawing.Point(767, 371);
            this.btnsuaLoaiSP.Name = "btnsuaLoaiSP";
            this.btnsuaLoaiSP.Size = new System.Drawing.Size(55, 23);
            this.btnsuaLoaiSP.TabIndex = 12;
            this.btnsuaLoaiSP.Text = "Sửa";
            this.btnsuaLoaiSP.UseVisualStyleBackColor = true;
            // 
            // btnthemLoaiSP
            // 
            this.btnthemLoaiSP.Location = new System.Drawing.Point(689, 371);
            this.btnthemLoaiSP.Name = "btnthemLoaiSP";
            this.btnthemLoaiSP.Size = new System.Drawing.Size(62, 23);
            this.btnthemLoaiSP.TabIndex = 11;
            this.btnthemLoaiSP.Text = "Thêm";
            this.btnthemLoaiSP.UseVisualStyleBackColor = true;
            this.btnthemLoaiSP.Click += new System.EventHandler(this.btnthemLoaiSP_Click);
            // 
            // btnloadLoaiSP
            // 
            this.btnloadLoaiSP.Location = new System.Drawing.Point(714, 15);
            this.btnloadLoaiSP.Name = "btnloadLoaiSP";
            this.btnloadLoaiSP.Size = new System.Drawing.Size(161, 37);
            this.btnloadLoaiSP.TabIndex = 10;
            this.btnloadLoaiSP.Text = "Load Loại SP";
            this.btnloadLoaiSP.UseVisualStyleBackColor = true;
            this.btnloadLoaiSP.Click += new System.EventHandler(this.btnloadLoaiSP_Click);
            // 
            // dtgdisplayLoaiSP
            // 
            this.dtgdisplayLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdisplayLoaiSP.Location = new System.Drawing.Point(6, 6);
            this.dtgdisplayLoaiSP.Name = "dtgdisplayLoaiSP";
            this.dtgdisplayLoaiSP.Size = new System.Drawing.Size(677, 388);
            this.dtgdisplayLoaiSP.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(899, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(899, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(899, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.tabSanPham);
            this.Name = "Form1";
            this.Text = "Quản lí linh kiện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabSanPham.ResumeLayout(false);
            this.tabSP.ResumeLayout(false);
            this.tabSP.PerformLayout();
            this.tabloaiSP.ResumeLayout(false);
            this.tabloaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdisplayLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadSP;
        private System.Windows.Forms.TabControl tabSanPham;
        private System.Windows.Forms.TabPage tabSP;
        private System.Windows.Forms.TabPage tabloaiSP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgiaKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbloaiSP;
        private System.Windows.Forms.TextBox txtmaLoaiSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtenLoaiSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmaLoaiSP2;
        private System.Windows.Forms.Button btnxoaLoaiSP;
        private System.Windows.Forms.Button btnsuaLoaiSP;
        private System.Windows.Forms.Button btnthemLoaiSP;
        private System.Windows.Forms.Button btnloadLoaiSP;
        private System.Windows.Forms.DataGridView dtgdisplayLoaiSP;
    }
}

