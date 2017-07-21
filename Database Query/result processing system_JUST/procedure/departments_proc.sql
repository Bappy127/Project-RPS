--departments table: insertion procedure
-------------------------------------
drop procedure insert_departments;
create procedure insert_departments
(p_dname IN departments.dept_name%type,
p_dabbr IN departments.dept_abbr%type,
p_dcode IN departments.dept_code%type,
p_fac_name IN faculty.fac_name%type,
p_exc OUT varchar2)
IS
	v_id departments.fac_id%type;
BEGIN
	select fac_id
	into v_id
	from faculty
	where fac_name=p_fac_name;

	insert into departments
	values (dept_id_gen(),upper(p_dname),p_dabbr,p_dcode,v_id );
commit;

	p_exc:='Successfully Added';

EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';
END insert_departments;
/


--departments table: viewing procedure
-----------------------------------
drop procedure view_departments;
create procedure view_departments
(p_fac_name IN faculty.fac_name%type,
dept_view_cursor OUT sys_refcursor,
p_exc OUT varchar2)
IS	
v_fac_id departments.fac_id%type;

BEGIN
	SELECT f.fac_id
	into v_fac_id
	FROM	faculty f, departments d
	WHERE f.fac_id= d.fac_id
	and f.fac_name= p_fac_name;
	
	OPEN dept_view_cursor for 
	select rownum,dept_name,dept_abbr,dept_code,fac_name 
	from departments d,faculty f
	where d.fac_id=f.fac_id
	and d.fac_id=v_fac_id;


EXCEPTION
	WHEN NO_DATA_FOUND THEN
		p_exc:='No data Found';
	WHEN OTHERS THEN
		p_exc:='Invalid';

	
END view_departments;
/


--departments table: selecting procedure
-------------------------------------
drop procedure select_departments;
create procedure select_departments
(p_dname IN OUT departments.dept_name%type,
p_dabbr OUT departments.dept_abbr%type,
p_dcode OUT departments.dept_code%type,
p_exc OUT varchar2)
IS
	--v_dname departments.dept_name%type;
BEGIN
	select dept_name,dept_abbr,dept_code
	into p_dname,p_dabbr,p_dcode
	from departments
	where dept_name=p_dname;

	--dept_name:=p_dname;

EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';

END select_departments;
/




--departments table: updating procedure
-------------------------------------
drop procedure update_departments;
create procedure update_departments
(p_dname IN OUT departments.dept_name%type,
p_doname IN departments.dept_name%type,
p_dabbr IN OUT departments.dept_abbr%type,
p_dcode IN OUT departments.dept_code%type,
p_fac_name IN faculty.fac_name%type,
p_exc OUT varchar2)
IS
	v_did departments.fac_id%type;
	v_fid departments.fac_id%type;
BEGIN
	select dept_id
	into v_did
	from departments
	where dept_name=p_doname;

	select fac_id
	into v_fid
	from faculty
	where fac_name=p_fac_name;

	update departments
	set dept_name=upper(p_dname),dept_abbr=upper(p_dabbr),dept_code=p_dcode,fac_id=v_fid
	where dept_id=v_did;
commit;
	p_exc:='Successfully Updated';

	select dept_name,dept_abbr,dept_code
	into p_dname,p_dabbr,p_dcode
	from departments
	where dept_id=v_did;

EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';

END update_departments;
/


--departments table: deleting procedure
-----------------------------------
drop procedure del_departments;
create procedure del_departments
(p_dname IN departments.dept_name%type,
p_exc OUT varchar2)
IS
	
BEGIN
	delete from departments
	where dept_name=p_dname;
commit;
	p_exc:='Successfully Deleted';

EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid Operation';

END del_departments;
/
