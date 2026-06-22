USE CognizantSQL;

CREATE TABLE EmployeeDetails (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Salary DECIMAL(10,2)
);

INSERT INTO EmployeeDetails VALUES
(1,'Tejasri',50000),
(2,'Pavithra',60000);

DELIMITER $$

CREATE PROCEDURE GetEmployees()
BEGIN
    SELECT * FROM EmployeeDetails;
END $$

DELIMITER ;

CALL GetEmployees();