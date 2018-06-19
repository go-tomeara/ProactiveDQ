CREATE PROCEDURE etl.SSISTask_ExampleTypeDataFK_Lookup

AS
BEGIN
	UPDATE Staging.ExampleData
	   SET ExampleTypeID = ID
	  FROM Staging.ExampleData AS ED
	  JOIN DataVault.ExampleType AS ETD
	    ON ED.SourceFKTypeValue = ETD.[TypeValue];
END;