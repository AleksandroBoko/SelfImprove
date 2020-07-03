CREATE TABLE [dbo].[Courses]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
	[Name] VARCHAR NOT NULL,
	[Description] VARCHAR NULL,
	[CategoryId] INT NULL,
	CONSTRAINT PK_Courses PRIMARY KEY ([Id]),
	CONSTRAINT FK_Courses_Categories FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
)
