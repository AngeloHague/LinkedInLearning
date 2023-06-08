-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description:
	Problem: Why is there a financial discrepancy between 2011 and 2012?
	Challenge: #2
		a) Get a list of customers who made purchases between 2011 and 2012.
        b) Get a list of customers, sales reps, and total transaction amounts for each customer between 2011 and 2012.
        c) How many transactions are above the average transaction amount during the same period?
	Solution:
		- Results stored in a view for next challenge.
		a) List is shown
		b) Additional Information included
		c) No. of sales above avg. per customer also included
*/
DROP VIEW  IF EXISTS V_2011_Sales;
CREATE VIEW V_2011_Sales AS
SELECT
	i.CustomerId,
	c.FirstName AS 'Customer Forename',
	c.LastName AS 'Customer Surname',
	count(i.customerid) AS 'No. Transactions',
	sum(i.total) AS 'Total Amount',
	c.SupportRepId,
	e.FirstName AS 'Employee Forename',
	e.LastName AS 'Employee Surname',
	e.EmployeeId,
	strftime('%Y',i.InvoiceDate) as 'Year',
	count((SELECT
			total
		FROM
			Invoice
		WHERE
			total > (SELECT avg(total) FROM Invoice WHERE strftime('%Y',InvoiceDate) IN( '2011','2012')) AND CustomerId=i.CustomerId))
			AS 'No. Sales Above Avg.'
FROM
	Invoice as i
LEFT JOIN
	Customer as c
ON
	i.CustomerId = c.CustomerId
LEFT JOIN
	Employee as e
ON
	c.SupportRepId = e.EmployeeId
WHERE
	strftime('%Y',i.InvoiceDate) IN( '2011','2012')
GROUP BY
	i.CustomerId
ORDER BY
	EmployeeId ASC, [No. Sales Above Avg.] DESC;

SELECT * FROM V_2011_Sales
