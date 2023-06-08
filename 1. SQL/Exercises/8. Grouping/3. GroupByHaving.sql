-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: What are the average total sales, per city, greater than $5?
*/

SELECT
	BillingCity,
	ROUND(AVG(total), 2) as  'Avg. Sales'
FROM
	Invoice
GROUP BY
	BillingCity
HAVING
	avg(total) > 5.00
ORDER BY
	BillingCity