IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_ConfigurazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Fase')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_ConfigurazioniDetail]
	ADD [Fase] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_Fase_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_ConfigurazioniDetail] SET [dbo].[TAG_DOORS_ConfigurazioniDetail].[Fase] = 0 WHERE [dbo].[TAG_DOORS_ConfigurazioniDetail].[Fase] IS NULL
GO


