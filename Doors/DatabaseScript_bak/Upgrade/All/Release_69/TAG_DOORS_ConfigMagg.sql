IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ConfigMagg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ConfigMagg] (
    [IdGuid] [varchar] (50) NOT NULL,
    [Line] [smallint] NOT NULL,
    [SubCtgProd] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_SubCtgProd_00 DEFAULT (''),
    [RigaMagg] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_RigaMagg_00 DEFAULT (0),
    [Customer] [varchar] (12) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Customer_00 DEFAULT (''),
    [CtgProd] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_CtgProd_00 DEFAULT (''),
    [TipoMaggiorazione] [int] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_TipoMaggiorazione_00 DEFAULT (996409344),
    [OltreStandard] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_OltreStandard_00 DEFAULT (0),
    [Item] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Item_00 DEFAULT (''),
    [Importo] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Importo_00 DEFAULT (0),
    [Dimensione] [int] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Dimensione_00 DEFAULT (1543569408),
    [Descrizione] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Descrizione_00 DEFAULT (''),
    [DaDim] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_DaDim_00 DEFAULT (0),
    [ADim] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_ADim_00 DEFAULT (0),
    [Apertura] [varchar] (12) NULL CONSTRAINT DF_TAG_DOORS_ConfigMagg_Apertura_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_ConfigMagg] PRIMARY KEY NONCLUSTERED
    (
        [IdGuid],
        [Line]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
