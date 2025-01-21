IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ParamsIn]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ParamsIn] (
    [idparam] [smallint] NOT NULL,
    [CatProd] [varchar] (8) NOT NULL,
    CONSTRAINT [PK_TAG_DOORS_ParamsIn] PRIMARY KEY NONCLUSTERED
    (
        [idparam],
        [CatProd]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
