--1. Kreiranje baze podataka
CREATE DATABASE Upisi

--2. Kreiranje tablice
CREATE TABLE Polaznici
(
	Sifra				int,
	Ime					nvarchar(50),
	Prezime				nvarchar(50),
	MjestoStanovanja	nvarchar(70)
)

--3. Promjena tablice, dodavanje kolona
ALTER TABLE Polaznici
	ADD BrojTelefona int

--4. Promjena tablice, promjena kolone
ALTER TABLE Polaznici
	ALTER COLUMN BrojTelefona varchar(20)
--5. Brisanje kolone
ALTER TABLE Polaznici
	DROP COLUMN BrojTelefona	
--6. Brisanje tablice
DROP TABLE Polaznici	

--7. Brisanje Cijele baze
USE master
DROP DATABASE Upisi	