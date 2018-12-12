
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2018 01:30:13
-- Generated from EDMX file: C:\Users\Juan\Source\Workspaces\MyWorkout\MyWorkout\Database\MyWorkout.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyWorkout];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SetExercise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sets] DROP CONSTRAINT [FK_SetExercise];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkoutSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sets] DROP CONSTRAINT [FK_WorkoutSet];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Workouts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workouts];
GO
IF OBJECT_ID(N'[dbo].[Sets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sets];
GO
IF OBJECT_ID(N'[dbo].[Exercises]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exercises];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Workouts'
CREATE TABLE [dbo].[Workouts] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Sets'
CREATE TABLE [dbo].[Sets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Repetitions] nvarchar(max)  NOT NULL,
    [FinishTime] datetime  NOT NULL,
    [Weight] nvarchar(max)  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [Exercise_Id] int  NOT NULL,
    [Workout_Id] int  NOT NULL
);
GO

-- Creating table 'Exercises'
CREATE TABLE [dbo].[Exercises] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Workouts'
ALTER TABLE [dbo].[Workouts]
ADD CONSTRAINT [PK_Workouts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sets'
ALTER TABLE [dbo].[Sets]
ADD CONSTRAINT [PK_Sets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Exercises'
ALTER TABLE [dbo].[Exercises]
ADD CONSTRAINT [PK_Exercises]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Exercise_Id] in table 'Sets'
ALTER TABLE [dbo].[Sets]
ADD CONSTRAINT [FK_SetExercise]
    FOREIGN KEY ([Exercise_Id])
    REFERENCES [dbo].[Exercises]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SetExercise'
CREATE INDEX [IX_FK_SetExercise]
ON [dbo].[Sets]
    ([Exercise_Id]);
GO

-- Creating foreign key on [Workout_Id] in table 'Sets'
ALTER TABLE [dbo].[Sets]
ADD CONSTRAINT [FK_WorkoutSet]
    FOREIGN KEY ([Workout_Id])
    REFERENCES [dbo].[Workouts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkoutSet'
CREATE INDEX [IX_FK_WorkoutSet]
ON [dbo].[Sets]
    ([Workout_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------