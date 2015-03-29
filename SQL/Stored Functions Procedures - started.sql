CREATE OR REPLACE PROCEDURE UC1_1_Register_Employee
		( pEmpID varchar2, 
       	 pFirstName varchar2,
       	 pLastName varchar2,
       	 pEmail varchar2,
       	 pContactNo varchar2,
       	 pPassword varchar2) AS
BEGIN
	INSERT INTO Employee VALUES (pEmpID, pFirstName, pLastName, pEmail, pContactNo, pPassword);
	dbms_output.put_line('Employee ' || pEmpID || ' added' );
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Employee ID  ' || pEmpID || ' already exists');
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
	dbms_output.put_line('Student ' || pStuID || ' added' );
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
	UDPATE Student
	SET FirstName = pFirstName,
		LastName = pLastName,
		Email = pEmail,
		ContactNo = pContactNo,
		Password = pPassword)
	WHERE StuID = pStuID;
	dbms_output.put_line('Student ' || pStuID || ' updated' );
EXCEPTION
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/







CREATE OR REPLACE PROCEDURE UC1_5_Register_Unit
		(pUnitID varchar2, 
       	 pUnitName varchar2,
       	 pUnitDesc varchar2) AS
BEGIN
	INSERT INTO Unit VALUES (pUnitID, pUnitName, pUnitDesc);
	dbms_output.put_line('Unit ' || pUnitID || ' added' );
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Unit ID ' || pUnitID || ' already exists');
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
	dbms_output.put_line('Unit Offering ' || pUnitID || ' added semester ' || pSemester || ', ' || pYear);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Unit offering ' || pUnitID || ' already exists for semester ' || pSemester || ', ' || pYear);
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
	dbms_output.put_line('Student ' || pStuID || ' enrolled ' || pUnitID || ' semester ' || pSemester || ', ' || pYear);
EXCEPTION
	WHEN DUP_VAL_ON_INDEX THEN
		RAISE_APPLICATION_ERROR(-20001, 'Student ' || pStuID || ' already enrolled in ' || pUnitID || ' for semester ' || pSemester || ', ' || pYear);
	WHEN OTHERS THEN
		RAISE_APPLICATION_ERROR(-20000, SQLERRM);
END;
/