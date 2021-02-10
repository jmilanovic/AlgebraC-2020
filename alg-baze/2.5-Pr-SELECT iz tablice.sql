-- Dohvati sve retke i sve kolone
--Kako pozivamo kolone, takve ih SQL vraæa (mala/velika slova)
SELECT sifra, ime, prezime, mjestostanovanja
FROM Polaznici
--ili
SELECT *
FROM Polaznici

--Aliasi 
SELECT
	Sifra AS 'Šifra polaznika',
	ime AS 'Ime polaznika',
	prezime 'Prezime polaznika',
	mjestoStanovanja AS 'Mjesto stanovanja'
FROM 
	Polaznici AS pol
	
--Redosljed kolona nije bitan
SELECT
	MjestoStanovanja, Prezime, Ime, Sifra
FROM
	Polaznici

--Ako se kod inserta navode kolone, treba pratiti njihov redosljed
INSERT INTO Polaznici
(MjestoStanovanja, Prezime, Ime)
VALUES
('Babina Greda', 'Maminjo','Zdrafko')	

--Sortiranje podataka
--Sort po jednoj koloni
SELECT *
FROM Polaznici pol
ORDER BY Ime DESC --ako ne navedemo sort order (ASC/DESC), ASC se podrazumijeva

--Sort po više kolona
SELECT *
FROM Polaznici
ORDER BY Prezime, Ime 


--Grupiranje
--Traži jedinstvene zapise izmeðu traženih kolona
SELECT DISTINCT  ime, prezime, mjestostanovanja
from Polaznici

--GROUP BY 
SELECT MjestoStanovanja
FROM Polaznici
group by MjestoStanovanja

--Group by plus agregat
SELECT MjestoStanovanja, COUNT(MjestoStanovanja)
from Polaznici
group by MjestoStanovanja

SELECT Prezime, COUNT(*)
from Polaznici
group by Prezime
order by Prezime desc

--TOP N zapisa
SELECT TOP 100000 *
FROM Polaznici
order by Sifra desc

