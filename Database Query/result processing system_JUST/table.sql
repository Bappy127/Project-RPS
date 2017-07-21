--dropping tables
-------------------
drop table marks_viva;
drop table marks_thesis_pro;
drop table marks_lab_old;
drop table marks_lab;
drop table marks_theory_old;
drop table marks_theory;
drop table promotion;
drop table grade_scale;
drop table students_info;
drop table residential_hall;
drop table courses;
drop table semesters;
drop table sessions;
drop table programs;
drop table departments;
drop table faculty;



--faculty table
----------------
create table faculty(
fac_id varchar2(5),
fac_name varchar2(60) NOT NULL
);


--departments table
--------------------
create table departments(
dept_id varchar2(5),
dept_name varchar2(40) NOT NULL,
dept_abbr varchar2(10) NOT NULL,
dept_code varchar2(5) NOT NULL,
fac_id varchar2(5) NOT NULL
);


--programs table
--------------------
create table programs(
prog_id varchar2(5),
degree varchar2(20) NOT NULL,
prog_name varchar2(40) NOT NULL,
dept_id varchar2(5) NOT NULL,
prog_abbr varchar2(25) NOT NULL
);


--sessions table
----------------
create table sessions(
session_id varchar2(10) NOT NULL,
session_desc varchar2(12),
academic_year varchar2(8) NOT NULL,
prog_id varchar2(5)
);


--semesters table
------------------
create table semesters(
sem_id varchar2(5) NOT NULL,
year varchar2(10),
sem varchar2(10)
);


--courses table
----------------
create table courses(
course_id varchar2(10) NOT NULL,
course_code varchar2(10),
course_title varchar2(120),
session_id varchar2(10),
sem_id varchar2(5) NOT NULL,
crdt number(4,2) NOT NULL,
type varchar2(16)
);

--residential_hall table
----------------
create table residential_hall(
resident_id varchar2 (5),
resident_name varchar2(50) NOT NULL,
res_type varchar2(7)
);


--students_info table
-----------------
create table students_info(
roll varchar2(10),
regi_no varchar2(10),
s_name varchar2(30) NOT NULL,
session_id varchar2(10) NOT NULL,
session_id_origin varchar2(10) NOT NULL,
phone varchar2(15) NOT NULL,
address_temp varchar2(60) NOT NULL,
address_perm varchar2(60),
email varchar2(30),
dob date,
religion varchar2(10),
nationality varchar2(15),
father_name varchar2(30) NOT NULL,
mother_name varchar2(30) NOT NULL,
Status varchar2(15) NOT NULL,
resident_id varchar2(20) NOT NULL
);


--promotion table
-------------------
create table promotion(
prom_id varchar2(10) NOT NULL,
sem_id varchar2(5),
session_id varchar2(10)
);


--grade_scale table
--------------------
create table grade_scale(
upper_lim number(5,2) NOT NULL,
lower_lim number(5,2) NOT NULL,
gp number(4,2),
lett_grd varchar(3) NOT NULL
);


--marks_theory table
--------------------
create table marks_theory(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
status varchar2(15),
internal_72 number(4,2),
external_72 number(4,2),
third_72 number(4,2),
ct_20 number(4,2),
att_8 number(2),
total_100 number,
gp number(4,2),
lett_grd varchar(3),
status_third varchar2(10)
);


--marks_theory_old table
--------------------
create table marks_theory_old(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
status varchar2(15),
part_a_36 number(4,2),
part_b_36 number(4,2),
ct_20 number(4,2),
att_8 number(2),
total_100 number,
gp number(4,2),
lett_grd varchar(3)
);


--marks_lab table
--------------------
create table marks_lab(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
status varchar2(15),
cpa_10 number(2),
qv_30 number(4,2),
pr_60 number(4,2),
total_100 number,
gp number(4,2),
lett_grd varchar(3)
);


--marks_lab_old table
--------------------
create table marks_lab_old(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
status varchar2(15),
att_10 number(2),
qz_20 number(4,2),
vv_20 number(4,2),
rp_50 number(4,2),
total_100 number,
gp number(4,2),
lett_grd varchar(3)
);


--marks_thesis_pro table
------------------------
create table marks_thesis_pro(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
status varchar2(15),
internal_60 number(4,2),
external_60 number(4,2),
third_60 number(4,2),
pr_30 number(4,2),
vv_10 number(4,2),
total_100 number,
gp number(4,2),
lett_grd varchar(3),
status_third varchar2(10)
);


--marks_viva table
------------------------
create table marks_viva(
roll varchar2(10),
course_id varchar2(10),
prom_id varchar2(10),
total_100 number,
gp number(4,2),
lett_grd varchar(3),
status_third varchar2(10)
);





