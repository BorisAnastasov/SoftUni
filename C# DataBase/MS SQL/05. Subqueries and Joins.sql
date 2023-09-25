--Part I – Queries for SoftUni Database
USE SoftUni;

--01. Employee Address
SELECT TOP(5) EmployeeID, JobTitle, a.AddressID, AddressText
FROM Employees AS e
INNER JOIN Addresses AS a 
ON e.AddressID = a.AddressID 
ORDER BY AddressID ASC

--02. Addresses with Towns
SELECT TOP 50 FirstName,LastName,t.[Name],AddressText
FROM Employees as e
INNER JOIN Addresses AS a
ON e.AddressID = a.AddressID
INNER JOIN Towns AS t
ON a.TownID = t.TownID
ORDER BY FirstName ASC, LastName

--03. Sales Employees
SELECT EmployeeID, FirstName, LastName, d.[Name] AS DepartmentName
FROM Employees AS e
INNER JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'

--04. Employee Departments
SELECT TOP(5) EmployeeID, FirstName, Salary, d.[Name] AS DepartmentName
FROM Employees AS e
INNER JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Engineering' AND Salary >15000
ORDER BY e.DepartmentID ASC

--05. Employees Without Projects
SELECT TOP(3) e.EmployeeID, e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS eP
ON eP.EmployeeID = e.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID ASC

--06. Employees Hired After
SELECT FirstName, LastName, HireDate, d.[Name]
FROM Employees AS e
INNER JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Finance' OR d.[Name] = 'Sales' AND HireDate > '1999-01-01'
ORDER BY HireDate ASC

--07. Employees With Project
SELECT TOP(5) e.EmployeeID, FirstName, p.[Name]
FROM Employees AS e
INNER JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
INNER JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE p.StartDate>'08-13-2002' AND p.EndDate IS NULL
ORDER BY e.EmployeeID ASC

--08. Employee 24
SELECT e.EmployeeID, FirstName,
CASE
WHEN YEAR(p.StartDate) >= 2005 THEN NULL
ELSE p.[Name]
END AS [ProjectName]
FROM Employees AS e
INNER JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
INNER JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24

--09. Employee Manager
SELECT e.EmployeeID, e.FirstName, e.ManagerID,
(SELECT FirstName
FROM Employees AS m
WHERE e.ManagerID = m.EmployeeID) AS ManagerName
FROM Employees AS e
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID ASC

--10. Employees Summary
SELECT TOP(50) e.EmployeeID, e.FirstName + ' ' + e.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS ManagerName, d.[Name] AS DepartmentName
FROM Employees AS e
	JOIN Employees AS m ON e.ManagerID = m.EmployeeID
	JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID;

--11. Min Average Salary
SELECT
 MIN(a.AverageSalary) AS MinAverageSalary
 FROM
 (
 SELECT e.DepartmentID,
 AVG(e.Salary) AS AverageSalary
 FROM Employees AS e
 GROUP BY e.DepartmentID
 ) AS a


--Part II – Queries for Geography Database
USE [Geography];

--12. Highest Peaks in Bulgaria
SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM Countries AS c
INNER JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
INNER JOIN Mountains AS m ON m.Id = mc.MountainId
INNER JOIN Peaks AS p ON p.MountainId = m.Id
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges
SELECT 
	mc.CountryCode,
	COUNT(m.MountainRange) AS MountainRanges
FROM MountainsCountries AS mc
	LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE mc.CountryCode IN ('BG', 'RU', 'US')
GROUP BY mc.CountryCode;

--14. Countries With or Without Rivers
SELECT TOP(5)
    c.CountryName,
	r.RiverName
FROM Countries AS c
     LEFT JOIN CountriesRivers AS cr 
	     ON cr.CountryCode = c.CountryCode
	 LEFT JOIN Rivers AS r 
	     ON r.Id = cr.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName ASC



--15. Continents and Currencies
SELECT 
[ContinentCode],
[CurrencyCode],
[CurrencyUsage]
FROM(
	SELECT *,
	DENSE_RANK() OVER(PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC) AS [CurrencyRank]
	FROM(
	    SELECT 
	    ContinentCode,
	    CurrencyCode,
	    COUNT(*) AS CurrencyUsage
	    FROM Countries 
	    GROUP BY ContinentCode,CurrencyCode
	    HAVING COUNT(*)>1
        ) AS [CurrencyRankUsage]
) AS [CurrencyUsageSubquery]
WHERE CurrencyRank = 1

--16. Countries Without Any Mountains
SELECT 
COUNT(*) AS [Count]
FROM Countries AS c
LEFT OUTER JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
WHERE mc.CountryCode IS NULL;

--17. Highest Peak and Longest River by Country
SELECT TOP(5)
c.CountryName,
MAX(p.Elevation) AS [HighestPeakElevation],
MAX(r.[Length]) AS [LongestRiverLength]
FROM Countries AS c
INNER JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
INNER JOIN Mountains AS m ON m.Id = mc.MountainId
INNER JOIN Peaks AS p ON p.MountainId = mc.MountainId
INNER JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
INNER JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY
[HighestPeakElevation] DESC,
[LongestRiverLength] DESC,
c.CountryName ASC

--18. Highest Peak Name and Elevation by Country
SELECT TOP(5)
Country,
[Highest Peak Name],
[Highest Peak Elevation],
Mountain
FROM
(
SELECT 
c.CountryName AS [Country],
ISNULL(p.PeakName, '(no highest peak)') AS [Highest Peak Name],
ISNULL(p.Elevation, '0') AS [Highest Peak Elevation],
ISNULL(m.MountainRange, '(no mountain)') AS [Mountain],
DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation) AS [Ranking]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
) AS [PEAKDATA]
WHERE Ranking = 1
ORDER BY Country ASC, [Highest Peak Elevation] ASC
