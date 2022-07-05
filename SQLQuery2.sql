SELECT ProductName, CategoryName
FROM Product p
	LEFT JOIN Category c ON p.CategoryId = c.Id
