-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Upper and lowercase strings
*/

SELECT
	FirstName,
	LastName,
	Address,
	upper(FirstName) || ' ' || upper(LastName) AS 'Full Name in caps',
	lower(FirstName) || ' ' || lower(LastName) AS 'Full Name in lower',
	upper(FirstName) || ' ' || upper(LastName) || ' ' || Address  || ', ' || City || ', ' || State || ', ' || substr(PostalCode,1,5) AS 'Shortened Mailing Address'
FROM
	Customer	
WHERE
	Country='USA'