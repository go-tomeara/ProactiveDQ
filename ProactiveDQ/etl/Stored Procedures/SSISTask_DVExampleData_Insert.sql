
CREATE PROCEDURE etl.SSISTask_DVExampleData_Insert

AS
BEGIN
	INSERT INTO DataVault.ExampleData
	     ( SourceRowKey
		 , ExampleTypeID
		 , SourceNumberValue )
	SELECT SourceRowKey
	     , ExampleTypeID
		 , SourceNumberValue
	  FROM Staging.ExampleData AS ED
	 WHERE ExampleTypeID IS NOT NULL;
END