UC1_1_Register_Employee('1234567', 'Sam', 'Hartwig', 'sam@hartwig.net.au', '0413318603', 'password123');
UC1_1_Register_Employee('1111111', 'Eric', 'Palalalalaluca', 'TheBigE@papdapaluca.net', '0413318604', 'password1234');	
--Test invalid ID
--UC1_1_Register_Employee('766890933', 'Eric', 'Palalalalaluca', 'TheBigE@papdapaluca.net', '0413318604', 'password1234');	
--Test invalid email
--UC1_1_Register_Employee('7668909', 'Eric', 'Palalalalalucia', 'TheBigEpapdapalucia.net', '0413318604', 'password1234');	
--Test invalid phone
--UC1_1_Register_Employee('7668909', 'Eric', 'Palalalalalucia', 'TheBigE@papdapalucia.net', '0413318604911', 'password1234');	

UC1_5_Register_Unit('INF10101', 'Eric', 'Papaluca');
UC1_5_Register_Unit('INF20004', 'Database Implementation', 'Taught by a great guy');	

UC1_9_Register_Student('7654321', 'Steve', 'Paile', 'aanwar@hotmale.com.au', '0413318603', 'password123');
UC1_9_Register_Student('7668977', 'Eric', 'PalalucucacacacA', 'TheBigE@papdapaluca.net', '0413318604', 'password1234');	

UC1_13_Register_Enrolment('7654321', 'INF10101', 1, 2015);
UC1_13_Register_Enrolment('7668977', 'INF10101', 1, 2014);
UC1_13_Register_Enrolment('7654321', 'INF20004', 2, 2015);
UC1_13_Register_Enrolment('7668977', 'INF20004', 2, 2014);

UC1_17_Register_Role_Type('Supervisor');
UC1_17_Register_Role_Type('Convenor');
UC1_17_Register_Role_Type('Admin');

UC1_21_Register_Unit_Offering('INF10101', 1, 2015);
UC1_21_Register_Unit_Offering('INF10101', 1, 2014);
UC1_21_Register_Unit_Offering('INF20004', 2, 2015);
UC1_21_Register_Unit_Offering('INF20004', 2, 2014);

INSERT INTO MeetingType VALUES ('Student');
INSERT INTO MeetingType VALUES ('Supervisor');
INSERT INTO MeetingType VALUES ('Client');

UC1_33_Register_Ass_Type('Group', 'Supple');
UC1_33_Register_Ass_Type('Individual', 'Not Supple');

UC2_1_Register_Team('4321', 'PROJ1', 'INF10101', 1, 2015, '1234567');
UC2_1_Register_Team('4321', 'PROJ1', 'INF10101', 1, 2015, '1111111');
UC2_1_Register_Team('5678', 'PROJ2', 'INF20004', 2, 2014, '1111111');

UC2_5_Register_Project
UC2_5_Register_Project