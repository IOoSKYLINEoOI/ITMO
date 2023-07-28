ALTER TRIGGER TransactionDetails.trgInsTransactions
ON TransactionDetails.Transactions
AFTER INSERT
AS
UPDATE CustomerDetails.Customers
	SET CleareBalance = CleareBalance +
		ISNULL((SELECT CASE WHEN CreditType = 0
											THEN i.Amount * -1
							ELSE i.Amount
						END
FROM INSERTED AS i
JOIN TransactionDetails.TransactionTypes AS tt
	ON tt.TransactionTypesId = i.TransactionType
WHERE AffectCashBalance = 1 ), 0)
FROM CustomerDetails.Customers AS c
JOIN INSERTED AS i
	ON i.CustomerId = c.CustomerId;