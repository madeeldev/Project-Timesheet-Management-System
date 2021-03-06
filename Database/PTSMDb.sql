USE [PTMSDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/6/2019 11:59:50 AM ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChangeProjectRequests]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChangeProjectRequests](
	[ChangeProjectRequestId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NULL,
	[ProjectId] [int] NOT NULL,
	[IndividualId] [nvarchar](450) NULL,
 CONSTRAINT [PK_ChangeProjectRequests] PRIMARY KEY CLUSTERED 
(
	[ChangeProjectRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectAssignment]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAssignment](
	[ProjectAssignmentId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NULL,
	[ProjectId] [int] NOT NULL,
	[EmployeeId] [nvarchar](450) NULL,
 CONSTRAINT [PK_ProjectAssignment] PRIMARY KEY CLUSTERED 
(
	[ProjectAssignmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[WorkspaceId] [int] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](max) NULL,
	[WorkspaceId] [int] NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSheets]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSheets](
	[TimeSheetId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Task] [nvarchar](max) NULL,
	[TaskType] [nvarchar](max) NULL,
	[HoursSpent] [int] NOT NULL,
	[EmployeeId] [nvarchar](450) NULL,
	[ProjectId] [int] NOT NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_TimeSheets] PRIMARY KEY CLUSTERED 
(
	[TimeSheetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeekSettings]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeekSettings](
	[WeekSettingId] [int] IDENTITY(1,1) NOT NULL,
	[StartDay] [nvarchar](max) NULL,
	[EndDay] [nvarchar](max) NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[WorkspaceId] [int] NOT NULL,
 CONSTRAINT [PK_WeekSettings] PRIMARY KEY CLUSTERED 
(
	[WeekSettingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workspaces]    Script Date: 8/6/2019 11:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workspaces](
	[WorkspaceId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[PmId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Workspaces] PRIMARY KEY CLUSTERED 
(
	[WorkspaceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190709061403_Initial', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190709070540_ApplicationUser', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190709070903_ApplicationUser', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190710162052_AddWorkspaceModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190710181628_AddProjectModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190711080317_AddProjectAssignmentModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190712054619_AddTaskModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190712080102_AddWeekSettingModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713105659_AddTimesheetModel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713131933_AddEndDateToWeekSettings', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713135801_AddProjectToTimesheet', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713140653_check', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713141433_clearJunk', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713141619_AddTimesheetUpdated', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190715051227_DeleteEndDateFromWeekSetting', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190715062856_AddStatusToTimesheet', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190722185535_AddChangeProjectRequestToDb', N'2.2.6-servicing-10079')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Project Manager', N'PROJECT MANAGER', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Individual', N'INDIVIDUAL', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a02d9d0-e18a-4f75-a66f-d34d28942a01', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'39702070-d241-4456-a25f-048db660a359', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3daf5de1-2e57-4a4a-879e-3a91cf1df056', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'49585b04-d9e3-4b70-979b-a767475ecd06', N'3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'55a15351-6b04-47af-9250-1153b9b7cfba', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'61f45f82-28fa-482e-a379-596b67931f27', N'3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'81d89882-0359-4f75-b9df-71a3e0cd89d7', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83c15442-104e-454a-84e6-f8d08f3dfeb4', N'3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf8a3044-b2ce-4a47-afac-e8af96f2fade', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dbc8ffa5-d070-403b-9ace-842cebe68730', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e370300e-7125-446f-9f67-ceab7819c99a', N'3')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'0a02d9d0-e18a-4f75-a66f-d34d28942a01', N'adeel@gmail.com', N'ADEEL@GMAIL.COM', N'adeel@gmail.com', N'ADEEL@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKzOPBHvcNFSrArXLkkcX+q7iZabnLXD9B0FkFSPbsvY6hmm9fBgveD0sChza1K2UA==', N'FZ3LXFL6GXZGLTWWDC7BCM7JV76O4EWA', N'62d54c9e-ef2c-4ecb-abcc-90314e679483', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'rana', N'adeel')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'39702070-d241-4456-a25f-048db660a359', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMFMMZ4O9rAckzai9s6kWRN0f+mZGbGcpFGXNFbFmpnlnJxcoP8vqbienYdtc05/aQ==', N'FOJBFYFYSD6VLN3HXE3VUJJLZVSJQYP7', N'8a91b17f-0664-448d-b835-5cb78ef43cb6', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'admin', N'admin')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'3daf5de1-2e57-4a4a-879e-3a91cf1df056', N'user1@gmail.com', N'USER1@GMAIL.COM', N'user1@gmail.com', N'USER1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMLPwC9voBiAOH6rsd5edrebVjyAYWnRdSlodxlNijFy3Q5RMpaM9kd/wdoiPWiGCA==', N'CVTS2OQKMOZ3L2FD342F67ZKQYA3XDSE', N'82a5165a-c1e3-44b1-96b7-bf1b9a52ba76', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'firstnameuser1', N'lastnameuser1')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'49585b04-d9e3-4b70-979b-a767475ecd06', N'hamza@gmail.com', N'HAMZA@GMAIL.COM', N'hamza@gmail.com', N'HAMZA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBVb6FI4etGjCx3Lrg4Bs1U+l8nhbAAMc3ofIVAS6BMWTZnj02of3fpQt0+AwOyaJA==', N'OGAVVOUJNZCRMIU6THYQJS4RCNFN3WWP', N'4ecba025-ddad-4995-b0ad-d28040e01cbf', NULL, 0, 0, NULL, 1, 3, N'ApplicationUser', N'Hamza', N'Arshad')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'55a15351-6b04-47af-9250-1153b9b7cfba', N'aqib@gmail.com', N'AQIB@GMAIL.COM', N'aqib@gmail.com', N'AQIB@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAbyKoYOH+VxvPT6lUmxAn73kT1f7zR7pJyKBx8IUATYVODOXvCdw4P1dtoZMTBuLg==', N'IQCCOMGQ25QCJHWQOH7JELX4RU33QGRX', N'5c41f903-a23e-475d-9ade-8840da435165', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Aqib', N'Iqhlaq')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'61f45f82-28fa-482e-a379-596b67931f27', N'user2@gmail.com', N'USER2@GMAIL.COM', N'user2@gmail.com', N'USER2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENda7Ko8vsFuhY3TmxopiH1OgiV7BsplTCedGHk3m5Vli0AQFDh46nnOo/hAlMYfGg==', N'YUBCFDUEFDI5C2JAA7P2S4DSX7CLBZPB', N'56cacaee-424c-4a5f-bcca-eeaa75c9bcad', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'user2firstname', N'user2lastname')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'81d89882-0359-4f75-b9df-71a3e0cd89d7', N'azhar@gmail.com', N'AZHAR@GMAIL.COM', N'azhar@gmail.com', N'AZHAR@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEyVGTVVUX0GByDKqMgPVTgAhkYMRswBLg59tzj8/hLfuitG5uT8RdKrSk+Uc+UBXQ==', N'OQ375RKISNXU5TM372BC6ZMXCVUKC5KK', N'a7c7597f-8133-47e7-be77-2adda3765431', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'azhar', N'ali')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'83c15442-104e-454a-84e6-f8d08f3dfeb4', N'nabeel@gmail.com', N'NABEEL@GMAIL.COM', N'nabeel@gmail.com', N'NABEEL@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECErnR8ftZhC7zMSu+iTwHT9Sgl5ePVozXktlgkzG0ySuT1WtEWXaKrxMnHBOrNynQ==', N'V4YTQM2XCSIESQBMJV367KDUCAYC2BK7', N'b2b9030d-104c-44b6-a013-b53ed1d4ce30', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Nabeel', N'Sajid')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'bf8a3044-b2ce-4a47-afac-e8af96f2fade', N'usama@gmail.com', N'USAMA@GMAIL.COM', N'usama@gmail.com', N'USAMA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIVXFymp+Rp/Eb7XgXuljQyW4yq3SnX7eLxKgDLxRamOrfWaZA4a9+J8KUsqorbmEA==', N'N5B44NPIMUSV56J5RCN3L2USRWI2Q5T6', N'e1434ad9-495c-4931-9113-66f392748d02', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'usama', N'baig')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'dbc8ffa5-d070-403b-9ace-842cebe68730', N'saniya@gmail.com', N'SANIYA@GMAIL.COM', N'saniya@gmail.com', N'SANIYA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGcSSjasibD4gAL8LpammqyBtTuqvEax/6QOzIEnLm2My0zbZao3PVL+pyko+C74Uw==', N'KJHVQRC3JLPJMFBVBDPCC27ZZTAF422A', N'b8ed541f-a602-48a3-ac3c-2bf60a82f8a4', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'saniya', N'majeed')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'e370300e-7125-446f-9f67-ceab7819c99a', N'individual2@gmail.com', N'INDIVIDUAL2@GMAIL.COM', N'individual2@gmail.com', N'INDIVIDUAL2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELDwNtELCtcfn19JGVANEfqmGi/+BMfKHZlooZomSmZodzynrRtX2fmbbQROJIvqvQ==', N'RUXJRKHC7HA6YS6YX5TLVB7XIS2N4JLY', N'393b9489-6960-49cd-8922-07ccf9366769', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'individual2', N'second')
SET IDENTITY_INSERT [dbo].[ChangeProjectRequests] ON 

INSERT [dbo].[ChangeProjectRequests] ([ChangeProjectRequestId], [Status], [ProjectId], [IndividualId]) VALUES (2, N'Accepted', 10, N'83c15442-104e-454a-84e6-f8d08f3dfeb4')
SET IDENTITY_INSERT [dbo].[ChangeProjectRequests] OFF
SET IDENTITY_INSERT [dbo].[ProjectAssignment] ON 

INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (8, N'Accepted', 11, N'83c15442-104e-454a-84e6-f8d08f3dfeb4')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (9, N'Pending', 11, N'49585b04-d9e3-4b70-979b-a767475ecd06')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (10, N'Pending', 11, N'bf8a3044-b2ce-4a47-afac-e8af96f2fade')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (11, N'Accepted', 10, N'83c15442-104e-454a-84e6-f8d08f3dfeb4')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (13, N'Accepted', 12, N'83c15442-104e-454a-84e6-f8d08f3dfeb4')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (14, N'Accepted', 13, N'61f45f82-28fa-482e-a379-596b67931f27')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (15, N'Accepted', 12, N'61f45f82-28fa-482e-a379-596b67931f27')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (16, N'Accepted', 10, N'61f45f82-28fa-482e-a379-596b67931f27')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (18, N'Accepted', 14, N'83c15442-104e-454a-84e6-f8d08f3dfeb4')
INSERT [dbo].[ProjectAssignment] ([ProjectAssignmentId], [Status], [ProjectId], [EmployeeId]) VALUES (19, N'Accepted', 14, N'61f45f82-28fa-482e-a379-596b67931f27')
SET IDENTITY_INSERT [dbo].[ProjectAssignment] OFF
SET IDENTITY_INSERT [dbo].[Projects] ON 

INSERT [dbo].[Projects] ([ProjectId], [Name], [Description], [DateCreated], [WorkspaceId]) VALUES (10, N'Learn ASP.Net Core', N'Learn ASP.Net Core MVC and Web Api', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), 8)
INSERT [dbo].[Projects] ([ProjectId], [Name], [Description], [DateCreated], [WorkspaceId]) VALUES (11, N'Front End', N'FYP Front End', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), 12)
INSERT [dbo].[Projects] ([ProjectId], [Name], [Description], [DateCreated], [WorkspaceId]) VALUES (12, N'user1 project 1', N'user1 project 1', CAST(N'2019-07-29T00:00:00.0000000' AS DateTime2), 14)
INSERT [dbo].[Projects] ([ProjectId], [Name], [Description], [DateCreated], [WorkspaceId]) VALUES (13, N'user1 project 2', N'user1 project 2', CAST(N'2019-07-29T00:00:00.0000000' AS DateTime2), 14)
INSERT [dbo].[Projects] ([ProjectId], [Name], [Description], [DateCreated], [WorkspaceId]) VALUES (14, N'HRMS', N'Human resource management', CAST(N'2019-07-31T00:00:00.0000000' AS DateTime2), 8)
SET IDENTITY_INSERT [dbo].[Projects] OFF
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (9, N'Task 1', 12)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (10, N'Task 2', 12)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (13, N'Meeting', 14)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (14, N'Development', 14)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (15, N'Learning', 14)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (16, N'Development', 8)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (17, N'Learning', 8)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (18, N'Meeting', 8)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (19, N'Documentation', 8)
INSERT [dbo].[Tasks] ([TaskId], [TaskName], [WorkspaceId]) VALUES (20, N'Marketing', 8)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
SET IDENTITY_INSERT [dbo].[TimeSheets] ON 

INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (7, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'Task 1', 3, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 11, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (8, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'Task 1', 3, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 11, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (9, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'asd', N'Task 1', 1, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 11, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (10, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'Task 1', 3, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 11, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (11, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'Task 1', 5, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 11, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (14, CAST(N'2019-07-29T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'user1 task 1', 6, N'61f45f82-28fa-482e-a379-596b67931f27', 13, N'Submitted')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (15, CAST(N'2019-07-30T00:00:00.0000000' AS DateTime2), N'Task 1', N'Meeting', 2, N'61f45f82-28fa-482e-a379-596b67931f27', 13, N'Saved')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (16, CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'Task 2', N'Development', 4, N'61f45f82-28fa-482e-a379-596b67931f27', 13, N'Saved')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (17, CAST(N'2019-07-30T00:00:00.0000000' AS DateTime2), N'Create A Service and Apply Rolebased Authorization', N'Development', 5, N'61f45f82-28fa-482e-a379-596b67931f27', 14, N'Accepetd')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (18, CAST(N'2019-07-31T00:00:00.0000000' AS DateTime2), N'Create an API Service and check it throught Postman', N'Development', 4, N'61f45f82-28fa-482e-a379-596b67931f27', 14, N'Accepetd')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (19, CAST(N'2019-07-30T00:00:00.0000000' AS DateTime2), N'Create an API Service and check it throught Postman', N'Development', 6, N'61f45f82-28fa-482e-a379-596b67931f27', 10, N'Accepetd')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (20, CAST(N'2019-07-30T00:00:00.0000000' AS DateTime2), N'Policy Based Autorization', N'Development', 4, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 10, N'Accepetd')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (21, CAST(N'2019-07-31T00:00:00.0000000' AS DateTime2), N'asd', N'Documentation', 5, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 10, N'Accepetd')
INSERT [dbo].[TimeSheets] ([TimeSheetId], [Date], [Task], [TaskType], [HoursSpent], [EmployeeId], [ProjectId], [Status]) VALUES (22, CAST(N'2019-07-30T00:00:00.0000000' AS DateTime2), N'Task 1', N'Learning', 4, N'83c15442-104e-454a-84e6-f8d08f3dfeb4', 14, N'Accepetd')
SET IDENTITY_INSERT [dbo].[TimeSheets] OFF
SET IDENTITY_INSERT [dbo].[WeekSettings] ON 

INSERT [dbo].[WeekSettings] ([WeekSettingId], [StartDay], [EndDay], [StartDate], [WorkspaceId]) VALUES (8, N'Wednesday', N'Wednesday', CAST(N'2019-07-31T00:00:00.0000000' AS DateTime2), 8)
INSERT [dbo].[WeekSettings] ([WeekSettingId], [StartDay], [EndDay], [StartDate], [WorkspaceId]) VALUES (10, N'Monday', N'Tuesday', CAST(N'2019-07-23T01:00:00.0000000' AS DateTime2), 12)
INSERT [dbo].[WeekSettings] ([WeekSettingId], [StartDay], [EndDay], [StartDate], [WorkspaceId]) VALUES (12, N'Monday', N'Monday', CAST(N'2019-07-29T01:00:00.0000000' AS DateTime2), 14)
SET IDENTITY_INSERT [dbo].[WeekSettings] OFF
SET IDENTITY_INSERT [dbo].[Workspaces] ON 

INSERT [dbo].[Workspaces] ([WorkspaceId], [Name], [DateCreated], [PmId]) VALUES (8, N'PTMS', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'81d89882-0359-4f75-b9df-71a3e0cd89d7')
INSERT [dbo].[Workspaces] ([WorkspaceId], [Name], [DateCreated], [PmId]) VALUES (11, N'Adeel''sWorkspace', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'0a02d9d0-e18a-4f75-a66f-d34d28942a01')
INSERT [dbo].[Workspaces] ([WorkspaceId], [Name], [DateCreated], [PmId]) VALUES (12, N'FYP 2016', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'55a15351-6b04-47af-9250-1153b9b7cfba')
INSERT [dbo].[Workspaces] ([WorkspaceId], [Name], [DateCreated], [PmId]) VALUES (13, N'Daily Timesheet', CAST(N'2019-07-23T00:00:00.0000000' AS DateTime2), N'dbc8ffa5-d070-403b-9ace-842cebe68730')
INSERT [dbo].[Workspaces] ([WorkspaceId], [Name], [DateCreated], [PmId]) VALUES (14, N'user1 workspace', CAST(N'2019-07-29T00:00:00.0000000' AS DateTime2), N'3daf5de1-2e57-4a4a-879e-3a91cf1df056')
SET IDENTITY_INSERT [dbo].[Workspaces] OFF
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ChangeProjectRequests]  WITH CHECK ADD  CONSTRAINT [FK_ChangeProjectRequests_AspNetUsers_IndividualId] FOREIGN KEY([IndividualId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ChangeProjectRequests] CHECK CONSTRAINT [FK_ChangeProjectRequests_AspNetUsers_IndividualId]
GO
ALTER TABLE [dbo].[ChangeProjectRequests]  WITH CHECK ADD  CONSTRAINT [FK_ChangeProjectRequests_Projects_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChangeProjectRequests] CHECK CONSTRAINT [FK_ChangeProjectRequests_Projects_ProjectId]
GO
ALTER TABLE [dbo].[ProjectAssignment]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignment_AspNetUsers_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ProjectAssignment] CHECK CONSTRAINT [FK_ProjectAssignment_AspNetUsers_EmployeeId]
GO
ALTER TABLE [dbo].[ProjectAssignment]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignment_Projects_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectAssignment] CHECK CONSTRAINT [FK_ProjectAssignment_Projects_ProjectId]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Workspaces_WorkspaceId] FOREIGN KEY([WorkspaceId])
REFERENCES [dbo].[Workspaces] ([WorkspaceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Workspaces_WorkspaceId]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Workspaces_WorkspaceId] FOREIGN KEY([WorkspaceId])
REFERENCES [dbo].[Workspaces] ([WorkspaceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Workspaces_WorkspaceId]
GO
ALTER TABLE [dbo].[TimeSheets]  WITH CHECK ADD  CONSTRAINT [FK_TimeSheets_AspNetUsers_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[TimeSheets] CHECK CONSTRAINT [FK_TimeSheets_AspNetUsers_EmployeeId]
GO
ALTER TABLE [dbo].[TimeSheets]  WITH CHECK ADD  CONSTRAINT [FK_TimeSheets_Projects_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TimeSheets] CHECK CONSTRAINT [FK_TimeSheets_Projects_ProjectId]
GO
ALTER TABLE [dbo].[WeekSettings]  WITH CHECK ADD  CONSTRAINT [FK_WeekSettings_Workspaces_WorkspaceId] FOREIGN KEY([WorkspaceId])
REFERENCES [dbo].[Workspaces] ([WorkspaceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WeekSettings] CHECK CONSTRAINT [FK_WeekSettings_Workspaces_WorkspaceId]
GO
ALTER TABLE [dbo].[Workspaces]  WITH CHECK ADD  CONSTRAINT [FK_Workspaces_AspNetUsers_PmId] FOREIGN KEY([PmId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Workspaces] CHECK CONSTRAINT [FK_Workspaces_AspNetUsers_PmId]
GO
