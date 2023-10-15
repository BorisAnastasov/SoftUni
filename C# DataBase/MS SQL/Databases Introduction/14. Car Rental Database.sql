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
