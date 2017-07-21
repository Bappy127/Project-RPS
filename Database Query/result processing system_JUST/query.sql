--query for students name with their dept
---------------------------------------------
select s.roll,s.s_name,d.dept_name
from students_info s,sessions se,departments d
where s.session_id=se.session_id and se.dept_id=d.dept_id;


--query for finding theory courses
-----------------------------------
select course_code "THEORY", course_title from courses where mod(to_number(substr(course_code,length(course_code))),2)!=0;


--query for finding lab courses
---------------------------------
select course_code "LAB", course_title from courses where substr(course_code,length(course_code)) in (2,4,6);
select course_code "LAB", course_title from courses where mod(to_number(substr(course_code,length(course_code))),2)=0;

--inserting courses format
---------------------------
insert into courses values ('c1',upper('CSE 1101'),'Introduction to Computer Systems & IT','s1','11',2.00);


--generating students_id
--------------------------
select substr(s.session_desc,3,2) || p.dept_id ||'01' 
from sessions s, programs p
where s.prog_id=p.prog_id and s.session_id='s1';

--finding programs with its sessions
------------------------------------
select s.session_id,s.session_desc,p.prog_abbr 
from sessions s, programs p 
where s.prog_id=p.prog_id 
order by prog_abbr,session_desc;

--checking asigned course
--------------------------
select m.roll,c.course_code 
from marks_theory m,courses c 
where m.course_id=c.course_id order by m.roll;




select count(session_id) from promotion where prom_id='n7' and prom_id IN
(select p.prom_id from promotion p,sessions s
where s.session_id=p.session_id and s.session_desc='2008-2009' and sem_id between 'm1' and 'm6'
union
select p.prom_id from promotion p,sessions s
where s.session_id=p.session_id and s.session_desc='2009-2010' and p.sem_id between 'm1'and 'm4'
union
select p.prom_id from promotion p,sessions s
where s.session_id=p.session_id and s.session_desc='2010-2011' and p.sem_id between 'm1'and 'm2')



--calculating tatal 100 marks
--------------------------------
select part_a_36,part_b_36,ct_20,att_8,NVL(part_a_36,0)+NVL(part_b_36,0)+NVL(ct_20,0)+NVL(att_8,0) "total", (select lett_grd from grade_scale where NVL(part_a_36,0)+NVL(part_b_36,0)+NVL(ct_20,0)+NVL(att_8,0) between lower_lim and upper_lim) "LG"
from marks_theory_old
where roll='080101' and course_id='c1' and prom_id='n1';



--calculating marks theory new
------------------------------
select abs(to_number(internal_72)-to_number(external_72)) "inex",	abs(to_number(internal_72)-to_number(third_72)) "inth",abs(to_number(external_72)-to_number(third_72)) "exth"
from marks_theory
where roll='080101' and course_id='c55' and prom_id='n7'

