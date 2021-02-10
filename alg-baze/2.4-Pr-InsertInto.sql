SELECT *
INTO #TempStud
FROM stud

DELETE #TempStud
DROP TABLE #TempStud

UPDATE st
SET 
	st.prezStud = RTRIM(st.prezStud) + ' (' + RTRIM(mj.nazMjesto) + ')'
--SELECT *
from TempStud st
INNER JOIN mjesto mj on st.pbrRod = mj.pbr
where mj.pbr = 10000


drop table TempStud