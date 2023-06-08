-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: How many invoices were bileld to Brussels, Orlando or Paris?
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	BillingCity IN ('Brussels','Orlando','Paris')
ORDER BY
	InvoiceDate