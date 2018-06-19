CREATE PROCEDURE val.ExampleTypeDataFK_Validator
	@BatchID INT
AS
BEGIN

	DECLARE @JobID AS INT;
	DECLARE @JobTaskID AS INT;
	 SELECT @JobID = J.ID FROM dq.Job AS J WHERE J.[Name] = 'Staging.SimulatedSSISRootPackage';
	 SELECT @JobTaskID = JT.ID FROM dq.JobTask AS JT WHERE JT.JobID = @JobID AND JT.[Name] = 'etl.SSISTask_ExampleTypeDataFK_Lookup';

	DECLARE @TableID AS INT;
	DECLARE @IssueID AS INT;
	 SELECT @TableID = T.ID FROM dq.[Table] AS T WHERE T.[Name] = 'ExampleData' AND T.[Schema] = 'Staging' AND T.[Database] = 'ProactiveDQ';
	 SELECT @IssueID = I.ID FROM dq.Issue AS I WHERE I.[Description] = 'FK_Value_Not_Found'

	DECLARE @BatchJobTaskStartDate AS DATETIME = GETDATE();
	 INSERT INTO dq.BatchJobTask ( BatchID, JobID, JobTaskID, StartDate ) VALUES ( @BatchID, @JobID, @JobTaskID, @BatchJobTaskStartDate );

	INSERT INTO dq.DataIssue
	     ( BatchID
		 , JobID
		 , JobTaskID
		 , TableID
		 , SourceRowPK
		 , ColumnName
		 , [Value]
		 , IssueID )
	SELECT @BatchID
		 , @JobID
		 , @JobTaskID
		 , @TableID
		 , SED.SourceRowKey
		 , 'SourceFKTypeValue' AS 'ColumnName'
		 , SED.SourceFKTypeValue
		 , @IssueID
	  FROM Staging.ExampleData AS SED
	 WHERE ExampleTypeID IS NULL;
END