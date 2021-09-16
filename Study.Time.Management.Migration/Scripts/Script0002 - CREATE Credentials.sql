create table Credentials(
    Id SERIAL PRIMARY KEY,
    Password varchar (100) not null,
    Email varchar (100) not null
); 
INSERT INTO Credentials (Password, Email)
VALUES ('admin','admin@gmail.com'),('creator', 'creator@gmail.com'), ('client', 'client@gmail.com');

INSERT INTO Credentials (Password, Email)
select 
    md5(random()::text),
    CONCAT(md5(random()::text),'gmail.com')
from generate_series(1,100) s(i);