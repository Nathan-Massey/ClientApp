-- Data entry for Client table

INSERT INTO Client (FirstName, LastName, Birthday)
            VALUES ('Nathan', 'Massey', '1989-7-6')

INSERT INTO Client (FirstName, LastName, Birthday)
            VALUES ('Collin', 'Massey', '1992-4-7')

INSERT INTO Client (FirstName, LastName, Birthday, Address)
            VALUES ('Andrew', 'Luck', '1990-9-25', 'Indianapolis')

-- ******************************************************************* --

-- Data entry for Orders table

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
			VALUES ('Towels', GETDATE(), 1, 1) -- Client Id 1 represents Nathan

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
			VALUES ('Shirts', '2017-5-3', 1, 2)

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
			VALUES ('Monitor', '2017-7-7', 1, 1)