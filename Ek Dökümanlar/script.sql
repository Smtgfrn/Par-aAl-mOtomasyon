USE [master]
GO
/****** Object:  Database [YazılımSınamaProje]    Script Date: 25.12.2018 22:18:00 ******/
CREATE DATABASE [YazılımSınamaProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YazılımSınamaProje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\YazılımSınamaProje.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YazılımSınamaProje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\YazılımSınamaProje_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YazılımSınamaProje] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YazılımSınamaProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YazılımSınamaProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YazılımSınamaProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YazılımSınamaProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YazılımSınamaProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YazılımSınamaProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YazılımSınamaProje] SET  MULTI_USER 
GO
ALTER DATABASE [YazılımSınamaProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YazılımSınamaProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YazılımSınamaProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YazılımSınamaProje] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YazılımSınamaProje] SET DELAYED_DURABILITY = DISABLED 
GO
USE [YazılımSınamaProje]
GO
/****** Object:  Table [dbo].[Atık_Kontrol]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atık_Kontrol](
	[atıkid] [int] IDENTITY(1,1) NOT NULL,
	[zimmetid] [int] NOT NULL,
	[adet] [int] NOT NULL,
 CONSTRAINT [PK_Atık_Kontrol] PRIMARY KEY CLUSTERED 
(
	[atıkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bölüm]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bölüm](
	[bölümid] [int] IDENTITY(1,1) NOT NULL,
	[bölüm] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bölüm] PRIMARY KEY CLUSTERED 
(
	[bölümid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[kategoriid] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdı] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[kategoriid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanıcı_Tipi]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcı_Tipi](
	[KullanıcıTipid] [int] IDENTITY(1,1) NOT NULL,
	[bölümid] [int] NOT NULL,
	[KullanıcıTipi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanıcı_Tipi] PRIMARY KEY CLUSTERED 
(
	[KullanıcıTipid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[kullanıcıid] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıTipid] [int] NOT NULL,
	[KullanıcıAdı] [nvarchar](50) NULL,
	[Şifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[kullanıcıid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[personelid] [int] IDENTITY(1,1) NOT NULL,
	[bölümid] [int] NOT NULL,
	[adı] [nvarchar](50) NULL,
	[soyadı] [nvarchar](50) NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[personelid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[urunid] [int] IDENTITY(1,1) NOT NULL,
	[kategoriid] [int] NOT NULL,
	[UrunAdı] [nvarchar](50) NULL,
	[UrunBirimFiyatı] [money] NOT NULL,
	[SatınAlmaTarihi] [nvarchar](20) NULL,
	[Firma] [nvarchar](50) NULL,
	[Adet] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[urunid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zimmet]    Script Date: 25.12.2018 22:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zimmet](
	[zimmetid] [int] IDENTITY(1,1) NOT NULL,
	[urunid] [int] NOT NULL,
	[personelid] [int] NOT NULL,
	[adet] [int] NOT NULL,
 CONSTRAINT [PK_Zimmet] PRIMARY KEY CLUSTERED 
(
	[zimmetid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Atık_Kontrol]  WITH CHECK ADD  CONSTRAINT [FK_Atık_Kontrol_Zimmet] FOREIGN KEY([zimmetid])
REFERENCES [dbo].[Zimmet] ([zimmetid])
GO
ALTER TABLE [dbo].[Atık_Kontrol] CHECK CONSTRAINT [FK_Atık_Kontrol_Zimmet]
GO
ALTER TABLE [dbo].[Kullanıcı_Tipi]  WITH CHECK ADD  CONSTRAINT [FK_Kullanıcı_Tipi_Bölüm] FOREIGN KEY([bölümid])
REFERENCES [dbo].[Bölüm] ([bölümid])
GO
ALTER TABLE [dbo].[Kullanıcı_Tipi] CHECK CONSTRAINT [FK_Kullanıcı_Tipi_Bölüm]
GO
ALTER TABLE [dbo].[Kullanıcılar]  WITH CHECK ADD  CONSTRAINT [FK_Kullanıcılar_Kullanıcı_Tipi] FOREIGN KEY([KullanıcıTipid])
REFERENCES [dbo].[Kullanıcı_Tipi] ([KullanıcıTipid])
GO
ALTER TABLE [dbo].[Kullanıcılar] CHECK CONSTRAINT [FK_Kullanıcılar_Kullanıcı_Tipi]
GO
ALTER TABLE [dbo].[Personeller]  WITH CHECK ADD  CONSTRAINT [FK_Personeller_Bölüm] FOREIGN KEY([bölümid])
REFERENCES [dbo].[Bölüm] ([bölümid])
GO
ALTER TABLE [dbo].[Personeller] CHECK CONSTRAINT [FK_Personeller_Bölüm]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler] FOREIGN KEY([kategoriid])
REFERENCES [dbo].[Kategoriler] ([kategoriid])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler]
GO
ALTER TABLE [dbo].[Zimmet]  WITH CHECK ADD  CONSTRAINT [FK_Zimmet_Personeller] FOREIGN KEY([personelid])
REFERENCES [dbo].[Personeller] ([personelid])
GO
ALTER TABLE [dbo].[Zimmet] CHECK CONSTRAINT [FK_Zimmet_Personeller]
GO
ALTER TABLE [dbo].[Zimmet]  WITH CHECK ADD  CONSTRAINT [FK_Zimmet_Urunler] FOREIGN KEY([urunid])
REFERENCES [dbo].[Urunler] ([urunid])
GO
ALTER TABLE [dbo].[Zimmet] CHECK CONSTRAINT [FK_Zimmet_Urunler]
GO
USE [master]
GO
ALTER DATABASE [YazılımSınamaProje] SET  READ_WRITE 
GO
