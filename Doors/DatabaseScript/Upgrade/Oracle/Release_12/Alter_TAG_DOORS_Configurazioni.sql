﻿ALTER TABLE "TAG_DOORS_CONFIGURAZIONI"
ADD "ROOTITEM" VARCHAR2 (21) DEFAULT ('')
GO


UPDATE "TAG_DOORS_CONFIGURAZIONI" SET "ROOTITEM" = '' WHERE "ROOTITEM" IS NULL
GO


