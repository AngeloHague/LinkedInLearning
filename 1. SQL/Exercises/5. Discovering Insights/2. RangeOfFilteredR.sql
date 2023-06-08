-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: How many invoices totaling between $1.98 and $5.00
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	total BETWEEN 1.98 AND 5.00
ORDER BY
	InvoiceDate