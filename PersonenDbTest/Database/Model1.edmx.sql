
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/07/2020 20:13:00
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

IF OBJECT_ID(N'[dbo].[FK_AbteilungPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_AbteilungPerson];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Abteilungs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Abteilungs];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Abteilung'
CREATE TABLE [dbo].[Abteilung] (
    [AbteilungId] int  NOT NULL,
    [AbteilungName] varchar(50)  NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [PersonId] int  NOT NULL,
    [Name] varchar(50)  NULL,
    [SecondName] varchar(50)  NULL,
    [Street] varchar(50)  NULL,
    [Plz] varchar(50)  NULL,
    [Place] varchar(50)  NULL,
    [AbteilungAbteilungId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AbteilungId] in table 'Abteilung'
ALTER TABLE [dbo].[Abteilung]
ADD CONSTRAINT [PK_Abteilung]
    PRIMARY KEY CLUSTERED ([AbteilungId] ASC);
GO

-- Creating primary key on [PersonId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AbteilungAbteilungId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [FK_PersonAbteilung]
    FOREIGN KEY ([AbteilungAbteilungId])
    REFERENCES [dbo].[Abteilung]
        ([AbteilungId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonAbteilung'
CREATE INDEX [IX_FK_PersonAbteilung]
ON [dbo].[Person]
    ([AbteilungAbteilungId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------