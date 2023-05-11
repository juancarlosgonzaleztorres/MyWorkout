USE [MyWorkout]
GO

/****** Object:  Table [dbo].[Excercises]    Script Date: 5/7/2023 7:17:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Excercises](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL
) ON [PRIMARY]
GO


