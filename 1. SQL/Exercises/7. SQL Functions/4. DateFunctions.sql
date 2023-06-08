-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Calculate the age of each employee
*/

SELECT
	FirstName,
	LastName,
	BirthDate,
	STRFTIME('%Y/%m/%d', Birthdate) AS 'Birthday - no time code',
	STRFTIME('%Y/%m/%d', 'now') - STRFTIME('%Y/%m/%d', Birthdate)  AS 'Age'
FROM
	Employee