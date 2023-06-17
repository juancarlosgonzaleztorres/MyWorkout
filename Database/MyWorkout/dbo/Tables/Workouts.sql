CREATE TABLE [dbo].[Workouts] (
    [Id]       INT      IDENTITY (1, 1) NOT NULL,
    [PersonId] INT      NULL,
    [Start]    DATETIME NULL,
    [Finish]   DATETIME NULL
);

