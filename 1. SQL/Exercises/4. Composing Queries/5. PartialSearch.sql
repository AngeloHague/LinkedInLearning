-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Query all Customer Last Names beginning with G
*/

SELECT
	LastName
FROM
	Customer
WHERE
    LastName LIKE 'G%'
