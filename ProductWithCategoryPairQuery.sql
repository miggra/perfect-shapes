-- Создание таблиц по заданию
CREATE TABLE Products (
    ProductId BIGINT PRIMARY KEY,
    ProductName NVARCHAR(100)
);

CREATE TABLE Categories (
    CategoryId BIGINT PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

CREATE TABLE ProductCategories (
    ProductId BIGINT,
    CategoryId BIGINT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

-- Заполнение таблиц Тестовыми данными
INSERT INTO Products (ProductId, ProductName) VALUES
(1, 'Product A'),
(2, 'Product B'),
(3, 'Product C');

INSERT INTO Categories (CategoryId, CategoryName) VALUES
(1, 'Category 1'),
(2, 'Category 2'),
(3, 'Category 3');

INSERT INTO ProductCategories (ProductId, CategoryId) VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 1),
(3, 3);

-- Скрипт для получения пар продукт-категория
SELECT
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN 
    Categories c ON pc.CategoryId = c.CategoryId;