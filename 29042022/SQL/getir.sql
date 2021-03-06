USE [master]
GO
/****** Object:  Database [getir]    Script Date: 27.02.2022 20:59:41 ******/
CREATE DATABASE [getir]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'getir', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\getir.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'getir_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\getir_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [getir] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [getir].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [getir] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [getir] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [getir] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [getir] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [getir] SET ARITHABORT OFF 
GO
ALTER DATABASE [getir] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [getir] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [getir] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [getir] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [getir] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [getir] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [getir] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [getir] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [getir] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [getir] SET  DISABLE_BROKER 
GO
ALTER DATABASE [getir] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [getir] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [getir] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [getir] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [getir] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [getir] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [getir] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [getir] SET RECOVERY FULL 
GO
ALTER DATABASE [getir] SET  MULTI_USER 
GO
ALTER DATABASE [getir] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [getir] SET DB_CHAINING OFF 
GO
ALTER DATABASE [getir] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [getir] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [getir] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [getir] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'getir', N'ON'
GO
ALTER DATABASE [getir] SET QUERY_STORE = OFF
GO
USE [getir]
GO
/****** Object:  Table [dbo].[PersonelBilgi]    Script Date: 27.02.2022 20:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelBilgi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [varchar](50) NULL,
 CONSTRAINT [PK_PersonelBilgi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PersonelBilgi] ON 

INSERT [dbo].[PersonelBilgi] ([ID], [PersonelAdi]) VALUES (1, N'selami uzun')
INSERT [dbo].[PersonelBilgi] ([ID], [PersonelAdi]) VALUES (2, N'yaşar sanen')
SET IDENTITY_INSERT [dbo].[PersonelBilgi] OFF
GO
/****** Object:  StoredProcedure [dbo].[Listele]    Script Date: 27.02.2022 20:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Listele]
as
select * from PersonelBilgi
GO
/****** Object:  StoredProcedure [dbo].[PersonelEkle]    Script Date: 27.02.2022 20:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelEkle]
@PersonelAdi varchar(50)

As
insert into PersonelBilgi (PersonelAdi) values (@PersonelAdi)

GO
/****** Object:  StoredProcedure [dbo].[PersonelGuncelle]    Script Date: 27.02.2022 20:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PersonelGuncelle]
@ID int,
@PersonelAdi varchar(50)

as
update PersonelBilgi set PersonelAdi=@PersonelAdi
where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[PersonelSilme]    Script Date: 27.02.2022 20:59:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PersonelSilme]
@ID int
as
delete from PersonelBilgi where ID=@ID
GO
USE [master]
GO
ALTER DATABASE [getir] SET  READ_WRITE 
GO
