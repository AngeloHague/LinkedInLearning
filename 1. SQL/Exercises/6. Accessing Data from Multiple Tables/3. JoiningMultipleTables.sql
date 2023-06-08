-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Join on multiple tables. What employees are responsible for the 10 highest invidivual sales?
*/

SELECT
	e.FirstName,
	e.LastName,
	e.EmployeeId,
	c.FirstName,
	c.LastName,
	i.CustomerId,
	i.total
FROM
	Invoice AS i
INNER JOIN
	Customer AS c
ON
	i.CustomerId = c.CustomerId
INNER JOIN
	Employee AS e
ON
	c.SupportRepId = e.EmployeeId
ORDER BY i.total DESC
LIMIT 10