IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabellaPannelliTesta]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabellaPannelliTesta] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_TabellaPannelliTesta_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Finitura] [varchar] (8) NOT NULL,
    [Battuta] [varchar] (8) NOT NULL,
    CONSTRAINT [PK_TAG_DOORS_TabellaPannelliTesta] PRIMARY KEY NONCLUSTERED
    (
        [Finitura],
        [Battuta]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
