DROP TABLE IF EXISTS Couriers;

CREATE TABLE Couriers (
    CourierID INT IDENTITY(1,1) PRIMARY KEY,
    SenderName NVARCHAR(100),
    SenderAddress NVARCHAR(200),
    ReceiverName NVARCHAR(100),
    ReceiverAddress NVARCHAR(200),
    Weight FLOAT,
    Status NVARCHAR(50),
    TrackingNumber NVARCHAR(100),
    DeliveryDate DATETIME,
    UserId INT
);

DROP TABLE IF EXISTS Employees;

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    Email NVARCHAR(100),
    ContactNumber NVARCHAR(20),
    Role NVARCHAR(50),
    Salary FLOAT
);

SELECT * FROM Couriers;
SELECT * FROM Employees;
