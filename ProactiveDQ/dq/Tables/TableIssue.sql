CREATE TABLE dq.TableIssue
(
	TableID INT NOT NULL,
	IssueID INT NOT NULL,
	CONSTRAINT PK_TableIssue PRIMARY KEY ( TableID, IssueID ),
	CONSTRAINT FK_TableIssue_Table FOREIGN KEY ( TableID ) REFERENCES dq.[Table] ( ID ),
	CONSTRAINT FK_TableIssue_Issue FOREIGN KEY ( IssueID ) REFERENCES dq.Issue ( ID )
)
