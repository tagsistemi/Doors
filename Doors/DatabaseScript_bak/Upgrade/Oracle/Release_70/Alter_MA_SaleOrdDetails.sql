﻿ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSPREZZOBASE" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSPREZZOBASE" = 0 WHERE "DOORSPREZZOBASE" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC1PB" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC1PB" = 0 WHERE "DOORSSC1PB" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC2PB" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC2PB" = 0 WHERE "DOORSSC2PB" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC3PB" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC3PB" = 0 WHERE "DOORSSC3PB" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSMAGGIORAZIONE" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSMAGGIORAZIONE" = 0 WHERE "DOORSMAGGIORAZIONE" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC1MAGG" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC1MAGG" = 0 WHERE "DOORSSC1MAGG" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC2MAGG" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC2MAGG" = 0 WHERE "DOORSSC2MAGG" IS NULL
GO


ALTER TABLE "MA_SALEORDDETAILS"
ADD "DOORSSC3MAGG" FLOAT (126) DEFAULT (0)
GO


UPDATE "MA_SALEORDDETAILS" SET "DOORSSC3MAGG" = 0 WHERE "DOORSSC3MAGG" IS NULL
GO


