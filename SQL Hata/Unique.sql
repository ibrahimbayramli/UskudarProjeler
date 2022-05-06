CREATE TABLE [dbo].[TBL_GUID]
(
[ID] [UNIQUEIDENTIFIER] DEFAULT (newsequentialid()),
[Value] [varchar](10) NULL
)

INSERT INTO TBL_GUID (Value) values('bekir')

SELECT * FROM TBL_GUID

CREATE TABLE [dbo].[TBL_GUID1]
(
[ID] [UNIQUEIDENTIFIER] DEFAULT (newid()),
[Value] [varchar](10) NULL
)

INSERT INTO TBL_GUID1 (Value) values('betül')

SELECT * FROM TBL_GUID1