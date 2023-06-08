-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: What are the average invoice totals by billing country and city?
*/

SELECT
	BillingCountry,
	BillingCity,
	ROUND(AVG(total), 2) as  'Avg. Sales'
FROM
	Invoice
GROUP BY
	BillingCountry,
	BillingCity
ORDER BY
	BillingCountry