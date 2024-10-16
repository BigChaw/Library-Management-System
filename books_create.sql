CREATE TABLE books_create
(
	id INT PRIMARY KEY IDENTITY (1, 1),
	booktitle VARCHAR(MAX) NULL,
	author VARCHAR(MAX) NULL,
	published_date DATE NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL
);



