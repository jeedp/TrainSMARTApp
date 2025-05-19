IF DB_ID(N'UserDB') IS NULL
BEGIN
    CREATE DATABASE [UserDB];
END
GO


USE [UserDB];
GO


--DROP TABLE IF EXISTS dbo.Users;
--GO


--DROP TABLE IF EXISTS dbo.Workouts;
--GO


--DROP TABLE IF EXISTS dbo.WorkoutTemplates;
--GO


--DROP TABLE IF EXISTS dbo.WorkoutTemplateExercises;
--GO


--DROP TABLE IF EXISTS dbo.WorkoutTemplateExerciseSets;
--GO


DROP TABLE IF EXISTS dbo.Exercises;
GO


--DROP TABLE IF EXISTS dbo.Measurements;
--GO










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
    UserID              INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID) ON DELETE CASCADE,
    TemplateID          INT                 NULL FOREIGN KEY REFERENCES dbo.WorkoutTemplates(TemplateID),
    DatePerformed       DATETIME            DEFAULT GETDATE(),
    Note                NVARCHAR(MAX)       NULL
);
GO


CREATE TABLE dbo.WorkoutExercises
(
    WorkoutExerciseID   INT                 IDENTITY(1,1) PRIMARY KEY,
    WorkoutID           INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Workouts(WorkoutID) ON DELETE CASCADE,
    ExerciseID          INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Exercises(ExerciseID),
    DisplayOrder        INT                 NOT NULL
);
GO


CREATE TABLE dbo.WorkoutExerciseSets
(
    SetID               INT                 IDENTITY(1,1) PRIMARY KEY,
    WorkoutExerciseID   INT                 NOT NULL FOREIGN KEY REFERENCES dbo.WorkoutExercises(WorkoutExerciseID) ON DELETE CASCADE,
    WeightLbs           DECIMAL(5,2),
    Reps                INT,
    TimeSeconds         INT,
    SetOrder            INT
);
GO


    -- exercises data
CREATE TABLE dbo.Exercises
(
    ExerciseID          INT                 IDENTITY(1,1) PRIMARY KEY,
    ExerciseName        NVARCHAR(100)       NOT NULL UNIQUE,
    MuscleGroup         NVARCHAR(50),       -- e.g., Chest, Legs
    Instructions        NVARCHAR(MAX)
);
GO


    -- workout data
CREATE TABLE dbo.WorkoutTemplates
(
    TemplateID          INT                 IDENTITY(1,1) PRIMARY KEY,
    UserID              INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID) ON DELETE CASCADE,
    TemplateName        NVARCHAR(100)       NOT NULL,
    Note                NVARCHAR(MAX)       NULL,
    DateCreated         DATETIME            DEFAULT GETDATE(),
    IsPrebuilt		    BIT                 DEFAULT 0       -- 0 = Custom, 1 = Prebuilt
);
GO


CREATE TABLE dbo.WorkoutTemplateExercises
(
    TemplateExerciseID  INT                 IDENTITY(1,1) PRIMARY KEY,
    TemplateID          INT                 NOT NULL FOREIGN KEY REFERENCES dbo.WorkoutTemplates(TemplateID) ON DELETE CASCADE,
    ExerciseID          INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Exercises(ExerciseID),
    RestSeconds         INT                 DEFAULT 60,     -- e.g., 60 seconds
    DisplayOrder        INT                 NOT NULL
);
GO


CREATE TABLE dbo.WorkoutTemplateExerciseSets 
(
    SetID               INT                 PRIMARY KEY IDENTITY(1,1),
    TemplateExerciseID  INT                 NOT NULL FOREIGN KEY REFERENCES dbo.WorkoutTemplateExercises(TemplateExerciseID) ON DELETE CASCADE,
    WeightLbs           DECIMAL(5,2)        NULL,
    Reps                INT                 NULL,
    RepsOnly            INT                 NULL,
    TimeSeconds         INT                 NULL,
    SetOrder            INT                 NOT NULL
);
GO


    -- measure data
CREATE TABLE dbo.Measurements
(
    MeasurementID       INT IDENTITY(1,1)   PRIMARY KEY,
    UserID              INT                 NOT NULL FOREIGN KEY REFERENCES dbo.Users(UserID) ON DELETE CASCADE,
    MeasurementDate     DATETIME            DEFAULT GETDATE(),

    -- General
    WeightKg            DECIMAL(5,2),       -- e.g., 75.50 kg
    BodyFatPercentage   DECIMAL(5,2),       -- e.g., 18.50 %
    CaloricIntake       INT,                -- e.g., 2500 calories

    -- Body parts (in centimeters)
    NeckCm              DECIMAL(5,2)        NULL,
    ShouldersCm         DECIMAL(5,2)        NULL,
    ChestCm             DECIMAL(5,2)        NULL,
    LeftBicepCm         DECIMAL(5,2)        NULL,
    RightBicepCm        DECIMAL(5,2)        NULL,
    LeftForearmCm       DECIMAL(5,2)        NULL,
    RightForearmCm      DECIMAL(5,2)        NULL,
    UpperAbsCm          DECIMAL(5,2)        NULL,
    WaistCm             DECIMAL(5,2)        NULL,
    LowerAbsCm          DECIMAL(5,2)        NULL,
    HipsCm              DECIMAL(5,2)        NULL,
    LeftThighCm         DECIMAL(5,2)        NULL,
    RightThighCm        DECIMAL(5,2)        NULL,
    LeftCalfCm          DECIMAL(5,2)        NULL,
    RightCalfCm         DECIMAL(5,2)        NULL
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
('Cable Crossover', 'Chest'),
('Dumbbell Bench Press', 'Chest'),
('Incline Dumbbell Press', 'Chest'),
('Decline Dumbbell Press', 'Chest'),
('Pec Deck Machine', 'Chest'),
('Single Arm Chest Press (Cable)', 'Chest'),
('Incline Chest Fly (Dumbbell)', 'Chest'),
('Decline Chest Fly (Dumbbell)', 'Chest'),
('Isometric Chest Squeeze', 'Chest'),

-- Back
('Pull-Up', 'Back'),
('Deadlift (Barbell)', 'Back'),
('Seated Row (Cable)', 'Back'),
('Lat Pulldown (Cable)', 'Back'),
('Bent Over Row (Barbell)', 'Back'),
('T-Bar Row', 'Back'),
('Chin-Up', 'Back'),
('Straight Arm Pulldown (Cable)', 'Back'),
('Single Arm Row (Dumbbell)', 'Back'),
('Inverted Row', 'Back'),
('Reverse Grip Lat Pulldown', 'Back'),
('Meadow Row', 'Back'),
('Chest Supported Row (Machine)', 'Back'),
('Cable Row with Rope', 'Back'),
('Resistance Band Row', 'Back'),

-- Legs
('Squat (Barbell)', 'Legs'),
('Lunge (Dumbbell)', 'Legs'),
('Leg Curl (Machine)', 'Legs'),
('Leg Press (Machine)', 'Legs'),
('Leg Extension (Machine)', 'Legs'),
('Standing Calf Raise (Dumbbell)', 'Legs'),
('Romanian Deadlift (Barbell)', 'Legs'),
('Sumo Squat (Dumbbell)', 'Legs'),
('Step-Up (Dumbbell)', 'Legs'),
('Bulgarian Split Squat', 'Legs'),
('Hip Thrust (Barbell)', 'Legs'),
('Glute Bridge', 'Legs'),
('Box Squat', 'Legs'),
('Wall Sit', 'Legs'),

-- Shoulders
('Upright Row (Barbell)', 'Shoulders'),
('Front Raise (Dumbbell)', 'Shoulders'),
('Reverse Fly (Dumbbell)', 'Shoulders'),
('Dumbbell Shoulder Press', 'Shoulders'),
('Lateral Raise (Dumbbell)', 'Shoulders'),
('Overhead Press (Barbell)', 'Shoulders'),
('Strict Military Press (Barbell)', 'Shoulders'),
('Arnold Press (Dumbbell)', 'Shoulders'),
('Cable Lateral Raise', 'Shoulders'),
('Face Pull (Cable)', 'Shoulders'),
('Cable Front Raise', 'Shoulders'),
('Landmine Press', 'Shoulders'),
('One-Arm Overhead Press (Dumbbell)', 'Shoulders'),

-- Biceps (under "Arms")
('Bicep Curl (Barbell)', 'Arms'),
('Hammer Curl (Dumbbell)', 'Arms'),
('Preacher Curl (Machine)', 'Arms'),
('Concentration Curl (Dumbbell)', 'Arms'),
('Cable Curl', 'Arms'),
('EZ Bar Curl', 'Arms'),
('Incline Dumbbell Curl', 'Arms'),
('Cable Hammer Curl with Rope', 'Arms'),
('Spider Curl', 'Arms'),
('Zottman Curl', 'Arms'),
('Reverse Curl (EZ Bar)', 'Arms'),

-- Triceps (under "Arms")
('Dips', 'Arms'),
('Skullcrusher (Barbell)', 'Arms'),
('Triceps Pushdown (Cable)', 'Arms'),
('Overhead Triceps Extension (Dumbbell)', 'Arms'),
('Close Grip Bench Press (Barbell)', 'Arms'),
('Kickbacks (Dumbbell)', 'Arms'),
('Overhead Cable Triceps Extension', 'Arms'),
('Close Grip Push-Up', 'Arms'),
('Reverse Grip Triceps Pushdown', 'Arms'),
('Single Arm Triceps Kickback', 'Arms'),

-- Core
('Plank', 'Core'),
('Crunches', 'Core'),
('Russian Twist', 'Core'),
('Flat Leg Raise', 'Core'),
('Bicycle Crunches', 'Core'),
('Hanging Leg Raise', 'Core'),
('Cable Crunch', 'Core'),
('Mountain Climbers', 'Core'),
('Side Plank', 'Core'),
('V-Ups', 'Core'),
('Toe Touches', 'Core'),
--('Flutter Kicks', 'Core'),
('Sit-Up', 'Core'),
('Hollow Body Hold', 'Core'),

-- Olympic
('Clean and Jerk', 'Olympic'),
('Snatch', 'Olympic'),
('Power Clean', 'Olympic'),
('Push Press', 'Olympic'),
('Hang Clean', 'Olympic'),
('Hang Snatch', 'Olympic'),
('Split Jerk', 'Olympic'),
('Power Snatch', 'Olympic'),
('High Pull (Barbell)', 'Olympic'),
('Muscle Clean', 'Olympic'),
('Deficit Snatch', 'Olympic'),
('Overhead Squat Snatch Grip', 'Olympic'),
('Block Pull (Snatch or Clean)', 'Olympic'),
('Tall Snatch', 'Olympic'),
('Clean Pull', 'Olympic'),

-- Full Body
('Thruster (Barbell)', 'Full Body'),
('Burpee', 'Full Body'),
('Kettlebell Swing', 'Full Body'),
('Dumbbell Snatch', 'Full Body'),
('Clean to Press (Dumbbell)', 'Full Body'),
--('Wall Ball', 'Full Body'),
('Deadlift to Press', 'Full Body'),
('Overhead Squat', 'Full Body'),
('Jump Squat', 'Full Body'),

-- Cardio
('Running (Treadmill)', 'Cardio'),
('Cycling (Stationary)', 'Cardio'),
('Rowing (Machine)', 'Cardio'),
('Jump Rope', 'Cardio'),
('Stair Climber', 'Cardio'),
('Elliptical Trainer', 'Cardio'),
--('Sled Push', 'Cardio'),
('Jumping Jacks', 'Cardio'),
('High Knees', 'Cardio'),

-- Other
('Stretching', 'Other')
GO










-- 1. Push-Up
UPDATE dbo.Exercises
SET Instructions = N'
1. Start in a plank position with your hands
    slightly wider than shoulder-width apart.
2. Keep your core tight and your body in a 
    straight line from head to heels.
3. Lower your chest towards the ground by 
    bending your elbows, keeping them close 
    to your body.
4. Stop when your chest is just above the 
    floor.
5. Push back up to the starting position 
    while keeping your form tight.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Push-Up';

-- 2. Chest Fly (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on the chest fly machine and adjust 
    the seat so the handles are at chest 
    level.
2. Grip the handles with a slight bend in 
    your elbows and keep your feet flat 
    on the floor.
3. Slowly bring the handles together in 
    front of your chest in a hugging 
    motion.
4. Squeeze your chest muscles at the peak 
    of the movement.
5. Return the handles to the starting 
    position in a controlled motion.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Chest Fly (Machine)';

-- 3. Bench Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie flat on a bench with your feet 
    planted firmly on the ground.
2. Grip the barbell slightly wider than 
    shoulder-width apart.
3. Unrack the barbell and position it 
    above your chest.
4. Lower the bar to the middle of your 
    chest while keeping your elbows at a 
    45-degree angle.
5. Push the bar back up to the starting 
    position until your arms are fully 
    extended.
6. Do not bounce the bar off your chest. 
    Use a smooth, controlled motion.'
WHERE ExerciseName = 'Bench Press (Barbell)';

-- 4. Incline Bench Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Set an incline bench at about 30-45 
    degrees.
2. Lie back with feet flat on the floor 
    and grip the bar slightly wider 
    than shoulder-width.
3. Unrack the barbell and hold it above 
    your upper chest.
4. Lower the bar down to the upper portion
    of your chest in a controlled manner.
5. Push the bar back up until your arms 
    are fully extended.
6. Focus on controlled motion and avoid 
    arching your lower back.'
WHERE ExerciseName = 'Incline Bench Press (Barbell)';

-- 5. Decline Bench Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Set a decline bench and secure your 
    legs under the pads.
2. Lie back and grip the barbell slightly 
    wider than shoulder-width apart.
3. Unrack the bar and hold it above your 
    lower chest.
4. Lower the bar to just below your chest 
    level in a controlled manner.
5. Press the bar back up to the starting 
    position until your arms are straight.
6. Maintain a tight core throughout the 
    exercise.'
WHERE ExerciseName = 'Decline Bench Press (Barbell)';

-- 6. Pull-Up
UPDATE dbo.Exercises
SET Instructions = N'
1. Grab the pull-up bar with a grip 
    slightly wider than shoulder-width, 
    palms facing away.
2. Hang with arms fully extended and legs 
    slightly bent if needed.
3. Pull yourself up until your chin is 
    above the bar, squeezing your shoulder 
    blades together.
4. Lower yourself back down with control 
    until your arms are fully extended 
    again.
5. Avoid swinging your body or kicking 
    your legs for momentum.'
WHERE ExerciseName = 'Pull-Up';

-- 7. Deadlift (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet hip-width apart, 
    barbell over your mid-foot.
2. Bend at the hips and knees to grip 
    the bar with both hands just outside 
    your knees.
3. Keep your back flat, chest up, and 
    core braced.
4. Drive through your heels to lift 
    the bar, keeping it close to your 
    body.
5. Stand up tall at the top with hips 
    and knees locked.
6. Lower the bar back to the ground 
    in a controlled manner.'
WHERE ExerciseName = 'Deadlift (Barbell)';

-- 8. Seated Row (Cable)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit down at the cable row machine and 
    place your feet on the foot platform.
2. Grab the handle with both hands and sit 
    upright with a straight back.
3. Pull the handle toward your torso while 
    squeezing your shoulder blades 
    together.
4. Pause briefly, then slowly return to 
    the starting position.
5. Avoid leaning back excessively; maintain 
    a controlled range of motion.'
WHERE ExerciseName = 'Seated Row (Cable)';

-- 9. Lat Pulldown (Cable)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit down at the lat pulldown machine 
    and adjust the thigh pads.
2. Grip the bar slightly wider than 
    shoulder-width with palms facing 
    forward.
3. Pull the bar down toward your upper 
    chest, squeezing your shoulder blades 
    together.
4. Pause at the bottom, then slowly 
    release the bar back to the starting 
    position.
5. Avoid using momentum or leaning too 
    far backward.'
WHERE ExerciseName = 'Lat Pulldown (Cable)';

-- 10. Bent Over Row (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, holding a barbell with an 
    overhand grip.
2. Bend your knees slightly and hinge 
    forward at the hips until your torso 
    is nearly parallel to the ground.
3. Let the bar hang at arm’s length, then 
    row it toward your lower chest.
4. Squeeze your shoulder blades together 
    at the top.
5. Lower the bar back down in a controlled 
    motion.
6. Keep your back straight throughout the 
    movement.'
WHERE ExerciseName = 'Bent Over Row (Barbell)';

-- 11. Squat (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and the barbell resting across 
    your upper back.
2. Grip the bar with both hands and brace 
    your core.
3. Begin the squat by pushing your hips 
    back and bending your knees.
4. Lower until your thighs are parallel 
    to the floor or slightly below.
5. Push through your heels to return to 
    the starting position.
6. Keep your chest up and knees in line 
    with your toes.'
WHERE ExerciseName = 'Squat (Barbell)';

-- 12. Lunge (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand upright holding a dumbbell in 
    each hand at your sides.
2. Step forward with one leg and lower 
    your hips until both knees are bent 
    at about 90 degrees.
3. Keep your front knee directly above 
    your ankle and your torso upright.
4. Push back through the heel of your 
    front foot to return to the starting 
    position.
5. Repeat with the opposite leg and 
    continue alternating.'
WHERE ExerciseName = 'Lunge (Dumbbell)';

-- 13. Leg Curl (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Adjust the machine so the pad rests 
    just above your ankles.
2. Lie face down and grip the handles for 
    support.
3. Curl your legs upward by contracting 
    your hamstrings.
4. Pause at the top of the movement, then 
    slowly lower back to the starting 
    position.
5. Avoid lifting your hips off the pad.'
WHERE ExerciseName = 'Leg Curl (Machine)';

-- 14. Leg Press (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on the leg press machine and place 
    your feet shoulder-width apart on the 
    platform.
2. Release the safety handles and lower 
    the platform by bending your knees.
3. Stop when your knees are at about a 
    90-degree angle.
4. Push the platform back up by extending 
    your legs without locking your knees.
5. Maintain control and avoid bouncing at 
    the bottom.'
WHERE ExerciseName = 'Leg Press (Machine)';

-- 15. Leg Extension (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on the leg extension machine with 
    your back against the pad and the 
    ankle pad above your feet.
2. Adjust the machine so your knees align 
    with the pivot point.
3. Extend your legs by contracting your 
    quadriceps.
4. Pause briefly at the top, then slowly 
    lower the weight back down.
5. Avoid using momentum and keep your 
    movement smooth and controlled.'
WHERE ExerciseName = 'Leg Extension (Machine)';

-- 16. Standing Calf Raise (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand upright holding a dumbbell in 
    each hand at your sides.
2. Position the balls of your feet on the 
    edge of a step or platform, allowing 
    your heels to hang off.
3. Raise your heels as high as possible by 
    contracting your calves.
4. Pause briefly at the top, then slowly 
    lower your heels below the platform 
    level.
5. Perform the movement in a slow, 
    controlled manner for full range of 
    motion.'
WHERE ExerciseName = 'Standing Calf Raise (Dumbbell)';

-- 17. Upright Row (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold a barbell with an 
    overhand grip in front of your thighs.
2. Pull the bar straight up to your chest, 
    keeping it close to your body.
3. Lead with your elbows, which should 
    remain higher than your wrists.
4. Pause briefly at the top, then lower 
    the bar back to the starting position.
5. Avoid swinging or using momentum.'
WHERE ExerciseName = 'Upright Row (Barbell)';

-- 18. Front Raise (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand upright with a dumbbell in each 
    hand resting in front of your thighs.
2. Keeping your arms straight (slight bend 
    at the elbow), raise the weights 
    directly in front of you to shoulder 
    height.
3. Pause briefly, then slowly lower the 
    weights back down to the starting 
    position.
4. Avoid using momentum and keep your 
    torso stationary.'
WHERE ExerciseName = 'Front Raise (Dumbbell)';

-- 19. Reverse Fly (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Hold a dumbbell in each hand and bend 
    at the hips until your torso is 
    nearly parallel to the ground.
2. Let your arms hang down with a slight 
    bend in the elbows.
3. Raise the weights out to the sides, 
    squeezing your shoulder blades 
    together at the top.
4. Slowly lower the weights back to the 
    starting position.
5. Avoid swinging and keep the motion 
    controlled.'
WHERE ExerciseName = 'Reverse Fly (Dumbbell)';

-- 20. Dumbbell Shoulder Press
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on a bench with back support 
    holding a dumbbell in each hand at 
    shoulder height.
2. Rotate your wrists so your palms face 
    forward.
3. Press the dumbbells upward until your 
    arms are fully extended above your 
    head.
4. Pause briefly, then slowly lower the 
    weights back to shoulder height.
5. Keep your back flat against the bench 
    and avoid arching excessively.'
WHERE ExerciseName = 'Dumbbell Shoulder Press';

-- 21. Lateral Raise (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand upright holding a dumbbell in 
    each hand at your sides.
2. With a slight bend in your elbows, 
    raise your arms out to the sides 
    until they are at shoulder height.
3. Pause briefly at the top, then lower 
    the dumbbells back down slowly.
4. Keep your torso stationary and avoid 
    using momentum.'
WHERE ExerciseName = 'Lateral Raise (Dumbbell)';

-- 22. Overhead Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart holding a barbell at shoulder 
    height.
2. Grip the bar slightly wider than 
    shoulder-width and brace your core.
3. Press the barbell overhead until your 
    arms are fully extended.
4. Pause, then lower the bar back to 
    shoulder level in a controlled motion.
5. Avoid leaning back; keep your spine 
    neutral throughout.'
WHERE ExerciseName = 'Overhead Press (Barbell)';

-- 23. Strict Military Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand tall with your feet together 
    and the barbell resting on your 
    upper chest.
2. Engage your core and press the bar 
    overhead without using your legs or 
    momentum.
3. Lock your arms out fully at the top, 
    then slowly lower the bar back to 
    your chest.
4. Keep your glutes and abs tight to 
    avoid back arching.'
WHERE ExerciseName = 'Strict Military Press (Barbell)';

-- 24. Bicep Curl (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart holding a barbell with an 
    underhand grip.
2. Keep your elbows close to your torso 
    and curl the bar up toward your 
    chest.
3. Squeeze your biceps at the top, then 
    lower the bar slowly to the starting 
    position.
4. Avoid swinging or using your back for 
    momentum.'
WHERE ExerciseName = 'Bicep Curl (Barbell)';

-- 25. Hammer Curl (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with a dumbbell in each hand, 
    palms facing inward.
2. Keeping your elbows tight to your 
    sides, curl both dumbbells 
    simultaneously.
3. Pause at the top, then slowly return 
    to the starting position.
4. Maintain controlled movement 
    throughout the exercise.'
WHERE ExerciseName = 'Hammer Curl (Dumbbell)';

-- 26. Preacher Curl (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit at the preacher bench and place 
    your arms over the angled pad, 
    gripping the handles or bar.
2. Curl the weight toward your shoulders, 
    keeping your upper arms pressed 
    against the pad.
3. Squeeze your biceps at the top, then 
    lower the weight slowly.
4. Focus on controlled movement and 
    avoid bouncing the weight.'
WHERE ExerciseName = 'Preacher Curl (Machine)';

-- 27. Concentration Curl (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on a bench and hold a dumbbell in 
    one hand with your elbow resting on 
    the inside of your thigh.
2. Curl the dumbbell up toward your 
    shoulder while keeping your upper 
    arm stationary.
3. Squeeze at the top, then slowly 
    lower the dumbbell.
4. Repeat for the desired reps before 
    switching arms.'
WHERE ExerciseName = 'Concentration Curl (Dumbbell)';

-- 28. Dips
UPDATE dbo.Exercises
SET Instructions = N'
1. Grip parallel bars and lift your body 
    so your arms are fully extended.
2. Lower yourself slowly by bending your 
    elbows until your upper arms are 
    parallel to the ground.
3. Press back up to the starting 
    position by extending your arms.
4. Keep your body upright to emphasize 
    triceps; leaning forward targets 
    the chest more.'
WHERE ExerciseName = 'Dips';

-- 29. Skullcrusher (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on a bench holding a barbell 
    with a narrow grip directly above 
    your chest.
2. Bend your elbows to lower the bar 
    toward your forehead.
3. Stop just before the bar touches your 
    forehead, then extend your arms 
    to raise the bar back up.
4. Keep your elbows stationary and 
    pointed forward throughout.'
WHERE ExerciseName = 'Skullcrusher (Barbell)';


-- 30. Triceps Pushdown (Cable)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand facing a cable machine with a 
    straight or angled bar attached to 
    the high pulley.
2. Grip the bar with palms facing down 
    and elbows tucked into your sides.
3. Push the bar down until your arms 
    are fully extended, squeezing your 
    triceps.
4. Slowly return to the starting 
    position, resisting the pull.
5. Keep your elbows stationary 
    throughout the movement.'
WHERE ExerciseName = 'Triceps Pushdown (Cable)';

-- 31. Overhead Triceps Extension (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit or stand holding a dumbbell with 
    both hands above your head.
2. Keep your elbows close to your ears 
    and lower the dumbbell behind your 
    head.
3. Extend your arms to lift the dumbbell 
    back to the starting position.
4. Avoid flaring your elbows or arching 
    your back.'
WHERE ExerciseName = 'Overhead Triceps Extension (Dumbbell)';

-- 32. Plank
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie face down and lift your body onto 
    your toes and forearms.
2. Keep your body in a straight line 
    from head to heels.
3. Engage your core, glutes, and quads 
    throughout the hold.
4. Do not let your hips sag or rise; 
    maintain a neutral spine.'
WHERE ExerciseName = 'Plank';

-- 33. Crunches
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on your back with knees bent and 
    hands behind your head.
2. Lift your upper back off the ground 
    by contracting your abs.
3. Pause briefly at the top, then lower 
    back down slowly.
4. Avoid pulling on your neck; keep your 
    chin slightly tucked.'
WHERE ExerciseName = 'Crunches';

-- 34. Russian Twist
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on the floor with knees bent and 
    feet lifted slightly off the ground.
2. Lean back slightly and hold a weight 
    or medicine ball in front of you.
3. Twist your torso to one side, then to 
    the other, rotating from the waist.
4. Keep your core engaged and move in a 
    controlled manner.'
WHERE ExerciseName = 'Russian Twist';

-- 35. Flat Leg Raise
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie flat on your back with your hands 
    under your hips for support.
2. Keeping your legs straight, lift them 
    up until they form a 90-degree angle.
3. Slowly lower them back down without 
    letting your feet touch the ground.
4. Engage your core throughout the 
    movement.'
WHERE ExerciseName = 'Flat Leg Raise';

-- 36. Bicycle Crunches
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on your back with your hands 
    behind your head and legs lifted.
2. Bring one knee toward your chest 
    while twisting your opposite elbow 
    toward it.
3. Alternate sides in a pedaling motion, 
    keeping your core tight.
4. Move slowly and deliberately for best 
    engagement.'
WHERE ExerciseName = 'Bicycle Crunches';





-- Chest

UPDATE dbo.Exercises 
SET Instructions = N' 
1. Stand in the center of the cable machine 
    with handles at chest level.
2. Keep your core tight and arms extended 
    to the sides with a slight bend in 
    your elbows.
3. Step forward slightly to create tension 
    in the cables.
4. Bring your hands together in front of 
    your chest in a wide, curved motion.
5. Squeeze your chest for a second when 
    your hands meet.
6. Slowly return to the starting position, 
    feeling a stretch in your chest.
7. Repeat for the desired number of 
    repetitions. '
WHERE ExerciseName = 'Cable Crossover';


UPDATE dbo.Exercises 
SET Instructions = N' 
1. Lie on a flat bench with dumbbells in 
    hand.
2. Keep your core tight and feet flat on 
    the floor.
3. Press the dumbbells upward, extending 
    your arms fully.
4. Pause for a second at the top.
5. Lower the dumbbells slowly back to your 
    chest.
6. Repeat for the desired number of 
    repetitions. '
WHERE ExerciseName = 'Dumbbell Bench Press';


UPDATE dbo.Exercises 
SET Instructions = N' 
1. Sit on an incline bench with dumbbells 
    in hand.
2. Keep your core tight and feet flat on 
    the floor.
3. Press the dumbbells upward, extending 
    your arms fully.
4. Pause for a second at the top.
5. Lower the dumbbells slowly back to your
    chest.
6. Repeat for the desired number of 
    repetitions. '
WHERE ExerciseName = 'Incline Dumbbell Press';


UPDATE dbo.Exercises 
SET Instructions = N' 
1. Lie on a decline bench with dumbbells 
    in hand.
2. Keep your core tight and feet secured 
    under the pads.
3. Press the dumbbells upward, extending 
    your arms fully.
4. Pause for a second at the top.
5. Lower the dumbbells slowly back to your
    chest.
6. Repeat for the desired number of
    repetitions. '
WHERE ExerciseName = 'Decline Dumbbell Press';


UPDATE dbo.Exercises 
SET Instructions = N' 
1. Sit on the machine with your elbows at 
    chest level.
2. Keep your core tight and back against 
    the backrest.
3. Push the handles together, squeezing 
    your chest.
4. Pause for a second when your hands are 
    close together.
5. Slowly return to the starting position.
6. Repeat for the desired number of 
    repetitions.  '
WHERE ExerciseName = 'Pec Deck Machine';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set the cable handle at chest height 
    and stand with your side facing the 
    machine.
2. Grab the handle with one hand and step 
    forward into a split stance.
3. Keep your core tight and your back
    straight.
4. Press the handle forward until your
    arm is fully extended.
5. Pause for a second at the end of the 
    movement.
6. Slowly return your hand to the starting
    position.
7. Repeat for the desired number of
    repetitions, then switch arms.'
WHERE ExerciseName = 'Single Arm Chest Press (Cable)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set an incline bench to about 
    30–45 degrees and lie on it 
    holding a dumbbell in each hand.
2. Start with your arms extended above
    your chest, palms facing each 
    other, and a slight bend in your 
    elbows.
3. Slowly lower the dumbbells out to 
    your sides in a wide arc, keeping 
    the bend in your elbows.
4. Stop when you feel a stretch in 
    your chest (dumbbells at about 
    chest level).
5. Bring the dumbbells back up in the
    same arc motion, squeezing your 
    chest at the top.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Incline Chest Fly (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set a bench to a decline position 
    and lie down with a dumbbell in
    each hand.
2. Hold the dumbbells above your chest
    with palms facing each other and 
    a slight bend in your elbows.
3. Slowly lower the dumbbells out to
    your sides in a wide arc until you 
    feel a stretch in your chest.
4. Keep your elbows slightly bent 
    throughout the movement.
5. Bring the dumbbells back up in the 
    same arc motion, squeezing your 
    chest at the top.
6. Repeat for the desired number of
repetitions.'
WHERE ExerciseName = 'Decline Chest Fly (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand or sit upright with your feet
    shoulder-width apart.
2. Hold a medicine ball or press your 
    palms together in front of your 
    chest.
3. Keep your elbows bent and at chest 
    level.
4. Squeeze your hands or the ball as
    hard as you can to activate your 
    chest muscles.
5. Hold the squeeze for 10–20 seconds 
    while keeping your core tight and 
    back straight.
6. Release the tension slowly.
7. Repeat for the desired number of 
    sets.'
WHERE ExerciseName = 'Isometric Chest Squeeze';


-- Back

UPDATE dbo.Exercises 
SET Instructions = N' 
1. Stand on the T-bar platform, holding 
    the handles firmly.
2. Keep your back straight and your 
    core tight throughout the movement.
3. Lift the weight by pulling the 
    handles toward your chest.
4. Squeeze your back muscles at the top 
    of the movement.
5. Slowly lower the weight back to the 
    starting position with control. 
6. Repeat for the desired number of 
    repetitions. '
WHERE ExerciseName = 'T-Bar Row';


UPDATE dbo.Exercises 
SET Instructions = N'
1 .Grab the pull-up bar with your palms 
    facing you and hands shoulder-width 
    apart.
2. Hang fully extended, keeping your 
    core tight and legs slightly bent 
    or crossed.
3. Pull your body up by bending your 
    elbows and driving them down toward 
    your sides.
4. Keep going until your chin is above 
    the bar.
5. Pause for a second at the top.
6. Lower yourself slowly back to the 
    starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Chin-up';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand facing a high pulley machine 
    with a straight bar attached.
2. Grab the bar with both hands, palms 
    facing down, and step back slightly.
3. Keep your arms straight and bend 
    forward slightly at the hips.
4. Pull the bar down in an arc until 
    your hands reach your thighs.
5. Squeeze your lats at the bottom of 
    the movement.
6. Slowly return the bar to the 
    starting position with control.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Straight Arm Pulldown (Cable)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Place your left knee and hand on a 
    bench for support.
2. Hold a dumbbell in your right hand, 
    arm extended straight down.
3. Keep your back flat and core tight.
4. Pull the dumbbell up toward your 
    waist, keeping your elbow close 
    to your body.
5. Squeeze your back muscles at the top.
6. Slowly lower the dumbbell back to 
    the starting position.
7. Repeat for the desired number of 
    repetitions, then switch sides.'
WHERE ExerciseName = 'Single Arm Row (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set a barbell in a rack at about 
    waist height or use a Smith machine.
2. Lie underneath the bar and grab it 
    with an overhand grip, hands slightly 
    wider than shoulder-width.
3. Keep your body straight with heels on 
    the ground and arms fully extended, 
    and core engaged.
4. Pull your chest up toward the bar by 
    bending your elbows.
5. Squeeze your shoulder blades together 
    at the top.
6. Lower yourself slowly back to the 
    starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Inverted Row';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit at the lat pulldown machine and 
    grab the bar with an underhand 
    (palms facing you) grip, hands 
    shoulder-width apart.
2. Keep your chest up and your back .
    straight.
3. Pull the bar down toward your upper 
    chest by bending your elbows and 
    squeezing your shoulder blades 
    together.
4. Pause briefly at the bottom of the 
    movement.
5. Slowly return the bar to the starting 
    position with control.
6. Repeat for the desired number of 
    repetitions.'
 WHERE ExerciseName = 'Reverse Grip Lat Pulldown';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Place one end of a barbell in a 
    landmine or corner for support and 
    load the other end with weight.
2. Stand beside the bar, stagger your 
    stance, and bend at the hips while 
    keeping your back flat.
3. Grab the bar with the hand closest to 
    it using a neutral grip 
    (palm facing in).
4. Keep your core tight and pull the bar 
    toward your hip by driving your elbow 
    back.
5. Squeeze your back muscles at the top of 
    the movement.
6. Slowly lower the bar back to the 
    starting position.
7. Repeat for the desired number of reps, 
    then switch sides.'
WHERE ExerciseName = 'Meadow Row';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit on the machine and place your chest
    against the pad.
2. Grab the handles with both hands, 
    keeping your arms extended.
3. Keep your chest pressed into the pad 
    and your core tight.
4. Pull the handles toward your body by 
    squeezing your shoulder blades 
    together.
5. Pause briefly at the top of the 
    movement.
6. Slowly return the handles to the 
    starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Chest Supported Row (Machine)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit at a cable row machine and attach
    a rope to the low pulley.
2. Grab the rope handles with both hands,
    palms facing each other.
3. Sit up straight with your back flat 
    and feet secured.
4. Pull the rope toward your lower chest 
    while keeping your elbows close to 
    your body.
5. Squeeze your shoulder blades together 
    at the end of the pull.
6. Slowly extend your arms to return to 
    the starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Cable Row with Rope';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Attach a resistance band to a sturdy 
    object at chest height.
2. Grab the ends of the band with both 
    hands, palms facing each other.
3. Step back to create tension in the 
    band and stand with your feet 
    shoulder-width apart.
4. Pull the handles toward your body by 
    bending your elbows and squeezing 
    your shoulder blades together.
5. Pause briefly when your hands are near 
    your body.
6. Slowly extend your arms back to the 
    starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Resistance Band Row';


-- Legs

UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet hip-width apart 
    and hold a barbell in front of your
    thighs with both hands.
2. Keep a slight bend in your knees and 
    brace your core.
3. Hinge at your hips and lower the
    barbell down the front of your legs.
4. Keep your back flat and the bar close
    to your body as you lower.
5. Stop when you feel a stretch in your
    hamstrings or the bar reaches 
    mid-shin level.
6. Push your hips forward to return to
    the starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Romanian Deadlift (Barbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet wider than
    shoulder-width apart and toes
    pointed slightly outward.
2. Hold a dumbbell with both hands,
    letting it hang straight down in 
    front of you.
3. Keep your back straight and core 
    tight.
4. Lower your body by bending your knees
    and pushing your hips back.
5. Go down until your thighs are parallel 
    to the ground or slightly below.
6. Push through your heels to return to 
    the starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Sumo Squat (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand facing a bench or elevated 
    platform, holding a dumbbell in 
    each hand at your sides.
2. Step up with your right foot, pushing 
    through your heel to lift your body 
    onto the platform.
3. Bring your left foot up to meet your 
    right foot on the platform.
4. Step back down with your right foot, 
    followed by your left foot, 
    returning to the starting position.
5. Repeat the movement for the desired 
    number of repetitions, then 
    switch legs.'
WHERE ExerciseName = 'Step-Up (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand a few feet away from a bench 
    with a dumbbell in each hand.
2. Place the top of your left foot on 
    the bench behind you.
3. Keep your torso upright and core 
    tight.
4. Lower your body by bending your 
    right knee, keeping your right 
    knee aligned with your toes.
5. Go down until your right thigh is 
    parallel to the ground, or 
    slightly below.
6. Push through your right heel to 
    return to the starting position.
7. Repeat for the desired number of 
    repetitions, then switch legs.'
WHERE ExerciseName = 'Bulgarian Split Squat';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit on the ground with your upper back 
    against a bench and a barbell over 
    your hips.
2. Roll the barbell to rest on your hips, 
    keeping your feet flat on the floor
    and knees bent.
3. Plant your feet shoulder-width apart 
    and keep your core tight.
4. Drive your hips upward by pressing 
    through your heels, lifting the 
    barbell.
5. Squeeze your glutes at the top of the 
    movement and hold for a second.
6. Slowly lower your hips back to the 
    starting position.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Hip Thrust (Barbell)';


UPDATE dbo.Exercises
SET Instructions = N'
1. Lie flat on your back with your knees
    bent and feet flat on the floor, 
    hip-width apart.
2. Keep your arms at your sides with palms
    facing down.
3. Drive through your heels and lift your 
    hips toward the ceiling, squeezing 
    your glutes at the top.
4. Pause for a second at the top of the 
    movement.
5. Slowly lower your hips back to the 
    floor.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Glute Bridge';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand in front of a box or bench with
    your feet shoulder-width apart.
2. Keep your chest up, core tight, and 
    back straight.
3. Slowly lower yourself by pushing your
    hips back and bending your knees.
4. Sit down gently on the box, keeping 
    your weight on your heels.
5. Pause for a second on the box, then 
    push through your heels to stand back 
    up to the starting position.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Box Squat';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your back against a wall, 
    feet shoulder-width apart, and about 
    2 feet away from the wall.
2. Slide your back down the wall, bending 
    your knees to about 90 degrees, like 
    sitting in an invisible chair.
3. Keep your knees aligned with your 
    ankles, and your thighs parallel to 
    the ground.
4. Hold this position, keeping your core 
    tight and back flat against the wall.
5. Hold for as long as you can, then 
    slowly stand back up to the starting 
    position.
6. Repeat for the desired number of 
    repetitions or duration.'
WHERE ExerciseName = 'Wall Sit';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Start by standing with your feet 
    shoulder-width apart and knees 
    slightly bent.
2. Lower into a squat position by bending 
    your knees and pushing your hips back, 
    keeping your chest up and back 
    straight.
3. Begin walking forward while staying in 
    the squat position, keeping your knees
    bent and close to the ground.
4. Take small, controlled steps, 
    maintaining the squat form throughout.
5. Keep your core tight and avoid letting 
    your knees cave inward.
6. Continue walking for a set distance or 
    time, then stand up to the starting 
    position.'
WHERE ExerciseName = 'Duck Walk';


-- Shoulders

UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit or stand with a dumbbell in each 
    hand, holding them at shoulder 
    height with palms facing your body.
2. Keep your core tight and back 
    straight.
3. Press the dumbbells overhead, 
    rotating your palms to face 
    forward as you lift.
4. Fully extend your arms at the top, 
    squeezing your shoulders.
5. Slowly lower the dumbbells back to 
    the starting position, rotating your 
    palms to face your body again.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Arnold Press (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand next to a cable machine with 
    the pulley set to the lowest 
    position.
2. Grab the handle with the hand 
    farthest from the machine, 
    keeping your arm at your side.
4. Step away from the machine slightly 
    to create tension in the cable, and 
    stand tall with your core tight.
5. Raise your arm out to the side, 
    keeping a slight bend in your 
    elbow, until it reaches shoulder 
    height.
6. Squeeze your shoulder at the top of 
    the movement.
7. Slowly lower your arm back to the 
    starting position, maintaining 
    control.
8. Repeat for the desired number of 
    repetitions, then switch sides.'
WHERE ExerciseName = 'Cable Lateral Raise';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set the pulley of a cable machine 
    to head height and attach a rope 
    handle.
2. Stand facing the machine and grab 
    the rope with both hands, palms 
    facing inward.
3. Step back slightly to create tension 
    in the cable, and keep your feet 
    shoulder-width apart.
4. Pull the rope towards your face, 
    keeping your elbows high and 
    flared out to the sides.
5. Squeeze your shoulder blades together 
    at the peak of the movement.
6. Slowly return the rope to the
    starting position, maintaining 
    control.
7. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Face Pull (Cable)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit on the floor with your legs 
    extended straight in front of you, 
    keeping your back straight and core 
    tight.
2. Grip the barbell with your hands 
    slightly wider than shoulder-width 
    apart.
3. Clean the barbell to shoulder height, 
    resting it on your deltoids.
4. Press the barbell overhead while 
    keeping your core engaged and your 
    back straight.
5. Fully extend your arms at the top, 
    squeezing your shoulders.
6. Lower the barbell back down to shoulder
    height in a controlled manner.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Z-Press (Barbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand facing a cable machine with the 
    pulley set at the lowest position.
2. Attach a handle to the pulley and grip 
    it with one hand, keeping your palm 
    facing inward.
3. Take a step back to create tension in 
    the cable and stand with your feet 
    shoulder-width apart.
4. With a slight bend in your elbow, raise 
    your arm straight in front of you to 
    shoulder height.
5. Pause for a second at the top, 
    squeezing your shoulder muscles.
6. Slowly lower your arm back to the 
    starting position, controlling the 
    cable.
7. Repeat for the desired number of 
    repetitions, then switch arms.'
WHERE ExerciseName = 'Cable Front Raise';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and position one end of a
    barbell in a landmine attachment or 
    corner.
2. Grip the other end of the barbell with
    both hands, keeping your elbows bent 
    and close to your body.
3. Press the barbell upward in a diagonal 
    motion, extending your arms fully 
    overhead.
4. Pause for a second at the top, 
    squeezing your shoulders.
5. Slowly lower the barbell back down, 
    controlling the movement.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Landmine Press';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, holding a dumbbell in one hand 
    at shoulder height.
2. Keep your core tight and your back 
    straight.
3. Press the dumbbell overhead, fully 
    extending your arm while keeping your
    elbow slightly bent at the top.
4. Pause for a second at the top, 
    squeezing your shoulder.
5. Slowly lower the dumbbell back to 
    shoulder height in a controlled
    motion.
6. Repeat for the desired number of
    repetitions, then switch arms.'
WHERE ExerciseName = 'One-Arm Overhead Press (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and place the center of the 
    resistance band under your feet.
2. Hold the ends of the band in each hand, 
    with your elbows bent at a 90-degree 
    angle and palms facing forward at 
    shoulder height.
3. Press the band upward, fully extending 
    your arms overhead.
4. Pause for a second at the top, squeezing 
    your shoulders.
5. Slowly lower your arms back to the 
    starting position in a controlled 
    motion.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Resistance Band Shoulder Press';


-- Biceps

UPDATE dbo.Exercises 
SET Instructions = N'
1. Set the pulley of a cable machine 
    to the lowest position and attach 
    a straight bar or rope handle.
2. Stand facing the machine with your 
    feet shoulder-width apart, and grab 
    the handle with both hands, 
    palms facing up.
3. Keep your elbows close to your torso
    and your core tight.
4. Curl the handle towards your chest by
    bending your elbows, contracting 
    your biceps.
5. Pause for a second at the top of the 
    movement, squeezing your biceps.
6. Slowly lower the handle back to the 
    starting position, feeling a 
    stretch in your biceps.
7. Repeat for the desired number of 
repetitions.'
WHERE ExerciseName = 'Cable Curl';


UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width
    apart, holding an EZ bar with an 
    underhand grip (palms facing up).
2. Keep your elbows close to your torso
    and your core tight.
3. Curl the bar upwards by bending your 
    elbows, focusing on contracting 
    your biceps.
4. Pause for a second at the top of the
    movement, squeezing your biceps.
5. Slowly lower the bar back to the 
    starting position, keeping tension 
    in your biceps.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'EZ Bar Curl';


UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on an incline bench with a 
    dumbbell in each hand, arms fully 
    extended and palms facing forward.
2. Keep your elbows close to your body 
    and your chest against the bench.
3. Curl the dumbbells upward, bending your
    elbows and squeezing your biceps at 
    the top.
4. Pause for a second at the top of the
    movement.
5. Slowly lower the dumbbells back to the 
    starting position, fully extending 
    your arms.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Incline Dumbbell Curl';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Attach a rope handle to the low pulley 
    of a cable machine.
2. Stand with your feet shoulder-width 
    apart, holding the rope with both 
    hands, palms facing each other.
3. Keep your elbows close to your body and
    your chest up.
4. Curl the rope upward, bending your 
    elbows and keeping your palms facing 
    each other throughout the movement.
5. Squeeze your forearms and biceps at the 
    top of the curl.
6. Slowly lower the rope back to the 
    starting position, fully extending
    your arms.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Cable Hammer Curl with Rope';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set an incline bench to a 45-degree
    angle and position yourself face down
    on the bench, with your chest against 
    the pad.
2. Hold a dumbbell in each hand with your 
    palms facing upward, letting your arms 
    hang straight down.
3. Keep your elbows stationary and curl 
    the dumbbells towards your shoulders,
    focusing on squeezing your biceps at 
    the top.
4. Pause for a second at the peak of the 
    movement.
5. Slowly lower the dumbbells back to the 
    starting position, fully extending 
    your arms.
6. Repeat for the desired number of 
repetitions.'
WHERE ExerciseName = 'Spider Curl';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with a dumbbell in each hand, 
    arms fully extended and palms facing 
    forward.
2. Curl the dumbbells up towards your
    shoulders while keeping your elbows 
    close to your body.
3. At the top of the curl, rotate your 
    wrists so your palms are facing 
    downward.
4. Slowly lower the dumbbells in a 
    controlled motion, focusing on the 
    eccentric phase.
5. At the bottom, rotate your wrists back 
    so your palms are facing upward.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Zottman Curl';


UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, holding an EZ bar with an 
    overhand grip (palms facing down).
2. Keep your elbows close to your body and
    your arms fully extended.
3. Curl the EZ bar upward by bending your 
    elbows, focusing on keeping your 
    wrists straight.
4. Squeeze your forearms and biceps at the
    top of the movement.
5. Slowly lower the bar back to the 
    starting position, fully extending 
    your arms.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Reverse Curl (EZ Bar)';


-- Triceps
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on a bench and grip the barbell 
    with your hands placed closer than 
    shoulder-width apart.
2. Keep your feet flat on the floor and 
    your back firmly pressed against 
    the bench.
3. Lower the barbell to your chest while 
    keeping your elbows close to your
    body.
4. Push the barbell back up to the 
    starting position, fully extending 
    your arms.
5. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Close Grip Bench Press (Barbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Hold a dumbbell in each hand and bend 
    forward slightly at the waist, 
    keeping your back straight.
2. Keep your elbows close to your body 
    and bend them at about a 90-degree 
    angle.
3. Extend your arms straight behind you 
    by straightening your elbows, 
    focusing on contracting your triceps.
4. Pause for a second at the top, 
    squeezing your triceps.
5. Slowly lower the dumbbells back to 
    the starting position, maintaining 
    control.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Kickbacks (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Attach a rope handle to the high pulley
    on a cable machine.
2. Stand facing away from the machine and
    grab the rope with both hands, palms 
    facing each other.
3. Step forward slightly to create tension
    in the cable and raise your arms 
    overhead, elbows bent.
4. Keep your upper arms stationary and 
    extend your forearms, pushing the rope 
    upward until your arms are fully 
    extended.
5. Squeeze your triceps at the top of the 
    movement.
6. Slowly lower the rope back to the 
    starting position, keeping your elbows
    close to your head.
7. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Overhead Cable Triceps Extension';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Start in a standard push-up position 
    with your hands placed closer together, 
    directly under your shoulders.
2. Keep your body in a straight line from 
    head to heels, engaging your core.
3. Lower your body towards the floor by 
    bending your elbows, keeping them 
    close to your sides.
4. Stop when your chest is just above 
    the ground.
5 .Push yourself back up to the starting 
    position, fully extending your arms.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Close Grip Push-Up';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Attach a rope or bar handle to the 
    high pulley of a cable machine.
2. Grab the handle with an underhand grip 
    (palms facing up), hands 
    shoulder-width apart.
3. Stand with your feet shoulder-width 
    apart and pull the handle down to
    your upper chest to create tension 
    in the cable.
4. Keep your elbows close to your sides 
    and press the handle downward by 
    extending your forearms.
5. Squeeze your triceps at the bottom of 
    the movement.
6. Slowly return the handle back to the 
    starting position, keeping tension on 
    the cable.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Reverse Grip Triceps Pushdown';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Grab a dumbbell with one hand and place
    the opposite knee and hand on a bench
    for support.
2. Keep your back flat and your core 
    engaged.
3. Hold the dumbbell with your upper arm 
    parallel to the floor and your elbow 
    bent at 90 degrees.
4. Extend your arm backward, straightening 
    your elbow and squeezing your triceps 
    at the top.
5. Slowly return to the starting position 
    with control.
6. Repeat for the desired number of 
    repetitions, then switch arms.'
WHERE ExerciseName = 'Single Arm Triceps Kickback';


-- Core

UPDATE dbo.Exercises
SET Instructions = N'
1. Hang from a pull-up bar with your 
    hands shoulder-width apart and your
    arms fully extended.
2. Keep your legs straight and your 
    core tight.
3. Lift your legs towards your chest 
    by flexing your hips, avoiding 
    swinging.
4. Pause at the top for a second, 
    squeezing your abs.
5. Slowly lower your legs back to the 
    starting position, maintaining 
    control.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Hanging Leg Raise';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Kneel in front of a cable machine 
    with a rope attachment set at the 
    highest position.
2. Grab the rope with both hands, 
    holding it near your head with your 
    elbows bent.
3. Keep your core tight and your back 
    straight as you pull the rope down 
    towards your knees.
4. Crunch forward, bringing your elbows 
    down toward your thighs while 
    contracting your abs.
5. Pause for a second at the bottom, 
    squeezing your core.
6. Slowly return to the starting position, 
    controlling the movement.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Cable Crunch';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Start in a high plank position with 
    your hands directly under your 
    shoulders and your body in a 
    straight line.
2. Engage your core and keep your back 
    flat.
3. Bring one knee towards your chest 
    while keeping the other leg 
    extended.
4. Quickly switch legs, extending the 
    first leg back while bringing the 
    other knee forward.
5. Continue alternating legs in a fast, 
    controlled motion.
6. Repeat for the desired number of 
    repetitions or time.'
WHERE ExerciseName = 'Mountain Climbers';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Lie on your side with your legs 
    extended and feet stacked on top 
    of each other.
2. Prop yourself up on your elbow, 
    keeping it directly under your 
    shoulder.
3. Lift your hips off the ground, 
    forming a straight line from your 
    head to your feet.
4. Engage your core and hold the
    position, avoiding any sagging 
    in your hips.
5. Keep your neck neutral and your 
    body aligned.
6. Hold for the desired amount of time, 
    then slowly lower your hips back 
    to the ground.
7. Repeat on the other side.'
WHERE ExerciseName = 'Side Plank';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Lie on your back with your arms 
    extended above your head and 
    legs straight.
2. Lift your legs and upper body off 
    the ground simultaneously, reaching 
    for your toes with your hands.
3. Keep your legs straight as you 
    crunch your body into a "V" shape.
4. Pause for a second at the top, 
    squeezing your abs.
5. Slowly lower your legs and upper 
    body back to the starting position, 
    maintaining control.
6. Repeat for the desired number of 
repetitions.'
WHERE ExerciseName = 'V-ups';


UPDATE dbo.Exercises
SET Instructions = N'
1. Lie flat on your back with your legs 
    extended straight up toward the 
    ceiling.
2. Keep your arms extended straight up 
    toward your toes.
3. Engage your core and lift your upper 
    back off the floor, reaching your hands 
    toward your toes.
4. Pause briefly at the top and squeeze 
    your abs.
5. Slowly lower your upper back to the 
    floor with control.
6. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Toe Touches';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Lie flat on your back with your legs 
    extended and arms at your sides or 
    under your glutes for support.
2. Lift both legs a few inches off the 
    floor.
3. Keeping your core tight, alternate 
    kicking your legs up and down in a
    quick, fluttering motion.
4. Keep your legs straight and avoid 
    touching the floor.
5. Continue for the desired time or number
    of repetitions.'
WHERE ExerciseName = 'Flutter Kicks';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Lie on your back with knees bent and 
    feet flat on the floor.
2. Hold a weight plate or dumbbell against 
    your chest or extended above you.
3. Tighten your core and slowly sit up, 
    lifting your upper body toward your 
    knees.
4. Pause briefly at the top.
5. Lower yourself back down with control.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Sit-Up';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Lie flat on your back with your arms 
    extended overhead and legs straight.
2. Engage your core by pressing your
    lower back into the floor.
3. Lift your shoulders, arms, and legs
    slightly off the ground to form a
    shallow "banana" shape.
4. Keep your arms close to your ears and
    legs together with toes pointed.
5. Hold this position, maintaining tension
    in your core throughout.
6. Breathe steadily and hold for the
    desired duration.'
WHERE ExerciseName = 'Hollow Body Hold';


-- Olympic

UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, with the barbell in front 
    of your shins.
2. Grip the barbell with your hands 
    slightly outside your knees, 
    keeping your back straight and 
    core tight.
3. Lift the barbell by pushing through 
    your heels, extending your hips and 
    knees, and pulling the bar up along
    your body.
4. When the bar reaches chest height, 
    quickly drop under it, catching it 
    on your shoulders in a squat
    position.
5. Stand up from the squat, bringing 
    the barbell to chest height.
6. Press the bar overhead by extending 
    your arms, locking out your elbows 
    at the top.
7. Slowly lower the bar back to the 
    starting position.
8. Repeat for the desired number of 
repetitions.'
WHERE ExerciseName = 'Clean and Jerk';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, with the barbell positioned
    over your mid-foot.
2. Grip the barbell with your hands 
    wider than shoulder-width apart, 
    palms facing down.
3. Bend at your hips and knees, keeping 
    your back flat and core tight, with 
    your chest up.
4. Lift the bar by extending your hips 
    and knees, pulling the bar upward 
    along your body.
5. As the bar passes your knees, 
    explosively shrug your shoulders 
    and pull yourself under the bar.
6. Drop into a deep squat while 
    catching the bar overhead with 
    your arms fully extended.
7. Stand up from the squat, keeping 
    the barbell locked overhead with 
    your arms fully extended.
8. Slowly lower the bar back to the 
    starting position.
9. Repeat for the desired number of
repetitions.'
WHERE ExerciseName = 'Snatch';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, with the barbell over your
    mid-foot.
2. Grip the barbell with your hands 
    slightly wider than shoulder-width 
    apart, keeping your back flat and 
    chest up.
3. Lower your hips and bend at the 
    knees while keeping your arms 
    straight.
4. Lift the barbell by pushing through 
    your heels, extending your hips 
    and knees at the same time.
5. When the bar reaches about chest 
    height, explosively shrug your
    shoulders and pull yourself under 
    the bar.
6. Drop into a quarter squat, catching 
    the barbell on your shoulders with 
    your elbows high.
7. Stand up fully with the bar resting
    on your shoulders.
8. Slowly lower the bar back to the 
    starting position.
9. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Power Clean';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, holding the barbell at 
    shoulder level with your palms 
    facing forward.
2. Keep your core tight and your chest 
    up, with your elbows slightly in 
    front of the bar.
3. Bend your knees slightly, then
    explosively extend your legs to 
    help drive the barbell upward.
4. As the bar is moving up, press it 
    overhead by fully extending your
    arms.
5. Pause briefly at the top with your
    arms fully extended and the barbell 
    locked out overhead.
6. Lower the barbell back to your 
    shoulders in a controlled motion.
7. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Push Press';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, with the barbell hanging 
    in front of your thighs.
2. Grip the bar with your hands 
    slightly wider than shoulder-width
    apart, keeping your back straight 
    and core tight.
3. Slightly bend your knees and push 
    your hips back, lowering the bar 
    to just above your knees while 
    keeping your chest up.
4. Explosively extend your hips and 
    knees, shrugging your shoulders 
    and pulling the bar upward.
5. As the bar reaches chest height, 
    quickly drop under the bar and 
    catch it on your shoulders in a 
    squat position.
6. Stand up from the squat, keeping 
    the barbell resting on your 
    shoulders.
7. Slowly lower the bar back to the 
    starting position.
8. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Hang Clean';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width
    apart and hold the barbell in front 
    of your thighs with a wide grip.
2. Keep your back straight, chest up, 
    and core tight.
3. Bend your knees slightly and push 
    your hips back to lower the bar just 
    above your knees.
4. Explosively extend your hips and 
    knees while pulling the bar upward 
    in a straight path.
5. As the bar rises, shrug your shoulders
    and pull yourself under the bar.
6. Catch the bar overhead with your arms 
    fully extended while dropping into
    a squat.
7. Stand up fully with the bar overhead.
8. Lower the bar slowly back to the 
    starting position.
9. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Hang Snatch';


UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width
    apart and hold the barbell at
    shoulder level with your palms 
    facing forward.
2. Keep your core tight and chest up, 
    with your elbows slightly in front 
    of the bar.
3. Dip slightly by bending your knees, 
    keeping your torso upright.
4. Explosively extend your legs and 
    drive the bar upward.
5. As the bar rises, quickly split your 
    legs—one foot moves forward and the 
    other moves back—to drop under the 
    bar.
6. Catch the bar overhead with your arms 
    fully extended and your body in a
    stable split stance.
7. Hold briefly, then bring your front 
    foot back, followed by your back foot
    to return to a standing position.
8. Lower the bar back to your shoulders 
    carefully.
9. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Split Jerk';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width
    apart and grip the barbell with a
    wide grip.
2. Keep your chest up, back straight,
    and core tight.
3. Start by lifting the bar smoothly 
    from the floor, keeping it close 
    to your body.
4. As the bar passes your knees, 
    explosively extend your hips and
    knees while pulling the bar upward.
5. Shrug your shoulders and pull 
    yourself under the bar slightly.
6. Catch the bar overhead with your arms 
    fully extended and your feet flat.
7. Stand up fully with the bar overhead 
    to complete the rep.
8. Lower the bar carefully back to the
    ground.
9. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Power Snatch';


UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold the barbell with an 
    overhand grip in front of your 
    thighs.
2. Keep your chest up, back straight,
    and core tight.
3. Begin by bending your knees slightly 
    and pushing your hips back.
4. Explosively extend your hips and 
    knees while pulling the bar straight
    up toward your chest.
5. Lead the movement with your elbows, 
    keeping them higher than your wrists.
6. Pull the bar to chest or upper-ab 
    level, pausing briefly at the top.
7. Lower the bar back down in a 
    controlled motion to the starting
    position.
8. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'High Pull (Barbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold the barbell with an 
    overhand grip, hands just outside 
    your thighs.
2. Keep your chest up, back straight,
    and core tight.
3. Start by lifting the bar smoothly 
    from the floor, keeping it close to 
    your body.
4. As the bar passes your knees, extend
    your hips and knees forcefully.
5. Pull the bar up by shrugging your 
    shoulders and bending your elbows
    high.
6. Without dropping under the bar, bring
    your elbows around and catch the bar
    on your shoulders.
7. Stand tall, then lower the bar back 
    to the starting position.
8. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Muscle Clean';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand on a small platform or weight 
    plate to create a slight deficit,
    feet hip-width apart.
2. Grip the barbell with a wide, snatch 
    grip and keep your back flat and 
    chest up.
3. Engage your core and pull the bar from 
    the floor with a strong and controlled
    motion.
4. Once the bar reaches mid-thigh, explode
    upward by extending your hips, knees, 
    and ankles.
5. Pull yourself under the bar and catch 
    it overhead in a deep squat position.
6. Stand up fully to complete the lift.
7. Lower the bar carefully back to the 
    floor and repeat for the desired 
    number of reps.'
WHERE ExerciseName = 'Deficit Snatch';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and grip the barbell with a 
    wide snatch grip.
2. Press or snatch the bar overhead and 
    lock out your elbows.
3 .Keep your chest up and core engaged 
    as you slowly lower into a deep squat.
4 .Make sure the bar stays in line with 
    the middle of your feet throughout 
    the movement.
5. Squat down as low as your mobility 
    allows while maintaining control.
6. Drive through your heels to return to 
    a standing position.
7 .Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Overhead Squat Snatch Grip';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Set the barbell on blocks or platforms
    so it rests just below or at the knee 
    level.
2. Stand with your feet shoulder-width 
    apart and grip the bar with either a 
    snatch or clean grip.
3. Keep your chest up, back flat, and core 
    tight.
4. Pull the bar straight up by driving 
    through your heels and extending your
    hips.
5. Keep the bar close to your body 
    throughout the lift.
6. Once you reach full extension at the 
    top, pause briefly.
7. Lower the bar back to the blocks in a 
    controlled manner.
8. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Block Pull (Snatch or Clean)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand tall with your feet shoulder-width
    apart, holding a barbell with a wide 
    snatch grip.
2. Begin with the bar at your chest or 
    upper abdominal level, elbows high and 
    to the sides.
3. Without dipping or using your legs, 
    explosively pull yourself under the 
    bar into a squat position.
4. Catch the bar overhead with arms fully 
    extended and torso upright.
5. Stand up to complete the lift.
6. Lower the bar and reset for the next 
    repetition.
7. Repeat for the desired number of
    repetitions.'
WHERE ExerciseName = 'Tall Snatch';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet hip-width apart, 
    barbell over midfoot, and grip it with 
    hands just outside your knees.
2. Keep your back flat, chest up, and arms 
    straight as you lift the bar from the 
    floor.
3. Drive through your legs to extend your 
    hips and knees simultaneously.
4. As the bar passes your knees, 
    explosively extend your hips and 
    ankles, shrugging your shoulders 
    upward.
5. Keep the bar close to your body during 
    the pull.
6. Lower the bar under control to the 
    ground.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Clean Pull';


-- Full body

UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold the barbell at 
    shoulder level with an overhand 
    grip.
2. Keep your elbows up, core tight, and 
    chest lifted.
3. Lower into a full squat, keeping your 
    heels flat and knees in line with 
    your toes.
4. Drive through your heels to stand up
    and push the bar overhead in one 
    smooth motion.
5. Fully extend your arms at the top, 
    locking out the bar.
6. Lower the bar back to your shoulders 
    and go into the next squat.
7. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Thruster (Barbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and your arms at your sides.
2. Drop into a squat and place your 
    hands on the floor in front of you.
3. Jump your feet back to land in a 
    plank position.
4. Do a push-up (optional for beginners).
5. Jump your feet back toward your hands 
    to return to the squat position.
6. Explosively jump into the air,
    reaching your arms overhead.
7. Land softly and immediately begin the 
    next repetition.'
WHERE ExerciseName = 'Burpee';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold a kettlebell with both
    hands in front of you.
2. Hinge at your hips and slightly bend 
    your knees to swing the kettlebell 
    between your legs.
3. Drive your hips forward to swing the 
    kettlebell up to chest height, 
    keeping your arms straight.
4. Let the kettlebell swing back down 
    between your legs as you hinge your 
    hips again.
5. Keep your back straight and core 
    tight throughout the movement.
6. Repeat the swing for the desired 
    number of repetitions.'
WHERE ExerciseName = 'Kettlebell Swing';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and a dumbbell on the floor 
    between your feet.
2. Squat down and grab the dumbbell with
    one hand, keeping your back straight
    and chest up.
3. Explosively stand up, pulling the 
    dumbbell upward in one motion.
4. As the dumbbell rises, rotate your 
    wrist and punch it overhead,
    locking your arm out.
5. Stand fully upright with the 
    dumbbell overhead.
6. Lower the dumbbell back to the floor 
    in a controlled motion.
7. Repeat for the desired reps, then 
    switch arms.'
WHERE ExerciseName = 'Dumbbell Snatch';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold a dumbbell in each
    hand at your sides.
2. Lower into a slight squat and use 
    your hips to explosively pull the 
    dumbbells up to shoulder height 
    (clean).
3. Rotate your wrists as you bring the 
    dumbbells to your shoulders, elbows 
    facing forward.
4. Press the dumbbells overhead until 
    your arms are fully extended.
5. Lower the dumbbells back to your 
    shoulders and then return them to 
    your sides.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Clean to Press (Dumbbell)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and hold a medicine ball at 
    chest level.
2. Lower into a squat, keeping your 
    chest up and knees behind your toes.
3. As you rise out of the squat,
    explosively throw the ball upward 
    towards a target (usually a wall 
    or a high mark).
4. Catch the ball as it comes back down,
    absorbing the impact by bending 
    your knees slightly.
5. Drop back into a squat and repeat the 
    motion, throwing the ball again.
6. Continue for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Wall Ball';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart, holding a dumbbell or barbell 
    in front of your thighs.
2. Hinge at your hips and lower the 
    weight toward the floor, keeping 
    your back straight and knees 
    slightly bent.
3. Drive through your heels to stand up 
    straight, bringing the weight back 
    to standing position.
4. Once standing, press the weight 
    overhead until your arms are fully
    extended.
5. Lower the weight back down to your 
    shoulders, then hinge at your hips 
    to lower the weight back to the
    floor.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Deadlift to Press';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and a barbell or dumbbell
    overhead, arms fully extended.
2. Keep your core tight and chest up, 
    with your gaze forward.
3. Push your hips back and lower into a 
    squat, keeping the weight overhead
    and your back straight.
4. Keep your knees in line with your 
    toes and squat as low as your 
    mobility allows, without your heels
    lifting off the ground.
5. Press through your heels to return to
    a standing position while maintaining
    the overhead position of the weight.
6. Repeat for the desired number of 
    repetitions.'
WHERE ExerciseName = 'Overhead Squat';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet shoulder-width 
    apart and your toes slightly pointed
    outward.
2. Lower your body into a squat position, 
    keeping your chest up and knees behind
    your toes.
3. Push through your heels to explosively
    jump up, reaching for the sky.
4. As you land, bend your knees and lower 
    your body back into the squat position
    to absorb the impact.
5. Repeat the jump and squat for the 
    desired number of repetitions.'
WHERE ExerciseName = 'Jump Squat';


-- Cardio
UPDATE dbo.Exercises 
SET Instructions = N'
1. Start by adjusting the treadmill to 
    a comfortable speed for your
    warm-up.
2. Stand on the treadmill belt with your 
    feet shoulder-width apart and hold 
    the handlebars for balance if 
    needed.
3. Begin walking or jogging at a pace
    that allows you to gradually 
    increase your heart rate.
4. Maintain an upright posture with your
    shoulders relaxed, and avoid leaning
    forward or back.
5. Keep your stride consistent and land 
    softly on your feet to minimize
    impact.
6. If you are running, gradually 
    increase your speed or incline as 
    desired for a more intense workout.
7. Keep your core tight and arms moving 
    naturally with each stride.
8. After your workout, gradually decrease
    your speed to cool down for
    5-10 minutes, then step off 
    carefully.'
WHERE ExerciseName = 'Running (Treadmill)';


UPDATE dbo.Exercises SET 
Instructions = N'
1. Adjust the seat height and handlebar
    position on the stationary bike to 
    ensure comfort and proper posture.
2. Start with your feet securely placed 
    in the pedals and begin pedaling at
    a comfortable pace.
3. Keep your back straight and core 
    engaged, avoiding slouching.
4. Maintain a steady pace, adjusting 
    the resistance to match your 
    fitness level.
5. Focus on smooth, consistent pedal 
    strokes, driving through your legs 
    and using your core for stability.
6. As you increase intensity, vary your 
    speed or resistance to challenge 
    your legs and cardiovascular system.
7. After your workout, gradually decrease 
    the resistance and pedal at a slower
    pace to cool down.
8. Step off the bike carefully once you 
    have completed your cool-down and
    are finished.'
WHERE ExerciseName = 'Cycling (Stationary)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Sit on the rowing machine with your 
    feet securely strapped into the
    footrests.
2. Hold the handle with both hands,
    keeping your arms extended straight
    in front of you.
3. Begin by bending your knees and 
    leaning slightly forward at the 
    hips to start the stroke.
4. Push through your legs to extend 
    your knees and pull the handle 
    toward your chest, keeping your 
    elbows close to your body.
5. As you finish the stroke, lean back 
    slightly, keeping your core engaged.
6. Reverse the motion by extending your 
    arms first, then bending your knees
    and leaning forward to return to 
    the starting position.
7. Maintain a steady, rhythmic pace, 
    focusing on smooth transitions 
    between strokes.
8. Gradually slow your pace toward the 
    end of your workout for a cool-down, 
    then step off the machine carefully.'
WHERE ExerciseName = 'Rowing (Machine)';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Hold the rope handles with your hands
    at hip height and position the rope 
    behind your feet.
2. Start by lightly jumping, swinging 
    the rope over your head and under 
    your feet with each jump.
3. Keep your elbows close to your body 
    and use your wrists to swing the 
    rope, rather than your arms.
4. Jump with both feet at the same time, 
    landing softly on the balls of 
    your feet.
5. Keep your core engaged and your body 
    upright throughout the exercise.
6. Focus on maintaining a steady rhythm,
    gradually increasing your speed as 
    you get comfortable.
7. Continue jumping for the desired 
    amount of time or repetitions, then 
    gradually slow down to cool off.'
WHERE ExerciseName = 'Jump Rope';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Step onto the stair climber machine 
    and adjust the settings to your
    preferred resistance and speed.
2. Stand upright with your feet on the
    pedals, holding the handlebars for 
    balance if needed.
3. Begin stepping by alternating legs, 
    simulating the motion of climbing 
    stairs.
4. Keep your core engaged, back straight,
    and avoid leaning forward.
5. Maintain a steady pace, focusing on 
    using your legs to push each step.
6. As you become comfortable, increase 
    the resistance or speed to challenge
    yourself.
7. After your workout, slow down 
    gradually to cool off before stepping 
    off the machine.'
WHERE ExerciseName = 'Stair Climber';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Step onto the elliptical machine and
    adjust the resistance and incline to
    your desired level.
2. Stand tall with your feet on the 
    pedals and your hands gripping the
    handlebars.
3. Begin pedaling by moving your legs in 
    a smooth, circular motion while
    pushing and pulling the handlebars.
4. Keep your back straight, core engaged, 
    and avoid leaning forward or 
    backward.
5. Maintain a steady pace, adjusting the 
    resistance or incline for a more 
    challenging workout.
6. Focus on using both your legs and arms 
    to move the machine, keeping your
    movements controlled.
7. After completing your workout, 
    gradually decrease the intensity to 
    cool down, then step off carefully.'
WHERE ExerciseName = 'Elliptical Trainer';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand behind the sled with your hands
    placed on the handles or the push
    bar.
2. Position your feet shoulder-width 
    apart and engage your core.
3. Lean slightly forward, keeping your
    back straight and your knees 
    slightly bent.
4. Push the sled forward using your 
    legs and arms, driving through 
    your heels and keeping your body 
    low.
5. Maintain a steady pace and focus on 
    pushing with full force, using your
    legs to generate power.
6. Push the sled for a set distance or 
    time, then stop and reset.
7. Repeat for the desired number of
    repetitions or sets.'
WHERE ExerciseName = 'Sled Push';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet together and 
    your hands by your sides.
2. Jump up, spreading your legs wide 
    while simultaneously raising your
    arms above your head.
3. Quickly reverse the motion by jumping
    again, bringing your feet back 
    together and lowering your arms to 
    your sides.
4. Continue jumping at a steady pace, 
    keeping your core engaged and your
    body upright.
5. Focus on maintaining a rhythm and 
    controlling your breathing 
    throughout the exercise.
6. Perform for the desired number of
    repetitions or time.'
WHERE ExerciseName = 'Jumping Jacks';


UPDATE dbo.Exercises 
SET Instructions = N'
1. Stand with your feet hip-width apart 
    and your arms bent at a 90-degree 
    angle.
2. Begin jogging in place by driving one
    knee up towards your chest as high 
    as possible.
3. Quickly lower that leg and raise the 
    opposite knee to chest height.
4. Continue alternating knees rapidly, 
    maintaining a steady pace.
5. Keep your core tight and your back 
    straight throughout the movement.
6. Engage your arms by pumping them in 
    rhythm with your legs.
7. Perform for the desired number of 
    repetitions or time.'
WHERE ExerciseName = 'High Knees';


-- Other 
UPDATE dbo.Exercises
SET Instructions = N'
1. Begin by standing or sitting in a 
    comfortable position.
2. Slowly stretch one muscle group at a
    time, holding the stretch gently 
    without bouncing.
3. Hold each stretch for 15-30 seconds,
    focusing on your breathing and
    relaxation.
4. Stretch major muscle groups such as 
    the hamstrings, quads, calves, back,
    chest, shoulders, and arms.
5. Ensure that you do not feel pain 
    while stretching; the stretch should
    be gentle and comfortable.
6. Repeat the stretches as needed for 
    improved flexibility and relaxation.'
WHERE ExerciseName = 'Stretching';










-- DISPLAYING DATA

SELECT * FROM dbo.Users;
GO


--SELECT * FROM dbo.Workouts;
--GO


SELECT * FROM dbo.WorkoutTemplates;
GO


SELECT * FROM dbo.WorkoutTemplateExercises;
GO


SELECT * FROM dbo.WorkoutTemplateExerciseSets;
GO


SELECT * FROM dbo.Exercises;
GO  


--SELECT * FROM dbo.Measurements;
--GO