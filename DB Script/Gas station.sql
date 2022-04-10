
--Drop database Gas_station 
--go
create database Gas_station
GO
USE [Gas_station]
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



/****** Object:  Table [dbo].[ProductReceipt]    Script Date: 1/9/2022 1:08:49 PM ******/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tax](
	[TaxID] [int] IDENTITY(1,1) NOT NULL,
	[Vat] [float] NOT NULL,
    [Value1] [float] NULL,
    [Value2] [float] NULL,
    [Value3] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TaxID] ASC
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
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[IDCard]  [nvarchar](20) NOT NULL,
	[Sex] [nvarchar](6) NOT NULL,
	[Age] [int] NOT NULL,
	[Phone1] [nvarchar](12) NULL,
	[Phone2] [nvarchar](12) NULL,
	[Email1] [nvarchar](100) NOT NULL,
	[Email2] [nvarchar](100) NULL,
	[Adress_country]   [nvarchar](100) NOT NULL,
	[Adress_city] [nvarchar](100) NOT NULL,
	[Adress_street] [nvarchar](100) NOT NULL,
	[Adress_level] [nvarchar](100)     NULL,
	[Adress_build] [nvarchar](100) NOT NULL,
	[Adress_zip] [nvarchar](100) NOT NULL,
	[Fax]   [nvarchar](100) NOT NULL
PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[EmPosition]    Script Date: 1/9/2022 1:08:49 PM ******/
CREATE TABLE [dbo].[EmPosition](
	[EmPositionID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[Position] [nvarchar](100) NOT NULL,
	[Additional] [nvarchar](100)  NULL
	)

/****** Object:  Table [dbo].[Cashier]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfEmployment](
	[TypeOfEmploymentID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Type] [nvarchar](100) NOT NULL
)



/****** Object:  Table [dbo].[Company]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[KRS]   [nvarchar](10) NOT NULL,
	[REGON]   [nvarchar](100) NOT NULL,
	[NIP]   [nvarchar](100) NOT NULL,
	[Email1] [nvarchar](100) NOT NULL,
	[Email2] [nvarchar](100) NULL,
	[Adress_country]   [nvarchar](100) NOT NULL,
	[Adress_city] [nvarchar](100) NOT NULL,
	[Adress_street] [nvarchar](100) NOT NULL,
	[Adress_level] [nvarchar](100)     NULL,
	[Adress_build] [nvarchar](100) NOT NULL,
	[Adress_zip] [nvarchar](100) NOT NULL,
	[Fax]   [nvarchar](100) NOT NULL,
	[Phone1] [nvarchar](50) NOT NULL,
	[Phone2] [nvarchar](50) NULL,
	[WWW] [nvarchar](50) NULL,
	[RegisterDate] [Date] NOT NULL,
	[Additional1] [nvarchar](50)  NULL,
	[Additional2] [nvarchar](50)  NULL,
	
PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
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
	[Name] [nvarchar](100) NOT NULL,
	[ID_Company] [int] NOT NULL,
	CONSTRAINT FK_DeveloperCompany FOREIGN KEY (ID_Company)
    REFERENCES Company (CompanyID),
PRIMARY KEY CLUSTERED 
(
	[DeveloperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
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
	[Name] [nvarchar](100) NOT NULL,
	[ID_Company] [int] NOT NULL,
	CONSTRAINT FK_DistributorCompany FOREIGN KEY (ID_Company)
    REFERENCES Company (CompanyID),
PRIMARY KEY CLUSTERED 
(
	[DistributorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
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


/****** Object:  Table [dbo].[MOP]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOP](
	[MopID] [int] IDENTITY(1,1) NOT NULL,
	[Mop_Type] [nvarchar](10) NOT NULL,
	[Currency] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MopID] ASC
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
	[Balance] [Money] NOT NULL,
	CONSTRAINT FK_LoyaltyCardMOP FOREIGN KEY (ID_MOP)
    REFERENCES MOP (MopID),
PRIMARY KEY CLUSTERED 
(
	[LoyaltyCardID] ASC
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
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[CatPromotion]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatPromotion](
	[PromotionID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Category] [int] NULL,
	[Prom_start] [datetime] NOT NULL,
	[Prom_end] [datetime] NOT NULL,
	[Prom_type] [nvarchar](50) NULL,
	[Prom_discount] [int] NOT NULL,
	CONSTRAINT FK_CatPromotionProduct FOREIGN KEY (ID_Category)
    REFERENCES Category (CategoryID),
    PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC
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
	[Units] [nvarchar](20) NOT NULL,
	[Type1] [nvarchar](20) NULL,
	[Type2] [nvarchar](20)NULL,
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



/****** Object:  Table [dbo].[ProductHistory]    Script Date: 1/9/2022 1:08:49 PM ******/
CREATE TABLE [dbo].[ProductHistory]
(
    [ProductID] [int]   NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Short_name] [nvarchar](20) NULL,
	[Description] [nvarchar](100) NULL,
	[Description1] [nvarchar](100) NULL,
	[ID_Developer] [int] NOT NULL,
	[ID_TAX] [int] NOT NULL,
	[ID_Distributor] [int] NOT NULL,
	[ID_Category] [int] NOT NULL,
	[ID_Type_Product] [int] NOT NULL,
	[List_price] [money] NOT NULL,
	[Stock_price] [money] NOT NULL,
	[StandartPrice] [money] NOT NULL,
	[SellStartDate] [datetime] NULL,
	[SellEndDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[QT_InStock] [float] NULL,
	[IsActive] [BIT] NOT NULL,
	[Restriction_age] [BIT] NOT NULL,
    [SysStartTime] DATETIME2 NOT NULL,
    [SysEndTime] DATETIME2 NOT NULL
);
GO

CREATE CLUSTERED COLUMNSTORE INDEX IX_ProductHistory
    ON ProductHistory;
CREATE NONCLUSTERED INDEX IX_ProductHistory_ID_PERIOD_COLUMNS
    ON ProductHistory (SysEndTime, SysStartTime, ProductID);
GO




/****** Object:  Table [dbo].[Product]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NULL,
	[Short_name] [nvarchar](20) NULL,
	[Description] [nvarchar](100) NULL,
	[Description1] [nvarchar](100) NULL,
	[ID_Developer] [int] NOT NULL,
	[ID_TAX] [int] NOT NULL,
	[ID_Distributor] [int] NOT NULL,
	[ID_Category] [int] NOT NULL,
	[ID_Type_Product] [int] NOT NULL,
	[List_price] [money] NOT NULL,
	[Stock_price] [money] NOT NULL,
	[StandartPrice] [money] NOT NULL,
	[SellStartDate] [datetime] NULL,
	[SellEndDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[QT_InStock] [float] NULL,
	[IsActive] [BIT] NOT NULL,
	[Restriction_age] [BIT] NOT NULL,
    [SysStartTime] DATETIME2 GENERATED ALWAYS AS ROW START NOT NULL,
    [SysEndTime] DATETIME2 GENERATED ALWAYS AS ROW END NOT NULL,
    PERIOD FOR SYSTEM_TIME (SysStartTime,SysEndTime),
	CONSTRAINT FK_ProductDeveloper FOREIGN KEY (ID_Developer)
    REFERENCES Developer (DeveloperID),

    CONSTRAINT FK_ProductTAX FOREIGN KEY (ID_TAX)
    REFERENCES Tax (TaxID),

	CONSTRAINT FK_ProductDistributor FOREIGN KEY (ID_Developer)
    REFERENCES Distributor (DistributorID),
	CONSTRAINT FK_ProductCategory FOREIGN KEY (ID_Category)
    REFERENCES Category (CategoryID),
	CONSTRAINT FK_ProductTypeProduct FOREIGN KEY (ID_Type_Product)
    REFERENCES Type_Product (Type_ProductID)
	)
	WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.ProductHistory));


/****** Object:  Table [dbo].[ProdPromotion]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdPromotion](
	[PromotionID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Product] [int] NULL,
	[Prom_start] [datetime] NOT NULL,
	[Prom_end] [datetime] NOT NULL,
	[Prom_type] [nvarchar](50) NULL,
	[Prom_discount] [int] NOT NULL,
	CONSTRAINT FK_ProdPromotionProduct FOREIGN KEY (ID_Product)
    REFERENCES Product (ProductID),
PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC
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
	[ID_Forecourt] [int] NOT NULL,
	[Email1] [nvarchar](100) NOT NULL,
	[Email2] [nvarchar](100) NULL,
	[Adress_country]   [nvarchar](100) NOT NULL,
	[Adress_city] [nvarchar](100) NOT NULL,
	[Adress_street] [nvarchar](100) NOT NULL,
	[Adress_build] [nvarchar](100) NOT NULL,
	[Adress_zip] [nvarchar](100) NOT NULL,
	[Fax]   [nvarchar](100) NOT NULL,
	[Phone1] [nvarchar](50) NOT NULL,
	[Phone2] [nvarchar](50) NULL,
	[WWW] [nvarchar](50) NULL,
	CONSTRAINT FK_StationForecourt FOREIGN KEY (ID_Forecourt)
    REFERENCES Forecourt (ForecourtID),
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

/****** Object:  Table [dbo].[Staff]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_Station] [int]  NOT NULL,
	[Type_of_staff] [nvarchar](20) NOT NULL,
	CONSTRAINT FK_StaffStation FOREIGN KEY (ID_Station)
    REFERENCES Station(StationID)
)


/****** Object:  Table [dbo].[Cashier]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cashier](
	[CashierID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[PESEL] [nvarchar](10) NOT NULL,
	[Salary] [money] NOT NULL,
	[Hire_date] [Date] NOT NULL,
	[Fire_date] [Date]NULL,
	[ID_Type_of_employment] [int] NOT NULL,
	[Work_email] [nvarchar](100) NOT NULL,
	[Work_phone] [nvarchar](100) NOT NULL,
	[ID_Person] [int]  NOT NULL,
	[IDEmPosition] [int] Not null,
	[Id_Staff][int] Not null,

	CONSTRAINT FK_CashierTypeEmployment FOREIGN KEY (ID_Type_of_employment)
    REFERENCES TypeOfEmployment(TypeOfEmploymentID),

	CONSTRAINT FK_CashierPerson FOREIGN KEY (ID_Person)
    REFERENCES Person(PersonID),

	CONSTRAINT FK_CashierEmPostion FOREIGN KEY (IDEmPosition)
    REFERENCES EmPosition(EmPositionID),

    CONSTRAINT FK_CashierStuff FOREIGN KEY (ID_Staff)
    REFERENCES Staff(StaffID)
)


/****** Object:  Table [dbo].[Login]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[ID_Cashier] [int] NOT NULL,
	[Login] [nvarchar](10) NOT NULL,
	[Last_login] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Last_Password] [nvarchar](10) NOT NULL
	CONSTRAINT FK_LoginCashier FOREIGN KEY (ID_Cashier)
    REFERENCES Cashier (CashierID)
	)


/****** Object:  Table [dbo].[StationConfiguration]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StationSettings](
	[SettingID] [int] IDENTITY(1,1) NOT NULL,
	[AEOD] [Datetime] NULL,
	[ID_Station] [int] NOT NULL,
	CONSTRAINT FK_StationSettingsStation FOREIGN KEY (ID_Station)
    REFERENCES Station (StationID)
)
GO


/****** Object:  Table [dbo].[Shift]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift](
	[ShiftID]      [int] IDENTITY(1,1) NOT NULL,
	[ID_Cashier]   [int]      NOT NULL,
	[ID_Station]   [int]      NOT NULL,
	[Shift_start]  [datetime] NOT NULL,
	[Shift_end]    [datetime] NOT NULL,
	[Income]       [money]     NULL,
	[Sales_volume] [money]     NULL,
	[Cash_amount_start] [money] NULL,
	[Cash_amount_end]   [money] NULL,
	CONSTRAINT FK_ShiftCashier FOREIGN KEY (ID_Cashier)
    REFERENCES Station (StationID),
	CONSTRAINT FK_ShiftStation FOREIGN KEY (ID_Station)
    REFERENCES Station (StationID),
PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
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
	[Register_date] [Datetime] NOT NULL,
    CONSTRAINT FK_CustomerLoyaltyCard FOREIGN KEY (ID_LoyaltyCard)
    REFERENCES LoyaltyCard (LoyaltyCardID),
	CONSTRAINT FK_CustomerPerson FOREIGN KEY (ID_Person)
    REFERENCES Person (PersonID),
    PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Payment]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[ID_MOP] [int] NOT NULL,
	[Created_at] [Datetime] NOT NULL,
    CONSTRAINT FK_PaymentsMop FOREIGN KEY (ID_MOP)
    REFERENCES MOP (MopID),
    PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
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
	[Deal_time] [datetime] NOT NULL,
	[Sel_price] [money] NOT NULL,
	[Original_price] [money] NOT NULL,
	[NIP] [varchar] NULL,
	[VRN] [varchar] NULL,
    [ID_Customer] [int] NULL,
	[ID_Shift] [int] NOT NULL,
    [ID_Payment]   [int] NOT NULL,
	[Qt_product] [float] NOT NULL,

	CONSTRAINT FK_ReceiptShift FOREIGN KEY (ID_Shift)
    REFERENCES Shift (ShiftID),
	CONSTRAINT FK_ReceiptCustomer FOREIGN KEY (ID_Customer)
    REFERENCES Customer (CustomerID),
    CONSTRAINT FK_ReceiptPayment FOREIGN KEY (ID_Payment)
    REFERENCES Payment (PaymentID),
PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
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
	[Unit_discount] [float] NOT NULL,
	[Turnover] [float] NOT NULL,
	[Original_price] [float] NOT NULL,
	[Quantity] [float] NOT NULL,
	CONSTRAINT FK_ProductReceiptProduct FOREIGN KEY (ID_Product)
    REFERENCES Product (ProductID),
	CONSTRAINT FK_ProductReceiptReceipt FOREIGN KEY (ID_Receipt)
    REFERENCES Receipt (ReceiptID),
PRIMARY KEY CLUSTERED 
(
	[ProductReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





/****** Object:  Table [dbo].[Cistern]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cistern](
	[CisternID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_Product] [int] NOT NULL,
	[Max_volume] [decimal](18, 0) NOT NULL,
	[Min_volume] [decimal](18, 0) NOT NULL,
	[Actual_volume] [decimal](18, 0) NOT NULL,
	CONSTRAINT FK_CisternProduct FOREIGN KEY (ID_Product)
    REFERENCES Product (ProductID))

	/****** Object:  Table [dbo].[Cistern]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecReport](
	[ReportID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_Shift] [int] NOT NULL,
	[ID_Mop]   [int]   NOT NULL,
	[Value] [money] NOT NULL,
	CONSTRAINT FK_RecReportShift FOREIGN KEY (ID_Shift)
    REFERENCES Shift (ShiftID),
	CONSTRAINT FK_RecReportMOP FOREIGN KEY (ID_Mop)
    REFERENCES MOP (MopID))

/****** Object:  Table [dbo].[FuelDelivery]    Script Date: 1/9/2022 1:08:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuelDelivery](
	[DeliveryID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cistern] [int] NOT NULL,
	[Data_delivery] [datetime] NOT NULL,
	CONSTRAINT FK_FuelDeliveryCistern FOREIGN KEY (ID_Cistern)
    REFERENCES Cistern (CisternID),
PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Person]  WITH CHECK ADD CHECK  (([Adress_zip] like '[0-9][0-9][-][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD CHECK  (([Adress_zip] like '[0-9][0-9][-][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD CHECK  (([Adress_zip] like '[0-9][0-9][-][0-9][0-9][0-9]'))

ALTER TABLE [dbo].[Station]  WITH CHECK ADD CHECK (Email1 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Station]  WITH CHECK ADD CHECK (Email2 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Company]  WITH CHECK ADD CHECK (Email1 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Company]  WITH CHECK ADD CHECK (Email2 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Person]  WITH CHECK ADD CHECK (Email1 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Person]  WITH CHECK ADD CHECK (Email2 LIKE '%___@___%.__%')
GO

ALTER TABLE [dbo].[Cashier]  WITH CHECK ADD CHECK (Work_email LIKE '%___@___%.__%')
GO

