-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: How us each individual city performing against the global avg. sales?
*/

SELECT
	BillingCity,
	ROUND(AVG(total),2) AS 'City Avg.',
	(SELECT ROUND(AVG(TOTAL),2) FROM Invoice) AS 'Global Avg.'
FROM
	Invoice
GROUP BY
	BillingCity
ORDER BY
	BillingCity