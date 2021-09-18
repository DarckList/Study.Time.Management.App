CREATE TABLE Clients(
    Id SERIAL PRIMARY KEY,
    Birthday date NOT NULL
);
INSERT INTO Clients (Birthday)
VALUES ('1997-02-27'),('1997-02-12');