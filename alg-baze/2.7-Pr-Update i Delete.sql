---UPDATE podataka

BEGIN Tran

UPDATE stud
SET imeStud = 'Mirko', prezStud = 'Spirko'
--where mbrStud = 1121

rollback

begin tran

UPDATE st
SET 
	st.prezStud = RTRIM(st.prezStud) + ' (' + RTRIM(mj.nazMjesto) + ')'
--SELECT *
from stud st
INNER JOIN mjesto mj on st.pbrRod = mj.pbr
where mj.pbr = 10000

rollback

commit

begin tran
update stud
SET prezStud = RTRIM(prezStud)
commit

--DELETE

begin tran

DELETE ispit
WHERE sifNastavnik = 122
Select * 
from ispit
where sifNastavnik = 122

rollback


