CREATE FUNCTION TransactionDetails.ufn_IntCalc
	(@InterestRate decimal(6,3)=10, @Amount decimal(18,5),
	@FromDate date, @ToDate date)
RETURNS decimal(18,5)
WITH EXECUTE AS CALLER
AS
BEGIN
	DECLARE @IntCalculated decimal(18,5)
	SELECT @IntCalculated = @Amount *
		(@InterestRate / 100.00) * ( DATEDIFF(d,@FromDate,@ToDate)/365.00)
	RETURN (ISNULL(@IntCalculated,0))
END;