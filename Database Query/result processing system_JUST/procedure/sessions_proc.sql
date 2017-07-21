--departments table: viewing dept procedure
-----------------------------------
drop procedure view_dept_sess;
create procedure view_dept_sess
(sess_dept_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN sess_dept_cursor for 
	select dept_name
	from departments;
		
END view_dept_sess;
/


--programs table: viewing procedure
-----------------------------------
drop procedure view_prog_sess;
create procedure view_prog_sess
(p_dname IN departments.dept_name%type,
prog_sess_cursor OUT sys_refcursor)
IS	

BEGIN

	OPEN prog_sess_cursor for 
	select prog_abbr 
	from programs p, departments d
	where p.dept_id=d.dept_id and dept_name=p_dname
	order by prog_abbr;
	
END view_prog_sess;
/




--sessions table: insertion procedure new
-----------------------------------------
drop procedure insert_sessions_new;
create procedure insert_sessions_new
(p_from IN sessions.session_desc%type,
p_to IN sessions.session_desc%type,
p_prog_id IN sessions.prog_id%type
--p_exc OUT varchar2
)
IS
	v_sess_desc varchar2(10);
	v_from number(4);
	v_to number(4);
BEGIN
	v_from:=to_number(p_from);
	v_to:=to_number(p_to);
	IF length(v_from)=4 and length(v_to)=4 and v_from=v_to-1 THEN
		v_sess_desc:=to_char(v_from)||'-'||to_char(v_to);
	END IF;

	insert into sessions
	values (sess_id_gen(),v_sess_desc,p_to,p_prog_id);
commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Session Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';*/
END insert_sessions_new;
/


--sessions table: insertion procedure continuous
------------------------------------------------
drop procedure insert_sessions_con;
create procedure insert_sessions_con
(p_prog_id IN sessions.prog_id%type
--,p_exc OUT varchar2
)
IS
	v_num number(5);
	v_num1 number(5);
	v_nxt sessions.session_desc%type;
BEGIN
	select max(substr(session_desc,6))
	into v_num 
	from sessions 
	where prog_id=p_prog_id;
	
	v_num1:=v_num+1;
	v_nxt:=to_char(v_num)||'-'||to_char(v_num1);

	insert into sessions
	values(sess_id_gen(),v_nxt,v_num1,p_prog_id);

commit;
END insert_sessions_con;
/

------------------------------------------------------------------------------------------
--sessions table: insertion procedure
-----------------------------------------
drop procedure insert_sessions;
create procedure insert_sessions
(p_from IN sessions.session_desc%type,
p_to IN sessions.session_desc%type,
p_prog_id IN sessions.prog_id%type,
p_exc OUT varchar2
)
IS
	v_num number(4);
BEGIN
	select count(session_desc)
	into v_num
	from sessions
	where prog_id=p_prog_id;

	IF v_num=0 THEN
		insert_sessions_new(p_from,p_to,p_prog_id,:p_exc);
	ELSE	insert_sessions_con(p_prog_id,:p_exc);
	END IF;

END insert_sessions;
/
----------------------------------------------------------------------------------------------------
	
