USE [EBusiness]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SystemUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Name] [nvarchar](500) NULL,
	[ContactNumber] [nvarchar](500) NULL,
	[Address] [nvarchar](2000) NULL,
	[IsActive] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_IsActive]  DEFAULT ((1)),
	[AllowInvoice] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowInvoice]  DEFAULT ((1)),
	[AllowStock] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowStock]  DEFAULT ((1)),
	[AllowCompany] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowCompany]  DEFAULT ((1)),
	[AllowCustomer] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowCustomer]  DEFAULT ((1)),
	[AllowItem] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowItem]  DEFAULT ((1)),
	[AllowShop] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowShop]  DEFAULT ((1)),
	[AllowReports] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowReports]  DEFAULT ((1)),
	[AllowUserManagement] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowUserManagement]  DEFAULT ((1)),
	[AllowOrder] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowOrder]  DEFAULT ((1)),
	[AllowCompanyPayment] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowCompanyPayment]  DEFAULT ((0)),
	[AllowCustomerPayment] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowCustomerPayment]  DEFAULT ((0)),
	[AllowReturnSale] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowReturnSale]  DEFAULT ((0)),
	[AllowReturnPurchase] [tinyint] NOT NULL CONSTRAINT [DF_SystemUsers_AllowReturnPurchase]  DEFAULT ((0)),
 CONSTRAINT [PK_SystemUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[SelectEmptyTable]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectEmptyTable]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectEmptyTable ''InvoiceDetail''
-- exec SelectCompany @CompanyName =''M''
CREATE PROCEDURE [dbo].[SelectEmptyTable]
@TableName nvarchar(500)
AS
BEGIN
DECLARE @Qry nvarchar(500)
	SET @Qry = ''SELECT top 0 * FROM '' + @TableName
	exec sp_sqlexec  @Qry
END
' 
END
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transactions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Transactions](
	[TransactionId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerCompanyId] [int] NULL,
	[TransactionDate] [datetime] NULL,
	[Amount] [money] NULL,
	[Balance] [money] NULL,
	[IsCustomer] [bit] NULL,
	[Comments] [nvarchar](500) NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Status]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Status]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Status](
	[Id] [int] NOT NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Shop]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Shop](
	[ShopName] [nvarchar](500) NULL,
	[ShopAddress] [nvarchar](1000) NULL,
	[ShopNumber] [nvarchar](500) NULL,
	[ShopSlogon] [nvarchar](500) NULL,
	[RegistrationNumber] [nvarchar](500) NULL,
	[Properiter] [nvarchar](500) NULL,
	[SaleNote] [nvarchar](500) NULL,
	[AD97DC5D7E618288E63528CC5CC6F3AE] [nvarchar](1000) NULL,
	[299073ED0704FC4383DBA129C67CCDEB] [nvarchar](200) NULL,
	[1B29BA78A2DF965545C5A563B6E997AE] [nvarchar](200) NULL,
	[A34C0CEC63EC0F1739FB5CB8F43A9CE1] [nvarchar](200) NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Shop', N'COLUMN',N'AD97DC5D7E618288E63528CC5CC6F3AE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'YEKMETSYS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Shop', @level2type=N'COLUMN',@level2name=N'AD97DC5D7E618288E63528CC5CC6F3AE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Shop', N'COLUMN',N'299073ED0704FC4383DBA129C67CCDEB'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ETADNOITALLATSNI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Shop', @level2type=N'COLUMN',@level2name=N'299073ED0704FC4383DBA129C67CCDEB'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Shop', N'COLUMN',N'1B29BA78A2DF965545C5A563B6E997AE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ETADYRIPXE' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Shop', @level2type=N'COLUMN',@level2name=N'1B29BA78A2DF965545C5A563B6E997AE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Shop', N'COLUMN',N'A34C0CEC63EC0F1739FB5CB8F43A9CE1'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NURTSAL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Shop', @level2type=N'COLUMN',@level2name=N'A34C0CEC63EC0F1739FB5CB8F43A9CE1'
GO
/****** Object:  StoredProcedure [dbo].[Admin_RestoreBackup]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin_RestoreBackup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[Admin_RestoreBackup]
@FilePath nvarchar(2500)=null
AS
BEGIN
	ALTER DATABASE EBusiness
	SET SINGLE_USER WITH
	ROLLBACK IMMEDIATE
	RESTORE DATABASE EBusiness FROM DISK = @FilePath WITH REPLACE
	ALTER DATABASE EBusiness SET MULTI_USER
END
' 
END
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 10/27/2011 17:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InvoiceDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [bigint] NULL,
	[ItemId] [int] NULL,
	[PurchasePrice] [money] NULL,
	[Quantity] [int] NULL,
	[GrandTotal] [money] NULL,
	[Total] [money] NULL,
	[Discount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Invoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[CompanyId] [int] NULL,
	[GrandTotal] [money] NULL CONSTRAINT [DF_Invoice_GrandTotal]  DEFAULT ((0.0)),
	[Discount] [money] NULL CONSTRAINT [DF_Invoice_Expenses]  DEFAULT ((0.0)),
	[Payment] [money] NULL CONSTRAINT [DF_Invoice_Payment]  DEFAULT ((0.0)),
	[Arrears] [money] NULL CONSTRAINT [DF_Invoice_Arrears]  DEFAULT ((0.0)),
	[Comments] [nvarchar](500) NULL,
	[IsReturn] [tinyint] NOT NULL CONSTRAINT [DF_Invoice_IsReturn]  DEFAULT ((0)),
	[OrderNo] [bigint] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[InsertExpiryDates]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertExpiryDates]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertExpiryDates]
@NextYear int=10
AS
BEGIN
DECLARE @Index int
DECLARE @InnerIndex int
DECLARE @Year int
DECLARE @ExpiryDate nvarchar(50)
SET @ExpiryDate =''''
-- truncate table ExpiryDate
SET @Index = 0
	WHILE @Index < @NextYear 
	BEGIN
		SET @Year = DATEPART(YEAR, DATEADD(YEAR, @Index, getDate()))
		SET @InnerIndex =1
		WHILE @InnerIndex <= 12
		BEGIN
			SET @ExpiryDate = Convert(nvarchar(4),@Year)  + ''-'' +Convert(nvarchar(2),@InnerIndex) + ''-01'' 
				IF (SELECT COUNT(1) FROM ExpiryDate WHERE ExpiryDate = @ExpiryDate ) <1
					INSERT INTO ExpiryDate VALUES(@ExpiryDate)
			SET @InnerIndex =@InnerIndex+1
		END
		SET @Index =@Index+1
	END

END
' 
END
GO
/****** Object:  Table [dbo].[ExceptionLog]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExceptionLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ExceptionLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExceptionTime] [datetime] NULL,
	[Module] [nvarchar](50) NULL,
	[Method] [nvarchar](50) NULL,
	[Message] [nvarchar](500) NULL,
	[StackTrace] [nvarchar](2500) NULL,
	[InnerMessage] [nvarchar](500) NULL,
 CONSTRAINT [PK_ExceptionLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](500) NULL,
	[CustomerName] [nvarchar](500) NULL,
	[ContactNumber] [nvarchar](500) NULL,
	[Address] [nvarchar](2000) NULL,
	[CustomerBalance] [money] NULL,
	[Remarks] [nvarchar](500) NULL,
	[City] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](200) NULL,
	[Phone] [nvarchar](100) NULL,
	[Fax] [nvarchar](100) NULL,
	[Web] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Company]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Company]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyCode] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](500) NULL,
	[CompanyBalance] [money] NULL,
	[Remarks] [nvarchar](500) NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](200) NULL,
	[Phone] [nvarchar](100) NULL,
	[Fax] [nvarchar](100) NULL,
	[Web] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ReceiptDetail]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReceiptDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReceiptDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ReceiptId] [bigint] NULL,
	[ItemId] [int] NULL,
	[PurchasePrice] [money] NULL,
	[ItemDiscount] [nvarchar](50) NULL,
	[SalePrice] [money] NULL,
	[Quantity] [int] NULL,
	[GrandTotal] [money] NULL,
	[Discount] [money] NULL,
	[Total] [money] NULL,
	[ProfitLoss] [money] NULL,
 CONSTRAINT [PK_ReceiptDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Receipt]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Receipt](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[CustomerId] [int] NULL,
	[ReceiptCustomerName] [nvarchar](50) NULL,
	[ReceiptCustomerAddress] [nvarchar](500) NULL,
	[GrandTotal] [money] NULL,
	[Discount] [money] NULL CONSTRAINT [DF_Receipt_Discount]  DEFAULT ((0.0)),
	[Total] [money] NULL CONSTRAINT [DF_Receipt_Total]  DEFAULT ((0.0)),
	[Expenses] [money] NULL CONSTRAINT [DF_Receipt_Expenses]  DEFAULT ((0.0)),
	[Payment] [money] NULL CONSTRAINT [DF_Receipt_Payment]  DEFAULT ((0.0)),
	[Arearrs] [money] NULL CONSTRAINT [DF_Receipt_Arearrs]  DEFAULT ((0.0)),
	[Comments] [nvarchar](500) NULL,
	[Purpose] [nvarchar](100) NULL,
	[IsReturn] [tinyint] NOT NULL,
	[UserId] [int] NULL,
	[ProfitLoss] [money] NULL,
	[UnitProfitLoss] [money] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ProductTransaction]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductTransaction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProductTransaction](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemName] [nvarchar](50) NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[CompanyCode] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ReceiptId] [nvarchar](50) NULL,
	[CustomerCode] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[QuantityIn] [int] NULL,
	[QuantityOut] [int] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_ProductTransaction_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NULL,
	[ItemId] [int] NULL,
	[PurchasePrice] [money] NULL,
	[Quantity] [int] NULL,
	[Total] [money] NULL,
	[Discount] [decimal](18, 2) NULL,
	[GrandTotal] [money] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Order]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[DeliveryDate] [date] NULL,
	[CompanyId] [int] NULL,
	[GrandTotal] [money] NULL,
	[Comments] [nvarchar](500) NULL,
	[Status] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Payment] [money] NULL,
	[Arrears] [money] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ItemType]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemType](
	[ItemTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeName] [nvarchar](300) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_ItemType] PRIMARY KEY CLUSTERED 
(
	[ItemTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[GetItemPacking]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetItemPacking]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetItemPacking]
@ItemId bigint
AS
BEGIN

	Select ItemId , PackingName
	from ItemPacking
		INNER JOIN Packing on Packing.Id=ItemPacking.PackingId
	Where ItemPacking.ItemId = @ItemId
	Order By DisplayOrder
	
END
' 
END
GO
/****** Object:  Table [dbo].[Item]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Item](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [nvarchar](100) NULL,
	[ItemName] [nvarchar](500) NULL,
	[ItemType] [int] NULL,
	[Packing] [nvarchar](50) NULL,
	[CompanyId] [int] NULL,
	[ItemInStock] [int] NULL,
	[ItemOnOrder] [int] NULL,
	[PurchasePrice] [money] NULL,
	[SalePrice] [money] NULL,
	[AvgPurchasePrice] [money] NULL,
	[Discount] [nvarchar](50) NULL,
	[StockLimit] [int] NULL,
	[IsActive] [bit] NULL,
	[BatchNo] [nvarchar](500) NULL,
	[ExpiryDate] [datetime] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[Admin_CreateBackup]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin_CreateBackup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[Admin_CreateBackup]
@FilePath nvarchar(2500)=null
AS
BEGIN
	BACKUP DATABASE EBusiness TO DISK =@FilePath 
END
' 
END
GO
/****** Object:  Table [dbo].[UserLog]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserLog](
	[Ticks] [bigint] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[UserId] [int] NULL,
	[ActionId] [int] NOT NULL,
	[ActionDetails] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserLog] PRIMARY KEY CLUSTERED 
(
	[Ticks] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[UserAction]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserAction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserAction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateOrder]
@OrderId bigint,
@Status int=1
AS
BEGIN
--Select * from Status
Update [Order] SET [Status] = @Status
-- Update Stock Here
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[IsDuplictaeInvoiceNo]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsDuplictaeInvoiceNo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[IsDuplictaeInvoiceNo]
@InvoiceNo nvarchar(50),
@CompanyId int
AS
BEGIN
	Select COUNT(*) from Invoice Where InvoiceNo=@InvoiceNo AND CompanyId=@CompanyId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[IsCodeExists]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsCodeExists]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec IsCodeExists ''nc'', ''company''
-- exec IsCodeExists ''nc'', ''customer''
-- exec IsCodeExists ''CC'', ''Item''
-- SELECT * FROM Item
CREATE PROCEDURE [dbo].[IsCodeExists]
@Code nvarchar(50),
@TableName nvarchar(50),
@Active int = 1 
AS
BEGIN
IF @Active <> 1
	SET @Active = null
IF LOWER(@TableName) = ''supplier''
set @TableName= ''company''
IF LOWER(@TableName) = ''company''
SELECT  COUNT(*) as cnt FROM Company Where (CompanyCode = @Code OR CompanyName = @Code ) AND IsActive = ISNULL(@Active, IsActive)
IF LOWER(@TableName) = ''customer''
SELECT  COUNT(*) as cnt  FROM Customer Where ( CustomerCode = @Code OR CustomerName = @Code ) AND IsActive = ISNULL(@Active, IsActive)
IF LOWER(@TableName) = ''item''
SELECT COUNT(*) as cnt FROM Item Where ( ItemCode = @Code OR ItemName = @Code ) AND IsActive = ISNULL(@Active, IsActive)
IF LOWER(@TableName) = ''itemtype''
SELECT COUNT(*) as cnt FROM ItemType Where ItemTypeName = @Code  AND IsActive = ISNULL(@Active, IsActive)
IF LOWER(@TableName) = ''systemusers''
SELECT COUNT(*) as cnt FROM SystemUsers Where UserName = @Code  AND IsActive = ISNULL(@Active, IsActive)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[CleanDatabase]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CleanDatabase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CleanDatabase]
AS
BEGIN
print (''.................................'')
print (''.................................'')
print (''......DATABASE CLEAN STARTED.....'')
print (''.................................'')
print (''.................................'')
print (''Removing Data From Shop Table'')
Truncate Table Shop
print (''Removing Data From ReceiptDetail Table'')
Truncate Table ReceiptDetail
print (''Removing Data From Receipt Table'')
Truncate Table Receipt
print (''Removing Data From InvoiceDetail Table'')
Truncate Table InvoiceDetail
print (''Removing Data From Invoice Table'')
Truncate Table [Order]
print (''Removing Data From OrderDetail Table'')
Truncate Table OrderDetail
print (''Removing Data From Order Table'')
Truncate Table Invoice
print (''Removing Data From Item Table'')
Truncate Table Item
print (''Removing Data From ItemType Table'')
Truncate Table ItemType
print (''Removing Data From Transactions Table'')
Truncate Table Transactions
print (''Removing Data From Customer Table'')
Truncate Table Customer
print (''Removing Data From Company Table'')
Truncate Table Company
print (''Removing Data From SystemUsers Table'')
Truncate Table SystemUsers
print (''.................................'')
print (''.................................'')
print (''......DATABASE CLEAN FINSHED.....'')
print (''.................................'')
print (''.................................'')

INSERT INTO [dbo].[SystemUsers]
           ([UserName],[Password],[IsActive],[AllowInvoice],[AllowStock],[AllowCompany],[AllowCustomer],[AllowItem]
           ,[AllowShop],[AllowReports],[AllowUserManagement])
     VALUES(''Admin'',''admin'',1,1,1,1,1,1,1,1,1)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[CheckCompanyItem]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckCompanyItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[CheckCompanyItem]
@CompanyItem nvarchar(200)=null,
@CompanyId int=null,
@Packing   nvarchar =null
AS
BEGIN
	 Select Company.CompanyName,Item.ItemName
	 From Company,Item
	 Where Company.CompanyId=@CompanyId
	 AND Item.ItemName=@CompanyItem
	 AND Item.Packing=@Packing
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChangePassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ChangePassword]
@Operation int=1,
@NewPassword nvarchar(100),
@UserName nvarchar(100),
@Password nvarchar(100)='''',
@IsReset bit=0
AS
BEGIN
 If @IsReset=0
	BEGIN
		Update SystemUsers SET [Password]=@NewPassword
		Where UserName=@UserName
		AND [Password]=@Password	
	END
ELSE If @IsReset=1
	BEGIN
		Update SystemUsers SET [Password]=@NewPassword
		Where UserName=@UserName
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUserLog]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertUserLog]
@Ticks bigint,
@UserId int,
@ActionId int,
@ActionDetails nvarchar(500)=null

AS
BEGIN
DECLARE @date DateTime
SET @date = GETDATE()
	INSERT INTO UserLog 
	VALUES (@Ticks, @date,@UserId, @ActionId, @ActionDetails)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteUser]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteUser] 
@Id int =0,
@UserName nvarchar(100),
@Password nvarchar(100),
@Name nvarchar(500),
@ContactNumber nvarchar(500),
@Address nvarchar(2000),
@AllowInvoice tinyint =1,
@AllowStock tinyint =1,
@AllowCompany tinyint =1,
@AllowCustomer tinyint =1,
@AllowItem tinyint =0,
@AllowShop tinyint =0,
@AllowReports tinyint =0,
@AllowUserManagement tinyint =0,
@AllowOrder tinyint =0,
@AllowCompanyPayment tinyint =0,
@AllowCustomerPayment tinyint =0,
@AllowReturnSale tinyint=0,
@AllowReturnPurchase tinyint =0,
@IsActive tinyint =1

AS
BEGIN

	IF @Id = 0
	BEGIN
		INSERT INTO [EBusiness].[dbo].[SystemUsers]
           ([UserName]
           ,[Password],[Name],[ContactNumber],[Address],[IsActive]
           ,[AllowInvoice],[AllowStock],[AllowCompany],[AllowCustomer]
           ,[AllowItem],[AllowShop],[AllowReports],[AllowUserManagement], [AllowOrder]
           , AllowCompanyPayment ,AllowCustomerPayment, AllowReturnSale, AllowReturnPurchase)
     VALUES
           (@UserName ,@Password ,@Name ,@ContactNumber ,@Address ,@IsActive ,
			@AllowInvoice ,@AllowStock ,@AllowCompany ,@AllowCustomer ,
			@AllowItem ,@AllowShop ,@AllowReports ,@AllowUserManagement, @AllowOrder
			, @AllowCompanyPayment ,@AllowCustomerPayment,@AllowReturnSale ,@AllowReturnPurchase )
	END
	ELSE IF @Id > 0
	BEGIN
		UPDATE [SystemUsers]
		SET 
			[Password] = @Password,
			[Name] = @Name,
			[ContactNumber] = @ContactNumber,
			[Address] = @Address,
			[IsActive] = @IsActive,
			[AllowInvoice] = @AllowInvoice,
			[AllowStock] = @AllowStock,
			[AllowCompany] = @AllowCompany,
			[AllowCustomer] = @AllowCustomer,
			[AllowItem] = @AllowItem,
			[AllowShop] = @AllowShop,
			[AllowReports] = @AllowReports,
			[AllowUserManagement] = @AllowUserManagement,
			[AllowOrder] = @AllowOrder,
			[AllowCompanyPayment] = @AllowCompanyPayment,
			[AllowCustomerPayment] = @AllowCustomerPayment,
			[AllowReturnSale] = @AllowReturnSale,
			[AllowReturnPurchase] = @AllowReturnPurchase
		WHERE SystemUsers.Id = @Id
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteTransaction]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteTransaction]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteTransaction]
@Operation int =0, -- 0=Insert, 1=Update
@CustomerCompanyId int =null,
@TransactionDate datetime,
@Amount	money,
@IsCustomer bit=1,
@UserId int=-1,
@Comments nvarchar(500) = ''''
AS
BEGIN
DECLARE @Balance money
DECLARE @NewId bigint 
SET @Balance = 0.0

	IF @Operation = 0 AND @Amount <> 0
	BEGIN
			IF @CustomerCompanyId > 0 
		BEGIN
			IF @IsCustomer =1
			BEGIN
				UPDATE Customer SET CustomerBalance = ISNULL(CustomerBalance,0) + @Amount WHERE Customer.CustomerId = @CustomerCompanyId
				SELECT @Balance = CustomerBalance FROM Customer WHERE Customer.CustomerId = @CustomerCompanyId
			END
			ELSE
			BEGIN
				UPDATE Company SET  CompanyBalance= ISNULL(CompanyBalance,0) + @Amount  WHERE Company.CompanyId = @CustomerCompanyId
				SELECT @Balance = CompanyBalance  FROM Company WHERE Company.CompanyId = @CustomerCompanyId
			END
		END
		
		INSERT INTO Transactions (CustomerCompanyId, TransactionDate, Amount, Balance, IsCustomer, Comments, UserId )
		VALUES(@CustomerCompanyId, @TransactionDate, @Amount, @Balance, @IsCustomer, @Comments, @UserId )
		Select @@IDENTITY

	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteShop]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteShop]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteShop]
@Operation int =0, -- o=Insert, 1=Update
@ShopName nvarchar(500),
@ShopAddress nvarchar(1000),
@ShopNumber nvarchar(500),
@ShopSlogon nvarchar(500),
@RegistrationNumber nvarchar(500),
@Properiter nvarchar(500),
@SaleNote nvarchar(500)
AS
BEGIN
	IF (Select COUNT(*) FROm Shop) = 0
	BEGIN
		INSERT INTO Shop (ShopName , ShopAddress , ShopNumber ,ShopSlogon,RegistrationNumber, Properiter,SaleNote)
		VALUES(@ShopName , @ShopAddress , @ShopNumber ,	@ShopSlogon , @RegistrationNumber, @Properiter,@SaleNote)
	END
	ELSE 
	BEGIN
		UPDATE Shop
		SET	ShopName =@ShopName ,
			ShopAddress = @ShopAddress ,
			ShopNumber = @ShopNumber ,
			ShopSlogon = @ShopSlogon ,
			RegistrationNumber = @RegistrationNumber,
			Properiter = @Properiter,
			SaleNote = @SaleNote
			
	END

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductInOutDetailedReport_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductInOutDetailedReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' -- Report_ProductInOutDetailedReport_Print @Id=2
CREATE PROCEDURE [dbo].[Report_ProductInOutDetailedReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @Title nvarchar(100)
DECLARE @ShopName nvarchar(200)
DECLARE @ShopAddress nvarchar(1000)
	
SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress  from Shop	
SELECT  @Title = ''Transaction Details of Product ['' + ItemName + '']'' + '' (''+ ItemCode + '')''   From Item Where ItemId = @Id	
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' +CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	SELECT CONVERT(nvarchar(30), Date,103) as Date, ISNULL(ReceiptId,InvoiceNo) as Detail ,
	 QuantityIn as [IN], 
	QuantityOut as [OUT],  Stock,
	@ShopName as ShopName , @ShopAddress as ShopAddress ,@Title as Title , @SDate as StartDate, @EDate as EndDate
	  FROM ProductTransaction
	Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	AND ItemId = @Id
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductInOutDetailedReport]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductInOutDetailedReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' -- drop proc Report_ProductHistoryReport
CREATE PROCEDURE [dbo].[Report_ProductInOutDetailedReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null
AS
BEGIN
	
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	SELECT CONVERT(nvarchar(30), Date,103) as Date, ISNULL(ReceiptId,InvoiceNo) as Detail ,
	 QuantityIn as [IN], 
	QuantityOut as [OUT],  Stock
	  FROM ProductTransaction
	Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	AND ItemId = @Id
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductDailySaleReport_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductDailySaleReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
 exec Report_ProductDailySaleReport_Print @Id=2
 exec Report_ProductDailyPurchaseReport_Print @Id=2

 exec Report_ProductDailySaleReport_Print @Id=4
 exec Report_ProductDailyPurchaseReport_Print @Id=4
*/
CREATE PROCEDURE [dbo].[Report_ProductDailySaleReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = 0

AS
BEGIN
	
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @ProductName nvarchar(100)
DECLARE @ShopName nvarchar(200)
DECLARE @ShopAddress nvarchar(1000)
IF @Id < 1
		SET @Id = null
		
	SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress  from Shop	
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @ProductName = ''Sale Summary of All Products''
	END
	ELSE
		SELECT  @ProductName = ''Sale Summary of Product ['' + ItemName + '']'' + '' (''+ ItemCode + '')''   From Item Where ItemId = @Id
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' +CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	Select sale.Date, ItemName, SUM(Returned) as SaleReturned,  SUM(Sold) as Sold ,
	 @ShopName as ShopName , @ShopAddress as ShopAddress ,@ProductName as Title , @SDate as StartDate, @EDate as EndDate
	from (
			Select ReceiptDetail.ItemId, CONVERT(nvarchar(20) , [Date], 103) as Date, 
			case when Receipt.IsReturn =1 then (ReceiptDetail.Quantity) else 0 end as Returned,
			case when Receipt.IsReturn <> 1 then (ReceiptDetail.Quantity) else 0 end as Sold 
			from ReceiptDetail
				INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id
			Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			 AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId) 
		) as sale
	INNER JOIN Item on sale.ItemId = Item.ItemId
	WHERE sale.ItemId = ISNULL(@Id, sale.ItemId)
	group by sale.Date, ItemName 
	order by sale.Date, ItemName
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductDailyPurchaseReport_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductDailyPurchaseReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--  Report_ProductDailyPurchaseReport_Print @Id=2
CREATE PROCEDURE [dbo].[Report_ProductDailyPurchaseReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = 0

AS
BEGIN
	
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @ProductName nvarchar(100)
DECLARE @ShopName nvarchar(200)
DECLARE @ShopAddress nvarchar(1000)
IF @Id < 1
		SET @Id = null
		
	SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress  from Shop	
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @ProductName = ''Purchase Summary of All Products''
	END
	ELSE
		SELECT  @ProductName = ''Purchase Summary of Product ['' + ItemName + '']'' + '' (''+ ItemCode + '')''   From Item Where ItemId = @Id
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' +CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
	
-- Purchase + Purchase Return	
	Select dt.Date, ItemName, SUM(Returned) as PurchaseReturned,  SUM(Purchased) as Purchased ,
	 @ShopName as ShopName , @ShopAddress as ShopAddress ,@ProductName as Title , @SDate as StartDate, @EDate as EndDate
	from (
			Select InvoiceDetail.ItemId, CONVERT(nvarchar(20) , [Date], 103) as Date, 
			case when Invoice.IsReturn =1 then (InvoiceDetail.Quantity) else 0 end as Returned,
			case when Invoice.IsReturn <> 1 then (InvoiceDetail.Quantity) else 0 end as Purchased 
			from InvoiceDetail
				INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id 
			Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			 AND InvoiceDetail.ItemId = ISNULL(@Id, InvoiceDetail.ItemId)
		) as dt
	INNER JOIN Item on dt.ItemId = Item.ItemId
	WHERE dt.ItemId = ISNULL(@Id, dt.ItemId)
	group by dt.Date, ItemName 
	order by dt.Date, ItemName

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_DailySalesPurchaseReport]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_DailySalesPurchaseReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_DailySalesPurchaseReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@InDetail	int = 0

AS
BEGIN
	
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END


	--Daily SalesPurchase
	IF @InDetail = 0
	BEGIN
	-- Purchase
	Select 
	case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as Invoice, 
	CONVERT(nvarchar(20), [Date], 103) as [Date], Company.CompanyName as Supplier, 
	case when ((GrandTotal-Discount) < 0 AND Invoice.IsReturn<>1 ) then ROUND(-1*(GrandTotal-Discount),2) else ROUND((GrandTotal-Discount),2)end as Total--, ROUND(Payment )  as Payment  
	from Invoice
		INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
	WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])

	-- Sales
	Select Receipt.Id as Receipt, CONVERT(nvarchar(20), [Date], 103) as [Date], Customer.CustomerName as Customer, 
	case when Total < 0 then ROUND(-1*Total,2) else 
	case when  Receipt.IsReturn=1 then  ROUND(-1*Total,2) else  ROUND(Total,2) end  end  as Total--, ROUND(Payment )  as Payment  
	from Receipt
		INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
	WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
				
	END
	--Daily SalesPurchase Detailed
	ELSE IF @InDetail=1
	BEGIN
		SELECT 
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as Invoice,
		CONVERT(nvarchar(20), [Date], 103) as [Date],
		Company.CompanyName as Supplier, 
		Item.ItemName as Item,	
		case when Invoice.IsReturn = 1 then ROUND(-1*SUM(Total),2) else  ROUND(SUM(Total),2) end as Total
		FROM Invoice
			INNER JOIN InvoiceDetail on Invoice.Id = InvoiceDetail.InvoiceId
			INNER JOIN Item on InvoiceDetail.ItemId = Item.ItemId
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		Group By 
		InvoiceNo,
		Invoice.IsReturn,
		Company.CompanyName, 
		Item.ItemName ,
		CONVERT(nvarchar(20), [Date], 103)

	--Sales
		Select Receipt.Id as Receipt
	   ,CONVERT(nvarchar(20), [Date], 103) as [Date]
	   , Customer.CustomerName as Customer
	   , ItemName as Item
	   , case when ReceiptDetail.Total < 0 then ROUND(-1*ReceiptDetail.Total,2)  else 
		case when  Receipt.IsReturn=1 then  ROUND(-1*ReceiptDetail.Total,2) else  ROUND(ReceiptDetail.Total,2) end end as Total 
		FROM Receipt
		INNER JOIN ReceiptDetail on Receipt.Id = ReceiptDetail.ReceiptId
		INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId  
		INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
	WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])

	END
	--Daily SalesPurchase Summary
	ELSE IF @InDetail =2
	BEGIN
	--purchase
	SELECT Convert(nvarchar(25), [Date], 103) as [Date],ROUND(SUM(GrandTotal),2) as ''Total''
	FROM Invoice
	WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	GROUP BY Convert(nvarchar(25), [Date], 103) 
	
	--sales
	SELECT CONVERT(nvarchar(25),[Date],103) as [Date] ,(ROUND(SUM(-1*Total),2)  ) as ''Total''
	FROM Receipt
	WHERE [Date]>=ISNULL(@StartDate,[Date]) AND [Date]<=ISNULL(@EndDate,[Date])
	GROUP BY CONVERT(nvarchar(25),[Date],103)
	END
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CustomerTransactions_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CustomerTransactions_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--exec [Report_CustomerTransactions_Print] 0,''2011/01/17'', ''2011/05/17'' 
CREATE PROCEDURE [dbo].[Report_CustomerTransactions_Print]
@Id bigint = null,
@FromDate datetime =null ,
@ToDate datetime =null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CustomerName nvarchar(50)
DECLARE @CashId int


		IF @Id =0 OR @Id IS NULL
		BEGIN
			SET @Id = null
			SET @CustomerName = ''Transaction Report of All Customers''
		END
		ELSE
		BEGIN
			SELECT @CashId = CustomerId  FROM Customer Where CustomerCode = ''CASH''
			IF @CashId = @Id
			BEGIN
				SET @CustomerName = ''Transaction Report of (CASH Customer)''
			END
			ELSE
			BEGIN
				SELECT  @CustomerName = ''Transaction Report of ('' + ISNULL(Customer.CustomerCode, ''CASH'')+ '')['' + ISNULL(Customer.CustomerName, ''CASH'') + '']'' FROM Customer Where CustomerId = @Id
			END
		END
		IF @FromDate IS NULL
			SET @SDate = ''From: N/A''
		ELSE
		BEGIN
			SET @SDate = ''From: '' + CONVERT(nvarchar(50),@FromDate, 103)
			SET @FromDate =DATEADD(SECOND,-1,@FromDate)
		END
		IF @ToDate IS NULL
			SET @EDate = ''To: N/A''
		ELSE
		BEGIN
			SET @EDate = ''To: '' +CONVERT(nvarchar(50),@ToDate, 103)
			SET @ToDate =DATEADD(day,1,@ToDate)
		SET @ToDate =DATEADD(SECOND,-1,@ToDate)
		END
	
			SELECT TransactionId, CONVERT(varchar(50), TransactionDate, 103) as TransactionDate,
			case when CustomerCode=''CASH'' then CustomerCode else CustomerName end as CustomerName, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE null end as Credit, 
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE null end as Debit,
			--ROUND(Amount ,2) as Amount, 
			ROUND(Balance ,2) as Balance
			--, Comments,
			, case when (@Id IS NULL) then 
				case when CustomerCode=''CASH'' then ''(CASH)'' else ''('' + CustomerName + '')'' end + Comments 
			
			else Comments end as Comments ,
			ShopName , @SDate as StartDate, @EDate as EndDate, @CustomerName as Customer
			FROM Transactions
				LEFT JOIN Customer on Transactions.CustomerCompanyId = Customer.CustomerId 
				Cross JOIN Shop
			WHERE --TransactionDate >= ISNULL(@FromDate, TransactionDate) AND TransactionDate <= ISNULL(@EDate, TransactionDate)
			--TransactionDate BETWEEN @FromDate AND  @ToDate
			TransactionDate >= ISNULL(@FromDate,TransactionDate )
		 AND TransactionDate <= ISNULL(@ToDate,TransactionDate )
			AND Transactions.CustomerCompanyId = ISNULL(@Id, Transactions.CustomerCompanyId)
			AND IsCustomer = 1
			order by CustomerCompanyId, TransactionId asc	

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CustomerSalesReportDetailed_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CustomerSalesReportDetailed_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_CustomerSalesReportDetailed_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null

AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CustomerName nvarchar(50)
DECLARE @CashId int
IF @Id =0
	SET @Id =null
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @CustomerName = ''Detailed Sale Report For All Customers''
	END
	ELSE
	BEGIN
		Select @CashId = CustomerId from Customer Where CustomerCode =''CASH''
		IF @CashId = @Id
		BEGIN
			SELECT @CustomerName = ''Detailed Sale Report For CASH Customers''
		END
		ELSE
		BEGIN
		SELECT @CustomerName = ''Detailed Sales Report of '' + CustomerName  + '' (''+ CustomerCode + '')''   FROM Customer Where CustomerId = @Id
		END
	END

	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' + CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END



		SELECT	ReceiptDetail.ReceiptId  as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
			case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+ case when @Id IS NULL then 
			case when CustomerCode=''CASH'' then ''CASH'' else CustomerName end 
		else '''' end as Customer, 
			CompanyName as Company, ItemName as Item, ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
			Quantity,
			case when Receipt.IsReturn =1 then ROUND(-1*ReceiptDetail.Total,2) else ROUND(ReceiptDetail.Total,2) end as Total ,
			ShopName, @SDate as StartDate, @EDate as EndDate, @CustomerName as CustomerName
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
			CROSS JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CustomerSalesReport_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CustomerSalesReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_CustomerSalesReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null

AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CustomerName nvarchar(50)
DECLARE @CashId int
--SET @CustomerName = null
IF @Id =0 
	SET @Id =null
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @CustomerName = ''Sales Report of All Customers''
	END
	ELSE
	BEGIN
		Select @CashId = CustomerId from Customer Where CustomerCode =''CASH''
		IF @CashId = @Id
		BEGIN
			SELECT @CustomerName = ''Sales Report of Cash Customers''
		END
		ELSE
		BEGIN
			SELECT @CustomerName = ''Sales Report of '' + CustomerName  + '' (''+ CustomerCode + '')''  FROM Customer Where CustomerId = @Id
		END
	END
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' + CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

		SELECT Id  as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
		 
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+ 
		case when @Id IS NULL then 
			case when CustomerCode=''CASH'' then Receipt.ReceiptCustomerName else CustomerName end 
		else '''' end as Customer, 
		--ROUND(GrandTotal,2) AS GrandTotal, 
		ROUND(-1*Total,2) AS GrandTotal, 
		ROUND(Payment,2) AS Payment , Comments,
		ShopName , @SDate as StartDate, @EDate as EndDate, @CustomerName as CustomerName
		FROM Receipt 
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			Cross JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CustomerSalesReport]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CustomerSalesReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec Report_CustomerSalesReport @InDetail =1

CREATE PROCEDURE [dbo].[Report_CustomerSalesReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null,
@InDetail	int=0

AS
BEGIN

	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
	
IF @Id =0
	SET @Id = null
	IF @InDetail = 1
	BEGIN
		SELECT	ReceiptDetail.ReceiptId  as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+ case when CustomerCode=''CASH'' then Receipt.ReceiptCustomerName else CustomerName end 
		 as Customer, 
			CompanyName as Company, ItemName as Item, ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
			--case when Quantity < 0 then -1*Quantity else Quantity end as Quantity,  
			Quantity,  
			case when Receipt.IsReturn =1 then ROUND(-1*ReceiptDetail.Total,2) else ROUND(ReceiptDetail.Total,2) end as Total 
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)

	END
	ELSE 
	BEGIN
		SELECT Id  as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+ case when CustomerCode=''CASH'' then Receipt.ReceiptCustomerName else CustomerName end 
		 as Customer, 
		--ROUND(GrandTotal,2) AS GrandTotal, select * from Receipt
		case when Total< 0 then ROUND(-1*Total,2) 
		else 
			case when Receipt.IsReturn=1 then ROUND(-1*Total,2) else ROUND(Total,2) end 
		end AS GrandTotal, 
		case when (Payment< 0 AND Receipt.IsReturn<>1 ) then ROUND(-1*Payment,2) else ROUND(Payment,2) end  AS Payment 
		FROM Receipt 
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)
	END

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CurrentCashReport]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CurrentCashReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_CurrentCashReport]
AS
BEGIN
DECLARE @CompaniesBalance money
DECLARE @CustomerBalance money
DECLARE @TotalSale money
DECLARE @TotalPurchase money
DECLARE @CashInHand money

Select @CompaniesBalance  = ROUND(ISNULL(SUM(Amount),0),2) from Transactions Where IsCustomer =0
Select @CustomerBalance  = ROUND(ISNULL(SUM(Amount),0),2) from Transactions Where IsCustomer =1
Select @TotalPurchase  = ROUND(ISNULL(SUM(GrandTotal),0),2) from Invoice
Select @TotalSale  = ROUND(ISNULL(SUM(-1*Total),0),2) from Receipt
SET @CashInHand = @TotalSale - @TotalPurchase + @CompaniesBalance + @CustomerBalance
Select ISNULL(@CompaniesBalance,0) as CompaniesBalance,ISNULL(@CustomerBalance,0) as CustomerBalance
, ISNULL(@TotalPurchase,0) as TotalPurchase , ISNULL(@TotalSale,0)  as TotalSale, ISNULL(@CashInHand,0) as CashInHand
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CompanyTransactions_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CompanyTransactions_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec [Report_CompanyTransactions_Print] 0,''2011/01/17'', ''2011/06/17'' 
CREATE PROCEDURE [dbo].[Report_CompanyTransactions_Print]
@Id bigint = null,
@FromDate datetime =null ,
@ToDate datetime =null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CompanyName nvarchar(50)
IF @Id =0 
SET @Id =null

		IF @Id =0 OR @Id IS NULL
		BEGIN
			SET @Id = null
			SET @CompanyName = ''Transaction Report of All Suppliers''
		END
		ELSE
		BEGIN
			--SELECT @CompanyName = ''Transaction Report of '' + ISNULL(CompanyName, ''CASH'') FROM Company Where CompanyId = @Id
			SELECT @CompanyName = ''Transaction Report of ('' + ISNULL(Company.CompanyCode, ''CASH'')+ '')['' + ISNULL(Company.CompanyName, ''CASH'') + '']'' FROM Company Where CompanyId = @Id
		END
		
		IF @FromDate IS NULL
			SET @SDate = ''From: N/A''
		ELSE
		BEGIN
			SET @SDate = ''From: '' + CONVERT(nvarchar(50),@FromDate, 103)
			SET @FromDate =DATEADD(SECOND,-1,@FromDate)
		END
		IF @ToDate IS NULL
			SET @EDate = ''To: N/A''
		ELSE
		BEGIN
			SET @EDate = ''To: '' +CONVERT(nvarchar(50),@ToDate, 103)
			SET @ToDate =DATEADD(day,1,@ToDate)
			SET @ToDate =DATEADD(SECOND,-1,@ToDate)
		END

		
		SELECT TransactionId, CONVERT(varchar(50), TransactionDate, 103) as TransactionDate, CompanyName, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE 0.00 end as Credit, 
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE 0.00 end as Debit,
		--ROUND(Amount ,2) as Amount, 
		ROUND(Balance ,2) as Balance
		, case when (@Id IS NULL) then ''('' + CompanyName + '')''+ Comments else Comments end as Comments ,
		ShopName , @SDate as StartDate, @EDate as EndDate, @CompanyName as Company
		FROM Transactions
			LEFT JOIN Company on Transactions.CustomerCompanyId = Company.CompanyId
			Cross JOIN Shop
		WHERE --TransactionDate >= ISNULL(@FromDate, TransactionDate) AND TransactionDate <= ISNULL(@EDate, TransactionDate)
		 --TransactionDate BETWEEN @FromDate AND  @ToDate
		 TransactionDate >= ISNULL(@FromDate,TransactionDate )
		 AND TransactionDate <= ISNULL(@ToDate,TransactionDate )
		AND Transactions.CustomerCompanyId = ISNULL(@Id, Transactions.CustomerCompanyId)
		AND IsCustomer = 0
		order by TransactionId asc	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CompanyPurchaseReportDetailed_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CompanyPurchaseReportDetailed_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_CompanyPurchaseReportDetailed_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CompanyName nvarchar(50)

	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @CompanyName = ''Detailed Purchase Report of All Suppliers''
	END
	ELSE
	BEGIN
		SELECT @CompanyName = ''Detailed Purchase Report of '' + CompanyName  + '' (''+ CompanyCode + '')''  FROM Company Where CompanyId = @Id
	END

	IF @StartDate IS NULL
		SET @SDate = ''N/A''
	ELSE
	BEGIN
		
		SET @SDate = CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''N/A''
	ELSE
	BEGIN
		
		SET @EDate = CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

		SELECT	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo  as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],CompanyName as Company, 
			ItemName as Item, ROUND(InvoiceDetail.PurchasePrice,2) as PurchasePrice, 
			Quantity, ROUND(InvoiceDetail.Total,2) as Total ,
		ShopName , @SDate as StartDate, @EDate as EndDate, @CompanyName as CompanyName
		FROM InvoiceDetail
			INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id
			INNER JOIN Item on InvoiceDetail.ItemId = Item.ItemId
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
			Cross JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Invoice.CompanyId = ISNULL(@Id, Invoice.CompanyId)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CompanyPurchaseReport_Print]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CompanyPurchaseReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_CompanyPurchaseReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CompanyName nvarchar(50)
IF @Id =0
	SET @Id =null
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @CompanyName = ''Purchase Report of All Suppliers''
	END
	ELSE
	BEGIN
		SELECT @CompanyName = ''Purchase Report of '' + CompanyName  + '' (''+ CompanyCode + '')''  FROM Company Where CompanyId = @Id
	END
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
	
		SET @SDate = ''From: '' + CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END


		SELECT	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],
		case when @Id IS NULL then CompanyName else '''' end as Company, 
			ROUND(Invoice.GrandTotal,2) as Total ,
			ROUND(-1*Invoice.Payment,2) as Payment ,Comments,
		ShopName , @SDate as StartDate, @EDate as EndDate, @CompanyName as CompanyName
		FROM Invoice 
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
			Cross JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Invoice.CompanyId = ISNULL(@Id, Invoice.CompanyId)
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_CompanyPurchaseReport]    Script Date: 10/27/2011 17:39:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_CompanyPurchaseReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
@Report =0 -> Product Sales Report
@Report =1 -> Customer Sales Report
@Report =2 -> Company Sales Report
@Report =3 -> Buyer Ledger

Report_CompanyPurchaseReport

*/
CREATE PROCEDURE [dbo].[Report_CompanyPurchaseReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null,
@InDetail	int = 0

AS
BEGIN
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
IF @Id =0
	SET @Id = null
	IF @InDetail = 0
	BEGIN
		SELECT 	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],CompanyName as Company, 
			ROUND(Invoice.GrandTotal,2) as Total ,
			ROUND(-1*Invoice.Payment,2) as Payment 
		FROM Invoice 
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Invoice.CompanyId = ISNULL(@Id, Invoice.CompanyId)
	END
	ELSE
	BEGIN
		SELECT	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],CompanyName as Company, 
			ItemName as Item, ROUND(InvoiceDetail.PurchasePrice,2) as PurchasePrice, 
			Quantity, ROUND(InvoiceDetail.Total,2) as Total 
		FROM InvoiceDetail
			INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id
			INNER JOIN Item on InvoiceDetail.ItemId = Item.ItemId
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Invoice.CompanyId = ISNULL(@Id, Invoice.CompanyId)
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_BuyerLedgerProductWise_Print]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_BuyerLedgerProductWise_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- Report_BuyerLedger_Print
CREATE PROCEDURE [dbo].[Report_BuyerLedgerProductWise_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null

AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)

	IF @Id =0
		SET @Id = null
	IF @StartDate IS NULL
		SET @SDate = ''N/A''
	ELSE
	BEGIN
		
		SET @SDate = CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''N/A''
	ELSE
	BEGIN
	
		SET @EDate = CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
		
	END
	
	
		SELECT	
		Shop.ShopName,
		case when @Id IS NULL then ''ALL Items'' when @Id IS NOT NULL then ItemName + '' (''+ ItemCode + '')'' end as CustomerName ,
		@SDate as ReportStartDate, 
		@EDate as ReportEndDate, 
		ReceiptDetail.ReceiptId as ReceiptNo ,
		CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+case when CustomerCode=''CASH'' then ReceiptCustomerName else CustomerName end as Customer ,
		case when len(Customer.Address) > 0 then Customer.Address else ''N/A'' end as Address, 
		case when len(Receipt.Purpose) > 0 then Receipt.Purpose else ''N/A'' end as Comments, 

		ItemName as Item, 
		Quantity
		FROM ReceiptDetail 
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			CROSS JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId)
		ORDER BY Receipt.Id

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_BuyerLedgerProductWise]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_BuyerLedgerProductWise]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec Report_BuyerLedgerProductWise @ItemId=2
CREATE PROCEDURE [dbo].[Report_BuyerLedgerProductWise]
@StartDate datetime = null,
@EndDate   datetime = null,
@ItemId	int = null

AS
BEGIN
	IF @ItemId =0
		SET @ItemId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
	
		SELECT	ReceiptDetail.ReceiptId as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+case when CustomerCode=''CASH'' then ReceiptCustomerName else CustomerName end as Customer, 
		ISNULL(Receipt.Purpose, '''') as Purpose, ItemName as Item, 
		--case when Quantity < 0 then -1*Quantity else Quantity end as Quantity
		Quantity
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND ReceiptDetail.ItemId = ISNULL(@ItemId, ReceiptDetail.ItemId)
		ORDER BY Receipt.Id

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_BuyerLedger_Print]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_BuyerLedger_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- Report_BuyerLedger_Print @Id=3
CREATE PROCEDURE [dbo].[Report_BuyerLedger_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null

AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @CashId int

	IF @Id =0
		SET @Id = null
	IF @StartDate IS NULL
		SET @SDate = ''N/A''
	ELSE
	BEGIN
		
		SET @SDate = CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''N/A''
	ELSE
	BEGIN
	
		SET @EDate = CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
		
	END
	Select @CashId = CustomerId from Customer Where CustomerCode =''CASH''
	
		SELECT	
		Shop.ShopName,
		case 
			when @Id IS NULL then ''ALL CUSTOMERS'' 
			when @Id =@CashId then ''Cash Customer'' 
			when @Id IS NOT NULL then ReceiptCustomerName + '' (''+ CustomerCode + '')'' end as CustomerName ,
		@SDate as ReportStartDate, 
		@EDate as ReportEndDate, 
		ReceiptDetail.ReceiptId as ReceiptNo ,
		CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+
		case when @Id IS NULL then 
			case when CustomerCode = ''CASH'' then ReceiptCustomerName else Customer.CustomerName end 
		when @Id =@CashId then ReceiptCustomerName
		else '''' end as Customer ,
		 
		case when CustomerCode = ''CASH'' then ReceiptCustomerAddress else
			case when len(Customer.Address) > 0 then Customer.Address else ''N/A'' end 
		end as Address, 
		case when len(Receipt.Purpose) > 0 then Receipt.Purpose else ''N/A'' end as Comments, 

		ItemName as Item, 
		--case when Quantity < 0 then -1*Quantity else Quantity end as Quantity
		Quantity, Packing
		FROM ReceiptDetail 
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			CROSS JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)
		ORDER BY Receipt.Id

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_BuyerLedger]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_BuyerLedger]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec Report_BuyerLedger @ForPrint=1
CREATE PROCEDURE [dbo].[Report_BuyerLedger]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null

AS
BEGIN
	IF @Id =0
		SET @Id = null
		
		
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
	
		SELECT	ReceiptDetail.ReceiptId as ReceiptNo ,CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+case when CustomerCode= ''CASH'' then ReceiptCustomerName else Customer.CustomerName end as Customer, 
		case when CustomerCode= ''CASH'' then ReceiptCustomerAddress else Customer.Address end as [Address], 
		 ItemName as Item, Packing , 
		 Quantity, ISNULL(Receipt.Purpose, '''') as Purpose
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)
		ORDER BY Receipt.Id

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertExceptionLog]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertExceptionLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertExceptionLog]
@Module nvarchar(50),
@Method nvarchar(50),
@Message nvarchar(500)=null,
@StackTrace nvarchar(2500)=null,
@InnerMessage nvarchar(500)=null

AS
BEGIN
INSERT INTO ExceptionLog (
	[ExceptionTime],[Module],[Method],[Message],[StackTrace],[InnerMessage])
VALUES(GetDate(),@Module ,@Method ,@Message ,@StackTrace ,@InnerMessage )

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetNextId]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetNextId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetNextId]
@TableName nvarchar(50)
AS
BEGIN

--SELECT +1 as NextId FROM Invoice

IF LOWER(@TableName) = ''invoice''
SELECT IsNULL(MAX(Id),0)+1 as NextId FROM Invoice
IF LOWER(@TableName) = ''order''
SELECT IsNULL(MAX(Id),0)+1 as NextId FROM [Order]
IF LOWER(@TableName) = ''receipt''
SELECT IsNULL(MAX(Id),0)+1 as NextId FROM Receipt
IF LOWER(@TableName) = ''payment''
SELECT IsNULL(MAX(TransactionId),0)+1 as NextId FROM Transactions
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Admin_InitializeDatabase]    Script Date: 10/27/2011 17:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin_InitializeDatabase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[Admin_InitializeDatabase]
AS
BEGIN
-- Insert Admin User
IF (Select COUNT(*) from [SystemUsers] Where UserName =''Admin'') = 0
BEGIN
INSERT INTO [SystemUsers]([UserName],[Password],[Name],[IsActive],[AllowInvoice],[AllowStock],[AllowCompany]
							,[AllowCustomer],[AllowItem],[AllowShop],[AllowReports],[AllowUserManagement], 
							AllowCompanyPayment, AllowCustomerPayment, AllowReturnPurchase, AllowReturnSale)
	VALUES(''Admin'',''admin'',''Administrator'',1,1,1,1,1,1,1,1,1,1,1,1,1)
END
ELSE 
BEGIN
	print ''Admin User already exists''
END
 --Insert Cash User
IF (Select COUNT(*) from [Customer] Where CustomerCode =''CASH'') = 0
BEGIN
 
INSERT INTO [Customer]([CustomerCode],[CustomerName],[Address],[IsActive])
	VALUES(''CASH'',''Cash Customer'',''N/A'',1)
END
ELSE 
BEGIN
	print ''CASH Customer already exists''
END
	
-- Insert Cash User
--IF (Select COUNT(*) from Customer Where CustomerCode =''Expenses'') = 0
--BEGIN

--INSERT INTO [Customer]([CustomerCode],[CustomerName],[Address],[IsActive])
--	VALUES(''Expenses'',''Expenses Account'',''N/A'',1)
--END
--ELSE 
--BEGIN
--	print ''Expenses Customer already exists''
--END


END
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[fnTable2]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnTable2]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[fnTable2]
(
@StartDate datetime = null,
	@EndDate   datetime = null,
	@Id	int = null
)
RETURNS 
@ResultTable TABLE 
(
	FinalDate Datetime, [IN] int, [OUT] int
)
AS
BEGIN
		IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	INSERT INTO @ResultTable (FinalDate, [IN], [OUT]) 
		SELECT CONVERT(nvarchar(20), Date,23) as Date, SUM(QuantityIn) as [IN], SUM(QuantityOut) as [OUT]
		FROM ProductTransaction
		Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND ItemId = @Id
		Group by CONVERT(nvarchar(20), Date,23)
		
	RETURN 
END
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[fnTable1]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnTable1]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[fnTable1]
(
@StartDate datetime = null,
	@EndDate   datetime = null,
	@Id	int = null
)
RETURNS 
@ResultTable TABLE 
(
	Id bigint, MyDate Datetime
)
AS
BEGIN
		IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	INSERT INTO @ResultTable (Id, MyDate) 
		Select MAX(Id) as StockId , CONVERT(nvarchar(20), [Date],23) as MyDate 
		FROM ProductTransaction
		Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND ItemId = @Id
		Group by CONVERT(nvarchar(20), Date,23)
		
	RETURN 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteItemType]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteItemType]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteItemType]
@Operation int =0, -- o=Insert, 1=Update
@ItemTypeId int =0,
@ItemTypeName nvarchar(500),
@IsActive int
AS
BEGIN
	IF @Operation = 0
	BEGIN
		INSERT INTO ItemType (ItemTypeName, IsActive)
		VALUES(@ItemTypeName, @IsActive)
	END
	ELSE IF @Operation = 1
	BEGIN
		UPDATE ItemType
		SET ItemTypeName = @ItemTypeName
			,IsActive = @IsActive
		WHERE ItemTypeId = @ItemTypeId
	END
	ELSE IF @Operation = 2
	BEGIN
		DELETE FROM ItemType WHERE ItemTypeId = @ItemTypeId
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteItem]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteItem]
@Operation int =0, -- 0=Insert, 1=Update, 2=Delete 
@ItemId int =0,
@ItemCode nvarchar(500),
@ItemName nvarchar(500),
@ItemType int,
@Packing nvarchar(50),
@CompanyId int,
@ItemInStock int,
@PurchasePrice money,
@SalePrice money,
@Discount nvarchar(50),
@IsActive bit,
@BatchNo nvarchar(20),
@ExpiryDate Datetime
AS
BEGIN
	IF @Operation = 0
	BEGIN
		INSERT INTO [Item]
           ([ItemCode]
           ,[ItemName]
           ,[ItemType]
           ,[Packing]
           ,[CompanyId]
           ,[ItemInStock]
           ,[ItemOnOrder]
           ,[PurchasePrice]
           ,[SalePrice]
           ,[Discount]
           ,[StockLimit]
           ,[IsActive] 
           ,[BatchNo],
           [ExpiryDate]
           
           )
     VALUES
           (@ItemCode ,@ItemName ,@ItemType,@Packing,@CompanyId,0,0
           ,@PurchasePrice,@SalePrice,@Discount,@ItemInStock,@IsActive,@BatchNo,@ExpiryDate )
	END
	ELSE IF @Operation = 1
	BEGIN
		UPDATE [Item]
        SET [ItemCode] = @ItemCode
           ,[ItemName] = @ItemName
           ,[ItemType] = @ItemType
           ,[Packing] = @Packing
           ,[CompanyId] = @CompanyId
           ,[StockLimit] = @ItemInStock
           ,[PurchasePrice] = @PurchasePrice
           ,[SalePrice] = @SalePrice
           ,[Discount] = @Discount
           ,[IsActive] = @IsActive,
           [BatchNo]=@BatchNo,
           [ExpiryDate]=@ExpiryDate
       WHERE
			ItemId = @ItemId
	END
	ELSE IF @Operation = 2
	BEGIN
		DELETE FROM Item WHERE ItemId= @ItemId
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertProductTransaction]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertProductTransaction]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertProductTransaction]
	@ItemId int
   ,@InvoiceId  bigint = null
   ,@ReceiptId  bigint =null
   
   ,@QuantityIn int=null
   ,@QuantityOut int=null
AS
BEGIN

	DECLARE @ReturnText nvarchar(50)=''''
	DECLARE @ItemCode  nvarchar(50)=null
	DECLARE @ItemName  nvarchar(50)=null
	DECLARE @Stock int 
	DECLARE @Date datetime
	DECLARE @InvoiceNo nvarchar(100) = null
	DECLARE @CompanyId int=null
	DECLARE @CompanyCode  nvarchar(50)=null
	DECLARE @CompanyName  nvarchar(50)=null
	
	DECLARE @ReceiptNo nvarchar(100) = null
	DECLARE @CustomerId int=null
	DECLARE @CustomerCode  nvarchar(50)=null
	DECLARE @CustomerName  nvarchar(50)=null
	
	Select @ItemCode = ItemCode, @ItemName = ItemName, @Stock = ItemInStock FROM Item Where ItemId = @ItemId
	IF @InvoiceId IS NOT NULL AND @InvoiceId > 0
		SELECT @InvoiceNo = InvoiceNo, @Date = Invoice.Date , @CompanyId = CompanyId, @ReturnText = case when IsReturn=1 then ''[Return Invoice]'' else ''[Invoice]'' end  FROM Invoice wHERE Id =@InvoiceId 
	IF @ReceiptId IS NOT NULL AND @ReceiptId > 0
		SELECT @ReceiptNo = Receipt.Id,  @CustomerId = CustomerId, @Date = Receipt.Date, @ReturnText = case when IsReturn=1 then ''[Return Receipt]'' else ''[Receipt]'' end  FROM Receipt wHERE Id =@ReceiptId
	
	IF @CustomerId IS NOT NULL AND @CustomerId > 0
		SELECT @CustomerCode = CustomerCode, @CustomerName=CustomerName FROM Customer Where CustomerId = @CustomerId
	IF @CompanyId IS NOT NULL AND @CompanyId > 0
		SELECT @CompanyCode = CompanyCode, @CompanyName=CompanyName FROM Company Where CompanyId = @CompanyId
	
	INSERT INTO [ProductTransaction]
           ([ItemId],[ItemCode],[ItemName]
           ,[InvoiceNo],[CompanyCode],[CompanyName]
           ,[ReceiptId],[CustomerCode],[CustomerName]
           ,[Date],[QuantityIn],[QuantityOut],[Stock])
     VALUES
           (@ItemId,@ItemCode,@ItemName
           ,@ReturnText+@InvoiceNo,@CompanyCode,@CompanyName
           ,@ReturnText+@ReceiptNo,@CustomerCode,@CustomerName
           ,@Date,@QuantityIn,@QuantityOut,@Stock)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteOrderDetail]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteOrderDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteOrderDetail]
@OrderId bigint,
@ItemId int,
@PurchasePrice money,
@Quantity int,
@Total money,
@Discount decimal,
@GrandTotal money

AS
BEGIN
	--INSERT INTO OrderDetail ( Id, ItemId, PurchasePrice, Quantity, Total ) 
	--VALUES ( @OrderId, @ItemId, @PurchasePrice, @Quantity, @Total )
	INSERT INTO OrderDetail ( OrderId, ItemId, PurchasePrice, Quantity, Total, Discount, GrandTotal ) 
	VALUES ( @OrderId, @ItemId, @PurchasePrice, @Quantity, @Total , @Discount, @GrandTotal)
	
	Update Item SET ItemOnOrder = ItemOnOrder + @Quantity Where ItemId = @ItemId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SetReceiptProfitLoss]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SetReceiptProfitLoss]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- SetReceiptProfitLoss 4
CREATE PROCEDURE [dbo].[SetReceiptProfitLoss]
@ReceiptId bigint
AS
BEGIN
/*
DECLARE @ProfitLoss money
--Select * from ReceiptDetail
DECLARE @TotalQty int
DECLARE @TotalPP decimal(18,6)
DECLARE @UnitProfitLoss decimal(18,6)
SELECT @TotalPP = SUM(Quantity*PurchasePrice) from ReceiptDetail	 Where ReceiptId = @ReceiptId
--SELECT @UnitProfitLoss = ROUND(Discount/@TotalQty,2) From Receipt Where Id = @ReceiptId
SELECT @UnitProfitLoss = (-1*Total - @TotalPP)/GrandTotal From Receipt Where Id = @ReceiptId
print ''@UnitProfitLoss''
print @UnitProfitLoss
Update ReceiptDetail 
	SET ProfitLoss = ROUND(Total*@UnitProfitLoss,0) --ROUND( (Quantity *(SalePrice - PurchasePrice)- Total *@UnitProfitLoss),2)
WHERE ReceiptId = @ReceiptId

SELECT @ProfitLoss = SUM(ProfitLoss) from ReceiptDetail Where ReceiptId = @ReceiptId

UPDATE Receipt 
	SET ProfitLoss = @ProfitLoss
WHERE Id = @ReceiptId

*/
-- Straight ProfitLoss
DECLARE @ProfitLoss money
DECLARE @AllDiscount money
DECLARE @UnitDiscount money
DECLARE @TotalItems int

Update ReceiptDetail 
SET ProfitLoss = case when Quantity < 0 then ROUND( Total + PurchasePrice*Quantity ,0)*-1 else 
ROUND( Total - PurchasePrice*Quantity ,0) end
WHERE ReceiptId = @ReceiptId

SELECT @AllDiscount = case when IsReturn =1 then -1*Discount else Discount end FROM Receipt Where Id = @ReceiptId
SELECT @TotalItems = SUM(Quantity) FROM ReceiptDetail Where ReceiptId = @ReceiptId
SET @UnitDiscount = @AllDiscount/@TotalItems

Update ReceiptDetail 
SET ProfitLoss = case when Quantity < 0 then ProfitLoss + ROUND( @UnitDiscount*Quantity ,0)*-1 else ProfitLoss - ROUND( @UnitDiscount*Quantity ,0)  end
WHERE ReceiptId = @ReceiptId

SELECT @ProfitLoss = SUM(ProfitLoss) from ReceiptDetail Where ReceiptId = @ReceiptId

UPDATE Receipt 
	SET ProfitLoss = @ProfitLoss
WHERE Id = @ReceiptId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserLog]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SelectUserLog]
@UserId int=null,
@StartTicks datetime=null,
@EndTicks datetime=null

AS
BEGIN
SELECT DateTime as [Time], su.UserName, su.Name, [Description] as [Action], ActionDetails as Details FROM UserLog ul
	LEFT OUTER JOIN SystemUsers su on ul.UserId = su.Id
	INNER JOIN UserAction ua on ul.ActionId = ua.Id
WHERE UserId = ISNULL(@UserId,UserId)
AND DateTime >= ISNULL(@StartTicks,DateTime)
AND DateTime <= ISNULL(@EndTicks,DateTime)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUser]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUser]
@Id int =null,
@UserName nvarchar(300)=null,
@Name    nvarchar(300)=null
 
AS
 
 
BEGIN
	SELECT * FROM SystemUsers    WHERE Id=ISNULL(@Id,Id)
	AND UserName LIKE ''%''+ISNULL( @UserName,'''')+''%''
	AND IsNULL(Name,'''') LIKE ''%''+ISNULL( @Name,'''')+''%''
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactions]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTransactions]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectTransactions @CustomerCompanyId = 0, @IsCustomer=1
CREATE PROCEDURE [dbo].[SelectTransactions]
@TransactionId int = 0,
@CustomerCompanyId int = null,
@FromTransactionDate datetime=null ,
@ToTransactionDate datetime=null ,
@IsCustomer smallint =1
AS
BEGIN
--SET @FromTransactionDate =DATEADD(day,-1,@FromTransactionDate)
if @FromTransactionDate IS NOT null
BEGIN
	SET @FromTransactionDate =DATEADD(SECOND,-1,@FromTransactionDate)
END
if @ToTransactionDate IS NOT null
BEGIN
	SET @ToTransactionDate =DATEADD(day,1,@ToTransactionDate)
	SET @ToTransactionDate =DATEADD(SECOND,-1,@ToTransactionDate)
END

 IF @CustomerCompanyId IS NULL OR @CustomerCompanyId=0
	BEGIN
		IF @IsCustomer = 1
		BEGIN
			SELECT TransactionId, TransactionDate, --CONVERT(nvarchar(20), TransactionDate,103) as TransactionDate, 
			case when CustomerCode=''CASH'' then CustomerCode else CustomerName end  as [Name], 
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE 0.00 end as Debit, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE 0.00 end as Credit, 
			--ROUND(Amount ,2) as Amount, 
			ROUND(Balance ,2) as Balance
			, Comments
			FROM Transactions
				LEFT JOIN Customer on Customer.CustomerId = Transactions.CustomerCompanyId
			WHERE TransactionDate >= isnull(@FromTransactionDate, TransactionDate )
			and TransactionDate <= isnull(@ToTransactionDate, TransactionDate )
			AND IsCustomer = 1
			order by TransactionId asc	
		END
		ELSE
		BEGIN
			SELECT TransactionId, TransactionDate, --CONVERT(nvarchar(20), TransactionDate,103) as TransactionDate, 
			 ISNULL(Company.CompanyName, ''CASH'')  as [Name], 
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE 0.00 end as Debit, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE 0.00 end as Credit, 
			--ROUND(Amount ,2) as Amount, 
			ROUND(Balance ,2) as Balance
			, Comments
			FROM Transactions
				LEFT JOIN Company on Company.CompanyId = Transactions.CustomerCompanyId
			--WHERE TransactionDate BETWEEN @FromTransactionDate AND  @ToTransactionDate
			WHERE TransactionDate >= isnull(@FromTransactionDate, TransactionDate )
				and TransactionDate <= isnull(@ToTransactionDate, TransactionDate )

			AND IsCustomer = 0
			order by TransactionId asc
		END
	END
	ELSE IF @IsCustomer = 1
	BEGIN
		SELECT TransactionId, TransactionDate,--CustomerName, --CONVERT(nvarchar(20), TransactionDate,103) as TransactionDate, 
		 --ISNULL(Customer.CustomerName, ''CASH'')  as [Name],
		 case when CustomerCode=''CASH'' then CustomerCode else CustomerName end  as [Name], 
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE 0.00 end as Debit, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE 0.00 end as Credit, 
			--ROUND(Amount ,2) as Amount, 
			ROUND(Balance ,2) as Balance
		, Comments
		FROM Transactions
			LEFT JOIN Customer on Customer.CustomerId = Transactions.CustomerCompanyId
		WHERE CustomerCompanyId = @CustomerCompanyId
		--AND TransactionDate BETWEEN @FromTransactionDate AND  @ToTransactionDate
		AND TransactionDate >= isnull(@FromTransactionDate, TransactionDate )
				and TransactionDate <= isnull(@ToTransactionDate, TransactionDate )

		AND IsCustomer = 1
		order by TransactionId asc	
	END
	ELSE 
	BEGIN
		SELECT TransactionId, TransactionDate, --CONVERT(nvarchar(20), TransactionDate,103) as TransactionDate, 
		ISNULL(Company.CompanyName, ''CASH'')  as [Name],
			case when Amount < 0 Then ROUND(-1*Amount ,2) ELSE 0.00 end as Debit, 
			case when Amount > 0 Then ROUND(Amount ,2) ELSE 0.00 end as Credit, 
			--ROUND(Amount ,2) as Amount, 
			ROUND(Balance ,2) as Balance
		, Comments
		FROM Transactions
			LEFT JOIN Company on Company.CompanyId = Transactions.CustomerCompanyId
		WHERE CustomerCompanyId = @CustomerCompanyId
				AND TransactionDate >= isnull(@FromTransactionDate, TransactionDate )
				and TransactionDate <= isnull(@ToTransactionDate, TransactionDate )
		AND IsCustomer = 0
		order by TransactionId asc	
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTransaction_Print]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTransaction_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--exec SelectTransactions 0,''2011/01/17'', ''2011/01/17'' , 0
CREATE PROCEDURE [dbo].[SelectTransaction_Print]
@TransactionId bigint ,
@IsCustomer smallint 
AS
BEGIN
	IF @TransactionId > 0
	BEGIN
	IF @IsCustomer = 1
		BEGIN
			SELECT 
			Shop.ShopName,''CUSTOMER PAYMENT SLIP'' Title,
			Shop.ShopAddress,Shop.RegistrationNumber,Shop.ShopNumber,        
			TransactionId, TransactionDate,
			Customer.CustomerCode as [Code], Customer.CustomerName as [Name], 
			case when Amount > 0 Then ''RS. '' +  CONVERT(NVARCHAR(50), ROUND(Amount ,2)) +  '' has been Credited to  "'' + Customer.CustomerName + '' ('' + Customer.CustomerCode + '')" account.''  
			when Amount < 0 Then ''RS. '' +  CONVERT(NVARCHAR(50), ROUND(-1*Amount ,2)) +  '' has been Debited to  "'' + Customer.CustomerName + '' ('' + Customer.CustomerCode + '')" account.'' 
			end as Credit,
			null as Debit, 
			ROUND(Balance ,2) as Balance
			, Comments
			FROM Transactions
				LEFT JOIN Customer on Customer.CustomerId = Transactions.CustomerCompanyId
				CROSS JOIN Shop
			WHERE TransactionId = @TransactionId
			AND IsCustomer = 1
			order by TransactionId asc	
		END
	ELSE
		BEGIN
			SELECT 
			Shop.ShopName,''SUPPLIER PAYMENT SLIP'' Title,
			Shop.ShopAddress,Shop.RegistrationNumber,Shop.ShopNumber, 
			TransactionId, TransactionDate,
			Company.CompanyCode as [Code],  Company.CompanyName as [Name],  
			case when Amount > 0 Then ''RS. '' +  CONVERT(NVARCHAR(50), ROUND(Amount ,2)) +  '' has been Credited to "'' + Company.CompanyName + '' ('' + Company.CompanyCode + '')" account.''  
			when Amount < 0 Then ''RS. '' +  CONVERT(NVARCHAR(50), ROUND(-1*Amount ,2)) +  '' has been Debited to "'' + Company.CompanyName + '' ('' + Company.CompanyCode + '')" account.'' 
			end as Credit,
			null as Debit, 
			ROUND(Balance ,2) as Balance
			, Comments
			FROM Transactions
				LEFT JOIN Company on Company.CompanyId = Transactions.CustomerCompanyId
				CROSS JOIN Shop
			WHERE TransactionId = @TransactionId
			AND IsCustomer = 0
			order by TransactionId asc
		END
	END
		
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectShop]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectShop]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectCompany @CompanyName =''M''
CREATE PROCEDURE [dbo].[SelectShop]
AS
BEGIN
	SELECT *
	FROM Shop Where ShopName IS NOT NULL
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectReceiptSummary]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectReceiptSummary]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectReceiptSummary]
@ReceiptId bigint=0,
@CustomerId int =0,
@StartDate datetime =null,
@EndDate datetime =null
AS
BEGIN
	SET NOCOUNT ON;
	IF @ReceiptId < 1
		SET @ReceiptId = null
	IF @CustomerId < 1
		SET @CustomerId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT ROW_NUMBER() 
        OVER (ORDER BY Receipt.Id) AS RowNo, 
        Receipt.Id as ReceiptNo, CONVERT(varchar(50), Receipt.Date, 103) as ReceiptDate,
        Customer.CustomerId,CustomerName,CustomerCode, 
        ISNULL(Customer.Address, ''N/A'') as CustomerAddress, 
        ROUND(IsNull(CustomerBalance,0) ,2) as CustomerBalance,
        Receipt.Comments,
        ROUND(Receipt.GrandTotal ,2) as ReceiptGrandTotal,
        ROUND(IsNull(Receipt.Discount,0) ,2) as ReceiptDiscount,
        ROUND(-1*Receipt.Total ,2) as ReceiptTotal,
        ROUND(Receipt.Expenses ,2) as Expenses,
        ROUND(Receipt.Payment ,2) as Payment,
        ROUND(IsNull(Receipt.Arearrs,0) ,2) as Arearrs        
    FROM Receipt 
		INNER JOIN Customer on Customer.CustomerId = Receipt.CustomerId
		
    WHERE Receipt.Id = ISNULL(@ReceiptId, Receipt.Id)
    AND Receipt.CustomerId = ISNULL(@CustomerId, Receipt.CustomerId)
    AND Receipt.Date >= ISNULL(@StartDate, Receipt.Date)
    AND Receipt.Date <= ISNULL(@EndDate, Receipt.Date)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectReceiptandReceiptDetails]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectReceiptandReceiptDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectReceiptandReceiptDetails]
@ReceiptId bigint=0,
@CustomerId int =0,
@StartDate datetime =null,
@EndDate datetime =null

AS
BEGIN
	SET NOCOUNT ON;
	IF @ReceiptId < 1
		SET @ReceiptId = null
	IF @CustomerId < 1
		SET @CustomerId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT 
        Receipt.Id ,
        CONVERT(varchar(50), Receipt.Date, 103) as [Date],
        case when CustomerCode=''CASH'' then ReceiptCustomerName else CustomerName end as [Name],
        CustomerCode as Code, 
        ROUND(GrandTotal ,2) as GrandTotal, 
        ROUND(Discount ,2) as Discount, 
        ROUND(-1*Total ,2) as NetTotal, 
        ROUND(Payment ,2) as Payment	, 
        ROUND(Arearrs ,2) as Arearrs, 
        CASE ISReturn When 0 THEN ''NO'' ELSE ''Return'' END as IsReturn	
    FROM  Receipt 
		INNER JOIN Customer on Customer.CustomerId = Receipt.CustomerId
    WHERE Receipt.Id = ISNULL(@ReceiptId, Receipt.Id)
    AND Receipt.CustomerId = ISNULL(@CustomerId, Receipt.CustomerId)
    AND Receipt.Date >= ISNULL(@StartDate, Receipt.Date)
    AND Receipt.Date <= ISNULL(@EndDate, Receipt.Date)

	SELECT ReceiptId,  ItemCode as Code, ItemName as [Name], Packing as Pack,
		ROUND(ReceiptDetail.SalePrice ,2) as SalePrice , Quantity as Qty,  
		ROUND(ReceiptDetail.GrandTotal ,2) as Total , 
		ROUND(ReceiptDetail.Discount ,2) as Disc, 
        ROUND(ReceiptDetail.Total ,2) as NetTotal 
    FROM ReceiptDetail
		INNER JOIN Receipt on Receipt.Id = ReceiptDetail.ReceiptId
		INNER JOIN Customer on Customer.CustomerId = Receipt.CustomerId
		INNER JOIN Item on Item.ItemId = ReceiptDetail.ItemId
    WHERE ReceiptId = ISNULL(@ReceiptId, ReceiptId)
    AND Receipt.CustomerId = ISNULL(@CustomerId, Receipt.CustomerId)
    AND Receipt.Date >= ISNULL(@StartDate, Receipt.Date)
    AND Receipt.Date <= ISNULL(@EndDate, Receipt.Date)
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectReceipt]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectReceipt]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectReceipt 7
CREATE PROCEDURE [dbo].[SelectReceipt]
@ReceiptId bigint=0,
@CustomerId int =0,
@StartDate datetime =null,
@EndDate datetime =null

AS
BEGIN
	SET NOCOUNT ON;
	IF @ReceiptId < 1
		SET @ReceiptId = null
	IF @CustomerId < 1
		SET @CustomerId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT ROW_NUMBER() 
        OVER (ORDER BY ReceiptDetail.Id) AS RowNo, 
        Shop.ShopName,''SALE RECEIPT'' Title,
        Shop.ShopAddress,Shop.RegistrationNumber,Shop.ShopNumber,
        case when Receipt.IsReturn =1 then ''RETURN RECEIPT'' else  SaleNote end as SaleNote  ,
        Receipt.Id as ReceiptNo, CONVERT(varchar(50), Receipt.Date, 103) as ReceiptDate,
        Customer.CustomerId,
        case when CustomerCode=''CASH'' then ReceiptCustomerName else Customer.CustomerName end as  CustomerName,
        CustomerCode, 
        case when CustomerCode =''CASH'' then ReceiptCustomerAddress else Customer.Address end as CustomerAddress,
         
        ROUND(IsNull(CustomerBalance,0) ,2) as CustomerBalance,
        Receipt.Comments, Receipt.Purpose,
        ROUND(Receipt.GrandTotal ,2) as ReceiptGrandTotal,
        ROUND(IsNull(Receipt.Discount,0) ,2) as ReceiptDiscount,
        ROUND(-1*Receipt.Total ,2) as ReceiptTotal,
        ROUND(Receipt.Expenses ,2) as Expenses,
        ROUND(Receipt.Payment ,2) as Payment,
        ROUND(IsNull(Receipt.Arearrs,0) ,2) as Arearrs,
        
        ReceiptDetail.ItemId,ItemCode, ItemName,ISNULL(Packing,''N/A'') as Packing, 
        ROUND(ReceiptDetail.SalePrice ,2) as SalePrice , 
        ROUND(ReceiptDetail.PurchasePrice ,2) as PurchasePrice , 
        Quantity, 
        ROUND(ReceiptDetail.GrandTotal ,2) as ReceiptDetailGrandTotal , 
        ROUND(IsNull(ReceiptDetail.Discount,0) ,2) as ReceiptDetailDiscount , 
        ROUND(IsNull(ReceiptDetail.Total,0) ,2) as ReceiptDetailTotal ,
        ROUND(IsNull(ItemDiscount,0) ,2) as ItemDiscount
        
    FROM ReceiptDetail
		INNER JOIN Receipt on Receipt.Id = ReceiptDetail.ReceiptId
		INNER JOIN Customer on Customer.CustomerId = Receipt.CustomerId
		INNER JOIN Item on Item.ItemId = ReceiptDetail.ItemId
		CROSS JOIN  Shop 
		
    WHERE ReceiptId = ISNULL(@ReceiptId, ReceiptId)
    AND Receipt.CustomerId = ISNULL(@CustomerId, Receipt.CustomerId)
    AND Receipt.Date >= ISNULL(@StartDate, Receipt.Date)
    AND Receipt.Date <= ISNULL(@EndDate, Receipt.Date)
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectOrderandOrderDetails]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectOrderandOrderDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectOrderandOrderDetails 4, null, null, null
CREATE PROCEDURE [dbo].[SelectOrderandOrderDetails]
@OrderId bigint=0,
@CompanyId int =0,
@StartDate datetime =null,
@EndDate datetime =null

AS
BEGIN
	SET NOCOUNT ON;
	IF @OrderId < 1
		SET @OrderId = null
	IF @CompanyId < 1
		SET @CompanyId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT 
        ordr.Id ,
        CONVERT(varchar(50), ordr.Date, 103) as [Date],
        CompanyName,CompanyCode , ordr.CompanyId , CompanyBalance ,
        ROUND(ordr.GrandTotal ,2) as GrandTotal, 
        ROUND(Discount ,2) as Discount	, 
        ROUND(Payment ,2) as Payment	, 
        ROUND(Arrears ,2) as Arrears	, 
        Comments	
    FROM  [Order] AS ordr 
		INNER JOIN Company on Company.CompanyId = ordr.CompanyId
    WHERE ordr.Id = ISNULL(@OrderId, ordr.Id)
    AND ordr.CompanyId = ISNULL(@CompanyId, ordr.CompanyId)
    AND ordr.Date >= ISNULL(@StartDate, ordr.Date)
    AND ordr.Date <= ISNULL(@EndDate, ordr.Date)

	SELECT OrderId, Item.ItemId, ItemCode, Item.ItemName, 
		ROUND(OrderDetail.PurchasePrice ,2) as PurchasePrice , 
		Quantity as Quantity , 
		ROUND(OrderDetail.GrandTotal,2) as GrandTotal , 
		Round(OrderDetail.Discount,2) as Discount,
		ROUND(OrderDetail.Total ,2) as Total 
    FROM OrderDetail
		INNER JOIN [Order] as ordr on ordr.Id = OrderDetail.OrderId
		INNER JOIN Company on Company.CompanyId = ordr.CompanyId
		INNER JOIN Item on Item.ItemId = OrderDetail.ItemId
    WHERE OrderId = ISNULL(@OrderId, OrderId)
    AND ordr.CompanyId = ISNULL(@CompanyId, ordr.CompanyId)
    AND ordr.Date >= ISNULL(@StartDate, ordr.Date)
    AND ordr.Date <= ISNULL(@EndDate, ordr.Date)
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectItemType]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectItemType]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectCompany @CompanyName =''M''
CREATE PROCEDURE [dbo].[SelectItemType]
@ItemTypeId int=null,
--@isActive int =1
@isActive int=null
AS
IF @isActive <> 1
	SET @isActive=null
BEGIN
	SELECT *
	FROM ItemType 
	WHERE ItemTypeId = ISNULL(@ItemTypeId, ItemTypeId)
	AND ItemType.IsActive= ISNULL(@isActive,ItemType.IsActive)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectItem_Print]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectItem_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectItem_Print @isActive=0, @CompanyId=1
CREATE PROCEDURE [dbo].[SelectItem_Print]
@isActive int=1,
@CompanyId int=0
AS
BEGIN
DECLARE @ShopName nvarchar(200)
DECLARE @Title nvarchar(200)
DECLARE @ShopAddress nvarchar(500)
DECLARE @RegistrationNumber nvarchar(200)
DECLARE @ShopNumber nvarchar(200)
DECLARE @SupplierReport bit
DECLARE @SupplierName nvarchar(50)
SET @SupplierReport =0
SET @SupplierName = ''Items List''
SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress,@RegistrationNumber = RegistrationNumber,@ShopNumber = ShopNumber 	From Shop

IF @isActive <> 1
	SET @isActive=null
IF @CompanyId > 0
BEGIN
	SET @isActive=1
	SET @SupplierReport = 1
	SELECT @SupplierName = ''Item List of Supplier ['' + Company.CompanyName + '']'' from Company Where Company.CompanyId = @CompanyId
END
IF @CompanyId < 1
	SET @CompanyId=null
	SELECT 
	@ShopName as ShopName, 
	@SupplierName  as Title,
	 @ShopAddress as ShopAddress, @RegistrationNumber as RegistrationNumber, @ShopNumber as ShopNumber ,
	
	ItemId,ItemCode , ItemName, 
	Packing, 
	case when @SupplierReport = 1 then '''' else CompanyName end as CompanyName,
	ItemTypeName,
	ROUND(SalePrice,2) as SalePrice
	FROM Item
	INNER JOIN ItemType on ItemType.ItemTypeId = ItemType
	INNER JOIN Company on Company.CompanyId = Item.CompanyId
	WHERE Item.IsActive = ISNULL(@isActive,Item.IsActive)
	AND Item.CompanyId = ISNULL(@CompanyId,Item.CompanyId)
	order by ItemName
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectItem]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectItem @CompanyId=1,  @Operation=1
CREATE PROCEDURE [dbo].[SelectItem]
@ItemId int=null,
@ItemCode nvarchar(500) = null,
@ItemName nvarchar(500) = null,
@ItemType int = null,
@CompanyId int = null,
@Operation int=0,
@isActive int=1
AS
--exec SelectItem null null 
IF @isActive <> 1
	SET @isActive=null
IF @Operation=0
BEGIN
	SELECT ItemId,Item.CompanyId,CompanyCode,ItemCode,ItemName,--Item.ItemType, 
	Packing, CompanyName,
	ItemTypeName,ItemInStock,ItemOnOrder,
	ROUND(PurchasePrice,2) as PurchasePrice,
	ROUND(SalePrice,2) as SalePrice,
	Discount as "Discount%", 
	Item.StockLimit,  Item.IsActive		--,  BatchNo,ExpiryDate
	FROM Item
	INNER JOIN ItemType on ItemType.ItemTypeId = ItemType
	INNER JOIN Company on Company.CompanyId = Item.CompanyId
	WHERE ItemId = ISNULL(@ItemId, ItemId)
	AND ItemCode like ''%'' + ISNULL(@ItemCode,'''') + ''%''
	AND ItemName like ''%'' + ISNULL(@ItemName,'''') + ''%''
	AND ItemType = ISNULL(@ItemType, ItemType)
	AND Item.CompanyId = ISNULL(@CompanyId, Item.CompanyId)
	AND Item.IsActive = ISNULL(@isActive,Item.IsActive)
END
ELSE IF @Operation=1
BEGIN
	SELECT ItemCode , ItemInStock,ItemOnOrder, StockLimit,ItemId,Item.CompanyId, 
	Item.ItemType,ItemCode , ItemName, 
	Packing, ItemInStock,ItemOnOrder,
	ROUND(PurchasePrice,2) as PurchasePrice,
	ROUND(SalePrice,2) as SalePrice,
	Discount 
 
	FROM Item
	WHERE Item.CompanyId = ISNULL(@CompanyId, Item.CompanyId)
	AND IsActive=1
	order by ItemName 
END
ELSE IF @Operation=2
BEGIN
	SELECT ItemCode , ItemInStock,ItemOnOrder, StockLimit,ItemId,Item.CompanyId, 
	Item.ItemType,ItemCode , ItemName, 
	Packing, ItemInStock,ItemOnOrder,
	ROUND(PurchasePrice,2) as PurchasePrice,
	ROUND(SalePrice,2) as SalePrice,
	Discount 
 
	FROM Item
	WHERE StockLimit >= ItemInStock
		AND ItemId in ( Select distinct ItemId from InvoiceDetail )
	AND IsActive=1
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoiceSummary]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectInvoiceSummary]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectInvoiceSummary]
@InvoiceId bigint=0,
@CompanyId int =0,
@StartDate datetime =null,
@EndDate datetime =null
AS
BEGIN
	SET NOCOUNT ON;
	IF @InvoiceId < 1
		SET @InvoiceId = null
	IF @CompanyId < 1
		SET @CompanyId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT ROW_NUMBER() 
        OVER (ORDER BY Invoice.Id) AS RowNo, 
        Invoice.Id as InvoiceNo, CONVERT(varchar(50), Invoice.Date, 103) as InvoiceDate, Invoice.InvoiceNo,
        Company.CompanyId,CompanyName,CompanyCode, 
        ISNULL(Company.Address, ''N/A'') as CompanyAddress, 
        ROUND(IsNull(CompanyBalance,0) ,2) as CompanyBalance,
        Invoice.Comments,
        ROUND(Invoice.GrandTotal ,2) as InvoiceGrandTotal,
        ROUND(IsNull(Invoice.Discount,0) ,2) as InvoiceDiscount,
        ROUND((Invoice.GrandTotal - Invoice.Discount) ,2) as InvoiceTotal,
        ROUND(-1*Invoice.Payment ,2) as Payment
    FROM Invoice 
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
		
    WHERE Invoice.Id = ISNULL(@InvoiceId, Invoice.Id)
    AND Invoice.CompanyId = ISNULL(@CompanyId, Invoice.CompanyId)
    AND Invoice.Date >= ISNULL(@StartDate, Invoice.Date)
    AND Invoice.Date <= ISNULL(@EndDate, Invoice.Date)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoiceOrder]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectInvoiceOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectInvoiceOrder @InvoiceOrderId=2, @IsInvoice=1
CREATE PROCEDURE [dbo].[SelectInvoiceOrder]
@InvoiceOrderId bigint=0,
@CompanyId int =0,
@StartDate datetime =null,
@EndDate datetime =null,
@IsInvoice bit =1


AS
BEGIN
	SET NOCOUNT ON;
	IF @InvoiceOrderId < 1
		SET @InvoiceOrderId = null
	IF @CompanyId < 1
		SET @CompanyId = null
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
IF @IsInvoice = 1
BEGIN

	SELECT ROW_NUMBER() 
        OVER (ORDER BY InvoiceDetail.Id) AS RowNo, 
        ''INVOICE'' as Title,
        Shop.ShopName,
        Shop.ShopAddress,Shop.RegistrationNumber,Shop.ShopNumber,
        Invoice.Id as [No], CONVERT(varchar(50), Invoice.Date, 103) as Date, ''Invoice No : '' + Invoice.InvoiceNo as InvoiceOrderNo,
        Company.CompanyId,CompanyName,CompanyCode, 
        ISNULL(Company.Address, ''N/A'') as CompanyAddress, 
        ROUND(IsNull(CompanyBalance,0) ,2) as CompanyBalance,
        Invoice.Comments, OrderNo,
        case when Invoice.GrandTotal  < 0 then ROUND(-1*Invoice.GrandTotal ,2) else ROUND(Invoice.GrandTotal ,2) end as GrandTotal,
        ROUND(IsNull(Invoice.Discount,0) ,2) as Discount,
        ROUND(Invoice.GrandTotal-Invoice.Discount ,2) as Total,
        ROUND(-1*Invoice.Payment ,2) as Payment,
        ROUND(IsNull(Invoice.Arrears,0) ,2) as Arrears,
        '''' as DeliveryDate,
        InvoiceDetail.ItemId,ItemCode, ItemName,ISNULL(Packing,''N/A'') as Packing, 
        ROUND(InvoiceDetail.PurchasePrice ,2) as Price , 
        case when Quantity < 0 then -1*Quantity else Quantity end as Quantity , 
        ROUND(InvoiceDetail.GrandTotal ,2) as DetailGrandTotal , 
        ROUND(IsNull(InvoiceDetail.Discount,0) ,2) as DetailDiscount , 
        ROUND(IsNull(InvoiceDetail.Total,0) ,2) as DetailTotal 
    FROM InvoiceDetail
		INNER JOIN Invoice on Invoice.Id = InvoiceDetail.InvoiceId
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
		INNER JOIN Item on Item.ItemId = InvoiceDetail.ItemId
		CROSS JOIN  Shop 
		
    WHERE InvoiceId = ISNULL(@InvoiceOrderId, InvoiceId)
    AND Invoice.CompanyId =ISNULL(@CompanyId, Invoice.CompanyId) 
    AND Invoice.Date >= ISNULL(@StartDate, Invoice.Date)
    AND Invoice.Date <= ISNULL(@EndDate, Invoice.Date)
END

ELSE
BEGIN
		SELECT ROW_NUMBER() 
        OVER (ORDER BY OrderDetail.Id) AS RowNo, 
        ''ORDER'' as Title,
        Shop.ShopName,
        Shop.ShopAddress,Shop.RegistrationNumber,Shop.ShopNumber,
        ordr.Id as [No], CONVERT(varchar(50), ordr.Date, 103) as Date, ''Order No : '' + CONVERT( nvarchar(50), OrderId)  as InvoiceOrderNo,
        Company.CompanyId,CompanyName,CompanyCode, 
        ISNULL(Company.Address, ''N/A'') as CompanyAddress, 
        ROUND(IsNull(CompanyBalance,0) ,2) as CompanyBalance,
        ordr.Comments,
         case when ordr.GrandTotal  < 0 then ROUND(-1*ordr.GrandTotal ,2) else ROUND(ordr.GrandTotal ,2) end as GrandTotal,
        ROUND(IsNull(ordr.Discount,0) ,2) as Discount,
        ROUND(ordr.GrandTotal ,2) as Total,
        ROUND(ordr.Payment ,2) as Payment,
        ROUND(IsNull(ordr.Arrears,0) ,2) as Arrears,
        ''Expected Delivery Date: ''+ CONVERT(nvarchar(25), DeliveryDate) as DeliveryDate,
        OrderDetail.ItemId,ItemCode, ItemName,ISNULL(Packing,''N/A'') as Packing, 
        ROUND(OrderDetail.PurchasePrice ,2) as Price , 
        case when Quantity < 0 then -1*Quantity else Quantity end as Quantity , 
        ROUND(OrderDetail.GrandTotal ,2) as DetailGrandTotal , 
        ROUND(IsNull(OrderDetail.Discount,0) ,2) as DetailDiscount , 
        ROUND(IsNull(OrderDetail.Total,0) ,2) as DetailTotal 
    FROM OrderDetail
		INNER JOIN [Order] as ordr on ordr.Id = OrderDetail.OrderId
		INNER JOIN Company on Company.CompanyId = ordr.CompanyId
		INNER JOIN Item on Item.ItemId = OrderDetail.ItemId
		CROSS JOIN  Shop 
		
    WHERE ordr.Id = ISNULL(@InvoiceOrderId, ordr.Id)
    AND ordr.CompanyId = ISNULL(@CompanyId, ordr.CompanyId) 
    AND ordr.Date >= ISNULL(@StartDate, ordr.Date)
    AND ordr.Date <= ISNULL(@EndDate, ordr.Date)

END	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoicedDetailById]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectInvoicedDetailById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectInvoicedDetailById] 
@InvoiceNo bigint=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		--IF @InvoiceNo < 1
		--SET @InvoiceNo = null
		SELECT 
        Invoice.Id ,
        CONVERT(varchar(50), Invoice.Date, 103) as [Date],InvoiceNo,
        CompanyName as [Name],CompanyCode as Code, 
        ROUND(GrandTotal ,2) as GrandTotal, 
        ROUND(Discount ,2) as Discount	, 
        ROUND(-1*Payment ,2) as Payment	, 
        ROUND(Arrears ,2) as Arrears	, 
        Comments	, OrderNo,
        CASE ISReturn When 0 THEN ''NO'' ELSE ''Return'' END as IsReturn	
    FROM  Invoice 
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
	   WHERE Invoice.InvoiceNo=@InvoiceNo--ISNULL(@InvoiceNo,Invoice.InvoiceNo)
	   
	   
	   SELECT InvoiceId, InvoiceNo,  ItemCode, Item.ItemName, 
		ROUND(InvoiceDetail.PurchasePrice ,2) as PurchasePrice , 
		Quantity as Quantity , 
		ROUND(InvoiceDetail.GrandTotal,2) as GrandTotal , 
		Round(InvoiceDetail.Discount,2) as Discount,
		ROUND(InvoiceDetail.Total ,2) as Total 
    FROM InvoiceDetail
		INNER JOIN Invoice on Invoice.Id = InvoiceDetail.InvoiceId
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
		INNER JOIN Item on Item.ItemId = InvoiceDetail.ItemId
    --WHERE InvoiceId = ISNULL(@InvoiceId, InvoiceId)
    --WHERE Invoice.InvoiceNo=ISNULL(@InvoiceNo,Invoice.InvoiceNo)
      WHERE Invoice.InvoiceNo=@InvoiceNo
    
    
END
--exec SelectInvoicedDetailById 0001
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoiceandInvoiceDetails]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectInvoiceandInvoiceDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' -- exec SelectInvoiceandInvoiceDetails ''1''
CREATE PROCEDURE [dbo].[SelectInvoiceandInvoiceDetails]
@InvoiceId nvarchar(50)=null,
@CompanyId int =null,
@StartDate datetime =null,
@EndDate datetime =null

AS
BEGIN
	SET NOCOUNT ON;
	--IF @InvoiceId < 1
	--	SET @InvoiceId = null
	IF @CompanyId < 1
		SET @CompanyId = null
	IF @StartDate IS NOT NULL
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	IF @EndDate IS NOT NULL
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		
	SELECT 
        Invoice.Id ,
        CONVERT(varchar(50), Invoice.Date, 103) as [Date],InvoiceNo,
        Company.CompanyId, CompanyName as [Name],CompanyCode as Code, 
        ROUND(GrandTotal ,2) as GrandTotal, 
        ROUND(Discount ,2) as Discount	, 
        ROUND(-1*Payment ,2) as Payment	, 
        ROUND(Arrears ,2) as Arrears	, 
        Comments	, OrderNo,
        CASE ISReturn When 0 THEN ''NO'' ELSE ''Return'' END as IsReturn	
    FROM  Invoice 
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
	   WHERE Invoice.InvoiceNo=ISNULL(@InvoiceId,Invoice.InvoiceNo)
		AND Invoice.CompanyId = ISNULL(@CompanyId, Invoice.CompanyId)
		AND Invoice.Date >= ISNULL(@StartDate, Invoice.Date)
		AND Invoice.Date <= ISNULL(@EndDate, Invoice.Date)

	SELECT InvoiceId, InvoiceNo, InvoiceDetail.ItemId, ItemCode, Item.ItemName, 
		ROUND(InvoiceDetail.PurchasePrice ,2) as PurchasePrice , 
		Quantity as Quantity , 
		ROUND(InvoiceDetail.GrandTotal,2) as GrandTotal , 
		Round(InvoiceDetail.Discount,2) as Discount,
		ROUND(InvoiceDetail.Total ,2) as Total 
    FROM InvoiceDetail
		INNER JOIN Invoice on Invoice.Id = InvoiceDetail.InvoiceId
		INNER JOIN Company on Company.CompanyId = Invoice.CompanyId
		INNER JOIN Item on Item.ItemId = InvoiceDetail.ItemId
    --WHERE InvoiceId = ISNULL(@InvoiceId, InvoiceId)
    WHERE Invoice.InvoiceNo=ISNULL(@InvoiceId,Invoice.InvoiceNo)
    AND Invoice.CompanyId = ISNULL(@CompanyId, Invoice.CompanyId)
    AND Invoice.Date >= ISNULL(@StartDate, Invoice.Date)
    AND Invoice.Date <= ISNULL(@EndDate, Invoice.Date)
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectExceptionLog]    Script Date: 10/27/2011 17:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectExceptionLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectExceptionLog]
@StartDate DateTime=null,
@EndDate   DateTime=null,
@Module    nvarchar(500)=null
AS
BEGIN
IF @StartDate IS NOT NULL
Set @StartDate=DATEADD(day,-1,@StartDate)
If @EndDate IS NOT NULL 
Set @EndDate =DATEADD(DAY,1,@EndDate)
	SELECT	[Id],[ExceptionTime],[Module],[Method],[Message],[StackTrace],[InnerMessage]
	FROM ExceptionLog
	WHERE ExceptionTime >= ISNULL(@StartDate,ExceptionTime)
	AND ExceptionTime <=ISNULL(@EndDate,ExceptionTime)
	AND Module=ISNULL(@Module,Module)
Order By Id Desc
END
' 
END
GO
/****** Object:  View [dbo].[TotalSaleView]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[TotalSaleView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[TotalSaleView]
AS
SELECT     dbo.ReceiptDetail.ItemId, SUM(dbo.ReceiptDetail.Quantity) AS TotalSale, SUM(dbo.ReceiptDetail.SalePrice * dbo.ReceiptDetail.Quantity) AS TotalSaleValue
FROM         dbo.ReceiptDetail INNER JOIN
                      dbo.Receipt ON dbo.Receipt.Id = dbo.ReceiptDetail.ReceiptId
WHERE     (dbo.Receipt.IsReturn = 0)
GROUP BY dbo.ReceiptDetail.ItemId
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'TotalSaleView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ReceiptDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receipt"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 125
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalSaleView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'TotalSaleView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalSaleView'
GO
/****** Object:  View [dbo].[TotalSaleReturnView]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[TotalSaleReturnView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[TotalSaleReturnView]
AS
SELECT     dbo.ReceiptDetail.ItemId, SUM(dbo.ReceiptDetail.Quantity) AS TotalSaleReturn, SUM(dbo.ReceiptDetail.SalePrice * dbo.ReceiptDetail.Quantity) 
                      AS TotalSaleValueReturn
FROM         dbo.ReceiptDetail INNER JOIN
                      dbo.Receipt ON dbo.Receipt.Id = dbo.ReceiptDetail.ReceiptId
WHERE     (dbo.Receipt.IsReturn = 1)
GROUP BY dbo.ReceiptDetail.ItemId
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'TotalSaleReturnView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ReceiptDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Receipt"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 125
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalSaleReturnView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'TotalSaleReturnView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalSaleReturnView'
GO
/****** Object:  View [dbo].[TotalPurchaseView]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[TotalPurchaseView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[TotalPurchaseView]
AS
SELECT     InD.ItemId, SUM(InD.Quantity) AS TotalPurchase, SUM(InD.PurchasePrice * InD.Quantity) AS TotalPurchaseValue
FROM         dbo.InvoiceDetail AS InD INNER JOIN
                      dbo.Invoice ON dbo.Invoice.Id = InD.InvoiceId
WHERE     (dbo.Invoice.IsReturn = 0)
GROUP BY InD.ItemId
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'TotalPurchaseView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 14
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "InD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Invoice"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 125
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalPurchaseView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'TotalPurchaseView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalPurchaseView'
GO
/****** Object:  View [dbo].[TotalPurchaseReturnView]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[TotalPurchaseReturnView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[TotalPurchaseReturnView]
AS
SELECT     InD.ItemId, SUM(InD.Quantity) AS TotalPurchase_Return, SUM(InD.PurchasePrice * InD.Quantity) AS TotalPurchaseValue_Return
FROM         dbo.InvoiceDetail AS InD INNER JOIN
                      dbo.Invoice ON dbo.Invoice.Id = InD.InvoiceId
WHERE     (dbo.Invoice.IsReturn = 1)
GROUP BY InD.ItemId
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'TotalPurchaseReturnView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 5
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "InD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Invoice"
            Begin Extent = 
               Top = 6
               Left = 252
               Bottom = 125
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1800
         Width = 2190
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalPurchaseReturnView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'TotalPurchaseReturnView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TotalPurchaseReturnView'
GO
/****** Object:  StoredProcedure [dbo].[Test]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Test]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[Test]
@P1 nvarchar(1000)=null,
@P2 nvarchar(200)=null,
@P3 nvarchar(200)=null,
@P4 nvarchar(200)=null
AS
BEGIN
IF (SELECT COUNT(*) FROM Shop) > 0
BEGIN
	UPDATE Shop
	SET [AD97DC5D7E618288E63528CC5CC6F3AE] = @P1,
		[299073ED0704FC4383DBA129C67CCDEB] = @P2,
		[1B29BA78A2DF965545C5A563B6E997AE] = @P3,
		[A34C0CEC63EC0F1739FB5CB8F43A9CE1] = @P4
END 
ELSE
BEGIN
	INSERT INTO Shop (
		[AD97DC5D7E618288E63528CC5CC6F3AE] ,
		[299073ED0704FC4383DBA129C67CCDEB] ,
		[1B29BA78A2DF965545C5A563B6E997AE] ,
		[A34C0CEC63EC0F1739FB5CB8F43A9CE1] ) 
	VALUES (@P1, @P2,@P3, @P4)
END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomer]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCustomer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectCustomer]
@CustomerId int=null,
@CustomerCode nvarchar(500) = null,
@CustomerName nvarchar(500) = null,
@OnlyActive bit=1
AS
BEGIN
DECLARE @AllBalance as Money

IF  @OnlyActive =0
	SET @OnlyActive=null


	SELECT @AllBalance = ROUND( SUM(CustomerBalance),2)
	FROM Customer 
	WHERE CustomerId = ISNULL(@CustomerId, CustomerId)
	AND IsActive  = ISNULL(@OnlyActive, IsActive) 
	AND CustomerCode LIKE ''%'' + ISNULL(@CustomerCode, '''') + ''%'' 
	AND CustomerName LIKE ''%'' + ISNULL(@CustomerName, '''') + ''%''  

	SELECT CustomerId, CustomerCode, 
	case when CustomerCode=''CASH'' then ''Cash Customer'' else CustomerName end as CustomerName, ContactNumber, 
		
	 @AllBalance as AllBalance
		,ContactPerson, Phone, [Address], Email, Web, Fax,City, ROUND(IsNULL(CustomerBalance,0),2) as CustomerBalance ,
		Remarks, IsActive 
	FROM Customer 
	WHERE CustomerId = ISNULL(@CustomerId, CustomerId) 
	AND IsActive  = ISNULL(@OnlyActive, IsActive) 
	AND CustomerCode LIKE ''%'' + ISNULL(@CustomerCode, '''') + ''%'' 
	AND CustomerName LIKE ''%'' + ISNULL(@CustomerName, '''') + ''%'' 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCompanyProducts]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCompanyProducts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectCompanyProducts]
@CompanyId int=null
AS
BEGIN
	SELECT CompanyId , CompanyCode as SupplierCode ,  CompanyName as SupplierName , 
	ROUND(CompanyBalance,2) as SupplierBalance  , IsActive 	FROM Company 
	
	SELECT ItemCode, ItemName, ItemTypeName,  ItemInStock as Stock, ItemOnOrder as OnOrder,
	  
	ROUND(PurchasePrice,2) as PurchasePrice, 
	ROUND(SalePrice,2) as SalePrice,CompanyId
	--,BatchNo, ExpiryDate
	FROM Item
		INNER JOIN ItemType on Item.ItemType = ItemType.ItemTypeId
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCompanyCustomer_Print]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCompanyCustomer_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectCompanyCustomer_Print @IsCompany = 0
CREATE PROCEDURE [dbo].[SelectCompanyCustomer_Print]
 @Id int=null
,@Code nvarchar(500) = null
,@Name nvarchar(500) = null
,@OnlyActive bit = 1
,@IsCompany bit = 1
AS
BEGIN
DECLARE @AllBalance as Money

DECLARE @ShopName nvarchar(200)
DECLARE @Title nvarchar(200)
DECLARE @ShopAddress nvarchar(500)
DECLARE @RegistrationNumber nvarchar(200)
DECLARE @ShopNumber nvarchar(200)

SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress,@RegistrationNumber = RegistrationNumber,@ShopNumber = ShopNumber 	From Shop
	
	IF @OnlyActive = 0
	SET @OnlyActive = null
IF @IsCompany = 1
BEGIN
	SET @Title =''Suppliers Profiles List'' 
	SELECT @AllBalance = SUM(CompanyBalance)
	FROM Company 
	WHERE CompanyId = ISNULL(@Id, CompanyId) 
	AND IsActive = ISNULL(@OnlyActive, IsActive) 
	AND CompanyCode  LIKE ''%'' + ISNULL(@Code, '''') + ''%'' 
	AND CompanyName LIKE ''%'' + ISNULL(@Name, '''') + ''%'' 

	SELECT 
	@ShopName as ShopName, @Title as Title, @ShopAddress as ShopAddress, @RegistrationNumber as RegistrationNumber, @ShopNumber as ShopNumber ,
	
	CompanyId as Id , CompanyCode as Code , CompanyName as Name
		,ContactPerson,'''' as ContactNumber, Phone, [Address], Email, Web, Fax,City, Remarks, 
		ROUND(CompanyBalance ,2) as Balance, case when IsActive= 1 Then ''Active'' else ''Not Active'' end as Active  
		, 
	@AllBalance as AllBalance
	FROM Company  
	WHERE CompanyId = ISNULL(@Id, CompanyId)  
	AND IsActive = ISNULL(@OnlyActive, IsActive)  
	AND CompanyCode  LIKE ''%'' + ISNULL(@Code, '''') + ''%'' 
	AND CompanyName LIKE ''%'' + ISNULL(@Name, '''') + ''%'' 
	order by CompanyName
END
ELSE
BEGIN
	SET @Title =''Customers Profiles List'' 
	SELECT @AllBalance = ROUND( SUM(CustomerBalance),2)
	FROM Customer 
	WHERE CustomerId = ISNULL(@Id, CustomerId)
	AND IsActive  = ISNULL(@OnlyActive, IsActive) 
	AND CustomerCode LIKE ''%'' + ISNULL(@Code, '''') + ''%'' 
	AND CustomerName LIKE ''%'' + ISNULL(@Name, '''') + ''%''  

	SELECT 
	@ShopName as ShopName, @Title as Title, @ShopAddress as ShopAddress, @RegistrationNumber as RegistrationNumber, @ShopNumber as ShopNumber ,	
	CustomerId as Id, CustomerCode as Code, CustomerName as Name, ContactPerson, ContactNumber 
		, Phone, [Address], Email, Web, Fax,City, Remarks, 
		ROUND(IsNULL(CustomerBalance,0),2) as Balance ,case when IsActive= 1 Then ''Active'' else ''Not Active'' end as Active,
	@AllBalance as AllBalance
	FROM Customer 
	WHERE CustomerId = ISNULL(@Id, CustomerId) 
	AND IsActive  = ISNULL(@OnlyActive, IsActive) 
	AND CustomerCode LIKE ''%'' + ISNULL(@Code, '''') + ''%'' 
	AND CustomerName LIKE ''%'' + ISNULL(@Name, '''') + ''%'' 
	order by CustomerName
END


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCompany]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCompany]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec SelectCompany @CompanyName =''M''
CREATE PROCEDURE [dbo].[SelectCompany]
 @CompanyId int=null
,@CompanyCode nvarchar(500) = null
,@CompanyName nvarchar(500) = null
,@OnlyActive bit = 1
AS
BEGIN
DECLARE @AllBalance as Money
	
	IF @OnlyActive = 0
	SET @OnlyActive = null

	SELECT @AllBalance = SUM(CompanyBalance)
	FROM Company 
	WHERE CompanyId = ISNULL(@CompanyId, CompanyId) AND IsActive = ISNULL(@OnlyActive, IsActive) 
	AND CompanyCode  LIKE ''%'' + ISNULL(@CompanyCode, '''') + ''%'' 
	AND CompanyName LIKE ''%'' + ISNULL(@CompanyName, '''') + ''%'' 

	SELECT CompanyId , CompanyCode , CompanyName , 
	@AllBalance as AllBalance
		,ContactPerson, Phone, [Address], Email, Web, Fax,City, Remarks, 
		ROUND(CompanyBalance ,2) as CompanyBalance, IsActive 
	FROM Company  
	WHERE CompanyId = ISNULL(@CompanyId, CompanyId)  
	AND IsActive = ISNULL(@OnlyActive, IsActive)  
	AND CompanyCode  LIKE ''%'' + ISNULL(@CompanyCode, '''') + ''%'' 
	AND CompanyName LIKE ''%'' + ISNULL(@CompanyName, '''') + ''%'' 


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_Stock]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_Stock]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_Stock]
AS
BEGIN
Select ItemCode, ItemName, Item.PurchasePrice, Item.SalePrice, 
	ROUND(SUM(InvoiceDetail.Quantity),2) as Received, 
	ROUND(SUM(ReceiptDetail.Quantity),2) as Sold 
	,ROUND((SUM(InvoiceDetail.Total ) - SUM(ReceiptDetail.SalePrice * ReceiptDetail.Quantity)),2) as StockValue
FROM Item
	left join InvoiceDetail on Item.ItemId = InvoiceDetail.ItemId
	left join ReceiptDetail on Item.ItemId = ReceiptDetail.ItemId
group by ItemCode, ItemName, Item.PurchasePrice, Item.SalePrice
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_SalesPurchase]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_SalesPurchase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
@Report =0 -> Product Sales Report
@Report =1 -> Customer Sales Report
@Report =2 -> Company Sales Report
@Report =3 -> Buyer Ledger
*/
CREATE PROCEDURE [dbo].[Report_SalesPurchase]
@Report int=0, 
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null

AS
BEGIN

IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

IF @Id =0
	SET @Id = null
-- Product Sales Report
	IF @Report =0
	BEGIN
		SELECT	ReceiptDetail.ReceiptId  as [Receipt No] ,CONVERT(varchar(50), [Date], 103) as [Date],CustomerName as Customer, 
			CompanyName as Company, ItemName as Item, ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
			Quantity, ROUND(ReceiptDetail.Total,2) as Total 
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId )

	END
		--Customer Sales Report
	ELSE IF @Report =1
	BEGIN
		SELECT Id  as [Receipt No] ,CONVERT(varchar(50), [Date], 103) as [Date],CustomerName as Customer, 
		ROUND(GrandTotal,2) AS GrandTotal, 
		ROUND(Payment,2) AS Payment , Comments
		FROM Receipt 
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)
	END
	--Company Sales Report
	ELSE IF @Report =2
	BEGIN
		SELECT	ReceiptDetail.ReceiptId as [Receipt No]  ,CONVERT(varchar(50), [Date], 103) as [Date],CustomerName as Customer, 
			CompanyName as Company , ItemName as Item, ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
			Quantity, ROUND(ReceiptDetail.Total,2) as Total 
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND ReceiptDetail.ItemId IN (Select Item.ItemId  from Item Where Item.CompanyId = ISNULL(@Id,Item.CompanyId )  )
	END
--Customer Report (Buyer Ledger)
	ELSE IF @Report =3
	BEGIN
		SELECT	ReceiptDetail.ReceiptId as [Receipt No] ,CONVERT(varchar(50), [Date], 103) as [Date],
		CustomerName as Customer, ISNULL(Receipt.Comments, ''N/A'') as Comments, ItemName as Item, Quantity
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND Receipt.CustomerId = ISNULL(@Id, Receipt.CustomerId)
		ORDER BY Receipt.CustomerId, [Date]
	END	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProfitLost]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProfitLost]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_ProfitLost]
@StartDate datetime = null,
@EndDate   datetime = null,
@Level	int = 0

AS
BEGIN

IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	IF @Level = 0 
	BEGIN
		SELECT ROUND(SUM(ProfitLoss),2) as TotalProfitLoss 
		FROM Receipt 
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	END	
	ELSE IF @Level = 1 
	BEGIN
		SELECT DATEPART(YEAR,[Date]) as [Year] , ROUND(SUM(ProfitLoss),2) as TotalProfitLoss 
		FROM Receipt
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		GROUP BY DATEPART(YEAR,[Date])
	END	
	ELSE IF @Level = 2 
	BEGIN
		SELECT (CONVERT(nvarchar(3), DATEPART(MONTH,[Date])) + '' / '' + CONVERT(nvarchar(5), DATEPART(Year,[Date])))  as [Month] 
		, ROUND(SUM(ProfitLoss),2) as TotalProfitLoss 
		FROM Receipt
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		GROUP BY  (CONVERT(nvarchar(3), DATEPART(MONTH,[Date])) + '' / '' + CONVERT(nvarchar(5), DATEPART(Year,[Date])))
		
	END	
	ELSE IF @Level = 3
	BEGIN
		SELECT CONVERT(nvarchar(20), [Date], 103) as [Day] 
		, ROUND(SUM(ProfitLoss),2) as TotalProfitLoss 
		FROM Receipt
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		GROUP BY  CONVERT(nvarchar(20), [Date], 103)
	END	
	ELSE IF @Level = 4
	BEGIN
		SELECT  Receipt.Id, CONVERT(nvarchar(20), Receipt.Date) as [Date], CustomerName as Customer
		, (ROUND(SUM(ProfitLoss),2)) as TotalProfitLoss ,
		case when IsReturn = 1 then ''Return Receipt'' else '''' end [Status]
		FROM Receipt
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		GROUP BY  Receipt.Id, CustomerName, Receipt.Discount , IsReturn, Receipt.Date
		
	END	
	ELSE IF @Level = 5
	BEGIN
		SELECT ReceiptDetail.ReceiptId	, CONVERT(nvarchar(20), [Date], 103) as [Date], 
		ItemCode, ItemName,Quantity,
		ROUND(ReceiptDetail.ProfitLoss,2) as ProfitLoss
		,case when IsReturn = 1 then ''Return Receipt'' else '''' end [Status]
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	END	

	ELSE IF @Level = 6 
	BEGIN
		SELECT ItemCode, ItemName, 
		--ROUND(ReceiptDetail.PurchasePrice,2) as PurchasePrice  , 
		--ROUND(ReceiptDetail.SalePrice,2) as SalePrice ,
		SUM(Quantity) as Quantity, ROUND(SUM(ReceiptDetail.ProfitLoss),2) as ProfitLoss 
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id
			INNER JOIN Item  on ReceiptDetail.ItemId = Item.ItemId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		group by ItemCode, ItemName --, ReceiptDetail.PurchasePrice, ReceiptDetail.SalePrice
		
	END	

	ELSE IF @Level = 7 -- Customerwise
	BEGIN
		SELECT CustomerName as Customer
		, (ROUND(SUM(ProfitLoss),2)) as TotalProfitLoss 
		FROM Receipt
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		GROUP BY  CustomerName
	END	

	ELSE IF @Level = 8 -- Supplierwise
	BEGIN
		SELECT	Company.CompanyName as Supplier,	SUM(ROUND(ReceiptDetail.ProfitLoss,2)) as TotalProfitLoss
		FROM ReceiptDetail
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
		--WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		group by Company.CompanyName
	END	


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductTransactionReport]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductTransactionReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_ProductTransactionReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = 0

AS
BEGIN
	
	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
	IF @Id < 1
		SET @Id = null
-- Purchase + Purchase Return	
	Select dt.Date, ItemName, SUM(Returned) as Returned,  SUM(Purchased) as Purchased 
	from (
	Select InvoiceDetail.ItemId, CONVERT(nvarchar(20) , [Date], 103) as Date, 
	case when Invoice.IsReturn =1 then (InvoiceDetail.Quantity) else 0 end as Returned,
	case when Invoice.IsReturn <> 1 then (InvoiceDetail.Quantity) else 0 end as Purchased 
	from InvoiceDetail
		INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id 
	Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	 AND InvoiceDetail.ItemId = ISNULL(@Id, InvoiceDetail.ItemId) ) as dt
	INNER JOIN Item on dt.ItemId = Item.ItemId
	WHERE dt.ItemId = ISNULL(@Id, dt.ItemId)
	group by dt.Date, ItemName 
	order by dt.Date, ItemName


-- Sale + Sale Return

	Select sale.Date, ItemName, SUM(Returned) as Returned,  SUM(Sold) as Sold 
	from (
	Select ReceiptDetail.ItemId, CONVERT(nvarchar(20) , [Date], 103) as Date, 
	case when Receipt.IsReturn =1 then (ReceiptDetail.Quantity) else 0 end as Returned,
	case when Receipt.IsReturn <> 1 then (ReceiptDetail.Quantity) else 0 end as Sold 
	from ReceiptDetail
		INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id
	Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
	 AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId) ) as sale
	INNER JOIN Item on sale.ItemId = Item.ItemId
	WHERE sale.ItemId = ISNULL(@Id, sale.ItemId)
	group by sale.Date, ItemName 
	order by sale.Date, ItemName
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductSalesReport_Print]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductSalesReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_ProductSalesReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @ProductName nvarchar(50)
IF @Id =0 
	SET @Id = null 
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @ProductName = ''Sale Report of All Products''
	END
	ELSE
		SELECT  @ProductName = ''Sale Report of Product ['' + ItemName + '']'' + '' (''+ ItemCode + '')''   From Item Where ItemId = @Id
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' +CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

	SELECT	ReceiptDetail.ReceiptId  as [ReceiptNo] ,CONVERT(varchar(50), [Date], 103) as [Date],
	case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+case when CustomerCode=''CASH'' then ''CASH'' else CustomerName end as Customer, 
		CompanyName as Company, 
		case when @Id IS NULL then ItemName else '''' end as Item, 
		ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
		--case when Quantity < 0 then -1*Quantity else Quantity end as Quantity, 
		--ROUND(ReceiptDetail.Total,2) as Total ,
			Quantity, 
			case when Receipt.IsReturn =1 then 
				ROUND(-1*ReceiptDetail.Total,2) 
			else ROUND(ReceiptDetail.Total,2)  end 
			as Total ,
		ShopName , @SDate as StartDate, @EDate as EndDate, @ProductName as ProductName
	FROM ReceiptDetail
		INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
		INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
		INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
		INNER JOIN Company on Item.CompanyId = Company.CompanyId
		CROSS JOIN Shop
	WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
		AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId )

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductSalesPurchaseReport]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductSalesPurchaseReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Report_ProductSalesPurchaseReport]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	int = null,
@IsPurchase int =0
AS
BEGIN

IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

IF @Id =0
	SET @Id = null
	IF @IsPurchase = 0 -- Sales Report
	BEGIN
		SELECT	ReceiptDetail.ReceiptId  as [Receipt No] ,CONVERT(varchar(50), [Date], 103) as [Date],
		case when Receipt.IsReturn =1 then ''(SALE RETURN)'' else ''''end
		+case when CustomerCode=''CASH'' then ''CASH'' else CustomerName end as Customer, 
			CompanyName as Supplier, ItemName as Item, 
			ROUND(ReceiptDetail.SalePrice,2) as SalePrice, 
			--case when Quantity < 0 then -1*Quantity else Quantity end as 
			Quantity, 
			case when Receipt.IsReturn =1 then 
				ROUND(-1*ReceiptDetail.Total,2) 
			else ROUND(ReceiptDetail.Total,2)  end 
			as Total 
		FROM ReceiptDetail
			INNER JOIN Receipt on ReceiptDetail.ReceiptId = Receipt.Id 
			INNER JOIN Item on ReceiptDetail.ItemId = Item.ItemId
			INNER JOIN Customer on Receipt.CustomerId = Customer.CustomerId
			INNER JOIN Company on Item.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND ReceiptDetail.ItemId = ISNULL(@Id, ReceiptDetail.ItemId )
	END
	ELSE
	BEGIN
		SELECT	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],CompanyName as Supplier, 
			ItemName as Item, 
			ROUND(InvoiceDetail.PurchasePrice,2) as PurchasePrice, 
			Quantity, 
			case when Invoice.IsReturn = 1 then	ROUND(-1*InvoiceDetail.Total,2) else	ROUND(InvoiceDetail.Total,2) end as Total 
		FROM InvoiceDetail
			INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id
			INNER JOIN Item on InvoiceDetail.ItemId = Item.ItemId
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND InvoiceDetail.ItemId = ISNULL(@Id, InvoiceDetail.ItemId )
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductPurchaseReport_Print]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductPurchaseReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec Report_ProductPurchaseReport_Print @Id =2, @IsProductReport=0
CREATE PROCEDURE [dbo].[Report_ProductPurchaseReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null,
@IsProductReport bit = 1
AS
BEGIN
DECLARE @CompanyId int
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @ProductName nvarchar(50)
IF @Id = 0
	SET @Id = null
	IF @Id =0 OR @Id IS NULL
	BEGIN
		SET @Id = null
		SET @CompanyId = null
		IF @IsProductReport = 1
		BEGIN
			SET @ProductName = ''Purchase Report of [ALL PRODUCTS]''
		END
		ELSE
		BEGIN
			SET @ProductName = ''Detailed Purchase Report of [ALL SUPPLIERS]''
		END
	END
	ELSE
	BEGIN
		IF @IsProductReport = 1
		BEGIN
			SET @CompanyId =null
			SELECT @ProductName = ''Purchase Report of ['' + ItemName + '']'' FROM Item Where Item.ItemId = @Id
		END
		ELSE
		BEGIN
			SET @CompanyId =@Id
			SET @Id = null
			SELECT @ProductName = ''Detailed Purchase Report of ['' + CompanyName + '']'' + '' (''+ CompanyCode + '')''   FROM Company Where Company.CompanyId = @CompanyId
		END
	END
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' + CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' + CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END
		SELECT	
		case when Invoice.IsReturn = 1 then ''[RETURN] '' else '''' end + InvoiceNo as InvoiceId 
		,CONVERT(varchar(50), [Date], 103) as [Date],CompanyName as Company, 
			case when @Id IS NULL then ItemName else '''' end as Item, 
			ROUND(InvoiceDetail.PurchasePrice,2) as PurchasePrice, 
			Quantity, 
		case when Invoice.IsReturn = 1 then	ROUND(-1*InvoiceDetail.Total,2) else	ROUND(InvoiceDetail.Total,2) end as Total ,
		ShopName , @SDate as StartDate, @EDate as EndDate, @ProductName as ProductName
		FROM InvoiceDetail
			INNER JOIN Invoice on InvoiceDetail.InvoiceId = Invoice.Id
			INNER JOIN Item on InvoiceDetail.ItemId = Item.ItemId
			INNER JOIN Company on Invoice.CompanyId = Company.CompanyId
			CROSS JOIN Shop
		WHERE [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
			AND  InvoiceDetail.ItemId = ISNULL(@Id, InvoiceDetail.ItemId )
			AND  Item.CompanyId = ISNULL(@CompanyId, Item.CompanyId)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SystemUserLogin]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemUserLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SystemUserLogin] 
@UserName nvarchar(100),
@Password nvarchar(100)
AS
BEGIN

	SELECT * FROM SystemUsers
	WHERE UserName = @UserName AND [Password] = @Password AND IsActive =1

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Stock]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stock]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- exec Stock 
CREATE PROCEDURE [dbo].[Stock]
@Where nvarchar(500)=null,
@IsPrint bit=0
AS
DECLARE @Query nvarchar(max)
DECLARE @Title nvarchar(200)
DECLARE @Value nvarchar(50)
DECLARE @startIndex int
DECLARE @endIndex int
DECLARE @ShopName nvarchar(500)

	IF @IsPrint = 0
	BEGIN
		SELECT ItemCode as Code , ItemName as Name, Packing, CompanyName as Company, CompanyCode , ItemTypeName as [Type],
			Item.PurchasePrice,Item.SalePrice
			, (ISNULL(TotalPurchase,0) + ISNULL(TotalPurchase_Return,0)) as TotalPurchase
			, (ISNULL(TotalSale,0) +  ISNULL(TotalSaleReturn,0)) as TotalSale
			,ItemInStock as Stock
			,ItemOnOrder as OnOrder
			,(ItemInStock*Item.PurchasePrice) as StockValue
			,ISNULL(-1*TotalPurchase_Return,0) as PurchasedValue
			,ISNULL(-1*TotalSaleReturn,0) as SoldValue
			--, (ISNULL(TotalPurchaseValue,0) +  ISNULL(TotalPurchaseValue_Return,0)) as PurchasedValue
			--, (ISNULL(TotalSaleValue,0) +  ISNULL(TotalSaleValueReturn,0)) as SoldValue
			,'''' as ShopName , '''' as Title

		FROM Item
			INNER JOIN ItemType on ItemType.ItemTypeId = ItemType
			INNER JOIN Company on Company.CompanyId = Item.CompanyId
			INNER JOIN TotalPurchaseView tpv on tpv.ItemId = Item.ItemId
			LEFT JOIN TotalPurchaseReturnView tprv on tprv.ItemId = Item.ItemId
			LEFT JOIN TotalSaleView tsv on tsv.ItemId = Item.ItemId
			LEFT JOIN TotalSaleReturnView tsrv on tsrv.ItemId = Item.ItemId
 
	END
	ELSE IF @IsPrint = 1 AND LEN(@Where) > 2
	BEGIN
		set @startIndex = 0
		set @endIndex = 0
		SET @Value = null
		SET @Title=''''''''''''

		set @startIndex = CHARINDEX('''''''',@Where,0)+1
		IF @startIndex > 1
		BEGIN
			set @endIndex = CHARINDEX('''''''',@Where,@startIndex)
			SET @Value = SUBSTRING(@Where, @startIndex, @endIndex- @startIndex)
			IF CHARINDEX(''CompanyCode'',@Where,0) > 0
			BEGIN
				SELECT @Title= ''''''SUPPLIER : '' + CompanyName + ''('' + CompanyCode + '')'''''' from Company Where CompanyCode=@Value
			END
			ELSE IF CHARINDEX(''ItemTypeName'',@Where,0) > 0
			BEGIN
				SELECT @Title= ''''''ITEM TYPE : '' + @Value + ''''''''
			END
			ELSE IF CHARINDEX(''ItemCode'',@Where,0) > 0
			BEGIN
				SELECT @Title= ''''''ITEM : '' + ItemName + ''('' + ItemCode + '')'''''' from Item Where ItemCode=@Value
		END
		END
		SELECT @ShopName  = ''''''''+ShopName+'''''''' from Shop
		
		SET @Query  = ''SELECT ItemCode as Code , ItemName as Name, Packing,  CompanyName as Company, CompanyCode , ItemTypeName as [Type],
			Item.PurchasePrice,Item.SalePrice
			, (ISNULL(TotalPurchase,0) + ISNULL(TotalPurchase_Return,0)) as TotalPurchase
			, (ISNULL(TotalSale,0) +  ISNULL(TotalSaleReturn,0)) as TotalSale
			,ItemInStock as Stock
			,ItemOnOrder as OnOrder
			,(ItemInStock*Item.PurchasePrice) as StockValue
			, (ISNULL(TotalPurchaseValue,0) +  ISNULL(TotalPurchaseValue_Return,0)) as PurchasedValue
			, (ISNULL(TotalSaleValue,0) +  ISNULL(TotalSaleValueReturn,0)) as SoldValue ,''+ @ShopName+ '' as ShopName ,''+ @Title+ '' as Title

		FROM Item
			INNER JOIN ItemType on ItemType.ItemTypeId = ItemType
			INNER JOIN Company on Company.CompanyId = Item.CompanyId
			INNER JOIN TotalPurchaseView tpv on tpv.ItemId = Item.ItemId
			left JOIN TotalPurchaseReturnView tprv on tprv.ItemId = Item.ItemId
			left JOIN TotalSaleView tsv on tsv.ItemId = Item.ItemId
			left JOIN TotalSaleReturnView tsrv on tsrv.ItemId = Item.ItemId
		WHERE '' + @Where + '' 
		Order By CompanyName ''
		print @Query
		exec sp_sqlexec @Query
	END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductInOutSummaryReport_Print]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductInOutSummaryReport_Print]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' -- drop proc Report_ProductHistoryReport
CREATE PROCEDURE [dbo].[Report_ProductInOutSummaryReport_Print]
@StartDate datetime = null,
@EndDate   datetime = null,
@Id	bigint = null
AS
BEGIN
DECLARE @SDate nvarchar(50)
DECLARE @EDate nvarchar(50)
DECLARE @Title nvarchar(100)
DECLARE @ShopName nvarchar(200)
DECLARE @ShopAddress nvarchar(1000)
SELECT  @ShopName = ShopName, @ShopAddress = ShopAddress  from Shop	
SELECT  @Title = ''Transaction Summary of Product ['' + ItemName + '']'' + '' (''+ ItemCode + '')''   From Item Where ItemId = @Id	
	
	
	IF @StartDate IS NULL
		SET @SDate = ''From: N/A''
	ELSE
	BEGIN
		SET @SDate = ''From: '' +CONVERT(nvarchar(50),@StartDate, 103)
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NULL
		SET @EDate = ''To: N/A''
	ELSE
	BEGIN
		SET @EDate = ''To: '' +CONVERT(nvarchar(50),@EndDate, 103)
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

SELECT Convert(nvarchar(20), [MyDate], 103) as Date, [IN], [OUT], Stock
, @ShopName as ShopName , @ShopAddress as ShopAddress ,@Title as Title , @SDate as StartDate, @EDate as EndDate
FROM ProductTransaction pt
	INNER JOIN fnTable1( @StartDate,@EndDate,@Id) as t1 on pt.Id = t1.Id
	INNER JOIN fnTable2( @StartDate,@EndDate,@Id) as t2 on t1.MyDate = t2.FinalDate 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Report_ProductInOutSummaryReport]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Report_ProductInOutSummaryReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' -- exec Report_ProductInOutSummaryReport @Id= 2
CREATE PROCEDURE [dbo].[Report_ProductInOutSummaryReport]
	@StartDate datetime = null,
	@EndDate   datetime = null,
	@Id	int = null
	AS
	BEGIN

	IF @StartDate IS NOT NULL 
	BEGIN
		SET @StartDate =DATEADD(SECOND,-1,@StartDate)
	END
	IF @EndDate IS NOT NULL 
	BEGIN
		SET @EndDate =DATEADD(day,1,@EndDate)
		SET @EndDate =DATEADD(SECOND,-1,@EndDate)
	END

SELECT Convert(nvarchar(20), [MyDate], 103) as Date, [IN], [OUT], Stock

FROM ProductTransaction pt
	INNER JOIN fnTable1( @StartDate,@EndDate,@Id) as t1 on pt.Id = t1.Id
	INNER JOIN fnTable2( @StartDate,@EndDate,@Id) as t2 on t1.MyDate = t2.FinalDate 

--	CREATE TABLE #Table1(Id bigint, MyDate Datetime)
--	INSERT INTO #Table1 (Id, MyDate) 
--		Select MAX(Id) as StockId , CONVERT(nvarchar(20), [Date],23) as MyDate 
--		FROM ProductTransaction
--		Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
--		AND ItemId = @Id
--		Group by CONVERT(nvarchar(20), Date,23)
		
		
--CREATE TABLE #Table2(FinalDate Datetime, [IN] int, [OUT] int)
--INSERT INTO #Table2 (FinalDate, [IN], [OUT]) 
--		SELECT CONVERT(nvarchar(20), Date,23) as Date, SUM(QuantityIn) as [IN], SUM(QuantityOut) as [OUT]
--		FROM ProductTransaction
--		Where  [Date] >= ISNULL(@StartDate, [Date]) AND [Date] <= ISNULL(@EndDate, [Date])
--		AND ItemId = @Id
--		Group by CONVERT(nvarchar(20), Date,23)

--SELECT Convert(nvarchar(20), [MyDate], 103) as Date, [IN], [OUT], Stock

--FROM ProductTransaction pt
--	INNER JOIN #Table1 as t1 on pt.Id = t1.Id
--	INNER JOIN #Table2 as t2 on t1.MyDate = t2.FinalDate 
	
--drop table #Table1
--drop table #Table2
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteOrder]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- drop proc InsertUpdateDeleteIvoice
CREATE PROCEDURE [dbo].[InsertUpdateDeleteOrder]
@CompanyId int = 1,
@GrandTotal money=0.0,
@DeliveryDate date=null,
@Discount money=0.0,
@Payment money=0.0,
@Arrears money=0.0,
@Comments nvarchar(500)=null,
@Status int=1,
@Operation int=null,
@OrderID  int =null
AS
 
BEGIN
	DECLARE @Date date
	DECLARE @ID bigint
	DECLARE @Detail nvarchar(500)
	DECLARE @tDetail nvarchar(500)
	set @ID =0
	SET @Date = GETDATE()

	--Select @ID = ISNULL(MAX(Id), 0)+1 from [Order]

	--INSERT INTO [Order] ([Date], CompanyId , GrandTotal , Comments,[Status] ) 
	--VALUES (@Date, @CompanyId , @GrandTotal , @Comments,2 )

	INSERT INTO [Order] ([Date], CompanyId , GrandTotal ,Discount, Payment, Arrears, Comments ,Status, DeliveryDate) 
	VALUES (@Date, @CompanyId , @GrandTotal , @Discount, @Payment, @Arrears,@Comments,@Status, @DeliveryDate)

	Select @ID = SCOPE_IDENTITY()
	Select @ID
	IF @Payment > 0
	BEGIN
		SET @tDetail = ''Payment for Order No.'' + Convert(nvarchar(20),@ID)
		SET @Payment = (-1)* @Payment 
		EXEC InsertUpdateDeleteTransaction 0, @CompanyId,@Date,@Payment,0,null, @tDetail
	END
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteInvoiceDetail]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteInvoiceDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteInvoiceDetail]
@InvoiceId bigint,
@ItemId int,
@PurchasePrice money,
@Quantity int,
@Total money,
@Discount decimal,
@GrandTotal money,
@IsReturn tinyint =0

AS
BEGIN
	DECLARE @OnOrder int
	SET @OnOrder = 0
	IF @IsReturn > 0
		SET @Quantity = -1*@Quantity

	INSERT INTO InvoiceDetail ( InvoiceId, ItemId, PurchasePrice, Quantity, Total, Discount, GrandTotal ) 
	VALUES ( @InvoiceId, @ItemId, @PurchasePrice, @Quantity, @Total , @Discount, @GrandTotal)
	
	SELECT @OnOrder =IsNULL(ItemOnOrder,0) - @Quantity from Item where ItemId = @ItemId
	IF @OnOrder <0
	BEGIN 
		SET @OnOrder =0
	END
	
	Update Item 
	SET 
		ItemInStock = ItemInStock + @Quantity ,
		ItemOnOrder  = @OnOrder
	WHERE ItemId = @ItemId
	
	exec dbo.InsertProductTransaction  @ItemId ,@InvoiceId,null ,@Quantity ,null
	
	
	-- Update AVG Purchase Price
	DECLARE @AvgPP money
	DECLARE @PrevAvgPP money
	DECLARE @PrevStock int
	SELECT 
		@PrevAvgPP = ISNULL(Item.AvgPurchasePrice,0) ,
		@PrevStock = Item.ItemInStock - @Quantity 
	from Item Where Item.ItemId =@ItemId
	print ''@PrevAvgPP''
	print @PrevAvgPP
	print ''@PrevStock''
	print @PrevStock
	SET @AvgPP = ((@PrevStock * @PrevAvgPP) + ( @PurchasePrice * @Quantity))/(@Quantity + @PrevStock)
	print ''@AvgPP''
	print @AvgPP
	Update Item 
	SET 
		 AvgPurchasePrice = @AvgPP
	WHERE ItemId = @ItemId
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteInvoice]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteInvoice]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- 
-- exec InsertUpdateDeleteIvoice ''0'', ''''
CREATE PROCEDURE [dbo].[InsertUpdateDeleteInvoice]
@CompanyId int = null,
@InvoiceNo nvarchar(50)=null,
@GrandTotal money=0.0,
@Discount money=0.0,
@Payment money=0.0,
@Arrears money=0.0,
@Comments nvarchar(500)=null,
@OrderNo	bigint=0,
@UserId int=-1,
@IsReturn	tinyint=0
AS
BEGIN
	DECLARE @Date datetime
	DECLARE @ID bigint
	DECLARE @Detail nvarchar(500)
	DECLARE @tDetail nvarchar(500)
	set @ID =0
	SET @Date = GETDATE()
	
	SET @Payment = (-1)* @Payment 
	
	IF @IsReturn > 0
	BEGIN
		set @GrandTotal = (-1)* @GrandTotal
		SET @Payment = (-1)* @Payment 		
	END

	INSERT INTO Invoice ([Date], CompanyId , GrandTotal ,Discount, Payment, Arrears, Comments ,IsReturn, OrderNo,InvoiceNo, UserId) 
	VALUES (@Date, @CompanyId , @GrandTotal , @Discount, @Payment, @Arrears,@Comments,@IsReturn, @OrderNo,@InvoiceNo,@UserId )
	Select @ID = SCOPE_IDENTITY()
	
	Select @ID  as ID
	--SET @Detail = ''Total for Invoice No.'' + Convert(nvarchar(20),@ID) 
	--SET @tDetail = ''Payment for Invoice No.'' + Convert(nvarchar(20),@ID)
	SET @Detail = ''Total for Invoice No.'' + Convert(nvarchar(20),@InvoiceNo) 
	SET @tDetail = ''Payment for Invoice No.'' + Convert(nvarchar(20),@InvoiceNo)
	
	IF @IsReturn > 0
	BEGIN
		--SET @tDetail = ''Return Payment for Invoice No.'' + Convert(nvarchar(20),@ID) 
		--SET @Detail = ''Return Total for Invoice No.'' + Convert(nvarchar(20),@ID) 
		
		SET @tDetail = ''Return Payment for Invoice No.'' + Convert(nvarchar(20),@InvoiceNo) 
		SET @Detail = ''Return Total for Invoice No.'' + Convert(nvarchar(20),@InvoiceNo)
		SET @Arrears = @GrandTotal 
	END
	print @tDetail
	print @Detail
	--EXEC InsertUpdateDeleteTransaction 0, @CompanyId,@Date,@GrandTotal,0, @UserId, @Detail
	EXEC InsertUpdateDeleteTransaction 0, @CompanyId,@Date,@GrandTotal,0, @UserId, @Detail
	IF @Payment <> 0
	BEGIN
		--SET @Payment = (-1)* @Payment 
		EXEC InsertUpdateDeleteTransaction 0, @CompanyId,@Date,@Payment,0, @UserId, @tDetail
	END
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteCustomer]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteCustomer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteCustomer]
@Operation int =0, -- o=Insert, 1=Update
@CustomerId int =0,
@CustomerCode nvarchar(50),
@CustomerName nvarchar(500),
@ContactNumber nvarchar(500),
@Address nvarchar(200),
@CustomerBalance money,
@Remarks nvarchar(500),
@City nvarchar(100),
@ContactPerson nvarchar(200),
@Phone nvarchar(100),
@Fax nvarchar(100),
@Web nvarchar(150),
@Email nvarchar(150),
@IsActive int=1
AS
BEGIN
DECLARE @NewId  bigint
DECLARE @Date datetime
SET @Date = GetDate()
SET @NewId =0
	IF @Operation = 0
	BEGIN
		INSERT INTO Customer (CustomerCode,CustomerName,ContactNumber, [Address], IsActive,
		Remarks ,City ,ContactPerson ,Phone ,Fax ,Web ,Email )
		VALUES(@CustomerCode,@CustomerName,@ContactNumber,@Address, @IsActive,
		@Remarks ,@City ,@ContactPerson ,@Phone ,@Fax ,@Web ,@Email )
		Select @NewId  = @@IDENTITY
		Select @NewId
		EXEC InsertUpdateDeleteTransaction 0, @NewId,@Date,@CustomerBalance,1,null, ''Initial Balance''

	END
	ELSE IF @Operation = 1
	BEGIN
		UPDATE Customer
		SET CustomerCode =@CustomerCode,
			CustomerName = @CustomerName,
			[Address] = @Address,
			CustomerBalance = @CustomerBalance,
			ContactNumber =@ContactNumber,
			Remarks = @Remarks,
			City = @City,
			ContactPerson = @ContactPerson,
			Phone = @Phone,
			Fax = @Fax,
			Web = @Web,
			Email =@Email,
			IsActive = @IsActive
		WHERE CustomerId = @CustomerId
	END
	ELSE IF @Operation = 2
	BEGIN
		DELETE FROM Customer WHERE CustomerId = @CustomerId
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteCompany]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteCompany]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteCompany]
@Operation int =0, -- 0=Insert, 1=Update, 2=Delete
@CompanyId int =0,
@CompanyCode nvarchar(50),
@CompanyName nvarchar(200),
@CompanyBalance money,
@Remarks nvarchar(500),
@Address nvarchar(500),
@City nvarchar(100),
@ContactPerson nvarchar(200),
@Phone nvarchar(100),
@Fax nvarchar(100),
@Web nvarchar(150),
@Email nvarchar(150),
@IsActive int=1
AS
BEGIN
DECLARE @NewId int
DECLARE @Date DateTime
SET @NewId = 0 
SET @Date  = GETDATE()
	IF @Operation = 0
	BEGIN
		INSERT INTO Company (CompanyCode,CompanyName, CompanyBalance, IsActive,Remarks,[Address],City,ContactPerson,Phone,Fax,Web,Email)
		VALUES(@CompanyCode, @CompanyName, 0.00, @IsActive,@Remarks,@Address,@City,@ContactPerson,@Phone,@Fax,@Web,@Email)
		Select @NewId  = @@IDENTITY
		Select @NewId
		EXEC InsertUpdateDeleteTransaction 0, @NewId,@Date,@CompanyBalance,0,null,''Initial Balance''
	END
	ELSE IF @Operation = 1
	BEGIN
		UPDATE Company
		SET --CompanyCode =@CompanyCode,
			CompanyName = @CompanyName,
			IsActive = @IsActive,
			Remarks = @Remarks,
			[Address] = @Address,
			City = @City,
			ContactPerson = @ContactPerson,
			Phone = @Phone,
			Fax = @Fax,
			Web = @Web,
			Email =@Email
		WHERE CompanyId = @CompanyId
	END
	ELSE IF @Operation = 2
	BEGIN
		DELETE FROM Company WHERE CompanyId = @CompanyId
	END
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteReceiptDetail]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteReceiptDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteReceiptDetail]
@ReceiptId bigint,
@ItemId int,
@SalePrice money,
@Quantity int,
@GrandTotal money,
@Discount money,
@Total money,
@ItemDiscount nvarchar(50),
@IsReturn tinyint=0,
@PrevReceiptId	bigint=0
AS
BEGIN
	DECLARE @PurchasePrice as money
	DECLARE @ProfitLoss as money
	DECLARE @UnitProfitLoss as money
	IF @IsReturn > 0
		SET @Quantity = -1*@Quantity
	SET @PurchasePrice = 0.0
	
	IF @IsReturn > 0 AND @PrevReceiptId > 0
	BEGIN
		
		Select @PurchasePrice = PurchasePrice from ReceiptDetail 
		Where ItemId = @ItemId AND ReceiptId = @PrevReceiptId
	END
	ELSE
	BEGIN
		Select @PurchasePrice = AvgPurchasePrice from Item Where Item.ItemId = @ItemId
	END
	
	
	INSERT INTO ReceiptDetail ( ReceiptId, ItemId, PurchasePrice, SalePrice, Quantity, GrandTotal, Discount,Total , ItemDiscount, ProfitLoss ) 
	VALUES ( @ReceiptId, @ItemId, @PurchasePrice, @SalePrice, @Quantity, @GrandTotal, @Discount, @Total , @ItemDiscount, @ProfitLoss )
	
	Update Item SET ItemInStock = ItemInStock - @Quantity Where ItemId = @ItemId
	
	exec dbo.InsertProductTransaction  @ItemId ,null ,@ReceiptId ,null ,@Quantity
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDeleteReceipt]    Script Date: 10/27/2011 17:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateDeleteReceipt]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateDeleteReceipt]
@CustomerId int = 1,
@GrandTotal money=0.0,
@Discount money=0.0,
@Total money=0.0,
@Expenses money=0.0,
@Payment money=0.0,
@Arearrs money=0.0,
@Comments nvarchar(500),
@Purpose nvarchar(100),
@UserId int=-1,
@IsReturn	tinyint=0
AS
BEGIN

	DECLARE @CashCustomerId int
	DECLARE @CashCustomerName nvarchar(50)
	DECLARE @CashCustomerAddress nvarchar(500)
	DECLARE @Date datetime
	DECLARE @ID bigint
	DECLARE @Detail nvarchar(500)
	DECLARE @tDetail nvarchar(500)
	DECLARE @UnitProfitLoss money
	set @ID =0
	SET @Date = GETDATE()
	
	SET @UnitProfitLoss = ROUND( @Discount/@GrandTotal,2)

	SET @Total = (-1)* @Total
	
	IF @IsReturn > 0
	BEGIN
		set @Total = (-1)* @Total
		SET @Payment = (-1)* @Payment 
	END
	Select @CashCustomerId = CustomerId ,@CashCustomerName = CustomerName ,@CashCustomerAddress = [Address] 
	FROM Customer Where CustomerCode = ''CASH''
	
	IF @CustomerId = @CashCustomerId
	BEGIN
		INSERT INTO Receipt ([Date], CustomerId , GrandTotal ,Discount ,Total , Expenses, Payment, Arearrs,Comments, IsReturn, UserId
		 ,ReceiptCustomerName, ReceiptCustomerAddress, UnitProfitLoss, Purpose ) 
		VALUES (@Date, @CustomerId , @GrandTotal ,@Discount ,@Total , @Expenses, @Payment, @Arearrs, @Comments, @IsReturn, @UserId 
		, @CashCustomerName,@CashCustomerAddress , @UnitProfitLoss, @Purpose)
	END
	ELSE
	BEGIN
		INSERT INTO Receipt ([Date], CustomerId , GrandTotal ,Discount ,Total , Expenses, Payment, Arearrs,Comments, IsReturn, UserId , UnitProfitLoss, Purpose) 
		VALUES (@Date, @CustomerId , @GrandTotal ,@Discount ,@Total , @Expenses, @Payment, @Arearrs, @Comments, @IsReturn, @UserId , @UnitProfitLoss, @Purpose)
	END
	
	Select @ID = SCOPE_IDENTITY()
	Select @ID as ID
	SET @Detail = ''Receipt No.'' + Convert(nvarchar(20),@ID)  + ''[''+ @Comments + '']''
	SET @tDetail = ''Receipt No.'' + Convert(nvarchar(20),@ID) + '' Payment [''+ @Comments + '']''
	IF @IsReturn > 0
	BEGIN
		SET @tDetail = ''Return Receipt No.'' + Convert(nvarchar(20),@ID) + '' Payment [''+ @Comments + '']''
		SET @Detail = ''Return Receipt No.'' + Convert(nvarchar(20),@ID) + ''[''+ @Comments + '']''
	END
	
	--SET @Total = (-1)*@Total
	EXEC InsertUpdateDeleteTransaction 0, @CustomerId, @Date, @Total,1,  @UserId,@Detail
	--SET @Payment = (-1)*@Payment
	EXEC InsertUpdateDeleteTransaction 0, @CustomerId,@Date,@Payment,1, @UserId,@tDetail
	
	
END
' 
END
GO
