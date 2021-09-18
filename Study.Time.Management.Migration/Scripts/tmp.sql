INSERT INTO "Credentials" ("Password", "Email")
select 
    md5(random()::text),
    CONCAT(md5(random()::text),'gmail.com')
from generate_series(1,100) s(i);