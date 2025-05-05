CREATE PROCEDURE CheckProductExists
	@ProductID INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
		
			Print 'Product exists'
		
	ELSE
		
			Print 'Product not found'
		
END;


EXEC CheckProductExists @ProductID = 1;