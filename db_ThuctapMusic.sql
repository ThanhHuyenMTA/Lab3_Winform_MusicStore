USE [master]
GO
/****** Object:  Database [Thuctap_Music]    Script Date: 3/20/2018 9:01:35 AM ******/
CREATE DATABASE [Thuctap_Music]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Thuctap_Music', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Thuctap_Music.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Thuctap_Music_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Thuctap_Music_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Thuctap_Music] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Thuctap_Music].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Thuctap_Music] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Thuctap_Music] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Thuctap_Music] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Thuctap_Music] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Thuctap_Music] SET ARITHABORT OFF 
GO
ALTER DATABASE [Thuctap_Music] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Thuctap_Music] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Thuctap_Music] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Thuctap_Music] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Thuctap_Music] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Thuctap_Music] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Thuctap_Music] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Thuctap_Music] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Thuctap_Music] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Thuctap_Music] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Thuctap_Music] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Thuctap_Music] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Thuctap_Music] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Thuctap_Music] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Thuctap_Music] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Thuctap_Music] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Thuctap_Music] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Thuctap_Music] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Thuctap_Music] SET  MULTI_USER 
GO
ALTER DATABASE [Thuctap_Music] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Thuctap_Music] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Thuctap_Music] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Thuctap_Music] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Thuctap_Music] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Thuctap_Music]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 3/20/2018 9:01:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[AlbumID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Price] [float] NOT NULL,
	[AlbumUrl] [text] NULL,
	[Genre_ID] [int] NOT NULL,
	[Artist_ID] [int] NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Artist]    Script Date: 3/20/2018 9:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[ArtistID] [int] IDENTITY(1,1) NOT NULL,
	[ArtistName] [nvarchar](150) NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[ArtistID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Genre]    Script Date: 3/20/2018 9:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nvarchar](150) NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdeDetal]    Script Date: 3/20/2018 9:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdeDetal](
	[OrderDetailIID] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [int] NOT NULL,
	[Album_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Total_OD] [float] NOT NULL,
 CONSTRAINT [PK_OrdeDetal] PRIMARY KEY CLUSTERED 
(
	[OrderDetailIID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/20/2018 9:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 3/20/2018 9:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [text] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Album] ON 

INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (303, N'Internal Auditor', 100, NULL, 10, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (304, N'Help Desk Technician', 155, NULL, 5, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (305, N'VP Quality Control', 200, NULL, 2, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (306, N'Chief Design Engineer', 118, NULL, 2, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (308, N'Information Systems Manager', 107, NULL, 1, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (309, N'Tax Accountant', 200, NULL, 10, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (310, N'Assistant Media Planner', 120, NULL, 10, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (311, N'Web Developer IV', 168, NULL, 1, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (312, N'Clinical Specialist', 169, NULL, 6, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (313, N'Social Worker', 52, NULL, 9, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (314, N'Safety Technician III', 200, NULL, 3, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (315, N'Developer III', 94, NULL, 2, 1)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (316, N'Programmer Analyst II', 132, NULL, 2, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (317, N'Senior Editor', 176, NULL, 7, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (318, N'Programmer I', 91, NULL, 3, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (319, N'Tax Accountant', 117, NULL, 7, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (320, N'Environmental Specialist', 99, NULL, 8, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (321, N'Database Administrator IV', 177, NULL, 1, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (322, N'Nuclear Power Engineer', 97, NULL, 3, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (323, N'Actuary', 171, NULL, 8, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (324, N'Administrative Assistant II', 73, NULL, 1, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (325, N'Human Resources Manager', 101, NULL, 8, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (326, N'Engineer II', 182, NULL, 9, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (327, N'Geologist IV', 61, NULL, 2, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (328, N'Financial Advisor', 167, NULL, 6, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (329, N'Statistician II', 180, NULL, 10, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (330, N'Community Outreach Specialist', 127, NULL, 9, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (331, N'Research Assistant III', 120, NULL, 1, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (332, N'Safety Technician IV', 142, NULL, 7, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (333, N'Recruiter', 57, NULL, 8, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (334, N'Data Coordiator', 162, NULL, 8, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (335, N'Civil Engineer', 95, NULL, 8, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (336, N'Software Engineer III', 179, NULL, 5, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (337, N'Speech Pathologist', 169, NULL, 7, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (338, N'Operator', 175, NULL, 8, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (339, N'Senior Editor', 161, NULL, 7, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (340, N'Occupational Therapist', 177, NULL, 7, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (341, N'Human Resources Assistant IV', 138, NULL, 10, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (342, N'Nurse', 68, NULL, 10, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (343, N'Editor', 139, NULL, 9, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (344, N'Research Associate', 150, NULL, 8, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (345, N'Environmental Specialist', 129, NULL, 10, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (346, N'Programmer II', 99, NULL, 8, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (347, N'Payment Adjustment Coordinator', 51, NULL, 1, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (348, N'Biostatistician III', 110, NULL, 1, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (349, N'Assistant Manager', 121, NULL, 8, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (350, N'Software Consultant', 131, NULL, 3, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (351, N'Junior Executive', 165, NULL, 4, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (352, N'Desktop Support Technician', 88, NULL, 10, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (353, N'Office Assistant I', 165, NULL, 5, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (354, N'Design Engineer', 128, NULL, 8, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (355, N'Legal Assistant', 148, NULL, 6, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (356, N'Professor', 169, NULL, 1, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (357, N'Legal Assistant', 163, NULL, 3, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (358, N'Legal Assistant', 89, NULL, 4, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (359, N'Physical Therapy Assistant', 120, NULL, 1, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (360, N'Software Consultant', 182, NULL, 4, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (361, N'Environmental Tech', 84, NULL, 7, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (362, N'Director of Sales', 155, NULL, 9, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (363, N'Physical Therapy Assistant', 64, NULL, 5, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (364, N'Quality Control Specialist', 142, NULL, 4, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (365, N'Engineer II', 190, NULL, 5, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (366, N'Librarian', 106, NULL, 3, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (367, N'Account Coordinator', 170, NULL, 8, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (368, N'Assistant Manager', 183, NULL, 4, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (369, N'Business Systems Development Analyst', 199, NULL, 5, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (370, N'Marketing Manager', 149, NULL, 3, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (371, N'Structural Analysis Engineer', 141, NULL, 8, 1)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (372, N'Automation Specialist IV', 147, NULL, 2, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (373, N'Project Manager', 57, NULL, 8, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (374, N'Actuary', 131, NULL, 6, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (375, N'Associate Professor', 142, NULL, 8, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (376, N'Financial Advisor', 122, NULL, 8, 1)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (377, N'Geologist II', 80, NULL, 9, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (378, N'Executive Secretary', 141, NULL, 6, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (379, N'Budget/Accounting Analyst IV', 122, NULL, 2, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (380, N'Administrative Officer', 100, NULL, 3, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (381, N'Human Resources Manager', 83, NULL, 6, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (382, N'Design Engineer', 50, NULL, 4, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (383, N'Occupational Therapist', 172, NULL, 9, 1)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (384, N'Food Chemist', 107, NULL, 9, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (385, N'Research Associate', 196, NULL, 1, 4)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (386, N'Database Administrator III', 101, NULL, 3, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (387, N'Health Coach IV', 160, NULL, 3, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (388, N'Director of Sales', 165, NULL, 10, 2)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (389, N'Physical Therapy Assistant', 105, NULL, 1, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (390, N'VP Marketing', 120, NULL, 4, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (391, N'Chemical Engineer', 114, NULL, 8, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (392, N'Web Developer IV', 125, NULL, 2, 8)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (393, N'Senior Editor', 83, NULL, 3, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (394, N'Assistant Manager', 145, NULL, 2, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (395, N'Librarian', 179, NULL, 9, 1)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (396, N'Human Resources Assistant III', 100, NULL, 4, 5)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (397, N'Registered Nurse', 195, NULL, 2, 7)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (398, N'Structural Engineer', 186, NULL, 4, 10)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (399, N'Automation Specialist IV', 74, NULL, 7, 6)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (400, N'Assistant Media Planner', 128, NULL, 5, 9)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (402, N'Edit (20/03)', 100, NULL, 6, 3)
INSERT [dbo].[Album] ([AlbumID], [Title], [Price], [AlbumUrl], [Genre_ID], [Artist_ID]) VALUES (403, N'Add (20/03)', 190, NULL, 3, 4)
GO
SET IDENTITY_INSERT [dbo].[Album] OFF
SET IDENTITY_INSERT [dbo].[Artist] ON 

INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (1, N'Codi Donavan')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (2, N'Ephrayim Curgenven')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (3, N'Elaine Siggins')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (4, N'Osmund Bartolomeu')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (5, N'Teri Levermore')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (6, N'Nate Schooley')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (7, N'Benton Spillard')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (8, N'Jewelle Turbayne')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (9, N'Thorsten Ellcock')
INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (10, N'Roldan Mallinar')
SET IDENTITY_INSERT [dbo].[Artist] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (1, N'Comedy1', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (2, N'Comedy2', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (3, N'Comedy', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (4, N'Action|Comedy|Crime', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (5, N'Documentary1', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (6, N'Comedy|Drama', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (7, N'Drama|Thriller', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (8, N'Western', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (9, N'Comedy|Fantasy', NULL)
INSERT [dbo].[Genre] ([GenreID], [GenreName], [Description]) VALUES (10, N'Documentary2', NULL)
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[OrdeDetal] ON 

INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (1, 1, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (2, 1, 4, 1, 55)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (3, 2, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (4, 2, 6, 1, 77)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (5, 3, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (6, 4, 3, 1, 22)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (7, 5, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (8, 6, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (9, 7, 3, 1, 22)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (10, 8, 1, 1, 100)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (11, 9, 1, 2, 200)
INSERT [dbo].[OrdeDetal] ([OrderDetailIID], [Order_ID], [Album_ID], [Quantity], [Total_OD]) VALUES (12, 9, 6, 1, 77)
SET IDENTITY_INSERT [dbo].[OrdeDetal] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (1, 1, CAST(N'2018-03-19 09:47:47.000' AS DateTime), 155)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (2, 2, CAST(N'2018-03-19 09:52:13.000' AS DateTime), 177)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (3, 3, CAST(N'2018-03-19 11:01:16.000' AS DateTime), 100)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (4, 4, CAST(N'2018-03-19 11:04:41.000' AS DateTime), 22)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (5, 5, CAST(N'2018-03-19 11:07:33.000' AS DateTime), 100)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (6, 6, CAST(N'2018-03-19 11:39:43.000' AS DateTime), 100)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (7, 7, CAST(N'2018-03-19 11:45:29.000' AS DateTime), 22)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (8, 8, CAST(N'2018-03-19 11:53:14.000' AS DateTime), 100)
INSERT [dbo].[Order] ([OrderID], [User_ID], [OrderDate], [Total]) VALUES (9, 9, CAST(N'2018-03-19 22:30:12.000' AS DateTime), 277)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (1, N'HỒNG', N'NHUNG', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'0983724443', N'hongnhung1234@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (2, N'MAI ', N'ANH', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'09585435', N'maianh123456@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (3, N'THANH', N'MAI', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'0978534324', N'thanhmai123456@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (4, N'THANH', N'HƯƠNG', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'098357243', N'thanhhuong345@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (5, N'HỒNG', N'HƯƠNG', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'090583676', N'honghuong567@gmial.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (6, N'TIỂU ', N'HI', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'09357432', N'tieuhi578@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (7, N'THANH', N'HẰNG', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'09453534', N'thanhhang456@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (8, N'NGỌC', N'MINH', N'HÀ NỘI', N'HÀ NỘI', N'', N'VIỆT NAM', N'09837584', N'ngocminh123456@gmail.com')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email]) VALUES (9, N'TRẦN ', N'NGỌC', N'HẢI DƯƠNG', N'HẢI DƯƠNG', N'', N'VIỆT NAM', N'09578232', N'tranngoc123467@gmail.com')
SET IDENTITY_INSERT [dbo].[User] OFF
USE [master]
GO
ALTER DATABASE [Thuctap_Music] SET  READ_WRITE 
GO
