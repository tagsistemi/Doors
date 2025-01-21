IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'OpFuoriMisuraPrimaDi')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [OpFuoriMisuraPrimaDi] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuoriMisuraPrimaDi_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[OpFuoriMisuraPrimaDi] = '' WHERE [dbo].[TAG_DOORS_Params].[OpFuoriMisuraPrimaDi] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Params' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'OpFuoriMIsuraUltima')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Params]
	ADD [OpFuoriMIsuraUltima] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuoriMIsuraUltima_00 DEFAULT ('0')
END
GO


UPDATE [dbo].[TAG_DOORS_Params] SET [dbo].[TAG_DOORS_Params].[OpFuoriMIsuraUltima] = '0' WHERE [dbo].[TAG_DOORS_Params].[OpFuoriMIsuraUltima] IS NULL
GO


