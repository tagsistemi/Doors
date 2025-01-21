IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_ConfigurazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'NoteOperazione')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_ConfigurazioniDetail]
	ADD [NoteOperazione] [varchar] (254) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_NoteOperazione_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_ConfigurazioniDetail] SET [dbo].[TAG_DOORS_ConfigurazioniDetail].[NoteOperazione] = '' WHERE [dbo].[TAG_DOORS_ConfigurazioniDetail].[NoteOperazione] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_ConfigurazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'NoteComponente')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_ConfigurazioniDetail]
	ADD [NoteComponente] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_NoteComponente_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_ConfigurazioniDetail] SET [dbo].[TAG_DOORS_ConfigurazioniDetail].[NoteComponente] = '' WHERE [dbo].[TAG_DOORS_ConfigurazioniDetail].[NoteComponente] IS NULL
GO


