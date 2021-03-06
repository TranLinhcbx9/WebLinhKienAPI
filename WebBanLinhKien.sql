USE [WebBanLinhKien]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[MaAdmin] [char](5) NOT NULL,
	[UserAd] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Pass] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaHD] [char](5) NOT NULL,
	[MaSP] [char](5) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPN] [char](5) NOT NULL,
	[MaSP] [char](5) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](5) NOT NULL,
	[NgayDat] [date] NULL,
	[NgayShip] [date] NULL,
	[MaKH] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](5) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Tuoi] [int] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[UserName] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Pass] [varchar](50) NULL,
	[IsVip] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [char](5) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[MoTa] [ntext] NULL,
	[URLAnh] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [char](5) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [char](5) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [char](5) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuyenAd]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuyenAd](
	[MaAdmin] [char](5) NOT NULL,
	[MaQuyen] [char](5) NOT NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaAdmin] ASC,
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/24/2020 9:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](5) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[MoTa] [ntext] NULL,
	[GiaKm] [money] NULL,
	[URLAnh] [varchar](200) NULL,
	[MaLoaiSP] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L001 ', N'RAM', N'Ram máy tính', NULL)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L002 ', N'SSD', N'Ổ cứng máy tính', NULL)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L003 ', N'Moniter', N'Màn hình máy tính', NULL)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L004 ', N'Chuột', N'Chuột máy tính', NULL)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L005 ', N'Bàn phím', N'Bàn phím máy tính', NULL)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai], [MoTa], [URLAnh]) VALUES (N'L006 ', N'HDD', NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S001 ', N'RAM Kingston 8G', 10, 99.0000, N'ram kingston mơi nghuyên hộp', 79.0000, NULL, N'L001 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S002 ', N'Bàn phím co EDRA EK387', 15, 50.0000, N'Bàn phím EDRA EK387 led rainbow với 7 chế độ led khác nhau, bàn phím mới nguyên seal', 45.0000, NULL, N'L005 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S003 ', N'SSD KingMax', 12, 65.0000, N'Hangf mowis nguyeen seal', 45.0000, NULL, N'L002 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S004 ', N'SSD WD', 20, 65.0000, N'Hangf mowis nguyeen seal', 45.0000, NULL, N'L002 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S005 ', N'Phím cơ EDRA EK3104', 25, 70.0000, N'Mới nguyên seal', 0.0000, NULL, N'L005 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S006 ', N'Màn hình LG1102', 25, 250.0000, N'Màn hình 75hz ngyên seal', 0.0000, NULL, N'L003 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S007 ', N'RAM Remax', 35, 50.0000, N'8G mới ', 45.0000, NULL, N'L001 ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MoTa], [GiaKm], [URLAnh], [MaLoaiSP]) VALUES (N'S008 ', N'RAM Kingmax', 35, 65.0000, N'8G mới nguyên seal', 55.0000, NULL, N'L001 ')
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuyenAd]  WITH CHECK ADD FOREIGN KEY([MaAdmin])
REFERENCES [dbo].[Admin] ([MaAdmin])
GO
ALTER TABLE [dbo].[QuyenAd]  WITH CHECK ADD FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([Tuoi]>(0)))
GO
