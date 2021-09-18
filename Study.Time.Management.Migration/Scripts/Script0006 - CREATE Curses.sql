CREATE TABLE Curses(
    Id SERIAL PRIMARY KEY,
    Title VARCHAR NOT NULL,
    CreatedAt date NOT NULL,
    Duration int NOT NULL,
    Description VARCHAR NOT NULL,
    Price decimal (18, 2) NOT NULL,
    CategoryId int NOT NULL,
    CreatorId int,

    CONSTRAINT fk_CategoryId
        FOREIGN KEY (CategoryId)
            REFERENCES Categories(Id),
    
    CONSTRAINT fk_CreatorId
        FOREIGN KEY(CreatorId)
            REFERENCES Clients(Id)
);

INSERT INTO Curses ( Title, CreatedAt, Duration, Description, Price, CategoryId, CreatorId)
VALUES ('Simple numerics', CURRENT_DATE, 90, 'Som description about first courde', 124.25, 1,2);