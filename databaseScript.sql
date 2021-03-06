
CREATE TABLE [dbo].[Account](
	[Username] [char](30) NOT NULL,
	[IDEmployee] [char](10) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IDTypeAccount] [tinyint] NOT NULL,
	[IDStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[IDBill] [char](10) NOT NULL,
	[IDBranch] [char](10) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
 CONSTRAINT [PK_Bill_1] PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillExport]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillExport](
	[IDBillExport] [char](10) NOT NULL,
	[Date] [date] NOT NULL,
	[IDBranch] [char](10) NOT NULL,
 CONSTRAINT [PK_Imort_1] PRIMARY KEY CLUSTERED 
(
	[IDBillExport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[IDBranch] [char](10) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Manager] [nvarchar](50) NOT NULL,
	[IDStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[IDBranch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailOfBill]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailOfBill](
	[IDBill] [char](10) NOT NULL,
	[IDDrink] [char](10) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_DetailOfBill] PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC,
	[IDDrink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailOfBillExport]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailOfBillExport](
	[IDBillExport] [char](10) NOT NULL,
	[IDMaterial] [char](10) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_DetailOfBillExport] PRIMARY KEY CLUSTERED 
(
	[IDBillExport] ASC,
	[IDMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[IDDrink] [char](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[IDStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_Drink_1] PRIMARY KEY CLUSTERED 
(
	[IDDrink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[IDEmployee] [char](10) NOT NULL,
	[Phone_Number] [char](20) NOT NULL,
	[IDSexual] [tinyint] NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[DayIn] [date] NOT NULL,
	[NumberOfDayOff] [tinyint] NOT NULL,
	[IDTypeEmployee] [tinyint] NOT NULL,
	[IDBranch] [char](10) NOT NULL,
	[IDStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[IDEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FullTimeEmployeeManagement]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FullTimeEmployeeManagement](
	[IDEmployee] [char](10) NOT NULL,
	[DateOff] [date] NOT NULL,
 CONSTRAINT [PK_FullTimeEmployeeManagement] PRIMARY KEY CLUSTERED 
(
	[IDEmployee] ASC,
	[DateOff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InforOfMaterial]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InforOfMaterial](
	[IDInfoOfMaterial] [char](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IDUnit] [tinyint] NOT NULL,
	[Price] [money] NOT NULL,
	[IDSupplier] [char](10) NOT NULL,
	[IDStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_InforOfMaterial] PRIMARY KEY CLUSTERED 
(
	[IDInfoOfMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[IDMaterial] [char](10) NOT NULL,
	[IDInfoOfMaterial] [char](10) NOT NULL,
	[ExpiryDate] [date] NOT NULL,
	[DateAdded] [date] NOT NULL,
	[Amount] [int] NOT NULL,
	[AmountLeft] [int] NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[IDMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartTimeEmployeeManagement]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartTimeEmployeeManagement](
	[IDEmployee] [char](10) NOT NULL,
	[DateWork] [date] NOT NULL,
 CONSTRAINT [PK_PartTimeEmployeeManagement] PRIMARY KEY CLUSTERED 
(
	[IDEmployee] ASC,
	[DateWork] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexual]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexual](
	[IDSexual] [tinyint] NOT NULL,
	[Sexual] [char](20) NOT NULL,
 CONSTRAINT [PK_Sexual] PRIMARY KEY CLUSTERED 
(
	[IDSexual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[IDStatus] [tinyint] NOT NULL,
	[Status] [char](20) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[IDStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[IDSupplier] [char](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[IDStatus] [tinyint] NULL,
 CONSTRAINT [PK_Supplier_1] PRIMARY KEY CLUSTERED 
(
	[IDSupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAccount]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAccount](
	[IDTypeAccount] [tinyint] NOT NULL,
	[Type] [char](20) NULL,
 CONSTRAINT [PK_TypeAccount] PRIMARY KEY CLUSTERED 
(
	[IDTypeAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeEmployee]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeEmployee](
	[IDTypeEmployee] [tinyint] NOT NULL,
	[TypeEmployee] [char](20) NOT NULL,
 CONSTRAINT [PK_TypeEmployee] PRIMARY KEY CLUSTERED 
(
	[IDTypeEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 4/29/2021 4:30:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[IDUnit] [tinyint] NOT NULL,
	[Unit] [char](20) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[IDUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [IDEmployee], [Password], [IDTypeAccount], [IDStatus]) VALUES (N'Admin                         ', N'EM00      ', N'Admin', 0, 1)
INSERT [dbo].[Account] ([Username], [IDEmployee], [Password], [IDTypeAccount], [IDStatus]) VALUES (N'minhthong774                  ', N'EM01      ', N'thong123ABC@', 1, 1)
GO
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI01      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI02      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI03      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI04      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI05      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI06      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
INSERT [dbo].[Bill] ([IDBill], [IDBranch], [DateCheckIn]) VALUES (N'BI07      ', N'BR04      ', CAST(N'2021-04-29' AS Date))
GO
INSERT [dbo].[BillExport] ([IDBillExport], [Date], [IDBranch]) VALUES (N'BE06      ', CAST(N'2021-04-28' AS Date), N'BR03      ')
GO
INSERT [dbo].[Branch] ([IDBranch], [Name], [Manager], [IDStatus]) VALUES (N'BR00      ', N'ROOT', N'Admin', 1)
INSERT [dbo].[Branch] ([IDBranch], [Name], [Manager], [IDStatus]) VALUES (N'BR02      ', N'Branch tokyo', N'Thong', 1)
INSERT [dbo].[Branch] ([IDBranch], [Name], [Manager], [IDStatus]) VALUES (N'BR03      ', N'Branch HongKong', N'Luy', 1)
INSERT [dbo].[Branch] ([IDBranch], [Name], [Manager], [IDStatus]) VALUES (N'BR04      ', N'Branch London', N'Duong', 1)
GO
INSERT [dbo].[DetailOfBill] ([IDBill], [IDDrink], [Count]) VALUES (N'BI05      ', N'DR04      ', 5)
INSERT [dbo].[DetailOfBill] ([IDBill], [IDDrink], [Count]) VALUES (N'BI06      ', N'DR04      ', 6)
INSERT [dbo].[DetailOfBill] ([IDBill], [IDDrink], [Count]) VALUES (N'BI07      ', N'DR04      ', 6)
GO
INSERT [dbo].[DetailOfBillExport] ([IDBillExport], [IDMaterial], [Count]) VALUES (N'BE06      ', N'MA01      ', 30)
GO
INSERT [dbo].[Drink] ([IDDrink], [Name], [Price], [IDStatus]) VALUES (N'DR02      ', N'coffee 3', 20000.0000, 1)
INSERT [dbo].[Drink] ([IDDrink], [Name], [Price], [IDStatus]) VALUES (N'DR03      ', N'coffee 2', 19000.0000, 1)
INSERT [dbo].[Drink] ([IDDrink], [Name], [Price], [IDStatus]) VALUES (N'DR04      ', N'coffee 4', 18000.0000, 0)
GO
INSERT [dbo].[Employee] ([FirstName], [LastName], [IDEmployee], [Phone_Number], [IDSexual], [Address], [DayIn], [NumberOfDayOff], [IDTypeEmployee], [IDBranch], [IDStatus]) VALUES (N'Admin', N' ', N'EM00      ', N'0                   ', 0, N'0', CAST(N'2000-01-01' AS Date), 30, 1, N'BR00      ', 1)
INSERT [dbo].[Employee] ([FirstName], [LastName], [IDEmployee], [Phone_Number], [IDSexual], [Address], [DayIn], [NumberOfDayOff], [IDTypeEmployee], [IDBranch], [IDStatus]) VALUES (N'thong', N'dinh minh', N'EM01      ', N'943831469           ', 1, N'Viet Nam', CAST(N'2021-04-28' AS Date), 10, 1, N'BR04      ', 1)
GO
INSERT [dbo].[FullTimeEmployeeManagement] ([IDEmployee], [DateOff]) VALUES (N'EM01      ', CAST(N'2021-05-13' AS Date))
INSERT [dbo].[FullTimeEmployeeManagement] ([IDEmployee], [DateOff]) VALUES (N'EM01      ', CAST(N'2021-05-18' AS Date))
INSERT [dbo].[FullTimeEmployeeManagement] ([IDEmployee], [DateOff]) VALUES (N'EM01      ', CAST(N'2021-05-21' AS Date))
INSERT [dbo].[FullTimeEmployeeManagement] ([IDEmployee], [DateOff]) VALUES (N'EM01      ', CAST(N'2021-05-26' AS Date))
GO
INSERT [dbo].[InforOfMaterial] ([IDInfoOfMaterial], [Name], [IDUnit], [Price], [IDSupplier], [IDStatus]) VALUES (N'IM01      ', N'Coffee Type 1', 1, 100000.0000, N'SP01      ', 1)
INSERT [dbo].[InforOfMaterial] ([IDInfoOfMaterial], [Name], [IDUnit], [Price], [IDSupplier], [IDStatus]) VALUES (N'IM02      ', N'Coffee Type 2', 1, 100000.0000, N'SP02      ', 0)
INSERT [dbo].[InforOfMaterial] ([IDInfoOfMaterial], [Name], [IDUnit], [Price], [IDSupplier], [IDStatus]) VALUES (N'IM03      ', N'Milk', 3, 100000.0000, N'SP03      ', 1)
INSERT [dbo].[InforOfMaterial] ([IDInfoOfMaterial], [Name], [IDUnit], [Price], [IDSupplier], [IDStatus]) VALUES (N'IM04      ', N'Milk 4', 3, 94000.0000, N'SP02      ', 1)
GO
INSERT [dbo].[Material] ([IDMaterial], [IDInfoOfMaterial], [ExpiryDate], [DateAdded], [Amount], [AmountLeft]) VALUES (N'MA01      ', N'IM01      ', CAST(N'2021-12-28' AS Date), CAST(N'2021-04-28' AS Date), 50, 20)
GO
INSERT [dbo].[Sexual] ([IDSexual], [Sexual]) VALUES (0, N'Not known           ')
INSERT [dbo].[Sexual] ([IDSexual], [Sexual]) VALUES (1, N'Male                ')
INSERT [dbo].[Sexual] ([IDSexual], [Sexual]) VALUES (2, N'Female              ')
INSERT [dbo].[Sexual] ([IDSexual], [Sexual]) VALUES (9, N'Not applicable      ')
GO
INSERT [dbo].[Status] ([IDStatus], [Status]) VALUES (0, N'NotUse              ')
INSERT [dbo].[Status] ([IDStatus], [Status]) VALUES (1, N'Use                 ')
GO
INSERT [dbo].[Supplier] ([IDSupplier], [Name], [Address], [IDStatus]) VALUES (N'SP01      ', N'Wakanda', N'forever', 1)
INSERT [dbo].[Supplier] ([IDSupplier], [Name], [Address], [IDStatus]) VALUES (N'SP02      ', N'Stark Industry', N'Money', 0)
INSERT [dbo].[Supplier] ([IDSupplier], [Name], [Address], [IDStatus]) VALUES (N'SP03      ', N'NCC4', N'abc', 1)
GO
INSERT [dbo].[TypeAccount] ([IDTypeAccount], [Type]) VALUES (0, N'Admin               ')
INSERT [dbo].[TypeAccount] ([IDTypeAccount], [Type]) VALUES (1, N'Employee            ')
GO
INSERT [dbo].[TypeEmployee] ([IDTypeEmployee], [TypeEmployee]) VALUES (0, N'PartTime            ')
INSERT [dbo].[TypeEmployee] ([IDTypeEmployee], [TypeEmployee]) VALUES (1, N'FullTime            ')
GO
INSERT [dbo].[Unit] ([IDUnit], [Unit]) VALUES (0, N'gram                ')
INSERT [dbo].[Unit] ([IDUnit], [Unit]) VALUES (1, N'kilogram            ')
INSERT [dbo].[Unit] ([IDUnit], [Unit]) VALUES (2, N'package             ')
INSERT [dbo].[Unit] ([IDUnit], [Unit]) VALUES (3, N'bottle              ')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([IDEmployee])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Employee]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Status]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_TypeAccount] FOREIGN KEY([IDTypeAccount])
REFERENCES [dbo].[TypeAccount] ([IDTypeAccount])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_TypeAccount]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Branch] FOREIGN KEY([IDBranch])
REFERENCES [dbo].[Branch] ([IDBranch])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Branch]
GO
ALTER TABLE [dbo].[BillExport]  WITH CHECK ADD  CONSTRAINT [FK_Imort_Branch] FOREIGN KEY([IDBranch])
REFERENCES [dbo].[Branch] ([IDBranch])
GO
ALTER TABLE [dbo].[BillExport] CHECK CONSTRAINT [FK_Imort_Branch]
GO
ALTER TABLE [dbo].[Branch]  WITH CHECK ADD  CONSTRAINT [FK_Branch_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[Branch] CHECK CONSTRAINT [FK_Branch_Status]
GO
ALTER TABLE [dbo].[DetailOfBill]  WITH CHECK ADD  CONSTRAINT [FK_DetailOfBill_Bill] FOREIGN KEY([IDBill])
REFERENCES [dbo].[Bill] ([IDBill])
GO
ALTER TABLE [dbo].[DetailOfBill] CHECK CONSTRAINT [FK_DetailOfBill_Bill]
GO
ALTER TABLE [dbo].[DetailOfBill]  WITH CHECK ADD  CONSTRAINT [FK_DetailOfBill_Drink] FOREIGN KEY([IDDrink])
REFERENCES [dbo].[Drink] ([IDDrink])
GO
ALTER TABLE [dbo].[DetailOfBill] CHECK CONSTRAINT [FK_DetailOfBill_Drink]
GO
ALTER TABLE [dbo].[DetailOfBillExport]  WITH CHECK ADD  CONSTRAINT [FK_DetailOfBillExport_BillExport] FOREIGN KEY([IDBillExport])
REFERENCES [dbo].[BillExport] ([IDBillExport])
GO
ALTER TABLE [dbo].[DetailOfBillExport] CHECK CONSTRAINT [FK_DetailOfBillExport_BillExport]
GO
ALTER TABLE [dbo].[DetailOfBillExport]  WITH CHECK ADD  CONSTRAINT [FK_DetailOfBillExport_Material] FOREIGN KEY([IDMaterial])
REFERENCES [dbo].[Material] ([IDMaterial])
GO
ALTER TABLE [dbo].[DetailOfBillExport] CHECK CONSTRAINT [FK_DetailOfBillExport_Material]
GO
ALTER TABLE [dbo].[Drink]  WITH CHECK ADD  CONSTRAINT [FK_Drink_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[Drink] CHECK CONSTRAINT [FK_Drink_Status]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Branch] FOREIGN KEY([IDBranch])
REFERENCES [dbo].[Branch] ([IDBranch])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Branch]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Sexual] FOREIGN KEY([IDSexual])
REFERENCES [dbo].[Sexual] ([IDSexual])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Sexual]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Status]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_TypeEmployee] FOREIGN KEY([IDTypeEmployee])
REFERENCES [dbo].[TypeEmployee] ([IDTypeEmployee])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_TypeEmployee]
GO
ALTER TABLE [dbo].[FullTimeEmployeeManagement]  WITH CHECK ADD  CONSTRAINT [FK_FullTimeEmployeeManagement_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([IDEmployee])
GO
ALTER TABLE [dbo].[FullTimeEmployeeManagement] CHECK CONSTRAINT [FK_FullTimeEmployeeManagement_Employee]
GO
ALTER TABLE [dbo].[InforOfMaterial]  WITH CHECK ADD  CONSTRAINT [FK_InforOfMaterial_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[InforOfMaterial] CHECK CONSTRAINT [FK_InforOfMaterial_Status]
GO
ALTER TABLE [dbo].[InforOfMaterial]  WITH CHECK ADD  CONSTRAINT [FK_InforOfMaterial_Supplier] FOREIGN KEY([IDSupplier])
REFERENCES [dbo].[Supplier] ([IDSupplier])
GO
ALTER TABLE [dbo].[InforOfMaterial] CHECK CONSTRAINT [FK_InforOfMaterial_Supplier]
GO
ALTER TABLE [dbo].[InforOfMaterial]  WITH CHECK ADD  CONSTRAINT [FK_InforOfMaterial_Unit] FOREIGN KEY([IDUnit])
REFERENCES [dbo].[Unit] ([IDUnit])
GO
ALTER TABLE [dbo].[InforOfMaterial] CHECK CONSTRAINT [FK_InforOfMaterial_Unit]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_InforOfMaterial] FOREIGN KEY([IDInfoOfMaterial])
REFERENCES [dbo].[InforOfMaterial] ([IDInfoOfMaterial])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_InforOfMaterial]
GO
ALTER TABLE [dbo].[PartTimeEmployeeManagement]  WITH CHECK ADD  CONSTRAINT [FK_PartTimeEmployeeManagement_Employee] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employee] ([IDEmployee])
GO
ALTER TABLE [dbo].[PartTimeEmployeeManagement] CHECK CONSTRAINT [FK_PartTimeEmployeeManagement_Employee]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Status2] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Status2]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDrinkList]    Script Date: 4/29/2021 4:30:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[USP_GetDrinkList]
 as select * from dbo.Drink


GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 4/29/2021 4:30:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
	@userName char(30),
	@passWord nvarchar(50)
as
	begin
		select * from dbo.Account where Username = @userName and Password = @passWord
	end
GO
USE [master]
GO
ALTER DATABASE [QuanLiChuoiCF] SET  READ_WRITE 
GO
