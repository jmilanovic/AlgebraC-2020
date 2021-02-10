USE [Upisi]
GO

SELECT
  --  [id] 
      [ime] AS 'Ime korisnika' 
      ,[prezime] AS 'Prezime korisnika' 
      ,[mjestomtanovanja]
	  , id * 5 AS 'sifraX5'
	  ,5 AS 'BrojPet'
	  ,id
  FROM [dbo].[Polaznici]
 -- ORDER BY 'Prezime korisnika' DESC  -- ili ASC
 ORDER BY 'sifraX5' ASC  
GO


SELECT
DISTINCT [mjestomtanovanja]
  FROM [dbo].[Polaznici]
GO

SELECT
MIN(ime),
     [mjestomtanovanja]
	 , SUM(id) AS 'suma ideva'
  FROM [dbo].[Polaznici]
 -- ORDER BY 'Prezime korisnika' DESC  -- ili ASC
 GROUP BY
 [mjestomtanovanja]
 
GO
SELECT
     max([mjestomtanovanja])
	 , ime
	 , sum(id)
  FROM [dbo].[Polaznici]
  WHERE [mjestomtanovanja] LIKE 'Zagreb'
 -- ORDER BY 'Prezime korisnika' DESC  -- ili ASC
 GROUP BY
 [ime]
 
GO