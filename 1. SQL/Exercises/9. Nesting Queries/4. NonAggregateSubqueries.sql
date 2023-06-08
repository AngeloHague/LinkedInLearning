-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Provide all invoices after the date of a specific invoice
*/

SELECT
	InvoiceDate,
	BillingCity,
	BillingAddress
FROM
	Invoice
WHERE
	InvoiceDate > 
	(
		SELECT
			InvoiceDate
		FROM
			Invoice
		WHERE
			InvoiceId = 251
	)