GO
USE master;
GO
CREATE DATABASE [adminMoneyDB];
GO
USE [adminMoneyDB];
GO
CREATE TABLE [dbo].[tblUsers] 
(
	[Id]         INT			CONSTRAINT [PK_tblUsersId]    PRIMARY KEY IDENTITY (1, 1) NOT NULL,
	[Name]       NVARCHAR (50)	CONSTRAINT [UQ_tblUsersName]  UNIQUE NOT NULL,
	[Login]      NVARCHAR (50)  CONSTRAINT [UQ_tblUsersLogin] UNIQUE NOT NULL,
	[Password]   NVARCHAR (50)  NOT NULL,
	[Status]     NVARCHAR (10)  NOT NULL
);
GO
CREATE TABLE [dbo].[tblCategories]
(
    [Id]         INT            CONSTRAINT [PK_tblCategoriesId] PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [Users]      INT            CONSTRAINT [FK_tblCategoriesUsers_tblUsersId] FOREIGN KEY REFERENCES [tblUsers]([Id]) NOT NULL,
	[Categories] NVARCHAR (50)  NOT NULL,
    [Finances]   NVARCHAR (10)  NOT NULL,
    [Status]     NVARCHAR (10)  NOT NULL
);
GO
CREATE TABLE [dbo].[tblValues]
(
    [Id]          INT            CONSTRAINT [PK_tblValuesId] PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [Categories]  INT            CONSTRAINT [FK_tblValuesCategories_tblCategoriesId] FOREIGN KEY REFERENCES [tblCategories]([Id]) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
	[Values]      MONEY          CONSTRAINT [DF_tblValuesValor]DEFAULT (0.00) NOT NULL,
    [Date]        DATE           NOT NULL,
    [Type]        CHAR (1)       NOT NULL,
	[Status]      NVARCHAR (10)  NOT NULL
);
GO
