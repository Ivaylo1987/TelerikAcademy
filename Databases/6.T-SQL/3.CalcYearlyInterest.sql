USE StoreprocedureTests
GO

CREATE FUNCTION ufn_CalcSumWithInterest(@sum money, @yearlyInterest int, @months int)
  RETURNS money
AS
BEGIN
	RETURN @sum + ((@sum * @yearlyInterest / 1200) * @months)
END
GO

SELECT
	a.Blance AS [Initial Sum],
	dbo.ufn_CalcSumWithInterest(a.Blance, 10, 12) as [Total Amount]
FROM Accounts AS a