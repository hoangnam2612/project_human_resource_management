create database [HumanResourceManagement]

USE [HumanResourceManagement]

GO

/****** Object:  Table [dbo].[User]    Script Date: 3/7/2024 2:27:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Username] [nvarchar](50) primary key NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleId] [int] NOT NULL
)

/****** Object:  Table [dbo].[Position]    Script Date: 3/7/2024 2:26:02 PM ******/


CREATE TABLE [dbo].[Position](
	[PositionId] [int] IDENTITY(1,1) primary key NOT NULL,
	[PositionCode] [nvarchar](50) NOT NULL,
	[PositionName] [nvarchar](500) NOT NULL,
	[Note] [nvarchar](300) NULL
 )




CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) primary key NOT NULL,
	[DepartmentCode] [nvarchar](50) NOT NULL,
	[DepartmentName] [nvarchar](150) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](12) NULL,
	[Note] [nvarchar](300) NULL
 )






/****** Object:  Table [dbo].[Staff]    Script Date: 3/7/2024 2:26:49 PM ******/


CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) primary key NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[DOB] [date] NOT NULL,
	[Sex] [int] NOT NULL,
	[HomeTown] [nvarchar](300) NOT NULL,
	[IdCardNumber] [nvarchar](12) NOT NULL,
	[IssuanceDate] [date] NOT NULL,
	[PlaceOfIssuance] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](350) NULL,
	[PositionId] [int] NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[CreateDate] [date] NOT NULL,
	[Creater] [nvarchar](50) NOT NULL,
	[EditDate] [date] NOT NULL,
	[Editer] [nvarchar](50) NOT NULL
 )

