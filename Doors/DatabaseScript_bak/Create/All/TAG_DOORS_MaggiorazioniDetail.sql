IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_MaggiorazioniDetail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_MaggiorazioniDetail] (
    [CtgProd] [varchar] (8) NOT NULL,
    [SubCtgProd] [varchar] (8) NOT NULL,
    [Customer] [varchar] (12) NOT NULL,
    [Riga] [smallint] NOT NULL,
    [Item] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Item_00 DEFAULT (''),
    [Descrizione] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Descrizione_00 DEFAULT (''),
    [Importo] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Importo_00 DEFAULT (0),
    [TipoMaggiorazione] [int] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_TipoMaggiorazione_00 DEFAULT (996409344),
    [Dimensione] [int] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Dimensione_00 DEFAULT (1543569408),
    [DaDim] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_DaDim_00 DEFAULT (0),
    [ADim] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_ADim_00 DEFAULT (0),
    [Apertura] [varchar] (12) NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_Apertura_00 DEFAULT (''),
    [OltreStandard] [float] NULL CONSTRAINT DF_TAG_DOORS_MaggiorazioniDetail_OltreStandard_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_MaggiorazioniDetail] PRIMARY KEY NONCLUSTERED
    (
        [CtgProd],
        [SubCtgProd],
        [Customer],
        [Riga]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
