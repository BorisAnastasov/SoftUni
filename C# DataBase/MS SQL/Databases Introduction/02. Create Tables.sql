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
