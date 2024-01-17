
--CREATE TABLE users(
    --id SERIAL PRIMARY KEY,
    --name VARCHAR(255),
    --email VARCHAR(255) UNIQUE NOT NULL
-- );

--CREATE TABLE marks(
    --id SERIAL PRIMARY KEY,
    --user_id INT REFERENCES users(id),
    --math INT,
    --science INT,
    --English INT
-- );

--insert into users(name, email) values('Test', 'test@gmail.com');

--insert into marks(user_id, math, science, English) values(4, 80, 55, 45);

--select * from users;

--select * from users order by name;

--select DISTINCT math from users;

--select * from users where name = 'Bhavesh';

--select * from users limit 2;

--select *
    --from users
--order by name
--offset 1 rows
--fetch First 1 Row only;

--select * from users where name in ('Alex', 'Bhavesh');

--select * from users where math between 70 and 75;

--select * from users where name like '%a%'

--select * from users where name Is NULL

--select * from users where name Is not NULL;

--select * from users u where u.id = 1

--select u.name, u.email, m.math, m.science, m.english from users u
--inner join marks m
--on u.id = m.id

--select u.id, m.id, u.name, u.email, m.math, m.science, m.english
--from users u
--left join marks m
--on u.id = m.id

--select u.id, m.id, u.name, u.email, m.math, m.science, m.english
--from users u
--right join marks m
--on u.id = m.id

--select u.id, m.id, u.name, u.email, m.math, m.science, m.english
--from users u
--full outer join marks m
--on u.id = m.id

--select  sum(math)  from marks group by math
