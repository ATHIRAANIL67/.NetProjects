/*CREATE TRIGGER emp_trigger ON employee
AFTER INSERT
AS
SELECT 'Row Created';*/

/*insert into employee(empid,empname,age,salary,DeptId)
values(108,'Tiji',26,20000,106);*/

CREATE TRIGGER emp_triggerdelete ON employee
after Delete
AS
SELECT 'Row Deleted';

delete from employee where empid=108;