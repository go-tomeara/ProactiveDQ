CREATE PROCEDURE dq.sp_ArchiveDataIssues

AS
	INSERT INTO dq.DataIssueArchive
	     ( StagingID
		 , TableID
		 , IssueID
		 , BatchID
		 , JobID
		 , JobTaskID
		 , SourceRowPK
		 , ColumnName
		 , [Value] )
	SELECT DI.[ID] AS 'StagingID'
	     , DI.TableID
		 , DI.IssueID
		 , DI.BatchID
		 , DI.JobID
		 , DI.JobTaskID		 
		 , DI.SourceRowPK
		 , DI.ColumnName
		 , DI.[Value]
	  FROM dq.[DataIssue] AS DI

