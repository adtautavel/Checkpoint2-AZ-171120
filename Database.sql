DROP DATABASE IF EXISTS DB_Checkpoint2
GO

CREATE DATABASE DB_Checkpoint2
GO

USE DB_Checkpoint2
CREATE TABLE Promotion (
	PromotionId INT PRIMARY KEY IDENTITY (1,1),
	PromotionLanguage VARCHAR (50) NOT NULL,
)
GO

CREATE TABLE Students (
	StudentId INT PRIMARY KEY IDENTITY (1,1),
	StudentFirstName VARCHAR (50) NOT NULL,
	StudentLastName VARCHAR (50) NOT NULL,
	FK_PromotionId INT FOREIGN KEY REFERENCES Promotion(PromotionId)
)
GO

CREATE TABLE Exams (
	ExamId INT PRIMARY KEY IDENTITY (1,1),
	ExamNote FLOAT NOT NULL,
	FK_StudentId INT FOREIGN KEY REFERENCES Students(StudentId)
)
GO

INSERT INTO Promotion (PromotionLanguage)
VALUES ('Euskera', 'Occita')
GO

INSERT INTO Students (StudentFirstName, StudentLastName, FK_PromotionId)
VALUES
	('Amin','Kraillo', 1),
	('Papir', 'Drücker', 1),
	('Octo', 'Plasmen', 1),
	('Ruben', 'Delacruz', 1),
	('Ulrich', 'Nichtarm', 1),
	('Johnny', 'Begoud', 2),
	('Manco', 'Capac', 2),
	('Jordi', 'Pebrots', 2),
	('Lloque', 'Yupanqui', 2),
	('Igor', 'Drunkalov', 2);

INSERT INTO Exams (FK_StudentId, ExamNote)
VALUES
	(1, 12),
	(1, 13),
	(1, 14),
	(2, 15),
	(2, 16),
	(2, 17),
	(3, 18),
	(3, 19),
	(3, 20),
	(4, 11),
	(4, 13),
	(4, 16),
	(5, 10),
	(5, 13),
	(5, 15),
	(6, 12),
	(6, 16),
	(6, 8),
	(7, 12),
	(7, 7),
	(7, 17),
	(8, 11),
	(8, 3),
	(8, 20),
	(9, 12),
	(9, 19),
	(9, 6),
	(10, 6),
	(10, 13),
	(10, 18);

