USE [master]
GO
/****** Object:  Database [North_Diamond_Hotel]    Script Date: 12/29/2022 7:12:20 AM ******/
CREATE DATABASE [North_Diamond_Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'North_Diamond_Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\North_Diamond_Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'North_Diamond_Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\North_Diamond_Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [North_Diamond_Hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [North_Diamond_Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [North_Diamond_Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [North_Diamond_Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [North_Diamond_Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [North_Diamond_Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [North_Diamond_Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [North_Diamond_Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [North_Diamond_Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [North_Diamond_Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [North_Diamond_Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [North_Diamond_Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [North_Diamond_Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [North_Diamond_Hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [North_Diamond_Hotel] SET QUERY_STORE = OFF
GO
USE [North_Diamond_Hotel]
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[Type] [nvarchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Activity_Reservations]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity_Reservations](
	[Name] [nvarchar](50) NOT NULL,
	[Guest_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Activity_Reservations] PRIMARY KEY CLUSTERED 
(
	[Guest_ID] ASC,
	[Date] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animation]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animation](
	[Staff_ID] [int] NOT NULL,
	[Show_Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Animation] PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC,
	[Show_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bar_Orders]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bar_Orders](
	[Bar_Location] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Food_Type] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bars]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bars](
	[Working_Hours] [nvarchar](50) NOT NULL,
	[Drink_Type] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bars_1] PRIMARY KEY CLUSTERED 
(
	[Location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chefs]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chefs](
	[Staff_ID] [int] NOT NULL,
	[Restaurant_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Chefs] PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Club_Reservations]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Club_Reservations](
	[Name] [nvarchar](50) NOT NULL,
	[Guest_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Club_Reservations_1] PRIMARY KEY CLUSTERED 
(
	[Guest_ID] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[Working_Hours] [nvarchar](50) NOT NULL,
	[Age_Restriction] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[Percentage] [float] NOT NULL,
	[Min_Duration] [int] NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[Percentage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food_and_Beverages]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food_and_Beverages](
	[Type] [nvarchar](50) NOT NULL,
	[Cost_per_Kilogram] [money] NOT NULL,
 CONSTRAINT [PK_Food_and_Beverages] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guests]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[ID] [int] NOT NULL,
	[Phone_No] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hall_reservation]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hall_reservation](
	[Name] [nvarchar](50) NOT NULL,
	[Guest_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Event_Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Hall_reservation] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Halls]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Halls](
	[Capacity] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_Halls] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Housekeeping]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Housekeeping](
	[Staff_ID] [int] NOT NULL,
	[Room_No] [int] NOT NULL,
 CONSTRAINT [PK_Housekeeping] PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC,
	[Room_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurant]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurant](
	[Location] [nvarchar](50) NOT NULL,
	[Cuisine] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Capacity] [int] NOT NULL,
	[Cost] [money] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurant_Orders]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurant_Orders](
	[Restaurant_Name] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Food_Type] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Restaurant_Orders] PRIMARY KEY CLUSTERED 
(
	[Restaurant_Name] ASC,
	[Quantity] ASC,
	[Food_Type] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurant_Reservations]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurant_Reservations](
	[Name] [nvarchar](50) NOT NULL,
	[Guest_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Restaurant_Reservations] PRIMARY KEY CLUSTERED 
(
	[Guest_ID] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Reservations]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Reservations](
	[Room_No] [int] NOT NULL,
	[Guest_ID] [int] NOT NULL,
	[Discount_Percentage] [float] NOT NULL,
	[Check_In] [date] NOT NULL,
	[Check_Out] [date] NOT NULL,
 CONSTRAINT [PK_Room_Reservations] PRIMARY KEY CLUSTERED 
(
	[Guest_ID] ASC,
	[Room_No] ASC,
	[Check_In] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Room_No] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
	[Cost] [float] NOT NULL,
	[Sea_View] [bit] NOT NULL,
	[Pool_View] [bit] NOT NULL,
	[Garden_View] [bit] NOT NULL,
	[Is_Clean] [bit] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Room_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Show_Time]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Show_Time](
	[Type] [nvarchar](50) NOT NULL,
	[Time] [date] NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Show_Time_1] PRIMARY KEY CLUSTERED 
(
	[Type] ASC,
	[Time] ASC,
	[Location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Ph#] [nvarchar](50) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Job_Type] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Time_of_Activity]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time_of_Activity](
	[Type] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Time_of_Activity_1] PRIMARY KEY CLUSTERED 
(
	[Type] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Bike', 50.0000)
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Cruise', 3500.0000)
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Diving', 150.0000)
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Parasailing', 250.0000)
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Safari', 200.0000)
INSERT [dbo].[Activities] ([Type], [Cost]) VALUES (N'Spa', 120.0000)
GO
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Parasailing', 1214, CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Bike', 1214, CAST(N'2023-02-04' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Safari', 1412, CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Parasailing', 1412, CAST(N'2023-01-03' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Cruise', 4578, CAST(N'2023-04-30' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Diving', 5246, CAST(N'2023-01-31' AS Date))
INSERT [dbo].[Activity_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Bike', 6547, CAST(N'2023-02-04' AS Date))
GO
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (120457, N'Magic')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (124578, N'Latin dance')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (224548, N'Play')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (253647, N'Light show')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (254975, N'Zumba')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (457567, N'Mr Diamond')
INSERT [dbo].[Animation] ([Staff_ID], [Show_Type]) VALUES (879874, N'Fire Show')
GO
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (14634, N'Haboubas Kitchen')
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (28460, N'Poki Toki')
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (45621, N'Coulis')
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (55446, N'Diamond Core ')
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (78451, N'Cucina Mia')
INSERT [dbo].[Chefs] ([Staff_ID], [Restaurant_Name]) VALUES (87423, N'Cucina Mia')
GO
INSERT [dbo].[Club_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Blume ', 1214, CAST(N'2022-12-28' AS Date))
INSERT [dbo].[Club_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'KaBoom', 1412, CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Club_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Bongos', 2526, CAST(N'2022-12-18' AS Date))
INSERT [dbo].[Club_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Blume', 6547, CAST(N'2023-01-13' AS Date))
GO
INSERT [dbo].[Clubs] ([Working_Hours], [Age_Restriction], [Name], [Cost]) VALUES (N'9-4', 18, N'Blume ', 200.0000)
INSERT [dbo].[Clubs] ([Working_Hours], [Age_Restriction], [Name], [Cost]) VALUES (N'8-5', 21, N'Bongos', 250.0000)
INSERT [dbo].[Clubs] ([Working_Hours], [Age_Restriction], [Name], [Cost]) VALUES (N'7-1', 18, N'KaBoom', 180.0000)
INSERT [dbo].[Clubs] ([Working_Hours], [Age_Restriction], [Name], [Cost]) VALUES (N'6-12', 16, N'La Sierra', 120.0000)
GO
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (5, 5)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (10, 10)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (15, 15)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (20, 20)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (25, 25)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (30, 30)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (35, 35)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (40, 40)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (45, 45)
INSERT [dbo].[Discount] ([Percentage], [Min_Duration]) VALUES (50, 50)
GO
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Bamya', 50.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Bread', 50.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Brownies', 170.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Burger', 150.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Cake', 160.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Carrot', 30.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Cheese', 90.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Chicken', 120.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Chilli', 40.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Coffe', 50.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Crab', 180.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Dough', 80.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Fish', 200.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Fool', 100.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Fresca', 60.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Fries', 70.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Gin', 340.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Green Tea', 45.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'honey', 70.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Hot Dog', 50.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Lemon', 30.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Lettuce', 35.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Mango', 30.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Mirenda', 40.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Molokheya', 75.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Mushrooms', 120.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Noodles', 80.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Pancake', 85.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Pasta', 70.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Peppers', 55.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Pepsi', 40.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Red Wine', 400.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Rice', 65.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Rum', 320.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Seaweed', 400.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Shrimp', 180.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Soup', 90.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Spinach', 65.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Sprite', 40.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Strawberry', 35.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Sugar', 120.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Sunshine', 60.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Tea', 35.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Tequilla', 300.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Tomato', 30.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Vodka ', 350.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Waffle', 80.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Water', 30.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'Whiskey', 320.0000)
INSERT [dbo].[Food_and_Beverages] ([Type], [Cost_per_Kilogram]) VALUES (N'White Wine', 400.0000)
GO
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (1214, N'0165487624', N'roqaia.ihab02@yahoo.com', N'Roqaia', N'Ihab', 18)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (1412, N'0114865476', N'Aihab@gmail.com', N'Ahmed', N'Ihab', 18)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (2112, N'0123541244', N'marlymofeed@hotmail.com', N'Marly ', N'Mofeed', 20)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (2468, N'1415161778', N'ali@gmail.com', N'Ali', N'Mohamed', 25)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (2526, N'0123252426', N'fouda23.s@gmail.com', N'Mostafa', N'foad', 40)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (4578, N'01005448126', N'lojymosta@gmail.com', N'Lojain', N'Mostafa', 26)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (4758, N'0128457641', N'ggawad@gmail.com', N'gamila', N'awad', 18)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (5246, N'01254855647', N'may.ouza@gmail.com', N'Maya', N'Azab', 21)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (5651, N'0121541354', N'Tarekhany@gmail.com', N'Tarek', N'Hany', 23)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (6402, N'0114154841', N'omaribo@outlook.com', N'Omar', N'Ibrahim', 14)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (6453, N'0113754684', N'midomado@gmail.com', N'Mostafa', N'Metwally', 17)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (6547, N'01235421325', N'zikozaki@hotmail.com', N'Youssef', N'Zaki', 22)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (6551, N'01256468624', N'Shaz.H@yahoo.com', N'Huda', N'Elshazly', 31)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (7953, N'0154849658', N'mhmdtoto@hotmail.com', N'Mohamed', N'Tarek', 29)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (7985, N'0136548232', N'skolta@hotmail.com', N'Sara', N'Kolta', 42)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (8745, N'0125645134', N'yasser.malak@yahoo.com', N'Malak', N'Yasser', 35)
INSERT [dbo].[Guests] ([ID], [Phone_No], [Email], [First_Name], [Last_Name], [Age]) VALUES (9045, N'0125456225', N'mmahdyy@gmail.com', N'Mariam', N'Mahdi', 27)
GO
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Al masah', 1214, CAST(N'2022-12-25' AS Date), N'wed')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Al masah', 1412, CAST(N'2022-12-29' AS Date), N'hhgh')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Al masah', 1214, CAST(N'2023-04-20' AS Date), N'wed')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Fayrouz', 1214, CAST(N'2022-12-28' AS Date), N'wed')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Lo''lo''a', 5651, CAST(N'2022-11-15' AS Date), N'Wedding')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Lo''lo''a', 2468, CAST(N'2022-12-19' AS Date), N'Birthday')
INSERT [dbo].[Hall_reservation] ([Name], [Guest_ID], [Date], [Event_Type]) VALUES (N'Zomoroda', 6551, CAST(N'2022-12-30' AS Date), N'Wedding')
GO
INSERT [dbo].[Halls] ([Capacity], [Name], [Cost]) VALUES (500, N'Al masah', 15000.0000)
INSERT [dbo].[Halls] ([Capacity], [Name], [Cost]) VALUES (1000, N'Fayrouz', 30000.0000)
INSERT [dbo].[Halls] ([Capacity], [Name], [Cost]) VALUES (200, N'Lo''lo''a', 70000.0000)
INSERT [dbo].[Halls] ([Capacity], [Name], [Cost]) VALUES (1500, N'Zomoroda', 32000.0000)
GO
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (1234567, 101)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (1234567, 102)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (1234567, 103)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (1234567, 104)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (1234567, 105)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (6512785, 201)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (6512785, 202)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (6512785, 203)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (6512785, 204)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (6512785, 205)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (8005004, 301)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (8005004, 302)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (8005004, 303)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (8005004, 304)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (8005004, 305)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (9856233, 401)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (9856233, 402)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (9856233, 403)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (9856233, 404)
INSERT [dbo].[Housekeeping] ([Staff_ID], [Room_No]) VALUES (9856233, 405)
GO
INSERT [dbo].[Restaurant] ([Location], [Cuisine], [Type], [Capacity], [Cost], [Name]) VALUES (N'Garden', N'Desserts', N'Sit Down', 40, 60.0000, N'Coulis')
INSERT [dbo].[Restaurant] ([Location], [Cuisine], [Type], [Capacity], [Cost], [Name]) VALUES (N'Pool 3', N'Italian', N'Open Buffet', 200, 200.0000, N'Cucina Mia')
INSERT [dbo].[Restaurant] ([Location], [Cuisine], [Type], [Capacity], [Cost], [Name]) VALUES (N'Lobby', N'Egyptian', N'Open Buffet', 500, 200.0000, N'Diamond Core')
INSERT [dbo].[Restaurant] ([Location], [Cuisine], [Type], [Capacity], [Cost], [Name]) VALUES (N'Beach', N'American', N'Sit Down', 100, 120.0000, N'Haboubas Kitchen')
INSERT [dbo].[Restaurant] ([Location], [Cuisine], [Type], [Capacity], [Cost], [Name]) VALUES (N'Pool 1', N'Asian', N'Sit down', 200, 140.0000, N'Poki Toki')
GO
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Coulis', 2, N'Sugar', CAST(N'2022-12-30' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Coulis', 6, N'Brownies', CAST(N'2022-12-28' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Cucina Mia', 3, N'Tomato', CAST(N'2022-10-12' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Cucina Mia', 7, N'Carrot', CAST(N'2022-12-28' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Cucina Mia', 10, N'Pasta', CAST(N'2022-11-11' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Diamond Core', 3, N'Bamya', CAST(N'2022-12-30' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Diamond Core', 5, N'Fool', CAST(N'2022-11-11' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Diamond Core', 10, N'Water', CAST(N'2022-12-09' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Haboubas Kitchen', 4, N'Burger', CAST(N'2022-12-28' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Haboubas Kitchen', 9, N'Fries', CAST(N'2022-10-12' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Poki Toki', 4, N'Seaweed', CAST(N'2022-12-30' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Poki Toki', 5, N'Lemon', CAST(N'2022-11-11' AS Date))
INSERT [dbo].[Restaurant_Orders] ([Restaurant_Name], [Quantity], [Food_Type], [Date]) VALUES (N'Poki Toki', 6, N'Fish', CAST(N'2022-10-12' AS Date))
GO
INSERT [dbo].[Restaurant_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Diamond Core', 1214, CAST(N'2022-12-16' AS Date))
INSERT [dbo].[Restaurant_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Cucina Mia', 1214, CAST(N'2022-12-28' AS Date))
INSERT [dbo].[Restaurant_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Coulis', 1214, CAST(N'2022-12-30' AS Date))
INSERT [dbo].[Restaurant_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Diamond Core', 1412, CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Restaurant_Reservations] ([Name], [Guest_ID], [Date]) VALUES (N'Haboubas kitchen', 2112, CAST(N'2022-12-24' AS Date))
GO
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (103, 1214, 10, CAST(N'2022-12-23' AS Date), CAST(N'2022-12-24' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (103, 1214, 10, CAST(N'2022-12-29' AS Date), CAST(N'2023-01-10' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (101, 1412, 20, CAST(N'2022-12-14' AS Date), CAST(N'2023-01-04' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (201, 1412, 10, CAST(N'2022-12-29' AS Date), CAST(N'2022-12-30' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (304, 1412, 10, CAST(N'2022-12-28' AS Date), CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (303, 2112, 30, CAST(N'2022-12-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (101, 2526, 5, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-25' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (102, 4578, 10, CAST(N'2023-01-10' AS Date), CAST(N'2023-01-20' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (102, 5246, 10, CAST(N'2023-01-10' AS Date), CAST(N'2023-01-20' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (102, 5651, 10, CAST(N'2023-01-10' AS Date), CAST(N'2023-01-20' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (302, 5651, 10, CAST(N'2022-12-22' AS Date), CAST(N'2022-12-23' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (102, 6402, 10, CAST(N'2023-01-10' AS Date), CAST(N'2023-01-20' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (204, 6453, 25, CAST(N'2023-02-01' AS Date), CAST(N'2023-02-26' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (204, 6547, 25, CAST(N'2023-02-01' AS Date), CAST(N'2023-02-06' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (204, 6551, 25, CAST(N'2023-02-01' AS Date), CAST(N'2023-02-06' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (403, 6551, 10, CAST(N'2022-12-22' AS Date), CAST(N'2022-12-23' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (401, 7953, 5, CAST(N'2023-04-04' AS Date), CAST(N'2023-04-11' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (205, 7985, 15, CAST(N'2022-11-05' AS Date), CAST(N'2022-11-23' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (205, 8745, 15, CAST(N'2022-11-05' AS Date), CAST(N'2022-11-23' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (205, 9045, 15, CAST(N'2022-11-05' AS Date), CAST(N'2022-11-23' AS Date))
INSERT [dbo].[Room_Reservations] ([Room_No], [Guest_ID], [Discount_Percentage], [Check_In], [Check_Out]) VALUES (403, 9045, 10, CAST(N'2022-12-22' AS Date), CAST(N'2022-12-23' AS Date))
GO
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (101, 2, N'Regular', 700, 0, 0, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (102, 4, N'Suite', 1500, 0, 1, 1, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (103, 2, N'Deluxe', 900, 0, 1, 1, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (104, 3, N'Regular', 1200, 1, 0, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (105, 1, N'Deluxe', 700, 1, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (201, 4, N'Deluxe', 1800, 1, 0, 0, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (202, 2, N'Regular', 700, 1, 0, 0, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (203, 4, N'Suite', 1600, 1, 1, 0, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (204, 3, N'Deluxe', 1400, 0, 1, 1, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (205, 3, N'Regular', 1200, 0, 1, 1, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (301, 4, N'Suite', 2000, 1, 1, 0, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (302, 4, N'Regular', 1800, 0, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (303, 1, N'Regular', 500, 0, 0, 1, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (304, 1, N'Deluxe', 700, 1, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (305, 3, N'Deluxe', 1400, 1, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (401, 1, N'Regular', 500, 0, 1, 0, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (402, 2, N'Deluxe', 1200, 1, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (403, 4, N'Regular', 1500, 1, 1, 0, 1)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (404, 4, N'Suite', 2200, 1, 1, 1, 0)
INSERT [dbo].[Rooms] ([Room_No], [Capacity], [Type], [Cost], [Sea_View], [Pool_View], [Garden_View], [Is_Clean]) VALUES (405, 3, N'Deluxe', 1300, 1, 0, 1, 1)
GO
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Belly Dance', CAST(N'2022-12-21' AS Date), N'Pool 3')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Belly Dance', CAST(N'2022-12-25' AS Date), N'Main Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Fire Show', CAST(N'2023-01-01' AS Date), N'Main Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Fire Show', CAST(N'2023-01-07' AS Date), N'Roman Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Latin dance', CAST(N'2022-12-17' AS Date), N'Pool 2')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Latin dance', CAST(N'2022-12-24' AS Date), N'Pool 3')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Light show', CAST(N'2022-01-01' AS Date), N'Main stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Light show', CAST(N'2022-12-30' AS Date), N'Roman Stage ')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Magic', CAST(N'2022-12-22' AS Date), N'Pool 1')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Magic', CAST(N'2022-12-23' AS Date), N'Main stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Magic', CAST(N'2022-12-23' AS Date), N'Roman stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Magic', CAST(N'2022-12-27' AS Date), N'Pool 3')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Mr Diamond', CAST(N'2022-12-12' AS Date), N'Main Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Mr Diamond', CAST(N'2022-12-29' AS Date), N'Pool 1')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Mr Diamond', CAST(N'2022-12-29' AS Date), N'Pool 3')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Mr Diamond', CAST(N'2023-01-15' AS Date), N'Pool 2')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Play', CAST(N'2023-01-07' AS Date), N'Main Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Play', CAST(N'2023-01-18' AS Date), N'Roman Stage')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Zumba', CAST(N'2022-12-16' AS Date), N'Pool 3')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Zumba', CAST(N'2022-12-19' AS Date), N'Pool 1')
INSERT [dbo].[Show_Time] ([Type], [Time], [Location]) VALUES (N'Zumba', CAST(N'2023-01-12' AS Date), N'Pool 3')
GO
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (122, N'vhy', N'Female', N'01289415564', N'cgh', N'hj', 18, N'Animation', N'kjhjfgddfg')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (483, N'Maadi', N'Female', N'01201566533', N'Nardeen', N'Ferweez', 25, N'Manager', N'Nardoiscool')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (798, N'Nasr City', N'Female', N'01289105564', N'Habiba', N'Fahmy', 25, N'Manager', N'H@2002')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (849, N'Dokki', N'Male', N'01225648662', N'David', N'Adel', 26, N'Manager', N'dino_vood')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (1456, N'zayed', N'Male', N'01445879654', N'Youssef', N'tamim', 32, N'Receptionist', N'y@1122')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (2264, N'tagamoa', N'Male', N'01154798125', N'Marco', N'Polo', 35, N'Receptionist', N'mp@1234')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (4545, N'', N'Female', N'01225568745', N'gvghvk', N'hgkvlj', 18, N'Animation', N'vghujv')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (5341, N'New Cairo', N'Female', N'01978564245', N'Salma', N'Ashraf', 25, N'Receptionist', N'nash@30')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (14634, N'Alexandria', N'Female', N'01334578122', N'Habouba', N'Wael', 34, N'Chef', N'lightninmkween')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (28460, N'maadi', N'Male', N'01191454564', N'Alhassan', N'Nabil', 41, N'Chef', N'kotyhassan')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (45621, N'Suez', N'Male', N'01256156247', N'Ahmed', N'Sameh', 24, N'Chef', N'semsem.02')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (55446, N'Nasr City', N'Male', N'01223348665', N'Mohamed ', N'Boraiy', 32, N'Chef', N'lemaza')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (78451, N'Korba', N'Female', N'01322459847', N'Sarraa', N'Khalil', 29, N'Chef', N'mamasoso')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (87423, N'Rehab ', N'Male ', N'01009145644', N'Mahmoud', N'Salah', 27, N'Chef ', N'S@341')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (120457, N'Luxor', N'Male', N'01226645897', N'Mina', N'Sultan', 24, N'Animation', N'm@1234')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (124578, N'Alexandria', N'Female', N'01245484345', N'Fatema', N'Kotb', 22, N'Animation', N'fkotb')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (224548, N'Gona', N'Female', N'01005478547', N'Hanzada', N'Fayez', 29, N'Animation', N'zozozozi')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (253647, N'Nasr City', N'Male', N'01415545975', N'Yehia', N'Yasser', 24, N'Animation', N'yyasser1997')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (254975, N'Zayed', N'Female', N'01245895723', N'Jana', N'Selim', 26, N'Animation', N'selimooo')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (457567, N'Agouza', N'Male', N'01254872354', N'Peter', N'Maximus', 25, N'Animation', N'petorewesh')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (879874, N'Tanta', N'Male', N'01154865478', N'Maged', N'Emara', 23, N'Animation', N'gedohabibi')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (1234567, N'Maadi', N'Female', N'01234545471', N'Hanady', N'Mehana', 34, N'Housekeeping', N'hanady@mehana')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (5488465, N'Zayed', N'Male', N'01215423254', N'Ziad', N'Abdelwareth', 31, N'Housekeeping', N'zozziz')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (6512785, N'Dokki', N'Female', N'01247535452', N'Sarah', N'Milad', 40, N'Housekeeping', N'S@1234')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (8005004, N'Hurgada', N'Female', N'01455684512', N'Manal', N'Salem', 29, N'Housekeeping', N'Salem_manal')
INSERT [dbo].[Staff] ([ID], [Address], [Gender], [Ph#], [First_Name], [Last_Name], [Age], [Job_Type], [Password]) VALUES (9856233, N'Rehab', N'Male', N'01006894175', N'Marwan', N'Mohamed', 35, N'Housekeeping', N'maro@300')
GO
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Bike', CAST(N'2022-12-19' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Bike', CAST(N'2023-02-04' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Cruise', CAST(N'2023-04-30' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Cruise', CAST(N'2023-07-03' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Diving', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Diving', CAST(N'2023-01-31' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Parasailing', CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Parasailing ', CAST(N'2023-01-03' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Safari', CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Safari', CAST(N'2023-01-25' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Spa', CAST(N'2023-01-05' AS Date))
INSERT [dbo].[Time_of_Activity] ([Type], [Date]) VALUES (N'Spa', CAST(N'2023-02-02' AS Date))
GO
ALTER TABLE [dbo].[Activity_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Reservations_Activity_Reservations] FOREIGN KEY([Name], [Date])
REFERENCES [dbo].[Time_of_Activity] ([Type], [Date])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Activity_Reservations] CHECK CONSTRAINT [FK_Activity_Reservations_Activity_Reservations]
GO
ALTER TABLE [dbo].[Activity_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Reservations_Guests] FOREIGN KEY([Guest_ID])
REFERENCES [dbo].[Guests] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Activity_Reservations] CHECK CONSTRAINT [FK_Activity_Reservations_Guests]
GO
ALTER TABLE [dbo].[Animation]  WITH CHECK ADD  CONSTRAINT [FK_Animation_Animation1] FOREIGN KEY([Staff_ID], [Show_Type])
REFERENCES [dbo].[Animation] ([Staff_ID], [Show_Type])
GO
ALTER TABLE [dbo].[Animation] CHECK CONSTRAINT [FK_Animation_Animation1]
GO
ALTER TABLE [dbo].[Animation]  WITH CHECK ADD  CONSTRAINT [FK_Animation_Staff] FOREIGN KEY([Staff_ID])
REFERENCES [dbo].[Staff] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Animation] CHECK CONSTRAINT [FK_Animation_Staff]
GO
ALTER TABLE [dbo].[Chefs]  WITH CHECK ADD  CONSTRAINT [FK_Chefs_Restaurant] FOREIGN KEY([Restaurant_Name])
REFERENCES [dbo].[Restaurant] ([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Chefs] CHECK CONSTRAINT [FK_Chefs_Restaurant]
GO
ALTER TABLE [dbo].[Chefs]  WITH CHECK ADD  CONSTRAINT [FK_Chefs_Staff] FOREIGN KEY([Staff_ID])
REFERENCES [dbo].[Staff] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Chefs] CHECK CONSTRAINT [FK_Chefs_Staff]
GO
ALTER TABLE [dbo].[Club_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Club_Reservations_Clubs] FOREIGN KEY([Name])
REFERENCES [dbo].[Clubs] ([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Club_Reservations] CHECK CONSTRAINT [FK_Club_Reservations_Clubs]
GO
ALTER TABLE [dbo].[Club_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Club_Reservations_Guests] FOREIGN KEY([Guest_ID])
REFERENCES [dbo].[Guests] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Club_Reservations] CHECK CONSTRAINT [FK_Club_Reservations_Guests]
GO
ALTER TABLE [dbo].[Hall_reservation]  WITH CHECK ADD  CONSTRAINT [FK_Hall_reservation_Hall_reservation] FOREIGN KEY([Guest_ID])
REFERENCES [dbo].[Guests] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Hall_reservation] CHECK CONSTRAINT [FK_Hall_reservation_Hall_reservation]
GO
ALTER TABLE [dbo].[Hall_reservation]  WITH CHECK ADD  CONSTRAINT [FK_Hall_reservation_Halls] FOREIGN KEY([Name])
REFERENCES [dbo].[Halls] ([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Hall_reservation] CHECK CONSTRAINT [FK_Hall_reservation_Halls]
GO
ALTER TABLE [dbo].[Housekeeping]  WITH CHECK ADD  CONSTRAINT [FK_Housekeeping_Rooms] FOREIGN KEY([Room_No])
REFERENCES [dbo].[Rooms] ([Room_No])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Housekeeping] CHECK CONSTRAINT [FK_Housekeeping_Rooms]
GO
ALTER TABLE [dbo].[Housekeeping]  WITH CHECK ADD  CONSTRAINT [FK_Housekeeping_Staff] FOREIGN KEY([Staff_ID])
REFERENCES [dbo].[Staff] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Housekeeping] CHECK CONSTRAINT [FK_Housekeeping_Staff]
GO
ALTER TABLE [dbo].[Restaurant_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Orders_Food_and_Beverages] FOREIGN KEY([Food_Type])
REFERENCES [dbo].[Food_and_Beverages] ([Type])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Restaurant_Orders] CHECK CONSTRAINT [FK_Restaurant_Orders_Food_and_Beverages]
GO
ALTER TABLE [dbo].[Restaurant_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Orders_Restaurant] FOREIGN KEY([Restaurant_Name])
REFERENCES [dbo].[Restaurant] ([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Restaurant_Orders] CHECK CONSTRAINT [FK_Restaurant_Orders_Restaurant]
GO
ALTER TABLE [dbo].[Restaurant_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Reservations_Guests] FOREIGN KEY([Guest_ID])
REFERENCES [dbo].[Guests] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Restaurant_Reservations] CHECK CONSTRAINT [FK_Restaurant_Reservations_Guests]
GO
ALTER TABLE [dbo].[Restaurant_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Reservations_Restaurant_Reservations] FOREIGN KEY([Name])
REFERENCES [dbo].[Restaurant] ([Name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Restaurant_Reservations] CHECK CONSTRAINT [FK_Restaurant_Reservations_Restaurant_Reservations]
GO
ALTER TABLE [dbo].[Room_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Table1_Discount] FOREIGN KEY([Discount_Percentage])
REFERENCES [dbo].[Discount] ([Percentage])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Room_Reservations] CHECK CONSTRAINT [FK_Table1_Discount]
GO
ALTER TABLE [dbo].[Room_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Table1_Guests] FOREIGN KEY([Guest_ID])
REFERENCES [dbo].[Guests] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Room_Reservations] CHECK CONSTRAINT [FK_Table1_Guests]
GO
ALTER TABLE [dbo].[Room_Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Table1_Rooms] FOREIGN KEY([Room_No])
REFERENCES [dbo].[Rooms] ([Room_No])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Room_Reservations] CHECK CONSTRAINT [FK_Table1_Rooms]
GO
ALTER TABLE [dbo].[Show_Time]  WITH CHECK ADD  CONSTRAINT [FK_Show_Time_Show_Time] FOREIGN KEY([Type], [Time], [Location])
REFERENCES [dbo].[Show_Time] ([Type], [Time], [Location])
GO
ALTER TABLE [dbo].[Show_Time] CHECK CONSTRAINT [FK_Show_Time_Show_Time]
GO
ALTER TABLE [dbo].[Time_of_Activity]  WITH CHECK ADD  CONSTRAINT [FK_Time_of_Activity_Activities] FOREIGN KEY([Type])
REFERENCES [dbo].[Activities] ([Type])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Time_of_Activity] CHECK CONSTRAINT [FK_Time_of_Activity_Activities]
GO
/****** Object:  StoredProcedure [dbo].[addGuest]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[addGuest]
@id int,
@phone_no nvarchar(40),
@email nvarchar(40),
@Fname nvarchar(40),
@Lname nvarchar (40),
@age int

as
begin
insert into Guests
values (@id, @phone_no, @email, @Fname, @Lname, @age)
end
GO
/****** Object:  StoredProcedure [dbo].[bookHall]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[bookHall]
@name nvarchar(40),
@date date,
@EventType nvarchar(40),
@id int

as
begin
insert into Hall_Reservation
values (@name, @id, @date, @EventType)
end
GO
/****** Object:  StoredProcedure [dbo].[bookRoom]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[bookRoom]
@id int,
@room int,
@discount int,
@inDate date,
@outDate date

as
begin
insert into Room_Reservations
values (@room,@id, @discount, @inDate, @outDate)
end
GO
/****** Object:  StoredProcedure [dbo].[getAvailableRooms]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getAvailableRooms]
@indate date,
@outDate date,
@capacity int,
@type nvarchar(40)

as
begin
select Room_No, Cost, Capacity, Sea_View, Pool_View, Garden_View From Rooms where Capacity >= @capacity and Type = @type
Except
select R.Room_No, R.Cost, R.Capacity, R.Sea_View, R.Pool_View, R.Garden_View from Rooms R, Room_Reservations RR where (R.Room_No = RR.Room_No) and ((@indate between RR.Check_In and RR.Check_Out ) or (@outDate between rr.Check_In and rr.Check_Out) or (@indate < rr.Check_In and @outDate > rr.Check_Out))
end

GO
/****** Object:  StoredProcedure [dbo].[getHallCapacities]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getHallCapacities]
as
begin
Select Capacity from Halls
end

GO
/****** Object:  StoredProcedure [dbo].[GetPasswordandJobTypeFromID]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetPasswordandJobTypeFromID]
@ID int

as
begin
Select Password, Job_Type from Staff where ID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[getRoomsToClean]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getRoomsToClean]
@id int

as
begin
Select Room_No FROM Housekeeping where Staff_ID = @id and Room_No IN
(Select Room_No FROM Rooms where Is_Clean= 0)
end

GO
/****** Object:  StoredProcedure [dbo].[getStaffNameFromID]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getStaffNameFromID]
@id int

as
begin
Select First_Name FROM Staff where ID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[markRoomAsCleaned]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[markRoomAsCleaned]
@Rno int

as
begin
Update Rooms Set Is_Clean = 1 where Room_No = @Rno
end

GO
/****** Object:  StoredProcedure [dbo].[UpdatePasswordFromID]    Script Date: 12/29/2022 7:12:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdatePasswordFromID]
@ID int,
@newPassword nvarchar(40)

as
begin
update staff set Password = @newPassword where ID = @ID
end

GO
USE [master]
GO
ALTER DATABASE [North_Diamond_Hotel] SET  READ_WRITE 
GO
