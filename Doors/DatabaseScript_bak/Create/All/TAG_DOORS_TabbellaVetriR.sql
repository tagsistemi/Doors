IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabbellaVetriR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabbellaVetriR] (
    [Item] [varchar] (21) NOT NULL,
    [LET] [float] NOT NULL,
    [HET] [float] NOT NULL,
    [Qta] [float] NULL CONSTRAINT DF_TAG_DOORS_TabbellaVetriR_Qta_00 DEFAULT (0),
    [LVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabbellaVetriR_LVT_00 DEFAULT (0),
    [HVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabbellaVetriR_HVT_00 DEFAULT (0),
    [SPVT] [float] NULL CONSTRAINT DF_TAG_DOORS_TabbellaVetriR_SPVT_00 DEFAULT (0),
    [CategoriaVt] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_TabbellaVetriR_CategoriaVt_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_TabbellaVetriR] PRIMARY KEY NONCLUSTERED
    (
        [Item],
        [LET],
        [HET]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
