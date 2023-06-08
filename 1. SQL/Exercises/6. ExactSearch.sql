-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Query all Tracks where Composer is unavailable
*/

SELECT
	Name
FROM
	Track
WHERE
	Composer = 'unavailable'
