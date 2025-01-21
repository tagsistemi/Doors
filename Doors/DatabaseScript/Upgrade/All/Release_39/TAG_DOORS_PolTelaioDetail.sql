IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_PolTelaioDetail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_PolTelaioDetail] (
    [Codice] [varchar] (21) NOT NULL,
    [Riga] [smallint] NOT NULL,
    [SpDa] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_SpDa_00 DEFAULT (0),
    [SpA] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_SpA_00 DEFAULT (0),
    [LCf] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LCf_00 DEFAULT (0),
    [QtaCf] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_QtaCf_00 DEFAULT (0),
    [LCfAl] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LCfAl_00 DEFAULT (0),
    [QtaCfAl] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_QtaCfAl_00 DEFAULT (0),
    [Imbotto] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_Imbotto_00 DEFAULT ('0'),
    [QtaImb] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_QtaImb_00 DEFAULT (0),
    [LCf1] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LCf1_00 DEFAULT (0),
    [QyaCf1] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_QyaCf1_00 DEFAULT (0),
    [LTelaio] [float] NULL CONSTRAINT DF_TAG_DOORS_PolTelaioDetail_LTelaio_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_PolTelaioDetail] PRIMARY KEY NONCLUSTERED
    (
        [Codice],
        [Riga]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
