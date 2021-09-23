--STORED PROCEDURE FOR INVOICE TABLE
-- IN CASE WE NEED TO SWITCH DB
--  USE marketDB

CREATE PROCEDURE SP_Insert_Invoice 
 (@EmissionDate datetime, @Subtotal money,
  @Tax int, @Total money, @SerialNumber varchar(15)) 
AS
  BEGIN
    INSERT INTO Invoice(EmissionDate,Subtotal, Tax, Total, RUC, SerialNumber)
	VALUES(@EmissionDate, @Subtotal, @Tax, @Total, '1792433363001', @SerialNumber)
  END;
