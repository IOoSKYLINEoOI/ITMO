USE ApressFinancial
GO

SELECT * FROM CustomerDetails.Customers
GO

SELECT CustomerFirstName, CustomerLastName, CleareBalance
FROM CustomerDetails.Customers
GO

SELECT CustomerFirstName AS 'First Name', 
 CustomerLastName AS 'Last Name', 
 CleareBalance 'Balance'
FROM CustomerDetails.Customers
GO