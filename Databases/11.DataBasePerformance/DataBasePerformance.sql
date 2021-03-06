USE PerformanceDB
Go

CREATE TABLE Logs(
	ID int NOT NULL IDENTITY,
	LogText nvarchar(300) NOT NULL,
	LogDate datetime NOT NULL,
	CONSTRAINT PK_Logs_ID PRIMARY KEY (ID)
)

--This is very slow if you don't have SSD. Better make it 100 000
SET NOCOUNT ON
DECLARE @RowCount int = 10000000

WHILE @RowCount > 0
BEGIN
	DECLARE @Text nvarchar(100) = 'Log Text: ' + SUBSTRING(CONVERT(varchar(40), NEWID()),0,9)
	DECLARE @Date datetime = DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0)

	INSERT INTO Logs(LogText, LogDate) 
	VALUES(@Text, @Date)

	SET @RowCount = @RowCount - 1
END
SET NOCOUNT OFF
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT COUNT(*)
FROM Logs
WHERE YEAR(LogDate) > 1990
AND YEAR(LogDate) < 2010

CREATE INDEX IDX_Logs_LogDate ON Logs(LogDate)
GO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT COUNT(*)
FROM Logs
WHERE YEAR(LogDate) > 1990
AND YEAR(LogDate) < 2010

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT COUNT(*)
FROM Logs
WHERE LogText LIKE 'Log Text: 48%'


CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT COUNT(*)
FROM Logs
WHERE LogText LIKE '%F2'

CREATE INDEX IDX_Logs_LogText ON Logs(LogText)
GO

-- Not always works should be enabled on the server
CREATE FULLTEXT CATALOG LogsTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(LogText)
KEY INDEX PK_Logs_ID
ON LogsTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT COUNT(*) 
FROM Logs
WHERE CONTAINS(LogText, '%48%')

--MYSql--

CREATE TABLE Logs(
  id int NOT NULL AUTO_INCREMENT,
  LogText nvarchar(50),
  LogDate datetime,
  PRIMARY KEY (id, LogDate)
) PARTITION BY RANGE(YEAR(LogDate)) (
	PARTITION p0 VALUES LESS THAN (1990),
	PARTITION p2 VALUES LESS THAN (2000),
	PARTITION p3 VALUES LESS THAN (2010),
	PARTITION p4 VALUES LESS THAN MAXVALUE
);

DELIMITER $$
CREATE PROCEDURE PopulateLogs()
BEGIN
	DECLARE counter INT;
	SET counter = 1;

	WHILE counter <= 100000 DO 

		INSERT INTO Logs (LogText, LogDate) VALUES (MD5(counter), DATE_ADD('1980-01-01', INTERVAL 20950 * rand() DAY));

		SET counter = counter + 1;
	END WHILE;
END $$
DELIMITER ;

CALL PopulateLogs()

SELECT id FROM Logs WHERE YEAR(LogDate) < 2010
SELECT id FROM Logs WHERE YEAR(LogDate) > 2010
SELECT id FROM Logs WHERE YEAR(LogDate) < 1990
SELECT id FROM Logs WHERE YEAR(LogDate) > 1991 AND YEAR(LogDate) < 1999
SELECT id FROM Logs WHERE YEAR(LogDate) = 1995
