
--local variables
declare @empid int;
--define the cursor
declare emp_cursor cursor
for
select empid from employee order by empid;
--open cursor(retrieve data)
open emp_cursor;
--perform the first fetch(get first row)
fetch next from emp_cursor into @empid
--close cursor
close emp_cursor
--and finally, remove it
deallocate emp_cursor;
select @empid as EmployeeID




---------------------*********************---------------------
DECLARE @employee_id INT
DECLARE @salary DECIMAL(10, 2)
DECLARE @grand_salary DECIMAL(10, 2) = 0
DECLARE employee_cursor CURSOR FOR
SELECT empid,salary FROM employee
OPEN employee_cursor
FETCH NEXT FROM employee_cursor INTO @employee_id, @salary
WHILE @@FETCH_STATUS = 0
BEGIN
  SET @grand_salary = @grand_salary + @salary
  FETCH NEXT FROM employee_cursor INTO @employee_id, @salary
  SELECT @employee_id AS EmployeeID, @salary AS Salary
END
CLOSE employee_cursor
DEALLOCATE employee_cursor
SELECT @grand_salary AS GrandSalary
---------------------*********************---------------------

---------------------*********************---------------------
DECLARE @sal DECIMAL(10, 2)
DECLARE @grandsalary DECIMAL(10, 2) = 0
DECLARE salary_cursor CURSOR FOR
SELECT salary FROM employee
OPEN salary_cursor
FETCH NEXT FROM salary_cursor INTO @sal
WHILE @@FETCH_STATUS = 0
BEGIN
  SET @grandsalary = @grandsalary + @sal
  FETCH NEXT FROM salary_cursor INTO @sal
END
CLOSE salary_cursor
DEALLOCATE salary_cursor
SELECT @grandsalary AS GrandSalary
---------------------*********************---------------------

