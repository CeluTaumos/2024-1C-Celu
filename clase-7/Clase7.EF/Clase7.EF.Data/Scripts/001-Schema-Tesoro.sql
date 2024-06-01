create DATABASE [Pw3-2c-IslaTesoro];
GO
USE [Pw3-2c-IslaTesoro]
GO

/****** Object:  Table [dbo].[Tesoro]    Script Date: 1/6/2024 14:41:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tesoro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[ImagenRuta] [nvarchar](300) NULL
) ON [PRIMARY]
GO


