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


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsPrezzoBase')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsPrezzoBase] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsPrezzoBase_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsPrezzoBase] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsPrezzoBase] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC1PB')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC1PB] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC1PB_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC1PB] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC1PB] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC2PB')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC2PB] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC2PB_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC2PB] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC2PB] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC3PB')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC3PB] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC3PB_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC3PB] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC3PB] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsMaggiorazione')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsMaggiorazione] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsMaggiorazione_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsMaggiorazione] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsMaggiorazione] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC1Magg')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC1Magg] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC1Magg_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC1Magg] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC1Magg] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC2Magg')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC2Magg] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC2Magg_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC2Magg] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC2Magg] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_SaleOrdDetails' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSC3Magg')
BEGIN
ALTER TABLE [dbo].[MA_SaleOrdDetails]
	ADD [DoorsSC3Magg] [float] NULL CONSTRAINT DF_MA_SaleOrdDetails_DoorsSC3Magg_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_SaleOrdDetails] SET [dbo].[MA_SaleOrdDetails].[DoorsSC3Magg] = 0 WHERE [dbo].[MA_SaleOrdDetails].[DoorsSC3Magg] IS NULL
GO


