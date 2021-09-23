--STORED PROCEDURES FOR INVOICE_DETAIL
--1. In case we need to switch database
--USE marketDB;

CREATE PROCEDURE SP_InsertInvoiceDetail
 ( @ClientId int,
   @ProductId int,
   @InvoiceId int,
   @ProductUnits int,
   @ProductTotalCost money)

AS
  BEGIN
    INSERT INTO Invoice_Detail (ClientID, ProductID, InvoiceID, ProductUnits, ProductTotalCost)
	VALUES(@ClientId, @ProductId, @InvoiceId, @ProductUnits, @ProductTotalCost)
  END;

