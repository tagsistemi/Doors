IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_PolTelaioDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'LCf1')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_PolTelaioDetail]
	ADD [LCf1] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LCf1_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_PolTelaioDetail] SET [dbo].[TAG_DOORS_PolTelaioDetail].[LCf1] = 0 WHERE [dbo].[TAG_DOORS_PolTelaioDetail].[LCf1] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_PolTelaioDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'QyaCf1')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_PolTelaioDetail]
	ADD [QyaCf1] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_QyaCf1_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_PolTelaioDetail] SET [dbo].[TAG_DOORS_PolTelaioDetail].[QyaCf1] = 0 WHERE [dbo].[TAG_DOORS_PolTelaioDetail].[QyaCf1] IS NULL
GO


