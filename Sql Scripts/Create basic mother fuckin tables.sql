/* **************************
	Basic Table Creation
****************************/

CREATE TABLE Boards (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(256),
	Description NVARCHAR(256),
	Active BIT
);

CREATE TABLE Lists (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	BoardId INT NOT NULL REFERENCES Boards(Id),
	Title NVARCHAR(256),
	Description NVARCHAR(MAX),
	Labels NVARCHAR(MAX),
	Archived BIT,
	Completed BIT
);

CREATE TABLE Cards (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ListId INT NOT NULL REFERENCES Lists(Id),
	Title NVARCHAR(256),
	Description NVARCHAR(MAX),
	Labels NVARCHAR(MAX),
	Archived BIT,
	Completed BIT
);

CREATE TABLE WorklogEvents (
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CardId INT NOT NULL REFERENCES Cards(Id),
	WorkStart DATETIME NOT NULL,
	WorkEnd DATETIME NOT NULL,
	FinalFurlong BIT,
	CreatedOn TIMESTAMP
)