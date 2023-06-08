-- SQL Essential Training

/*
Written By: Angelo Hague
Date: Thu 8th Jun 2023
Description: Which Tracks are not selling?
*/
SELECT
	TrackId,
	Composer,
	Name
FROM
	Track
WHERE
	TrackId NOT IN
	(
		SELECT
			DISTINCT TrackId
		FROM
			InvoiceLine
		ORDER BY
			TrackId
	)