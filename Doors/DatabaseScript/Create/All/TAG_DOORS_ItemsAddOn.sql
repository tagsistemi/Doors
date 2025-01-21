IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ItemsAddOn]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ItemsAddOn] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_ItemsAddOn_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Item] [varchar] (21) NOT NULL,
    [Apertura] [varchar] (12) NULL CONSTRAINT DF_TAG_DOORS_ItemsAddOn_Apertura_00 DEFAULT (''),
    [Note] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_ItemsAddOn_Note_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_ItemsAddOn] PRIMARY KEY NONCLUSTERED
    (
        [Item]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
