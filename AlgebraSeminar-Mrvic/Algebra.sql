USE [master]
GO
/****** Object:  Database [Algebra]    Script Date: 27.2.2021. 13:30:37 ******/
CREATE DATABASE [Algebra]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Algebra', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Algebra.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Algebra_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Algebra_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Algebra] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Algebra].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Algebra] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Algebra] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Algebra] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Algebra] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Algebra] SET ARITHABORT OFF 
GO
ALTER DATABASE [Algebra] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Algebra] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Algebra] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Algebra] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Algebra] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Algebra] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Algebra] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Algebra] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Algebra] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Algebra] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Algebra] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Algebra] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Algebra] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Algebra] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Algebra] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Algebra] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Algebra] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Algebra] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Algebra] SET  MULTI_USER 
GO
ALTER DATABASE [Algebra] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Algebra] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Algebra] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Algebra] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Algebra] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Algebra] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Algebra] SET QUERY_STORE = OFF
GO
USE [Algebra]
GO
/****** Object:  Table [dbo].[Predbiljezba]    Script Date: 27.2.2021. 13:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predbiljezba](
	[IdPredbiljezba] [int] IDENTITY(1,1) NOT NULL,
	[Datum] [date] NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Adresa] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefon] [int] NOT NULL,
	[IdSeminar] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Predbiljezba] PRIMARY KEY CLUSTERED 
(
	[IdPredbiljezba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seminar]    Script Date: 27.2.2021. 13:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seminar](
	[IdSeminar] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](50) NOT NULL,
	[Datum] [date] NOT NULL,
	[Popunjen] [bit] NOT NULL,
	[Predavac] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Seminar] PRIMARY KEY CLUSTERED 
(
	[IdSeminar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposlenik]    Script Date: 27.2.2021. 13:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposlenik](
	[IdZaposlenik] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[KorisnickoIme] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Zaposlenik] PRIMARY KEY CLUSTERED 
(
	[IdZaposlenik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Predbiljezba] ON 

INSERT [dbo].[Predbiljezba] ([IdPredbiljezba], [Datum], [Ime], [Prezime], [Adresa], [Email], [Telefon], [IdSeminar], [Status]) VALUES (1, CAST(N'2021-02-15' AS Date), N'Petar', N'Peric', N'Sisacka', N'test@test.hr', 12345, 1, 1)
INSERT [dbo].[Predbiljezba] ([IdPredbiljezba], [Datum], [Ime], [Prezime], [Adresa], [Email], [Telefon], [IdSeminar], [Status]) VALUES (2, CAST(N'2015-02-25' AS Date), N'Maric', N'Markovic', N'Valpovacka', N'test2@test2.hr', 4615, 2, 0)
INSERT [dbo].[Predbiljezba] ([IdPredbiljezba], [Datum], [Ime], [Prezime], [Adresa], [Email], [Telefon], [IdSeminar], [Status]) VALUES (3, CAST(N'2021-02-11' AS Date), N'Jura', N'Jurkovic', N'Slunjska', N'test3@test3', 12356, 3, 0)
INSERT [dbo].[Predbiljezba] ([IdPredbiljezba], [Datum], [Ime], [Prezime], [Adresa], [Email], [Telefon], [IdSeminar], [Status]) VALUES (4, CAST(N'2021-02-10' AS Date), N'Jovo', N'Jovic', N'Slatinska', N'test4@test4', 135, 2, 0)
SET IDENTITY_INSERT [dbo].[Predbiljezba] OFF
GO
SET IDENTITY_INSERT [dbo].[Seminar] ON 

INSERT [dbo].[Seminar] ([IdSeminar], [Naziv], [Opis], [Datum], [Popunjen], [Predavac]) VALUES (1, N'c#', N'Programiranje c#', CAST(N'2021-02-11' AS Date), 1, N'Predrag Mrvic')
INSERT [dbo].[Seminar] ([IdSeminar], [Naziv], [Opis], [Datum], [Popunjen], [Predavac]) VALUES (2, N'Java', N'Programiranje Java', CAST(N'2021-02-10' AS Date), 0, N'Josip Milanovic')
INSERT [dbo].[Seminar] ([IdSeminar], [Naziv], [Opis], [Datum], [Popunjen], [Predavac]) VALUES (3, N'ASP.Net', N'WEB programiranje', CAST(N'2021-02-17' AS Date), 1, N'Zvonimir Boban')
INSERT [dbo].[Seminar] ([IdSeminar], [Naziv], [Opis], [Datum], [Popunjen], [Predavac]) VALUES (4, N'Java', N'Programiranje u Javi', CAST(N'2021-02-25' AS Date), 1, N'Boris Boris')
SET IDENTITY_INSERT [dbo].[Seminar] OFF
GO
ALTER TABLE [dbo].[Predbiljezba]  WITH CHECK ADD  CONSTRAINT [FK_Predbiljezba_Seminar] FOREIGN KEY([IdSeminar])
REFERENCES [dbo].[Seminar] ([IdSeminar])
GO
ALTER TABLE [dbo].[Predbiljezba] CHECK CONSTRAINT [FK_Predbiljezba_Seminar]
GO
USE [master]
GO
ALTER DATABASE [Algebra] SET  READ_WRITE 
GO
