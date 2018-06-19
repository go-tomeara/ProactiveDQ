CREATE TABLE [dq].[DataIssue] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [BatchID]     INT           NOT NULL,
    [JobID]       INT           NOT NULL,
    [JobTaskID]   INT           NOT NULL,
    [TableID]     INT           NOT NULL,
    [SourceRowPK] VARCHAR (MAX) NULL,
    [ColumnName]  VARCHAR (255) NOT NULL,
    [Value]       VARCHAR (MAX) NULL,
    [IssueID]     INT           NOT NULL,
    CONSTRAINT [PK_DataIssue] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DataIssue_BatchJobTask] FOREIGN KEY ([BatchID], [JobID], [JobTaskID]) REFERENCES [dq].[BatchJobTask] ([BatchID], [JobID], [JobTaskID]),
    CONSTRAINT [FK_DataIssue_TableIssue] FOREIGN KEY ([TableID], [IssueID]) REFERENCES [dq].[TableIssue] ([TableID], [IssueID])
);



