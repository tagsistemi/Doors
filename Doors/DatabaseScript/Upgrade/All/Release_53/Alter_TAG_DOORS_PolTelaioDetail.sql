IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_PolTelaioDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'LTelaio')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_PolTelaioDetail]
	ADD [LTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_PolTelaioDetail] SET [dbo].[TAG_DOORS_PolTelaioDetail].[LTelaio] = 0 WHERE [dbo].[TAG_DOORS_PolTelaioDetail].[LTelaio] IS NULL
GO


