IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLarghezza')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsLarghezza] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsLarghezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsLarghezza] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsLarghezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAltezza')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsAltezza] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsAltezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsAltezza] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsAltezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpMuro')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSpMuro] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSpMuro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSpMuro] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSpMuro] IS NULL
GO


