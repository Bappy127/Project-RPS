--semesters table: insertion procedure
-------------------------------------
drop procedure insert_semesters;
create procedure insert_semesters
(p_year IN semesters.year%type,
p_sem IN semesters.sem%type,
p_exc OUT varchar2
)
IS
BEGIN
	insert into semesters
	values (sem_id_gen(),initcap(p_year),initcap(p_sem));
commit;
	P_exc:='Successfully Added';
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='No More Semester';
END insert_semesters;
/


--semesters table: select procedure
-------------------------------------
drop procedure select_semesters;
create procedure select_semesters
(sem_cursor OUT sys_refcursor)
IS
BEGIN
	open sem_cursor for
	select rownum,initcap(year)||' '||'Year'||', '||initcap(sem)||' '||'Semester' 
	from semesters;

END select_semesters;
/



--semesters table: delete procedure
-------------------------------------
drop procedure del_semesters;
create procedure del_semesters
(sem_cur_val IN varchar2,
p_exc OUT varchar2)
IS
	v_year varchar2(10);
	v_sem varchar2(10);
BEGIN
	select substr(sem_cur_val,1,3),substr(sem_cur_val,11,3)
	into v_year,v_sem
	from dual;	

	delete from semesters
	where year=v_year and sem=v_sem;
commit;
	p_exc:='Successfully Deleted';

EXCEPTION
	WHEN OTHERS THEN
		p_exc:='No More Semester';

END del_semesters;
/
