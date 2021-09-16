CREATE TABLE Categories(
    Id SERIAL PRIMARY KEY,
    Title VARCHAR (200) NOT NULL
);
INSERT INTO Categories (Title)
VALUES ('Mathmatic'),('phithics'), ('biology'),('geography'),('history'), ('astronomy'),('chemistry'),('algebra');
