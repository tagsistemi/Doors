IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_Aperture]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_Aperture] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_Aperture_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [CodiceAp] [varchar] (12) NOT NULL,
    [Descrizione] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Aperture_Descrizione_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_Aperture] PRIMARY KEY NONCLUSTERED
    (
        [CodiceAp]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
