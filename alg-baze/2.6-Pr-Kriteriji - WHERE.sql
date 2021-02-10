Select  *
from Polaznici
WHERE 
	Prezime = 'klafura'

--Logièki operator AND (I) - svi uvjeti moraju biti zadovoljeni
Select * 
FROM Polaznici
WHERE
	Prezime = 'klafura'
	AND Ime ='jurb'
	
SELECT *
FROM Polaznici
WHERE 
	(Prezime = 'klafura'
	OR Prezime = 'Karabatiæ')
	AND Ime <> 'Jura'


Select *
 FROM Polaznici
 WHERE NOT Prezime = 'klafura'
 
 Select * 
 from Polaznici
 where	 
	Prezime = 'klafura'
	AND Sifra < 120
	
--IN Operator

SELECT *
FROM Polaznici
WHERE Sifra IN(2, 4,6)

--SUBSELECT - podupit

SELECT * 
FROM Polaznici
WHERE Sifra IN
(Select Sifra from Polaznici where Ime = 'ava')
 
 
-- LIKE operator
SELECT *
FROM Polaznici
WHERE Prezime like '%a%a'	

SELECT *
FROM Polaznici
where Sifra between 11 and 25

SELECT *
FROM Polaznici
WHERE Sifra > 11 and Sifra < 25