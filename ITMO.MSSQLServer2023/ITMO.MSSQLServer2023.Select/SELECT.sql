--1. Отображает все столбцы в таблице Person
SELECT *
FROM [Person].[Person];
GO

--2. Отображает только выбранные столбцы в таблице Person
SELECT Title, FirstName, LastName, MiddleName
FROM [Person].[Person];
GO

--3. Получение конкретных строк в таблице
SELECT ProductNumber, Name, ListPrice, Color, Size, Weight
FROM [Production].[Product]
WHERE ListPrice < $100;
GO

SELECT ProductNumber, Name, ListPrice, Color, Size, Weight
FROM [Production].[Product]
WHERE ListPrice < $100
AND ProductNumber LIKE 'SO%';
GO

--4. Фильтрация данных с помощью сравнения строк
SELECT ProductNumber, Name, ListPrice, Color, Size, Weight
FROM [Production].[Product]
WHERE ListPrice < $100
AND (ProductNumber LIKE 'SO%' OR ProductNumber LIKE 'TG%');
GO

--5. Получение диапазона значений
SELECT ProductNumber, Name, ListPrice, Color, Size, Weight
FROM [Production].[Product]
WHERE ProductNumber LIKE 'SO%' 
	OR ((ListPrice BETWEEN $50 AND $180) AND ProductNumber LIKE 'TG%');
GO

--6. Получение списка значений
SELECT ProductNumber, Name, ListPrice, Color, Size, Weight
FROM [Production].[Product]
WHERE ProductNumber LIKE 'SO%' 
	OR ((ListPrice BETWEEN $50 AND $180) 
		AND ProductNumber LIKE 'TG%' 
		AND Size IN ('M', 'L'));
GO

--7. Работа со значениями NULL
SELECT ProductNumber, Name, Weight
FROM [Production].[Product]
WHERE ProductLine IS NULL;
GO

SELECT ProductNumber, Name, Weight,
ISNULL(ProductLine, 'NA')
FROM [Production].[Product];
GO

SELECT ProductNumber, Name, Weight,
ISNULL(ProductLine, 'NA') AS 'Product Line'
FROM [Production].[Product];
GO

SELECT ProductNumber, Name, COALESCE(CONVERT(NVARCHAR, Weight), SIZE, 'NA') AS Measurement,
ISNULL(ProductLine, 'NA') AS 'Product Line'
FROM [Production].[Product];
GO

-- 8. Сортировка данных
SELECT ProductNumber, Name, Class
FROM [Production].[Product]
ORDER BY Class;
GO

SELECT ProductNumber, Name, Class, ListPrice
FROM [Production].[Product]
ORDER BY Class, ListPrice DESC;
GO

--9. Устранение дублирования строк
SELECT DISTINCT Color
FROM [Production].[Product]
WHERE ProductNumber LIKE 'HL%';
GO

--10. Использование выражений
SELECT LastName + ',' + FirstName
FROM [Person].[Person];
GO

SELECT (LastName + ',' + FirstName) AS Contacts
FROM [Person].[Person];
GO

SELECT (LastName + ',' + FirstName) AS Contacts
FROM [Person].[Person]
WHERE SUBSTRING (LastName, 1, 3) = 'Mac';
GO

--11. Агрегатные функции 
SELECT AVG(VacationHours) AS 'AverageVacationHours',
	SUM(SickLeaveHours) AS 'TotalSickLeave Hours'
FROM [HumanResources].[Employee]
WHERE JobTitle LIKE '%Vice President%';
GO

SELECT COUNT(*)
FROM [HumanResources].[Employee];
GO

--12. Использование Агрегатных функций с NULL
SELECT COUNT(*)
FROM [Person].[Address]
WHERE ISNULL(AddressLine2, '0') = '0';
GO

SELECT COUNT(AddressLine2)
FROM [Person].[Address];
GO

SELECT COUNT (DISTINCT AddressLine2)
FROM [Person].[Address];
GO

--13. Подведение итогов
SELECT ProductID, AVG(DaysToManufacture) AS 'AvgDaysToManufacture'
FROM [Production].[Product]
GROUP BY ProductID;
GO

--14. Использование предложения GROUP BY
SELECT Color, AVG(ListPrice) AS 'AvgListPrice'
FROM [Production].[Product]
WHERE ProductNumber = 'FR-R72R-58'
GROUP BY Color;
GO

--15. Использование предложения HAVING
SELECT ProductID, AVG(OrderQty) AS 'AverageQuantity',
	SUM(LineTotal) AS 'Total' 
FROM [Sales].[SalesOrderDetail]
GROUP BY ProductID
HAVING SUM(LineTotal) > $1000000.00 AND AVG(OrderQty) < 3;
GO