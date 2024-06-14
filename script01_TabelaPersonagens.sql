IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ONIBUS] (
    [Id] int NOT NULL IDENTITY,
    [Linha] varchar(200) NOT NULL,
    [NomeLinha] varchar(200) NOT NULL,
    [PontoPartida] varchar(200) NOT NULL,
    [PontoFinal] varchar(200) NOT NULL,
    [TempoEspera] int NOT NULL,
    [Situacao] int NOT NULL,
    CONSTRAINT [PK_TB_ONIBUS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Linha', N'NomeLinha', N'PontoFinal', N'PontoPartida', N'Situacao', N'TempoEspera') AND [object_id] = OBJECT_ID(N'[TB_ONIBUS]'))
    SET IDENTITY_INSERT [TB_ONIBUS] ON;
INSERT INTO [TB_ONIBUS] ([Id], [Linha], [NomeLinha], [PontoFinal], [PontoPartida], [Situacao], [TempoEspera])
VALUES (1, '1234A', 'Parque Luiz Fernando', 'Av. Vitor Luz', 'Parque Luiz Cardoso', 1, 5),
(2, '1345A', 'Av. Professora Quitereia', 'R. Sarjento Bruno', 'Av. Professora Quiteria', 1, 15),
(3, '1456A', 'Vila Guilherme', 'Rua Soldado   Brad kynndy', 'Vila Guilherme', 1, 25),
(4, '1567A', 'AV. Marion', 'Rua Professora Fatima', 'Av. Marion', 1, 35),
(5, '1678A', 'Av. Eduardo Kaue', ' Rua Senior Bruno Leitao', 'Av. Eduardo Kaue', 3, 45);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Linha', N'NomeLinha', N'PontoFinal', N'PontoPartida', N'Situacao', N'TempoEspera') AND [object_id] = OBJECT_ID(N'[TB_ONIBUS]'))
    SET IDENTITY_INSERT [TB_ONIBUS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240428201638_MigracaoInicial', N'8.0.4');
GO

COMMIT;
GO

