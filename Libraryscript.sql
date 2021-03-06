USE [master]
GO
/****** Object:  Database [DBLibrary]    Script Date: 25/08/2020 1:55:52 pm ******/
CREATE DATABASE [DBLibrary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBLibrary', FILENAME = N'C:\Users\Zahid Ali\DBLibrary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBLibrary_log', FILENAME = N'C:\Users\Zahid Ali\DBLibrary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DBLibrary] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBLibrary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBLibrary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBLibrary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBLibrary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBLibrary] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBLibrary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBLibrary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBLibrary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBLibrary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBLibrary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBLibrary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBLibrary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBLibrary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBLibrary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBLibrary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBLibrary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBLibrary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBLibrary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBLibrary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBLibrary] SET  MULTI_USER 
GO
ALTER DATABASE [DBLibrary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBLibrary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBLibrary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBLibrary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBLibrary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBLibrary] SET QUERY_STORE = OFF
GO
USE [DBLibrary]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DBLibrary]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[adminID] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auther]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auther](
	[authorID] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[authorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[fullname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[bookID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[description] [varchar](555) NOT NULL,
	[genre] [varchar](55) NOT NULL,
	[edition] [varchar](55) NOT NULL,
	[bookImage] [varchar](555) NOT NULL,
	[price] [varchar](155) NOT NULL,
	[totalStock] [varchar](155) NOT NULL,
	[currentStock] [varchar](155) NOT NULL,
	[authorID] [int] NOT NULL,
	[publisherID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[memberID] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[fullname] [varchar](255) NOT NULL,
	[mobileNumber] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[IDCardNumber] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[IDCardNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[memberAddress]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberAddress](
	[memberID] [int] NOT NULL,
	[streetAddress] [varchar](255) NOT NULL,
	[city] [varchar](155) NOT NULL,
	[state] [varchar](155) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[memberbookissue]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberbookissue](
	[memberID] [int] NOT NULL,
	[bookID] [int] NOT NULL,
	[issueDate] [Date] NOT NULL,
	[dueDate] [Date] NOT NULL,
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publisher]    Script Date: 25/08/2020 1:55:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publisher](
	[publisherID] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[publisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[fullname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD FOREIGN KEY([authorID])
REFERENCES [dbo].[auther] ([authorID])
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD FOREIGN KEY([publisherID])
REFERENCES [dbo].[publisher] ([publisherID])
GO
ALTER TABLE [dbo].[memberAddress]  WITH CHECK ADD FOREIGN KEY([memberID])
REFERENCES [dbo].[member] ([memberID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[memberbookissue]  WITH CHECK ADD FOREIGN KEY([bookID])
REFERENCES [dbo].[book] ([bookID])
GO
ALTER TABLE [dbo].[memberbookissue]  WITH CHECK ADD FOREIGN KEY([memberID])
REFERENCES [dbo].[member] ([memberID])
GO
USE [master]
GO
ALTER DATABASE [DBLibrary] SET  READ_WRITE 
GO
