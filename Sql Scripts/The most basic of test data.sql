INSERT INTO Boards
	(Name, Description, Active)
VALUES
	('Test Boards	', 'This is first test board', 1)
;

INSERT INTO Groupings
	(BoardId, Title, Description, Labels, Archived, Completed)
VALUES
	(1, 'Grouping 1', 'A real OG', 'OG', 0, 0)
;

INSERT INTO Cards
	(GroupingId, Title, Description, Labels, Archived, Completed)
VALUES
	(1, 'Card 1', 'The first card to exist', 'First card, Hing, Frogs', 0, 0)
;

