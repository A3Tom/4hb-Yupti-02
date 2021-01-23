INSERT INTO Boards
	(Name, Description, Active)
VALUES
	('Test Boards	', 'This is first test board', 1)
;

INSERT INTO Lists
	(BoardId, Title, Description, Labels, Archived, Completed)
VALUES
	(1, 'List 1', 'A real OG', 'OG', 0, 0)
;

INSERT INTO Cards
	(ListId, Title, Description, Labels, Archived, Completed)
VALUES
	(1, 'Card 1', 'The first card to exist', 'First card, Hing, Frogs', 0, 0)
;

