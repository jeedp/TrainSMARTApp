IF DB_ID(N'UserDB') IS NULL
BEGIN
    CREATE DATABASE [UserDB];
END
GO


USE [UserDB];
GO


DROP TABLE IF EXISTS dbo.Users;
GO


CREATE TABLE dbo.Users
(
    UserID       INT            IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)   NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255)  NOT NULL,
    Email        NVARCHAR(100)  NOT NULL UNIQUE,
    DateCreated  DATETIME       DEFAULT GETDATE()
);
GO


SELECT * FROM dbo.Users;
GO