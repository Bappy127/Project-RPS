--residential_hall table: insertion procedure
-------------------------------------
drop procedure insert_residential_hall;
create procedure insert_residential_hall
(p_name IN residential_hall.resident_name%type,
p_exc OUT varchar2)
IS
BEGIN
	insert into residential_hall
	values (resident_id_gen(),p_name);
commit;
	p_exc:='Successfully Added';
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';
END insert_residential_hall;
/



--residential_hall table: viewing procedure
-----------------------------------
drop procedure view_residential_hall;
create procedure view_residential_hall
(resident_view_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN resident_view_cursor for 
	select rownum,fac_name from faculty;
	
END view_residential_hall;
/




--residential_hall table: deleting procedure
-----------------------------------
drop procedure del_residential_hall;
create procedure del_residential_hall
(p_fname IN residential_hall.resident_name%type,
p_exc OUT varchar2)
IS
	
BEGIN
	delete from residential_hall
	where resident_name=p_fname;
commit;
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid Operation';

END del_residential_hall;
/




----------------------------------------
--residential_hall table: updating procedure
-----------------------------------
drop procedure update_residential_hall;
create procedure update_residential_hall
(p_name IN residential_hall.resident_name%type,
p_oname varchar2,
p_exc OUT varchar2)
IS
BEGIN
	update residential_hall
	set resident_name=p_name
	where resident_name=p_oname;

commit;
	p_exc:='Successfully Added';
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';
END update_faculty;
/
