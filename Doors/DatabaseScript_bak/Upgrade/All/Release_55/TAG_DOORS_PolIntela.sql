IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_PolIntela]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_PolIntela] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_PolIntela_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Item] [varchar] (21) NOT NULL,
    [HDa] [float] NOT NULL,
    [HA] [float] NOT NULL,
    [LDa] [float] NOT NULL,
    [LA] [float] NOT NULL,
    [FindH] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_PolIntela_FindH_00 DEFAULT ('0'),
    [FindL] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_PolIntela_FindL_00 DEFAULT ('0'),
    [RequiredQty] [float] NULL CONSTRAINT DF_TAG_DOORS_PolIntela_RequiredQty_00 DEFAULT (0),
    [Quantita] [float] NULL CONSTRAINT DF_TAG_DOORS_PolIntela_Quantita_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_PolIntela] PRIMARY KEY NONCLUSTERED
    (
        [Item],
        [HDa],
        [HA],
        [LDa],
        [LA]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
