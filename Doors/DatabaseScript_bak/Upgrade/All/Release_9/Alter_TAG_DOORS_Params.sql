IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ProgConf')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [ProgConf] [int] NULL CONSTRAINT DF_TAG_DOORS_Params_ProgConf_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[ProgConf] = 0 WHERE [dbo].[TAG_DOORS_Params].[ProgConf] IS NULL
GO


