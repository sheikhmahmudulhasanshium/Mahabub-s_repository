USE [master]
GO
/****** Object:  Database [Cafe Management System]    Script Date: 8/25/2021 6:04:21 PM ******/
CREATE DATABASE [Cafe Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cafe Management System', FILENAME = N'D:\program files\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cafe Management System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cafe Management System_log', FILENAME = N'D:\program files\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cafe Management System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Cafe Management System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cafe Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cafe Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cafe Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cafe Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cafe Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cafe Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cafe Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cafe Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cafe Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cafe Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cafe Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cafe Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cafe Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cafe Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cafe Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cafe Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cafe Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cafe Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cafe Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cafe Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cafe Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cafe Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cafe Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cafe Management System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cafe Management System] SET  MULTI_USER 
GO
ALTER DATABASE [Cafe Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cafe Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cafe Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cafe Management System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cafe Management System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cafe Management System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Cafe Management System] SET QUERY_STORE = OFF
GO
USE [Cafe Management System]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Role] [nvarchar](80) NOT NULL,
	[ContactNo] [nvarchar](30) NULL,
	[Address] [nvarchar](200) NULL,
	[JoiningDate] [date] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[Price] [float] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[OrdersView]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OrdersView]
AS
SELECT        dbo.Orders.Id AS OrderId, FORMAT(dbo.Orders.Date, 'dd-MM-yyyy') AS Date, dbo.Orders.Price, dbo.Users.Name AS EmployeeName
FROM            dbo.Orders INNER JOIN
                         dbo.Users ON dbo.Orders.EmployeeId = dbo.Users.Id
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CategoryId] [int] NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersItems]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[FoodId] [int] NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_OrdersItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[OrdersItemsView]    Script Date: 8/25/2021 6:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OrdersItemsView]
AS
SELECT        dbo.OrdersItems.OrderId, dbo.Categories.Name AS Category, dbo.Foods.Name AS Item, dbo.OrdersItems.Quantity, dbo.OrdersItems.Price
FROM            dbo.Categories INNER JOIN
                         dbo.Foods ON dbo.Categories.Id = dbo.Foods.CategoryId INNER JOIN
                         dbo.OrdersItems ON dbo.Foods.Id = dbo.OrdersItems.FoodId
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Coffee')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Sandwiches')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Bakery')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Foods] ON 

INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (1, N'Frappuccino', 1, 2.95)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (4, N'Caramel macchiato', 1, 5.23)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (5, N'Americano', 1, 5.67)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (6, N'Turkish coffee', 1, 3.32)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (7, N'Cafe latte', 1, 7.35)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (8, N'Iced coffee', 1, 4.12)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (9, N'Plain coffee', 1, 2.29)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (10, N'Cheesesteak', 2, 14.23)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (11, N'Doner Kebab', 2, 10.25)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (12, N'Taco Sandwich', 2, 12.55)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (13, N'Caprese Grilled Cheese Sandwich', 2, 11.75)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (14, N'Grilled Zucchini Hummus Wrap', 2, 9.25)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (15, N'Cinnamon-crumb coffeecake', 3, 7.66)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (16, N'Cheese croissant', 3, 5.25)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (17, N'Hotdog buns', 3, 6.23)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (45, N'Black', 1, 2.22)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (46, N'Fish', 2, 5.22)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (47, N'Sweet pie', 3, 1.22)
INSERT [dbo].[Foods] ([Id], [Name], [CategoryId], [Price]) VALUES (48, N'plain', 1, -20)
SET IDENTITY_INSERT [dbo].[Foods] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (1, 20, 45.068504, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (2, 20, 20.5, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (3, 20, 74.5775, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (4, 20, 23.1495, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (5, 20, 10.25, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (7, 20, 13.041, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (8, 20, 13.041, CAST(N'2021-08-22' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (9, 20, 58.590004, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (10, 20, 58.590004, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (12, 20, 30.75, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (13, 20, 30.75, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (14, 20, 37.22, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (15, 20, 37.22, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (16, 4, 62.215004, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (17, 4, 62.215004, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (18, 22, 39.5485, CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Orders] ([Id], [EmployeeId], [Price], [Date]) VALUES (19, 22, 39.5485, CAST(N'2021-08-23' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdersItems] ON 

INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (1, 1, 11, 2, 20.5)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (2, 1, 17, 3, 18.69)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (3, 2, 11, 2, 20.5)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (4, 3, 11, 3, 30.75)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (5, 3, 1, 1, 2.95)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (6, 3, 17, 5, 31.15)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (7, 4, 1, 2, 5.9)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (8, 4, 10, 1, 14.23)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (9, 5, 11, 1, 10.25)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (10, 7, 5, 2, 11.34)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (11, 9, 4, 3, 15.690001)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (12, 9, 12, 3, 37.65)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (13, 9, 16, 1, 5.25)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (14, 12, 11, 3, 30.75)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (15, 14, 15, 1, 7.66)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (16, 14, 5, 3, 17.01)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (17, 14, 12, 1, 12.55)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (18, 16, 11, 3, 30.75)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (19, 16, 4, 3, 15.690001)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (20, 16, 15, 1, 7.66)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (21, 18, 5, 2, 11.34)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (22, 18, 12, 1, 12.55)
INSERT [dbo].[OrdersItems] ([Id], [OrderId], [FoodId], [Quantity], [Price]) VALUES (23, 18, 16, 2, 10.5)
SET IDENTITY_INSERT [dbo].[OrdersItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Gender], [Email], [Password], [Role], [ContactNo], [Address], [JoiningDate]) VALUES (4, N'Rachel Green', N'Female', N'green@gmail.com', N'green123  ', N'Employee', N'572-887-90', N'Dhaka', CAST(N'2019-08-10' AS Date))
INSERT [dbo].[Users] ([Id], [Name], [Gender], [Email], [Password], [Role], [ContactNo], [Address], [JoiningDate]) VALUES (5, N'Gunther ', N'Male', N'gunther@gmail.com', N'gunther123', N'Employee', N'891-456-09', N'Dhaka', CAST(N'2021-01-01' AS Date))
INSERT [dbo].[Users] ([Id], [Name], [Gender], [Email], [Password], [Role], [ContactNo], [Address], [JoiningDate]) VALUES (20, N'Tasneem Jahan', N'Female', N'jahan@gmail.com', N'jahan123  ', N'Admin', N'678-872-97', N'Dhaka', CAST(N'2021-08-23' AS Date))
INSERT [dbo].[Users] ([Id], [Name], [Gender], [Email], [Password], [Role], [ContactNo], [Address], [JoiningDate]) VALUES (22, N'Abir', N'Male', N'abir@gmail.com', N'abir123   ', N'Admin', N'122-999-90', N'Narayanganj', CAST(N'2021-08-23' AS Date))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Foods]  WITH CHECK ADD  CONSTRAINT [FK_Foods_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Foods] CHECK CONSTRAINT [FK_Foods_Categories]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Users] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[OrdersItems]  WITH CHECK ADD  CONSTRAINT [FK_OrdersItems_Foods] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Foods] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[OrdersItems] CHECK CONSTRAINT [FK_OrdersItems_Foods]
GO
ALTER TABLE [dbo].[OrdersItems]  WITH CHECK ADD  CONSTRAINT [FK_OrdersItems_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[OrdersItems] CHECK CONSTRAINT [FK_OrdersItems_Orders]
GO
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
         Begin Table = "Categories"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Foods"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OrdersItems"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 228
               Right = 679
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
      Begin ColumnWidths = 11
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrdersItemsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrdersItemsView'
GO
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
         Begin Table = "Orders"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Users"
            Begin Extent = 
               Top = 6
               Left = 870
               Bottom = 136
               Right = 1040
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
      Begin ColumnWidths = 11
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrdersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrdersView'
GO
USE [master]
GO
ALTER DATABASE [Cafe Management System] SET  READ_WRITE 
GO
