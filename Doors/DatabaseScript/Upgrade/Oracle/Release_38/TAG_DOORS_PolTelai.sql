﻿CREATE TABLE "TAG_DOORS_POLTELAI" (
    "TBGUID" CHAR(38) DEFAULT ('00000000-0000-0000-0000-000000000000'),
    "CODICE" VARCHAR2 (21) NOT NULL,
    "SPMURODA" FLOAT (126) DEFAULT (0),
    "SPMUROA" FLOAT (126) DEFAULT (0),
    "LTELAIO" FLOAT (126) DEFAULT (0),
    "TIPOTELAIO" VARCHAR2 (8) DEFAULT (''),
    "DESCRIZIONE" VARCHAR2 (64) DEFAULT (''),
    CONSTRAINT "PK_TAG_DOORS_POLTELAI" PRIMARY KEY
    (
        "CODICE"
    )
)
GO
