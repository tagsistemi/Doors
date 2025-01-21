IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[TAG_DOORS_Params]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[TAG_DOORS_Params] (
    [TBGuid] [uniqueidentifier] NULL CONSTRAINT DF_TAG_DOORS_Params_TBGuid_00 DEFAULT ('00000000-0000-0000-0000-000000000000'),
    [id] [smallint] NOT NULL,
    [Server] [varchar] (150) NULL CONSTRAINT DF_TAG_DOORS_Params_Server_00 DEFAULT (''),
    [Installazione] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_Installazione_00 DEFAULT (''),
    [Porta] [smallint] NULL CONSTRAINT DF_TAG_DOORS_Params_Porta_00 DEFAULT (0),
    [Company] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_Company_00 DEFAULT (''),
    [User] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_User_00 DEFAULT (''),
    [Password] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_Password_00 DEFAULT (''),
    [UtenteMago] [varchar] (50) NULL CONSTRAINT DF_TAG_DOORS_Params_UtenteMago_00 DEFAULT (''),
    [ProgConf] [int] NULL CONSTRAINT DF_TAG_DOORS_Params_ProgConf_00 DEFAULT (0),
    [CatMercPorte] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercPorte_00 DEFAULT (''),
    [CatMercTelai] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercTelai_00 DEFAULT (''),
    [CatMercImbotti] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercImbotti_00 DEFAULT (''),
    [CatMercPannelli] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercPannelli_00 DEFAULT (''),
    [CatMercAccessori] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercAccessori_00 DEFAULT (''),
    [CatMercPanneliLav] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercPanneliLav_00 DEFAULT (''),
    [OperazioneFuoriMisura] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Params_OperazioneFuoriMisura_00 DEFAULT (''),
    [OpFuoriMisuraPrimaDi] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuoriMisuraPrimaDi_00 DEFAULT (''),
    [OpFuoriMIsuraUltima] [char] (1) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuoriMIsuraUltima_00 DEFAULT ('0'),
    [OpFuorimisuraDopoDi] [varchar] (21) NULL CONSTRAINT DF_TAG_DOORS_Params_OpFuorimisuraDopoDi_00 DEFAULT (''),
    [CatMercTelaiLav] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercTelaiLav_00 DEFAULT (''),
    [CatMercCoprifiliLav] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercCoprifiliLav_00 DEFAULT (''),
    [CatMercCfAlettaLunga] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercCfAlettaLunga_00 DEFAULT (''),
    [CatMercFerramenta] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercFerramenta_00 DEFAULT (''),
    [CatMercVetri] [varchar] (8) NULL CONSTRAINT DF_TAG_DOORS_Params_CatMercVetri_00 DEFAULT (''),
    CONSTRAINT [PK_TAG_DOORS_Params] PRIMARY KEY NONCLUSTERED
    (
        [id]
    ) ON [PRIMARY]
) ON [PRIMARY]
END
GO
