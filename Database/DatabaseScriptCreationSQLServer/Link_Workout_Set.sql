USE [MyWorkout]
GO

/****** Object:  Table [dbo].[Link_Workout_Set]    Script Date: 5/7/2023 7:17:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Link_Workout_Set](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WorkoutId] [int] NULL,
	[SetId] [int] NULL
) ON [PRIMARY]
GO


