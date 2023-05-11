USE [MyWorkout]
GO

/****** Object:  Table [dbo].[Workouts]    Script Date: 5/7/2023 7:18:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Workouts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Start] [datetime] NULL,
	[Finish] [datetime] NULL
) ON [PRIMARY]
GO


