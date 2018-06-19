CREATE TABLE [Staging].[ExampleData] (
    [StagingRowID] INT IDENTITY(1,1) NOT NULL,
	SourceRowKey INT,
	SourceFKTypeValue VARCHAR(255),
	ExampleTypeID INT,
	SourceNumberValue DECIMAL(15,2)
);

