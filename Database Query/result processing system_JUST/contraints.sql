--dropping foreign key constraints
-----------------------------------
alter table marks_viva drop constraint mrks_viva_stu_fk;

alter table marks_viva drop constraint mrks_viva_cou_fk;

alter table marks_viva drop constraint mrks_viva_prom_fk;

alter table marks_viva drop constraint mrks_viva_grd_fk;

alter table marks_lab_old drop constraint mrks_lab_old_stu_fk;

alter table marks_lab_old drop constraint mrks_lab_old_cou_fk;

alter table marks_lab_old drop constraint mrks_lab_old_prom_fk;

alter table marks_lab_old drop constraint mrks_lab_old_grd_fk;

alter table marks_theory_old drop constraint mrks_thry_old_stu_fk;

alter table marks_theory_old drop constraint mrks_thry_old_cou_fk;

alter table marks_theory_old drop constraint mrks_thry_old_prom_fk;

alter table marks_theory_old drop constraint mrks_thry_old_grd_fk;

alter table marks_thesis_pro drop constraint mrks_thpr_stu_fk;

alter table marks_thesis_pro drop constraint mrks_thpr_cou_fk;

alter table marks_thesis_pro drop constraint mrks_thpr_prom_fk;

alter table marks_thesis_pro drop constraint mrks_thpr_grd_fk;

alter table marks_lab drop constraint mrks_lab_stu_fk;

alter table marks_lab drop constraint mrks_lab_cou_fk;

alter table marks_lab drop constraint mrks_lab_prom_fk;

alter table marks_lab drop constraint mrks_lab_grd_fk;

alter table marks_theory drop constraint mrks_thry_stu_fk;

alter table marks_theory drop constraint mrks_thry_cou_fk;

alter table marks_theory drop constraint mrks_thry_prom_fk;

alter table marks_theory drop constraint mrks_thry_grd_fk;

alter table promotion drop constraint prom_sess_fk;

alter table promotion drop constraint prom_sem_fk;

alter table courses drop constraint cour_sess_fk;

alter table courses drop constraint cour_sem_fk;

alter table students_info drop constraint stu_resi_id_fk;

alter table students_info drop constraint stu_sess_fk;

alter table students_info drop constraint stu_sess_orgn_fk;

alter table sessions drop constraint sess_prog_fk;

alter table programs drop constraint prog_dep_fk;

alter table departments drop constraint dep_fac_fk; 



--dropping unique key constraints
---------------------------------
alter table courses drop constraint courses_uk;

alter table grade_scale drop constraint grade_scale_uk;

alter table promotion drop constraint promotion_uk;

alter table students_info drop constraint stu_regi_uk;

alter table students_info drop constraint stu_ph_uk;

alter table students_info drop constraint stu_email_uk;

alter table residential_hall drop constraint resident_name_uk;

alter table semesters drop constraint sem_id_uk;

alter table sessions drop constraint sessions_uk;

alter table programs drop constraint prog_uk;

alter table programs drop constraint prog_abbr_uk;

alter table departments drop constraint dept_name_uk;

alter table departments drop constraint dept_code_uk;

alter table departments drop constraint dept_abbr_uk;

alter table faculty drop constraint fac_name_uk; 




--dropping primary key constraints
------------------------------------
alter table marks_viva drop constraint marks_viva_pk;

alter table marks_lab_old drop constraint marks_lab_old_pk;

alter table marks_theory_old drop constraint marks_theory_old_pk;

alter table marks_thesis_pro drop constraint marks_thesis_pro_pk;

alter table marks_lab drop constraint marks_lab_pk;

alter table marks_theory drop constraint marks_theory_pk;

alter table grade_scale drop constraint grade_scale_pk;

alter table courses drop constraint courses_pk;

alter table promotion drop constraint promotion_pk;

alter table students_info drop constraint students_info_pk;

alter table residential_hall drop constraint resident_id_pk;

alter table sessions drop constraint sessions_pk;

alter table programs drop constraint programs_pk;

alter table departments drop constraint departments_pk;

alter table faculty drop constraint faculty_pk; 

alter table semesters drop constraint semesters_pk;



--dropping check constraints
------------------------------------
alter table marks_theory drop constraint marks_thry_i72_ck;

alter table marks_theory drop constraint marks_thry_e72_ck;

alter table marks_theory drop constraint marks_thry_t72_ck;

alter table marks_theory drop constraint marks_thry_ct20_ck;

alter table marks_theory drop constraint marks_thry_att20_ck;

alter table marks_lab drop constraint marks_lab_cpa10_ck;

alter table marks_lab drop constraint marks_lab_qv30_ck;

alter table marks_lab drop constraint marks_lab_pr10_ck;

alter table marks_thesis_pro drop constraint marks_thpro_i60_ck;

alter table marks_thesis_pro drop constraint marks_thpro_e60_ck;

alter table marks_thesis_pro drop constraint marks_thpro_t60_ck;

alter table marks_thesis_pro drop constraint marks_thpro_pr30_ck;

alter table marks_thesis_pro drop constraint marks_thpro_vv10_ck;

alter table marks_theory_old drop constraint marks_theory_old_a36_ck;

alter table marks_theory_old drop constraint marks_theory_old_b36_ck;

alter table marks_theory_old drop constraint marks_theory_old_ct20_ck;

alter table marks_theory_old drop constraint marks_theory_old_att8_ck;

alter table marks_lab_old drop constraint marks_lab_old_att10_ck;

alter table marks_lab_old drop constraint marks_lab_old_qz20_ck;

alter table marks_lab_old drop constraint marks_lab_old_vv20_ck;

alter table marks_lab_old drop constraint marks_lab_old_rp50_ck;

alter table marks_viva drop constraint marks_t100_ck;

alter table courses drop constraint courses_crdt_ck;

alter table courses drop constraint courses_type_ck;

alter table students_info drop constraint stu_status_ck;

alter table semesters drop constraint sem_year_ck;

alter table semesters drop constraint sem_sem_ck;

alter table programs drop constraint prog_degr_ck;




--faculty table
----------------
alter table faculty
add constraint faculty_pk primary key(fac_id);

alter table faculty
add constraint fac_name_uk unique(fac_name); 



--departments table
--------------------
alter table departments
add constraint departments_pk primary key(dept_id);

alter table departments
add constraint dep_fac_fk foreign key(fac_id)
references faculty(fac_id);

alter table departments 
add constraint dept_name_uk unique(dept_name);

alter table departments 
add constraint dept_code_uk unique(dept_code);

alter table departments 
add constraint dept_abbr_uk unique(dept_abbr);



--programs table
-----------------
alter table programs
add constraint programs_pk primary key(prog_name,dept_id);

alter table programs
add constraint prog_dep_fk foreign key(dept_id)
references departments(dept_id);

alter table programs
add constraint prog_uk unique(prog_id);

alter table programs
add constraint prog_abbr_uk unique(prog_abbr);

alter table programs
add constraint prog_degr_ck check(degree in (upper('bachelor'),upper('master'),upper('doctorate'),upper('post doc')));



--sessions table
----------------
alter table sessions
add constraint sessions_pk primary key(session_desc,prog_id);

alter table sessions
add constraint sess_prog_fk foreign key(prog_id)
references programs(prog_id);

alter table sessions
add constraint sessions_uk unique(session_id);



--semesters table
----------------
alter table semesters
add constraint semesters_pk primary key(year,sem);

alter table semesters
add constraint sem_id_uk unique(sem_id);

alter table semesters
add constraint sem_year_ck check(year in (initcap('1st'),initcap('2nd'),initcap('3rd'),initcap('4th')));

alter table semesters
add constraint sem_sem_ck check (sem in (initcap('1st'),initcap('2nd')));


--residential_hall table
----------------

alter table residential_hall
add constraint resident_id_pk primary key(resident_id);

alter table residential_hall
add constraint resident_name_uk unique(resident_name);


--students_info table
----------------------
alter table students_info
add constraint students_info_pk primary key(roll); 

alter table students_info
add constraint stu_sess_fk foreign key(session_id)
references sessions(session_id);

alter table students_info
add constraint stu_sess_orgn_fk foreign key(session_id_origin)
references sessions(session_id) on delete cascade;

alter table students_info
add constraint stu_regi_uk unique(regi_no);

alter table students_info
add constraint stu_ph_uk unique(phone);

alter table students_info
add constraint stu_email_uk unique(email);

alter table students_info
add constraint stu_status_ck check(status in (upper('regular'),upper('withdrawn')));

alter table students_info
add constraint stu_resi_id_fk foreign key(resident_id)
references residential_hall(resident_id);




--courses table
----------------
alter table courses
add constraint courses_pk primary key(course_code,session_id);

alter table courses
add constraint cour_sess_fk foreign key(session_id)
references sessions(session_id);

alter table courses
add constraint cour_sem_fk foreign key(sem_id)
references semesters(sem_id);

alter table courses
add constraint courses_uk unique(course_id);

alter table courses
add constraint courses_crdt_ck check(crdt in (1.00,1.50,2.00,3.00));

alter table courses
add constraint courses_type_ck check(type in (upper('viva-voce'),upper('thesis/project')));



--promotion table
------------------
alter table promotion
add constraint promotion_pk primary key(session_id,sem_id);

alter table promotion
add constraint prom_sess_fk foreign key(session_id)
references sessions(session_id);

alter table promotion
add constraint prom_sem_fk foreign key(sem_id)
references semesters(sem_id);

alter table promotion
add constraint promotion_uk unique(prom_id);



--grade_scale table
----------------------
alter table grade_scale
add constraint grade_scale_pk primary key(gp);

alter table grade_scale
add constraint grade_scale_uk unique(lett_grd);



--marks_theory table
---------------------
alter table marks_theory
add constraint marks_theory_pk primary key(roll,course_id,prom_id);

alter table marks_theory
add constraint mrks_thry_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_theory
add constraint mrks_thry_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_theory
add constraint mrks_thry_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_theory
add constraint mrks_thry_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_theory
add constraint marks_thry_i72_ck check(internal_72 between 0 and 72);

alter table marks_theory
add constraint marks_thry_e72_ck check(external_72 between 0 and 72);

alter table marks_theory
add constraint marks_thry_t72_ck check(third_72 between 0 and 72);

alter table marks_theory
add constraint marks_thry_ct20_ck check(ct_20 between 0 and 20);

alter table marks_theory
add constraint marks_thry_att20_ck check(att_8 between 0 and 8);



--marks_lab table
---------------------
alter table marks_lab
add constraint marks_lab_pk primary key(roll,course_id,prom_id);

alter table marks_lab
add constraint mrks_lab_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_lab
add constraint mrks_lab_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_lab
add constraint mrks_lab_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_lab
add constraint mrks_lab_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_lab
add constraint marks_lab_cpa10_ck check(cpa_10 between 0 and 10);

alter table marks_lab
add constraint marks_lab_qv30_ck check(qv_30 between 0 and 30);

alter table marks_lab
add constraint marks_lab_pr10_ck check(pr_60 between 0 and 60);



--marks_thesis_pro table
---------------------
alter table marks_thesis_pro
add constraint marks_thesis_pro_pk primary key(roll,course_id,prom_id);

alter table marks_thesis_pro
add constraint mrks_thpr_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_thesis_pro
add constraint mrks_thpr_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_thesis_pro
add constraint mrks_thpr_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_thesis_pro
add constraint mrks_thpr_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_thesis_pro
add constraint marks_thpro_i60_ck check(internal_60 between 0 and 60);

alter table marks_thesis_pro
add constraint marks_thpro_e60_ck check(external_60 between 0 and 60);

alter table marks_thesis_pro
add constraint marks_thpro_t60_ck check(third_60 between 0 and 60);

alter table marks_thesis_pro
add constraint marks_thpro_pr30_ck check(pr_30 between 0 and 30);

alter table marks_thesis_pro
add constraint marks_thpro_vv10_ck check(vv_10 between 0 and 10);





--marks_theory_old table
---------------------
alter table marks_theory_old
add constraint marks_theory_old_pk primary key(roll,course_id,prom_id);

alter table marks_theory_old
add constraint mrks_thry_old_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_theory_old
add constraint mrks_thry_old_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_theory_old
add constraint mrks_thry_old_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_theory_old
add constraint mrks_thry_old_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_theory_old
add constraint marks_theory_old_a36_ck check(part_a_36 between 0 and 36);

alter table marks_theory_old
add constraint marks_theory_old_b36_ck check(part_b_36 between 0 and 36);

alter table marks_theory_old
add constraint marks_theory_old_ct20_ck check(ct_20 between 0 and 20);

alter table marks_theory_old
add constraint marks_theory_old_att8_ck check(att_8 between 0 and 8);



--marks_lab_old table
---------------------
alter table marks_lab_old
add constraint marks_lab_old_pk primary key(roll,course_id,prom_id);

alter table marks_lab_old
add constraint mrks_lab_old_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_lab_old
add constraint mrks_lab_old_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_lab_old
add constraint mrks_lab_old_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_lab_old
add constraint mrks_lab_old_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_lab_old
add constraint marks_lab_old_att10_ck check(att_10 between 0 and 10);

alter table marks_lab_old
add constraint marks_lab_old_qz20_ck check(qz_20 between 0 and 20);

alter table marks_lab_old
add constraint marks_lab_old_vv20_ck check(vv_20 between 0 and 20);

alter table marks_lab_old
add constraint marks_lab_old_rp50_ck check(rp_50 between 0 and 50);



--marks_viva table
-------------------
alter table marks_viva
add constraint marks_viva_pk primary key(roll,course_id,prom_id);

alter table marks_viva
add constraint mrks_viva_stu_fk foreign key(roll)
references students_info(roll);

alter table marks_viva
add constraint mrks_viva_cou_fk foreign key(course_id)
references courses(course_id);

alter table marks_viva
add constraint mrks_viva_prom_fk foreign key(prom_id)
references promotion(prom_id);

alter table marks_viva
add constraint mrks_viva_grd_fk foreign key(lett_grd)
references grade_scale(lett_grd);

alter table marks_viva
add constraint marks_t100_ck check(total_100 between 0 and 100);














