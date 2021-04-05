CREATE DATABASE majomiStore;
USE majomiStore;

CREATE TABLE Employee_Language(
	ID_Language VARCHAR(5) NOT NULL PRIMARY KEY,
	Title VARCHAR(25) NOT NULL
);


CREATE TABLE Work(
	ID_Work VARCHAR(3) NOT NULL PRIMARY KEY,
	Title_Work VARCHAR(25) NOT NULL,
	Salary INT NULL
);

CREATE TABLE Employee(
	ID VARCHAR(3) NOT NULL PRIMARY KEY,
	Emp_Name VARCHAR(25) NULL,
	Sex VARCHAR(5) NULL,
	DOB SMALLDATETIME NULL,
	Emp_Address VARCHAR(50),
	Phone_Number VARCHAR(10) NOT NULL,
	Email VARCHAR(100),
	Acadamic_Level VARCHAR(20),
	ID_Language VARCHAR(5) NOT NULL REFERENCES Employee_Language(ID_Language),
	ID_Work VARCHAR(3) NOT NULL REFERENCES Work(ID_Work),
	Start_Working_Day SMALLDATETIME NOT NULL,
);

CREATE TABLE Account(
	ID VARCHAR(3) NOT NULL PRIMARY KEY REFERENCES Employee(ID),
	UserName VARCHAR(25) NOT NULL UNIQUE,
	User_Password VARCHAR(25) NOT NULL	
);


--//////////////////////////LANGUAGE/////////////////////////

SELECT *
FROM Employee_Language;

INSERT INTO Employee_Language VALUES ('001','Tieng Anh ');
INSERT INTO Employee_Language VALUES ('002','Tieng Phap');
INSERT INTO Employee_Language VALUES ('003','Tieng Nga');
INSERT INTO Employee_Language VALUES ('004','Tieng Trung');
INSERT INTO Employee_Language VALUES ('005','Tieng Thai');
INSERT INTO Employee_Language VALUES ('006','Tieng Nhat');
INSERT INTO Employee_Language VALUES ('007','Tieng Han');


---------------------Work----------------------------------
SELECT * FROM Work;

INSERT INTO Work VALUES ('01','Quan Ly',10000000);
INSERT INTO Work VALUES ('02','Ban hang',7000000);
INSERT INTO Work VALUES ('03','Tap vu',6000000);
INSERT INTO Work VALUES ('04','Bao ve',5000000);
INSERT INTO Work VALUES ('05','Nhan vien order',8000000);
INSERT INTO Work VALUES ('06','Mau anh',3000000);

---------------------Employee----------------------------------
SELECT *
FROM Employee;

INSERT INTO Employee VALUES('001','Huynh Anh Thu','Nu','Dec 30, 2001','57 Duong so 1 KDC Metro','0782966311','thu011@gmail.com','Dai hoc','001','01','Mar 21, 2021');
INSERT INTO Employee VALUES('002','Le Minh Ngoc','Nu','Mar 7, 2001','Nguyen Van Cu','01234567','ngoc002@gmail.com','Dai hoc','001','02','Mar 21, 2021');
INSERT INTO Employee VALUES('003','Nguyen Thao Uyen','Nu','Oct 10, 2001','Duong 3/2','1234589','uyen003@gmail.com','Dai hoc','001','05','Mar 21, 2021');
INSERT INTO Employee VALUES('004','Tran Nhan Nghia','Nam','Jan 24, 2000','40 Duong so 3 KDC Thoi Nhut 2','0939635755','nghia004@gmail.com','Dai hoc','005','04','Mar 21, 2021');
INSERT INTO Employee VALUES('005','Nguyen Van Ha','Nam','Nov 11, 2000','Long Hoa, Binh Thuy','1234567','ha005@gmail.com','Dai hoc','001','06','Mar 30, 2021');
INSERT INTO Employee VALUES('006','Nguyen Dinh Quy','Nam','Jul 24, 2000','Vo Van Kiet Binh Thuy','45634563','quy006@gmail.com','Dai hoc','002','03','Mar 30, 2021');
INSERT INTO Employee VALUES('007','Le Doan Khanh','Nam','Apr 30, 2000','Stella Ngan Thuan Binh Thuy','093234565','khanh007@gmail.com','Dai hoc','003','04','Mar 30, 2021');

---------------------Account----------------------------------
SELECT * FROM Account;
INSERT INTO Account VALUES ('001','thu3012','alittlesugar');
INSERT INTO Account VALUES ('002','ngoc73','ngoc73');
INSERT INTO Account VALUES ('003','thaouyen','thaouyen');
INSERT INTO Account VALUES ('004','nghia241','chuvod');

--------------------------
SELECT COUNT(*)
FROM Employee;

SELECT E.ID, E.Emp_Name,E.Sex,E.DOB,E.Emp_Address,E.Phone_Number,E.Email,E.Acadamic_Level,L.Title AS Title_Language ,W.Title_Work,E.Start_Working_Day INTO EmpInfo
FROM Employee E JOIN Employee_Language L ON E.ID_Language=L.ID_Language
				JOIN Work W ON E.ID_Work=W.ID_Work
WHERE E.ID_Language = ANY(SELECT ID_Language FROM Employee_Language) AND E.ID_Work=ANY(SELECT ID_Work FROM Work);


SELECT * FROM EmpInfo ORDER BY ID ASC;

SELECT * FROM Employee ORDER BY ID ASC;

SELECT Title FROM Employee_Language; 


SELECT  COUNT(*) AS soluong
FROM Employee E JOIN Employee_Language L ON E.ID_Language=L.ID_Language
WHERE L.Title='Tieng Anh';

--Them du lieu tu bang emp_info sang du lieu bang Employee
INSERT INTO Employee
SELECT I.ID, I.Emp_Name,I.Sex,I.DOB,I.Emp_Address,I.Phone_Number,I.Email, 
		I.Acadamic_Level,L.ID_Language, W.ID_Work,I.Start_Working_Day
FROM EmpInfo I JOIN Employee_Language L ON I.Title_Language=L.Title
				JOIN Work W ON I.Title_Work=W.Title_Work
WHERE ID='008'

ORDER BY ID ASC;


--Tim theo id trong bang EmpInfo
SELECT * FROM EmpInfo WHERE id='005';
SELECT * FROM EmpInfo WHERE Emp_Name='Tran Nhan Nghia';
SELECT * FROM EmpInfo WHERE Phone_Number='0939335450';

--Xoa du lieu
DELETE EmpInfo WHERE ID='013';
SELECT * FROM EmpInfo ORDER BY ID ASC;
SELECT * FROM Employee ORDER BY ID ASC;

DELETE Employee
WHERE id='S07';

--Update data
UPDATE EmpInfo SET ID='010',Emp_Name='Ngo Quy Duc', Sex='Nu',DOB='1989-11-19',Emp_Address='Thao Dien Quan 2',Phone_Number='0906627513',Email='mai@gmail',Acadamic_Level='Dai hoc',Title_Language='Tieng Anh',Title_Work='Bao Ve',Start_Working_Day='2021-03-30' WHERE ID='012';



--Truy xuat luong (salary) nhan vien
SELECT E.Emp_Name, W.Title_Work, W.Salary
FROM Employee E JOIN Work W ON E.ID_Work=W.ID_Work;

ALTER TABLE Employee
ALTER COLUMN Start_Working_Day DATE NULL

