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