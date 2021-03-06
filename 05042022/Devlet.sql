USE [master]
GO
/****** Object:  Database [Devlet]    Script Date: 5.04.2022 18:29:38 ******/
CREATE DATABASE [Devlet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Devlet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Devlet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Devlet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Devlet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Devlet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Devlet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Devlet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Devlet] SET ARITHABORT OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Devlet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Devlet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Devlet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Devlet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Devlet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Devlet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Devlet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Devlet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Devlet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Devlet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Devlet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Devlet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Devlet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Devlet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Devlet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Devlet] SET  MULTI_USER 
GO
ALTER DATABASE [Devlet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Devlet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Devlet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Devlet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Devlet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Devlet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Devlet] SET QUERY_STORE = OFF
GO
USE [Devlet]
GO
/****** Object:  Table [dbo].[Nufus]    Script Date: 5.04.2022 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nufus](
	[VatandasNo] [int] NOT NULL,
	[AileSiraNo] [int] NULL,
	[CiltNo] [int] NULL,
	[SeriNo] [char](9) NULL,
	[KutukNo] [varchar](50) NULL,
	[MedeniHal] [varchar](50) NULL,
	[KanGrubu] [varchar](50) NULL,
 CONSTRAINT [PK_Nufus] PRIMARY KEY CLUSTERED 
(
	[VatandasNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tapular]    Script Date: 5.04.2022 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tapular](
	[TapuNo] [int] NOT NULL,
	[ParselNo] [int] NULL,
	[AdaNo] [int] NULL,
	[KonumAdi] [varchar](50) NULL,
	[VergiSicilNo] [int] NULL,
 CONSTRAINT [PK_Tapular] PRIMARY KEY CLUSTERED 
(
	[TapuNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vatandaslar]    Script Date: 5.04.2022 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vatandaslar](
	[VatandasNo] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NOT NULL,
	[Yas] [int] NOT NULL,
	[Telefon] [char](11) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vatandaslar] PRIMARY KEY CLUSTERED 
(
	[VatandasNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vergiler]    Script Date: 5.04.2022 18:29:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vergiler](
	[VergiSicilNo] [int] NOT NULL,
	[VergiAdi] [varchar](50) NULL,
	[vNo] [int] NULL,
	[VergiAraci] [varchar](50) NULL,
	[VergiDairesi] [varchar](50) NULL,
 CONSTRAINT [PK_Vergiler] PRIMARY KEY CLUSTERED 
(
	[VergiSicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Nufus] ([VatandasNo], [AileSiraNo], [CiltNo], [SeriNo], [KutukNo], [MedeniHal], [KanGrubu]) VALUES (1, 5465, 546546, N'asdasd   ', N'asdasd', N'asdasd', N'asdasddsf')
INSERT [dbo].[Nufus] ([VatandasNo], [AileSiraNo], [CiltNo], [SeriNo], [KutukNo], [MedeniHal], [KanGrubu]) VALUES (2, 8979, 54654, N'assdas   ', N'asdas', N'dasdas', N'asdasd')
INSERT [dbo].[Nufus] ([VatandasNo], [AileSiraNo], [CiltNo], [SeriNo], [KutukNo], [MedeniHal], [KanGrubu]) VALUES (3, 5456, 4564, N'asdasd   ', N'asda456', N'546das', N'fasdas')
GO
SET IDENTITY_INSERT [dbo].[Vatandaslar] ON 

INSERT [dbo].[Vatandaslar] ([VatandasNo], [AdSoyad], [Yas], [Telefon], [Mail]) VALUES (1, N'ibrahim zengin', 29, N'05556057152', N'zenginibrahim@gmail.com')
INSERT [dbo].[Vatandaslar] ([VatandasNo], [AdSoyad], [Yas], [Telefon], [Mail]) VALUES (2, N'behinur', 26, N'0545423132 ', N'bakjsdhaks@gmail.com')
INSERT [dbo].[Vatandaslar] ([VatandasNo], [AdSoyad], [Yas], [Telefon], [Mail]) VALUES (3, N'Özgür leş', 41, N'321534     ', N'2a1dasd@gmail.com')
SET IDENTITY_INSERT [dbo].[Vatandaslar] OFF
GO
ALTER TABLE [dbo].[Nufus]  WITH CHECK ADD  CONSTRAINT [FK_Nufus_Vatandaslar] FOREIGN KEY([VatandasNo])
REFERENCES [dbo].[Vatandaslar] ([VatandasNo])
GO
ALTER TABLE [dbo].[Nufus] CHECK CONSTRAINT [FK_Nufus_Vatandaslar]
GO
ALTER TABLE [dbo].[Tapular]  WITH CHECK ADD  CONSTRAINT [FK_Tapular_Vergiler] FOREIGN KEY([VergiSicilNo])
REFERENCES [dbo].[Vergiler] ([VergiSicilNo])
GO
ALTER TABLE [dbo].[Tapular] CHECK CONSTRAINT [FK_Tapular_Vergiler]
GO
ALTER TABLE [dbo].[Vergiler]  WITH CHECK ADD  CONSTRAINT [FK_Vergiler_Nufus] FOREIGN KEY([vNo])
REFERENCES [dbo].[Nufus] ([VatandasNo])
GO
ALTER TABLE [dbo].[Vergiler] CHECK CONSTRAINT [FK_Vergiler_Nufus]
GO
USE [master]
GO
ALTER DATABASE [Devlet] SET  READ_WRITE 
GO
