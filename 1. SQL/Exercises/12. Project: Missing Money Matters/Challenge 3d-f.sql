-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: 
	Problem: Why is there a financial discrepancy between 2011 and 2012?
	Challenge: #3
		d) List the customers that the employee identified in the last question
        e) Which customer made the highest purchase?
        f) Do you see any suspicious purchases?
        g) Who would you conclude is the primary person of interest?

    Solution:
        Running the query Jane Peacock made a large sale of $1000.86 to "John Doeein"
*/

SELECT
	c.CustomerId,
	c.FirstName,
	c.LastName,
	i.InvoiceId,
	i.total,
	i.InvoiceDate,
	c.SupportRepId,
	e.FirstName,
	e.LastName
From
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
	c.SupportRepId = 3 AND strftime('%Y',i.InvoiceDate) = '2011'
ORDER BY
	total DESC