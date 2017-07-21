--faculty table: insertion procedure
-------------------------------------
drop procedure insert_faculty;
create procedure insert_faculty
(p_name IN faculty.fac_name%type,
p_exc OUT varchar2)
IS
BEGIN
	insert into faculty
	values (fac_id_gen(),p_name);
commit;
	p_exc:='Successfully Added';
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';
END insert_faculty;
/


--faculty table: viewing procedure
-----------------------------------
drop procedure view_faculty;
create procedure view_faculty
(fac_view_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN fac_view_cursor for 
	select rownum,fac_name from faculty;
	
END view_faculty;
/


--faculty table: deleting procedure
-----------------------------------
drop procedure del_faculty;
create procedure del_faculty
(p_fname IN faculty.fac_name%type,
p_exc OUT varchar2)
IS
	
BEGIN
	delete from faculty
	where fac_name=p_fname;
commit;
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid Operation';

END del_faculty;
/


----------------------------------------
--faculty table: updating procedure
-----------------------------------
drop procedure update_faculty;
create procedure update_faculty
(p_name IN faculty.fac_name%type,
p_oname varchar2,
p_exc OUT varchar2)
IS
BEGIN
	update faculty
	set fac_name=p_name
	where fac_name=p_oname;

commit;
	p_exc:='Successfully Added';
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';
END update_faculty;
/
