
CREATE PROCEDURE productpricing AS
BEGIN 
SELECT Avg(prod_price) AS priceaverage
FROM products;
END;

create or alter procedure sp_PrintDate as
begin
select GETDATE();
end;

exec sp_PrintDate;

Create procedure ShowEmpData as
begin
select avg(salary) as [Average salary] from employee;
end;

exec ShowEmpData

create or alter procedure ShowEmpWithId(@empid int) as
begin
	select * from employee where EmpId=@empid;
end;

exec ShowEmpWithId 101

/*Write a procedure to pass empid as input and obtain salary of employee as output type variable*/
create or alter procedure sp_GetSalary
@empid int,@sal money output
as
begin
select @sal=salary from employee where EmpId=@empid;
end;
--instead of using exec command use gui:dbo.sp_GetSalary(right click)-->Execute Stored Procedure-->Pass only input value(eg;101)

use EmpDB
declare @empid int
declare @sal money
exec sp_GetSalary @empid=103,@sal=@sal output
select @sal;