IF DB_ID(N'UserDB') IS NULL
BEGIN
    CREATE DATABASE [UserDB];
END
GO


USE [UserDB];
GO


DROP TABLE IF EXISTS dbo.Users;
GO


DROP TABLE IF EXISTS dbo.Workouts;
GO


DROP TABLE IF EXISTS dbo.Measurements;
GO


CREATE TABLE dbo.Users
(
    UserID        INT            IDENTITY(1,1) PRIMARY KEY,
    Username      NVARCHAR(50)   NOT NULL UNIQUE,
    PasswordHash  NVARCHAR(255)  NOT NULL,
    Email         NVARCHAR(100)  NOT NULL UNIQUE,
    DateCreated   DATETIME       NOT NULL DEFAULT GETDATE(),
    WorkoutCount  INT            NOT NULL DEFAULT 0
);
GO


CREATE TABLE dbo.Workouts
(
    WorkoutID       INT IDENTITY(1,1)   PRIMARY KEY,
    UserID          INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID),
    WorkoutDate     DATETIME            DEFAULT GETDATE(),
    WorkoutType     NVARCHAR(100),
    DurationMinutes INT
);
GO


CREATE TABLE dbo.Measurements
(
    MeasurementID   INT IDENTITY(1,1)   PRIMARY KEY,
    UserID          INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID),
    MeasurementDate DATETIME            DEFAULT GETDATE(),

    -- General
    WeightKg           DECIMAL(5,2),   -- e.g., 75.50 kg
    BodyFatPercentage  DECIMAL(5,2),   -- e.g., 18.50 %
    CaloricIntake      INT,            -- e.g., 2500 calories

    -- Body parts (in centimeters)
    NeckCm             DECIMAL(5,2),
    ShouldersCm        DECIMAL(5,2),
    ChestCm            DECIMAL(5,2),
    LeftBicepCm        DECIMAL(5,2),
    RightBicepCm       DECIMAL(5,2),
    LeftForearmCm      DECIMAL(5,2),
    RightForearmCm     DECIMAL(5,2),
    UpperAbsCm         DECIMAL(5,2),
    WaistCm            DECIMAL(5,2),
    LowerAbsCm         DECIMAL(5,2),
    HipsCm             DECIMAL(5,2),
    LeftThighCm        DECIMAL(5,2),
    RightThighCm       DECIMAL(5,2),
    LeftCalfCm         DECIMAL(5,2),
    RightCalfCm        DECIMAL(5,2)
);
GO


SELECT * FROM dbo.Users;
GO


SELECT * FROM dbo.Workouts;
GO


SELECT * FROM dbo.Measurements;
GO