-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description:
	Problem: Why is there a financial discrepancy between 2011 and 2012?
	Challenge: #1
		a) How many transactions took place between 2011 and 2012?
		b) How much money did WSDA make in that period?

    Solution: Run Query for solution.
	To limit the output to JUST 2011, I added commented out HAVING clause
    
	Challenge: #2
        d) What is the average transaction amount for each year that WSDA Music has been in business?
    Solution: Without HAVING clause, this solution also satisfies the 2.d. criteria.
*/

SELECT
round(avg(i.total),2) AS 'Avg. Sale',
count(i.total) AS 'No. Transactions',
sum(i.total) AS 'Annual Income',
strftime('%Y',i.InvoiceDate) AS 'Year'
FROM
	Invoice AS i
GROUP BY
	strftime('%Y',i.InvoiceDate)
/*HAVING
	strftime('%Y',i.InvoiceDate) = '2011'
*/