IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'TipoMaggiorazione')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [TipoMaggiorazione] [int] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_TipoMaggiorazione_00 DEFAULT (996409344)
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[TipoMaggiorazione] = 996409344 WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[TipoMaggiorazione] IS NULL
GO


