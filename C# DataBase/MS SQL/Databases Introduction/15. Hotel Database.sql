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
