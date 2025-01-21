IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'OpFuorimisuraDopoDi')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [OpFuorimisuraDopoDi] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuorimisuraDopoDi_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[OpFuorimisuraDopoDi] = '' WHERE [dbo].[TAG_DOORS_Params].[OpFuorimisuraDopoDi] IS NULL
GO


