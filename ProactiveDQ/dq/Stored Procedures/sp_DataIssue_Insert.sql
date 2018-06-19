
CREATE PROCEDURE dq.sp_DataIssue_Insert 
(
	  @BatchID INT	
	, @LoadDate DATETIME2
	, @JobName VARCHAR(255)
    , @JobTaskName AS VARCHAR(255)
	, @TableName AS VARCHAR(255)
	, @SourceRowPK AS VARCHAR(MAX)
	, @ColumnName VARCHAR(255)
	, @Value VARCHAR(MAX)
	, @Description VARCHAR(MAX)
)
AS
BEGIN
	DECLARE @IssueID AS INT;
	 SELECT @IssueID = ID FROM dq.Issue AS I WHERE I.[Description] = @Description;
	DECLARE @JobTaskID AS INT;
	 SELECT @JobTaskID = ID FROM dq.JobTask AS JT WHERE JT.[Name] = @JobTaskName;
	DECLARE @JobID AS INT;
	 SELECT @JobID = J.ID FROM dq.Job AS J WHERE J.[Name] = @JobName;
	DECLARE @TableID AS INT;
	 SELECT @TableID = T.ID FROM dq.[Table] AS T WHERE T.[Name] = @TableName;

	INSERT INTO dq.DataIssue 
			  ( BatchID
			  , JobID
			  , JobTaskID
			  , TableID
			  , SourceRowPK
			  , ColumnName
			  , [Value]
			  , IssueID )  
	   VALUES ( @BatchID
			  , @JobID
			  , @JobTaskID
			  , @TableID
			  , @SourceRowPK
			  , @ColumnName
			  , @Value
			  , @IssueID );
END