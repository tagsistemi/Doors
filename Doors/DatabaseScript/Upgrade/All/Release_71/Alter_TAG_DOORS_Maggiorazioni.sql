IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ScontoMagg1')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [ScontoMagg1] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg1_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg1] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg1] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ScontoMagg2')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [ScontoMagg2] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg2_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg2] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg2] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Maggiorazioni' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'ScontoMagg3')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Maggiorazioni]
	ADD [ScontoMagg3] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg3_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_Maggiorazioni] SET [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg3] = 0 WHERE [dbo].[TAG_DOORS_Maggiorazioni].[ScontoMagg3] IS NULL
GO


