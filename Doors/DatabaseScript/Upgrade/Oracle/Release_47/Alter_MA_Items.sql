﻿ALTER TABLE "MA_ITEMS"
ADD "DOORSSPPROFINTTELAIO" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_ITEMS" SET "DOORSSPPROFINTTELAIO" = 0 WHERE "DOORSSPPROFINTTELAIO" IS NULL
GO


ALTER TABLE "MA_ITEMS"
ADD "DOORSSPPROFESTTELAIO" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_ITEMS" SET "DOORSSPPROFESTTELAIO" = 0 WHERE "DOORSSPPROFESTTELAIO" IS NULL
GO


