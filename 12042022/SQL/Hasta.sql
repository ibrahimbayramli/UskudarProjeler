USE [master]
GO
/****** Object:  Database [Hastahane]    Script Date: 12.04.2022 17:33:47 ******/
CREATE DATABASE [Hastahane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hastahane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hastahane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hastahane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hastahane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hastahane] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hastahane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hastahane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hastahane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hastahane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hastahane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hastahane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hastahane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hastahane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hastahane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hastahane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hastahane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hastahane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hastahane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hastahane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hastahane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hastahane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hastahane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hastahane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hastahane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hastahane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hastahane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hastahane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hastahane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hastahane] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hastahane] SET  MULTI_USER 
GO
ALTER DATABASE [Hastahane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hastahane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hastahane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hastahane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hastahane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hastahane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hastahane] SET QUERY_STORE = OFF
GO
USE [Hastahane]
GO
/****** Object:  Table [dbo].[Doktorlar]    Script Date: 12.04.2022 17:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktorlar](
	[DoktorNo] [int] IDENTITY(500,5) NOT NULL,
	[DoktorAdSoyad] [varchar](50) NULL,
	[DoktorTcNo] [nchar](11) NULL,
	[TekefonNo] [nchar](11) NULL,
	[Adres] [varchar](50) NULL,
	[DoktorDogumTarihi] [nchar](10) NULL,
	[PoliklinikNo] [int] NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[DoktorNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hastalar]    Script Date: 12.04.2022 17:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastalar](
	[HastaNo] [int] IDENTITY(600,5) NOT NULL,
	[HastaAdSoyad] [varchar](50) NULL,
	[HastaTcNo] [nchar](11) NULL,
	[HastaDogumTarihi] [varchar](50) NULL,
	[Boy] [int] NULL,
	[Yas] [int] NULL,
	[RaporDurumu] [varchar](50) NULL,
	[RandevuTarihi] [varchar](50) NULL,
	[DoktorNo] [int] NULL,
 CONSTRAINT [PK_Hastalar] PRIMARY KEY CLUSTERED 
(
	[HastaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poliklinikler]    Script Date: 12.04.2022 17:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poliklinikler](
	[PoliklinikNo] [int] IDENTITY(1,1) NOT NULL,
	[PoliklinikAdi] [varchar](50) NULL,
	[PoliklinikUzmanSayisi] [int] NULL,
	[PoliklinikBasHekimi] [varchar](50) NULL,
	[PoliklinikBasHemsiresi] [varchar](50) NULL,
	[YatakSayisi] [int] NULL,
 CONSTRAINT [PK_Poliklinikler] PRIMARY KEY CLUSTERED 
(
	[PoliklinikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receteler]    Script Date: 12.04.2022 17:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receteler](
	[ReceteNo] [int] IDENTITY(700,5) NOT NULL,
	[HastaNo] [int] NULL,
	[DoktorNo] [int] NULL,
	[HastaAdiSoyadi] [varchar](50) NULL,
	[ReceteDetay] [varchar](50) NULL,
	[ReceteTarih] [varchar](50) NULL,
 CONSTRAINT [PK_Receteler] PRIMARY KEY CLUSTERED 
(
	[ReceteNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doktorlar] ON 

INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (500, N'Sinan KARADAĞ', N'123456789  ', N'123456724  ', N'Ümraniye', N'05.04.1987', 10)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (505, N'Koray KISA', N'654972313  ', N'321657981  ', N'Maltepe', N'12.03.1978', 2)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (510, N'Tarık TAŞ', N'2316549123 ', N'32165432   ', N'Maltepe', N'26.12.1982', 3)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (515, N'Cem UZUN', N'2146513132 ', N'49873216   ', N'Üsküdar', N'02.02.1990', 1)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (540, N'Murat YUVA', N'1324654987 ', N'2163546    ', N'Kartal', N'01.01.1962', 4)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (545, N'Hilmi DEREN', N'135497854  ', N'21649871   ', N'Kartal', N'13.05.1977', 5)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (550, N'Mustafa ASİL', N'132498732  ', N'16545616   ', N'Kartal', N'01.07.1942', 6)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (555, N'Kemal DEMİR', N'12346713   ', N'165498231  ', N'Esenkent', N'27.07.1991', 7)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (560, N'Mert DİP', N'13246987   ', N'13246984   ', N'Kadıköy', N'11.09.1955', 8)
INSERT [dbo].[Doktorlar] ([DoktorNo], [DoktorAdSoyad], [DoktorTcNo], [TekefonNo], [Adres], [DoktorDogumTarihi], [PoliklinikNo]) VALUES (565, N'Ali KOR', N'654321987  ', N'32164      ', N'Beşiktaş', N'17.08.1949', 9)
SET IDENTITY_INSERT [dbo].[Doktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Hastalar] ON 

INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (600, N'Murat GÖK', N'1324654    ', N'01.01.1998', 187, 24, N'Yok', N'15.04.2022', 500)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (605, N'Mert AK', N'231654231  ', N'25.07.1988', 175, 34, N'Yok', N'01.05.2022', 505)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (610, N'Ceren KIRIK', N'321354687  ', N'12.09.1995', 170, 27, N'Var', N'24.4.2022', 510)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (615, N'Giray KOL', N'31216543   ', N'15.12.1978', 195, 44, N'Yok', N'17.05.2022', 515)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (640, N'Dursun ŞİMŞEK', N'9182631    ', N'11.03.1983', 179, 39, N'Yok', N'29.04.2022', 540)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (645, N'Kadri IŞIK', N'1231321    ', N'01.01.1999', 177, 23, N'Var', N'29.04.2022', 545)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (650, N'Cenk DEMİR', N'1345798    ', N'12.06.1992', 189, 30, N'Yok', N'01.05.2022', 550)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (660, N'Kerim İZ', N'32165498   ', N'19.02.1972', 169, 50, N'Yok', N'15.04.2022', 555)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (665, N'Kerem KERİM', N'1346549    ', N'10.10.1990', 197, 32, N'Yok', N'22.05.2022', 560)
INSERT [dbo].[Hastalar] ([HastaNo], [HastaAdSoyad], [HastaTcNo], [HastaDogumTarihi], [Boy], [Yas], [RaporDurumu], [RandevuTarihi], [DoktorNo]) VALUES (670, N'Dilek SAĞIR', N'1324649    ', N'12.03.1993', 155, 29, N'Yok', N'12.06.2022', 565)
SET IDENTITY_INSERT [dbo].[Hastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Poliklinikler] ON 

INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (1, N'Dahiliye', 5, N'Cem UZUN', N'Canan ÜSKÜDAR', 30)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (2, N'Ortopedi', 15, N'Koray KISA', N'Gizem BAL', 75)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (3, N'Çocuk', 3, N'Tarık TAŞ', N'Buse KAL', 5)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (4, N'Diş', 27, N'Murat YUVA', N'Erkan KIR', 0)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (5, N'Genel Cerrahi', 4, N'Hilmi DEREN', N'Elif KAR', 120)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (6, N'Acil ', 9, N'Mustafa ASİL', N'Nuran DEMİRYÜREK', 0)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (7, N'Kardiyoloji', 12, N'Kemal DEMİR', N'Makbule TATLI', 25)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (8, N'Çene Cerrahisi', 2, N'Mert DİP', N'Ezgi KAT', 7)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (9, N'Kalp Damar Cerrahisi', 7, N'Ali KOR', N'Büşra TAT', 130)
INSERT [dbo].[Poliklinikler] ([PoliklinikNo], [PoliklinikAdi], [PoliklinikUzmanSayisi], [PoliklinikBasHekimi], [PoliklinikBasHemsiresi], [YatakSayisi]) VALUES (10, N'Kulak Burun Boğaz', 15, N'Sinan KARADAĞ', N'Beste DURU', 5)
SET IDENTITY_INSERT [dbo].[Poliklinikler] OFF
GO
SET IDENTITY_INSERT [dbo].[Receteler] ON 

INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (700, 600, 500, N'Murat GÖK', N'Asprin', N'12.04.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (705, 605, 505, N'Mert AK', N'Parol', N'10.03.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (710, 610, 510, N'Ceren KIRIK', N'Parol', N'19.02.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (715, 615, 515, N'Giray KOL', N'İbrumin Cold', N'17.01.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (720, 640, 540, N'Dursun ŞİMŞEK', N'Asprin', N'17.01.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (725, 645, 545, N'Kadri IŞIK', N'Ator', N'25.02.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (730, 650, 550, N'Cenk DEMİR', N'Asprin', N'19.03.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (735, 660, 555, N'Kerim İZ', N'Parol', N'22.01.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (740, 665, 560, N'Kerem KERİM', N'Asprin', N'13.0.2022')
INSERT [dbo].[Receteler] ([ReceteNo], [HastaNo], [DoktorNo], [HastaAdiSoyadi], [ReceteDetay], [ReceteTarih]) VALUES (745, 670, 565, N'Dilek SAĞIR', N'İbrumin Cold', N'01.04.2022')
SET IDENTITY_INSERT [dbo].[Receteler] OFF
GO
ALTER TABLE [dbo].[Doktorlar]  WITH CHECK ADD  CONSTRAINT [FK_Doktorlar_Poliklinikler] FOREIGN KEY([PoliklinikNo])
REFERENCES [dbo].[Poliklinikler] ([PoliklinikNo])
GO
ALTER TABLE [dbo].[Doktorlar] CHECK CONSTRAINT [FK_Doktorlar_Poliklinikler]
GO
ALTER TABLE [dbo].[Hastalar]  WITH CHECK ADD  CONSTRAINT [FK_Hastalar_Doktorlar] FOREIGN KEY([DoktorNo])
REFERENCES [dbo].[Doktorlar] ([DoktorNo])
GO
ALTER TABLE [dbo].[Hastalar] CHECK CONSTRAINT [FK_Hastalar_Doktorlar]
GO
ALTER TABLE [dbo].[Receteler]  WITH CHECK ADD  CONSTRAINT [FK_Receteler_Hastalar] FOREIGN KEY([HastaNo])
REFERENCES [dbo].[Hastalar] ([HastaNo])
GO
ALTER TABLE [dbo].[Receteler] CHECK CONSTRAINT [FK_Receteler_Hastalar]
GO
USE [master]
GO
ALTER DATABASE [Hastahane] SET  READ_WRITE 
GO
