
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2017 23:34:31
-- Generated from EDMX file: D:\SlicerConf\SlicerConf\SlicerConf.Data\SlicerConfDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SlicerConfDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PrinterPrinterSetting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PrinterSettings] DROP CONSTRAINT [FK_PrinterPrinterSetting];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Printers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Printers];
GO
IF OBJECT_ID(N'[dbo].[PrinterSettings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrinterSettings];
GO
IF OBJECT_ID(N'[dbo].[Filaments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filaments];
GO
IF OBJECT_ID(N'[dbo].[Pictures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pictures];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Printers'
CREATE TABLE [dbo].[Printers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MaxBuildX] int  NOT NULL,
    [MaxBuildY] int  NOT NULL,
    [MaxBuildZ] int  NOT NULL
);
GO

-- Creating table 'PrinterSettings'
CREATE TABLE [dbo].[PrinterSettings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LayerHeight] float  NOT NULL,
    [Perimeters] int  NOT NULL,
    [TopShells] int  NOT NULL,
    [BottomShells] int  NOT NULL,
    [PrinterId] int  NOT NULL
);
GO

-- Creating table 'Filaments'
CREATE TABLE [dbo].[Filaments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PrintTemperature] int  NOT NULL,
    [HeatbedEnabled] bit  NOT NULL,
    [HeatbedTemperature] int  NOT NULL
);
GO

-- Creating table 'Pictures'
CREATE TABLE [dbo].[Pictures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [img] varbinary(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Printers'
ALTER TABLE [dbo].[Printers]
ADD CONSTRAINT [PK_Printers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PrinterSettings'
ALTER TABLE [dbo].[PrinterSettings]
ADD CONSTRAINT [PK_PrinterSettings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Filaments'
ALTER TABLE [dbo].[Filaments]
ADD CONSTRAINT [PK_Filaments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [PK_Pictures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PrinterId] in table 'PrinterSettings'
ALTER TABLE [dbo].[PrinterSettings]
ADD CONSTRAINT [FK_PrinterPrinterSetting]
    FOREIGN KEY ([PrinterId])
    REFERENCES [dbo].[Printers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrinterPrinterSetting'
CREATE INDEX [IX_FK_PrinterPrinterSetting]
ON [dbo].[PrinterSettings]
    ([PrinterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------