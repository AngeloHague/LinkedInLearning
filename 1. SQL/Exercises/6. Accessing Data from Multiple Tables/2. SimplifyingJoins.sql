-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Extracting desired columns from joins
*/

SELECT
	c.FirstName,
	c.LastName,
	i.InvoiceId,
	i.CustomerId,
	i.InvoiceDate,
	i.total
FROM
	Invoice AS i
INNER JOIN
	Customer AS c
ON
	i.CustomerId = c.CustomerId
ORDER BY c.CustomerId