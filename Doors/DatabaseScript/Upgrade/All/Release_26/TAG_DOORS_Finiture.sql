IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_Finiture]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_Finiture] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_Finiture_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Codice] [varchar] (8) NOT NULL,
    [Descrizione] [varchar] (64) NULL CONSTRAINT DF_TAG_DOORS_Finiture_Descrizione_00 DEFAULT (''),
    [Gruppo] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Finiture_Gruppo_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_Finiture] PRIMARY KEY NONCLUSTERED
    (
        [Codice]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
