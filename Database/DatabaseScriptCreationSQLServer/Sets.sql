USE [MyWorkout]
GO

/****** Object:  Table [dbo].[Sets]    Script Date: 5/7/2023 7:18:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Repetitions] [int] NOT NULL,
	[ExcerciseId] [int] NOT NULL,
	[Start] [datetime] NULL,
	[Finish] [datetime] NULL,
	[Weight] [int] NULL
) ON [PRIMARY]
GO


