CREATE TABLE dq.BatchJobTask
(
	[BatchID] INT NOT NULL,
	[JobID] INT NOT NULL,
	[JobTaskID] INT NOT NULL,
	[StartDate] DATETIME NOT NULL,
	[EndDate] DATETIME NULL,
	CONSTRAINT PK_BatchJobTask PRIMARY KEY ( BatchID, JobID, JobTaskID ),
	CONSTRAINT FK_BatchJobTask_Batch FOREIGN KEY ( BatchID ) REFERENCES dq.Batch ( ID ),
	CONSTRAINT FK_BatchJobTask_JobTask FOREIGN KEY ( JobID, JobTaskID ) REFERENCES dq.JobTask ( JobID, ID )
)
