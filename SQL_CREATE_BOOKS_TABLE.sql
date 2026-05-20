-- SQL Script to create or update the Books table
-- Run this script in your SQL Server to ensure the Books table exists with all required columns

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Books')
BEGIN
	CREATE TABLE [dbo].[Books] (
		[BookId] INT IDENTITY(1,1) PRIMARY KEY,
		[Title] NVARCHAR(MAX) NOT NULL,
		[Author] NVARCHAR(MAX),
		[Category] NVARCHAR(MAX),
		[Year] INT,
		[PdfFilePath] NVARCHAR(MAX)
	);
END
ELSE
BEGIN
	-- Check if PdfFilePath column exists, if not add it
	IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.Books') AND name = 'PdfFilePath')
	BEGIN
		ALTER TABLE [dbo].[Books]
		ADD [PdfFilePath] NVARCHAR(MAX);
	END
END
