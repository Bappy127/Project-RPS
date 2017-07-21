--------------------------------------------

















------------------------------------------
drop procedure insert_session_students;
create procedure insert_session_students
(g_sess INOUT students_info.session_id%type)
IS
BEGIN
	:g_sess
END insert_session_students;
/
-------------------------------------------------


drop procedure insert_students;
create procedure insert_students
(p_regi IN students_info.regi_no%type,
p_name IN students_info.s_name%type,
p_sess IN students_info.session_id%type,
--p_sess_orgn IN students_info.session_id_origin%type,
p_phone IN students_info.phone%type,
p_addt IN students_info.address_temp%type,
p_addp IN students_info.address_perm%type,
p_email IN students_info.email%type,
p_dob IN students_info.dob%type,
p_reli IN students_info.religion%type,
p_nat IN students_info.nationality%type,
p_fat IN students_info.father_name%type,
p_mot IN students_info.mother_name%type,
p_st IN students_info.status%type
--,p_exc OUT varchar2
)
IS
BEGIN
	insert into students_info
	values (roll_gen(p_sess),p_regi,p_name,p_sess,p_sess,p_phone,p_addt,p_addp,p_email,p_dob,p_reli,p_nat,p_fat,p_mot,p_st);
commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='Invalid';*/
END insert_students;
/




--courses table: insertion procedure
------------------------------------------
drop procedure insert_courses;
create procedure insert_courses
(p_course_code_sub IN courses.course_code%type,
p_course_code_num IN courses.course_code%type,
p_course_title IN courses.course_title%type,
p_session_id IN courses.session_id%type,
p_sem_id IN courses.sem_id%type,
p_crdt IN courses.crdt%type,
p_type courses.type%type,
p_exc OUT varchar2
)
IS
	v_course_code courses.course_code%type;
	v_course_code_sub courses.course_code%type;
	v_course_code_num number;
	
BEGIN
	v_course_code_sub:=upper(p_course_code_sub);
	IF length(p_course_code_num)=4 THEN 
		v_course_code_num:= to_number(p_course_code_num);
	ELSE	p_exc:='invalid course number';
	END IF;
	v_course_code:= v_course_code_sub||' '||to_char(v_course_code_num);
	
	insert into courses
	values(course_id_gen(),v_course_code,initcap(p_course_title),p_session_id,p_sem_id,p_crdt,upper(p_type));

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Change Course Code';

	WHEN VALUE_ERROR THEN
		p_exc:='Invalid course id';

	WHEN OTHERS THEN
		p_exc:='Invalid';*/

END insert_courses;
/






--promotion table: insertion procedure
------------------------------------------
drop procedure insert_promotion;
create procedure insert_promotion
(p_session_id IN promotion.session_id%type,
p_exc OUT varchar2)
IS
	v_num number;
	v_id promotion.sem_id%type;
BEGIN
	select max(to_number(substr(sem_id,2))) 
	into v_num
	from promotion
	where session_id=p_session_id;

IF		v_num is NULL
THEN	 	v_id:='m1';

ELSE		v_num:=v_num+1;
		v_id:='m'||v_num;
END IF;

	insert into promotion (prom_id,sem_id,session_id)
	values(prom_id_gen(),v_id,p_session_id);

commit;
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Name Already Exists';
	WHEN OTHERS THEN
		p_exc:='No More Promotion';

END insert_promotion;
/



--marks_theory table: insertion procedure
------------------------------------------
drop procedure insert_marks_thry;
create procedure insert_marks_thry
(p_roll IN marks_theory.roll%type,
p_course_id IN marks_theory.course_id%type,
p_prom_id IN marks_theory.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_theory (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_thry;
/



--marks_lab table: insertion procedure
------------------------------------------
drop procedure insert_marks_lab;
create procedure insert_marks_lab
(p_roll IN marks_lab.roll%type,
p_course_id IN marks_lab.course_id%type,
p_prom_id IN marks_lab.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_lab (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_lab;
/


--marks_thesis_pro table: insertion procedure
------------------------------------------
drop procedure insert_marks_thesis_pro;
create procedure insert_marks_thesis_pro
(p_roll IN marks_thesis_pro.roll%type,
p_course_id IN marks_thesis_pro.course_id%type,
p_prom_id IN marks_thesis_pro.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_thesis_pro (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_thesis_pro;
/


--marks_viva table: insertion procedure
------------------------------------------
drop procedure insert_marks_viva;
create procedure insert_marks_viva
(p_roll IN marks_viva.roll%type,
p_course_id IN marks_viva.course_id%type,
p_prom_id IN marks_viva.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_viva (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_viva;
/


--marks_theory_old table: insertion procedure
------------------------------------------
drop procedure insert_marks_thry_old;
create procedure insert_marks_thry_old
(p_roll IN marks_theory_old.roll%type,
p_course_id IN marks_theory_old.course_id%type,
p_prom_id IN marks_theory_old.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_theory_old (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_thry_old;
/



--marks_lab_old table: insertion procedure
------------------------------------------
drop procedure insert_marks_lab_old;
create procedure insert_marks_lab_old
(p_roll IN marks_lab_old.roll%type,
p_course_id IN marks_lab_old.course_id%type,
p_prom_id IN marks_lab_old.prom_id%type
--,p_exc OUT varchar2
)
IS
BEGIN
	
	insert into marks_lab_old (roll,course_id,prom_id)
	values(p_roll,p_course_id,p_prom_id);

commit;
/*EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		p_exc:='Already Exists';
	WHEN OTHERS THEN
		p_exc:='invalid';*/

END insert_marks_lab_old;
/



--assign courses against roll number in a semester and session
---------------------------------------------------------------
drop procedure assign_courses;
create procedure assign_courses
(p_prom_id IN promotion.prom_id%type
--p_sem_id IN promotion.sem_id%type,
--p_session_id IN promotion.session_id%type
)
IS
	v_roll students_info.roll%type;
	v_course courses%rowtype;
	--v_val number;
	
	cursor stu_roll_cursor IS
	select roll from students_info s, promotion p 
	where s.session_id= p.session_id and p.prom_id=p_prom_id and upper(status)= 'REGULAR';

	cursor course_cursor IS
	select course_id,course_code,type from courses c,promotion p
	where c.session_id= p.session_id and c.sem_id= p.sem_id and p.prom_id=p_prom_id;


BEGIN

	IF old_system(p_prom_id)!=0	THEN

		FOR v_roll IN stu_roll_cursor
		LOOP
		
			FOR v_course IN course_cursor
			LOOP
				IF mod(to_number(substr(v_course.course_code,length(v_course.course_code))),2)!=0 AND v_course.type IS NULL
				THEN 
					insert_marks_thry_old(v_roll.roll,v_course.course_id,p_prom_id);
				
				END IF;
			
				IF mod(to_number(substr(v_course.course_code,length(v_course.course_code))),2)=0 AND v_course.type IS NULL
				THEN 
					insert_marks_lab_old(v_roll.roll,v_course.course_id,p_prom_id);

				END IF;

				IF v_course.type = upper('thesis/project')
				THEN insert_marks_thesis_pro(v_roll.roll,v_course.course_id,p_prom_id);
				END IF;

				IF v_course.type = upper('viva-voce')
				THEN insert_marks_viva(v_roll.roll,v_course.course_id,p_prom_id);
				END IF;
			
			END LOOP;
		
		END LOOP;
	
	ELSE
		FOR v_roll IN stu_roll_cursor
		LOOP
		
			FOR v_course IN course_cursor
			LOOP
				IF mod(to_number(substr(v_course.course_code,length(v_course.course_code))),2)!=0 AND v_course.type IS NULL
				THEN 
					insert_marks_thry(v_roll.roll,v_course.course_id,p_prom_id);
				
				END IF;
			
				IF mod(to_number(substr(v_course.course_code,length(v_course.course_code))),2)=0 AND v_course.type IS NULL
				THEN 
					insert_marks_lab(v_roll.roll,v_course.course_id,p_prom_id);

				END IF;

				IF v_course.type = upper('thesis/project')
				THEN insert_marks_thesis_pro(v_roll.roll,v_course.course_id,p_prom_id);
				END IF;

				IF v_course.type = upper('viva-voce')
				THEN insert_marks_viva(v_roll.roll,v_course.course_id,p_prom_id);
				END IF;
			
			END LOOP;
		
		END LOOP;
	END IF;
END;
/

delete from marks_theory;
delete from marks_theory_old;
delete from marks_lab;
delete from marks_lab_old;
delete from marks_thesis_pro;
delete from marks_viva;




--marks_theory_old table:insert marks
----------------------------------
drop procedure input_marks_thry;
create procedure input_marks_thry
(p_roll IN marks_theory.roll%type,
p_cid IN marks_theory.course_id%type,
p_pid IN marks_theory.prom_id%type,
p_i72 IN OUT varchar2,
p_e72 IN OUT varchar2,
p_t72 IN OUT varchar2,
p_20 IN OUT varchar2,
p_8 IN OUT varchar2,
p_100 OUT number,
p_gp OUT number,
p_lg OUT varchar2,
p_exc OUT varchar2)
IS
	v_in_ex number;
	v_in_th number;
	v_ex_th number;
	v_i72 number;
	v_e72 number;
	v_t72 number;

BEGIN
	UPDATE marks_theory 
	SET internal_72=to_number(p_i72) ,external_72=to_number(p_e72), third_72=to_number(p_t72), ct_20=to_number(p_20) ,att_8=to_number(p_8)
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;
commit;

	select to_number(internal_72),to_number(external_72),to_number(third_72),to_char(NVL(internal_72,0)),to_char(NVL(external_72,0)),third_72,to_char(NVL(ct_20,0)),to_char(NVL(att_8,0))
	into v_i72,v_e72,v_t72,p_i72,p_e72,p_t72,p_20,p_8
	from marks_theory
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;

	--p_100:=p_a_36+p_b_36+p_20+p_8;

	select abs(to_number(internal_72)-to_number(external_72)),	abs(to_number(internal_72)-to_number(third_72)),abs(to_number(external_72)-to_number(third_72))
	into v_in_ex,v_in_th,v_ex_th
	from marks_theory
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;



IF (v_in_ex<=(72*.2)) THEN
	select (to_number(internal_72)+to_number(external_72))/2+to_number(ct_20)+to_number(att_8), (select lett_grd from grade_scale where (to_number(internal_72)+to_number(external_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim),(select gp from grade_scale where (to_number(internal_72)+to_number(external_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim)
	into p_100,p_lg,p_gp
	from marks_theory
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;

	p_t72:='XX';

ELSIF (v_in_ex>(72*.2)) THEN

	IF (p_t72 is NULL) THEN
		p_t72:='REQUIRED';

	ELSE

		IF ((v_in_th> v_ex_th) or (v_in_th=v_ex_th and (v_e72>v_i72))) THEN

			select (to_number(external_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8), (select lett_grd from grade_scale where (to_number(external_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim),(select gp from grade_scale where (to_number(external_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim)
			into p_100,p_lg,p_gp
			from marks_theory
			where roll=p_roll and course_id=p_cid and prom_id=p_pid;

		ELSIF ((v_in_th< v_ex_th) or (v_in_th=v_ex_th and (v_e72<v_i72))) THEN	
			select (to_number(internal_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8), (select lett_grd from grade_scale where (to_number(internal_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim),(select gp from grade_scale where (to_number(internal_72)+to_number(third_72))/2+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim)
			into p_100,p_lg,p_gp
			from marks_theory
			where roll=p_roll and course_id=p_cid and prom_id=p_pid;

		END IF;
	
	END IF;

END IF;



EXCEPTION
	WHEN VALUE_ERROR THEN
		p_exc:='Invalid number';
	WHEN OTHERS THEN
		p_exc:='invalid';	

END input_marks_thry;
/





--marks_theory_old table:insert marks
----------------------------------
drop procedure input_marks_thry_old;
create procedure input_marks_thry_old
(p_roll IN marks_theory_old.roll%type,
p_cid IN marks_theory_old.course_id%type,
p_pid IN marks_theory_old.prom_id%type,
p_a_36 IN OUT varchar2,
p_b_36 IN OUT varchar2,
p_20 IN OUT varchar2,
p_8 IN OUT varchar2,
p_100 OUT number,
p_gp OUT number,
p_lg OUT varchar2,
p_exc OUT varchar2)
IS
	

BEGIN
	UPDATE marks_theory_old 
	SET part_a_36=to_number(p_a_36) ,part_b_36=to_number(p_b_36) ,ct_20=to_number(p_20) ,att_8=to_number(p_8)
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;
commit;

	select to_char(NVL(part_a_36,0)),to_char(NVL(part_b_36,0)),to_char(NVL(ct_20,0)),to_char(NVL(att_8,0))
	into p_a_36,p_b_36,p_20,p_8
	from marks_theory_old
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;

	--p_100:=p_a_36+p_b_36+p_20+p_8;

	select to_number(part_a_36)+to_number(part_b_36)+to_number(ct_20)+to_number(att_8), (select lett_grd from grade_scale where to_number(part_a_36)+to_number(part_b_36)+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim),(select gp from grade_scale where to_number(part_a_36)+to_number(part_b_36)+to_number(ct_20)+to_number(att_8) between lower_lim and upper_lim)
	into p_100,p_lg,p_gp
	from marks_theory_old
	where roll=p_roll and course_id=p_cid and prom_id=p_pid;


EXCEPTION
	WHEN VALUE_ERROR THEN
		p_exc:='Invalid number';
	WHEN OTHERS THEN
		p_exc:='invalid';	

END input_marks_thry_old;
/




