-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Get Length and shorten strings
*/

SELECT
	FirstName,
	LastName,
	Address,
	LENGTH(PostalCode),
	substr(PostalCode,1,5) as '5 Digit Postal Code',
	FirstName || ' ' || LastName || ' ' || Address  || ', ' || City || ', ' || State || ', ' || substr(PostalCode,1,5) AS 'Shortened Mailing Address'
FROM
	Customer	
WHERE
	Country='USA'