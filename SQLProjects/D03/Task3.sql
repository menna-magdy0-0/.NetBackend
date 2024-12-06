USE Collage ;

SELECT * FROM Topics;
SELECT * FROM Courses;
SELECT * FROM Instructors;
SELECT * FROM Departments;
SELECT * FROM Students;
SELECT * FROM Stud_Course;
SELECT * FROM Course_Instructor;

--Task 01
--1.Insert two new rows into the Students table, associating each student with a specific department.

INSERT INTO Students(Stud_ID, FName, LName, Age,Address, Dep_id)
VALUES
(6,'Hasan','Ahmed',21,'Fayoum',1),
(7,'Martina','Shawki',20,'Dahab',2);
SELECT * FROM Students;

--2.Insert two new rows into the Instructors table, specifying their salaries and departments.
INSERT INTO Instructors (Ins_ID, Name,Address,Bouns, Salary, Hour_Rate, Dep_ID)
VALUES 
(6, 'Hazem Mohamed', 'Gharbia', 500, 4800, 50, 1),
(7, 'Khaled Hegazy', 'Mansoura', 700, 5200, 55, 2);
SELECT * FROM Instructors;

--3.Insert two new rows into the Courses table, specifying the course names and their durations.
INSERT INTO Courses(Course_ID,Name,Duration,Description,Topic_ID)
VALUES
(6, 'Web Development', 40, 'Full-stack basics', 1),
(7, 'Linear Algebra', 30, 'Matrix operations', 2);
SELECT * FROM Courses;

--Task 02
--1.Insert a new student into the Students table with your personal data, assigning the student to department number 20
INSERT INTO Departments(Dep_ID,Name,Hiring_Date,Ins_ID)
VALUES (20,'.NET Development','2024-12-04',3);
INSERT INTO Students (Stud_ID, FName, LName, Age, Address, Dep_id)
VALUES 
(8, 'Menna', 'Magdy', 23, 'Mahalla', 20);
SELECT * FROM Students;

--2.Insert a new instructor into the Instructors table with personal data of your friend, assigning
--the instructor to department number 20, setting the salary to 4500, and leaving the bonus
--column empty.
INSERT INTO Instructors(Ins_ID,Name,Address,Salary,Hour_Rate,Dep_ID)
VALUES (8,'Sara Nour','Mansoura',4500,48,20)
Select * FROM Instructors;
--3.Increase the salary of all instructors by 15% of their current values.
Select * FROM Instructors;
UPDATE Instructors
      SET Salary=Salary*0.15 +Salary
Select * FROM Instructors;
--4.Update the name of a specific course in the Courses table to "Code Wave".
UPDATE Courses
SET Name='Code Wave'
where Course_ID=6;