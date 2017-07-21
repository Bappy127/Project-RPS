--values in faculty table
--------------------------
exec insert_faculty ('Engineering and Technology');
exec insert_faculty ('Biological Science');
exec insert_faculty ('Applied Science and Technology');
exec insert_faculty ('Physical Education, Sports, Culture and Languages');


--values in departments table
------------------------------
exec insert_departments ('Computer Science and Engineering','CSE','01','f1');
exec insert_departments ('Electrical and Electronic Engineering','EEE','02','f1');
exec insert_departments ('Industrial and Production Engineering','IPE','03','f1');
exec insert_departments ('Petroleum and Mining Engineering','PME','04','f1');
exec insert_departments ('Chemical Engineering','ChE','05','f1');
exec insert_departments ('Microbiology','MB','06','f2');
exec insert_departments ('Fisheries and Marine Bio-Science','FMB','07','f2');
exec insert_departments ('Pharmacy','Pharmacy','08','f2');
exec insert_departments ('Genetic Engineering and Biotechnology','GEBT','09','f2');
exec insert_departments ('Environmental Science and Technology','EST','10','f3');
exec insert_departments ('Nutrition and Food Technology','NFT','11','f3');
exec insert_departments ('Physical Education and Sport Science','PESS','12','f4');



--values in programs table
------------------------------
exec insert_programs ('bachelor','Bachelor of Science in Engineering','d1','B. Sc. Engg. in CSE');
exec insert_programs ('bachelor','Bachelor of Science in Engineering','d2','B. Sc. Engg. in EEE');
exec insert_programs ('bachelor','Bachelor of Science in Engineering','d3','B. Sc. Engg. in IPE');
exec insert_programs ('bachelor','Bachelor of Science in Engineering','d4','B. Sc. Engg. in PME');
exec insert_programs ('bachelor','Bachelor of Science in Engineering','d5','B. Sc. Engg. in ChE');

exec insert_programs ('bachelor','Bachelor of Science (Honours)','d6','B. Sc. (Honours) in MB');
exec insert_programs ('bachelor','Bachelor of Science (Honours)','d7','B. Sc. (Honours) in FMB');
exec insert_programs ('bachelor','Bachelor of Science (Honours)','d8','B. Pharm');
exec insert_programs ('bachelor','Bachelor of Science (Honours)','d9','B. Sc. in GEBT');

exec insert_programs ('bachelor','Bachelor of Science (Honours)','d10','B. Sc. (Honours) in EST');
exec insert_programs ('bachelor','Bachelor of Science (Honours)','d11','B. Sc. (Honours) in NFT');

exec insert_programs ('bachelor','Bachelor','d12','B. PESS');

exec insert_programs ('master','Master of Science in Engineering','d1','M. Sc. Engg. in CSE');
exec insert_programs ('master','Master in Engineering','d1','M. Engg. in CSE');

exec insert_programs ('master','Master of Science (Honours)','d6','M. Sc. (Honours) in MB');
exec insert_programs ('master','Master of Science (Honours)','d7','M. Sc. (Honours) in FMB');
exec insert_programs ('master','Master of Science (Honours)','d10','M. Sc. (Honours) in EST');



--values in sessions table
------------------------------
exec insert_sessions_new('2008','2009','p1',:g_exc);

exec insert_sessions_con('p1',:g_exc);
------------------------------------------------------

exec insert_sessions_new('2008','2009','p1');
exec insert_sessions_new('2008','2009','p6');
exec insert_sessions_new('2008','2009','p7');
exec insert_sessions_new('2008','2009','p10');

exec insert_sessions_con('p1');
exec insert_sessions_con('p6');
exec insert_sessions_con('p7');
exec insert_sessions_con('p10');
exec insert_sessions_new('2009','2010','p3');
exec insert_sessions_new('2009','2010','p4');
exec insert_sessions_new('2009','2010','p5');
exec insert_sessions_new('2009','2010','p9');

exec insert_sessions_con('p1');
exec insert_sessions_con('p6');
exec insert_sessions_con('p7');
exec insert_sessions_con('p10');
exec insert_sessions_con('p3');
exec insert_sessions_con('p4');
exec insert_sessions_con('p5');
exec insert_sessions_con('p9');
exec insert_sessions_new('2010','2011','p8');
exec insert_sessions_new('2010','2011','p11');

exec insert_sessions_con('p1');
exec insert_sessions_con('p6');
exec insert_sessions_con('p7');
exec insert_sessions_con('p10');
exec insert_sessions_con('p3');
exec insert_sessions_con('p4');
exec insert_sessions_con('p5');
exec insert_sessions_con('p9');
exec insert_sessions_con('p8');
exec insert_sessions_con('p11');
exec insert_sessions_new('2011','2012','p2');
exec insert_sessions_new('2011','2012','p12');

exec insert_sessions_con('p1');
exec insert_sessions_con('p6');
exec insert_sessions_con('p7');
exec insert_sessions_con('p10');
exec insert_sessions_con('p3');
exec insert_sessions_con('p4');
exec insert_sessions_con('p5');
exec insert_sessions_con('p9');
exec insert_sessions_con('p8');
exec insert_sessions_con('p11');
exec insert_sessions_con('p2');
exec insert_sessions_con('p12');



--values in semesters table
------------------------------
exec insert_semesters('First','First');
exec insert_semesters('First','Second');
exec insert_semesters('Second','First');
exec insert_semesters('Second','Second');
exec insert_semesters('Third','First');
exec insert_semesters('Third','Second');
exec insert_semesters('Fourth','First');
exec insert_semesters('Fourth','Second');


--exec insert_semesters('Fourth','Second',:g_exc);


--values in grade_scale table
-----------------------------
variable g_exc varchar2(10);
exec insert_grade_scale('100','80','4.00','A+',:g_exc);
print g_exc;

exec insert_grade_scale (100,80,4.00,'A+',:g_exc);
exec insert_grade_scale (79.5,75,3.75,'A',:g_exc);
exec insert_grade_scale (74.5,70,3.50,'A-',:g_exc);
exec insert_grade_scale (69.5,65,3.25,'B+',:g_exc);
exec insert_grade_scale (64.5,60,3.00,'B',:g_exc);
exec insert_grade_scale (59.5,55,2.75,'B-',:g_exc);
exec insert_grade_scale (54.5,50,2.50,'C+',:g_exc);
exec insert_grade_scale (49.5,45,2.25,'C',:g_exc);
exec insert_grade_scale (44.5,40,2.00,'C-',:g_exc);
exec insert_grade_scale (39.5,0,0.00,'F',:g_exc);


--values in students_info table
--------------------------------
variable g_sess varchar2(10);
BEGIN
	:g_sess:='s1';
END;
/
exec insert_students('101','rakib',:g_sess,'01918059864','jess','chadpur','rakib1@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'))
exec insert_students('102','nazmu',:g_sess,'01918059865','jess','jessore','nazmul@gmail.com',to_date('22-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('103','nowsh',:g_sess,'01918059866','jess','chadpur','rakib2@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('104','snigh',:g_sess,'01918059867','jess','chadpur','rakib3@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('105','rasel',:g_sess,'01918059868','jess','chadpur','rakib4@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('106','sunan',:g_sess,'01918059869','jess','chadpur','rakib5@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('107','belal',:g_sess,'01918059870','jess','chadpur','rakib6@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('','belal',:g_sess,'01919059870','jess','chadpur','rakib12@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('withdrawn'));
exec insert_students('108','banna',:g_sess,'01918059871','jess','chadpur','rakib7@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('109','nahid',:g_sess,'01918059872','jess','chadpur','rakib8@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('110','arafa',:g_sess,'01918059873','jess','chadpur','rakib9@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('810','sayed',:g_sess,'01738017150','jess','chadpur','june20@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('112','sayda',:g_sess,'01938017150','jess','chadpur','saum20@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));

BEGIN
	:g_sess:='s5';
END;
/
exec insert_students('901','june1',:g_sess,'01738017142','jess','chadpur','june11@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('902','emma1',:g_sess,'01738017143','jess','jessore','june12@gmail.com',to_date('22-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('903','moni1',:g_sess,'01738017144','jess','chadpur','june13@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('','belal',:g_sess,'01918159870','jess','chadpur','rakib58@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('904','rakib',:g_sess,'01738017145','jess','chadpur','june14@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('905','rubin',:g_sess,'01738017146','jess','chadpur','june15@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('','belal',:g_sess,'01918069870','jess','chadpur','rakib45@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('906','kaniz',:g_sess,'01738017147','jess','chadpur','june16@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('907','tanim',:g_sess,'01738017148','jess','chadpur','june17@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('908','sabia',:g_sess,'01738017141','jess','chadpur','june18@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('809','reshm',:g_sess,'01738017149','jess','chadpur','june19@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('910','debra',:g_sess,'01938017148','jess','chadpur','saum17@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('911','iqbal',:g_sess,'01938017141','jess','chadpur','saum18@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('111','rakhi',:g_sess,'01938017149','jess','chadpur','saum19@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));


BEGIN
	:g_sess:='s13';
END;
/
exec insert_students('010','saumo',:g_sess,'01938017142','jess','chadpur','saum11@gmail.com',to_date('21-11-1992','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('011','sampa',:g_sess,'01938017143','jess','jessore','saum12@gmail.com',to_date('22-11-1992','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('012','monji',:g_sess,'01938017144','jess','chadpur','saum13@gmail.com',to_date('21-11-1992','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('013','tanji',:g_sess,'01938017145','jess','chadpur','saum14@gmail.com',to_date('21-11-1992','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('','belal',:g_sess,'01918259870','jess','chadpur','rakib37@gmail.com',to_date('21-11-1990','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('909','taufi',:g_sess,'01938017146','jess','chadpur','saum15@gmail.com',to_date('21-11-1991','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));
exec insert_students('014','abeer',:g_sess,'01938017147','jess','chadpur','saum16@gmail.com',to_date('21-11-1992','dd-mm-yyyy'),'islam','bangladeshi','Mr. A','Mrs. B',upper('regular'));


--update students due to readmission and year drop
---------------------------------------------------
update students_info set session_id='s5' where roll='080111';
update students_info set session_id='s5',session_id_origin='s5' where roll='080112';
update students_info set session_id='s13',session_id_origin='s1' where roll='080113';

update students_info set session_id='s13' where roll='090111';
update students_info set session_id='s13' where roll='090112';
update students_info set session_id='s13',session_id_origin='s13' where roll='090113';
update students_info set session_id='s13',session_id_origin='s13' where roll='090114';




--values in courses table
--------------------------------
set define off;
--syllabus for session_id s1
-----------------------------
variable g_c_sess varchar2(10);
variable g_sem varchar2(10);
variable g_exc varchar2(25);
BEGIN
	:g_c_sess:='s1';
	:g_sem:='m1';
END;
/
exec insert_courses ('CSE','1101','Introduction to Computer Systems & IT',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','1103','Structured Programming Language',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1105','Discrete Mathematics',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('ENG','1001','English Language ',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('MATH','1003','Algebra and Trigonometry',:g_c_sess,:g_sem,2.00,:g_exc);
exec insert_courses ('PHY','1003','Physics ( Heat Thermodynamics, Structure of Matter, Waves and Oscillations and Physical Optics',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1104','Structured Programming Language Lab',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('PHY','1104','Physics Lab',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('ENG','1002','English Language Lab',:g_c_sess,:g_sem,1.00,'',:g_exc);

BEGIN
	:g_sem:='m2';
END;
/
exec insert_courses ('CSE','1201','Electricity, Magnetism and Electrical Devices',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1202','Electricity, Magnetism and Electrical Devices Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','1203','Statistics',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CHEM','1205','Chem I',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CHEM','1206','Chem I Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('MATH','1201','Math II',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','1207','Data Structures and Algorithms',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1208','Data Structures and Algorithms Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','1200','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m3';
END;
/
exec insert_courses ('CSE','2101','Basic Electronics & Electronics Devices ',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2102','Basic Electronics & Electronics Devices Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','2103','Object Oriented Programming',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2104','Object Oriented Programming Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','2105','Digital Logic Design',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2106','Digital Logic Design Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('MATH','2101','Math III',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','2107','Computer Architecture and Organization ',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2100','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m4';
END;
/
exec insert_courses ('ESCO','2201','Economics and Sociology',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','2201','Algorithm Analysis and Design ',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2202','Algorithm Analysis and Design Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','2203','Numerical Methods',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2204','Numerical Methods Laboratory',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2205','Switching Devices and Pulse Techniques',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2206','Switching Devices and Pulse Techniques Laboratories',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','2210','Software Development Project I',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','2200','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m5';
END;
/
exec insert_courses ('CSE','3101','Microprocessors and Assembly Languages',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3102','Microprocessors and Assembly Languages Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3103','Database System',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3104','Database System Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3105','Operating Systems',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3107','Programming with JAVA',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3108','Programming with JAVA Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3109','Peripherals  and Interfacing',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3110','Peripherals  and Interfacing Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3100','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m6';
END;
/
exec insert_courses ('CSE','3201','Data Communication',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3202','Data Communication Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3203','System Analysis and Design',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3208','Web Based Programming',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('IMAC','3201','Industrial Management and Accounting ',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3205','Computer Graphics',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3206','Computer Graphics Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','3210','Software Development Project II',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','3200','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m7';
END;
/
exec insert_courses ('CSE','4101','Software Engineering',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4110','Project/Thesis',:g_c_sess,:g_sem,3.00,'thesis/project',:g_exc);
exec insert_courses ('CSE','4103','Computer Network',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4104','Computer Network Laboratories',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4105','Formal Languages & Automata Theory',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4107','Simulation and Modeling',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4108','Simulation and Modeling Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4109','Parallel and Distributed Processing',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4100','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m8';
END;
/
exec insert_courses ('CSE','4210','Project/Thesis',:g_c_sess,:g_sem,3.00,'thesis/project',:g_exc);
exec insert_courses ('CSE','4201','Artificial Intelligence ',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4202','Artificial Intelligence Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4203','Digital Signal and Image Processing',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4204','Digital Signal and Image Processing Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4208','Programming with C # Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4205','Compiler Design',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','4206','Compiler Design Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','4200','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);


--syllabus for session_id s5
-----------------------------
BEGIN
	:g_c_sess:='s5';
	:g_sem:='m1';
END;
/
exec insert_courses ('CSE','1101','Computer Fundamentals',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CHEM','1101','Chemistry',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CHEM','1102','Chemistry  Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('PHY','1101','Physics ( Heat Thermodynamics, Structure of Matter, Waves and Oscillations and Physical Optics)',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('PHY','1102','Physics  Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('ENG','1101','Communicative English',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('MATH','1101','Algebra and Trigonometry (Math I) ',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','1103','Element of Statistics and Probability',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1100','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);

BEGIN
	:g_sem:='m2';
END;
/
exec insert_courses ('CSE','1201','Structured Programming Language',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1202','Structured Programming Language Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','1203','Discrete Mathematics',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1205','Electricity, Magnetism and Electrical Devices',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1206','Electricity, Magnetism and Electrical Devices Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('MATH','1201','Calculus and Differential Equations (Math II)',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','1207','Basic Electronics and Electronic Devices',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1208','Basic Electronics and Electronic Devices Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','1200','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);



--syllabus for session_id s13
-----------------------------
BEGIN
	:g_c_sess:='s13';
	:g_sem:='m1';
END;
/
exec insert_courses ('CSE','1101','Computer Fundamentals',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CHEM','1101','Chemistry',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CHEM','1102','Chemistry  Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('PHY','1101','Physics ( Heat Thermodynamics, Structure of Matter, Waves and Oscillations and Physical Optics)',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('PHY','1102','Physics  Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('ENG','1101','Communicative English',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('MATH','1101','Calculus and Differential Equations (Math I)',:g_c_sess,:g_sem,2.00,'',:g_exc);
exec insert_courses ('CSE','1103','Electricity, Magnetism and Electrical Devices',:g_c_sess,:g_sem,3.00,'',:g_exc);
exec insert_courses ('CSE','1104','Electricity, Magnetism and Electrical Devices Laboratory',:g_c_sess,:g_sem,1.50,'',:g_exc);
exec insert_courses ('CSE','1100','Viva-Voce',:g_c_sess,:g_sem,1.00,'viva-voce',:g_exc);



--values for promotion table
--------------------------------
variable g_p_sess varchar2(10);
variable g_exc varchar2(25);
BEGIN
	:g_p_sess:='s1';
END;
/
exec insert_promotion(:g_p_sess,:g_exc);

BEGIN
	:g_p_sess:='s5';
END;
/
exec insert_promotion(:g_p_sess,:g_exc);

BEGIN
	:g_p_sess:='s13';
END;
/
exec insert_promotion(:g_p_sess,:g_exc);




--assign courses
------------------
exec assign_courses('n1');




--values for marks_theory_old
------------------------------



--values for marks_theory
------------------------------

variable g_roll varchar2(10);
variable g_cid varchar2(5);
variable g_pid varchar2(5);
variable g_i72 varchar2(15);
variable g_e72 varchar2(15);
variable g_t72 varchar2(15);
variable g_20 varchar2(15);
variable g_8 varchar2(15);
variable g_100 number;
variable g_gp number;
variable g_lg varchar2(5);
variable g_exc varchar2(15);

BEGIN
	:g_roll:='080101';
	:g_cid:='c55';
	:g_pid:='n7';
	:g_i72:='6a';
	:g_e72:='55';
	:g_t72:='';
	:g_20:='10';
	:g_8:='6';

END;
/

exec input_marks_thry(:g_roll,:g_cid,:g_pid,:g_i72,:g_e72,:g_t72,:g_20,:g_8,:g_100,:g_gp,:g_lg,:g_exc);

print g_roll;
print g_cid;
print g_pid;
print g_i72;
print g_e72;
print g_t72;
print g_20;
print g_8;
print g_100;
print g_gp;
print g_lg;
print g_exc;

























