CREATE TABLE Exercises(
    Id SERIAL PRIMARY KEY,
    Title varchar NOT NULL,
    Answer varchar NOT NULL,
    CursesId int NOT NULL,
    DopDataId int,

    CONSTRAINT fk_DopDataId 
        FOREIGN KEY(DopDataId) 
            REFERENCES DopDatas(Id)
            ON DELETE SET NULL,

    CONSTRAINT fk_CursesId 
        FOREIGN KEY(CursesId)
            REFERENCES Curses(Id)
            ON DELETE CASCADE
);

INSERT INTO Exercises (Title, Answer, CursesId, DopDataId)
VALUES (
    'What will be afte added 1 and 2',
    '3',
    1,
    null
  ),
  (
    'What will be afte subract 10 and 2',
    '8',
    1,
    null
  ),
  (
    'How mach cookies staed if we eat 5. In start we have 20',
    '15',
    1,
    null
  );