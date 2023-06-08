-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: What are the average invoice totals greater than $5 for cities starting with B?
*/

SELECT
	BillingCity,
	ROUND(AVG(total), 2) as  'Avg. Sales'
FROM
	Invoice
WHERE
	BillingCity LIKE 'B%'
GROUP BY
	BillingCity
HAVING
	avg(total) > 5.00
ORDER BY
	BillingCity