-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Creating a view to get the average total sales
*/

CREATE VIEW V_AvgTotal AS 
SELECT
	round(avg(total),2) AS 'Avg. Total'
FROM
	Invoice