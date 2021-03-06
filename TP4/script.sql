USE [master]
GO
/****** Object:  Database [TP4-DangeloTomas-Competencia]    Script Date: 22/11/2021 17:13:03 ******/
CREATE DATABASE [TP4-DangeloTomas-Competencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Competencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Competencia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Competencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Competencia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4-DangeloTomas-Competencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET  MULTI_USER 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4-DangeloTomas-Competencia', N'ON'
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET QUERY_STORE = OFF
GO
USE [TP4-DangeloTomas-Competencia]
GO
/****** Object:  Table [dbo].[juegos]    Script Date: 22/11/2021 17:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[juegos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[juego] [varchar](50) NOT NULL,
	[rojos] [int] NULL,
	[verdes] [int] NULL,
	[puntos] [int] NULL,
	[tiempo] [float] NULL,
	[ganador] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[juegos] ON 

INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (2, N'Ajedrez', 1, 1, 100, 60, N'Verde')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (3, N'Ajedrez', 1, 1, 100, 60, N'Verde')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (4, N'Ajedrez', 1, 1, 100, 60, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (8, N'Carrera', 8, 8, 260, 16.7, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (7, N'Carrera', 10, 10, 255, 2.5, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (9, N'Quemados', 15, 15, 360, 28.9, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (10, N'Quemados', 26, 26, 600, 28.4, N'Verde')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (11, N'Quemados', 10, 10, 200, 15.6, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (12, N'Quemados', 12, 13, 230, 19, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (13, N'Ajedrez', 1, 1, 100, 60, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (14, N'Ajedrez', 1, 1, 100, 60, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (15, N'Ajedrez', 1, 1, 100, 60, N'Verde')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (16, N'Ajedrez', 1, 1, 100, 60, N'Rojo')
INSERT [dbo].[juegos] ([codigo], [juego], [rojos], [verdes], [puntos], [tiempo], [ganador]) VALUES (1, N'Ajedrez', 1, 1, 100, 60, N'Rojo')
SET IDENTITY_INSERT [dbo].[juegos] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4-DangeloTomas-Competencia] SET  READ_WRITE 
GO
