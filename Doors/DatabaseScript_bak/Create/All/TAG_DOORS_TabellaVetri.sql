IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabellaVetri]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabellaVetri] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetri_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Item] [varchar] (21) NOT NULL,
    [LEsternoTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetri_LEsternoTelaio_00 DEFAULT (0),
    [HEsternoTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetri_HEsternoTelaio_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_TabellaVetri] PRIMARY KEY NONCLUSTERED
    (
        [Item]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
