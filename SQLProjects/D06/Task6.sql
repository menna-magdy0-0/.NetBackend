--Task6
--1.Create a stored procedure to show the number of students per department.[use ITI DB]
--Solution:
--I have created user defined stored procedure without any parameters 
--using count aggregate functio to count the number of students 
-- and made inner join to fet the relation between student and department
-- then called the procedure NStud to output the data
USE ITI;
CREATE PROC NStud
AS 
	SELECT COUNT(S.St_Id),D.Dept_Name
	FROM 
		Student S
	INNER JOIN 
		Department D
	ON D.Dept_Id=S.Dept_Id
	GROUP BY 
		D.Dept_Name 
NStud;
--Another Solution 
CREATE PROC GetNbyDep @Dep varchar(20)
AS
	SELECT COUNT(S.St_Id),@Dep
	FROM 
		Student S
	INNER JOIN 
		Department D
	ON D.Dept_Id=S.Dept_Id
	WHERE D.Dept_Name=@Dep
	GROUP BY D.Dept_Name

GetNbyDep 'Java'

--2.Create a stored procedure that calculates the area of a circle given its radius
--solution:
--I've created procedure that take radius parameter and with knowing the area 
--I've multiplied the PI with POWER of radius then displays it 
CREATE PROC Area @radius float
AS
	SELECT PI()*POWER(@radius,2)

Area 4;

--3.Create a stored procedure that calculates the sum of a given range of numbers
--solution:
-- I've created SumRange procedure 
-- he needs to calculate the sum of range between numbers
-- so I've made the procedure take 2 numbers and while loop
-- to sum the all numbers with in the range
CREATE PROC SumRange @x INT , @y INT
AS 
	DECLARE @Current INT=@x 
	DECLARE @sumV INT =0
	WHILE @Current<=@y
	begin
		SET @sumV+=@Current
		SET @Current+=1
	end 
	SELECT @sumV
SumRange 3,10;

--4.Create a trigger to prevent anyone from inserting a new record in the Department table
--( Display a message for user to tell him that he can’t insert a new record in that table )
--I've created a trigger on Department Table and use it instead of insert to prevent inserting 
--and add suser_name() function to make it special for all users 
--tried to test and noticed that its prevented from inserting 
CREATE TRIGGER T1
ON Department 
INSTEAD OF insert 
AS 
	SELECT SUSER_NAME()+ 'Can’t insert a new record in Department table'

INSERT INTO Department (Dept_Id,Dept_Name,Dept_Desc,Dept_Location,Dept_Manager)
VALUES (99,'.NET','Back end','Mansoura',2)
SELECT * FROM Department