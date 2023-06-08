-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Nesting functions together, round the average sales to 2 decimals places
*/

SELECT
	SUM(total) AS 'Sales',
	ROUND(AVG(total), 2) as  'Avg. Sales',
	MAX(total) as  'Max. Sales',
	MIN(total) as  'Min. Sales',
	COUNT(*) as  'No. of Sales'
FROM
	Invoice