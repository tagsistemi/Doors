IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_Finiture' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'Gruppo')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_Finiture]
	ADD [Gruppo] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Finiture_Gruppo_00 DEFAULT ('')
END
GO


UPDATE [dbo].[TAG_DOORS_Finiture] SET [dbo].[TAG_DOORS_Finiture].[Gruppo] = '' WHERE [dbo].[TAG_DOORS_Finiture].[Gruppo] IS NULL
GO


