﻿CREATE TABLE dq.JobTask
(
	JobID INT NOT NULL,
	ID INT IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	CONSTRAINT PK_JobTask PRIMARY KEY ( JobID, ID ),
	CONSTRAINT FK_JobTask_Job FOREIGN KEY (JobID ) REFERENCES dq.Job ( ID )	
)
