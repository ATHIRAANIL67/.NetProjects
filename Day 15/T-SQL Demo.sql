BEGIN
	PRINT 'Hiiiiiii';
END;


declare @n1 int,@n2 int,@s int;
begin
	set @n1=10;
	set @n2=40;
	set @s=@n1+@n2;
	print @s;
end;

DECLARE @age INT;
DECLARE @firstName CHAR(10);
DECLARE @lastName CHAR(10);
SET @firstName='Siddharth';
SET @lastName='Malhotra';
SET @age=25;
PRINT @firstName + ', ' + @lastName;
PRINT @age;

-----CASE STATEMENT-----
DECLARE @t INT=-5 -- Try assigning 2, -5, 45
SELECT CASE
	WHEN @t>0 THEN
		CASE
			WHEN @t=1 THEN 'One'
			WHEN @t=2 THEN 'Two'
			ELSE 'not a Number required'
		END
	ELSE 'less than one'
END

-----USING LOOPING-----
DECLARE @counter INT
SET @counter=1
WHILE @counter <= 10
BEGIN
PRINT @counter
SET @counter=@counter+1
END