IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'UtenteMago')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [UtenteMago] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_UtenteMago_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[UtenteMago] = '' WHERE [dbo].[TAG_DOORS_Params].[UtenteMago] IS NULL
GO


