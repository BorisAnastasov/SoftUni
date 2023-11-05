
--1. One-To-One Relationship
CREATE TABLE Passports(
PassportID INT IDENTITY(101,1) PRIMARY KEY,
PassportNumber NVARCHAR(100)
)
CREATE TABLE Persons(
PersonID INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(100),
Salary FlOAT,
PassportID INT FOREIGN KEY REFERENCES Passports(PassportID)
)

INSERT INTO Passports(PassportNumber)
VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2');

INSERT INTO Persons
VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101);

--2. One-To-Many Relationship
CREATE TABLE Manufacturers(
ManufacturerID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100),
EstablishedOn DATETIME
)

CREATE TABLE Models(
ModelID INT IDENTITY(101,1) PRIMARY KEY,
[Name] NVARCHAR(50),
ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers
VALUES
('BMW','07/03/1916'),
('Tesla','01/01/2003'),
('Lada','01/05/1966');

INSERT INTO Models
VALUES
('X1', 1),
('i6', 1),
('Model S', 2),
('Model X', 2),
('Model 3', 2),
('Nova', 3);


--3. Many-To-Many Relationship
CREATE TABLE Exams(
ExamID INT IDENTITY(101,1) PRIMARY KEY,
[Name] NVARCHAR(100)
)

CREATE TABLE Students(
StudentID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(50),
)

CREATE TABLE StudentsExams(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
ExamID INT FOREIGN KEY REFERENCES Exams(ExamID) 
PRIMARY KEY (StudentID, ExamID)
)

INSERT INTO Exams
VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g');

INSERT INTO Students
VALUES
('Mila'),
('Toni'),
('Ron');

INSERT INTO StudentsExams
VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103);

--04. Self-Referencing
CREATE TABLE Teachers(
TeacherID INT IDENTITY(101,1) PRIMARY KEY,
[Name] NVARCHAR(100),
ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID) NULL 
)

INSERT INTO Teachers
VALUES
('John', NULL),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101);


--5. Online Store Database
CREATE DATABASE OnlineShop;
USE OnlineShop;

CREATE TABLE Cities(
CityID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100)
)

CREATE TABLE Customers(
CustomerID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100),
Birthday DATETIME,
CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders(
OrderID INT IDENTITY(1,1) PRIMARY KEY,
CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes(
ItemTypeID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100)
)

CREATE TABLE Items(
ItemID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100),
ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems(
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
ItemID INT FOREIGN KEY REFERENCES Items(ItemID)
PRIMARY KEY (OrderID, ItemID)
)

--06. University Database
CREATE TABLE Majors(
MajorID INT IDENTITY(1,1),
[Name] NVARCHAR(35),
CONSTRAINT PK_MajorID PRIMARY KEY (MajorID)
);

CREATE TABLE Students(
StudentID INT IDENTITY(1,1),
StudentNumber INT,
StudentName NVARCHAR(50),
MajorID INT,
CONSTRAINT PK_StudentID PRIMARY KEY (StudentID),
CONSTRAINT FK_MajorID_Students FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
);

CREATE TABLE Payments(
PaymentID INT IDENTITY(1,1),
PaymentDate DATE,
PaymentAmount FLOAT,
StudentID INT,
CONSTRAINT PK_PaymentID PRIMARY KEY (PaymentID),
CONSTRAINT FK_StudentId_Payments FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Subjects(
SubjectID INT IDENTITY(1,1),
SubjectName NVArchar(25) NOT NULL,
CONSTRAINT PK_SubjectID PRIMARY KEY (SubjectID)
);

CREATE TABLE Agenda(
StudentID INT,
SubjectID INT,
CONSTRAINT FK_StudentID_Agenda FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
CONSTRAINT FK_SubjectID_Agenda FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
CONSTRAINT PK_Agenda_Subject_Student PRIMARY KEY (StudentID, SubjectID)
);

--9. *Peaks in Rila
USE Geography;
SELECT M.MountainRange, P.PeakName, P.Elevation
FROM Peaks AS P
JOIN Mountains AS M ON P.MountainId = M.Id	
WHERE M.MountainRange = 'Rila'
ORDER BY P.Elevation DESC
