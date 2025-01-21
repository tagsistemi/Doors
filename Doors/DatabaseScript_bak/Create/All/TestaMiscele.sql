IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TestaMiscele]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TestaMiscele] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TestaMiscele_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Codice] [varchar] (12) NOT NULL,
    [Descrizione] [varchar] (50) NULL CONSTRAINT DF_TestaMiscele_Descrizione_00 DEFAULT (''),
    CONSTRAINT [PK_TestaMiscele] PRIMARY KEY NONCLUSTERED
    (
        [Codice]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
