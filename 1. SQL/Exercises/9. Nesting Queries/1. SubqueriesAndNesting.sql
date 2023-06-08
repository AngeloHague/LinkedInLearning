-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Find all sales below the average total sales
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	total <
		(
			SELECT
				ROUND(AVG(total), 2) as  'Avg. Sales'
			FROM
				Invoice
		)
ORDER BY
	total DESC