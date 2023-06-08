-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Get all invoices where the billing city starts with P or D.
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	BillingCity LIKE 'P%'
	OR BillingCity LIKE 'D%'
ORDER BY
	InvoiceDate