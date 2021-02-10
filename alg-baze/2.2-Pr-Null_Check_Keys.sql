--1. NOT NULL polja
CREATE TABLE Polaznici
(
	Sifra				INT NOT NULL,
	Ime					VARCHAR(20) NOT NULL,
	Prezime				VARCHAR(20) NOT NULL,
	MjestoStanovanja	VARCHAR(50)
)

--2. CHECK Constraint
DROP TABLE Polaznici
CREATE TABLE Polaznici
(
	Sifra				INT not null,
	Ime					varchar(20) not null,
	Prezime				varchar(20) not null,
	MjestoStanovanja	varchar(50),
	CONSTRAINT ChkSifra CHECK(Sifra between 1 and 1000)
)

--3. CHECK Constraint implicitno + UNIQUE
drop table Polaznici
CREATE TABLE Polaznici
(
	Sifra				INT UNIQUE 
						CHECK(Sifra BETWEEN 1 and 1000),
	Ime					VARCHAR(20) not null,
	Prezime				VARCHAR(20) not null,
	MjestoStanovanja	varchar(50)
)

--4. Primarni kljuè
drop table Polaznici
create table Polaznici
(
	Sifra				int 
						PRIMARY KEY 
						check(Sifra between 1 and 1000),
	Ime					varchar(20) not null,
	Prezime				varchar(20) not null,
	MjestoStanovanja	varchar(50)
)

--Foreign keys
CREATE TABLE Seminari
(
	Sifra				char(3) PRIMARY KEY,
	Naziv				varchar(250)
)

CREATE TABLE Upisi
(
	SifraPolaznika		INT 
						FOREIGN KEY	
						REFERENCES Polaznici(Sifra),
	SifraSeminara		char(3)
						FOREIGN KEY
						REFERENCES SEMINARI(Sifra)
	constraint PK_Sifra 
	primary key(SifraPolaznika, SifraSeminara)
)
