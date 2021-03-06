USE [master]
GO
/****** Object:  Database [DB_RK_Cosmetics_System]    Script Date: 05-05-2022 11:19:06 ******/
CREATE DATABASE [DB_RK_Cosmetics_System] ON  PRIMARY 
( NAME = N'DB_RK_Cosmetics_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_RK_Cosmetics_System.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_RK_Cosmetics_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DB_RK_Cosmetics_System_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_RK_Cosmetics_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET  MULTI_USER 
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET DB_CHAINING OFF 
GO
USE [DB_RK_Cosmetics_System]
GO
/****** Object:  Table [dbo].[Brand_Details]    Script Date: 05-05-2022 11:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand_Details](
	[Brand_ID] [int] NOT NULL,
	[Brand_Name] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Brand_Details] PRIMARY KEY CLUSTERED 
(
	[Brand_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Basic_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Basic_Details](
	[Customer_Id] [int] NOT NULL,
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Mobile_No] [numeric](10, 0) NOT NULL,
	[Date] [date] NOT NULL,
	[Bill] [money] NOT NULL,
	[Discount] [float] NOT NULL,
	[Final_Bill] [money] NOT NULL,
 CONSTRAINT [PK_Customer_Basic_Details] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Details](
	[Customer_Id] [int] NOT NULL,
	[Brand_Name] [nvarchar](20) NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Per_Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[GST_Applied] [float] NOT NULL,
	[Price] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distributor_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distributor_Details](
	[Distributor_ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Registration_No] [int] NOT NULL,
	[Tie_Up_Date] [date] NOT NULL,
	[Mobile_No] [numeric](10, 0) NOT NULL,
	[Alternate_Mobile_No] [numeric](10, 0) NULL,
	[Aadhar_No] [nvarchar](14) NOT NULL,
	[PAN_No] [nvarchar](14) NOT NULL,
	[Email_ID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Distributor_Details] PRIMARY KEY CLUSTERED 
(
	[Distributor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Details](
	[Employee_ID] [int] NOT NULL,
	[First_Name] [nvarchar](20) NOT NULL,
	[Middle_Name] [nvarchar](20) NOT NULL,
	[Last_Name] [nvarchar](20) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Joining_Date] [date] NOT NULL,
	[Mobile_No] [numeric](10, 0) NOT NULL,
	[Alternate_Mobile_No] [numeric](10, 0) NULL,
	[Aadhar_No] [nvarchar](14) NOT NULL,
	[PAN_No] [nvarchar](14) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Email_ID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee_Details] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expences_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expences_Details](
	[Expences_Id] [int] NOT NULL,
	[Expences_Details] [nvarchar](50) NOT NULL,
	[Amount_Paid] [money] NOT NULL,
	[Date] [date] NOT NULL,
	[Bill_Image] [image] NULL,
	[Paid_By] [nvarchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Details](
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Details](
	[Product_ID] [int] NOT NULL,
	[Brand_Name] [nvarchar](20) NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Purchases_Price] [money] NOT NULL,
	[Selling_Price] [money] NOT NULL,
	[Stock] [int] NOT NULL,
	[Distributor_Name] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[GST] [float] NOT NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Product_Details] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Stock_Details]    Script Date: 05-05-2022 11:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Stock_Details](
	[Product_Id] [int] NOT NULL,
	[Mfg_Date] [date] NOT NULL,
	[Expiry_Date] [date] NOT NULL,
	[Date] [date] NOT NULL,
	[Stock] [int] NOT NULL,
	[Current_Stock] [int] NOT NULL,
	[New_Stock] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product_Stock_Details]  WITH CHECK ADD  CONSTRAINT [FK_Product_Stock_Details_Product_Details] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product_Details] ([Product_ID])
GO
ALTER TABLE [dbo].[Product_Stock_Details] CHECK CONSTRAINT [FK_Product_Stock_Details_Product_Details]
GO
USE [master]
GO
ALTER DATABASE [DB_RK_Cosmetics_System] SET  READ_WRITE 
GO
