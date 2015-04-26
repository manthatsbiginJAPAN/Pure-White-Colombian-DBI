CREATE OR REPLACE PROCEDURE UC1_1_Register_Employee
		( pEmpID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	INSERT INTO Employee VALUES (pEmpID, pFirstName, pLastName, pEmail, pContactNo, pPassword);
	--dbms_output.put_line('Employee ' || pEmpID || ' added' ); --for testing
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
	--dbms_output.put_line('Employee ' || pEmpID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/

CREATE or REPLACE FUNCTION UC1_3_View_Employee 
	RETURN SYS_REFCURSOR AS emps SYS_REFCURSOR;
BEGIN
	OPEN emps for select * from employee;
	--dbms_output.put_line('Listing All Employee Details');
	--LOOP
	--	Fetch emps into e;
	--	Exit When emps%NOTFOUND;
	--	dbms_output.put_line('Employee ID: '|| e.EmpId --for testing
	--					 || ' First Name: ' ||e.FirstName
	--					 || ' Last Name: ' ||e.LastName
	--					 || ' Email: ' || e.Email
	--					 || ' ContactNo:' || e.ContactNo); 
	--End Loop;
	return emps;
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
	--dbms_output.put_line('Employee ' || pEmpID || ' deleted' ); --for testing
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
	--dbms_output.put_line('Unit ' || pUnitID || ' added' ); --for testing
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
	--dbms_output.put_line('Unit ' || pUnitID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/



CREATE or REPLACE FUNCTION UC1_7_View_Unit
	RETURN SYS_REFCURSOR AS units SYS_REFCURSOR;
	u Unit%ROWTYPE;
BEGIN
	OPEN units for select * from Unit;
	--LOOP
	--	Fetch unts into u;
	--	Exit When unts%NOTFOUND;
	--	dbms_output.put_line('Unit ID: '|| u.UnitId --for testing
	--					 || ' Unit Name: ' || u.UnitName
	--					 || ' Unit Description: ' || u.UnitDesc);
	--End Loop;
	return units;
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
	--dbms_output.put_line('Unit ' || pUnitID || ' deleted' ); --for testing
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
	--dbms_output.put_line('Student ' || pStuID || ' added' );--for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student ID ' || pStuID || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/


create or replace PROCEDURE UC1_10_Update_Student
		(pStuID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	UPDATE Student
	SET FirstName = pFirstName,
		LastName = pLastName,
		Email = pEmail,
		ContactNo = pContactNo,
		Password = pPassword
	WHERE StuID = pStuID;
	--dbms_output.put_line('Student ' || pStuID || ' updated' ); --for testing
	
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/


create or replace FUNCTION UC1_11_View_Student
	RETURN SYS_REFCURSOR AS studs SYS_REFCURSOR;
BEGIN
	--dbms_output.put_line('Listing All Student Details');
	OPEN studs for select * from student;
	--LOOP
		--Fetch studs into s;
		--Exit When studs%NOTFOUND;
		--dbms_output.put_line('Student ID: '|| s.StuId --for testing
		--				 || ' FirstName: ' || s.FirstName
		--				 || ' LastName: ' || s.LastName
		--				 || ' Email: ' || s.Email
		--				 || ' ContactNo: ' || s.ContactNo
		--				 || ' Password: ' || s.Password);
	--End Loop;
	Return studs;
EXCEPTION
	When Others Then
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
End;

/

CREATE OR REPLACE PROCEDURE UC1_12_Delete_Student
		(pStuID varchar2) AS
BEGIN
	Delete Student
	WHERE StuId = pStuID;
	--dbms_output.put_line('Student ' || pStuID || ' deleted' ); --for testing
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
	--dbms_output.put_line('Student ' || pStuID --for testing
	--				|| ' enrolled ' || pUnitID
	--				|| ' semester ' || pSemester
	--				|| ', ' || pYear);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student ' || pStuID || ' already enrolled in ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC1_14_Update_Enrolment -- TO BE DELETED
		(pStuID varchar2,	
		 pUnitID varchar2, 
       	 pSemester number,
       	 pYear number,
       	 newUnitID varchar2,
       	 newSemester varchar2,
       	 newYear varchar2) AS
BEGIN
	UPDATE Enrolment
	SET
		UnitID = newUnitID,
		Semester = newSemester,
		Year = newYear
	WHERE StuID = pStuID and
		UnitID = pUnitID and
		Semester = pSemester and
		Year = pYear;
	--dbms_output.put_line('Enrolment of Student: ' || pStuID || 
	--								 ' for unit ' || pUnitID ||
	--								 ' semester ' || pSemester ||
	--								 ', ' || pYear|| ' updated'); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001,'Student: '|| pStuID || ' already enrolled in: '|| pUnitID || ', '|| pSemester || ', '|| pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/


CREATE or REPLACE FUNCTION UC1_15_View_Enrolment RETURN SYS_REFCURSOR AS enrols SYS_REFCURSOR;
BEGIN
	dbms_output.put_line('Listing All Student Enrolments');
	OPEN enrols for select * from Enrolment;
	--LOOP
	--	Fetch enrols into e;
	--	Exit When enrols%NOTFOUND;
	--	dbms_output.put_line('Student ID: '|| e.StuId --for testing
	--					 || ' UnitID: ' || e.UnitID
	--					 || ' Semester: ' || e.Semester
	--					 || ' Year: ' || e.Year);
	--End Loop;
	Return enrols;
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


CREATE or REPLACE FUNCTION UC1_18_View_Role_Type
RETURN SYS_REFCURSOR AS roles SYS_REFCURSOR;
BEGIN
	--dbms_output.put_line('Listing All Role types');
	OPEN roles for select * from RoleType;
	--LOOP
	--	Fetch roles into r;
	--	Exit When roles%NOTFOUND;
	--	dbms_output.put_line('Role: '|| r.Role);
	--End Loop;
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
	SET Role = NewRole
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
       	 pYear number,
       	 pEmpID varchar2) AS
BEGIN
	INSERT INTO UnitOffering VALUES (pUnitID, pSemester, pYear, pEmpID);
	--dbms_output.put_line('Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Unit offering ' || pUnitID || ' already exists for semester ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_22_View_Unit_Offering
	RETURN SYS_REFCURSOR AS uos SYS_REFCURSOR;
BEGIN
	--dbms_output.put_line('Listing All Unit Offerings');
	OPEN uos for select * from UnitOffering;
	--LOOP
	--	Fetch uos into uo;
	--	Exit When uos%NOTFOUND;
	--	dbms_output.put_line('Unit ID: '|| uo.UnitId --for testing
	--					 || ' Semester: ' || uo.semester
	--					 || ' Year: ' || uo.Year); 
	--End Loop;
	return uos;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/


create or replace PROCEDURE UC1_23_Update_Unit_Offering
		(pUnitID varchar2, 
       	 pSemester number,
       	 pYear number,
       	 pEmpID varchar2,
       	 newEmpID varchar2) AS
BEGIN
	UPDATE UnitOffering
	SET EmpID = NewEmpID -- Employee is the only thing we can change
	WHERE UnitID = pUnitID AND Semester = pSemester AND Year = pYear AND EmpID = pEmpID;
	--dbms_output.put_line('Unit Offering ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear || ' updated'); --for testing
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




-- CREATE OR REPLACE PROCEDURE UC1_25_Register_Employee_Role
-- 		( pEmpID varchar2, 
--        	 pRole varchar2) AS
-- BEGIN
-- 	INSERT INTO EmployeeRole VALUES (pEmpID, pRole);
-- 	dbms_output.put_line('Employee ' || pEmpID || ' added as ' || pRole); --for testing
-- EXCEPTION
-- 	WHEN DUP_VAL_ON_INDEX THEN
-- 		RAISE_APPLICATION_ERROR(-20001, 'Employee ' || pEmpID || ' already ' || pRole);
-- 	WHEN OTHERS THEN
-- 		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
-- END;
-- /


-- CREATE or REPLACE FUNCTION UC1_26_View_Employee_Role RETURN SYS_REFCURSOR AS emproles SYS_REFCURSOR;
-- BEGIN
-- 	--dbms_output.put_line('Listing All Employee Details');
-- 	OPEN emproles for select * from EmployeeRole;
-- 	--LOOP
-- 	--	Fetch emproles into er;
-- 	--	Exit When emproles%NOTFOUND;
-- 	--	dbms_output.put_line('Employee ID: '|| er.EmpId --for testing
-- 	--					 || ' Role: ' || er.Role); 
-- 	--End Loop;
-- 	Return emproles;
-- EXCEPTION
-- 	When Others Then
-- 		dbms_output.put_line(SQLERRM);
-- End;
-- /




-- CREATE OR REPLACE PROCEDURE UC1_28_Delete_Employee_Role
-- 		(pEmpID varchar2, pRole varchar2) AS
-- BEGIN
-- 	Delete EmployeeRole
-- 	WHERE EmpID = pEmpID AND Role = pRole;
-- 	--dbms_output.put_line('Employee ' || pEmpID || ' deleted as ' || pRole); --for testing
-- EXCEPTION
-- 	WHEN OTHERS THEN
-- 		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
-- END;
-- /


-- CREATE OR REPLACE PROCEDURE UC1_29_Meeting_Role_Type
-- 		(pMeetType varchar2) AS
-- BEGIN
-- 	INSERT INTO MeetingType VALUES (pMeetType);
-- 	--dbms_output.put_line(pMeetType || ' meeting type added'); --for testing
-- EXCEPTION
-- 	WHEN DUP_VAL_ON_INDEX THEN
-- 		RAISE_APPLICATION_ERROR(-20001, 'Meeting type ' || pMeetType || ' already exists');
-- 	WHEN OTHERS THEN
-- 		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
-- END;
-- /


CREATE or REPLACE FUNCTION UC1_30_View_Meeting_Type
RETURN SYS_REFCURSOR AS mtypes SYS_REFCURSOR;
BEGIN
	--dbms_output.put_line('Listing All Meeting types');
	OPEN mtypes for select * from MeetingType;
	--LOOP
	--	Fetch mtypes into mts;
	--	Exit When mt%NOTFOUND;
	--	dbms_output.put_line('Meeting type: '|| mt.MeetingType);
	--End Loop;
	Return mtypes;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/



CREATE OR REPLACE PROCEDURE UC1_31_Update_Meeting_Type -- think we're going to have problems with this
		(pMeetType varchar2, NewMeetType varchar2) AS
BEGIN
	UPDATE MeetingType
	SET MeetType = NewMeetType
	WHERE MeetType = pMeetType;
	--dbms_output.put_line('Meeting type ' || pMeetType || ' updated' ); --for testing
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
	--dbms_output.put_line('Meeting type ' || pMeetType || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/




create or replace PROCEDURE UC1_33_Register_Ass_Type
		(pAssType varchar2, pTypeDesc varchar2) AS
BEGIN
	INSERT INTO AssessmentType VALUES (pAssType, pTypeDesc);
	--dbms_output.put_line(pAssType || ' Assessment type added'); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment type ' || pAssType || ' already exists');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE or REPLACE FUNCTION UC1_34_View_Assessment_Type
	RETURN SYS_REFCURSOR AS ats SYS_REFCURSOR;

BEGIN
	OPEN ats for select * from AssessmentType;
	--LOOP
	--	Fetch ats into a;
	--	Exit When ats%NOTFOUND;
	--	dbms_output.put_line('Meeting type: '|| mt.MeetingType);
	--End Loop;
	Return ats;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;
/



CREATE OR REPLACE PROCEDURE UC1_35_Update_Assessment_Type -- think we're going to have problems with this
		(pAssType varchar2,
		 pTypeDesc varchar2,
		 NewAssType varchar2,
		 NewTypeDesc varchar2) AS
BEGIN
	UPDATE AssessmentType
	SET AssType = NewAssType,
		TypeDesc = NewTypeDesc
	WHERE AssType = pAssType;
	--dbms_output.put_line('Assessment type ' || pAssType || ' updated' ); --for testing
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
	--dbms_output.put_line('Assessment type ' || pAssType || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


create or replace PROCEDURE UC2_1_Register_Team
		(pTeamID varchar2,
	pProjID varchar2,
	pUnitID varchar2,
	pSemester number,
	pYear number,
	pEmpID varchar2
	--pRole varchar2
	) AS
BEGIN
	INSERT INTO Team VALUES (pTeamID, pProjID, pUnitID, pSemester, pYear, pEmpID);
	--dbms_output.put_line('Team Id: ' || pTeamID || ' For the Project: ' || pProjID || ' Unit: ' || pUnitID ||' Semester: ' || pSemester || ' Year: ' || pYear || ' Supervisor Id ' || pEmpID);
EXCEPTION
  WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Team ID ' || pTeamID|| ' already exists for semester ' ||pUnitID|| ', '|| pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC2_2_Update_Team
		(pTeamID varchar2,
	pProjID varchar2,
	pUnitID varchar2,
	pSemester number,
	pYear number,
	pEmpID varchar2
	--pRole varchar2
	) AS
BEGIN
	UPDATE Team
	SET ProjID = pProjID,
		Semester = pSemester,
		Year = pYear,
		EmpId = pEmpID
		--Role = pRole
	WHERE TeamID = pTeamID;
	--dbms_output.put_line('Team' || pTeamID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


CREATE OR REPLACE PROCEDURE UC2_4_Delete_Team
		(pTeamID varchar2) AS
BEGIN
	Delete Team
	WHERE TeamID = pTeamID;
	--dbms_output.put_line('Team ' || pTeamID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

create or replace PROCEDURE UC2_5_Register_Project
		(pProjID varchar2,
	pProjDesc varchar2,
	pUnitID varchar2, 
    pSemester number,
	pYear number) AS
BEGIN
	INSERT INTO Project VALUES (pProjID, pProjDesc, pUnitID, pSemester, pYear);
	--dbms_output.put_line('Adding Project: '|| pProjID ||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Project: ' || pProjID|| ' Already exists for:' || pUnitID || ', ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

create or replace PROCEDURE UC2_6_Update_Project
		(pProjID varchar2,
	pProjDesc varchar2,
	pUnitID varchar2, 
    pSemester number,
	pYear number) AS
BEGIN
	UPDATE Project
	SET	ProjDesc = pProjDesc	
	WHERE ProjID = pProjID and
		UnitID = pUnitID and
		Semester = pSemester and
		Year = pYear;
	--dbms_output.put_line('Project' || pProjID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE UC2_8_Delete_Project
		(pProjID varchar2) AS
BEGIN
	Delete Project
	WHERE ProjID = pProjID;
	--dbms_output.put_line('Project ' || pProjID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


create or replace PROCEDURE UC2_9_Register_Assessment
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
	INSERT INTO Assessment VALUES (pAssID, pAssTitle, pAssDesc, pUnitID, pSemester, pYear, pMarkingGuide, pAssType, pDueDate);
	--dbms_output.put_line('Assessment: '|| pAssID ||' Title: '|| pAssTitle||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment ID ' || pAssID || ' already exists for: ' || pUnitID|| ', '|| pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/

create or replace PROCEDURE UC2_10_Update_Assessment
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
	UPDATE Assessment
	SET AssTitle = pAssTitle,
		AssDesc = pAssDesc,
		MarkingGuide = pMarkingGuide,
		AssType = pAssType,
		DueDate = pDueDate
	WHERE AssId = pAssID and
		UnitId = pUnitID and
		Semester = pSemester and
		Year = pYear;
	--dbms_output.put_line('Assessment' || pAssID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/

CREATE OR REPLACE PROCEDURE UC2_12_Delete_Assessment
		(pAssID varchar2) AS
BEGIN
	Delete Assessment
	WHERE AssID = pAssID;
	--dbms_output.put_line('Assessment ' || pAssID || ' deleted' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/


create or replace PROCEDURE UC2_13_Register_Ass_Allo
		(pAssID varchar2,
	pUnitID varchar2, 
	pSemester number,
	pYear number,
	pStuID varchar2,
	pTeamID varchar2,
	pSubmission varchar2) AS
BEGIN
	INSERT INTO AssessmentAllocation VALUES (pAssID, pUnitID, pSemester, pYear, pStuID, pTeamID, pSubmission);
	--dbms_output.put_line('Assessment: '|| pAssID ||' Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear|| ' Assigned to student: '|| pStuID || ' In team: '|| pTeamID); --for testing
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Assessment ID ' || pAssID || ' already exists for: ' || pUnitID|| ', '|| pSemester || ', ' || pYear|| ' Student: '|| pStuID || ' Team: '|| pTeamID);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/


create or replace PROCEDURE UC2_14_Update_Ass_Allo
		(pAssID varchar2,
	pUnitID varchar2, 
	pSemester number,
	pYear number,
	pStuID varchar2,
	pTeamID varchar2,
	pSubmission varchar2) AS
BEGIN
	UPDATE AssessmentAllocation
	SET Submission = pSubmission
	WHERE AssId = pAssID and
		  UnitId = pUnitID and
		  Semester = pSemester and
		  Year = pYear and
		  StuID = pStuID and
		  TeamID = pTeamID;
	--dbms_output.put_line('Assessment' || pAssID || ' updated' ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/


CREATE or REPLACE FUNCTION UC2_15_View_Ass_allo 
	RETURN SYS_REFCURSOR AS emps SYS_REFCURSOR;
	e Employee%ROWTYPE;
BEGIN
	
	
	OPEN emps for select * from employee;

	--dbms_output.put_line('Listing All Employee Details');
	--LOOP
	--	Fetch emps into e;
	--	Exit When emps%NOTFOUND;
	--	dbms_output.put_line('Employee ID: '|| e.EmpId --for testing
	--					 || ' First Name: ' ||e.FirstName
	--					 || ' Last Name: ' ||e.LastName
	--					 || ' Email: ' || e.Email
	--					 || ' ContactNo:' || e.ContactNo); 
	--End Loop;
	return emps;
EXCEPTION
	When Others Then
		dbms_output.put_line(SQLERRM);
End;

/

CREATE OR REPLACE PROCEDURE UC2_16_Delete_Ass_Allo
		(pAssID varchar2, pUnitID varchar2, pSemester varchar2, pYear number, pStuID varchar2) AS
BEGIN
	Delete AssessmentAllocation
	WHERE AssID = pAssID and
		UnitID = pUnitID and
		Semester = pSemester and
		Year = pYear and
		StuID = pStuID;
	--dbms_output.put_line('Assessment ' || pAssID || ' deleted for: '|| pUnitID || ', '|| pSemester || ', '|| pYear || ', '|| pStuID ); --for testing
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/

create or replace PROCEDURE UC2_17_Register_Team_Allo
		(pTeamID varchar2,
	pStuID varchar2,
	pUnitID varchar2,
	pSemester varchar2,
	pYear varchar2) AS
BEGIN 
	INSERT INTO StudentTeamAllocation VALUES (pTeamID, pStuID, pUnitID, pSemester, pYear);
	--dbms_output.put_line('Registered Student: '|| pStuID || ' into Team: '|| pTeamID|| ' for unit: ' || pUnitID || 'added semester ' || pSemester || ', '|| pYear);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student: ' || pStuID || ' already exists for team: ' || pTeamID);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;

/

CREATE or REPLACE PROCEDURE UC3_2_Register_Meeting
		(pMeetingID number,
	pTeamID varchar2,
	pUnitID varchar2,
	pSemester number,
	pYear number,
	pMeetType varchar2,
	pStartTime date,
	pFinishTime date,
	pMinutes varchar2,
	pEmpID varchar2,
	pClientName varchar2) AS
BEGIN
	INSERT INTO Meeting VALUES (pMeetingID, pTeamID, pUnitID, pSemester, pYear, pMeetType, pStartTime, pFinishTime, pMinutes, pEmpID, pClientName);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Meeting ID: ' || pMeetingID || ' already exists.');
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);	
END;

/

CREATE or REPLACE PROCEDURE UC3_3_Update_Meeting
		(pMeetingID number,
		pTeamID varchar2,
		pUnitID varchar2,
		pSemester number,
		pYear number,
		pMeetType varchar2,
		pStartTime date,
		pFinishTime date,
		pMinutes varchar2,
		pEmpID varchar2,
		pClientName varchar2) AS
BEGIN
	UPDATE Meeting
	SET TeamID = pTeamID,
		UnitId = pUnitID,
		Semester = pSemester,
		Year = pYear,
		MeetType = pMeetType,
		StartTime = pStartTime,
		FinishTime = pFinishTime,
		Minutes = pMinutes,
		EmpID = pEmpID,
		ClientName = pClientName 
	WHERE MeetingID = pMeetingID;
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);	
END;



