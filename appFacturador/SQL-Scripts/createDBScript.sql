--SQL SCRIPTS TO CREATE A DATABASE

--Emergency Only!
use master;
drop database marketDB;


--PART ONE: DATABASE CREATION

--1. CREATE DATABASE AND USE IT
Create database marketDB;
Use marketDB;

--2. CREATE TABLE CLIENT
Create Table Client(
 ClientID int PRIMARY KEY IDENTITY(1,1),
 FirstName varchar (30) NOT NULL,
 LastName varchar (30) NOT NULL,
 Phone varchar (15) NOT NULL,
 Email varchar (30) NOT NULL,
 PersonalAddress varchar (60) NOT NULL
)


--3. CREATE TABLE PRODUCT
Create Table Product(
 ProductID int PRIMARY KEY IDENTITY(1,1),
 ProductName varchar (30) NOT NULL,
 ProductPrice money NOT NULL,
 ProductCategory varchar (30) NOT NULL
)

--4. CREATE TABLE INVOICE
Create Table Invoice(
 InvoiceID int PRIMARY KEY IDENTITY(1,1),
 EmissionDate date NOT NULL,
 Subtotal money NOT NULL,
 Tax int,
 Total money NOT NULL
)

--5. CREATE TABLE CLIENT CONSUMPTION
Create Table Client_Consumption(
  ClientID int,
  ProductID int,
  Units int,
  PRIMARY KEY (ClientID, ProductID),
  
  CONSTRAINT FK_ClientID FOREIGN KEY (ClientID)
  REFERENCES Client(ClientID),

  CONSTRAINT FK_ProductID FOREIGN KEY (ProductID)
  REFERENCES Product(ProductID)
)

--6. CREATE TABLE INVOICE DETAIL
Create Table Invoice_Detail(
  ClientID int,
  ProductID int,
  InvoiceID int,

  PRIMARY KEY(ClientID, ProductID, InvoiceID),
  CONSTRAINT FK_ClientConsumptionID FOREIGN KEY (ClientID, ProductID)
  REFERENCES Client_Consumption(ClientID, ProductID),

  CONSTRAINT FK_InvoiceID FOREIGN KEY (InvoiceID)
  REFERENCES Invoice(InvoiceID)
)