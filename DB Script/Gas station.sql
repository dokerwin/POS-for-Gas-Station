USE [master]
GO
/****** Object:  Database [Gas station]    Script Date: 1/9/2022 1:08:49 PM ******/
CREATE DATABASE [Gas station]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gas station', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HURTOWNIA\MSSQL\DATA\Gas station.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gas station_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HURTOWNIA\MSSQL\DATA\Gas station_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Gas station] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gas station].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gas station] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gas station] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gas station] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gas station] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gas station] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gas station] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gas station] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gas station] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gas station] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gas station] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gas station] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gas station] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gas station] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gas station] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gas station] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Gas station] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gas station] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gas station] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gas station] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gas station] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gas station] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gas station] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gas station] SET RECOVERY FULL 
GO
ALTER DATABASE [Gas station] SET  MULTI_USER 
GO
ALTER DATABASE [Gas station] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gas station] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gas station] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gas station] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gas station] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gas station] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gas station', N'ON'
GO
ALTER DATABASE [Gas station] SET QUERY_STORE = OFF
GO
USE [Gas station]
GO
/****** Object:  Table [dbo].[Advertising]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertising](
	[AdvertisingID] [int] IDENTITY(1,1) NOT NULL,
	[Adv_Name] [nvarchar](50) NULL,
	[Adv_Start] [datetime] NOT NULL,
	[Adv_End] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdvertisingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Adv_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cashier]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cashier](
	[CashierID] [int] IDENTITY(1,1) NOT NULL,
	[Cashier_Status] [nvarchar](10) NOT NULL,
	[Cashier_login] [nvarchar](10) NOT NULL,
	[Cashier_password] [nvarchar](10) NOT NULL,
	[ID_Person] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CashierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Name] [nvarchar](50) NULL,
	[Cat_Description] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cistern]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cistern](
	[ID_Cistern] [int] IDENTITY(1,1) NOT NULL,
	[ID_Product] [int] NOT NULL,
	[MaxVolume] [decimal](18, 0) NOT NULL,
	[MinVolume] [decimal](18, 0) NOT NULL,
	[ActualVolume] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cistern] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[Company_Name] [nvarchar](100) NOT NULL,
	[Company_Email] [nvarchar](100) NOT NULL,
	[ID_Location] [int] NOT NULL,
	[Company_Phone] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Company_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Company_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[ID_LoyaltyCard] [int] NOT NULL,
	[ID_Person] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developer]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developer](
	[DeveloperID] [int] IDENTITY(1,1) NOT NULL,
	[Dev_Name] [nvarchar](100) NOT NULL,
	[ID_Company] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeveloperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Dev_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distributor]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distributor](
	[DistributorID] [int] IDENTITY(1,1) NOT NULL,
	[Dis_Name] [nvarchar](100) NOT NULL,
	[ID_Company] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DistributorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Dis_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Forecourt]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forecourt](
	[ForecourtID] [int] IDENTITY(1,1) NOT NULL,
	[NozzleAmount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ForecourtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FuelDelivery]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuelDelivery](
	[ID_Delivery] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cistern] [int] NOT NULL,
	[DataDelivery] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Delivery] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Postal_Code] [varchar](6) NOT NULL,
	[Street] [nvarchar](100) NOT NULL,
	[Build] [nvarchar](50) NOT NULL,
	[City] [nvarchar](255) NULL,
	[Country] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoyaltyCard]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoyaltyCard](
	[LoyaltyCardID] [int] IDENTITY(1,1) NOT NULL,
	[ID_MOP] [int] NOT NULL,
	[Amount] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoyaltyCardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOP]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOP](
	[MopID] [int] IDENTITY(1,1) NOT NULL,
	[Mop_Type] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[Person_Name] [nvarchar](50) NOT NULL,
	[Person_Surname] [nvarchar](50) NOT NULL,
	[Person_Sex] [nvarchar](6) NOT NULL,
	[Person_Age] [int] NOT NULL,
	[ID_Location] [int] NOT NULL,
	[Person_Phone] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_Name] [nvarchar](50) NULL,
	[Pro_Description] [nvarchar](100) NULL,
	[ID_Discount] [int] NULL,
	[ID_Developer] [int] NOT NULL,
	[ID_Distributor] [int] NOT NULL,
	[ID_Category] [int] NOT NULL,
	[ID_Type_Product] [int] NOT NULL,
	[Pro_Price] [money] NOT NULL,
	[Pro_LastUpdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductReceipt]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductReceipt](
	[ProductReceiptID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Receipt] [int] NOT NULL,
	[ID_Product] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[PromotionID] [int] IDENTITY(1,1) NOT NULL,
	[Prom_Start] [datetime] NOT NULL,
	[Prom_End] [datetime] NOT NULL,
	[Prom_Type] [nvarchar](50) NULL,
	[Prom_Discount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[ReceiptID] [int] IDENTITY(1,1) NOT NULL,
	[DealTime] [datetime] NOT NULL,
	[Receipt_Price] [money] NOT NULL,
	[ID_Shift] [int] NOT NULL,
	[Number_Product] [int] NOT NULL,
	[ID_Customer] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shift]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift](
	[ShiftID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cashier] [int] NOT NULL,
	[ID_Station] [int] NOT NULL,
	[ShiftStart] [datetime] NOT NULL,
	[ShiftEnd] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[StationID] [int] IDENTITY(1,1) NOT NULL,
	[Station_Name] [nvarchar](50) NOT NULL,
	[ID_Location] [int] NOT NULL,
	[ID_Forecourt] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Station_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Product]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Product](
	[Type_ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Units] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Type_ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Units] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cashier]  WITH CHECK ADD  CONSTRAINT [FK_CashierPerson] FOREIGN KEY([ID_Person])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Cashier] CHECK CONSTRAINT [FK_CashierPerson]
GO
ALTER TABLE [dbo].[Cistern]  WITH CHECK ADD  CONSTRAINT [FK_CisternProduct] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Cistern] CHECK CONSTRAINT [FK_CisternProduct]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_CompanyLocation] FOREIGN KEY([ID_Location])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_CompanyLocation]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_CustomerLoyaltyCard] FOREIGN KEY([ID_LoyaltyCard])
REFERENCES [dbo].[LoyaltyCard] ([LoyaltyCardID])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_CustomerLoyaltyCard]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPerson] FOREIGN KEY([ID_Person])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_CustomerPerson]
GO
ALTER TABLE [dbo].[Developer]  WITH CHECK ADD  CONSTRAINT [FK_DeveloperCompany] FOREIGN KEY([ID_Company])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Developer] CHECK CONSTRAINT [FK_DeveloperCompany]
GO
ALTER TABLE [dbo].[Distributor]  WITH CHECK ADD  CONSTRAINT [FK_DistibutorCompany] FOREIGN KEY([ID_Company])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Distributor] CHECK CONSTRAINT [FK_DistibutorCompany]
GO
ALTER TABLE [dbo].[FuelDelivery]  WITH CHECK ADD  CONSTRAINT [FK_DeliveyCistern] FOREIGN KEY([ID_Cistern])
REFERENCES [dbo].[Cistern] ([ID_Cistern])
GO
ALTER TABLE [dbo].[FuelDelivery] CHECK CONSTRAINT [FK_DeliveyCistern]
GO
ALTER TABLE [dbo].[LoyaltyCard]  WITH CHECK ADD  CONSTRAINT [FK_MOP] FOREIGN KEY([ID_MOP])
REFERENCES [dbo].[MOP] ([MopID])
GO
ALTER TABLE [dbo].[LoyaltyCard] CHECK CONSTRAINT [FK_MOP]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_PersonLocation] FOREIGN KEY([ID_Location])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_PersonLocation]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategorey] FOREIGN KEY([ID_Category])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductCategorey]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductDeveloper] FOREIGN KEY([ID_Developer])
REFERENCES [dbo].[Developer] ([DeveloperID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductDeveloper]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductDistributor] FOREIGN KEY([ID_Distributor])
REFERENCES [dbo].[Distributor] ([DistributorID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductDistributor]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductPromotion] FOREIGN KEY([ID_Discount])
REFERENCES [dbo].[Promotion] ([PromotionID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductPromotion]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductType] FOREIGN KEY([ID_Type_Product])
REFERENCES [dbo].[Type_Product] ([Type_ProductID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductType]
GO
ALTER TABLE [dbo].[ProductReceipt]  WITH CHECK ADD  CONSTRAINT [FK_ProductReceipt] FOREIGN KEY([ID_Receipt])
REFERENCES [dbo].[Receipt] ([ReceiptID])
GO
ALTER TABLE [dbo].[ProductReceipt] CHECK CONSTRAINT [FK_ProductReceipt]
GO
ALTER TABLE [dbo].[ProductReceipt]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptProduct] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ProductReceipt] CHECK CONSTRAINT [FK_ReceiptProduct]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptShift] FOREIGN KEY([ID_Shift])
REFERENCES [dbo].[Shift] ([ShiftID])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_ReceiptShift]
GO
ALTER TABLE [dbo].[Shift]  WITH CHECK ADD  CONSTRAINT [FK_ShiftCashier] FOREIGN KEY([ID_Cashier])
REFERENCES [dbo].[Cashier] ([CashierID])
GO
ALTER TABLE [dbo].[Shift] CHECK CONSTRAINT [FK_ShiftCashier]
GO
ALTER TABLE [dbo].[Shift]  WITH CHECK ADD  CONSTRAINT [FK_ShiftStation] FOREIGN KEY([ID_Station])
REFERENCES [dbo].[Station] ([StationID])
GO
ALTER TABLE [dbo].[Shift] CHECK CONSTRAINT [FK_ShiftStation]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_StationForecourt] FOREIGN KEY([ID_Forecourt])
REFERENCES [dbo].[Forecourt] ([ForecourtID])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_StationForecourt]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_StationLocation] FOREIGN KEY([ID_Location])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_StationLocation]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD CHECK  (([Postal_Code] like '[0-9][0-9][-][0-9][0-9][0-9]'))
GO
USE [master]
GO
ALTER DATABASE [Gas station] SET  READ_WRITE 
GO
