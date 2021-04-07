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


CREATE TABLE Customer(
	ID_Customer VARCHAR(10) NOT NULL PRIMARY KEY,
	Name_Customer VARCHAR(25) NOT NULL,
	PhoneNumber_Customer VARCHAR(15) NOT NULL,
	MarkOfReward_Customer INT,
);


CREATE TABLE Product(
	ID_Product VARCHAR(10) NOT NULL PRIMARY KEY,
	Title_Product VARCHAR(100) NOT NULL,
	Type_Product VARCHAR(10) NOT NULL,
	Sex_Product VARCHAR(7) NULL,
	Cost_Product FLOAT,
	Amount_Product INT,
	Manufacturer VARCHAR(100),
	Color_Porduct VARCHAR(30),
	Image_Product IMAGE NULL,
);

CREATE TABLE INVOICE(
	ID_Invoice VARCHAR(10) NOT NULL,
	Invoice_Day Date,
	ID_Customer VARCHAR(10) NOT NULL REFERENCES Customer(ID_Customer),
	ID_Product VARCHAR(10) NOT NULL REFERENCES Product(ID_Product),
	Quantity_Product INT,
	SubTotal FLOAT NULL,
	Discount FLOAT NULL,
	GrandTotal FLOAT NULL,
	MarkOfAccumulation INT
);

	
--////////////////////////////////////////LANGUAGE/////////////////////////////////////////////

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

--------------------Customer------------------------------------
SELECT * FROM Customer
INSERT INTO Customer VALUES ('KH001','Lu Thi Thanh Mi','0914635308',10);
INSERT INTO Customer VALUES ('KH002','Truong Tieu Phung','0793904783',5);
INSERT INTO Customer VALUES ('KH003','Tran Quang Vinh','0879293131',8);
INSERT INTO Customer VALUES ('KH004','Cao Ngoc Bao Long','0939894721',17);

--------------------Product------------------------------------

SELECT * FROM Product;

INSERT INTO Product 
SELECT 'ASM001','Ao so mi trang nam tay dai','Ao','Male',100000,10,'Thai Tuan','Trang',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\ao_so_mi_nam.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'AK001','Ao khoac jean','Ao','Female',350000,3,'Taobao','Xanh den',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\ao_khoac_jean.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'AK002','Ao khoac Cardigan','Ao','Female',550000,2,'Taobao','Den',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\Ao_Cardigan.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'AT001','Ao thun champion','Ao','Male',330000,20,'champion','Trang',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\champion.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'V001','Vay jean','Vay','Female',180000,10,'Taobao','Xanh dam',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\vay_jean.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'TX001','Tui Da Beo','Tui xach','Female',80000,50,'Taobao','Da beo',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\tui_da_beo.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'G001','Giay adidas ultar boost 20','Giay','Male',5000000,10,'Adidas','Trang vien xanh',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\adidas-xplr-white-sf.jpg', 
	Single_Blob) AS Picture;

-------------------------------------------Invoice-----------------------------------------------

SELECT * FROM INVOICE;

INSERT INTO INVOICE VALUES('HD001','Apr 6, 2021','KH001','AK002',1,550000,null,550000,5);
INSERT INTO INVOICE VALUES('HD001','Apr 6, 2021','KH001','V001',1,180000,null,180000,1);
INSERT INTO INVOICE VALUES('HD002','Apr 7, 2021','KH002','AK001',1,350000,null,350000,3);
INSERT INTO INVOICE VALUES('HD003','Apr 7, 2021','KH003','AT001',2,330000,null,330000,(330000*2)/100000);
INSERT INTO INVOICE VALUES('HD004','Apr 7, 2021','KH004','G001',1,5000000,null,5000000,5000000/100000);
INSERT INTO INVOICE VALUES('HD004','Apr 7, 2021','KH004','AT001',1,350000,null,350000,3);
INSERT INTO INVOICE VALUES('HD005','Apr 8, 2021','KH004','ASM001',1,100000,0.2,100000-100000*0.2,1);



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



--Truy xuat thong tin toan bo Customer
SELECT * FROM Customer ORDER BY ID_Customer ASC;

SELECT MAX(ID_Customer) FROM Customer;

DELETE Customer WHERE ID_Customer='KH007';

UPDATE Customer SET Name_Customer='Lan Nguyen', PhoneNumber_Customer='01234' WHERE ID_Customer='KH007';

--Tim kiem customer theo phone number
SELECT * FROM Customer WHERE PhoneNumber_Customer='0939894721';