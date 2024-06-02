create database [Pw3-2c-IslaTesoro]
go
USE [Pw3-2c-IslaTesoro]
GO

/****** Object:  Table [dbo].[Ubicacion]    Script Date: 2/6/2024 00:11:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ubicacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO


