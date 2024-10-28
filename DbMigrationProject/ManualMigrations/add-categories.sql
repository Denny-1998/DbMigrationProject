USE DbMigrationProject01;
GO

CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255)
);

ALTER TABLE Products
ADD category_id INT;

ALTER TABLE Products
ADD CONSTRAINT FK_Products_Categories
FOREIGN KEY (category_id) REFERENCES Categories(Id);
