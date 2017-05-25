USE [HR]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS(SELECT 1  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Absence' AND COLUMN_NAME = 'ApprovalStateId')
BEGIN
	ALTER TABLE Absence
	ADD ApprovalStateId INT

	EXECUTE ('UPDATE ABSENCE SET ApprovalStateId = 1 WHERE ApprovalStateId IS NULL')

	ALTER TABLE Absence
	ALTER COLUMN ApprovalStateId INT NOT NULL

	ALTER TABLE Absence
	ADD FOREIGN KEY (ApprovalStateId) REFERENCES ApprovalState(ApprovalStateId)
END

IF EXISTS(SELECT 1  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Absence' AND COLUMN_NAME = 'AbsenceStatusId')
BEGIN
	
	ALTER TABLE Absence
	DROP CONSTRAINT FK_Absence_AbsenceStatus

	ALTER TABLE Absence
	DROP COLUMN AbsenceStatusId
END