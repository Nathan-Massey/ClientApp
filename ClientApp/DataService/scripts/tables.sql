-- Create 2 tables , Client and Order

-- Client

CREATE TABLE Client
(
	Id INT PRIMARY KEY IDENTITY(1, 1), -- Primary Key
	FirstName VARCHAR(max) NOT NULL,
	LastName VARCHAR(max) NOT NULL,
	Birthday DATE NOT NULL,
	Address VARCHAR(max)
)

-- Order

CREATE TABLE Orders
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Description VARCHAR(max) NOT NULL,
	Created DATE NOT NULL,
	Shipped BIT NOT NULL, -- Boolean

	Client_Id INT FOREIGN KEY REFERENCES Client(Id)-- Foreign Key from Client table
)

-- New column for table orders

ALTER TABLE Orders
ADD total money;