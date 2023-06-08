-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: In SQLite, views cannot be modified. Simply drop (delete) the view, then recreate it as desired.
*/

DROP VIEW "main"."V_AvgTotal";
CREATE VIEW V_AvgTotal AS 
SELECT
	round(avg(total),2) AS 'Avg. Total'
FROM
	Invoice