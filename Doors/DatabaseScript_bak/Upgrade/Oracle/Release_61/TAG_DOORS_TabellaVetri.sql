﻿CREATE TABLE "TAG_DOORS_TABELLAVETRI" (
    "TBGUID" CHAR(38) DEFAULT ('00000000-0000-0000-0000-000000000000'),
    "ITEM" VARCHAR2 (21) NOT NULL,
    "LESTERNOTELAIO" FLOAT (126) DEFAULT (0),
    "HESTERNOTELAIO" FLOAT (126) DEFAULT (0),
    CONSTRAINT "PK_TAG_DOORS_TABELLAVETRI" PRIMARY KEY
    (
        "ITEM"
    )
)
GO
