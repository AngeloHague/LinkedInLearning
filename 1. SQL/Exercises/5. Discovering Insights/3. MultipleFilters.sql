-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: How many invoices totaling between $1.98 or $3.96
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	total IN (1.98, 3.96)
ORDER BY
	InvoiceDate