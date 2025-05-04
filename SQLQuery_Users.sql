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


DROP TABLE IF EXISTS dbo.WorkoutTemplates;
GO


DROP TABLE IF EXISTS dbo.WorkoutTemplateExercises;
GO


DROP TABLE IF EXISTS dbo.Exercises;
GO


DROP TABLE IF EXISTS dbo.Measurements;
GO










-- CREATING TABLES

    -- user data
CREATE TABLE dbo.Users
(
    UserID              INT                 IDENTITY(1,1) PRIMARY KEY,
    Username            NVARCHAR(50)        NOT NULL UNIQUE,
    PasswordHash        NVARCHAR(255)       NOT NULL,
    Email               NVARCHAR(100)       NOT NULL UNIQUE,
    DateCreated         DATETIME            NOT NULL DEFAULT GETDATE(),
    WorkoutCount        INT                 NOT NULL DEFAULT 0
);
GO


    -- history data
CREATE TABLE dbo.Workouts
(
    WorkoutID           INT                 IDENTITY(1,1) PRIMARY KEY,
    UserID              INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID),
    WorkoutDate         DATETIME            DEFAULT GETDATE(),
    WorkoutType         NVARCHAR(100),
    DurationMinutes     INT
);
GO


    -- exercises data
CREATE TABLE dbo.Exercises
(
    ExerciseID          INT                     IDENTITY(1,1) PRIMARY KEY,
    ExerciseName        NVARCHAR(100)           NOT NULL UNIQUE,
    MuscleGroup         NVARCHAR(50),    -- e.g., Chest, Legs
    Instructions        NVARCHAR(MAX)
);
GO


    -- workout data
CREATE TABLE dbo.WorkoutTemplates
(
    TemplateID          INT                 IDENTITY(1,1) PRIMARY KEY,
    UserID              INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID),
    TemplateName        NVARCHAR(100)       NOT NULL,
    CreatedDate         DATETIME            DEFAULT GETDATE()
);
GO


CREATE TABLE dbo.WorkoutTemplateExercises
(
    TemplateExerciseID  INT         IDENTITY(1,1) PRIMARY KEY,
    TemplateID          INT         NOT NULL FOREIGN KEY REFERENCES dbo.WorkoutTemplates(TemplateID),
    ExerciseID          INT         NOT NULL FOREIGN KEY REFERENCES dbo.Exercises(ExerciseID),
    Sets                INT,
    WeightLbs		    DECIMAL(5,2),   -- e.g., 75.50 lbs
    Reps                INT,
    RestSeconds         INT
);
GO


    -- measure data
CREATE TABLE dbo.Measurements
(
    MeasurementID       INT IDENTITY(1,1)       PRIMARY KEY,
    UserID              INT                     NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID),
    MeasurementDate     DATETIME                DEFAULT GETDATE(),

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










-- INSERTING DATA

INSERT INTO dbo.Exercises (ExerciseName, MuscleGroup)
VALUES
    -- Chest
('Push-Up', 'Chest'),
('Chest Fly (Machine)', 'Chest'),
('Bench Press (Barbell)', 'Chest'),
('Incline Bench Press (Barbell)', 'Chest'),
('Decline Bench Press (Barbell)', 'Chest'),

    -- Back
('Pull-Up', 'Back'),
('Deadlift (Barbell)', 'Back'),
('Seated Row (Cable)', 'Back'),
('Lat Pulldown (Cable)', 'Back'),
('Bent Over Row (Barbell)', 'Back'),

    -- Legs
('Flat Leg Raise', 'Legs'),
('Squat (Barbell)', 'Legs'),
('Lunge (Dumbbell)', 'Legs'),
('Leg Curl (Machine)', 'Legs'),
('Leg Press (Machine)', 'Legs'),
('Leg Extension (Machine)', 'Legs'),
('Standing Calf Raise (Dumbbell)', 'Legs'),

    -- Shoulders
('Upright Row (Barbell)', 'Shoulders'),
('Front Raise (Dumbbell)', 'Shoulders'),
('Reverse Fly (Dumbbell)', 'Shoulders'),
('Dumbbell Shoulder Press', 'Shoulders'),
('Lateral Raise (Dumbbell)', 'Shoulders'),
('Overhead Press (Barbell)', 'Shoulders'),
('Strict Military Press (Barbell)', 'Shoulders'),

    -- Biceps
('Bicep Curl (Barbell)', 'Biceps'),
('Hammer Curl (Dumbbell)', 'Biceps'),
('Preacher Curl (Machine)', 'Biceps'),
('Concentration Curl (Dumbbell)', 'Biceps'),

    -- Triceps
('Dips', 'Triceps'),
('Skullcrusher (Barbell)', 'Triceps'),
('Triceps Pushdown (Cable)', 'Triceps'),
('Overhead Triceps Extension (Dumbbell)', 'Triceps'),

    -- Core
('Plank', 'Core'),
('Crunches', 'Core'),
('Russian Twist', 'Core'),
('Flat Leg Raise', 'Core'),
('Bicycle Crunches', 'Core');
GO










-- DISPLAYING DATA

SELECT * FROM dbo.Users;
GO


SELECT * FROM dbo.Workouts;
GO


SELECT * FROM dbo.WorkoutTemplates;
GO


SELECT * FROM dbo.WorkoutTemplateExercises;
GO


SELECT * FROM dbo.Exercises;
GO  


SELECT * FROM dbo.Measurements;
GO