﻿ALTER TABLE "TAG_DOORS_CONFIGURAZIONIDETAIL"
ADD "EXPLOSIONLINE" NUMBER (6) DEFAULT (0)
GO


UPDATE "TAG_DOORS_CONFIGURAZIONIDETAIL" SET "EXPLOSIONLINE" = 0 WHERE "EXPLOSIONLINE" IS NULL
GO


