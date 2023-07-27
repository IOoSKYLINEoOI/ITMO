USE tempdb
GO

SELECT CustomerId, CustomerFirstName,
	CustomerOtherInitials, CustomerLastName
INTO dbo.Customers
FROM ApressFinancial.CustomerDetails.Customers
GO

DELETE FROM dbo.Customers
WHERE CustomerId = 4
GO

TRUNCATE TABLE dbo.Customers
GO


