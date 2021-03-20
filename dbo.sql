/*
 Navicat Premium Data Transfer

 Source Server         : SqlServer
 Source Server Type    : SQL Server
 Source Server Version : 12002000
 Source Host           : .:1433
 Source Catalog        : RestaurantAutomation
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 12002000
 File Encoding         : 65001

 Date: 20/03/2021 14:31:59
*/


-- ----------------------------
-- Table structure for Dish
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Dish]') AND type IN ('U'))
	DROP TABLE [dbo].[Dish]
GO

CREATE TABLE [dbo].[Dish] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [MenuItemId] int  NULL,
  [OrderId] int  NULL,
  [Count] int  NULL,
  [Status] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CompletedTime] datetime  NULL,
  [OrderedTime] datetime  NULL,
  [FinishedTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Dish] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Dish
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Dish] ON
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'2', N'2', N'1', N'2', N'Finished', N'2021-03-19 16:00:28.260', N'2021-03-19 16:00:15.410', NULL)
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'3', N'2', N'2', N'213', N'Finished', N'2021-03-19 16:33:26.873', N'2021-03-19 16:33:09.140', NULL)
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'4', N'2', N'2', N'12', N'Finished', N'2021-03-19 16:33:25.037', N'2021-03-19 16:33:14.260', NULL)
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'5', N'2', N'7', N'2', N'Finished', N'2021-03-20 13:56:30.940', N'2021-03-20 13:56:28.357', N'2021-03-20 13:56:31.987')
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'6', N'2', N'3', N'2', N'Ordered', NULL, N'2021-03-20 13:57:17.850', NULL)
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'7', N'4', N'3', N'1', N'Ordered', NULL, N'2021-03-20 13:57:25.553', NULL)
GO

INSERT INTO [dbo].[Dish] ([Id], [MenuItemId], [OrderId], [Count], [Status], [CompletedTime], [OrderedTime], [FinishedTime]) VALUES (N'8', N'3', N'3', N'3', N'Ordered', NULL, N'2021-03-20 13:57:30.233', NULL)
GO

SET IDENTITY_INSERT [dbo].[Dish] OFF
GO


-- ----------------------------
-- Table structure for Menuitem
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Menuitem]') AND type IN ('U'))
	DROP TABLE [dbo].[Menuitem]
GO

CREATE TABLE [dbo].[Menuitem] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [price] money  NULL
)
GO

ALTER TABLE [dbo].[Menuitem] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Menuitem
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Menuitem] ON
GO

INSERT INTO [dbo].[Menuitem] ([id], [name], [price]) VALUES (N'2', N'Hamburg', N'1.2000')
GO

INSERT INTO [dbo].[Menuitem] ([id], [name], [price]) VALUES (N'3', N'French fries', N'.6000')
GO

INSERT INTO [dbo].[Menuitem] ([id], [name], [price]) VALUES (N'4', N'Steak', N'5.8000')
GO

INSERT INTO [dbo].[Menuitem] ([id], [name], [price]) VALUES (N'5', N'Salad', N'3.4000')
GO

SET IDENTITY_INSERT [dbo].[Menuitem] OFF
GO


-- ----------------------------
-- Table structure for Order
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type IN ('U'))
	DROP TABLE [dbo].[Order]
GO

CREATE TABLE [dbo].[Order] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Status] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [TableNum] varchar(20) COLLATE Chinese_PRC_CI_AS  NULL,
  [OrderedTime] datetime  NULL,
  [FinishedTime] datetime  NULL
)
GO

ALTER TABLE [dbo].[Order] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Order
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Order] ON
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'1', N'Completed', N'01', N'2021-03-19 14:49:23.607', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'2', N'Completed', N'01', N'2021-03-19 14:51:54.190', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'3', N'Ordered', N'01', N'2021-03-19 16:42:44.033', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'4', N'Ordered', N'01', N'2021-03-19 16:42:50.707', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'5', N'Ordered', N'01', N'2021-03-19 16:42:53.003', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'6', N'Ordered', N'01', N'2021-03-19 16:42:56.753', NULL)
GO

INSERT INTO [dbo].[Order] ([Id], [Status], [TableNum], [OrderedTime], [FinishedTime]) VALUES (N'7', N'Completed', N'05', N'2021-03-20 13:56:25.220', N'2021-03-20 13:56:34.530')
GO

SET IDENTITY_INSERT [dbo].[Order] OFF
GO


-- ----------------------------
-- Table structure for Table
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Table]') AND type IN ('U'))
	DROP TABLE [dbo].[Table]
GO

CREATE TABLE [dbo].[Table] (
  [Id] int  NOT NULL,
  [Num] varchar(20) COLLATE Chinese_PRC_CI_AS  NULL,
  [Status] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Table] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Table
-- ----------------------------
INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'1', N'01', N'Occupied')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'2', N'02', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'3', N'03', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'4', N'04', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'5', N'05', N'Dirty')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'6', N'06', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'7', N'07', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'8', N'08', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'9', N'09', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'10', N'10', N'Clean')
GO

INSERT INTO [dbo].[Table] ([Id], [Num], [Status]) VALUES (N'11', N'11', N'Clean')
GO


-- ----------------------------
-- Table structure for User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type IN ('U'))
	DROP TABLE [dbo].[User]
GO

CREATE TABLE [dbo].[User] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [username] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [password] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [role] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[User] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of User
-- ----------------------------
SET IDENTITY_INSERT [dbo].[User] ON
GO

INSERT INTO [dbo].[User] ([id], [username], [password], [role]) VALUES (N'1', N'admin', N'admin', N'M')
GO

SET IDENTITY_INSERT [dbo].[User] OFF
GO


-- ----------------------------
-- Auto increment value for Dish
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Dish]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table Dish
-- ----------------------------
ALTER TABLE [dbo].[Dish] ADD CONSTRAINT [PK__Dish__3214EC07257D6C2D] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Menuitem
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Menuitem]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table Menuitem
-- ----------------------------
ALTER TABLE [dbo].[Menuitem] ADD CONSTRAINT [PK__MenuItem__3213E83F50B67710] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Order
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Order]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table Order
-- ----------------------------
ALTER TABLE [dbo].[Order] ADD CONSTRAINT [PK__Order__3214EC07201885CE] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Table
-- ----------------------------
ALTER TABLE [dbo].[Table] ADD CONSTRAINT [PK__Table__3214EC07CFE829C1] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for User
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[User]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK__User__3213E83FBAFE7B60] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

