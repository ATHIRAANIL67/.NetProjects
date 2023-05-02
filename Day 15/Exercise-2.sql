CREATE TABLE CLIENT_MASTER (
    CLIENTNO VARCHAR(6) CONSTRAINT pk_clientno PRIMARY KEY CHECK (CLIENTNO LIKE 'C%'),
    NAME VARCHAR(20) NOT NULL,
    ADDRESS1 VARCHAR(30),
    ADDRESS2 VARCHAR(30),
    CITY VARCHAR(15),
    PINCODE NUMERIC(8),
    STATE VARCHAR(15),
    BALDUE NUMERIC(10,2)
);

INSERT INTO Client_Master VALUES 
('C00001', 'Ivan Bayross', 'ABC House','Gandhi Street','Mumbai', 400054, 'Maharashtra', 15000),
('C00002','Amit Antony','XYZ House','Tirupathi Nagar','Chennai',506767,'Tamilnadu',20000),
('C00003','Daya R','Karthika','Pallickathodu','Kottayam',686503,'Kerala',12000.00),
('C00004','Lee Min Ho','ChaCha','Chung','Jungsei',124356,'Seoul',40000.00),
('C00005','Aleena Joji','Kulathoor','Kurissummodu','Changassery',675834,'Kerala',5000.00);

CREATE TABLE PRODUCT_MASTER (
  PRODUCTNO VARCHAR(6) CONSTRAINT PK_PRODUCTNO PRIMARY KEY CONSTRAINT CHK_PRODUCTNO CHECK (PRODUCTNO LIKE 'P%'),
  DESCRIPTION VARCHAR(15) NOT NULL,
  PROFITPERC NUMERIC(4,2) NOT NULL,
  UNITMEASURE VARCHAR(10) NOT NULL,
  QTYONHAND NUMERIC(8) NOT NULL,
  REORDERLVL NUMERIC(8) NOT NULL,
  SELLPRICE NUMERIC(8,2) CONSTRAINT CHK_SELLPRICE CHECK (SELLPRICE <> 0) NOT NULL,
  COSTPRICE NUMERIC(8,2) CONSTRAINT CHK_COSTPRICE CHECK (COSTPRICE <> 0) NOT NULL
);

INSERT INTO Product_Master VALUES 
('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250),
('P00002','Jeans',3,'Piece',100,55,3500,4000),
('P00003','Kurti',6,'Piece',110,30,800,850),
('P00004','1.44 drive',4,'Piece',55,36,1000,950);

CREATE TABLE SALESMAN_MASTER (
    SALESMANNO varchar(6) CONSTRAINT pk_salesmanno PRIMARY KEY CHECK (SALESMANNO LIKE 'S%'),
    SALESMANNAME varchar(20) NOT NULL,
    ADDRESS1 varchar(30) NOT NULL,
    ADDRESS2 varchar(30),
    CITY varchar(20),
    PINCODE numeric(8),
    STATE varchar(20),
    SALAMT numeric(8,2) NOT NULL CHECK (SALAMT <> 0),
    TGTTOGET numeric(6,2) NOT NULL,
    YTDSALES numeric(6,2) NOT NULL,
    REMARKS varchar(60)
);

INSERT INTO Salesman_Master VALUES 
('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good'),
('S00002', 'Neerav', 'B/16', 'Alandur', 'Chennai', 509997, 'tamilnadu', 3500, 50, 55, 'Average'), 
('S00003', 'Daksha', 'A/09', 'Pampady', 'Kottayam', 686589, 'Kerala', 1000, 200, 80, 'Excellent');

CREATE TABLE SALES_ORDER (
    ORDERNO VARCHAR(6) CONSTRAINT pk_sales_order PRIMARY KEY CHECK (ORDERNO LIKE 'O%'),
    CLIENTNO VARCHAR(6) CONSTRAINT fk_sales_order_client REFERENCES CLIENT_MASTER (CLIENTNO),
    ORDERDATE DATE,
    DELYADDR VARCHAR(25),
    SALESMANNO VARCHAR(6) CONSTRAINT fk_sales_order_salesman REFERENCES SALESMAN_MASTER (SALESMANNO),
    DELYTYPE CHAR(1) CHECK (DELYTYPE IN ('P', 'F')),
    BILLEDYN CHAR(1) CHECK (BILLEDYN IN ('Y', 'N')),
    DELYDATE DATE,
    ORDERSTATUS VARCHAR(10) CHECK (ORDERSTATUS IN ('In Process', 'Fulfilled', 'Backorder', 'Cancelled'))
);

select * from SALES_ORDER;
 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus) 
 VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'In Process');
 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus) 
 VALUES('O19002', '23-april-18', 'C00002', 'P', 'N', 'S00003', '22-december-23', 'Cancelled');
 INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus) 
 VALUES('O19003', '12-july-03', 'C00001', 'P', 'Y', 'S00002', '20-july-18', 'Backorder');




CREATE TABLE SALES_ORDER_DETAILS (
  ORDERNO varchar(6),
  PRODUCTNO varchar(6),
  QTYORDERED numeric(8),
  QTYDISP numeric(8),
  PRODUCTRATE numeric(10,2),
  CONSTRAINT PK_SALES_ORDER_DETAILS PRIMARY KEY (ORDERNO, PRODUCTNO),
  CONSTRAINT FK_SALES_ORDER FOREIGN KEY (ORDERNO) REFERENCES SALES_ORDER(ORDERNO),
  CONSTRAINT FK_PRODUCT_MASTER FOREIGN KEY (PRODUCTNO) REFERENCES PRODUCT_MASTER(PRODUCTNO)
);
select * from SALES_ORDER_DETAILS;
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525); 
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19002', 'P00003', 3, 5, 300);
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19003', 'P00002', 6, 9, 773); 

/*Answer following queries with the help of above schema : [10] 
1. Display the names of all the clients.*/
select name from CLIENT_MASTER;

--2. Display all the clients who are located in Mumbai. 
select name from CLIENT_MASTER where city='Mumbai';

--3. Display all the products whose selling price is > 2000 and < 5000. 
select description from PRODUCT_MASTER where SELLPRICE between 2000 and 5000;

--4. Display Name, City and State of Clients not in the state of Maharashtra. 
select name,city,state from CLIENT_MASTER where state not in('Maharashtra');

--5. Display all the information of client_no C0001 and C0002.
select * from CLIENT_MASTER where CLIENTNO in('C00001','C00002');

--6. Change the selling price of '1.44 drive' to Rs. 1150.50. 
update PRODUCT_MASTER set SELLPRICE=1150.50 where DESCRIPTION='1.44 drive';

--7. Delete the record of client_no C0005. 
delete from CLIENT_MASTER where CLIENTNO='C00005';

--8. Display the clients who stay in a city whose second letter is 'a'. 
INSERT INTO Client_Master VALUES 
('C00005', 'James Joy', 'A House','Nehru Street','Manjeri', 687890, 'Kerala', 5000);
select name from CLIENT_MASTER where city like '_a%';

--9. Count the number of products having price greater than or equal to 1500. 
select count(productno) from PRODUCT_MASTER where SELLPRICE>=1500;

--10. Display qtyordered, qtydisp and balancedqty (not in table). select QTYORDERED,QTYDISP,(qtyordered-qtydisp) as BALANCEDQTY from SALES_ORDER_DETAILS;--Write Commands to do following [10] Define in 1 or 2 lines and give one example also [10] 
--1. Make Client_no as primary key in client_master. 
ALTER TABLE CLIENT_MASTER ADD PRIMARY KEY (CLIENTNO);

--2. Add a new column phone_no in the client_master table. 
ALTER TABLE CLIENT_MASTER ADD PHONE_NO NUMERIC(10);

--3. Add the not null constraint in the product_master table with the column description, profit percent, sell price and cost price. 
ALTER TABLE PRODUCT_MASTER
ALTER COLUMN DESCRIPTION VARCHAR(15) NOT NULL;
ALTER TABLE PRODUCT_MASTER
ALTER COLUMN PROFITPERC NUMERIC(4,2) NOT NULL;
ALTER TABLE PRODUCT_MASTER
ALTER COLUMN SELLPRICE NUMERIC(8,2) NOT NULL;
ALTER TABLE PRODUCT_MASTER
ALTER COLUMN COSTPRICE NUMERIC(8,2) NOT NULL;

--4. Change size of name column to 60 in client_master table. 
ALTER TABLE CLIENT_MASTER 
ALTER COLUMN NAME VARCHAR(60);

--5. Remove pincode column from table. ALTER TABLE CLIENT_MASTER DROP COLUMN PINCODE;--Write queries for following descriptions: (Joins ) [10]
--1. Find out the products, which have been sold to 'Ivan Bayross'. 
SELECT PM.PRODUCTNO, PM.DESCRIPTION
FROM PRODUCT_MASTER PM
INNER JOIN SALES_ORDER_DETAILS SOD ON PM.PRODUCTNO = SOD.PRODUCTNO
INNER JOIN SALES_ORDER SO ON SOD.ORDERNO = SO.ORDERNO
INNER JOIN CLIENT_MASTER CM ON SO.CLIENTNO = CM.CLIENTNO
WHERE CM.NAME = 'Ivan Bayross';

--2. Finding out the products and their quantities that will have to be delivered in the current month.


--3. Listing the ProductNo and description of constantly sold (i.e. rapidly moving) products. 
--4. Finding the names of clients who have purchased 'Trousers'. 
--5. Listing the products and orders from customers who have ordered less than 5 units of 'Pull Overs'. 