-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Provide all invoices on the dates of these following invoices: 251, 252, 254
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity
FROM
	Invoice
WHERE
	InvoiceDate IN
	(
		SELECT
			InvoiceDate
		FROM
			Invoice
		WHERE
			InvoiceId IN (251, 252, 254)
	)

