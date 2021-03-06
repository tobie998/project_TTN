USE [master]
GO
/****** Object:  Database [BanHangDienTu]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE DATABASE [BanHangDienTu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanHangDienTu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BanHangDienTu.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BanHangDienTu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BanHangDienTu_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BanHangDienTu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanHangDienTu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanHangDienTu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanHangDienTu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanHangDienTu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanHangDienTu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanHangDienTu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanHangDienTu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanHangDienTu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanHangDienTu] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BanHangDienTu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanHangDienTu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanHangDienTu] SET  MULTI_USER 
GO
ALTER DATABASE [BanHangDienTu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanHangDienTu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanHangDienTu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanHangDienTu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BanHangDienTu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BanHangDienTu]
GO
/****** Object:  Table [dbo].[ADMINS]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINS](
	[MaNV] [int] NOT NULL,
	[TenLOGIN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.ADMINS] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIET_HOADON]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_HOADON](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[GiamGia] [float] NULL,
 CONSTRAINT [PK_dbo.CHITIET_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLIENTS]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTS](
	[MaKH] [int] NOT NULL,
	[TenLOGIN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.CLIENTS] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIOHANG]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOHANG](
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_dbo.GIOHANG] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANG_SX]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG_SX](
	[MaHSX] [int] NOT NULL,
	[TenHSX] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.HANG_SX] PRIMARY KEY CLUSTERED 
(
	[MaHSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [int] NOT NULL,
	[TenHD] [nvarchar](50) NULL,
	[NgayDatHang] [date] NULL,
	[TongTien] [float] NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_dbo.HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NULL,
	[ImagePath] [varchar](max) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GT] [nvarchar](5) NULL,
	[SDT] [char](10) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_dbo.KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLH] [int] NOT NULL,
	[TenLH] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GT] [nvarchar](5) NULL,
	[NS] [date] NULL,
	[SĐT] [char](13) NULL,
	[Luong] [float] NULL,
	[photo] [varchar](300) NULL,
 CONSTRAINT [PK_dbo.NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 5/14/2019 11:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [int] NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[TinhTrang] [nvarchar](30) NULL,
	[MaLH] [int] NULL,
	[MaHSX] [int] NULL,
	[Photo] [varchar](50) NULL,
	[NgaySX] [date] NULL,
 CONSTRAINT [PK_dbo.SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ADMINS] ([MaNV], [TenLOGIN], [MatKhau]) VALUES (1, N'admin1', N'1')
INSERT [dbo].[ADMINS] ([MaNV], [TenLOGIN], [MatKhau]) VALUES (2, N'admin2', N'1')
INSERT [dbo].[ADMINS] ([MaNV], [TenLOGIN], [MatKhau]) VALUES (4, N'admin4', N'1')
INSERT [dbo].[CLIENTS] ([MaKH], [TenLOGIN], [MatKhau]) VALUES (1, N'kh001', N'1')
INSERT [dbo].[CLIENTS] ([MaKH], [TenLOGIN], [MatKhau]) VALUES (2, N'kh004', N'123')
INSERT [dbo].[CLIENTS] ([MaKH], [TenLOGIN], [MatKhau]) VALUES (3, N'kh002', N'1')
INSERT [dbo].[CLIENTS] ([MaKH], [TenLOGIN], [MatKhau]) VALUES (4, N'kh003', N'1')
INSERT [dbo].[GIOHANG] ([MaSP], [SoLuong], [Gia], [Photo]) VALUES (1, 1, 17900000, NULL)
INSERT [dbo].[GIOHANG] ([MaSP], [SoLuong], [Gia], [Photo]) VALUES (2, 2, 27800000, NULL)
INSERT [dbo].[GIOHANG] ([MaSP], [SoLuong], [Gia], [Photo]) VALUES (3, 2, 3000000, NULL)
INSERT [dbo].[GIOHANG] ([MaSP], [SoLuong], [Gia], [Photo]) VALUES (4, 1, 7800000, NULL)
INSERT [dbo].[HANG_SX] ([MaHSX], [TenHSX]) VALUES (1, N'Dell')
INSERT [dbo].[HANG_SX] ([MaHSX], [TenHSX]) VALUES (2, N'SamSung')
INSERT [dbo].[HANG_SX] ([MaHSX], [TenHSX]) VALUES (3, N'Sony')
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [NgayDatHang], [TongTien], [MaKH], [MaNV]) VALUES (1, N'HD01', CAST(N'2019-01-01' AS Date), 1000000, 1, 1)
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [NgayDatHang], [TongTien], [MaKH], [MaNV]) VALUES (2, N'HD02', CAST(N'2019-03-03' AS Date), 15000000, 2, 3)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GT], [SDT], [NgaySinh]) VALUES (0, N'Phạm Minh Thái', N'Nam', N'0387651414', CAST(N'1991-10-10' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GT], [SDT], [NgaySinh]) VALUES (1, N'Phạm Thế Hoạt', N'Nam', N'0325798653', CAST(N'1976-10-10' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GT], [SDT], [NgaySinh]) VALUES (2, N'Trần Đức Hiền', N'Nam', N'0387644649', CAST(N'1977-02-10' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GT], [SDT], [NgaySinh]) VALUES (3, N'Phạm Thế Quý', N'Nam', N'0384848765', CAST(N'1982-11-10' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GT], [SDT], [NgaySinh]) VALUES (4, N'Trịnh Minh Trung', N'Nam', N'0347448899', CAST(N'1988-06-19' AS Date))
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (1, N'Laptop')
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (2, N'SmartPhone')
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (3, N'Phụ Kiện')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GT], [NS], [SĐT], [Luong], [photo]) VALUES (0, N'Phạm Duy Thái', N'Nu', CAST(N'1998-10-08' AS Date), N'0367654100   ', 1500000, N'imgface1.jpg')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GT], [NS], [SĐT], [Luong], [photo]) VALUES (1, N'Phan Thị Cúc', N'Nữ', CAST(N'1998-10-10' AS Date), N'0361256545   ', 1500000, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GT], [NS], [SĐT], [Luong], [photo]) VALUES (2, N'Phan Văn Nhật', N'Nam', CAST(N'1998-02-15' AS Date), N'0346461414   ', 5000000, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GT], [NS], [SĐT], [Luong], [photo]) VALUES (3, N'Phan Hoàng Sơn', N'Nam', CAST(N'1998-04-19' AS Date), N'0368453912   ', 400000, NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GT], [NS], [SĐT], [Luong], [photo]) VALUES (4, N'Trịnh Văn Hà', N'Nam', CAST(N'1996-10-10' AS Date), N'0358764157   ', 3600000, NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (1, N'Dell Vostro 35600', 15000000, N'Mới', 2, 1, N'product07.png', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (2, N'SamSung Galaxy S10', 18900000, N'Mới', 2, 2, N'product07.png', CAST(N'2019-01-01' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (3, N'Tai Nghe Sony 365', 3500000, N'Mới', 3, 3, N'product03.png', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (4, N'Asus MX567', 12700000, N'Mới', 1, 1, N'product02.png', CAST(N'2018-10-03' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (5, N'Laptop MSI Gaming134', 15000000, N'Mới', 1, 1, N'product06.png', CAST(N'2018-10-05' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (8, N'SamSung Galaxy S10', 12999000, N'Mới', 2, 2, N'product07.png', CAST(N'2018-12-07' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (15, N'Máy Ảnh Rekam', 13299000, N'Mới', 3, 3, N'bg1.png', CAST(N'2018-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (16, N'sdsad', 15000, N'moi', 2, 1, N'anhcnpm.png', CAST(N'2027-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [Gia], [TinhTrang], [MaLH], [MaHSX], [Photo], [NgaySX]) VALUES (56, N'ghh', 67, N'cu', 1, 1, N'product04.png', CAST(N'2013-10-12' AS Date))
/****** Object:  Index [IX_MaNV]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaNV] ON [dbo].[ADMINS]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaHD]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaHD] ON [dbo].[CHITIET_HOADON]
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaSP]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaSP] ON [dbo].[CHITIET_HOADON]
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaKH]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaKH] ON [dbo].[CLIENTS]
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaSP]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaSP] ON [dbo].[GIOHANG]
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaKH]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaKH] ON [dbo].[HOADON]
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaNV]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaNV] ON [dbo].[HOADON]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaHSX]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaHSX] ON [dbo].[SANPHAM]
(
	[MaHSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaLH]    Script Date: 5/14/2019 11:27:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaLH] ON [dbo].[SANPHAM]
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ADMINS]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ADMINS_dbo.NHANVIEN_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[ADMINS] CHECK CONSTRAINT [FK_dbo.ADMINS_dbo.NHANVIEN_MaNV]
GO
ALTER TABLE [dbo].[CHITIET_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CHITIET_HOADON_dbo.HOADON_MaHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIET_HOADON] CHECK CONSTRAINT [FK_dbo.CHITIET_HOADON_dbo.HOADON_MaHD]
GO
ALTER TABLE [dbo].[CHITIET_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CHITIET_HOADON_dbo.SANPHAM_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CHITIET_HOADON] CHECK CONSTRAINT [FK_dbo.CHITIET_HOADON_dbo.SANPHAM_MaSP]
GO
ALTER TABLE [dbo].[CLIENTS]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CLIENTS_dbo.KHACHHANG_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CLIENTS] CHECK CONSTRAINT [FK_dbo.CLIENTS_dbo.KHACHHANG_MaKH]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GIOHANG_dbo.SANPHAM_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[GIOHANG] CHECK CONSTRAINT [FK_dbo.GIOHANG_dbo.SANPHAM_MaSP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HOADON_dbo.KHACHHANG_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_dbo.HOADON_dbo.KHACHHANG_MaKH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HOADON_dbo.NHANVIEN_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_dbo.HOADON_dbo.NHANVIEN_MaNV]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SANPHAM_dbo.HANG_SX_MaHSX] FOREIGN KEY([MaHSX])
REFERENCES [dbo].[HANG_SX] ([MaHSX])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_dbo.SANPHAM_dbo.HANG_SX_MaHSX]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SANPHAM_dbo.LOAIHANG_MaLH] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LOAIHANG] ([MaLH])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_dbo.SANPHAM_dbo.LOAIHANG_MaLH]
GO
USE [master]
GO
ALTER DATABASE [BanHangDienTu] SET  READ_WRITE 
GO
