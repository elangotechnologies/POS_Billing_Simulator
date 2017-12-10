USE [master]
GO
/****** Object:  Database [pos_billing]    Script Date: 12/10/2017 4:40:17 PM ******/
CREATE DATABASE [pos_billing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pos_billing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ELASQLEXPRESS\MSSQL\DATA\pos_billing.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pos_billing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ELASQLEXPRESS\MSSQL\DATA\pos_billing_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pos_billing] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pos_billing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pos_billing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pos_billing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pos_billing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pos_billing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pos_billing] SET ARITHABORT OFF 
GO
ALTER DATABASE [pos_billing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pos_billing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pos_billing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pos_billing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pos_billing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pos_billing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pos_billing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pos_billing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pos_billing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pos_billing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pos_billing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pos_billing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pos_billing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pos_billing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pos_billing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pos_billing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pos_billing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pos_billing] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pos_billing] SET  MULTI_USER 
GO
ALTER DATABASE [pos_billing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pos_billing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pos_billing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pos_billing] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [pos_billing] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'pos_billing', N'ON'
GO
USE [pos_billing]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[displayBillId] [varchar](50) NOT NULL,
	[entityId] [numeric](5, 0) NOT NULL,
	[dateTime] [datetime] NOT NULL,
	[itemsPriceInTotal] [numeric](11, 2) NOT NULL,
	[taxAmount1] [numeric](11, 2) NOT NULL,
	[taxAmount2] [numeric](11, 2) NULL,
	[tipAmount] [numeric](11, 2) NULL,
	[cardNo] [varchar](50) NULL,
	[cardTransactionRef] [varchar](50) NULL,
	[orderNo] [varchar](50) NULL,
	[authToken] [varchar](50) NULL,
	[placeCameFrom] [varchar](50) NULL,
	[extra1] [varchar](50) NULL,
	[extra2] [varchar](50) NULL,
	[cashTendered] [numeric](11, 2) NULL,
	[cashReturned] [numeric](11, 2) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillItems]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillItems](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[billId] [numeric](5, 0) NULL,
	[itemPriceId] [numeric](5, 0) NULL,
	[qty] [numeric](5, 2) NULL,
 CONSTRAINT [PK_BillItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NULL,
	[addressLine1] [varchar](100) NULL,
	[addressLine2] [varchar](100) NULL,
	[addressLine3] [varchar](100) NULL,
	[addressLine4] [varchar](100) NULL,
	[addressLine5] [varchar](100) NULL,
	[addressLine6] [varchar](100) NULL,
	[addressLine7] [varchar](100) NULL,
	[type] [varchar](50) NOT NULL,
	[billHeight] [numeric](8, 2) NULL,
	[billWidth] [numeric](8, 2) NULL,
	[taxPercent1] [numeric](4, 2) NULL,
	[taxPercent2] [numeric](4, 2) NULL,
	[distanceFromHotel] [numeric](4, 2) NULL,
	[distanceFromOffice] [numeric](4, 2) NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntityType]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntityType](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EntityType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[categoryId] [numeric](5, 0) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemPriceEntityWise]    Script Date: 12/10/2017 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPriceEntityWise](
	[id] [numeric](5, 0) IDENTITY(1,1) NOT NULL,
	[entityId] [numeric](5, 0) NULL,
	[itemId] [numeric](5, 0) NULL,
	[price] [numeric](11, 2) NULL,
 CONSTRAINT [PK_ItemPriceEntityWise] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bill]    Script Date: 12/10/2017 4:40:17 PM ******/
CREATE NONCLUSTERED INDEX [IX_Bill] ON [dbo].[Bill]
(
	[entityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Item]    Script Date: 12/10/2017 4:40:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Item] ON [dbo].[Item]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemPriceEntityWise]    Script Date: 12/10/2017 4:40:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ItemPriceEntityWise] ON [dbo].[ItemPriceEntityWise]
(
	[entityId] ASC,
	[itemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Entity] FOREIGN KEY([entityId])
REFERENCES [dbo].[Entity] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Entity]
GO
ALTER TABLE [dbo].[BillItems]  WITH CHECK ADD  CONSTRAINT [FK_BillItems_Bill] FOREIGN KEY([billId])
REFERENCES [dbo].[Bill] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillItems] CHECK CONSTRAINT [FK_BillItems_Bill]
GO
ALTER TABLE [dbo].[ItemPriceEntityWise]  WITH CHECK ADD  CONSTRAINT [FK_ItemPriceEntityWise_Entity] FOREIGN KEY([entityId])
REFERENCES [dbo].[Entity] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemPriceEntityWise] CHECK CONSTRAINT [FK_ItemPriceEntityWise_Entity]
GO
USE [master]
GO
ALTER DATABASE [pos_billing] SET  READ_WRITE 
GO
