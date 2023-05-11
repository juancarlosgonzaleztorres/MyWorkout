USE [MyWorkout]
GO

/****** Object:  Table [dbo].[Link_Workout_Person]    Script Date: 5/7/2023 7:17:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Link_Workout_Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[WorkoutId] [int] NOT NULL
) ON [PRIMARY]
GO


