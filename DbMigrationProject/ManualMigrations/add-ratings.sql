USE DbMigrationProject01;

CREATE TABLE ProductRatings (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ProductId INT NOT NULL,
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),
    Review VARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ProductId) REFERENCES Products(Id) ON DELETE CASCADE
);
