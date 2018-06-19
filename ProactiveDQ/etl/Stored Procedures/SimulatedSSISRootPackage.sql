
CREATE PROCEDURE [etl].[SimulatedSSISRootPackage]
	@BatchID INT
AS
BEGIN	 
	 EXECUTE etl.SSISTask_ExampleTypeDataFK_Lookup;
	 EXECUTE val.ExampleTypeDataFK_Validator @BatchID;
	 EXECUTE val.SourceNumberValueOutOfRange_Validator @BatchID;
	 EXECUTE etl.SSISTask_DVExampleData_Insert;
END