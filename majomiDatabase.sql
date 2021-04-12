CREATE DATABASE majomiStore;
USE majomiStore;

CREATE TABLE Employee(
	ID VARCHAR(7) NOT NULL PRIMARY KEY,
	Emp_Name VARCHAR(50) NOT NULL,
	Sex VARCHAR(10),
	DOB Date,
	Emp_Address VARCHAR(200),
	Phone_Number VARCHAR(10) NOT NULL,
	Email VARCHAR(100),
	Acadamic_Level VARCHAR(20),
	Language VARCHAR(20), 
	IDWorkType VARCHAR(5) NOT NULL REFERENCES Work(IDWorkType),
	Start_Working_Day DATE NOT NULL,
	Allowance INT
);


CREATE TABLE Work(
	IDWorkType VARCHAR(5) NOT NULL Primary key,
	TitleWork VARCHAR(20) NOT NULL,
	Salary INT NOT NULL
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
	UnitPrice INT,
	Amount_Product INT,
	Manufacturer VARCHAR(100),
	Color_Porduct VARCHAR(30),
	Image_Product IMAGE NULL,
);


CREATE TABLE Invoice(
	ID_Invoice VARCHAR(10) NOT NULL,
	Invoice_Day Date,
	ID_Customer VARCHAR(10) NOT NULL REFERENCES Customer(ID_Customer),
	ID_Product VARCHAR(10) NOT NULL REFERENCES Product(ID_Product),
	Quantity_Product INT,
	UnitPrice INT,
	GrandTotal FLOAT NULL,
);

---------------------Employee----------------------------------
SELECT *
FROM Employee;

INSERT INTO Employee VALUES('NV001','Huynh Anh Thu','Female','Dec 30, 2001','57 Duong so 1 KDC Metro','0782966311','thu001@gmail.com','Dai hoc','Tieng Anh','CV01','Mar 21, 2021',0);
INSERT INTO Employee VALUES('NV002','Le Minh Ngoc','Female','Mar 7, 2001','Nguyen Van Cu','01234567','ngoc002@gmail.com','Dai hoc','Tieng Anh','CV02','Mar 21, 2021',200000);
INSERT INTO Employee VALUES('NV003','Nguyen Hong Thao Uyen','Female','Oct 10, 2001','Duong 3/2','1234589','uyen003@gmail.com','Dai hoc','Tieng Anh','CV05','Mar 21, 2021',300000);
INSERT INTO Employee VALUES('NV004','Tran Nhan Nghia','Male','Jan 24, 2000','40 Duong so 3 KDC Thoi Nhut 2','0939635755','nghia004@gmail.com','Dai hoc','Tieng Nhat','CV07','Mar 21, 2021',2000);
INSERT INTO Employee VALUES('NV005','Nguyen Van Ha','Male','Nov 11, 2000','Long Hoa, Binh Thuy','1234567','ha005@gmail.com','Dai hoc','Tieng Phap','CV06','Mar 30, 2021',20000);
INSERT INTO Employee VALUES('NV006','Nguyen Dinh Quy','Male','Jul 24, 2000','Vo Van Kiet Binh Thuy','45634563','quy006@gmail.com','Dai hoc','Tieng Nga','CV03','Mar 30, 2021',9000);
INSERT INTO Employee VALUES('NV007','Le Doan Khanh','Male','Apr 30, 2000','Stella Ngan Thuan Binh Thuy','093234565','khanh007@gmail.com','Dai hoc','Tieng Trung','CV04','Mar 30, 2021',67000);

---------------------Account----------------------------------
SELECT * FROM Account;
INSERT INTO Account VALUES ('001','thu3012','alittlesugar');
INSERT INTO Account VALUES ('002','ngoc73','ngoc73');
INSERT INTO Account VALUES ('003','thaouyen','thaouyen');
INSERT INTO Account VALUES ('004','nghia241','chuvod');


------------------------------WORK------------------------------
INSERT INTO Work VALUES ('CV01','Quan ly',10000000);
INSERT INTO Work VALUES ('CV02','Ban hang',6000000);
INSERT INTO Work VALUES ('CV03','Bao ve',4000000);
INSERT INTO Work VALUES ('CV04','Tap vu',4500000);
INSERT INTO Work VALUES ('CV05','Nhan vien order',5000000);
INSERT INTO Work VALUES ('CV06','Mau anh',9000000);
INSERT INTO Work VALUES ('CV07','Chup anh',7000000);

--------------------Customer------------------------------------
SELECT * FROM Customer
INSERT INTO Customer VALUES ('KH001','Lu Thi Thanh Mi','0914635308');
INSERT INTO Customer VALUES ('KH002','Truong Tieu Phung','0793904783');
INSERT INTO Customer VALUES ('KH003','Tran Quang Vinh','0879293131');
INSERT INTO Customer VALUES ('KH004','Cao Ngoc Bao Long','0939894721');

--------------------Product------------------------------------

SELECT * FROM Product;

INSERT INTO Product 
SELECT 'Ao001','Ao so mi trang nam tay dai','Ao','Male',100000,10,'Thai Tuan','Trang',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\ao_so_mi_nam.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Ao002','Ao khoac jean','Ao','Female',350000,3,'Taobao','Xanh den',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\ao_khoac_jean.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Ao003','Ao khoac Cardigan','Ao','Female',550000,2,'Taobao','Den',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\Ao_Cardigan.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Ao004','Ao thun champion','Ao','Male',330000,20,'champion','Trang',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\champion.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Va001','Vay jean','Vay','Female',180000,10,'Taobao','Xanh dam',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\vay_jean.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Tu001','Tui Da Beo','Tui xach','Female',80000,50,'Taobao','Da beo',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\tui_da_beo.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Gi001','Giay adidas ultar boost 20','Giay','Male',5000000,10,'Adidas','Trang vien xanh',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\adidas-xplr-white-sf.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Qu001','Quan kappa','Quan','Male',4000000,30,'Kappa','Deng vien xanh dam',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\quan_Kappa.jpg', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Qu002','Quan short','Quan','Male',100000,30,'Tiki','Den',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\quan_short.jfif', 
	Single_Blob) AS Picture;

INSERT INTO Product 
SELECT 'Gi002','Giay Nike','Giay','Male',7000000,1,'Nike','Trang xam',
	BulkColumn FROM OPENROWSET(BULK 'F:\Programming\App\Fashion-Store-Development-Project\Photo\nike.jpeg', 
	Single_Blob) AS Picture;


-------------------------------------------Invoice-----------------------------------------------

SELECT * FROM INVOICE;

INSERT INTO INVOICE VALUES('HD001','Apr 6, 2021','KH001','Ao003',1,550000,550000);
INSERT INTO INVOICE VALUES('HD001','Apr 6, 2021','KH001','Va001',1,180000,180000);
INSERT INTO INVOICE VALUES('HD002','Apr 7, 2021','KH002','Ao002',1,350000,350000);
INSERT INTO INVOICE VALUES('HD003','Apr 7, 2021','KH003','Ao004',2,330000,330000*2);
INSERT INTO INVOICE VALUES('HD004','Apr 7, 2021','KH004','Gi001',1,5000000,5000000);
INSERT INTO INVOICE VALUES('HD004','Apr 7, 2021','KH004','Ao004',1,350000,350000);
INSERT INTO INVOICE VALUES('HD005','Apr 8, 2021','KH004','Ao001',1,100000,100000);

------------------------------------------------------------
SELECT COUNT(*) FROM Employee;

SELECT E.ID, E.Emp_Name,E.Sex,E.DOB,E.Emp_Address,E.Phone_Number,E.Email,E.Acadamic_Level,L.Title AS Title_Language ,W.Title_Work,E.Start_Working_Day
FROM Employee E JOIN Employee_Language L ON E.ID_Language=L.ID_Language
				JOIN Work W ON E.ID_Work=W.ID_Work
WHERE E.ID_Language = ANY(SELECT ID_Language FROM Employee_Language) AND E.ID_Work=ANY(SELECT ID_Work FROM Work);

SELECT * FROM Employee ORDER BY ID ASC;


SELECT E.ID, E.Emp_Name,E.Sex,E.DOB,E.Emp_Address,E.Phone_Number,E.Email,E.Acadamic_Level,E.Language ,W.TitleWork,E.Start_Working_Day
FROM Employee E JOIN Work W ON E.IDWorkType=W.IDWorkType
WHERE E.IDWorkType=ANY(SELECT IDWorkType FROM Work)
ORDER BY E.ID ASC;

SELECT E.ID, E.Emp_Name,E.Sex,E.DOB,E.Emp_Address,E.Phone_Number,E.Email,E.Acadamic_Level,E.Language ,W.TitleWork,E.Start_Working_Day
FROM Employee E JOIN Work W ON E.IDWorkType=W.IDWorkType
WHERE Emp_Name='Huynh Anh Thu'
ORDER BY E.ID ASC;

SELECT  COUNT(*) AS soluong
FROM Employee E JOIN Employee_Language L ON E.ID_Language=L.ID_Language
WHERE L.Title='Tieng Anh';

--Lay idWorkType
SELECT IDWorkType FROM Work WHERE TitleWork='Quan ly';

--Them du lieu tu bang emp_info sang du lieu bang Employee
INSERT INTO Employee
SELECT I.ID, I.Emp_Name,I.Sex,I.DOB,I.Emp_Address,I.Phone_Number,I.Email, 
		I.Acadamic_Level,L.ID_Language, W.ID_Work,I.Start_Working_Day
FROM EmpInfo I JOIN Employee_Language L ON I.Title_Language=L.Title
				JOIN Work W ON I.Title_Work=W.Title_Work
WHERE ID='008'

ORDER BY ID ASC;


SELECT * FROM Employee;

--Update data
UPDATE Employee SET ID='NV009',Emp_Name='Hoang Thien Nhi', Sex='Male',DOB='2019-02-18',Emp_Address='Thao Dien Quan 2',Phone_Number='0906627513',Email='tom@gmail',Acadamic_Level='Dai hoc',Language='Tieng Anh',IDWorkType='CV05',Start_Working_Day='2021-03-30', Allowance=0 WHERE ID='NV009';

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
SELECT ID_Customer FROM Customer WHERE PhoneNumber_Customer='0939894721';



--Tim tat ca thong tin trong bang Product
SELECT * FROM Product ORDER BY ID_Product ASC;

--Tim tat ca loai ao
SELECT * FROM Product WHERE Type_Product='Ao' ORDER BY ID_Product ASC;
SELECT COUNT(*) FROM Product WHERE Type_Product='Ao';

--Tim tat ca loai quan
SELECT * FROM Product WHERE Type_Product='Quan';

--Tim tat ca loai vay
SELECT * FROM Product WHERE Type_Product='Vay';

--Tim tat ca loai giay
SELECT * FROM Product WHERE Type_Product='Giay';

--Tim tat ca loai Tui xach
SELECT * FROM Product WHERE Type_Product='Tui xach';

SELECT * FROM Product WHERE ID_Product='Ao001';

--Cap nhat san pham
UPDATE Product SET Title_Product=@title, Type_Product=@type, Sex_Product=@sex, Cost_Product=@cost, Amount_Product=@amount, Manufacturer=@manu, Color_Porduct=@color, Image_Product=@image WHERE ID_Product=@id;


UPDATE Product 
SET Title_Product='Vay jean', Type_Product='Vay', Sex_Product='Female', UnitPrice=180000, Amount_Product=20, Manufacturer='Taobao', Color_Porduct='Xanh dam' WHERE ID_Product='Va001';
--Xac dinh ID Product

SELECT * FROM Product;
Use majomiStore
SELECT MAX(ID_Product)  FROM Product WHERE Type_Product='Ao';

SELECT * FROM Product WHERE Title_Product='Quan kappa';

--Xuat picture tu id product
SELECT Image_Product FROM Product WHERE ID_Product='Ao001';

-- Hoa don
SELECT * FROM INVOICE ORDER BY ID_Invoice ASC;

SELECT MAX(ID_Invoice) FROM INVOICE;

--In danh sach hang hoa sau khi nhap ID vao
SELECT I.ID_Product,P.Title_Product, Quantity_Product,I.UnitPrice,I.GrandTotal,P.Image_Product
FROM INVOICE I JOIN Product P ON I.ID_Product=P.ID_Product
WHERE I.ID_Invoice='HD001';

--In title hang hoa sau khi nhap ID product vao
SELECT Title_Product FROM Product WHERE ID_Product='Gi001';


SELECT * FROM INVOICE WHERE ID_Invoice='HD001';
SELECT * FROM INVOICE ORDER BY ID_Invoice ASC;
SELECT * FROM Customer;
USE majomiStore;

INSERT INTO INVOICE VALUES('HD001','Apr 6, 2021','KH001','Ao003',1,550000,0,550000,5);

SELECT COUNT(*) FROM INVOICE WHERE ID_Invoice='HD007';


DELETE INVOICE WHERE ID_Invoice='HD007';

ALTER TABLE Product
ALTER COLUMN [Cost_Product] INT NULL;

ALTER TABLE INVOICE
ALTER COLUMN [SubTotal] INT NULL;


SELECT Cost_Product FROM Product WHERE ID_Product='Ao001';

SELECT UnitPrice FROM Product WHERE ID_Product='Ao001';

SELECT SUM(GrandTotal) FROM Invoice WHERE ID_Invoice='HD001';

SELECT I.ID_Invoice,I.Invoice_Day,C.ID_Customer,C.Name_Customer,I.ID_Product,I.Quantity_Product,I.UnitPrice,I.GrandTotal
FROM Invoice I JOIN Customer C ON I.ID_Customer=C.ID_Customer
WHERE C.Name_Customer='To Huynh Minh Khoi'
ORDER BY I.ID_Invoice ASC;


SELECT * FROM Product;
SELECT * FROM Invoice;
SELECT * FROM Customer;

SELECT * FROM Invoice WHERE ID_Invoice='HD001';

SELECT Amount_Product FROM Product WHERE ID_Product='Ao001';

UPDATE Invoice SET Quantity_Product=2, GrandTotal WHERE ID_Invoice='HD001' AND ID_Customer='KH001' AND ID_Product='Ao003';

DELETE Invoice WHERE ID_Invoice='HD001' AND ID_Customer='KH001' AND ID_Product='Ao003';