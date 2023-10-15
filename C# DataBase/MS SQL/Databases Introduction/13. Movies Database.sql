CREATE DATABASE Movies;

USE Movies;

CREATE TABLE Directors(
 Id INT PRIMARY KEY IDENTITY,
 DirectorName NVARCHAR(150),
 Notes NVARCHAR(MAX)
)

CREATE TABLE Genres(
 Id INT PRIMARY KEY IDENTITY,
 GenreName NVARCHAR(150),
 Notes NVARCHAR(MAX)
)

CREATE TABLE Categories(
 Id INT PRIMARY KEY IDENTITY,
 CategoryName NVARCHAR(150),
 Notes NVARCHAR(MAX)
)

CREATE TABLE Movies(
 Id INT PRIMARY KEY IDENTITY,
 Title NVARCHAR(150),
 DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
 CopyrightYear DATETIME2,
 [LENGTH] NVARCHAR(100),
 GenreId INT FOREIGN KEY REFERENCES Genres(Id),
 CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
 Rating DECIMAL(5, 2),
 Notes NVARCHAR(MAX)
)

INSERT INTO Directors
VALUES
('dqqwdqwfqh', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw')


INSERT INTO Genres
VALUES
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw')


INSERT INTO Categories
VALUES
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw'),
('dqqwdqwfqw', 'fewcwqw')

INSERT INTO Movies
VALUES
('wfefwreg', 3, '12-12-2000', 123.10, 3, 5, 5.00, 'qfdWEFwef'),
('wfefwreg', 2, '12-12-2000', 123.10, 5, 1, 5.00, 'qfdWEFwef'),
('wfefwreg', 1, '12-12-2000', 123.10, 2, 2, 5.00, 'qfdWEFwef'),
('wfefwreg', 4, '12-12-2000', 123.10, 4, 3, 5.00, 'qfdWEFwef'),
('wfefwreg', 5, '12-12-2000', 123.10, 1, 4, 5.00, 'qfdWEFwef')