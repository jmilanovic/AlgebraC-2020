-- Z3.2
-- mbr, ime, prez svih stud. Ime i prez treba zajedno
SELECT s.mbrStud, 
CONCAT(RTRIM(s.imeStud),' ',RTRIM(s.prezStud) ) AS 'Ime i prezime'
FROM stud s
GO
-- Z3.3
-- ime svih stud samo jenom. poredati po abecedi silazno
SELECT DISTINCT s.imeStud 
FROM stud s 
ORDER BY s.imeStud  DESC
GO

-- Z3.3 drugi nacin
-- ime svih stud samo jenom. poredati po abecedi silazno
SELECT s.imeStud, COUNT(s.imeStud ) AS 'ukupno imena'
FROM stud s
GROUP BY s.imeStud 
ORDER BY 'ukupno imena' DESC,s.imeStud  DESC
GO

-- Z3.4 drugi nacin
-- mbrstud svih koji su polozili ispit 146
SELECT i.mbrStud
FROM ispit i
WHERE i.sifPred=146 AND i.ocjena>1

-- Z3.5 
-- ime i prez nast i placu (koef*+0.4)*800
SELECT TOP 2 PERCENT WITH TIES
*
,n.imeNastavnik
, n.prezNastavnik
, (n.koef+0.4)*800 AS placa
FROM nastavnik n
ORDER BY placa DESC

-- Z3.6 
-- ime i prez nast i placu (koef*+0.4)*800 
-- Oni s manjom od 3500 ili vecom od 8000
SELECT
*
,n.imeNastavnik
, n.prezNastavnik
, (n.koef+0.4)*800 AS placa
FROM nastavnik n
WHERE (n.koef+0.4)*800 <3500 OR (n.koef+0.4)*800>8000
ORDER BY placa DESC

-- Z3.7 
-- ime prezime stud koji su pali predmete od 220 do 240
SELECT s.imeStud, s.prezStud
FROM stud s
RIGHT JOIN ispit i
ON i.mbrStud=s.mbrStud
WHERE i.sifPred BETWEEN 220 AND 240
AND i.ocjena=1

-- Z3.8 
-- ime, prez stud koji su negdje dobili 3
SELECT DISTINCT s.imeStud, s.prezStud
FROM stud s
RIGHT JOIN ispit i
ON i.mbrStud=s.mbrStud
WHERE  i.ocjena=3

-- Z3.9 
-- naziv pred na koji nitko nije izisao
SELECT p.nazPred
FROM ispit i 
RIGHT JOIN pred p
on i.sifPred=p.sifPred
WHERE i.datIspit IS NULL AND p.upisanoStud>0
ORDER BY p.upisanoStud DESC

-- Z3.10
-- naziv pred na ciji ispit je izisao barem jedan
-- rjesenje:60
SELECT DISTINCT p.nazPred
FROM ispit i 
RIGHT JOIN pred p
on i.sifPred=p.sifPred
WHERE i.datIspit IS NOT NULL

-- Z3.10 drugi nacin INNER
-- naziv pred na ciji ispit je izisao barem jedan
SELECT DISTINCT p.nazPred
FROM ispit i 
INNER JOIN pred p
on i.sifPred=p.sifPred
-- WHERE i.datIspit IS NOT NULL

-- Z3.11  ---> Z3.24 POKUSAJTE SAMI

-- Z3.25
-- podaci o stud i mjestu stan za one koji su 
-- barem jednom pali predmet "osnove baza podataka"
SELECT s.imeStud,s.prezStud,m.nazMjesto, COUNT(s.mbrStud) AS 'koliko puta pao'
FROM pred p
INNER JOIN ispit i
ON p.sifPred=i.sifPred
LEFT JOIN stud s
ON i.mbrStud=s.mbrStud
LEFT JOIN mjesto m
ON s.pbrStan=m.pbr
WHERE i.ocjena=1 AND p.nazPred LIKE '%baza%'
GROUP BY s.mbrStud,s.imeStud,s.prezStud,m.nazMjesto
ORDER BY 'koliko puta pao' DESC
