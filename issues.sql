CREATE TABLE issues 
(
	id INT PRIMARY KEY IDENTITY (1, 1),
	issue_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	contact VARCHAR(MAX) NULL,
	email VARCHAR(MAX) NULL,
	book_title VARCHAR NULL,
	author VARCHAR(MAX) NULL,
	image VARACHAR(MAX) NULL,
	issue_date DATE NULL,
	return_date DATE NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL,
);

-- SELECT data from table 
SELECT * FROM issue;

-- delete all data in table  == USE ONLY IN NECCEESSERY USE CASES!!!
DELETE FROM issues;