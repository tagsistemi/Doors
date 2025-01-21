IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_PolTelai]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_PolTelai] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_PolTelai_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Codice] [varchar] (21) NOT NULL,
    [SpMuroDa] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelai_SpMuroDa_00 DEFAULT (0),
    [SpMuroA] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelai_SpMuroA_00 DEFAULT (0),
    [LTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelai_LTelaio_00 DEFAULT (0),
    [TipoTelaio] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_PolTelai_TipoTelaio_00 DEFAULT (''),
    [Descrizione] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_PolTelai_Descrizione_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_PolTelai] PRIMARY KEY NONCLUSTERED
    (
        [Codice]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
