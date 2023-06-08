-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: What are the average sales of cities beginning with L?
*/

SELECT
	BillingCity,
	ROUND(AVG(total), 2) as  'Avg. Sales'
FROM
	Invoice
WHERE
	BillingCity LIKE 'L%'
GROUP BY BillingCity
ORDER BY BillingCity