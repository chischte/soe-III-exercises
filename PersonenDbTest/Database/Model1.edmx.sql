
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2020 19:47:29
-- Generated from EDMX file: C:\git\soe-III-exercises\PersonenDbTest\Database\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Personenverwaltung];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Abteilung]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Abteilung];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Abteilungs'
CREATE TABLE [dbo].[Abteilungs] (
    [Id] int  NOT NULL,
    [Abteilung1] varchar(50)  NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int  NOT NULL,
    [Name] varchar(50)  NULL,
    [SecondName] varchar(50)  NULL,
    [Street] varchar(50)  NULL,
    [Plz] varchar(50)  NULL,
    [Place] varchar(50)  NULL,
    [AbteilungId] int  NULL,
    [AbteilungId1] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Abteilungs'
ALTER TABLE [dbo].[Abteilungs]
ADD CONSTRAINT [PK_Abteilungs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AbteilungId1] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_AbteilungPerson]
    FOREIGN KEY ([AbteilungId1])
    REFERENCES [dbo].[Abteilungs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AbteilungPerson'
CREATE INDEX [IX_FK_AbteilungPerson]
ON [dbo].[People]
    ([AbteilungId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------