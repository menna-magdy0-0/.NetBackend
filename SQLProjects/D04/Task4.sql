USE Collage ;
-- 1.Select max two salaries in the instructor table.
SELECT TOP(2) Salary
FROM Instructors 
ORDER BY Salary DESC;
--2. Write a query to select the highest two salaries in Each 
--Department for instructors who have salaries. “using one of Ranking Functions”
SELECT * 
FROM ( SELECT *, ROW_NUMBER() OVER (PARTITION BY Dep_ID ORDER BY Salary DESC ) AS RN FROM Instructors) AS NewTable
WHERE RN <=2;
--3.Write a query to select a random student from each department. “using one of Ranking Functions
SELECT * FROM (SELECT *,ROW_NUMBER()OVER (PARTITION BY Dep_ID ORDER BY NEWID()) AS RN FROM Students) AS NewTable
WHERE RN=1;
--4.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
CREATE Function Range (@First INT , @Last INT)
returns @t table 
         (Value INT)
	AS
	BEGIN 
		DECLARE @Current INT =@First;
		WHILE @Current <=@Last
		BEGIN 
			INSERT INTO @t(Value)
			VALUES(@Current);
			SET @Current+=1;
		END
		RETURN;
	END;
SELECT * FROM Range (2,10);

--5.Create a table-valued function that takes Student No and returns Department Name with Student full name.
CREATE Function GetData(@S_ID INT)
returns table
as 
return
(
	SELECT D.Name as DeptName , S.FName+' '+S.LName as FullName 
	FROM 
		Students S
	INNER JOIN 
		Departments D 
	ON 
		S.Dep_id=D.Dep_ID 
	WHERE 
		Stud_ID=@S_ID);
SELECT * FROM dbo.GetData(8);
--6.Create a function that takes an integer which represents the format of the Manager hiring date and displays department name, Manager Name and hiring date with this format.
CREATE FUNCTION DispData(@Format INT)
returns @t table
	(
		Dept_Name varchar(20),
		ManagerName varchar(20),
		HiringDate VARCHAR(20)
	)
AS
	BEGIN
		INSERT INTO @t (Dept_Name, ManagerName, HiringDate)
		SELECT 
			D.Name AS Dept_Name ,
			I.Name as ManagerName ,
			FORMAT(D.Hiring_Date ,CASE 
            WHEN @Format = 1 THEN 'MM/dd/yyyy' 
            WHEN @Format = 2 THEN 'dd-MM-yyyy' 
            WHEN @Format = 3 THEN 'yyyy.MM.dd' 
            ELSE 'yyyy-MM-dd'
			END)as HiringDate
			FROM 
				Departments D
			INNER JOIN 
				Instructors I
			ON 
				I.Ins_ID=D.Ins_ID
		return;
	end;

SELECT * FROM DispData(2);
--7.Create multi-statement table-valued function that takes a string If string='first name' returns student first name
CREATE FUNCTION StudentData(@string VARCHAR(20))
returns @t table
	(
		STUD_Name VARCHAR(20)
	)
AS
	BEGIN
		if @string='First Name'
			insert into @t
			select FName from Students 
		return;
	end;

select * from StudentData('First Name');
