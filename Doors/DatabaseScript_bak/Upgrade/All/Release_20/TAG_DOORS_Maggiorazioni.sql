IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_Maggiorazioni]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_Maggiorazioni] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Prodctg] [varchar] (8) NOT NULL,
    [ProdSubCtg] [varchar] (8) NOT NULL,
    [Customer] [varchar] (12) NOT NULL,
    [DescriTabella] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_DescriTabella_00 DEFAULT (''),
    [Sconto1] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto1_00 DEFAULT (0),
    [Sconto2] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto2_00 DEFAULT (0),
    [Sconto3] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Sconto3_00 DEFAULT (0),
    [Provvigione] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_Provvigione_00 DEFAULT (0),
    [ScontoMagg1] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg1_00 DEFAULT (0),
    [ScontoMagg2] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg2_00 DEFAULT (0),
    [ScontoMagg3] [float] NULL CONSTRAINT DF_TAG_DOORS_Maggiorazioni_ScontoMagg3_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_Maggiorazioni] PRIMARY KEY NONCLUSTERED
    (
        [Prodctg],
        [ProdSubCtg],
        [Customer]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
