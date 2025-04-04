-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: 
	Problem: Why is there a financial discrepancy between 2011 and 2012?
	Challenge: #3
        f) Do you see any suspicious purchases?
	Solution:
		The suspicious purchase also has no billing information, nor does the customer have any address
*/

SELECT *
FROM Invoice
INNER JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
WHERE InvoiceId = 413