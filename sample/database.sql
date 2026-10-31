IF DB_ID('lab_equipment_db') IS NULL
    CREATE DATABASE lab_equipment_db;
GO

USE lab_equipment_db;
GO

IF OBJECT_ID('users', 'U') IS NULL
CREATE TABLE users (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    username      NVARCHAR(50) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL
);
GO

IF OBJECT_ID('categories', 'U') IS NULL
CREATE TABLE categories (
    id   INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE
);
GO

IF OBJECT_ID('equipment', 'U') IS NULL
CREATE TABLE equipment (
    property_no   NVARCHAR(20) PRIMARY KEY,
    name          NVARCHAR(100) NOT NULL,
    brand         NVARCHAR(100) NULL,
    model         NVARCHAR(100) NULL,
    serial_no     NVARCHAR(100) NULL,
    date_acquired DATE NULL,
    category_id   INT NOT NULL REFERENCES categories(id),
    status        NVARCHAR(20) NOT NULL,
    location      NVARCHAR(200) NULL,
    remarks       NVARCHAR(500) NULL
);
GO

-- Default login: username admin, password admin123 (change this)
IF NOT EXISTS (SELECT 1 FROM users WHERE username = 'admin')
INSERT INTO users (username, password_hash)
VALUES ('admin', CONVERT(NVARCHAR(255), HASHBYTES('SHA2_256', CONVERT(VARCHAR(100), 'admin123')), 2));
GO