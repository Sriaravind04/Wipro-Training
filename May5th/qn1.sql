CREATE PROCEDURE GetAllProducts
AS
BEGIN
	SELECT * FROM Products;
END;

EXEC GetAllProducts;