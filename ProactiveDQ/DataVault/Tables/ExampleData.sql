CREATE TABLE [DataVault].[ExampleData] (
    [ID] INT IDENTITY(1,1) NOT NULL, 
    [SourceRowKey] INT NOT NULL,
	[ExampleTypeID] INT NOT NULL,
	[SourceNumberValue] DECIMAL(15, 2) NOT NULL,
	CONSTRAINT FK_ExampleData_ExampleType FOREIGN KEY ( ExampleTypeID ) REFERENCES DataVault.ExampleType ( ID ),
	CONSTRAINT PK_ExampleData PRIMARY KEY ( ID )
);

