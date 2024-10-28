IF DB_ID('DbMigrationProject01') IS NULL
BEGIN
    CREATE DATABASE DbMigrationProject01;
END
GO

USE DbMigrationProject01;
GO

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL
);
