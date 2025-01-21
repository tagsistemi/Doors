IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_GruppiFiniture]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_GruppiFiniture] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_GruppiFiniture_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Codice] [varchar] (8) NOT NULL,
    [Descrizione] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_GruppiFiniture_Descrizione_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_GruppiFiniture] PRIMARY KEY NONCLUSTERED
    (
        [Codice]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
