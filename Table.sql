CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (150)  NOT NULL,
    [ContextKey]     NVARCHAR (300)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (32)   NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC)
);

CREATE TABLE [dbo].[Chickens] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Producing]     NVARCHAR (MAX) NULL,
    [AmountProduce] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Chickens] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Cows] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Producing]     NVARCHAR (MAX) NULL,
    [AmountProduce] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Cows] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Turtles] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Producing]     NVARCHAR (MAX) NULL,
    [AmountProduce] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Turtles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

SET IDENTITY_INSERT [dbo].[Chickens] ON
INSERT INTO [dbo].[Chickens] ([id], [Name], [Producing], [AmountProduce]) VALUES (1, N'Курица', N'Яйца', N'10 штук')
SET IDENTITY_INSERT [dbo].[Chickens] OFF

SELECT * FROM [Chickens]

SET IDENTITY_INSERT [dbo].[Cows] ON
INSERT INTO [dbo].[Cows] ([Id], [Name], [Producing], [AmountProduce]) VALUES (1, N'Корова', N'Молоко', N'15 литров')
SET IDENTITY_INSERT [dbo].[Cows] OFF

SELECT * FROM [Cows]

SET IDENTITY_INSERT [dbo].[Turtles] ON
INSERT INTO [dbo].[Turtles] ([Id], [Name], [Producing], [AmountProduce]) VALUES (1, N'Черепашка', N'Яйца', N'25 штук')
SET IDENTITY_INSERT [dbo].[Turtles] OFF

SELECT * FROM [Turtles]

SELECT 
Chickens.Id as 'Id',
Cows.Id  as 'Id',
Turtles.Id as 'Id'
FROM  Chickens, Cows, Turtles
WHERE Chickens.Id = Chickens.Id and Cows.Id = Cows.Id and 
      Turtles.Id = Turtles.Id
