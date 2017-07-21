--faculty table: fac_id generator function
----------------------------------------------
drop function fac_id_gen;
create function fac_id_gen
RETURN varchar2
IS
	v_num number;
	v_id faculty.fac_id%type;
BEGIN
	select max(to_number(substr(fac_id,2))) 
	into v_num
	from faculty;

IF		v_num is NULL
THEN	 	v_id:='f1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='f'||v_num;
RETURN	v_id;
END IF;
END fac_id_gen;
/


--departments table: dept_id generator function
----------------------------------------------
drop function dept_id_gen;
create function dept_id_gen
RETURN varchar2
IS
	v_num number;
	v_id departments.dept_id%type;
BEGIN
	select max(to_number(substr(dept_id,2))) 
	into v_num
	from departments;

IF		v_num is NULL
THEN	 	v_id:='d1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='d'||v_num;
RETURN	v_id;
END IF;
END dept_id_gen;
/


--programs table: prog_id generator function
----------------------------------------------
drop function prog_id_gen;
create function prog_id_gen
RETURN varchar2
IS
	v_num number;
	v_id programs.prog_id%type;
BEGIN
	select max(to_number(substr(prog_id,2))) 
	into v_num
	from programs;

IF		v_num is NULL
THEN	 	v_id:='p1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='p'||v_num;
RETURN	v_id;
END IF;
END prog_id_gen;
/


--sessions table: sessions_id generator function
----------------------------------------------
drop function sess_id_gen;
create function sess_id_gen
RETURN varchar2
IS
	v_num number;
	v_id sessions.session_id%type;
BEGIN
	select max(to_number(substr(session_id,2))) 
	into v_num
	from sessions;

IF		v_num is NULL
THEN	 	v_id:='s1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='s'||v_num;
RETURN	v_id;
END IF;
END sess_id_gen;
/


--sessions table: new-continuous function
----------------------------------------------
drop function sess_new_con;
create function sess_new_con
(p_id IN sessions.prog_id%type)
RETURN number
IS
	v_num number;
	
BEGIN
	select count(session_id) 
	into v_num
	from sessions
	where prog_id=p_id;

RETURN	v_num;

END sess_new_con;
/






--semesters table: sem_id generator function
----------------------------------------------
drop function sem_id_gen;
create function sem_id_gen
RETURN varchar2
IS
	v_num number;
	v_id semesters.sem_id%type;
BEGIN
	select max(to_number(substr(sem_id,2))) 
	into v_num
	from semesters;

IF		v_num is NULL
THEN	 	v_id:='m1';
RETURN	v_id;

ELSIF		v_num=8
THEN		RETURN NULL;

ELSE		v_num:=v_num+1;
		v_id:='m'||v_num;
RETURN	v_id;
END IF;
END sem_id_gen;
/


--residential_hall table: fac_id generator function
----------------------------------------------
drop function resident_id_gen;
create function resident_id_gen
RETURN varchar2
IS
	v_num number;
	v_id residential_hall.resident_id%type;
BEGIN
	select max(to_number(substr(resident_id,2))) 
	into v_num
	from residential_hall;

IF		v_num is NULL
THEN	 	v_id:='r1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='r'||v_num;
RETURN	v_id;
END IF;
END resident_id_gen;
/



--student_info table: roll generator function
----------------------------------------------
drop function roll_gen;
create function roll_gen
(p_sess_orgn IN sessions.session_id%type)
return varchar2
IS
	v_count number;
	v_max_roll students_info.roll%type;
	v_nxt_roll students_info.roll%type;
	v_roll students_info.roll%type;
	v_ini students_info.roll%type;
BEGIN
	select count(roll)
	into v_count 
	from students_info 
	where session_id_origin= p_sess_orgn;

IF v_count=0	
THEN
	select substr(s.session_desc,3,2) || d.dept_code ||'01' 
	into v_nxt_roll
	from sessions s, programs p, departments d
	where s.prog_id=p.prog_id and p.dept_id=d.dept_id and
	s.session_id= p_sess_orgn;
RETURN v_nxt_roll;
ELSE
	select max(roll)
	into v_max_roll 
	from students_info 
	where session_id_origin= p_sess_orgn;
	
	v_ini:= substr(v_max_roll,1,4);
	v_roll:= substr(v_max_roll,length(v_max_roll)-1)+1;

	IF to_number(v_roll) between 1 and 9
	THEN
		v_nxt_roll:=v_ini||'0'||v_roll;
	RETURN v_nxt_roll;
	
	ELSE
		v_nxt_roll:= v_ini||v_roll;
	RETURN v_nxt_roll;
	END IF;
END IF;	
END roll_gen;
/



--courses table: course_id generator function
----------------------------------------------
drop function course_id_gen;
create function course_id_gen
RETURN varchar2
IS
	v_num number;
	v_id courses.course_id%type;
BEGIN
	select max(to_number(substr(course_id,2))) 
	into v_num
	from courses;

IF		v_num is NULL
THEN	 	v_id:='c1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='c'||v_num;
RETURN	v_id;
END IF;
END course_id_gen;
/


--promotion table: prom_id generator function
----------------------------------------------
drop function prom_id_gen;
create function prom_id_gen
RETURN varchar2
IS
	v_num number;
	v_id promotion.prom_id%type;
BEGIN
	select max(to_number(substr(prom_id,2))) 
	into v_num
	from promotion;

IF		v_num is NULL
THEN	 	v_id:='n1';
RETURN	v_id;

ELSE		v_num:=v_num+1;
		v_id:='n'||v_num;
RETURN	v_id;
END IF;
END prom_id_gen;
/


--old system decider function
-------------------------------
drop funtion old_system;
create function old_system
(p_prom_id IN promotion.prom_id%type)
RETURN number
IS
	v_num number;
BEGIN
	select count(session_id) 
	into v_num
	from promotion 
	where prom_id=p_prom_id and 
		prom_id IN	(select p.prom_id from promotion p,sessions s
				where s.session_id=p.session_id and s.session_desc='2008-2009' and sem_id between 'm1' and 'm6'
				union
				select p.prom_id from promotion p,sessions s
				where s.session_id=p.session_id and s.session_desc='2009-2010' and p.sem_id between 'm1'and 'm4'
				union
				select p.prom_id from promotion p,sessions s
				where s.session_id=p.session_id and s.session_desc='2010-2011' and p.sem_id between 'm1'and 'm2');


	RETURN v_num;
END old_system;
/


