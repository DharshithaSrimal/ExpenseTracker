
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2020 22:51:00
-- Generated from EDMX file: C:\Users\acprlk\Google Drive\ASE\Enterprise Development\CW2\ExpenseTracker\ExpenseTracker.DataAccess\ExpenseTrackerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ExpenseTracker];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_CategoryTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_FinancialAccountTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_FinancialAccountTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_PayeeTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_PayeeTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_EventTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_EventTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_FinancialAccountTransfer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_FinancialAccountTransfer];
GO
IF OBJECT_ID(N'[dbo].[FK_FinancialAccountTransfer1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_FinancialAccountTransfer1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Payees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payees];
GO
IF OBJECT_ID(N'[dbo].[FinancialAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FinancialAccounts];
GO
IF OBJECT_ID(N'[dbo].[Transfers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [SysGenerated] bit  NOT NULL,
    [Category_Id] int  NOT NULL,
    [FinancialAccount_Id] int  NOT NULL,
    [Payee_Id] int  NULL,
    [Event_Id] int  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] int  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NULL,
    [DateTime] datetime  NOT NULL,
    [RecurFrequency] int  NULL,
    [Occurrences] int  NULL,
    [UntillWhen] datetime  NULL,
    [LastProcessed] datetime  NOT NULL
);
GO

-- Creating table 'Payees'
CREATE TABLE [dbo].[Payees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Business] nvarchar(max)  NULL,
    [ContactNo] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [Note] nvarchar(max)  NULL
);
GO

-- Creating table 'FinancialAccounts'
CREATE TABLE [dbo].[FinancialAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Color] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Transfers'
CREATE TABLE [dbo].[Transfers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Note] nvarchar(max)  NULL,
    [DateTime] datetime  NOT NULL,
    [SourceAccount_Id] int  NOT NULL,
    [TargetAccount_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payees'
ALTER TABLE [dbo].[Payees]
ADD CONSTRAINT [PK_Payees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FinancialAccounts'
ALTER TABLE [dbo].[FinancialAccounts]
ADD CONSTRAINT [PK_FinancialAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [PK_Transfers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Category_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_CategoryTransaction]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryTransaction'
CREATE INDEX [IX_FK_CategoryTransaction]
ON [dbo].[Transactions]
    ([Category_Id]);
GO

-- Creating foreign key on [FinancialAccount_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_FinancialAccountTransaction]
    FOREIGN KEY ([FinancialAccount_Id])
    REFERENCES [dbo].[FinancialAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FinancialAccountTransaction'
CREATE INDEX [IX_FK_FinancialAccountTransaction]
ON [dbo].[Transactions]
    ([FinancialAccount_Id]);
GO

-- Creating foreign key on [Payee_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_PayeeTransaction]
    FOREIGN KEY ([Payee_Id])
    REFERENCES [dbo].[Payees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayeeTransaction'
CREATE INDEX [IX_FK_PayeeTransaction]
ON [dbo].[Transactions]
    ([Payee_Id]);
GO

-- Creating foreign key on [Event_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_EventTransaction]
    FOREIGN KEY ([Event_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventTransaction'
CREATE INDEX [IX_FK_EventTransaction]
ON [dbo].[Transactions]
    ([Event_Id]);
GO

-- Creating foreign key on [SourceAccount_Id] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_FinancialAccountTransfer]
    FOREIGN KEY ([SourceAccount_Id])
    REFERENCES [dbo].[FinancialAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FinancialAccountTransfer'
CREATE INDEX [IX_FK_FinancialAccountTransfer]
ON [dbo].[Transfers]
    ([SourceAccount_Id]);
GO

-- Creating foreign key on [TargetAccount_Id] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [FK_FinancialAccountTransfer1]
    FOREIGN KEY ([TargetAccount_Id])
    REFERENCES [dbo].[FinancialAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FinancialAccountTransfer1'
CREATE INDEX [IX_FK_FinancialAccountTransfer1]
ON [dbo].[Transfers]
    ([TargetAccount_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------