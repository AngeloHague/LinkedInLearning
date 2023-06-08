-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: 
	Problem: Why is there a financial discrepancy between 2011 and 2012?
	Challenge: #3
		a) Get a list of employees who exceeded the avg. transaction amount that year
        b) Create Commision Payout Column that displays each employee's commision based on 15% of sales transactions
        c) Which employee made the highest commission?
*/

SELECT
	v.EmployeeId,
	v.[Employee Forename],
	v.[Employee Surname],
	sum(v.[No. Sales Above Avg.]) as [Total Sales Above Avg.],
	sum((SELECT v.[Total Amount]
		FROM V_2011_Sales
		WHERE [SupportRepId] = v.EmployeeId )
	) as [Total Sales],
	round(sum((SELECT v.[Total Amount]
		FROM V_2011_Sales
		WHERE [SupportRepId] = v.EmployeeId )
	) * 0.15, 2) as [Commision]
FROM V_2011_Sales AS v
GROUP BY
	v.EmployeeId
ORDER BY
	[Commision] DESC