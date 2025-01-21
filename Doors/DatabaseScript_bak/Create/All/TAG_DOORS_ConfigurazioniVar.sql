IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ConfigurazioniVar]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ConfigurazioniVar] (
    [Line] [smallint] NOT NULL,
    [IdGuid] [varchar] (50) NOT NULL,
    [CodVariante] [varchar] (21) NOT NULL,
    [Bom] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniVar_Bom_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_ConfigurazioniVar] PRIMARY KEY NONCLUSTERED
    (
        [Line],
        [IdGuid],
        [CodVariante]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
