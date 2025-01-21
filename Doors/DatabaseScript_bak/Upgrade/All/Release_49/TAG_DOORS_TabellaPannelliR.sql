IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabellaPannelliR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabellaPannelliR] (
    [Finitura] [varchar] (8) NOT NULL,
    [Battuta] [varchar] (8) NOT NULL,
    [DaCm] [float] NOT NULL,
    [ACm] [float] NOT NULL,
    [CmInternoBattutaPannello] [float] NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_CmInternoBattutaPannello_00 DEFAULT (0),
    [IsStandard] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_IsStandard_00 DEFAULT ('0'),
    [Dimensione] [int] NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Dimensione_00 DEFAULT (1543569408),
    [Operation1] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation1_00 DEFAULT (''),
    [Operation2] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation2_00 DEFAULT (''),
    [Operation3] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_Operation3_00 DEFAULT (''),
    [BattutaComponente] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliR_BattutaComponente_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_TabellaPannelliR] PRIMARY KEY NONCLUSTERED
    (
        [Finitura],
        [Battuta],
        [DaCm],
        [ACm]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
