CREATE OR REPLACE PROCEDURE UC1_1_Register_Employee
		( pEmpID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	INSERT INTO Employee VALUES (pEmpID, pFirstName, pLastName, pEmail, pContactNo, pPassword);
	dbms_output.put_line('Employee ' || pEmpID || ' added' ); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Employee ID  ' || pEmpID || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_2_Update_Employee
		(pEmpID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	UPDATE Employee
	SET FirstName = pFirstName,
		LastName = pLastName,
		Email = pEmail,
		ContactNo = pContactNo,
		Password = pPassword
	WHERE EmpID = pEmpID;
	dbms_output.put_line('Employee ' || pEmpID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE PROCEDURE UC1_3_View_Employee AS
	e Employee%ROWTYPE;
	CURSOR emps IS SELECT * FROM Employee Emp;
BEGIN
	dbms_output.put_line('Listing All Employee Details');
	OPEN emps;
	LOOP
		Fetch emps into e;
		Exit When emps%NOTFOUND;
		dbms_output.put_line('Employee ID: '|| e.EmpId --for testing
						 || ' First Name: ' ||e.FirstName
						 || ' Last Name: ' ||e.LastName
						 || ' Email: ' || e.Email
						 || ' ContactNo:' || e.ContactNo); 
	End Loop;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/

CREATE OR REPLACE PROCEDURE UC1_4_Delete_Employee
		(pEmpID varchar2) AS
BEGIN
	Delete Employee
	WHERE EmpID = pEmpID;
	dbms_output.put_line('Employee ' || pEmpID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/









CREATE OR REPLACE PROCEDURE UC1_5_Register_Unit
		( pUnitID varchar2, 
       	 pUnitName varchar2,
       	 pUnitDesc varchar2) AS
BEGIN
	INSERT INTO Unit VALUES (pUnitID, pUnitName, pUnitDesc);
	dbms_output.put_line('Unit ' || pUnitID || ' added' ); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Unit ID  ' || pUnitID || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_6_Update_Unit
		(pUnitID varchar2, 
       	 pUnitName varchar2,
       	 pUnitDesc varchar2) AS
BEGIN
	UPDATE Unit
	SET UnitName = pUnitName,
		UnitDesc = pUnitDesc
	WHERE UnitID = pUnitID;
	dbms_output.put_line('Unit ' || pUnitID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE PROCEDURE UC1_7_View_Unit AS
	u Unit%ROWTYPE;
	CURSOR units IS SELECT * FROM Unit;
BEGIN
	dbms_output.put_line('Listing All Unit Details');
	OPEN units;
	LOOP
		Fetch units into u;
		Exit When units%NOTFOUND;
		dbms_output.put_line('Unit ID: '|| u.UnitId --for testing
						 || ' Unit Name: ' || u.UnitName
						 || ' Unit Description: ' || u.UnitDesc);
	End Loop;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/

CREATE OR REPLACE PROCEDURE UC1_8_Delete_Unit
		(pUnitID varchar2) AS
BEGIN
	Delete Unit
	WHERE UnitID = pUnitID;
	dbms_output.put_line('Unit ' || pUnitID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/










CREATE OR REPLACE PROCEDURE UC1_9_Register_Student
		(pStuID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	INSERT INTO Student VALUES (pStuID, pFirstName, pLastName, pEmail, pContactNo, pPassword);
	dbms_output.put_line('Student ' || pStuID || ' added' );--for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student ID ' || pStuID || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_10_Update_Student
		(pStuID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2) AS
BEGIN
	UPDATE Student
	SET FirstName = pFirstName,
		LastName = pLastName,
		Email = pEmail,
		ContactNo = pContactNo,
	WHERE StuID = pStuID;
	dbms_output.put_line('Student ' || pStuID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/



CREATE or REPLACE FUNCTION UC1_11_View_Student RETURN CURSOR AS
	s Student%ROWTYPE;
	CURSOR students IS SELECT * FROM Student;
BEGIN
	dbms_output.put_line('Listing All Student Details');
	OPEN students;
	LOOP
		Fetch students into s;
		Exit When students%NOTFOUND;
		dbms_output.put_line('Student ID: '|| s.StuId --for testing
						 || ' FirstName: ' || s.FirstName
						 || ' LastName: ' || s.LastName
						 || ' Email: ' || s.Email
						 || ' ContactNo: ' || s.ContactNo);
	End Loop;
	Return students;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/

CREATE OR REPLACE PROCEDURE UC1_12_Delete_Student
		(pStuID varchar2) AS
BEGIN
	Delete Student
	WHERE StuId = pStuID;
	dbms_output.put_line('Student ' || pStuID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/











CREATE OR REPLACE PROCEDURE UC1_13_Register_Enrolment
		(pStuID varchar2,	
		 pUnitID varchar2, 
       	 pSemester number,
       	 pYear number) AS
BEGIN
	INSERT INTO Enrolment VALUES (pStuID, pUnitID, pSemester, pYear);
	dbms_output.put_line('Student ' || pStuID --for testing
					|| ' enrolled ' || pUnitID
					|| ' semester ' || pSemester
					|| ', ' || pYear);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student ' || pStuID || ' already enrolled in ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC1_14_Update_Enrolment
		(pStuID varchar2,	
		 pUnitID varchar2, 
       	 pSemester number,
       	 pYear number,
       	 NewStuID varchar2,	
		 NewUnitID varchar2, 
       	 NewSemester number,
       	 NewYear number) AS
BEGIN
	UPDATE Enrolment
	SET StuID = NewStuID,
		UnitID = NewUnitID,
		Semester = NewSemester,
		Year = NewYear,
	WHERE StuID = pStuID AND UnitID = pUnitID AND Semester = pSemester AND Year = pYear;
	dbms_output.put_line('Enrolment of Student: ' || pStuID || 
									 ' for unit ' || pUnitID ||
									 ' semester ' || pSemester ||
									 ', ' || pYear|| ' updated'); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/



CREATE or REPLACE FUNCTION UC1_15_View_Enrolment RETURN CURSOR AS
	e enrolmentt%ROWTYPE;
	CURSOR enrolments IS SELECT * FROM Student;
BEGIN
	dbms_output.put_line('Listing All Student Enrolments');
	OPEN enrolments;
	LOOP
		Fetch enrolments into e;
		Exit When enrolments%NOTFOUND;
		dbms_output.put_line('Student ID: '|| e.StuId --for testing
						 || ' UnitID: ' || e.UnitID
						 || ' Semester: ' || e.Semester
						 || ' Year: ' || e.Year);
	End Loop;
	Return enrolments;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/

CREATE OR REPLACE PROCEDURE UC1_16_Delete_Enrolment
		(pStuID varchar2,	
		 pUnitID varchar2, 
       	 pSemester number,
       	 pYear number) AS
BEGIN
	Delete Enrolment
	WHERE StuID = pStuID AND UnitID = pUnitID AND Semester = pSemester AND Year = pYear;
	dbms_output.put_line('Enrolment of Student: ' || pStuID || 
									 ' for unit ' || pUnitID ||
									 ' semester ' || pSemester ||
									 ', ' || pYear|| ' deleted'); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/











CREATE OR REPLACE PROCEDURE UC1_17_Register_Role_Type
		(pRole varchar2) AS
BEGIN
	INSERT INTO RoleType VALUES (pRole);
	dbms_output.put_line(pRole || ' roll added '); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Role ' || pRole || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_18_View_Role_Type RETURN CURSOR AS
	r RoleType%ROWTYPE;
	CURSOR roles IS SELECT * FROM RoleType;
BEGIN
	dbms_output.put_line('Listing All Role types');
	OPEN roles;
	LOOP
		Fetch roles into r;
		Exit When roles%NOTFOUND;
		dbms_output.put_line('Role: '|| r.Role);
	End Loop;
	Return roles;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/



CREATE OR REPLACE PROCEDURE UC1_19_Update_Role_Type -- think we're going to have problems with this
		(pRole varchar2, NewRole varchar2) AS
BEGIN
	UPDATE RoleType
	SET Role = NewRole,
	WHERE Role = pRole;
	dbms_output.put_line('Role ' || pRole || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_20_Delete_Role_Type
		(pRole varchar2) AS
BEGIN
	Delete RoleType
	WHERE Role = pRole;
	dbms_output.put_line('Role ' || pRole || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/











CREATE OR REPLACE PROCEDURE UC1_21_Register_Unit_Offering
		(pUnitID varchar2, 
       	 pSemester number,
       	 pYear number) AS
BEGIN
	INSERT INTO UnitOffering VALUES (pUnitID, pSemester, pYear);
	dbms_output.put_line('Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Unit offering ' || pUnitID || ' already exists for semester ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE PROCEDURE UC1_22_View_Unit_Offering AS
	uo UnitOffering%ROWTYPE;
	CURSOR uos IS SELECT * FROM UnitOffering;
BEGIN
	dbms_output.put_line('Listing All Unit Offerings');
	OPEN uos;
	LOOP
		Fetch uos into uo;
		Exit When uos%NOTFOUND;
		dbms_output.put_line('Unit ID: '|| uo.UnitId --for testing
						 || ' Semester: ' || uo.semester
						 || ' Year: ' || uo.Year); 
	End Loop;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/


CREATE OR REPLACE PROCEDURE UC1_23_Update_Unit_Offering
		(pUnitID varchar2, 
       	 pSemester number,
       	 pYear number,
       	 NewUnitID varchar2, 
       	 NewSemester number,
       	 NewYear number) AS
BEGIN
	UPDATE UnitOffering
	SET UnitID = NewUnitID, -- test this, idk it's possible to update the primary key of the row you've searched for USING it's original primary key...
		Semester = NewSemester,
		Year = NewYear,
	WHERE pUnitID = pUnitID AND Semester = pSemester AND Year = pYear;
	dbms_output.put_line('Unit Offering ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear || ' updated'); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_24_Delete_UnitOffering
		(pUnitID varchar2, 
       	 pSemester number,
       	 pYear number) AS
BEGIN
	Delete UnitOffering
	WHERE pUnitID = pUnitID AND Semester = pSemester AND Year = pYear;
	dbms_output.put_line('Unit Offering ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear || ' deleted'); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/









CREATE OR REPLACE PROCEDURE UC1_25_Register_Employee_Role
		( pEmpID varchar2, 
       	 pRole varchar2) AS
BEGIN
	INSERT INTO EmployeeRole VALUES (pEmpID, pRole);
	dbms_output.put_line('Employee ' || pEmpID || ' added as ' || pRole); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Employee ' || pEmpID || ' already ' || pRole);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_26_View_Employee_Role RETURN CURSOR AS
	er EmployeeRole%ROWTYPE;
	CURSOR emproles IS SELECT * FROM EmployeeRole;
BEGIN
	dbms_output.put_line('Listing All Employee Details');
	OPEN emproles;
	LOOP
		Fetch emproles into er;
		Exit When emproles%NOTFOUND;
		dbms_output.put_line('Employee ID: '|| er.EmpId --for testing
						 || ' Role: ' || er.Role); 
	End Loop;
	Return emproles;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/


CREATE OR REPLACE PROCEDURE UC1_27_Update_Employee_Role
		(pEmpID varchar2, 
       	 pRole varchar2,
       	 NewEmpID varchar2,
       	 NewRole varchar2) AS
BEGIN
	UPDATE EmployeeRole
	SET EmpID = NewEmpID,
		Role = NewRole
	WHERE EmpID = pEmpID AND Role = pRole;
	dbms_output.put_line('Employee ' || pEmpID || ' updated as ' || pRole); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_28_Delete_Employee_Role
		(pEmpID varchar2, pRole varchar2) AS
BEGIN
	Delete EmployeeRole
	WHERE EmpID = pEmpID AND Role = pRole;
	dbms_output.put_line('Employee ' || pEmpID || ' deleted as ' || pRole); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/





	


CREATE OR REPLACE PROCEDURE UC1_29_Meeting_Role_Type
		(pMeetType varchar2) AS
BEGIN
	INSERT INTO MeetingType VALUES (pMeetType);
	dbms_output.put_line(pMeetType || ' meeting type added'); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Meeting type ' || pMeetType || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_30_View_Meeting_Type RETURN CURSOR AS
	mt MeetingType%ROWTYPE;
	CURSOR mts IS SELECT * FROM MeetingType;
BEGIN
	dbms_output.put_line('Listing All Meeting types');
	OPEN mts;
	LOOP
		Fetch mt into mts;
		Exit When mt%NOTFOUND;
		dbms_output.put_line('Meeting type: '|| mt.MeetingType);
	End Loop;
	Return mts;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/



CREATE OR REPLACE PROCEDURE UC1_31_Update_Meeting_Type -- think we're going to have problems with this
		(pMeetType varchar2, NewMeetType varchar2) AS
BEGIN
	UPDATE MeetingType
	SET MeetType = NewMeetType,
	WHERE MeetType = pMeetType;
	dbms_output.put_line('Meeting type ' || pMeetType || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_32_Delete_Meeting_Type
		(pMeetType varchar2) AS
BEGIN
	Delete MeetingType
	WHERE MeetType = pMeetType;
	dbms_output.put_line('Meeting type ' || pMeetType || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/









CREATE OR REPLACE PROCEDURE UC1_33_Register_Assessment_Type
		(pAssType varchar2, pTypeDesc varchar2) AS
BEGIN
	INSERT INTO AssessmentType VALUES (pAssType, pTypeDesc);
	dbms_output.put_line(pAssType || ' Assessment type added'); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment type ' || pAssessmentType || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_34_View_Assessment_Type RETURN CURSOR AS
	at AssessmentType%ROWTYPE;
	CURSOR ats IS SELECT * FROM MeetingType;
BEGIN
	dbms_output.put_line('Listing All Meeting types');
	OPEN ats;
	LOOP
		Fetch at into mts;
		Exit When mt%NOTFOUND;
		dbms_output.put_line('Meeting type: '|| mt.MeetingType);
	End Loop;
	Return mts;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/



CREATE OR REPLACE PROCEDURE UC1_35_Update_Assessment_Type -- think we're going to have problems with this
		(pAssType varchar2,
		 pTypeDesc varchar2,
		 NewAssType varchar2) AS
BEGIN
	UPDATE AssessmentType
	SET AssType = NewAssType,
	WHERE AssType = pAssType;
	dbms_output.put_line('Assessment type ' || pAssType || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC1_36_Delete_Assessment_Type
		(pAssType varchar2) AS
BEGIN
	Delete AssessmentType
	WHERE AssType = pAssType;
	dbms_output.put_line('Assessment type ' || pAssType || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC2_1_Register_Team
		(pTeamID varchar2,
	pProjID varchar2,
	pUnitID varchar2,
	pSemester number,
	pYear number,
	pEmpID varchar2,
	pRole varchar2) AS
BEGIN
	INSERT INTO Team VALUES (pTeamID, pProjID, pUnitID, pSemester, pYear, pEmpID, pRole)
	dbms_output.put_line('Team Id: ' || pTeamID || ' For the Project: ' || pProjID || ' Unit: ' || pUnitID ||' Semester: ' || pSemester || ' Year: ' || pYear || ' Supervisor Id ' || pEmpID)
WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Team ID ' || pTeamID|| ' already exists for semester ' ||pUnitID|| ', '|| pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC2_2_Update_Employee
			(
			
);
/

CREATE OR REPLACE FUNCTION UC2_3_View_Team
(
);
/

CREATE OR REPLACE PROCEDURE UC2_3_Delete_Team
(
);
/

CREATE OR REPLACE PROCEDURE UC2_5_Register_Project
		(pProjID varchar2,
	pProjDesc varchar2,
	pUnitID varchar2, 
    pSemester number,
	pYear number) AS
BEGIN
	INSERT INTO Project VALUES (pProjID, pProjDesc, UnitID, pSemester, pYear);
	dbms_output.put_line('Adding Project: '|| pProjID ||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Project: ' || pProjID|| ' Already exists for:' || UnitID || ', ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC2_9_Register_Assessment
		(pAssID varchar2,
	pAssTitle varchar2,
	pAssDesc varchar2,
	pUnitID varchar2, 
	pSemester number,
	pYear number,
	pMarkingGuide varchar2,
	pAssType varchar2,
	pDueDate date) AS
BEGIN
	INSERT INTO Assessment VALUES (pAssID, pAssTitle, pAssDesc, pUnitID, pSemester, pYear, pMarkingGuide, pAssType, p);
	dbms_output.put_line('Assessment: '|| pAssID ||' Title: '|| pAssTitle||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment ID ' || pAssID || ' already exists for: ' || pUnitID|| ', '|| pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC2_13_Register_Assessment_Allocation
		(pAssID varchar2,
	pUnitID varchar2, 
	pSemester number,
	pYear number,
	pStuID varchar2,
	pTeamID varchar2,
	pSubmission varchar2) AS
BEGIN
	INSERT INTO Assessment VALUES (pAssID, pUnitID, pSemester, pYear, pStuID, pSubmission);
	dbms_output.put_line('Assessment: '|| pAssID ||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear|| ' Assigned to student: '|| pStuID || ' In team: '|| pTeamID); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment ID ' || pAssID || ' already exists for: ' || pUnitID|| ', '|| pSemester || ', ' || pYear|| ' Student: '|| pStuID || ' Team: '|| pTeamID);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/







