-- Insert Data Into Clients Table
USE marketDB;

INSERT INTO Client (FirstName, LastName, Phone, Email, PersonalAddress)
VALUES ('Ana', 'Trujillo', '0918382912', 'ana.trujillo@email.com', 'Avda. de la Constitución 2222')

INSERT INTO Client (FirstName, LastName, Phone, Email, PersonalAddress)
VALUES ('Thomas', 'Hardy', '0948362731', 'thomas.hardy@email.com', '120 Hanover Sq.')

INSERT INTO Client (FirstName, LastName, Phone, Email, PersonalAddress)
VALUES ('Christina', ' Berglund', '0988776612', 'chris.berglund@email.com', 'Forsterstr. 57')

INSERT INTO Client (FirstName, LastName, Phone, Email, PersonalAddress)
VALUES ('Elizabeth', 'Lincoln', '0912827325', 'liza.lincoln@email.com', '23 Tsawassen Blvd.')

INSERT INTO Client (FirstName, LastName, Phone, Email, PersonalAddress)
VALUES ('Yang', 'Wang', '0979187544', 'yang.wang@email.com', 'Hauptstr. 29')

select * from Client;




