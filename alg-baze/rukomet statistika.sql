/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
, LEFT(ishod,2) AS rez_dom
, RIGHT(ishod,2) AS rez_gost
, IIF(LEFT(ishod,2)>RIGHT(ishod,2), 1,  2 ) AS rez
  FROM [rukomet].[dbo].susreti s
  LEFT JOIN timovi t_dom
  ON t_dom.id=s.domacin_id
  LEFT JOIN timovi t_gost
  ON t_gost.id=s.gost_id