-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: What are the average invoice totals by city?
*/

SELECT
	BillingCity,
	ROUND(AVG(total), 2) as  'Avg. Sales'
FROM
	Invoice
GROUP BY BillingCity