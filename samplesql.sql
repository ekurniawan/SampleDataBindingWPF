USE [master]
GO
/****** Object:  Database [POSDb]    Script Date: 12/15/2016 11:04:15 AM ******/
CREATE DATABASE [POSDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POSDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\POSDb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POSDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\POSDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [POSDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POSDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POSDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POSDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POSDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POSDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POSDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [POSDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POSDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POSDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POSDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POSDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POSDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POSDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POSDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POSDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POSDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POSDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POSDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POSDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POSDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POSDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POSDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POSDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POSDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POSDb] SET  MULTI_USER 
GO
ALTER DATABASE [POSDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POSDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POSDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POSDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [POSDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [POSDb]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 12/15/2016 11:04:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barang](
	[KodeBarang] [varchar](8) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[NamaBarang] [varchar](50) NOT NULL,
	[HargaBeli] [money] NOT NULL,
	[HargaJual] [money] NOT NULL,
	[Stok] [int] NOT NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[KodeBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetailPembelian]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetailPembelian](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KodeNotaBeli] [int] NOT NULL,
	[KodeBarang] [varchar](8) NOT NULL,
	[Harga] [money] NOT NULL,
	[Kuantitas] [int] NULL,
	[Subtotal] [money] NULL,
 CONSTRAINT [PK_DetailPembelian] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[KategoriId] [int] IDENTITY(1,1) NOT NULL,
	[NamaKategori] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NotaPembelian]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaPembelian](
	[KodeNotaBeli] [int] IDENTITY(1,1) NOT NULL,
	[KodePemasok] [int] NOT NULL,
	[Tanggal] [date] NOT NULL,
 CONSTRAINT [PK_NotaPembelian] PRIMARY KEY CLUSTERED 
(
	[KodeNotaBeli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pelanggan]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pelanggan](
	[KodePelanggan] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [varchar](50) NULL,
	[Alamat] [varchar](50) NULL,
	[Telpon] [varchar](50) NULL,
 CONSTRAINT [PK_Pelanggan] PRIMARY KEY CLUSTERED 
(
	[KodePelanggan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pemasok]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pemasok](
	[KodePemasok] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [varchar](50) NULL,
	[Alamat] [varchar](50) NULL,
	[Telpon] [varchar](50) NULL,
 CONSTRAINT [PK_Pemasok] PRIMARY KEY CLUSTERED 
(
	[KodePemasok] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pengguna]    Script Date: 12/15/2016 11:04:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pengguna](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Aturan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pengguna] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Kategori] ON 

INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (1, N'Laptop Lowend')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (2, N'PC')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (3, N'Keyboard')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (4, N'Mouse')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (5, N'Ultrabook')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (7, N'Motherboard')
INSERT [dbo].[Kategori] ([KategoriId], [NamaKategori]) VALUES (9, N'Hardisk')
SET IDENTITY_INSERT [dbo].[Kategori] OFF
SET IDENTITY_INSERT [dbo].[Pemasok] ON 

INSERT [dbo].[Pemasok] ([KodePemasok], [Nama], [Alamat], [Telpon]) VALUES (1, N'Toko ABC', N'Jl Mawar 12', N'567874')
INSERT [dbo].[Pemasok] ([KodePemasok], [Nama], [Alamat], [Telpon]) VALUES (2, N'Toko Murah', N'Jl Mangga 14', N'567898')
SET IDENTITY_INSERT [dbo].[Pemasok] OFF
ALTER TABLE [dbo].[Barang] ADD  CONSTRAINT [DF_Barang_HargaBeli]  DEFAULT ((0)) FOR [HargaBeli]
GO
ALTER TABLE [dbo].[Barang] ADD  CONSTRAINT [DF_Barang_HargaJual]  DEFAULT ((0)) FOR [HargaJual]
GO
ALTER TABLE [dbo].[Barang] ADD  CONSTRAINT [DF_Barang_Stok]  DEFAULT ((0)) FOR [Stok]
GO
ALTER TABLE [dbo].[DetailPembelian] ADD  CONSTRAINT [DF_DetailPembelian_Harga]  DEFAULT ((0)) FOR [Harga]
GO
ALTER TABLE [dbo].[DetailPembelian] ADD  CONSTRAINT [DF_DetailPembelian_Kuantitas]  DEFAULT ((0)) FOR [Kuantitas]
GO
ALTER TABLE [dbo].[DetailPembelian] ADD  CONSTRAINT [DF_DetailPembelian_Subtotal]  DEFAULT ((0)) FOR [Subtotal]
GO
ALTER TABLE [dbo].[NotaPembelian] ADD  CONSTRAINT [DF_NotaPembelian_Tanggal]  DEFAULT (getdate()) FOR [Tanggal]
GO
ALTER TABLE [dbo].[Barang]  WITH CHECK ADD  CONSTRAINT [FK_Barang_Kategori] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategori] ([KategoriId])
GO
ALTER TABLE [dbo].[Barang] CHECK CONSTRAINT [FK_Barang_Kategori]
GO
ALTER TABLE [dbo].[DetailPembelian]  WITH CHECK ADD  CONSTRAINT [FK_DetailPembelian_Barang] FOREIGN KEY([KodeBarang])
REFERENCES [dbo].[Barang] ([KodeBarang])
GO
ALTER TABLE [dbo].[DetailPembelian] CHECK CONSTRAINT [FK_DetailPembelian_Barang]
GO
ALTER TABLE [dbo].[DetailPembelian]  WITH CHECK ADD  CONSTRAINT [FK_DetailPembelian_NotaPembelian] FOREIGN KEY([KodeNotaBeli])
REFERENCES [dbo].[NotaPembelian] ([KodeNotaBeli])
GO
ALTER TABLE [dbo].[DetailPembelian] CHECK CONSTRAINT [FK_DetailPembelian_NotaPembelian]
GO
ALTER TABLE [dbo].[NotaPembelian]  WITH CHECK ADD  CONSTRAINT [FK_NotaPembelian_Pemasok] FOREIGN KEY([KodePemasok])
REFERENCES [dbo].[Pemasok] ([KodePemasok])
GO
ALTER TABLE [dbo].[NotaPembelian] CHECK CONSTRAINT [FK_NotaPembelian_Pemasok]
GO
USE [master]
GO
ALTER DATABASE [POSDb] SET  READ_WRITE 
GO
