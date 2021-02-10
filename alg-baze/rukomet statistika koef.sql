/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
sum(s.broj_golova) as ukupno, i.ime, i.prezime, i.pozicija, i.cijena, t.naziv, t.drzava, sum(s.broj_golova)/cijena AS koef_igrac
  FROM [rukomet].[dbo].[statistika] s
  LEFT JOIN igraci i
  ON s.igrac_id=i.id
  LEFT JOIN timovi t
  ON i.tim_id=t.id
  GROUP BY igrac_id, i.ime, i.prezime, i.pozicija, i.cijena, t.naziv, t.drzava
  ORDER BY koef_igrac DESC