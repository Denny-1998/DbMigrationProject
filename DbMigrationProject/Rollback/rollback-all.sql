USE DbMigrationProject01;

IF OBJECT_ID('dbo.ProductRatings', 'U') IS NOT NULL
    DROP TABLE dbo.ProductRatings;

IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL
    DROP TABLE dbo.Products;

IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL
    DROP TABLE dbo.Categories;

USE master

DROP DATABASE DbMigrationProject01;
