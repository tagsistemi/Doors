IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsVerso')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsVerso] [varchar] (21) NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsVerso_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsVerso] = '' WHERE [dbo].[MA_SaleOrdDetails].[DoorsVerso] IS NULL
GO


