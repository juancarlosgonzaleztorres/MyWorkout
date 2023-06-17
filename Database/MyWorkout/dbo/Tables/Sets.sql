CREATE TABLE [dbo].[Sets] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [Repetitions] INT      NOT NULL,
    [ExcerciseId] INT      NOT NULL,
    [Start]       DATETIME NULL,
    [Finish]      DATETIME NULL,
    [Weight]      INT      NULL,
    [WorkoutId]   INT      NULL
);

