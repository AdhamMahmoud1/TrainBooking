USE [master]
GO
/****** Object:  Database [BookingTrain]    Script Date: 5/22/2023 3:00:56 PM ******/
CREATE DATABASE [BookingTrain]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookingTrain', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BookingTrain.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookingTrain_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BookingTrain_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BookingTrain] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookingTrain].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookingTrain] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookingTrain] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookingTrain] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookingTrain] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookingTrain] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookingTrain] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookingTrain] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookingTrain] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookingTrain] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookingTrain] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookingTrain] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookingTrain] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookingTrain] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookingTrain] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookingTrain] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookingTrain] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookingTrain] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookingTrain] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookingTrain] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookingTrain] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookingTrain] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookingTrain] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookingTrain] SET RECOVERY FULL 
GO
ALTER DATABASE [BookingTrain] SET  MULTI_USER 
GO
ALTER DATABASE [BookingTrain] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookingTrain] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookingTrain] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookingTrain] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookingTrain] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookingTrain] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookingTrain', N'ON'
GO
ALTER DATABASE [BookingTrain] SET QUERY_STORE = ON
GO
ALTER DATABASE [BookingTrain] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BookingTrain]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/22/2023 3:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[SSN] [varchar](15) NOT NULL,
	[name] [varchar](50) NULL,
	[gender] [varchar](5) NULL,
	[PASSWORD] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paasenger]    Script Date: 5/22/2023 3:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paasenger](
	[SSN] [varchar](15) NOT NULL,
	[name] [varchar](50) NULL,
	[gender] [varchar](5) NULL,
	[PASSWORD] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 5/22/2023 3:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[price] [float] NULL,
	[route] [varchar](50) NULL,
	[TripID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Train]    Script Date: 5/22/2023 3:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Train](
	[TrainID] [int] IDENTITY(1, 1) NOT NULL,
	[seats] [int] NULL,
	[kind] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[TrainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 5/22/2023 3:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Tid] [int] IDENTITY(1, 1) NOT NULL,
	[source] [varchar](30) NULL,
	[distination] [varchar](30) NULL,
	[TrainID] [int] NULL,
	[arrivalTime] [varchar](50) NULL,
	[Date] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD FOREIGN KEY([TripID])
REFERENCES [dbo].[Trip] ([Tid])
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD FOREIGN KEY([TrainID])
REFERENCES [dbo].[Train] ([TrainID])
GO
USE [master]
GO
ALTER DATABASE [BookingTrain] SET  READ_WRITE 
GO