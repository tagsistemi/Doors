IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAltezzaIntBatt')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAltezzaIntBatt] [float] NULL CONSTRAINT DF_MA_Items_DoorsAltezzaIntBatt_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAltezzaIntBatt] = 0 WHERE [dbo].[MA_Items].[DoorsAltezzaIntBatt] IS NULL
GO


