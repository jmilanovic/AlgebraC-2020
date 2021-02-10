USE [Upisi]
GO

SELECT [id]
      ,[ime]
      ,[prezime]
      ,[mjestomtanovanja]
  FROM [dbo].[Polaznici]
  -- Samo one iz Zg i one ciji id je neparan MODULO
  WHERE mjestomtanovanja LIKE 'Za%' AND (id % 2 != 0)
  ORDER By prezime
GO

SELECT [id]
      ,[ime]
      ,[prezime]
      ,[mjestomtanovanja]
  FROM [dbo].[Polaznici]
  -- Samo one iz Zg ILI one ciji id je paran MODULO
  WHERE mjestomtanovanja LIKE 'Za%' OR (id % 2 = 0)
  ORDER By prezime
GO
SELECT *
  FROM [dbo].[Polaznici]
  WHERE id NOT IN (10,2,9)
  ORDER BY id
GO

SELECT *
  FROM [dbo].[Polaznici] 
  WHERE id IN (
  SELECT id AS 'sifra'
  FROM [dbo].[Polaznici] 
  WHERE id>5
  
  )
  ORDER BY id
GO
--              ime od tri slova  mora @   (bilo koja domena), mora .com  
--             ana, ava, ane, ala       @   gmail, hotmail  .com
-- abc@abc.com  [a]__@%.com 
