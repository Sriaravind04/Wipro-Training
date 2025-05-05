CREATE TABLE Students (
StudentID INT PRIMARY KEY,
FirstName VARCHAR(50),
Marks INT,
DOB DATE
);

INSERT INTO Students (StudentID, FirstName, Marks, DOB)
VALUES
(1,'Amit', 92, '2003-05-10'),
(2,'Neha', 78, '2002-11-15'),
(3,'Rahul', 61, '2004-01-20'),
(4,'Sneha',49,'2003-09-01');