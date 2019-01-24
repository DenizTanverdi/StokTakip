
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/24/2019 11:20:08
-- Generated from EDMX file: C:\Users\iau\Desktop\StokTakip\WindowsFormsAppEntity\Okul.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NORTHWND2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_OgrenciSehirler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SehirlerSet] DROP CONSTRAINT [FK_OgrenciSehirler];
GO
IF OBJECT_ID(N'[dbo].[FK_AlinanDerslerOgrenci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OgrenciSet] DROP CONSTRAINT [FK_AlinanDerslerOgrenci];
GO
IF OBJECT_ID(N'[dbo].[FK_DerslerAlinanDersler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlinanDerslerSet] DROP CONSTRAINT [FK_DerslerAlinanDersler];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[OgrenciSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OgrenciSet];
GO
IF OBJECT_ID(N'[dbo].[SehirlerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SehirlerSet];
GO
IF OBJECT_ID(N'[dbo].[DerslerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DerslerSet];
GO
IF OBJECT_ID(N'[dbo].[AlinanDerslerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlinanDerslerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'OgrenciSet'
CREATE TABLE [dbo].[OgrenciSet] (
    [OgrId] int IDENTITY(1,1) NOT NULL,
    [OgrenciAdi] nvarchar(max)  NULL,
    [Soyad] nvarchar(max)  NOT NULL,
    [OgrenciNo] nvarchar(max)  NOT NULL,
    [Cinsiyet] nvarchar(max)  NOT NULL,
    [DogumTarihi] datetime  NOT NULL,
    [SehirId] nvarchar(max)  NOT NULL,
    [AlinanDersler_OgId] int  NOT NULL,
    [AlinanDersler_DersId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SehirlerSet'
CREATE TABLE [dbo].[SehirlerSet] (
    [SehirId] int IDENTITY(1,1) NOT NULL,
    [SehirAdi] nvarchar(max)  NOT NULL,
    [Ogrenci_OgrId] int  NOT NULL
);
GO

-- Creating table 'DerslerSet'
CREATE TABLE [dbo].[DerslerSet] (
    [DId] int IDENTITY(1,1) NOT NULL,
    [DersAdi] nvarchar(max)  NOT NULL,
    [Kredi] int  NOT NULL
);
GO

-- Creating table 'AlinanDerslerSet'
CREATE TABLE [dbo].[AlinanDerslerSet] (
    [OgId] int IDENTITY(1,1) NOT NULL,
    [DersId] nvarchar(max)  NOT NULL,
    [Dersler_DId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OgrId] in table 'OgrenciSet'
ALTER TABLE [dbo].[OgrenciSet]
ADD CONSTRAINT [PK_OgrenciSet]
    PRIMARY KEY CLUSTERED ([OgrId] ASC);
GO

-- Creating primary key on [SehirId] in table 'SehirlerSet'
ALTER TABLE [dbo].[SehirlerSet]
ADD CONSTRAINT [PK_SehirlerSet]
    PRIMARY KEY CLUSTERED ([SehirId] ASC);
GO

-- Creating primary key on [DId] in table 'DerslerSet'
ALTER TABLE [dbo].[DerslerSet]
ADD CONSTRAINT [PK_DerslerSet]
    PRIMARY KEY CLUSTERED ([DId] ASC);
GO

-- Creating primary key on [OgId], [DersId] in table 'AlinanDerslerSet'
ALTER TABLE [dbo].[AlinanDerslerSet]
ADD CONSTRAINT [PK_AlinanDerslerSet]
    PRIMARY KEY CLUSTERED ([OgId], [DersId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Ogrenci_OgrId] in table 'SehirlerSet'
ALTER TABLE [dbo].[SehirlerSet]
ADD CONSTRAINT [FK_OgrenciSehirler]
    FOREIGN KEY ([Ogrenci_OgrId])
    REFERENCES [dbo].[OgrenciSet]
        ([OgrId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OgrenciSehirler'
CREATE INDEX [IX_FK_OgrenciSehirler]
ON [dbo].[SehirlerSet]
    ([Ogrenci_OgrId]);
GO

-- Creating foreign key on [AlinanDersler_OgId], [AlinanDersler_DersId] in table 'OgrenciSet'
ALTER TABLE [dbo].[OgrenciSet]
ADD CONSTRAINT [FK_AlinanDerslerOgrenci]
    FOREIGN KEY ([AlinanDersler_OgId], [AlinanDersler_DersId])
    REFERENCES [dbo].[AlinanDerslerSet]
        ([OgId], [DersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlinanDerslerOgrenci'
CREATE INDEX [IX_FK_AlinanDerslerOgrenci]
ON [dbo].[OgrenciSet]
    ([AlinanDersler_OgId], [AlinanDersler_DersId]);
GO

-- Creating foreign key on [Dersler_DId] in table 'AlinanDerslerSet'
ALTER TABLE [dbo].[AlinanDerslerSet]
ADD CONSTRAINT [FK_DerslerAlinanDersler]
    FOREIGN KEY ([Dersler_DId])
    REFERENCES [dbo].[DerslerSet]
        ([DId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DerslerAlinanDersler'
CREATE INDEX [IX_FK_DerslerAlinanDersler]
ON [dbo].[AlinanDerslerSet]
    ([Dersler_DId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------