-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Target Sales Goal: They want as many customers to spend betweeen $7 and $15

Sales Categories
Baseline Purchase - $0.99 to 1.99
Low Purchase - $2 to 6.99
Target Purchase - $7 and 15
Top Performer - Above $15
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total,
	CASE
		WHEN total < 2.00 THEN 'Baseline Purchase'
		WHEN total BETWEEN 2.00 AND 6.99 THEN 'Low Purchase'
		WHEN total BETWEEN 7.00 AND 15.00 THEN 'Target Purchase'
		ELSE 'Top Performer'
	END AS PurchaseType
FROM
	Invoice
WHERE
	PurchaseType = 'Top Performer'
ORDER BY
	BillingCity