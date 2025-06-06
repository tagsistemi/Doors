﻿CREATE TABLE "TAG_DOORS_TABELLAPANNELLIR" (
    "FINITURA" VARCHAR2 (8) NOT NULL,
    "BATTUTA" VARCHAR2 (8) NOT NULL,
    "DACM" FLOAT (126) NOT NULL,
    "ACM" FLOAT (126) NOT NULL,
    "CMINTERNOBATTUTAPANNELLO" FLOAT (126) DEFAULT (0),
    "ISSTANDARD" CHAR (1) DEFAULT ('0'),
    "DIMENSIONE" NUMBER (10) DEFAULT (1543569408),
    "OPERATION1" VARCHAR2 (21) DEFAULT (''),
    "OPERATION2" VARCHAR2 (21) DEFAULT (''),
    "OPERATION3" VARCHAR2 (21) DEFAULT (''),
    "BATTUTACOMPONENTE" VARCHAR2 (8) DEFAULT (''),
    CONSTRAINT "PK_TAG_DOORS_TABELLAPANNELLIR" PRIMARY KEY
    (
        "FINITURA",
        "BATTUTA",
        "DACM",
        "ACM"
    )
)
GO
