﻿ALTER TABLE "TAG_DOORS_POLTELAIODETAIL"
ADD "LTELAIO" FLOAT (126) DEFAULT (0)
GO


UPDATE "TAG_DOORS_POLTELAIODETAIL" SET "LTELAIO" = 0 WHERE "LTELAIO" IS NULL
GO


