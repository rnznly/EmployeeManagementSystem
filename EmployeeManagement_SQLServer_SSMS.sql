/* =============================================================
   Employee Management System - Database Setup Script
   Target: Microsoft SQL Server 2019+ / SQL Server Express
   ============================================================= */

-- 1. Create Database
IF DB_ID(N'EmployeeManagementDB') IS NULL
BEGIN
    CREATE DATABASE EmployeeManagementDB;
    PRINT 'Database EmployeeManagementDB created successfully.';
END
GO

USE EmployeeManagementDB;
GO

-- 2. Drop existing objects if recreating
IF OBJECT_ID('dbo.vw_EmployeeDirectory','V') IS NOT NULL DROP VIEW dbo.vw_EmployeeDirectory;
IF OBJECT_ID('dbo.usp_EmployeeHistory_Delete','P') IS NOT NULL DROP PROCEDURE dbo.usp_EmployeeHistory_Delete;
IF OBJECT_ID('dbo.usp_EmployeeHistory_Update','P') IS NOT NULL DROP PROCEDURE dbo.usp_EmployeeHistory_Update;
IF OBJECT_ID('dbo.usp_EmployeeHistory_Create','P') IS NOT NULL DROP PROCEDURE dbo.usp_EmployeeHistory_Create;
IF OBJECT_ID('dbo.usp_EmployeeHistory_ReadByEmployee','P') IS NOT NULL DROP PROCEDURE dbo.usp_EmployeeHistory_ReadByEmployee;
IF OBJECT_ID('dbo.usp_Employee_Search','P') IS NOT NULL DROP PROCEDURE dbo.usp_Employee_Search;
IF OBJECT_ID('dbo.usp_Employee_Delete','P') IS NOT NULL DROP PROCEDURE dbo.usp_Employee_Delete;
IF OBJECT_ID('dbo.usp_Employee_Update','P') IS NOT NULL DROP PROCEDURE dbo.usp_Employee_Update;
IF OBJECT_ID('dbo.usp_Employee_Create','P') IS NOT NULL DROP PROCEDURE dbo.usp_Employee_Create;
IF OBJECT_ID('dbo.usp_Employee_Read','P') IS NOT NULL DROP PROCEDURE dbo.usp_Employee_Read;
IF OBJECT_ID('dbo.EmploymentHistory','U') IS NOT NULL DROP TABLE dbo.EmploymentHistory;
IF OBJECT_ID('dbo.Employees','U') IS NOT NULL DROP TABLE dbo.Employees;
IF OBJECT_ID('dbo.Departments','U') IS NOT NULL DROP TABLE dbo.Departments;
IF OBJECT_ID('dbo.EmployeeNumberSequence','SO') IS NOT NULL DROP SEQUENCE dbo.EmployeeNumberSequence;
GO

-- 3. Sequence for auto-generating EMP-000001 IDs
CREATE SEQUENCE dbo.EmployeeNumberSequence 
    AS INT 
    START WITH 1 
    INCREMENT BY 1;
GO

-- 4. Departments Lookup Table
CREATE TABLE dbo.Departments (
    DepartmentId INT IDENTITY(1,1) CONSTRAINT PK_Departments PRIMARY KEY,
    DepartmentCode VARCHAR(20) NOT NULL CONSTRAINT UQ_Departments_Code UNIQUE,
    DepartmentName VARCHAR(100) NOT NULL CONSTRAINT UQ_Departments_Name UNIQUE,
    CreatedAt DATETIME2(0) NOT NULL CONSTRAINT DF_Departments_CreatedAt DEFAULT SYSUTCDATETIME()
);
GO

-- 5. Employees Master Table
CREATE TABLE dbo.Employees (
    EmployeeId VARCHAR(15) NOT NULL CONSTRAINT PK_Employees PRIMARY KEY
        CONSTRAINT DF_Employees_EmployeeId DEFAULT (
            'EMP-' + RIGHT('000000' + CONVERT(VARCHAR(6), NEXT VALUE FOR dbo.EmployeeNumberSequence), 6)
        ),
    FirstName VARCHAR(60) NOT NULL,
    MiddleName VARCHAR(60) NULL,
    LastName VARCHAR(60) NOT NULL,
    Sex VARCHAR(30) NULL CONSTRAINT CK_Employees_Sex CHECK (Sex IN ('Female','Male','Prefer not to say')),
    BirthDate DATE NOT NULL,
    Email VARCHAR(150) NOT NULL CONSTRAINT UQ_Employees_Email UNIQUE,
    Phone VARCHAR(30) NULL,
    Address VARCHAR(255) NULL,
    DepartmentId INT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    EmploymentStatus VARCHAR(20) NOT NULL CONSTRAINT DF_Employees_Status DEFAULT 'Active'
        CONSTRAINT CK_Employees_Status CHECK (EmploymentStatus IN ('Active','On Leave','Resigned','Terminated','Retired')),
    HireDate DATE NOT NULL,
    Salary DECIMAL(12,2) NOT NULL CONSTRAINT DF_Employees_Salary DEFAULT 0
        CONSTRAINT CK_Employees_Salary CHECK (Salary >= 0),
    CreatedAt DATETIME2(0) NOT NULL CONSTRAINT DF_Employees_CreatedAt DEFAULT SYSUTCDATETIME(),
    UpdatedAt DATETIME2(0) NOT NULL CONSTRAINT DF_Employees_UpdatedAt DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentId) REFERENCES dbo.Departments(DepartmentId)
        ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT CK_Employees_Dates CHECK (HireDate >= BirthDate)
);
GO

CREATE INDEX IX_Employees_Name ON dbo.Employees(LastName, FirstName);
CREATE INDEX IX_Employees_Department ON dbo.Employees(DepartmentId);
CREATE INDEX IX_Employees_Status ON dbo.Employees(EmploymentStatus);
GO

-- 6. Employment History Table (One-to-Many)
CREATE TABLE dbo.EmploymentHistory (
    HistoryId BIGINT IDENTITY(1,1) CONSTRAINT PK_EmploymentHistory PRIMARY KEY,
    EmployeeId VARCHAR(15) NOT NULL,
    CompanyName VARCHAR(150) NOT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    EmploymentType VARCHAR(20) NOT NULL CONSTRAINT CK_History_Type CHECK (
        EmploymentType IN ('Permanent','Contractual','Part-time','Internship','Temporary','Volunteer')
    ),
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    ReasonForLeaving VARCHAR(255) NULL,
    Notes VARCHAR(MAX) NULL,
    CreatedAt DATETIME2(0) NOT NULL CONSTRAINT DF_History_CreatedAt DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_History_Employee FOREIGN KEY (EmployeeId) REFERENCES dbo.Employees(EmployeeId) ON DELETE CASCADE,
    CONSTRAINT CK_History_Dates CHECK (EndDate IS NULL OR EndDate >= StartDate)
);
GO

CREATE INDEX IX_History_Employee ON dbo.EmploymentHistory(EmployeeId);
GO

-- 7. View: Dynamic Birthday-Adjusted Age & Directory Projection
CREATE OR ALTER VIEW dbo.vw_EmployeeDirectory AS
SELECT 
    e.EmployeeId,
    e.FirstName,
    e.MiddleName,
    e.LastName,
    CONCAT_WS(' ', e.FirstName, e.MiddleName, e.LastName) AS FullName,
    e.Sex,
    e.BirthDate,
    DATEDIFF(YEAR, e.BirthDate, CAST(GETDATE() AS DATE)) -
    CASE 
        WHEN DATEADD(YEAR, DATEDIFF(YEAR, e.BirthDate, CAST(GETDATE() AS DATE)), e.BirthDate) > CAST(GETDATE() AS DATE) 
        THEN 1 
        ELSE 0 
    END AS Age,
    e.Email,
    e.Phone,
    e.Address,
    e.DepartmentId,
    d.DepartmentCode,
    d.DepartmentName,
    e.JobTitle,
    e.EmploymentStatus,
    e.HireDate,
    e.Salary,
    e.CreatedAt,
    e.UpdatedAt
FROM dbo.Employees e 
LEFT JOIN dbo.Departments d ON d.DepartmentId = e.DepartmentId;
GO

-- 8. Stored Procedures: Employee CRUDS
CREATE OR ALTER PROCEDURE dbo.usp_Employee_Create
    @FirstName VARCHAR(60), @MiddleName VARCHAR(60) = NULL, @LastName VARCHAR(60), @Sex VARCHAR(30) = NULL,
    @BirthDate DATE, @Email VARCHAR(150), @Phone VARCHAR(30) = NULL, @Address VARCHAR(255) = NULL,
    @DepartmentId INT = NULL, @JobTitle VARCHAR(100), @EmploymentStatus VARCHAR(20) = 'Active',
    @HireDate DATE, @Salary DECIMAL(12,2), @EmployeeId VARCHAR(15) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NewEmployee TABLE(EmployeeId VARCHAR(15));
    INSERT dbo.Employees(FirstName, MiddleName, LastName, Sex, BirthDate, Email, Phone, Address, DepartmentId, JobTitle, EmploymentStatus, HireDate, Salary)
    OUTPUT inserted.EmployeeId INTO @NewEmployee(EmployeeId)
    VALUES(@FirstName, @MiddleName, @LastName, @Sex, @BirthDate, @Email, @Phone, @Address, @DepartmentId, @JobTitle, @EmploymentStatus, @HireDate, @Salary);
    SELECT @EmployeeId = EmployeeId FROM @NewEmployee;
    SELECT * FROM dbo.vw_EmployeeDirectory WHERE EmployeeId = @EmployeeId;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Employee_Read 
    @EmployeeId VARCHAR(15) = NULL
AS 
BEGIN 
    SET NOCOUNT ON; 
    SELECT * FROM dbo.vw_EmployeeDirectory 
    WHERE @EmployeeId IS NULL OR EmployeeId = @EmployeeId 
    ORDER BY LastName, FirstName; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Employee_Update
    @EmployeeId VARCHAR(15), @FirstName VARCHAR(60), @MiddleName VARCHAR(60) = NULL, @LastName VARCHAR(60), @Sex VARCHAR(30) = NULL,
    @BirthDate DATE, @Email VARCHAR(150), @Phone VARCHAR(30) = NULL, @Address VARCHAR(255) = NULL, @DepartmentId INT = NULL,
    @JobTitle VARCHAR(100), @EmploymentStatus VARCHAR(20), @HireDate DATE, @Salary DECIMAL(12,2)
AS 
BEGIN 
    SET NOCOUNT ON; 
    UPDATE dbo.Employees 
    SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Sex = @Sex,
        BirthDate = @BirthDate, Email = @Email, Phone = @Phone, Address = @Address,
        DepartmentId = @DepartmentId, JobTitle = @JobTitle, EmploymentStatus = @EmploymentStatus,
        HireDate = @HireDate, Salary = @Salary, UpdatedAt = SYSUTCDATETIME() 
    WHERE EmployeeId = @EmployeeId; 
    EXEC dbo.usp_Employee_Read @EmployeeId; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Employee_Delete 
    @EmployeeId VARCHAR(15)
AS 
BEGIN 
    SET NOCOUNT ON; 
    DELETE FROM dbo.Employees WHERE EmployeeId = @EmployeeId; 
    SELECT @@ROWCOUNT AS RowsDeleted; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Employee_Search 
    @Search VARCHAR(150) = NULL, 
    @DepartmentId INT = NULL, 
    @EmploymentStatus VARCHAR(20) = NULL
AS 
BEGIN 
    SET NOCOUNT ON; 
    SELECT * FROM dbo.vw_EmployeeDirectory 
    WHERE (@Search IS NULL OR EmployeeId LIKE '%' + @Search + '%' OR FullName LIKE '%' + @Search + '%' OR JobTitle LIKE '%' + @Search + '%') 
      AND (@DepartmentId IS NULL OR DepartmentId = @DepartmentId) 
      AND (@EmploymentStatus IS NULL OR EmploymentStatus = @EmploymentStatus) 
    ORDER BY LastName, FirstName; 
END;
GO

-- 9. Stored Procedures: Employment History CRUDS
CREATE OR ALTER PROCEDURE dbo.usp_EmployeeHistory_ReadByEmployee 
    @EmployeeId VARCHAR(15)
AS 
BEGIN 
    SET NOCOUNT ON; 
    SELECT * FROM dbo.EmploymentHistory 
    WHERE EmployeeId = @EmployeeId 
    ORDER BY StartDate DESC; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_EmployeeHistory_Create 
    @EmployeeId VARCHAR(15), @CompanyName VARCHAR(150), @JobTitle VARCHAR(100), 
    @EmploymentType VARCHAR(20), @StartDate DATE, @EndDate DATE = NULL, 
    @ReasonForLeaving VARCHAR(255) = NULL, @Notes VARCHAR(MAX) = NULL
AS 
BEGIN 
    SET NOCOUNT ON; 
    INSERT dbo.EmploymentHistory(EmployeeId, CompanyName, JobTitle, EmploymentType, StartDate, EndDate, ReasonForLeaving, Notes) 
    VALUES(@EmployeeId, @CompanyName, @JobTitle, @EmploymentType, @StartDate, @EndDate, @ReasonForLeaving, @Notes); 
    SELECT CAST(SCOPE_IDENTITY() AS BIGINT) AS HistoryId; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_EmployeeHistory_Update 
    @HistoryId BIGINT, @CompanyName VARCHAR(150), @JobTitle VARCHAR(100), 
    @EmploymentType VARCHAR(20), @StartDate DATE, @EndDate DATE = NULL, 
    @ReasonForLeaving VARCHAR(255) = NULL, @Notes VARCHAR(MAX) = NULL
AS 
BEGIN 
    SET NOCOUNT ON; 
    UPDATE dbo.EmploymentHistory 
    SET CompanyName = @CompanyName, JobTitle = @JobTitle, EmploymentType = @EmploymentType,
        StartDate = @StartDate, EndDate = @EndDate, ReasonForLeaving = @ReasonForLeaving, Notes = @Notes 
    WHERE HistoryId = @HistoryId; 
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_EmployeeHistory_Delete 
    @HistoryId BIGINT
AS 
BEGIN 
    SET NOCOUNT ON; 
    DELETE FROM dbo.EmploymentHistory WHERE HistoryId = @HistoryId; 
    SELECT @@ROWCOUNT AS RowsDeleted; 
END;
GO

-- 10. Seed Initial Sample Data
INSERT dbo.Departments(DepartmentCode, DepartmentName) 
VALUES ('HR', 'Human Resources'), ('IT', 'Information Technology'), ('FIN', 'Finance');
GO

DECLARE @newId VARCHAR(15);
EXEC dbo.usp_Employee_Create 'Ana', 'Marie', 'Santos', 'Female', '1995-04-10', 'ana.santos@example.com', '09170000001', 'Cebu City', 2, 'Systems Analyst', 'Active', '2022-06-01', 35000, @newId OUTPUT;
EXEC dbo.usp_Employee_Create 'Mark', NULL, 'Dela Cruz', 'Male', '1990-11-22', 'mark.delacruz@example.com', '09170000002', 'Mandaue City', 1, 'HR Officer', 'Active', '2020-01-15', 32000, @newId OUTPUT;
GO

PRINT 'Database setup completed successfully!';