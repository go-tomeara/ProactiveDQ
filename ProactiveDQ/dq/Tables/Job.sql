﻿CREATE TABLE dq.Job
(
	ID INT IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	CONSTRAINT PK_Job  PRIMARY KEY ( ID )
)