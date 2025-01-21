IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_ModelliConf]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_ModelliConf] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_ModelliConf_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [Modello] [varchar] (21) NOT NULL,
    [DescriModello] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_ModelliConf_DescriModello_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_ModelliConf] PRIMARY KEY NONCLUSTERED
    (
        [Modello]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
