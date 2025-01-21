IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ConfigurazioniDetail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ConfigurazioniDetail] (
    [IdGuid] [varchar] (50) NOT NULL,
    [Line] [smallint] NOT NULL,
    [Component] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_Component_00 DEFAULT (''),
    [ComponentDescription] [varchar] (128) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_ComponentDescription_00 DEFAULT (''),
    [IsRtgStep] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_IsRtgStep_00 DEFAULT ('0'),
    [Qty] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_Qty_00 DEFAULT (0),
    [BOMLevel] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_BOMLevel_00 DEFAULT (0),
    [ParentBOM] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_ParentBOM_00 DEFAULT (''),
    [BOM] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_BOM_00 DEFAULT (''),
    [BreakingBOM] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_BreakingBOM_00 DEFAULT (''),
    [BreakingItem] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_BreakingItem_00 DEFAULT (''),
    [IsABOM] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_IsABOM_00 DEFAULT ('0'),
    [Note] [varchar] (250) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_Note_00 DEFAULT (''),
    [ExplosionLine] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_ExplosionLine_00 DEFAULT (0),
    [NoteOperazione] [varchar] (254) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_NoteOperazione_00 DEFAULT (''),
    [NoteComponente] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_NoteComponente_00 DEFAULT (''),
    [Fase] [smallint] NULL CONSTRAINT DF_TAG_DOORS_ConfigurazioniDetail_Fase_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_ConfigurazioniDetail] PRIMARY KEY NONCLUSTERED
    (
        [IdGuid],
        [Line]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
