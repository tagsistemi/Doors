IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_Configurazioni]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_Configurazioni] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [IdGuid] [varchar] (50) NOT NULL,
    [SaleOrdId] [int] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_SaleOrdId_00 DEFAULT (0),
    [PositionSaleOrd] [smallint] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_PositionSaleOrd_00 DEFAULT (0),
    [LineSaleOrd] [smallint] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_LineSaleOrd_00 DEFAULT (0),
    [Larghezza] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_Larghezza_00 DEFAULT (0),
    [Altezza] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_Altezza_00 DEFAULT (0),
    [SpessoreMuro] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_SpessoreMuro_00 DEFAULT (0),
    [SpessoreTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_SpessoreTelaio_00 DEFAULT (0),
    [NoteConfText] [text] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_NoteConfText_00 DEFAULT (''),
    [RootItem] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_RootItem_00 DEFAULT (''),
    [VarianteRoot] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_VarianteRoot_00 DEFAULT (''),
    [VarianteStandard] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_VarianteStandard_00 DEFAULT ('0'),
    [DescRootVar] [varchar] (250) NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_DescRootVar_00 DEFAULT (''),
    [LIntBattuta] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_LIntBattuta_00 DEFAULT (0),
    [HIntBattuta] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_HIntBattuta_00 DEFAULT (0),
    [AriaH] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_AriaH_00 DEFAULT (0),
    [AriaL] [float] NULL CONSTRAINT DF_TAG_DOORS_Configurazioni_AriaL_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_Configurazioni] PRIMARY KEY NONCLUSTERED
    (
        [IdGuid]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
