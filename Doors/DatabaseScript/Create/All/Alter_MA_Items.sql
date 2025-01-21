IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsApertura')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsApertura] [varchar] (12) NULL CONSTRAINT DF_MA_Items_DoorsApertura_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsApertura] = '' WHERE [dbo].[MA_Items].[DoorsApertura] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsNote')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsNote] [varchar] (50) NULL CONSTRAINT DF_MA_Items_DoorsNote_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsNote] = '' WHERE [dbo].[MA_Items].[DoorsNote] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLarghezza')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsLarghezza] [float] NULL CONSTRAINT DF_MA_Items_DoorsLarghezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsLarghezza] = 0 WHERE [dbo].[MA_Items].[DoorsLarghezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAltezza')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAltezza] [float] NULL CONSTRAINT DF_MA_Items_DoorsAltezza_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAltezza] = 0 WHERE [dbo].[MA_Items].[DoorsAltezza] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsFinitura')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsFinitura] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsFinitura_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsFinitura] = '' WHERE [dbo].[MA_Items].[DoorsFinitura] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsBattuta')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsBattuta] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsBattuta_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsBattuta] = '' WHERE [dbo].[MA_Items].[DoorsBattuta] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsTipoTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsTipoTelaio] [varchar] (8) NULL CONSTRAINT DF_MA_Items_DoorsTipoTelaio_00 DEFAULT ('')
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsTipoTelaio] = '' WHERE [dbo].[MA_Items].[DoorsTipoTelaio] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpessore')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsSpessore] [float] NULL CONSTRAINT DF_MA_Items_DoorsSpessore_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsSpessore] = 0 WHERE [dbo].[MA_Items].[DoorsSpessore] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLarghezzaIntBatt')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsLarghezzaIntBatt] [float] NULL CONSTRAINT DF_MA_Items_DoorsLarghezzaIntBatt_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsLarghezzaIntBatt] = 0 WHERE [dbo].[MA_Items].[DoorsLarghezzaIntBatt] IS NULL
GO


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


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAriaL')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAriaL] [float] NULL CONSTRAINT DF_MA_Items_DoorsAriaL_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAriaL] = 0 WHERE [dbo].[MA_Items].[DoorsAriaL] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsAriaH')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsAriaH] [float] NULL CONSTRAINT DF_MA_Items_DoorsAriaH_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsAriaH] = 0 WHERE [dbo].[MA_Items].[DoorsAriaH] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpProfIntTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsSpProfIntTelaio] [float] NULL CONSTRAINT DF_MA_Items_DoorsSpProfIntTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsSpProfIntTelaio] = 0 WHERE [dbo].[MA_Items].[DoorsSpProfIntTelaio] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsSpProfEstTelaio')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsSpProfEstTelaio] [float] NULL CONSTRAINT DF_MA_Items_DoorsSpProfEstTelaio_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsSpProfEstTelaio] = 0 WHERE [dbo].[MA_Items].[DoorsSpProfEstTelaio] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'HVetro')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [HVetro] [float] NULL CONSTRAINT DF_MA_Items_HVetro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[HVetro] = 0 WHERE [dbo].[MA_Items].[HVetro] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'LVetro')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [LVetro] [float] NULL CONSTRAINT DF_MA_Items_LVetro_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[LVetro] = 0 WHERE [dbo].[MA_Items].[LVetro] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsLNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsLNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsLNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsLNominale] = 0 WHERE [dbo].[MA_Items].[DoorsLNominale] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsHNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsHNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsHNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsHNominale] = 0 WHERE [dbo].[MA_Items].[DoorsHNominale] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsPNominale')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsPNominale] [float] NULL CONSTRAINT DF_MA_Items_DoorsPNominale_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsPNominale] = 0 WHERE [dbo].[MA_Items].[DoorsPNominale] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffL')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffL] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffL_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffL] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffL] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffH')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffH] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffH_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffH] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffH] IS NULL
GO


IF NOT EXISTS (SELECT dbo.syscolumns.name FROM dbo.syscolumns, dbo.sysobjects WHERE
	dbo.sysobjects.name = 'MA_Items' AND dbo.sysobjects.id = dbo.syscolumns.id
	AND dbo.syscolumns.name = 'DoorsCoeffP')
BEGIN
ALTER TABLE [dbo].[MA_Items]
	ADD [DoorsCoeffP] [float] NULL CONSTRAINT DF_MA_Items_DoorsCoeffP_00 DEFAULT (0)
END
GO


UPDATE [dbo].[MA_Items] SET [dbo].[MA_Items].[DoorsCoeffP] = 0 WHERE [dbo].[MA_Items].[DoorsCoeffP] IS NULL
GO


