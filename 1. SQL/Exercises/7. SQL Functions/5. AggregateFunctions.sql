-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Find the Total, Average, Max, Min and No. of sales.
*/

SELECT
	SUM(total) AS 'Sales',
	AVG(total) as  'Avg. Sales',
	MAX(total) as  'Max. Sales',
	MIN(total) as  'Min. Sales',
	COUNT(*) as  'No. of Sales'
FROM
	Invoice