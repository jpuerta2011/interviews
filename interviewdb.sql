/*
Navicat SQL Server Data Transfer

Source Server         : SQLServerLocal
Source Server Version : 140000
Source Host           : DESKTOP-UN7E7G8\SQLEXPRESS:1433
Source Database       : interviewdb
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2020-03-09 01:02:58
*/


-- ----------------------------
-- Table structure for Applicants
-- ----------------------------
DROP TABLE [dbo].[Applicants]
GO
CREATE TABLE [dbo].[Applicants] (
[ApplicantId] int NOT NULL ,
[Name] varchar(200) NOT NULL ,
[Email] varchar(50) NOT NULL ,
[Street] varchar(50) NOT NULL ,
[Suite] varchar(50) NOT NULL ,
[City] varchar(80) NOT NULL ,
[ZipCode] varchar(20) NOT NULL ,
[Lat] float(53) NOT NULL ,
[Lon] float(53) NOT NULL 
)


GO

-- ----------------------------
-- Records of Applicants
-- ----------------------------
INSERT INTO [dbo].[Applicants] ([ApplicantId], [Name], [Email], [Street], [Suite], [City], [ZipCode], [Lat], [Lon]) VALUES (N'1', N'Leanne Graham', N'Sincere@april.biz', N'Kulas Light', N'Apt. 556', N'Gwenborough', N'92998-3874', N'-37.3159', N'81.1496')
GO
GO

-- ----------------------------
-- Table structure for Interviews
-- ----------------------------
DROP TABLE [dbo].[Interviews]
GO
CREATE TABLE [dbo].[Interviews] (
[InterviewId] bigint NOT NULL IDENTITY(1,1) ,
[RecruiterProcessId] bigint NOT NULL ,
[ApplicantId] int NOT NULL ,
[Date] datetime NOT NULL ,
[InterviewTypeId] bigint NOT NULL ,
[State] bit NOT NULL DEFAULT ((1)) 
)


GO

-- ----------------------------
-- Records of Interviews
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Interviews] ON
GO
INSERT INTO [dbo].[Interviews] ([InterviewId], [RecruiterProcessId], [ApplicantId], [Date], [InterviewTypeId], [State]) VALUES (N'1', N'1', N'1', N'2020-03-09 22:38:00.000', N'1', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[Interviews] OFF
GO

-- ----------------------------
-- Table structure for InterviewTypes
-- ----------------------------
DROP TABLE [dbo].[InterviewTypes]
GO
CREATE TABLE [dbo].[InterviewTypes] (
[InterviewTypeId] bigint NOT NULL IDENTITY(1,1) ,
[Name] varchar(30) NOT NULL ,
[State] bit NOT NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[dbo].[InterviewTypes]', RESEED, 3)
GO

-- ----------------------------
-- Records of InterviewTypes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[InterviewTypes] ON
GO
INSERT INTO [dbo].[InterviewTypes] ([InterviewTypeId], [Name], [State]) VALUES (N'1', N'Presencial', N'1')
GO
GO
INSERT INTO [dbo].[InterviewTypes] ([InterviewTypeId], [Name], [State]) VALUES (N'2', N'Telefónica', N'1')
GO
GO
INSERT INTO [dbo].[InterviewTypes] ([InterviewTypeId], [Name], [State]) VALUES (N'3', N'Remota', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[InterviewTypes] OFF
GO

-- ----------------------------
-- Table structure for RecruiterProcesses
-- ----------------------------
DROP TABLE [dbo].[RecruiterProcesses]
GO
CREATE TABLE [dbo].[RecruiterProcesses] (
[RecruiterProcessId] bigint NOT NULL IDENTITY(1,1) ,
[UserId] bigint NOT NULL ,
[Description] varchar(500) NOT NULL ,
[State] bit NOT NULL DEFAULT ((1)) ,
[ParentTechnologyId] bigint NOT NULL 
)


GO

-- ----------------------------
-- Records of RecruiterProcesses
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RecruiterProcesses] ON
GO
INSERT INTO [dbo].[RecruiterProcesses] ([RecruiterProcessId], [UserId], [Description], [State], [ParentTechnologyId]) VALUES (N'1', N'1', N'Test prueba técnica', N'1', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[RecruiterProcesses] OFF
GO

-- ----------------------------
-- Table structure for RecruiterProcessTechnologies
-- ----------------------------
DROP TABLE [dbo].[RecruiterProcessTechnologies]
GO
CREATE TABLE [dbo].[RecruiterProcessTechnologies] (
[RecruiterProcessTechnologyId] bigint NOT NULL IDENTITY(1,1) ,
[TechnologyId] bigint NOT NULL ,
[RecruiterProcessId] bigint NOT NULL ,
[State] bit NOT NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[dbo].[RecruiterProcessTechnologies]', RESEED, 2)
GO

-- ----------------------------
-- Records of RecruiterProcessTechnologies
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RecruiterProcessTechnologies] ON
GO
INSERT INTO [dbo].[RecruiterProcessTechnologies] ([RecruiterProcessTechnologyId], [TechnologyId], [RecruiterProcessId], [State]) VALUES (N'1', N'3', N'1', N'1')
GO
GO
INSERT INTO [dbo].[RecruiterProcessTechnologies] ([RecruiterProcessTechnologyId], [TechnologyId], [RecruiterProcessId], [State]) VALUES (N'2', N'9', N'1', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[RecruiterProcessTechnologies] OFF
GO

-- ----------------------------
-- Table structure for Technologies
-- ----------------------------
DROP TABLE [dbo].[Technologies]
GO
CREATE TABLE [dbo].[Technologies] (
[TechnologyId] bigint NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(80) NOT NULL ,
[ParentTechnologyId] bigint NULL ,
[State] bit NOT NULL DEFAULT ((1)) ,
[Code] smallint NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Technologies]', RESEED, 12)
GO

-- ----------------------------
-- Records of Technologies
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Technologies] ON
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'1', N'Microsoft .Net', null, N'1', N'0')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'2', N'Oracle Java', null, N'1', N'0')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'3', N'Asp.Net', N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'4', N'Java Server Pages', N'2', N'1', N'1')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'5', N'MVVM', N'1', N'1', N'2')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'6', N'Java Server Faces', N'2', N'1', N'2')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'7', N'Ado.Net', N'1', N'1', N'3')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'8', N'Enterprise Java Beans', N'2', N'1', N'3')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'9', N'Entity FrameWork', N'1', N'1', N'4')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'10', N'Java Persistence Api', N'2', N'1', N'4')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'11', N'LinQ', N'1', N'1', N'5')
GO
GO
INSERT INTO [dbo].[Technologies] ([TechnologyId], [Name], [ParentTechnologyId], [State], [Code]) VALUES (N'12', N'Java Messaging Services', N'2', N'1', N'5')
GO
GO
SET IDENTITY_INSERT [dbo].[Technologies] OFF
GO

-- ----------------------------
-- Table structure for Users
-- ----------------------------
DROP TABLE [dbo].[Users]
GO
CREATE TABLE [dbo].[Users] (
[UserId] bigint NOT NULL IDENTITY(1,1) ,
[Name] varchar(200) NOT NULL ,
[UserName] varchar(10) NOT NULL ,
[Password] varchar(80) NOT NULL ,
[Role] varchar(15) NOT NULL 
)


GO

-- ----------------------------
-- Records of Users
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Users] ON
GO
INSERT INTO [dbo].[Users] ([UserId], [Name], [UserName], [Password], [Role]) VALUES (N'1', N'Juan Puerta', N'admin1', N'bRhb9PuyDayPVpaQZpI+1YxVdcUIJnvKSDBDv8eOXU93KjVbKQu4uUDEQWhbB6Pv', N'Recluiter')
GO
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO

-- ----------------------------
-- Indexes structure for table Applicants
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Applicants
-- ----------------------------
ALTER TABLE [dbo].[Applicants] ADD PRIMARY KEY ([ApplicantId])
GO

-- ----------------------------
-- Indexes structure for table Interviews
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Interviews
-- ----------------------------
ALTER TABLE [dbo].[Interviews] ADD PRIMARY KEY ([InterviewId])
GO

-- ----------------------------
-- Indexes structure for table InterviewTypes
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table InterviewTypes
-- ----------------------------
ALTER TABLE [dbo].[InterviewTypes] ADD PRIMARY KEY ([InterviewTypeId])
GO

-- ----------------------------
-- Indexes structure for table RecruiterProcesses
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RecruiterProcesses
-- ----------------------------
ALTER TABLE [dbo].[RecruiterProcesses] ADD PRIMARY KEY ([RecruiterProcessId])
GO

-- ----------------------------
-- Indexes structure for table RecruiterProcessTechnologies
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RecruiterProcessTechnologies
-- ----------------------------
ALTER TABLE [dbo].[RecruiterProcessTechnologies] ADD PRIMARY KEY ([RecruiterProcessTechnologyId])
GO

-- ----------------------------
-- Indexes structure for table Technologies
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Technologies
-- ----------------------------
ALTER TABLE [dbo].[Technologies] ADD PRIMARY KEY ([TechnologyId])
GO

-- ----------------------------
-- Indexes structure for table Users
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD PRIMARY KEY ([UserId])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Interviews]
-- ----------------------------
ALTER TABLE [dbo].[Interviews] ADD FOREIGN KEY ([ApplicantId]) REFERENCES [dbo].[Applicants] ([ApplicantId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[Interviews] ADD FOREIGN KEY ([InterviewTypeId]) REFERENCES [dbo].[InterviewTypes] ([InterviewTypeId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[Interviews] ADD FOREIGN KEY ([RecruiterProcessId]) REFERENCES [dbo].[RecruiterProcesses] ([RecruiterProcessId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RecruiterProcesses]
-- ----------------------------
ALTER TABLE [dbo].[RecruiterProcesses] ADD FOREIGN KEY ([ParentTechnologyId]) REFERENCES [dbo].[Technologies] ([TechnologyId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[RecruiterProcesses] ADD FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RecruiterProcessTechnologies]
-- ----------------------------
ALTER TABLE [dbo].[RecruiterProcessTechnologies] ADD FOREIGN KEY ([RecruiterProcessId]) REFERENCES [dbo].[RecruiterProcesses] ([RecruiterProcessId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[RecruiterProcessTechnologies] ADD FOREIGN KEY ([TechnologyId]) REFERENCES [dbo].[Technologies] ([TechnologyId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
