IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Dimensione')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [Dimensione] [int] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Dimensione_00 DEFAULT (1543569408)
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[Dimensione] = 1543569408 WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[Dimensione] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DaDim')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [DaDim] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_DaDim_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[DaDim] = 0 WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[DaDim] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ADim')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [ADim] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_ADim_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[ADim] = 0 WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[ADim] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Apertura')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [Apertura] [varchar] (12) NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Apertura_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[Apertura] = '' WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[Apertura] IS NULL
GO


