CREATE TABLE Users(
    Id SERIAL PRIMARY KEY,
    NickName varchar(100) NOT NULL,
    Avatar bytea ,
    CredentialId int NOT NULL,
    RollId int NOT NULL,
    ClientId int,

    CONSTRAINT fk_CredentialId 
        FOREIGN KEY(CredentialId)
            REFERENCES Credentials(Id)
            ON DELETE CASCADE,
    
    CONSTRAINT fk_RoleId
        FOREIGN KEY(RollId)
            REFERENCES Rolls(Id),

    CONSTRAINT fk_ClientId 
        FOREIGN KEY(ClientId)
            REFERENCES Clients(Id)
            ON DELETE CASCADE
);

INSERT INTO Users (
        NickName,
        Avatar,
        CredentialId,
        RollId,
        ClientId
    )
VALUES ('AdminNickname', null, 1, 1, null),
    ('CreatorNickname', null, 2, 2, 1),
    ('ClientNickname', null, 3, 3, 2);