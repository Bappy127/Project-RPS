--programs table: insertion procedure
-------------------------------------
drop procedure insert_programs;
create procedure insert_programs
(p_degree IN programs.degree%type,
p_pname IN programs.prog_name%type,
p_dname IN departments.dept_name%type,
p_abbr IN programs.prog_abbr%type,
p_exc OUT varchar2)
IS
	v_did programs.dept_id%type;
BEGIN
	select dept_id
	into v_did
	from departments
	where dept_name=p_dname;
	
	insert into programs
	values (prog_id_gen(),upper(p_degree),upper(p_pname),v_did,upper(p_abbr));
commit;
	p_exc:='Successfully Added';

EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';
END insert_programs;
/


--programs table: viewing procedure
-----------------------------------
drop procedure view_programs;
create procedure view_programs
(prog_view_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN prog_view_cursor for 
	select dept_abbr,degree,prog_name,prog_abbr 
	from programs p, departments d
	where p.dept_id=d.dept_id
	order by dept_abbr,degree;
	
END view_programs;
/


--programs table: viewing level procedure
-----------------------------------
drop procedure view_level;
create procedure view_level
(prog_level_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN prog_level_cursor for 
	select distinct(degree)
	from programs;
	
END view_level;
/


--programs table: viewing dept procedure
-----------------------------------
drop procedure view_dept;
create procedure view_dept
(prog_dept_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN prog_dept_cursor for 
	select distinct(dept_name)
	from programs p, departments d
	where p.dept_id=d.dept_id;
	
END view_dept;
/


--programs table: select procedure
-----------------------------------
drop procedure select_degree;
create procedure select_degree
(p_dname IN departments.dept_name%type,
prog_abbr_cursor OUT sys_refcursor)
IS
	v_did programs.dept_id%type;
BEGIN
	open prog_abbr_cursor for
	select prog_abbr from programs p, departments d
	where p.dept_id=d.dept_id and d.dept_name=p_dname;

END select_degree;
/


--programs table: select degree_name procedure
-----------------------------------
drop procedure select_deg_name;
create procedure select_deg_name
(p_abbr IN OUT programs.prog_abbr%type,
p_name OUT programs.prog_name%type,
p_exc OUT varchar2)
IS
	v_abbr programs.prog_abbr%type;
BEGIN
	select prog_name,prog_abbr
	into p_name,v_abbr 
	from programs	
	where prog_abbr=p_abbr;

	p_abbr:=v_abbr;

EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';

END select_deg_name;
/


--programs table: updating procedure
-----------------------------------
drop procedure update_programs;
create procedure update_programs
(p_oabbr IN programs.prog_abbr%type,
p_name IN programs.prog_name%type,
p_abbr IN programs.prog_abbr%type,
p_exc OUT varchar2
)
IS
	v_id programs.prog_id%type;
BEGIN
	select prog_id
	into v_id
	from programs
	where prog_abbr=p_oabbr;

	update programs
	set prog_name=upper(p_name),prog_abbr=p_abbr
	where prog_id=v_id;

commit;
	p_exc:='Successfully Updated';
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';
END update_programs;
/



--programs table: deleting procedure
-----------------------------------
drop procedure delete_program;
create procedure delete_program
(p_abbr IN programs.prog_abbr%type,
p_exc OUT varchar2)
IS
BEGIN
	Delete from programs	
	where prog_abbr=p_abbr;
commit;
	p_exc:='Successfully Deleted';
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';

END delete_program;
/
