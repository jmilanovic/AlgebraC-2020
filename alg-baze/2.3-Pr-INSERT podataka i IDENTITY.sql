--Upis podataka u tablicu
INSERT INTO Polaznici
VALUES
(1,'Mirko', 'Spirko', 'Zagreb')

insert into polaznici 
values
(2, 'Jura','Klafura', 'Varaždin')

--Upis NULL vrijednosti
INSERT INTO Polaznici
VALUES
(3,'Pero','Ždero', NULL)
--ili
INSERT INTO Polaznici
(Sifra, Ime, Prezime)
VALUES
(4,'Ava','Karabatiæ')

--AUTO inkrement Primarnog kljuèa
--Obriši tablicu Upisi
--Obriši tablicu Polaznici
--Kreiraj tablicu polaznici sa svim constraintima i PK i FK
--Kreiraj tablicu upisi  sa svim constraintima i PK i FK
DROP TABLE Upisi
DROP TABLE Polaznici
CREATE TABLE Polaznici
(
	Sifra				INT 
						PRIMARY KEY 
						CHECK(Sifra between 1 and 1000)
						IDENTITY(1,1),
	Ime					varchar(20) not null,
	Prezime				varchar(20) not null,
	MjestoStanovanja	varchar(50)
)

CREATE TABLE Upisi
(
	SifraPolaznika		int
						foreign key
						references Polaznici(Sifra),
	SifraSeminara		CHAR(3)
						foreign key
						references Seminari(Sifra)
	CONSTRAINT PKSifra primary key(SifraPolaznika, SifraSeminara)
)

--Moramo ponovno napuniti tablicu
INSERT INTO Polaznici VALUES('Mirko','Spirko', 'Zagreb')
INSERT INTO Polaznici VALUES('Jura','Klafura', 'Varaždin')
INSERT INTO Polaznici(Ime, Prezime) VALUES('Pero','Ždero')
INSERT INTO Polaznici VALUES('Ava','Karabatiæ', 'Smederevo')