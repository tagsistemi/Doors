IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_TabellaPannelliAp]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_TabellaPannelliAp] (
    [Finitura] [varchar] (8) NOT NULL,
    [Battuta] [varchar] (8) NOT NULL,
    [Apertura] [varchar] (12) NOT NULL,
    CONSTRAINT [PK_TAG_DOORS_TabellaPannelliAp] PRIMARY KEY NONCLUSTERED
    (
        [Finitura],
        [Battuta],
        [Apertura]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
