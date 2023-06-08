-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Query all Customer First Names, Last Names, and Email Addresses, limiting/refining results to 10
*/

SELECT
	FirstName AS [Customer First Name],
	LastName AS 'Customer Last Name',
	Email AS EMAIL
FROM
	Customer
LIMIT 10