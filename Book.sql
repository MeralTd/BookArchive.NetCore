USE [BookDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13.11.2020 22:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 13.11.2020 22:14:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[PageCount] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Name], [Author], [PageCount]) VALUES (1, N'Dans Dans Dans', N'Haruki Murakami', 520)
INSERT [dbo].[Books] ([Id], [Name], [Author], [PageCount]) VALUES (2, N'Şeker Portakalı', N'Jose Mauro De Vasconcelos', 186)
INSERT [dbo].[Books] ([Id], [Name], [Author], [PageCount]) VALUES (3, N'Fareler ve İnsanlar', N'John Steinbeck', 111)
INSERT [dbo].[Books] ([Id], [Name], [Author], [PageCount]) VALUES (4, N'The Little Prince', N'Antoine De Saint Exupery', 120)
INSERT [dbo].[Books] ([Id], [Name], [Author], [PageCount]) VALUES (6, N'Momo', N'Michael Ende', 304)
SET IDENTITY_INSERT [dbo].[Books] OFF
