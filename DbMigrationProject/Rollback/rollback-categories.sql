USE DbMigrationProject01;

IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL 
BEGIN
    ALTER TABLE Products DROP CONSTRAINT FK_Products_Categories;
END

DROP TABLE IF EXISTS Categories;
