CREATE TABLE ClientCurces(
    Id SERIAL PRIMARY KEY,
    ClientId int not null,
    CurseId int not null,
    StartedAt date NOT NULL,
    EndAt date NOT NULL,

    CONSTRAINT fk_ClientId
        FOREIGN KEY (ClientId) 
            REFERENCES Clients(Id),
            
    CONSTRAINT fk_CurseId
        FOREIGN KEY (CurseId)
            REFERENCES Curses(Id)
);

INSERT INTO ClientCurces (
    ClientId,
    CurseId,
    StartedAt,
    EndAt
  )
VALUES (
    1,
    1,
    CURRENT_DATE,
    CURRENT_DATE + (SELECT Duration FROM Curses where Id = 1)
  ),
 (
    2,
    1,
    CURRENT_DATE,
    CURRENT_DATE + (SELECT Duration FROM Curses where Id = 1)
  );