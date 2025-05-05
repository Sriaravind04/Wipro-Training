CREATE PROCEDURE GetProductRevenue
	@ProductID INT
AS 
BEGIN
	SELECT o.OrderDate, (o.Quantity * p.Price) AS TotalRevenue
		FROM Orders o
		inner join Products p on o.ProductID = p.ProductID
		WHERE o.ProductID = @ProductID;
END

EXEC GetProductRevenue @ProductID = 1;