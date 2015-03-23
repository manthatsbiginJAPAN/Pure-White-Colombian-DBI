DROP TABLE AssessmentAllocation;
DROP TABLE Assessment;
DROP TABLE MeetingAttendance;
DROP TABLE Meeting;
DROP TABLE TeamAllocation;
DROP TABLE Team;
DROP TABLE Project;
DROP TABLE EmployeeRole;
DROP TABLE Role;
DROP TABLE Employee;
DROP TABLE Enrolment;
DROP TABLE UnitOffering;
DROP TABLE Unit;
DROP TABLE STUDENT;


CREATE TABLE Student ( --links a student id to a name 
StuID varchar2(10)
, FirstName varchar2(20) NOT NULL
, LastName varchar2(20) NOT NULL -- in the pdf it doesn't say that it has to be not null... but that's kinda :/
, Email varchar2(100) UNIQUE --nullable? Not everyone will have an email right?
, ContactNo varchar2(10) NOT NULL
, Password varchar2(50) NOT NULL -- ie admin assigns pw at the start, could be bday for example
, PRIMARY KEY (StuID)
);

CREATE TABLE Unit ( --links a unit to a name
UnitID varchar2 (10)
, UnitName varchar2 (50) NOT NULL
, UnitDesc varchar2 (200)
, PRIMARY KEY (UnitID)
);

CREATE TABLE UnitOffering ( -- links unit to a point in time (year and semester) and assigns convener
UnitID varchar2(10) NOT NULL
, Semester number(1) NOT NULL
, Year number(4) NOT NULL
, PRIMARY KEY (UnitID, Semester, Year)
, FOREIGN KEY (UnitID) REFERENCES Unit
);

CREATE TABLE Enrolment ( --links an enrolled student to an offered unit
StuID varchar2(10) NOT NULL
, UnitID varchar2(10) NOT NULL
, Semester number(1) NOT NULL
, Year number(4) NOT NULL
, PRIMARY KEY (StuID, UnitID, Semester, Year)
, FOREIGN KEY (StuID) REFERENCES Student
, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
);

-------------------------------------------------------------------------------------

CREATE TABLE Employee ( --links an employee id to a name
EmpID varchar2(10)
, FirstName varchar2(20) NOT NULL
, LastName varchar2 (20) NOT NULL
, Email varchar2(100) UNIQUE
, ContactNo varchar2(10) NOT NULL
, Password varchar2(50) NOT NULL
, PRIMARY KEY (EmpID)
);

CREATE TABLE Role ( --lists the number of roles available (ie convener, admin and supervisor)
Role varchar2(20) -- use a check constraint? Extra points. Ok
--, RoleDescription varchar2 (200) -- probably not neccessary..?
, PRIMARY KEY (Role)
);

CREATE TABLE EmployeeRole ( --Links an employee to a particular role in a particular offered unit 
EmpID varchar2(10) NOT NULL -- do we need to explicitly say 'not null' for all of these below?
, Role varchar2(20) NOT NULL
, UnitID varchar2(20) NOT NULL
, Semester number(1) NOT NULL
, Year number(4) NOT NULL
, PRIMARY KEY (EmpID, Role, UnitID, Semester, Year)
, FOREIGN KEY (EmpID) REFERENCES Employee
, FOREIGN KEY (Role) REFERENCES Role
, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
);

-------------------------------------------------------------------------------------

CREATE TABLE Project ( --Links a projectID (with description) to an offered unit 
ProjID varchar2(10) NOT NULL
, ProjDesc varchar2(200) NOT NULL
, UnitID varchar2(10) NOT NULL
, Semester number(1) NOT NULL
, Year number (4) NOT NULL
, PRIMARY KEY (ProjID, UnitID, Semester, Year)
, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
);

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
, FOREIGN KEY (EmpID, Role, UnitID, Semester, Year) REFERENCES EmployeeRole --need to test
);

CREATE TABLE TeamAllocation ( --links an enrolled student to a team (which is already assigned to a unit offering)
TeamID varchar2(10) -- do we need 'not null'
, StuID varchar2(10) -- 'can' be null
, UnitID varchar2(10) NOT NULL
, Semester number(1) NOT NULL
, Year number(4) NOT NULL
, PRIMARY KEY (TeamID, StuID)
, FOREIGN KEY (TeamID) REFERENCES Team
, FOREIGN KEY (StuID, UnitID, Semester, Year) REFERENCES Enrolment
);

-------------------------------------------------------------------------------------

CREATE TABLE Meeting ( --Links a team to a meeting for an offered unit
TeamID varchar2(10) NOT NULL
, MeetingNo number(2) NOT NULL --thus will be limited to 99 meetings, but I 
, UnitID varchar2(10) NOT NULL
, Semester number(1) NOT NULL
, Year number(4) NOT NULL
, StartTime Date NOT NULL
, FinishTime Date NOT NULL
, Agenda varchar2(1000) --not null?
, Minutes varchar2(1000) --not null?
, ActionItems varchar2(1000) --not null?
, EmpID varchar2(10) NOT NULL --the supervisor (retrieved from the team table)
, PRIMARY KEY (TeamID, MeetingNo) --include MeetingID, UnitID, Semester, Year...?
, FOREIGN KEY (TeamID) REFERENCES Team
);

CREATE TABLE MeetingAttendance ( --Links a student to a meeting
MeetingNo number(2) NOT NULL
, TeamID varchar2(10) NOT NULL
, StuID varchar2(10) NOT NULL
, PRIMARY KEY (TeamID, MeetingNo, StuID)
, FOREIGN KEY (TeamID, MeetingNo) REFERENCES Meeting
, FOREIGN KEY (TeamID, StuID) REFERENCES TeamAllocation
);

-------------------------------------------------------------------------------------

CREATE TABLE Assessment ( --links an assessment to a unit offering - I think they would surely have to be able to alter assessments for each subject
AssID varchar2(10) NOT NULL
, AssTitle varchar2(50) NOT NULL
, AssDesc varchar2(200) NOT NULL
, UnitID varchar2(10) NOT NULL
, Semester number(2) NOT NULL
, Year number(4) NOT NULL
, Nature varchar2(10) --how do we distinguish individual assessments from group ones...? Check constraint in (individual/group) but then what..? :(
, MarkingGuide varchar2(1000)
, DueDate Date NOT NULL
, PRIMARY KEY (AssID, UnitID, Semester, Year)
, FOREIGN KEY (UnitID, Semester, Year) REFERENCES UnitOffering
);

CREATE TABLE AssessmentAllocation ( --links enrolled students to an assessment in an offered unit
AssID varchar2(10) NOT NULL
, UnitID varchar2(10) NOT NULL
, Semester number(2) NOT NULL
, Year number(4) NOT NULL
, StuID varchar2(10) NOT NULL
, TeamID varchar2(10) --SHOULD be nullable... ie it's blank if it's an individual assessment, otherwise links with team
						-- but not sure how to approach this...
, Submission varchar2(1000) UNIQUE
, Score number(3)
, Feedback	varchar2(500)
, PRIMARY KEY (AssID, UnitID, Semester, Year, StuID)
, FOREIGN KEY (AssID, UnitID, Semester, Year) REFERENCES Assessment
, FOREIGN KEY (StuID, UnitID, Semester, Year) REFERENCES Enrolment
, FOREIGN KEY (TeamID) REFERENCES Team --cos this part is where it's not going to like it
);

-------------------------------------------------------------------------------------