IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_PolIntelaDetail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_PolIntelaDetail] (
    [Item] [varchar] (21) NOT NULL,
    [Distinta] [varchar] (21) NOT NULL,
    [HDa] [float] NOT NULL,
    [HA] [float] NOT NULL,
    [LDa] [float] NOT NULL,
    [LA] [float] NOT NULL,
    CONSTRAINT [PK_TAG_DOORS_PolIntelaDetail] PRIMARY KEY NONCLUSTERED
    (
        [Item],
        [Distinta],
        [HDa],
        [HA],
        [LDa],
        [LA]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
