CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);

insert into Persons values(101,'Anil','Athira','Karthika','Kottayam');


select * from Persons;
select FirstName from Persons where PersonID='101';

insert into Dept1 values(101,'Sales');
select * from Dept1;