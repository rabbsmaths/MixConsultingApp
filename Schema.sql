CREATE DATABASE MiX_Consulting_DB;
GO

USE MiX_Consulting_DB;
GO

-------------------------------------------------------------------------------
-- Table: AuthorizedUsers
-- Purpose: Protects system access and enforces POPIA boundaries.
-------------------------------------------------------------------------------
CREATE TABLE AuthorizedUsers (
    UserID INT IDENTITY(1,1) NOT NULL,
    Username NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    IsActive BIT DEFAULT 1 NOT NULL,
    CONSTRAINT PK_AuthorizedUsers PRIMARY KEY CLUSTERED (UserID),
    CONSTRAINT UQ_AuthorizedUsers_Username UNIQUE (Username)
);

-------------------------------------------------------------------------------
-- Table: Companies
-- Purpose: Core enterprise entity tracking unique corporate registration keys.
-------------------------------------------------------------------------------
CREATE TABLE Companies (
    CompanyID INT IDENTITY(1,1) NOT NULL,
    CompanyName NVARCHAR(150) NOT NULL,
    VatNumber NVARCHAR(15) NULL,
    RegistrationNumber NVARCHAR(50) NULL,
    CONSTRAINT PK_Companies PRIMARY KEY CLUSTERED (CompanyID),
    CONSTRAINT UQ_Companies_RegNumber UNIQUE (RegistrationNumber)
);

-------------------------------------------------------------------------------
-- Table: Addresses
-- Purpose: Houses standalone geographic location records to prevent string replication.
-------------------------------------------------------------------------------
CREATE TABLE Addresses (
    AddressID INT IDENTITY(1,1) NOT NULL,
    Line1 NVARCHAR(150) NOT NULL,
    Line2 NVARCHAR(150) NULL,
    City NVARCHAR(100) NOT NULL,
    PostalCode NVARCHAR(10) NOT NULL,
    CONSTRAINT PK_Addresses PRIMARY KEY CLUSTERED (AddressID),
    CONSTRAINT UQ_Addresses_UniqueLocation UNIQUE (Line1, Line2, City, PostalCode)
);

-------------------------------------------------------------------------------
-- Table: CompanyAddresses (The M:M Associative Bridge Table)
-- Purpose: Maps single address location indices to multiple distinct company profiles.
-------------------------------------------------------------------------------
CREATE TABLE CompanyAddresses (
    CompanyID INT NOT NULL,
    AddressID INT NOT NULL,
    AddressType NVARCHAR(20) NOT NULL, -- 'Physical', 'Postal', 'HeadOffice'
    CONSTRAINT PK_CompanyAddresses PRIMARY KEY CLUSTERED (CompanyID, AddressID, AddressType),
    CONSTRAINT FK_CompanyAddresses_Companies FOREIGN KEY (CompanyID) 
        REFERENCES Companies (CompanyID) ON DELETE CASCADE,
    CONSTRAINT FK_CompanyAddresses_Addresses FOREIGN KEY (AddressID) 
        REFERENCES Addresses (AddressID) ON DELETE CASCADE,
    CONSTRAINT CK_CompanyAddresses_Type CHECK (AddressType IN ('Physical', 'Postal', 'HeadOffice'))
);

-------------------------------------------------------------------------------
-- Table: Representatives
-- Purpose: Manages localized primary point-of-contact child profiles.
-------------------------------------------------------------------------------
CREATE TABLE Representatives (
    RepresentativeID INT IDENTITY(1,1) NOT NULL,
    CompanyID INT NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    CellNumber NVARCHAR(15) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_Representatives PRIMARY KEY CLUSTERED (RepresentativeID),
    CONSTRAINT FK_Representatives_Companies FOREIGN KEY (CompanyID) 
        REFERENCES Companies (CompanyID) ON DELETE CASCADE
);

-- Performance Indexes optimized for heavy transactional INNER JOIN operations over the network
CREATE NONCLUSTERED INDEX IX_CompanyAddresses_Lookup ON CompanyAddresses (CompanyID) INCLUDE (AddressID, AddressType);
CREATE NONCLUSTERED INDEX IX_Companies_Search ON Companies (CompanyName);
CREATE NONCLUSTERED INDEX IX_Representatives_Lookup ON Representatives (CompanyID);

-- Seed Default Administration Profile (Username: 'admin' | Password: 'Password123')
INSERT INTO AuthorizedUsers (Username, PasswordHash)
VALUES ('admin', '$2a$12$K7v19bB4u7D2CgE9mZ6u1Oex3vRt7m9lKmPyW1QzN3G8hJn6KxyZu');
GO