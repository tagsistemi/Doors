IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaPannelliR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Dimensione')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaPannelliR]
	ADD [Dimensione] [int] NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Dimensione_00 DEFAULT (1543569408)
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaPannelliR] SET [dbo].[TAG_DOORS_TabellaPannelliR].[Dimensione] = 1543569408 WHERE [dbo].[TAG_DOORS_TabellaPannelliR].[Dimensione] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaPannelliR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Operation1')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaPannelliR]
	ADD [Operation1] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation1_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaPannelliR] SET [dbo].[TAG_DOORS_TabellaPannelliR].[Operation1] = '' WHERE [dbo].[TAG_DOORS_TabellaPannelliR].[Operation1] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaPannelliR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Operation2')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaPannelliR]
	ADD [Operation2] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation2_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaPannelliR] SET [dbo].[TAG_DOORS_TabellaPannelliR].[Operation2] = '' WHERE [dbo].[TAG_DOORS_TabellaPannelliR].[Operation2] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_TabellaPannelliR' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Operation3')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_TabellaPannelliR]
	ADD [Operation3] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation3_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_TabellaPannelliR] SET [dbo].[TAG_DOORS_TabellaPannelliR].[Operation3] = '' WHERE [dbo].[TAG_DOORS_TabellaPannelliR].[Operation3] IS NULL
GO


