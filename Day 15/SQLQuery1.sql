select empname + 'is registered' as "Message" from employee;    /*CONCATENATING FIELDS -- USING ALIAS*/

select empid,empid+1001 'New EmpId' from employee;

select 'India', CHARINDEX('d','India') as 'Position in string';  /*CharIndex() Returns the position of a specified character
within a string*/

select REPLACE('abcdefgh','abcd','xxx');     /*Replace() Replaces characters within a string with other
specified characters*/

select DATEPART(WEEKDAY,GETDATE());

SELECT LEFT(empname,1),count(*) FROM employee GROUP BY LEFT(empname,1);     /*Left() Returns characters from the left of a string*/

select * from employee;

alter table employee add DeptId int;

ALTER TABLE employee
ADD CONSTRAINT FK_DeptId_Employee
FOREIGN KEY (DeptId) REFERENCES Dept(DeptId);   /*ADDING FOREIGN KEY*/

select 'Employee ' + employee.empname + ' works in ' + dept.deptname + ' Department.'
from dept,employee
where employee.deptId=dept.deptId;        /*JOINING TWO TABLES USING ',' AND 'WHERE'*/

SELECT 'Employee ' + employee.empname + ' works in ' + dept.deptname + ' Department.'
FROM dept JOIN employee
ON employee.deptId=dept.deptId;           /*JOINING TWO TABLES USING 'JOIN' AND 'ON'*/

SELECT DISTINCT deptid FROM employee;

SELECT 'Employee ' + employee.empname + ' works in ' + dept.deptname + ' Department.'
FROM dept RIGHT OUTER JOIN employee
ON employee.deptId=dept.deptId;  