--Cross join, Cartesian join (Spaja svaki sa svakim)
Select *
from Proizvodi, KategorijeProizvodi, Kategorije

--Inner join, unutarnje spajanje
--Spaja tablice po zadanom kriteriju (polju, poljima). Vraæa samo retke koji zadovoljavaju uvjet
SELECT *
FROM MjereProizvoda mp
INNER JOIN Proizvodi p on mp.Id = p.MjeraProizvodaId
--Spajanje više tablica
SELECT kat.Id as 'IdKategorije', pro.Id as 'IdProizvoda', pro.*
FROM Kategorije kat
	INNER JOIN KategorijeProizvodi kp on kat.Id = kp.KategorijaId
	INNER JOIN Proizvodi pro on kp.ProizvodId = pro.Id


--LEFT JOIN
--Vraæa sve retke sa lijeve strane. Retke sa desne strane nadopunjava NULL vrijednostima
SELECT *
FROM 
	MjereProizvoda mp 
	LEFT JOIN Proizvodi p on mp.Id = p.MjeraProizvodaId 

--RIGHT JOIN
--Isto kao LEFT JOIN samo nadopunjava desnu stranu
SELECT *
FROM
	Proizvodi p
	RIGHT JOIN MjereProizvoda mp on  mp.Id = p.MjeraProizvodaId

--Puno vanjsko spajanje FULL OUTER JOIN
SELECT *
FROM Proizvodi p
FULL JOIN MjereProizvoda mp on p.MjeraProizvodaId = mp.Id
FULL JOIN NarudzbeDetalji nd on nd.ProizvodId = p.Id 

--Rekurzivno spajanje
SELECT *
FROM KategorijeProizvodi kp1
inner join KategorijeProizvodi kp2 
	on kp1.ProizvodId = kp2.ProizvodId AND kp1.Id <> kp2.Id