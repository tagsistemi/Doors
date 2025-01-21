IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabellaVetriR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabellaVetriR] (
    [Item] [varchar] (21) NOT NULL,
    [LET] [float] NOT NULL,
    [HET] [float] NOT NULL,
    [Qty] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_Qty_00 DEFAULT (0),
    [LVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_LVT_00 DEFAULT (0),
    [HVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_HVT_00 DEFAULT (0),
    [PVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_PVT_00 DEFAULT (0),
    [CategoriaVt] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_CategoriaVt_00 DEFAULT (''),
    [Tipologia] [int] NULL CONSTRAINT DF_TAG_DOORS_TabellaVetriR_Tipologia_00 DEFAULT (1511522304),
    CONSTRAINT [PK_TAG_DOORS_TabellaVetriR] PRIMARY KEY NONCLUSTERED
    (
        [Item],
        [LET],
        [HET]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
