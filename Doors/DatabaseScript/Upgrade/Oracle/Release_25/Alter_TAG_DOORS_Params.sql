﻿ALTER TABLE "TAG_DOORS_PARAMS"
ADD "CATMERCPANNELILAV" VARCHAR2 (8) DEFAULT ('')
GO


UPDATE "TAG_DOORS_PARAMS" SET "CATMERCPANNELILAV" = '' WHERE "CATMERCPANNELILAV" IS NULL
GO


