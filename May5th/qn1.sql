CREATE PROCEDURE GetAllProducts
AS
BEGIN
	SELECT * FROM Products;
END;

EXEC GetAllProducts;

//executeforhigherendproducts

CREATE PROCEDURE HigherEndProducts
AS
BEGIN
	SELECT * FROM Products where Price>20000;
END;

EXEC HigherEndProducts;

//
CREATE PROCEDURE GetOrdersByProduct
	@ProductID INT
AS
BEGIN
	SELECT
		o.OrderID,
		o.Quantity,
		o.OrderDate,
		p.ProductName,
		p.Price
	FROM Orders o
	INNER JOIN Products p ON o.ProductID = p.ProductID
	WHERE o.ProductID = @ProductID;
END;

EXEC GetOrdersByProduct @ProductID = 1;