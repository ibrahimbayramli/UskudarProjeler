
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/20/2022 17:32:21
-- Generated from EDMX file: C:\Users\STUDENT2\Desktop\UskudarProjeler\20042022\Uygulama1\Uygulama1\Malzemeler.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Malzemeler];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Malzeme'
CREATE TABLE [dbo].[Malzeme] (
    [MalzemeId] int IDENTITY(1,1) NOT NULL,
    [MalzemeAdi] nvarchar(max)  NOT NULL,
    [MalzemeAdet] int  NOT NULL,
    [MalzemeFiyat] decimal(18,0)  NOT NULL,
    [MalzemeDepoAdi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tedarikciler'
CREATE TABLE [dbo].[Tedarikciler] (
    [TNo] int IDENTITY(1,1) NOT NULL,
    [TAdi] nvarchar(max)  NOT NULL,
    [TAdres] nvarchar(max)  NOT NULL,
    [TTel] nvarchar(max)  NOT NULL,
    [MalzemeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MalzemeId] in table 'Malzeme'
ALTER TABLE [dbo].[Malzeme]
ADD CONSTRAINT [PK_Malzeme]
    PRIMARY KEY CLUSTERED ([MalzemeId] ASC);
GO

-- Creating primary key on [TNo] in table 'Tedarikciler'
ALTER TABLE [dbo].[Tedarikciler]
ADD CONSTRAINT [PK_Tedarikciler]
    PRIMARY KEY CLUSTERED ([TNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MalzemeId] in table 'Tedarikciler'
ALTER TABLE [dbo].[Tedarikciler]
ADD CONSTRAINT [FK_MalzemeTedarikciler]
    FOREIGN KEY ([MalzemeId])
    REFERENCES [dbo].[Malzeme]
        ([MalzemeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MalzemeTedarikciler'
CREATE INDEX [IX_FK_MalzemeTedarikciler]
ON [dbo].[Tedarikciler]
    ([MalzemeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------