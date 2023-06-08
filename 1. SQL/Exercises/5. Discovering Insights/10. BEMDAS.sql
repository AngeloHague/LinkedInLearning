-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Get all invoices that are greater than $1.98 from any cities whose name starts with P or D.

SQL follows BEMDAS, so without brackets in this query it will not execute as requested.

It would default to:
WHERE
	(total > 1.98 AND
	BillingCity LIKE 'P%')
	OR BillingCity LIKE 'D%'

BEMDAS: Brackets, Exponents, Multiplication/Division, Addition/Subtraction
*/

SELECT
	InvoiceDate,
	BillingAddress,
	BillingCity,
	total
FROM
	Invoice
WHERE
	total > 1.98 AND
	(BillingCity LIKE 'P%' OR BillingCity LIKE 'D%')
ORDER BY
	InvoiceDate