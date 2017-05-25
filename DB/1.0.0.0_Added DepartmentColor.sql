USE HR

GO
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Department' AND COLUMN_NAME = 'Colour')
BEGIN
	ALTER TABLE Department
	DROP COLUMN Colour
END

GO
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Department' AND COLUMN_NAME = 'Theme')
BEGIN
	ALTER TABLE Department
	DROP COLUMN Theme
END

GO
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Department' AND COLUMN_NAME = 'ColourId')
BEGIN
	ALTER TABLE Department
	ADD ColourId int FOREIGN KEY REFERENCES Colour(ColourId)
END

-----------------   Once you have data in the ColourId columns change column to not null