IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ConfigVetri]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ConfigVetri] (
    [IdGuid] [varchar] (50) NOT NULL,
    [Line] [smallint] NOT NULL,
    [Item] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_ConfigVetri_Item_00 DEFAULT (''),
    [Description] [varchar] (150) NULL CONSTRAINT DF_TAG_DOORS_ConfigVetri_Description_00 DEFAULT (''),
    [Qty] [float] NULL CONSTRAINT DF_TAG_DOORS_ConfigVetri_Qty_00 DEFAULT (0),
    CONSTRAINT [PK_TAG_DOORS_ConfigVetri] PRIMARY KEY NONCLUSTERED
    (
        [IdGuid],
        [Line]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
