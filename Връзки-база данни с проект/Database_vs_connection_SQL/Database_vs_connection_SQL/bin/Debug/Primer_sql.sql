CREATE DATABASE Primer_connection

use Primer_connection

CREATE TABLE Clients(
ID int PRIMARY KEY,
ime NVARCHAR(20),
telefon NVARCHAR(10)
)

CREATE TABLE Stoki(
Stoke_id int PRIMARY KEY,
stoke_name NVARCHAR(20),
ammount int
)

CREATE TABLE Clients_Stoki(
id_client int FOREIGN KEY 
REFERENCES Clients(ID),
id_stoke int FOREIGN KEY
REFERENCES Stoki(Stoke_id)
)

INSERT INTO Clients(ID,ime,telefon)
VALUES (1,'Ivan Ivanov','0897880901'),
(2,'Teodor Zdravkov','0899920502'),
(3,'Pesho Svilenov','0897512155')

INSERT INTO Stoki(Stoke_id,stoke_name,ammount)
VALUES (1,'Sirene',4),
(2,'Izvara',7),
(3,'Kashkaval',4);

INSERT INTO Clients_Stoki(id_client,id_stoke)
VALUES (1,3),
(1,2),
(2,2),
(3,1);

SELECT ID,ime,telefon FROM Clients