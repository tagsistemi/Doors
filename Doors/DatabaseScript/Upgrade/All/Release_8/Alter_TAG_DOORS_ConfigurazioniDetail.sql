IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_ConfigurazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ExplosionLine')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_ConfigurazioniDetail]
	ADD [ExplosionLine] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_ExplosionLine_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_ConfigurazioniDetail] SET [dbo].[TAG_DOORS_ConfigurazioniDetail].[ExplosionLine] = 0 WHERE [dbo].[TAG_DOORS_ConfigurazioniDetail].[ExplosionLine] IS NULL
GO


