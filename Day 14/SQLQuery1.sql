insert into test values(101,'Ram Kumar');
insert into test values(102,'Ajay Kumar');
select * from test;


CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);

INSERT INTO Persons VALUES(101,'Athira','Anil','Karthika','Kottayam');

INSERT INTO Persons VALUES
(102,'Asha','P','Achyutham','Pallickathodu'),
(103,'Rini','John','Maduvakkara','PTA');

SELECT * FROM Persons;
select personid,firstname from persons where city='Kottayam';

select GetDate()

select 10+10

SELECT firstname,LastName FROM Persons WHERE LastName LIKE 'A%';
SELECT * FROM Persons ORDER BY LastName DESC;

create table employee(empid int primary key,empname varchar(50),age int, salary money);
insert into employee values
(101,'Athira',24,25000),
(102,'Aleena',23,26323),
(103,'Nabeela',24,21000),
(104,'Dhanya',22,17897);
select * from employee;
select count(empid) as count,salary from employee group by salary;