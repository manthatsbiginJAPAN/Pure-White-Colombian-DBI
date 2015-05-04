BEGIN
delete from Studentteamallocation;
delete from Team;
delete from Meetingtype;
delete from Enrolment;
delete from Project;
delete from Unitoffering;
delete from Student;
delete from Employeerole;
delete from RoleType;
delete from Employee;
delete from Unit;

UC1_1_Register_Employee('1234567', 'Sam', 'Hartwig', 'sam@hartwig.net.au', '0413318603', 'password123');
UC1_1_Register_Employee('1111111', 'Eric', 'Palalalalaluca', 'TheBigE@papdapaluca.net', '0413318604', 'password1234');	

UC1_5_Register_Unit('INF10101', 'Ericology', 'Papaluca teaches the masses');
UC1_5_Register_Unit('INF20004', 'Database Implementation', 'Taught by a great guy');	

UC1_9_Register_Student('7654321', 'Stevey', 'Paile', 'aanwar@hotmale.com.au', '0413318603', 'password123');
UC1_9_Register_Student('7668977', 'Frank', 'PalalucucacacacA', 'TheBigE@papdapaluca.net', '0413318604', 'password1234');	

UC1_17_Register_Role_Type('Supervisor');
UC1_17_Register_Role_Type('Convenor');
UC1_17_Register_Role_Type('Admin');

UC1_25_Register_Employee_Role('1111111', 'Admin');
UC1_25_Register_Employee_Role('1234567', 'Supervisor');
UC1_25_Register_Employee_Role('1111111', 'Convenor');

UC1_21_Register_Unit_Offering('INF10101', 1, 2015, '1111111', 'Convenor');
UC1_21_Register_Unit_Offering('INF10101', 1, 2014, '1111111', 'Convenor');
UC1_21_Register_Unit_Offering('INF20004', 2, 2015, '1111111', 'Convenor');
UC1_21_Register_Unit_Offering('INF20004', 2, 2014, '1111111', 'Convenor');

UC1_13_Register_Enrolment('7654321', 'INF10101', 1, 2015);
UC1_13_Register_Enrolment('7668977', 'INF10101', 1, 2014);
UC1_13_Register_Enrolment('7654321', 'INF20004', 2, 2015);
UC1_13_Register_Enrolment('7668977', 'INF20004', 2, 2014);

INSERT INTO MeetingType VALUES ('Student');
INSERT INTO MeetingType VALUES ('Supervisor');
INSERT INTO MeetingType VALUES ('Client');




UC2_5_Register_Project('PROJ1', 'Project 1', 'INF10101', 1, 2015);
UC2_5_Register_Project('PROJ2', 'Project 2', 'INF20004', 2, 2014);

UC2_1_Register_Team('Team1', 'PROJ1', 'INF10101', 1, 2015, '1234567', 'Supervisor');
UC2_1_Register_Team('Team1', 'PROJ2', 'INF20004', 2, 2014, '1234567', 'Supervisor');

--UC2_17_Register_Team_Allo('Team1', '7668977', 'INF10101', 1, 2015);
--UC2_17_Register_Team_Allo('Team1', '7654321', 'INF10101', 1, 2015);
--UC2_17_Register_Team_Allo('Team1', '7668977', 'INF20004', 2, 2014);
UC2_17_Register_Team_Allo('Team1', '7654321', 'INF20004', 2, 2014);

--UC3_2_Register_Meeting('MT1895', 'Team1', 'INF10101', 1, 2015, 'Student', 2015-03-04 13:34:21, 2015-03-04 15:27:17, 'minutes.exe #TODO', '1234567', null);
--UC3_2_Register_Meeting('MT1899', 'Team1', 'INF20004', 2, 2014, 'Student', 2014-08-04 15:30:41, 2014-08-04 18:22:11, 'minutes.exe #TODO', '1111111', null);



END;