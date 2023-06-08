-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: How many invoices were billed after 2010-05-22 and have a total of less than $3.00?
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	DATE(InvoiceDate) > '2010-05-22'
	AND total < 3.00
ORDER BY
	InvoiceDate