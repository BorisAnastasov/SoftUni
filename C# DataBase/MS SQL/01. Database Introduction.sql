
--1
CREATE DATABASE Minions;

--2
USE Minions;

CREATE TABLE Towns(
    Id INT PRIMARY KEY , 
    [Name] VARCHAR(100),
);

CREATE TABLE Minions(
  Id INT PRIMARY KEY , 
  [Name] VARCHAR(100),
  Age INT
);

--3
ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(id);

--4
INSERT INTO Towns
(Id, [Name])
VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO Minions
(Id, [Name], Age, TownId)
VALUES
(1, 'Kevin', 22, 1),
(2 ,'Bob', 15, 3),
(3, 'Steward', NULL, 2)

--5
DELETE FROM Minions;

--6
DROP TABLE Minions;
DROP TABLE Towns;

--7
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

--8
CREATE TABLE Users(
 Id INT PRIMARY KEY IDENTITY,
 Username VARCHAR(30) NOT NULL,
 [Password] VARCHAR(26) NOT NULL,
 ProfilePicture IMAGE,
 LastLoginTime DATETIME2,
 IsDeleted BIT
)

INSERT INTO Users
VALUES
('Boris1', '123456', null, '2000-04-23', 0),
('Boris2', '123456', null, '2000-04-23', 1),
('Boris3', '123456', null, '2000-04-23', 0),
('Boris4', '123456', null, '2000-04-23', 1),
('Boris5', '123456', null, '2000-04-23', 0)

--9
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC07E781B3CB;

--10
ALTER TABLE Users
ADD CONSTRAINT PK_IdAndUsername PRIMARY KEY (Id, Username);

--11
ALTER TABLE Users
ADD CONSTRAINT DF_LastLogin
DEFAULT GETDATE() FOR LastLoginTime;

--12
ALTER TABLE Users
DROP CONSTRAINT PK_IdAndUsername;

ALTER TABLE Users
ADD CONSTRAINT PK_Id PRIMARY KEY (Id);

ALTER TABLE Users
ADD CONSTRAINT PK_Username CHECK (LEN(Username)>= 3);

--13
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


--14

CREATE DATABASE CarRental;

USE CarRental;

CREATE TABLE Categories(
  Id INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(150),
  DailyRate DECIMAL(5, 2),
  WeeklyRate DECIMAL(5, 2),
  MonthRate DECIMAL(5, 2),
  WeekendRate DECIMAL(5, 2)
)

CREATE TABLE Cars(
  Id INT PRIMARY KEY IDENTITY,
  PlateNumber NVARCHAR(10),
  Manufacturer NVARCHAR(100),
  Model NVARCHAR(100),
  CarYear CHAR(4),
  CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
  Doors INT,
  Picture VARBINARY(MAX),
  Condition NVARCHAR(100),
  Available BIT
)

CREATE TABLE Employees(
  Id INT PRIMARY KEY IDENTITY,
  FirstName NVARCHAR(100),
  LastName NVARCHAR(100),
  Title NVARCHAR(100),
  Notes NVARCHAR(100)
  )

CREATE TABLE Costumers(
  Id INT PRIMARY KEY IDENTITY,
  DriverLicenceNumber NVARCHAR(100),
  FullName NVARCHAR(150),
  [Address] NVARCHAR(150),
  City NVARCHAR(100),
  ZIPCode NVARCHAR(100),
)

CREATE TABLE RentalOrders(
  Id INT PRIMARY KEY IDENTITY,
  EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
  CostumerId INT FOREIGN KEY REFERENCES Costumers(Id),
  CarId INT FOREIGN KEY REFERENCES Cars(Id),
  TankLevel INT,
  KilometrageStart INT,
  KilometrageEnd INT,
  TotalKilometrage INT,
  StartDate DATETIME2,
  EndDate DATETIME2,
  TotalDays INT,
  RateApplied BIT,
  TaxRate INT,
  OrderStatus NVARCHAR(50),
  Notes NVARCHAR(100)
)

INSERT INTO Categories
VALUES
('doiwfwqon', 21, 32, 12, 34),
('doiwfwqon', 21, 32, 12, 34),
('doiwfwqon', 21, 32, 12, 34)

INSERT INTO Cars
VALUES
('qwdqwd', 'qwdqwdq', 'qwdqwdq', '1997', 1, 4, null, 'qdqwdq', 1),
('qwdqwd', 'qwdqwdq', 'qwdqwdq', '1997', 1, 4, null, 'qdqwdq', 1),
('qwdqwd', 'qwdqwdq', 'qwdqwdq', '1997', 1, 4, null, 'qdqwdq', 1)

INSERT INTO Employees
VALUES
('fwfwq', 'wdqwqw', 'qwdqwdqw', 'dqwdq'),
('fwfwq', 'wdqwqw', 'qwdqwdqw', 'dqwdq'),
('fwfwq', 'wdqwqw', 'qwdqwdqw', 'dqwdq')

INSERT INTO Costumers
VALUES
('dqwddgwgwe', 'qdwdqdw', 'qdqwdqfqf', 'dqdqwdqw', 'dqqqweqwe'),
('dqwddgwgwe', 'qdwdqdw', 'qdqwdqfqf', 'dqdqwdqw', 'dqqqweqwe'),
('dqwddgwgwe', 'qdwdqdw', 'qdqwdqfqf', 'dqdqwdqw', 'dqqqweqwe')

INSERT INTO RentalOrders
VALUES
(1,1,2, 32, 23, 53, 23, '10-10-2000', '10-10-2002', 12, 1,34,'qwdqf', 'qdqwdqqdw'),
(1,1,2, 32, 23, 53, 23, '10-10-2000', '10-10-2002', 12, 1,34,'qwdqf', 'qdqwdqqdw'),
(1,1,2, 32, 23, 53, 23, '10-10-2000', '10-10-2002', 12, 1,34,'qwdqf', 'qdqwdqqdw')

--15

CREATE DATABASE Hotel;

USE Hotel;

CREATE TABLE Employees(
  Id INT PRIMARY KEY IDENTITY,
  FirstName NVARCHAR(100),
  LastName NVARCHAR(100),
  Title NVARCHAR(100),
  Notes NVARCHAR(100)
  )

CREATE TABLE Costumers(
 AccountNumber NVARCHAR(100) PRIMARY KEY,
 FirstName NVARCHAR(100),
 LastName NVARCHAR(100),
 PhoneNumber NVARCHAR(100),
 EmergencyName NVARCHAR(100),
 EmergencyNumber NVARCHAR(100),
 Notes NVARCHAR(100)
)

CREATE TABLE RoomStatus(
 RoomStatus NVARCHAR(100) PRIMARY KEY,
 Notes NVARCHAR(100)
)

CREATE TABLE RoomTypes(
 RoomType NVARCHAR(100) PRIMARY KEY,
 Notes NVARCHAR(100)
)

CREATE TABLE BedTypes(
 BedType NVARCHAR(100) PRIMARY KEY,
 Notes NVARCHAR(100)
)

CREATE TABLE Rooms(
 RoomNumber NVARCHAR(100) UNIQUE,
 RoomType NVARCHAR(100) FOREIGN KEY REFERENCES RoomTypes(RoomType),
 BedType NVARCHAR(100) FOREIGN KEY REFERENCES BedTypes(BedType),
 Rate FLOAT UNIQUE,
 RoomStatus NVARCHAR(100) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
 Notes NVARCHAR(100),
)

CREATE TABLE Payments(
 Id INT PRIMARY KEY IDENTITY,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
 PaymentDate DATETIME2,
 AccountNumber NVARCHAR(100) FOREIGN KEY REFERENCES Costumers(AccountNumber),
 FirstDateOccupied DATETIME2,
 LastDateOccupied DATETIME2,
 TotalDays INT,
 AmountCharged DECIMAL(5,2),
 TaxRate FLOAT,
 TaxAmount FLOAT,
 PaymentTotal FLOAT,
 Notes NVARCHAR(100)
)

CREATE TABLE Occupancies(
 Id INT PRIMARY KEY IDENTITY,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
 DateOccupied DATETIME2,
 AccountNumber NVARCHAR(100) FOREIGN KEY REFERENCES Costumers(AccountNumber),
 RoomNumber NVARCHAR(100) FOREIGN KEY REFERENCES Rooms(RoomNumber),
 RateApplied FLOAT FOREIGN KEY REFERENCES Rooms(Rate),
 PhoneCharge DECIMAL,
 Notes NVARCHAR(100)
) 

INSERT INTO Employees
VALUES
('fewfwe', 'dqwdqwdqd', 'qwdqwdqf', 'qfdqwdqd'),
('fewfwe', 'dqwdqwdqd', 'qwdqwdqf', 'qfdqwdqd'),
('fewfwe', 'dqwdqwdqd', 'qwdqwdqf', 'qfdqwdqd')

INSERT INTO Costumers
VALUES
('qwdqf3qwf1', 'qwedqwfqg', 'qwfqwfqwf', 'qwdqge2qfq', 'dqewqwfdqw', 'qwfddfewq', 'qwfqwd'),
('qwdqf3qwf2', 'qwedqwfqg', 'qwfqwfqwf', 'qwdqge2qfq', 'dqewqwfdqw', 'qwfddfewq', 'qwfqwd'),
('qwdqf3qwf3', 'qwedqwfqg', 'qwfqwfqwf', 'qwdqge2qfq', 'dqewqwfdqw', 'qwfddfewq', 'qwfqwd')

INSERT INTO RoomStatus
VALUES
('qfqwdq1', 'qwdqwfdqw'),
('qfqwdq2', 'qwdqwfdqw'),
('qfqwdq3', 'qwdqwfdqw')

INSERT INTO RoomTypes
VALUES
('qwfdwgwgf1', 'qwfdqfgqg'),
('qwfdwgwgf2', 'qwfdqfgqg'),
('qwfdwgwgf3', 'qwfdqfgqg')

INSERT INTO BedTypes
VALUES
('wefdfqwd1', 'qfwqwdqw'),
('wefdfqwd2', 'qfwqwdqw'),
('wefdfqwd3', 'qfwqwdqw')

INSERT INTO Rooms
VALUES
('qwdqwdwq1', NULL, NULL, 231, NULL, 'qdqwdw'),
('qwdqwdwq2', NULL, NULL, 223, NULL, 'qdqwdw'),
('qwdqwdw3q', NULL, NULL, 233, NULL, 'qdqwdw')

INSERT INTO Payments
VALUES
(1, '12-12-2000', NULL, '12-12-2000', '12-12-2000', 12, 23, 34, 45, 50,'dwqdqd'),
(1, '12-12-2000', NULL, '12-12-2000', '12-12-2000', 12, 23, 34, 45, 50,'dwqdqd'),
(1, '12-12-2000', NULL, '12-12-2000', '12-12-2000', 12, 23, 34, 45, 50,'dwqdqd')

INSERT INTO Occupancies
VALUES
(1, '12-12-2000', NULL, NULL, NULL, 23, 'qwdqwdqd'),
(1, '12-12-2000', NULL, NULL, NULL, 23, 'qwdqwdqd'),
(1, '12-12-2000', NULL, NULL, NULL, 23, 'qwdqwdqd')

--16
CREATE DATABASE SoftUni;

USE SoftUni;

CREATE TABLE Towns(
 Id INT PRIMARY KEY IDENTITY,
 [Name] NVARCHAR(150),
)

CREATE TABLE Addresses(
 Id INT PRIMARY KEY IDENTITY,
 AddressText NVARCHAR(150),
 TownId INT FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments (
 Id INT PRIMARY KEY IDENTITY,
 [Name] NVARCHAR(150),
)

CREATE TABLE Employees(
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(50),
 MiddleName NVARCHAR(50),
 LastName NVARCHAR(50),
 JobTitle NVARCHAR(100),
 DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
 HireDate DATETIME2,
 Salary DECIMAL,
 AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NULL
)

--17

BACKUP DATABASE SoftUni
TO DISK = 'softuni-backup.bak';

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni  
 FROM DISK = 'C:\Users\USER\softuni-backup.bak';

--18

INSERT INTO Towns
VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')


INSERT INTO Departments
VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

INSERT INTO Employees
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '02-01-2013', 3500.00,NULL),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '03-02-2004', 4000.00,NULL),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '08-28-2016', 525.25,NULL),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '12-09-2007', 3000.00,NULL),
('Peter', 'Pan', 'Pan', 'Intern', 3, '08-28-2016', 599.88,NULL)

--19

SELECT * FROM dbo.Towns;

SELECT * FROM Departments;

SELECT * FROM Employees;

--20
USE SoftUni;

SELECT * 
FROM Towns
ORDER BY [Name] ASC;

SELECT * 
FROM Departments
ORDER BY [Name] ASC;

SELECT * 
FROM Employees
ORDER BY [Salary] DESC;

--21
USE SoftUni;

SELECT [Name] 
FROM Towns
ORDER BY [Name] ASC;

SELECT [Name]
FROM Departments
ORDER BY [Name] ASC;

SELECT FirstName, LastName, JobTitle, Salary
FROM Employees
ORDER BY [Salary] DESC;

--22
USE SoftUni;

UPDATE Employees
SET 
Salary*=1.1;

SELECT Salary
FROM Employees;

--23
USE Hotel;

UPDATE Payments
SET
TaxRate*=0.97

SELECT TaxRate
FROM Payments

--24
USE Hotel;

DELETE 
FROM Occupancies;
