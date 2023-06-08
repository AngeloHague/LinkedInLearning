-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Using DML (Data Manipulation Language). Modifying (UPDATE) data.

NOTE: The WHERE clause is CRUCIAL or it will update EVERY record
*/

UPDATE
	Artist
SET Name = 'Damien Marley'
WHERE
	ArtistId = 276

