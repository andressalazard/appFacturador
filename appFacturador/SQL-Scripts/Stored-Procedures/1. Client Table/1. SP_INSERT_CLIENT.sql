--STORED PROCEDURES FOR CLIENT TABLE
--1. In case we need to switch database
--USE marketDB;


--2. Stored Procedure to Insert a new Client Record
CREATE PROCEDURE SP_Insert_Client
	( @FirstName varchar(30), @LastName varchar(30),
	  @Phone varchar(15), @Email varchar(30),
	  @PersonalAddress varchar(60) )
AS
BEGIN
  INSERT INTO Client(FirstName, LastName, Phone, Email, PersonalAddress)
  VALUES (@FirstName, @LastName,@Phone,@Email, @PersonalAddress)
END;

