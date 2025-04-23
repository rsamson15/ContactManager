CREATE DATABASE Project1;

CREATE TABLE Employees (
EmployeeID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
EmployeeFirstname VARCHAR(255),
EmployeeLastName VARCHAR(255)
);

CREATE TABLE Assignments (
AssignmentID INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
DateAssigned DATE,
OwnerFirstName VARCHAR (255),
OwnerLastName VARCHAR (255),
Address VARCHAR (255),
Phone VARCHAR (255),
ProblemDescription TEXT,
Completed BOOLEAN,
EmployeeID INT,
CONSTRAINT FK_AssignmentsEmployees FOREIGN KEY (EmployeeID)
REFERENCES Employees(EmployeeID)
);