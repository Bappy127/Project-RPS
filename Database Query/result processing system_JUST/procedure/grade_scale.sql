--grade_scale table: insertion procedure
-----------------------------------------
drop procedure insert_grade_scale;
create procedure insert_grade_scale
(p_ul IN varchar2,
p_ll IN varchar2,
p_gp IN varchar2,
p_lg IN grade_scale.lett_grd%type,
p_exc OUT varchar2)
IS
BEGIN
	insert into grade_scale
	values(to_number(p_ul),to_number(p_ll),to_number(p_gp),p_lg);
commit;
	p_exc:='Successfully Added';

EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Change';

	WHEN VALUE_ERROR THEN
		p_exc:='Invalid number';

	WHEN OTHERS THEN
		p_exc:='Invalid';
END insert_grade_scale;
/


--grade_scale table: view procedure
-----------------------------------------
drop procedure view_grade_scale;
create procedure view_grade_scale
(grd_cursor OUT sys_refcursor)
IS
BEGIN
	open grd_cursor for
	select lett_grd,gp,upper_lim,lower_lim
	from grade_scale;

END view_grade_scale;
/


--grade_scale table: deleting procedure
-----------------------------------
drop procedure del_grade;
create procedure del_grade
(p_lg IN grade_scale.lett_grd%type,
p_exc OUT varchar2)
IS
BEGIN
	Delete from grade_scale	
	where lett_grd=p_lg;
commit;
	p_exc:='Successfully Deleted';
EXCEPTION
	WHEN OTHERS THEN
		p_exc:='Invalid';

END del_grade;
/
