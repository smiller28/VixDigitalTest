# VixDigitalTest

To Create the Database please run the following script:

USE [master]
GO

/****** Object:  Database [PollingDB]    Script Date: 13/08/2020 21:11:09 ******/
CREATE DATABASE [PollingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PollingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PollingDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'PollingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PollingDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PollingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PollingDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PollingDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PollingDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PollingDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PollingDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [PollingDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PollingDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PollingDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PollingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PollingDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PollingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PollingDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PollingDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PollingDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PollingDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PollingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PollingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PollingDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PollingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PollingDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PollingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PollingDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PollingDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [PollingDB] SET  MULTI_USER 
GO

ALTER DATABASE [PollingDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PollingDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PollingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PollingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PollingDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PollingDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PollingDB] SET  READ_WRITE 
GO

To create the database tables please run the following scripts:

USE [PollingDB]
GO

/****** Object:  Table [dbo].[Services]    Script Date: 13/08/2020 21:11:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Services]') AND type in (N'U'))
DROP TABLE [dbo].[Services]
GO

/****** Object:  Table [dbo].[Services]    Script Date: 13/08/2020 21:11:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [PollingDB]
GO

/****** Object:  Table [dbo].[ServiceResponse]    Script Date: 13/08/2020 21:12:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServiceResponse]') AND type in (N'U'))
DROP TABLE [dbo].[ServiceResponse]
GO

/****** Object:  Table [dbo].[ServiceResponse]    Script Date: 13/08/2020 21:12:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ServiceResponse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Service] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
	[Server] [nvarchar](max) NULL,
	[MethodType] [nvarchar](50) NULL,
	[ContentType] [nvarchar](50) NULL,
	[ServiceLastModified] [datetime2](7) NULL,
	[LastUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_ServiceResponse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

Will need to amend ConnectionString located in appsettings.json to match details of your own SQL Server.

Nuget Packages Installed:
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.VisualStudio.Web.CodeGeneration.Design
