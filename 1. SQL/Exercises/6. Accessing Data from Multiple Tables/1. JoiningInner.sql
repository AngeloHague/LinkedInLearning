-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Joining Tables

Inner Join: returns all matching records (excludes joining missing records e.g. a customerid that has been removed by account deletion)

Left (Outer) Join: returns all records from the left table with any matching records from the right table. adds null data to missing records from right table

Right (Outer) Join: Not supported in SQLite. Returns entire right table with any matching records from the left table.
*/

SELECT
	*
FROM
	Invoice
INNER JOIN
	Customer
ON
	Invoice.CustomerId = Customer.CustomerId
ORDER BY Customer.CustomerId