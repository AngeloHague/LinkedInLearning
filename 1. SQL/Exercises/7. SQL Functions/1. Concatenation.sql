-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Concatenate various string fields into a mailing address
*/

SELECT
	FirstName,
	LastName,
	Address,
	FirstName || ' ' || LastName || ' ' || Address  || ', ' || City || ', ' || State || ', ' || PostalCode AS 'Mailing Address'
FROM
	Customer	
WHERE
	Country='USA'