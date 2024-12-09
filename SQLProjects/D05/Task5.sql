--Task5
--1.Use ITI DB:
--Create a view that displays the student's full name, course name if the student has a grade more
--SOLUTION:
--1-He needs to display Student full name so it related to student table 
--full name includes student first name and last name so I concatenated them 
--2-display course name and it related to course table 
--3-there is no relation between student and course so I make a bridge between 2 tables with stud_course table 
--that includes the 2 forign keys relation to student table and course table so I made 2 inner joins
--4-he needs a condition that Grade is more than 50 degree so I made where condtion 
--5-he needs to create view so I made the previous content in the scope of view 
USE ITI;
CREATE VIEW VstudData 
AS
	SELECT S.St_Fname +' '+S.St_Lname as FullName , C.Crs_Name as CourseName
FROM 
	Student S
INNER JOIN
	Stud_Course SC
ON 
	S.St_Id=SC.St_Id
INNER JOIN 
	Course C
ON 
	C.Crs_Id=SC.Crs_Id
WHERE SC.Grade>50

SELECT *FROM VstudData;

--2.Create an Encrypted view that displays Instructor names and the topics they teach.
--Solution:
--1-He needs to create view with encryption so I've made the container of view 
--2-He needs to display the Instructor names and it is related to instructor table 
--3-He needs to display also the topics that relate to instructor which is in topic table 
--but there is no relation between instructors and topics so we need multiple bridges 
--so I've made relations (inner join) beteen instructor and instructor course then 
-- made relation between them and course then made relation between them and Topic 
CREATE VIEW VInsData
WITH ENCRYPTION 
AS
	SELECT 
		I.Ins_Name as InstructorName,T.Top_Name as Topics
		
	FROM 
		Instructor I 
	INNER JOIN 
		Ins_Course IC
	ON 
		I.Ins_Id =IC.Ins_Id
	INNER JOIN 
		Course C
	ON 
		C.Crs_Id=IC.Crs_Id
	INNER JOIN 
		Topic T
	ON 
		T.Top_Id=C.Top_Id

SELECT * FROM VInsData;
