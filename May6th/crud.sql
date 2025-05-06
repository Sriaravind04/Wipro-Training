CREATE TABLE Books (
	BookID INT PRIMARY KEY,
	Title VARCHAR(100),
	Author VARCHAR(100),
	Genre VARCHAR(50),
	Price DECIMAL(8,2),
	PublishedYear INT
);

INSERT INTO Books (BookID, Title, Author, Genre, Price, PublishedYear)
VALUES
(1,'Atomic Habits', 'James Clear', 'Self-help', 499.00,2018),
(2,'The Alchemist', 'Paulo Coelho', 'Fiction', 299.00,1993),
(3,'Clean Code', 'Robert C.Martin','Programming',799.00,2008),
(4,'Sapiens','Yuval Noah Harari','History',599.00,2015);

UPDATE Books 
SET Price = 399
WHERE BookID = 2;

DELETE FROM books
WHERE Price <400;