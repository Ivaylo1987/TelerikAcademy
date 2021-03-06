USE [master]
GO
/****** Object:  Database [Locations]    Script Date: 8/21/2014 9:38:34 PM ******/
CREATE DATABASE [Locations]
GO
ALTER DATABASE [Locations] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Locations].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Locations] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Locations] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Locations] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Locations] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Locations] SET ARITHABORT OFF 
GO
ALTER DATABASE [Locations] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Locations] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Locations] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Locations] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Locations] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Locations] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Locations] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Locations] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Locations] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Locations] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Locations] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Locations] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Locations] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Locations] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Locations] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Locations] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Locations] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Locations] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Locations] SET  MULTI_USER 
GO
ALTER DATABASE [Locations] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Locations] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Locations] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Locations] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Locations] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Locations]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 8/21/2014 9:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 8/21/2014 9:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 8/21/2014 9:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinetId] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 8/21/2014 9:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 8/21/2014 9:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressId], [Name], [TownId]) VALUES (1, N'Mladost 1, Alexander Malinov 17 str.', 1)
INSERT [dbo].[Addresses] ([AddressId], [Name], [TownId]) VALUES (2, N'Berlin strasse 7', 2)
INSERT [dbo].[Addresses] ([AddressId], [Name], [TownId]) VALUES (3, N'Jung-gu Taepyeong-no 1-ga 24-2 beonji
Hana Apateu 104-dong 915-ho
Bak Minho Seonsaeng-nim', 3)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (3, N'North America')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (4, N'South America')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (5, N'Asia')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (6, N'Australia')
INSERT [dbo].[Continents] ([ContinentId], [Name]) VALUES (7, N'Antarctica')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (2, N'Germany', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (3, N'USA', 3)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (4, N'Chile', 4)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (5, N'South Korea', 5)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (6, N'China', 5)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (7, N'Australia', 6)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (2, N'Pesho', N'Goshev', 1)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (3, N'Franz', N'Muller', 2)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (4, N'Joy', N'Si', 3)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (2, N'Berlin', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (3, N'Seoul', 5)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (4, N'Washington', 3)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([TownId])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinetId])
REFERENCES [dbo].[Continents] ([ContinentId])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([AddressId])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [Locations] SET  READ_WRITE 
GO
