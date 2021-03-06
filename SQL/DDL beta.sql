		DROP TABLE Assessment CASCADE CONSTRAINTS;
		DROP TABLE AssessmentType CASCADE CONSTRAINTS;
		DROP TABLE AssessmentAllocation CASCADE CONSTRAINTS;
		DROP TABLE MeetingType CASCADE CONSTRAINTS;
		DROP TABLE MeetingAttendance CASCADE CONSTRAINTS;
		DROP TABLE Meeting CASCADE CONSTRAINTS;
    		DROP TABLE AgendaItem CASCADE CONSTRAINTS;
    		DROP TABLE ActionItem CASCADE CONSTRAINTS;
		DROP TABLE StudentTeamAllocation CASCADE CONSTRAINTS; 
		DROP TABLE Team CASCADE CONSTRAINTS;
		DROP TABLE Project CASCADE CONSTRAINTS;
		DROP TABLE EmployeeRole CASCADE CONSTRAINTS;
		DROP TABLE RoleType CASCADE CONSTRAINTS;
		DROP TABLE Employee CASCADE CONSTRAINTS;
		DROP TABLE Enrolment CASCADE CONSTRAINTS;
		DROP TABLE UnitOffering CASCADE CONSTRAINTS;
		DROP TABLE Unit CASCADE CONSTRAINTS;
		DROP TABLE Student CASCADE CONSTRAINTS;


		CREATE TABLE Student ( --links a student id to a name 
		StuID varchar2(10)
		, FirstName varchar2(20) NOT NULL
		, LastName varchar2(20)
		, Email varchar2(100) UNIQUE NOT NULL
		, ContactNo varchar2(10) NOT NULL
		, Password varchar2(50) NOT NULL -- ie admin assigns pw at the start, could be bday for example
		, PRIMARY KEY (StuID)
		);

		/
		
		CREATE TABLE Employee ( --links an employee id to a name
		EmpID varchar2(10)
		, FirstName varchar2(20) NOT NULL
		, LastName varchar2 (20)
		, Email varchar2(100) UNIQUE NOT NULL
		, ContactNo varchar2(10) NOT NULL
		, Password varchar2(50) NOT NULL
		, PRIMARY KEY (EmpID)
		);

		/

		CREATE TABLE RoleType ( --lists the number of roles available (ie convener, admin and supervisor)
		Role varchar2(20) -- use a check constraint? Extra points. Ok
		--, RoleDescription varchar2 (200) -- probably not neccessary..?
		, PRIMARY KEY (Role)
		);

		/

		CREATE TABLE EmployeeRole ( --Links an employee to a particular role in a particular offered unit 
		EmpID varchar2(10) -- do we need to explicitly say 'not null' for all of these below?
		, Role varchar2(20)
		, PRIMARY KEY (EmpID, Role)
		, FOREIGN KEY (EmpID) REFERENCES Employee
		, FOREIGN KEY (Role) REFERENCES RoleType
		);

		/


		CREATE TABLE Unit ( --links a unit to a name
		UnitID varchar2 (10)
		, UnitName varchar2 (50) NOT NULL
		, UnitDesc varchar2 (200)
		, PRIMARY KEY (UnitID)
		);

		/

		CREATE TABLE UnitOffering ( -- links unit to a point in time (year and semester) and assigns convener
		UnitID varchar2(10)
		, Semester number(1) NOT NULL
		, Year number(4) NOT NULL
		, EmpID varchar2(10) 
		, Role varchar2(20)
		, PRIMARY KEY (UnitID, Semester, Year)
		, FOREIGN KEY (UnitID) REFERENCES Unit
		, FOREIGN KEY (EmpID, Role) REFERENCES EmployeeRole
		);

		/

		CREATE TABLE Enrolment ( --links an enrolled student to an offered unit
		StuID varchar2(10) NOT NULL
		, UnitID varchar2(10) NOT NULL
		, Semester number(1) NOT NULL
		, Year number(4) NOT NULL
		, PRIMARY KEY (StuID, UnitID, Semester, Year)
		, FOREIGN KEY (StuID) REFERENCES Student
		, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
		);

		/

		
		-------------------------------------------------------------------------------------

		CREATE TABLE Project ( --Links a projectID (with description) to an offered unit 
		ProjID varchar2(10)
		, ProjDesc varchar2(200) 
		, UnitID varchar2(10) 
		, Semester number(1) 
		, Year number (4) 
		, PRIMARY KEY (ProjID, UnitID, Semester, Year)
		, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
		);

		/

		CREATE TABLE Team ( --links a Team to a project within an offered unit, and with a supervisor
		TeamID varchar2(10) NOT NULL
		, ProjID varchar2(10) NOT NULL
		, UnitID varchar2(10) NOT NULL
		, Semester number(1) NOT NULL
		, Year number (4) NOT NULL
		, EmpID varchar2(10) --the supervisor
		, Role varchar2(20) -- we need to include it because it is part of the employee role PK
		, PRIMARY KEY (TeamID) --include UnitOffering PKs and maybe team ID like we have on BB, a two digit number?
		, FOREIGN KEY (ProjID, UnitID, Semester, Year) REFERENCES Project
		, FOREIGN KEY (EmpID, Role) REFERENCES EmployeeRole --need to test
		);

		/

		CREATE TABLE StudentTeamAllocation ( --links an enrolled student to a team (which is already assigned to a unit offering)
		TeamID varchar2(10) -- do we need 'not null'
		, StuID varchar2(10) -- 'can' be null
		, UnitID varchar2(10) NOT NULL
		, Semester number(1) NOT NULL
		, Year number(4) NOT NULL
		, PRIMARY KEY (TeamID, StuID)
		, FOREIGN KEY (TeamID) REFERENCES Team
		, FOREIGN KEY (StuID, UnitID, Semester, Year) REFERENCES Enrolment
		);

		/

		-------------------------------------------------------------------------------------

		CREATE TABLE MeetingType (
		MeetType varchar2(20)
		, PRIMARY KEY (MeetType)
		);
		
		/
		
		CREATE TABLE Meeting ( --Links a team to a meeting for an offered unit
		TeamID varchar2(10) 
		, MeetingID number(3) NOT NULL --Limited to 99 Meetings
		, UnitID varchar2(10) NOT NULL
		, Semester number(1) NOT NULL
		, Year number(4) NOT NULL
		, MeetType varchar2(20)
		, StartTime Date NOT NULL
		, FinishTime Date 
		, Minutes varchar2(1000) --not null?
		, EmpID varchar2(10) NOT NULL --the supervisor (retrieved from the team table)
		, ClientName varchar2(30)
		, PRIMARY KEY (MeetingID) --include MeetingID, UnitID, Semester, Year...?
		, FOREIGN KEY (TeamID) REFERENCES Team
		, FOREIGN KEY (MeetType) REFERENCES MeetingType
		);

		/

		CREATE TABLE MeetingAttendance ( --Links a student to a meeting
		MeetingID number(3)
		, TeamID varchar2(10)
		, StuID varchar2(10)
		, PRIMARY KEY (TeamID, MeetingID, StuID)
		, FOREIGN KEY (MeetingID) REFERENCES Meeting
		, FOREIGN KEY (TeamID, StuID) REFERENCES StudentTeamAllocation
		);

		/
		
		CREATE TABLE AgendaItem (
		MeetingID number(3)
		, AgendaNum number(3)
		, AgendaDesc varchar2(200)
		, PRIMARY KEY (MeetingID, AgendaNum)
		, FOREIGN KEY (MeetingID) REFERENCES Meeting
		);
		
		/
		
		CREATE TABLE ActionItem (
		MeetingID number(3)
		, ActionNum number(3)
		, ActionDesc varchar2(200)
		, PRIMARY KEY (MeetingID, ActionNum)
		, FOREIGN KEY (MeetingID) REFERENCES Meeting
		);
		
		/ 
		-------------------------------------------------------------------------------------

		/

		CREATE TABLE AssessmentType( -- Attribute entity for assessment types
		AssType varchar2(20)
		, TypeDesc varchar2(100)
		, PRIMARY KEY (AssType)
		);

		/


		CREATE TABLE Assessment ( --links an assessment to a unit offering - I think they would surely have to be able to alter assessments for each subject
		AssID varchar2(10) NOT NULL
		, AssTitle varchar2(50) NOT NULL
		, AssDesc varchar2(200) -- removed the NOT NULL
		, UnitID varchar2(10) NOT NULL
		, Semester number(2) NOT NULL
		, Year number(4) NOT NULL
		, MarkingGuide varchar2(1000) 
		, AssType varchar2 (20) NOT NULL
		, DueDate Date NOT NULL
		, PRIMARY KEY (AssID, UnitID, Semester, Year)
		, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
		, FOREIGN KEY (AssType) REFERENCES AssessmentType
		);

		/
		
		CREATE TABLE AssessmentAllocation ( --links enrolled students to an assessment in an offered unit
		AssID varchar2(10)
		, UnitID varchar2(10)
		, Semester number(2)
		, Year number(4)
		, StuID varchar2(10)
		, TeamID varchar2(10) --Nullable, Assessment may be an individual task
		, Submission varchar2(1000) UNIQUE --Unique, prevents plagarism (lol)
		, PRIMARY KEY (AssID, UnitID, Semester, Year, StuID)
		, FOREIGN KEY (AssID, UnitID, Semester, Year) REFERENCES Assessment
		, FOREIGN KEY (StuID, UnitID, Semester, Year) REFERENCES Enrolment -- Does UnitID, Semester, Year need to reference all 3?
		, FOREIGN KEY (TeamID) REFERENCES Team -- Should this reference StudentTeamAllocation to match ERD?
		);

		-------------------------------------------------------------------------------------	
