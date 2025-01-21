IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'TAG_DOORS_MaggiorazioniDetail' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'OltreStandard')
BEGIN
ALTER TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail]
	ADD [OltreStandard] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_OltreStandard_00 DEFAULT (0)
END
GO


UPDATE [dbo].[TAG_DOORS_MaggiorazioniDetail] SET [dbo].[TAG_DOORS_MaggiorazioniDetail].[OltreStandard] = 0 WHERE [dbo].[TAG_DOORS_MaggiorazioniDetail].[OltreStandard] IS NULL
GO


