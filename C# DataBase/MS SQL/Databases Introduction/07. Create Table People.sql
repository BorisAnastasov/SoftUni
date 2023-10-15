CREATE TABLE People(
 Id INT PRIMARY KEY IDENTITY,
 [Name] NVARCHAR(200) NOT NULL,
 Picture IMAGE,
 Height DECIMAL(5,2) NULL,
 [Weight] DECIMAL(5,2) NULL,
 Gender CHAR(1) NOT NULL CHECK (Gender IN ('m', 'f')),
 BirthDate DATETIME2 NOT NULL,
 Biography NVARCHAR(MAX) NULL
)

INSERT INTO People([Name], Picture, Height, [Weight], Gender, BirthDate, Biography)
VALUES
('Ivan', NULL, 12.45, 60.00, 'm', '2000-04-23', 'qdjwiefnoIEWFNjwfoWEFNOnwf'),
('Martin', NULL, 15.40, 65.00, 'm', '2001-11-07', 'ejgnakosdvsdjfbnpov'),
('Kristian', NULL, 12.45, 60.00, 'm', '2001-09-18', 'qdjwiefnoIEWFNjwfoWEFNOnwf'),
('Alex', NULL, 12.45, 60.00, 'm', '2008-08-01', 'qdjwiefnoIEWFNjwfoWEFNOnwf'),
('Maria', NULL, 12.45, 60.00, 'f', '2006-07-10', 'qdjwiefnoIEWFNjwfoWEFNOnwf')