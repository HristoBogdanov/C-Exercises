CREATE DATABASE Students_Zodiac_Signs

use Students_Zodiac_Signs

CREATE TABLE students(
id int PRIMARY KEY,
name nvarchar(30) not null,
birthdate date,
gender nvarchar(10) not null,
school_id int FOREIGN KEY
REFERENCES schools(id_school),
sign_id int FOREIGN KEY 
REFERENCES signs(id_sign)
)

CREATE TABLE schools(
id_school int PRIMARY KEY,
name_school nvarchar(50) not null
)

CREATE TABLE signs(
id_sign int PRIMARY KEY,
name_sign nvarchar(30) not null,
first_date date,
last_date date
)

insert schools (id_school, name_school)
values ​​(2400272, 'OU "Georgi Kirkov"'),
      (2400271, 'OU "Kulata"'),
      (2400276, 'OU "Nikola Vaptsarov"'),
      (2400265, 'PG "Ivan Hadjienov"'),
      (2400262, 'PPMG "Nikola Obreshkov"'),
      (2400263, 'UGS "St. St. Cyril and Methodius"'),
      (2400264, 'SU "Exarch Antim I"'),
	  (2400268, 'PGLPT')

	  go

insert signs (id_sign, name_sign, first_date, last_date)
values ​​(1, 'Aries', '2021-03-21', '2021-04-19'),
      (2, 'Taurus', '2021-04-20', '2021-05-20'),
      (3, 'Gemini', '2021-05-21', '2021-06-21'),
      (4, 'Cancer', '2021-06-22', '2021-07-22'),
      (5, 'Leo', '2021-07-23', '2021-08-22'),
      (6, 'Virgo', '2021-08-23', '2021-09-22'),
      (7, 'Libra', '2021-09-23', '2021-10-23'),
      (8, 'Scorpio', '2021-10-24', '2021-11-22'),
      (9, 'Sagittarius', '2021-11-23', '2021-12-21'),
      (10, 'Capricorn', '2021-12-22', '2021-01-19'),
      (11, 'Aquarius', '2021-01-20', '2021-02-18'),
      (12, 'Pisces', '2021-02-19', '2021-03-20')

insert students
VALUES (1, 'Anna Kukova', '2003-04-12', 'female', 2400271,1),
		(2, 'Angel Momov', '2003-03-17', 'male', 2400268,12),
		(3, 'Anastasia Nedyalkova', '2003-08-20', 'female', 2400276,5),
		(4, 'Alexander Kolev', '2003-09-03', 'male', 2400268,6),
		(5, 'Georgi Dimitrv', '2003-11-09', 'male', 2400272,8),
		(6, 'Dimitar Paunov', '2003-01-18', 'male', 2400276,10),
		(7, 'Donna Ivanova', '2003-08-29', 'female', 2400263,6),
		(8, 'Deyan Bozhkov', '2003-12-21', 'male', 2400265,9),
		(9, 'Elena Stefanova', '2003-03-01', 'female', 2400271,12),
		(10, 'Emanuela Velkova', '2003-07-07', 'female', 2400272,4),
		(11, 'Jean Stoev', '2003-08-13', 'male', 2400271,5),
		(12, 'Zhelyazko Dimov', '2003-09-12', 'female', 2400265,6),
		(13, 'Isabel Samarova', '2003-10-10', 'female', 2400271,7),
		(14, 'Ivan Draganov', '2003-11-11', 'male', 2400271,8),
		(15, 'Kaloyan Dechkov', '2003-05-19', 'male', 2400262,2),
		(16, 'Krassimira Koleva', '2003-02-20', 'female', 2400271,12),
		(17, 'Lyubomir Shterev', '2003-01-02', 'male', 2400262,10),
		(18, 'Maria Assenova', '2003-04-12', 'female', 2400265,1),
		(19, 'Maryana Katsarska', '2003-08-23', 'female', 2400276,6),
		(20, 'Presiana Bogdanova', '2003-09-30', 'female', 2400268,7),
		(21, 'Rositsa Kirilova', '2003-04-03', 'female', 2400264,1),
		(22, 'Rosen Plevneliev', '2003-06-08', 'male', 2400271,3),
		(23, 'Silvia Zemedelska', '2003-11-12', 'female', 2400272,8),
		(24, 'Stanislav Chorbanliev', '2003-01-16', 'male', 2400263,10),
		(25, 'Hristo Bogdanov', '2003-02-11', 'male', 2400265,11),
		(26, 'Tsvetelin Mutanov', '2003-09-06', 'male', 2400276,6),
		(27, 'Tsvetana Pironkova', '2003-07-22', 'female', 2400264,4),
		(28, 'Tsvetomir Tsanev', '2003-10-28', 'male', 2400265,8),
		(29, 'Chavdar Monev', '2003-10-21', 'male', 2400264,7),
		(30, 'Yanitsa Genevska', '2003-11-12', 'female', 2400263,8)
		
		
use Students_12v

SELECT name,name_school from schools
JOIN students 
ON students.school_id=schools.id_school
ORDER BY name DESC

go

SELECT name,name_school,gender FROM students
JOIN schools 
ON schools.id_school=students.school_id
WHERE (gender='male' AND name_school='OU "Georgi Kirkov"')

go

SELECT name,id_sign,name_sign FROM students
JOIN signs 
ON signs.id_sign=students.sign_id
WHERE (sign_id=3 OR sign_id=4 OR sign_id=5)

go

SELECT name,name_sign FROM students
JOIN signs 
ON signs.id_sign=students.sign_id
GROUP BY name_sign,name

go

SELECT name,name_sign FROM students
JOIN signs
ON signs.id_sign=students.sign_id
WHERE(name_sign='Aquarius'OR name_sign='Pisces')
ORDER BY name

go

SELECT name,name_school FROM students
JOIN schools
ON students.school_id=schools.id_school
GROUP BY name_school,name

go

SELECT name,name_school,name_sign FROM students
JOIN schools
ON students.school_id=schools.id_school
JOIN signs
ON students.sign_id=signs.id_sign
WHERE (name_school='OU "Nikola Vaptsarov"' OR name_school='SU "Exarch Antim I"' OR sign_id=9) 

go

SELECT name,name_school,name_sign FROM students
JOIN schools
ON students.school_id=schools.id_school
JOIN signs
ON students.sign_id=signs.id_sign
WHERE (name_school='PGLPT' OR sign_id=5 OR sign_id=6) 

go

SELECT name,birthdate,name_sign FROM students
JOIN signs
ON signs.id_sign=students.sign_id
WHERE (sign_id>=2 AND sign_id<=6)

go

SELECT name,birthdate,name_sign FROM students
JOIN signs
ON signs.id_sign=students.sign_id
WHERE (sign_id>2 AND sign_id<10)

go

UPDATE students
SET gender='male'
WHERE (name='Zhelyazko Dimov')

SELECT name,name_school,name_sign FROM students
JOIN schools
ON students.school_id=schools.id_school
JOIN signs
ON students.sign_id=signs.id_sign
WHERE (gender='female' AND (name_school='PG "Ivan Hadjienov"' OR name_school='OU "Kulata"' OR sign_id=9 OR sign_id=10))
