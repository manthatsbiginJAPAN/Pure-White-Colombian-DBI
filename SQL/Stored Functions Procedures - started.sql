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
	SET FirstName = NewFirstName,
		LastName = NewLastName,
		Email = NewEmail,
		ContactNo = NewContactNo,
	WHERE StuID = pStuID AND  
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
	e Student%ROWTYPE;
	CURSOR students IS SELECT * FROM Student;
BEGIN
	dbms_output.put_line('Listing All Student Enrolments');
	OPEN enrolments;
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

CREATE OR REPLACE PROCEDURE UC1_16_Delete_Enrolment
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




CREATE OR REPLACE PROCEDURE UC1_19_Update_Role -- think we're going to have problems with this
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


CREATE OR REPLACE PROCEDURE UC1_20_Delete_Role
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
       	 pYear number) AS
BEGIN
	UPDATE UnitOffering
	SET UnitID = pUnitID, -- test this, idk it's possible to update the primary key of the row you've searched for USING it's original primary key...
		Semester = pSemester,
		Year = pYear
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
