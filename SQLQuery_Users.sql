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
('Bicep Curl (Barbell)', 'Arms'),
('Hammer Curl (Dumbbell)', 'Arms'),
('Preacher Curl (Machine)', 'Arms'),
('Concentration Curl (Dumbbell)', 'Arms'),

    -- Triceps
('Dips', 'Arms'),
('Skullcrusher (Barbell)', 'Arms'),
('Triceps Pushdown (Cable)', 'Arms'),
('Overhead Triceps Extension (Dumbbell)', 'Arms'),

    -- Core
('Plank', 'Core'),
('Crunches', 'Core'),
('Russian Twist', 'Core'),
('Flat Leg Raise', 'Core'),
('Bicycle Crunches', 'Core');
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
3. Unrack the barbell and position it above 
    your chest.
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
5. Push the bar back up until your arms are 
    fully extended.
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
    squeezing your shoulder blades together.
4. Pause briefly, then slowly return to the 
    starting position.
5. Avoid leaning back excessively; maintain 
    a controlled range of motion.'
WHERE ExerciseName = 'Seated Row (Cable)';

-- 9. Lat Pulldown (Cable)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit down at the lat pulldown machine and 
    adjust the thigh pads.
2. Grip the bar slightly wider than 
    shoulder-width with palms facing forward.
3. Pull the bar down toward your upper chest, 
    squeezing your shoulder blades together.
4. Pause at the bottom, then slowly release 
    the bar back to the starting position.
5. Avoid using momentum or leaning too far 
    backward.'
WHERE ExerciseName = 'Lat Pulldown (Cable)';

-- 10. Bent Over Row (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width apart, 
    holding a barbell with an overhand grip.
2. Bend your knees slightly and hinge 
    forward at the hips until your torso is 
    nearly parallel to the ground.
3. Let the bar hang at arm’s length, then 
    row it toward your lower chest.
4. Squeeze your shoulder blades together at 
    the top.
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
2. Release the safety handles and lower the 
    platform by bending your knees.
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
    your back against the pad and the ankle 
    pad above your feet.
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
1. Stand upright holding a dumbbell in each 
    hand at your sides.
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
1. Stand with your feet shoulder-width apart 
    and hold a barbell with an overhand grip 
    in front of your thighs.
2. Pull the bar straight up to your chest, 
    keeping it close to your body.
3. Lead with your elbows, which should remain 
    higher than your wrists.
4. Pause briefly at the top, then lower the 
    bar back to the starting position.
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
4. Avoid using momentum and keep your torso 
    stationary.'
WHERE ExerciseName = 'Front Raise (Dumbbell)';

-- 19. Reverse Fly (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Hold a dumbbell in each hand and bend 
    at the hips until your torso is nearly 
    parallel to the ground.
2. Let your arms hang down with a slight 
    bend in the elbows.
3. Raise the weights out to the sides, 
    squeezing your shoulder blades together 
    at the top.
4. Slowly lower the weights back to the 
    starting position.
5. Avoid swinging and keep the motion 
    controlled.'
WHERE ExerciseName = 'Reverse Fly (Dumbbell)';

-- 20. Dumbbell Shoulder Press
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on a bench with back support holding 
    a dumbbell in each hand at shoulder 
    height.
2. Rotate your wrists so your palms face 
    forward.
3. Press the dumbbells upward until your 
    arms are fully extended above your head.
4. Pause briefly, then slowly lower the 
    weights back to shoulder height.
5. Keep your back flat against the bench and 
    avoid arching excessively.'
WHERE ExerciseName = 'Dumbbell Shoulder Press';

-- 21. Lateral Raise (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand upright holding a dumbbell in each 
    hand at your sides.
2. With a slight bend in your elbows, raise 
    your arms out to the sides until they 
    are at shoulder height.
3. Pause briefly at the top, then lower the 
    dumbbells back down slowly.
4. Keep your torso stationary and avoid 
    using momentum.'
WHERE ExerciseName = 'Lateral Raise (Dumbbell)';

-- 22. Overhead Press (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width apart 
    holding a barbell at shoulder height.
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
1. Stand tall with your feet together and 
    the barbell resting on your upper chest.
2. Engage your core and press the bar 
    overhead without using your legs or 
    momentum.
3. Lock your arms out fully at the top, then 
    slowly lower the bar back to your chest.
4. Keep your glutes and abs tight to avoid 
    back arching.'
WHERE ExerciseName = 'Strict Military Press (Barbell)';

-- 24. Bicep Curl (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with your feet shoulder-width apart 
    holding a barbell with an underhand grip.
2. Keep your elbows close to your torso and 
    curl the bar up toward your chest.
3. Squeeze your biceps at the top, then lower 
    the bar slowly to the starting position.
4. Avoid swinging or using your back for 
    momentum.'
WHERE ExerciseName = 'Bicep Curl (Barbell)';

-- 25. Hammer Curl (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand with a dumbbell in each hand, palms 
    facing inward.
2. Keeping your elbows tight to your sides, 
    curl both dumbbells simultaneously.
3. Pause at the top, then slowly return to 
    the starting position.
4. Maintain controlled movement throughout 
    the exercise.'
WHERE ExerciseName = 'Hammer Curl (Dumbbell)';

-- 26. Preacher Curl (Machine)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit at the preacher bench and place your 
    arms over the angled pad, gripping the 
    handles or bar.
2. Curl the weight toward your shoulders, 
    keeping your upper arms pressed against 
    the pad.
3. Squeeze your biceps at the top, then 
    lower the weight slowly.
4. Focus on controlled movement and avoid 
    bouncing the weight.'
WHERE ExerciseName = 'Preacher Curl (Machine)';

-- 27. Concentration Curl (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on a bench and hold a dumbbell in one 
    hand with your elbow resting on the 
    inside of your thigh.
2. Curl the dumbbell up toward your shoulder 
    while keeping your upper arm stationary.
3. Squeeze at the top, then slowly lower the 
    dumbbell.
4. Repeat for the desired reps before 
    switching arms.'
WHERE ExerciseName = 'Concentration Curl (Dumbbell)';

-- 28. Dips
UPDATE dbo.Exercises
SET Instructions = N'
1. Grip parallel bars and lift your body so 
    your arms are fully extended.
2. Lower yourself slowly by bending your 
    elbows until your upper arms are parallel 
    to the ground.
3. Press back up to the starting position by 
    extending your arms.
4. Keep your body upright to emphasize triceps; 
    leaning forward targets the chest more.'
WHERE ExerciseName = 'Dips';

-- 29. Skullcrusher (Barbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on a bench holding a barbell with a 
    narrow grip directly above your chest.
2. Bend your elbows to lower the bar toward 
    your forehead.
3. Stop just before the bar touches your 
    forehead, then extend your arms to raise 
    the bar back up.
4. Keep your elbows stationary and pointed 
    forward throughout.'
WHERE ExerciseName = 'Skullcrusher (Barbell)';


-- 30. Triceps Pushdown (Cable)
UPDATE dbo.Exercises
SET Instructions = N'
1. Stand facing a cable machine with a 
    straight or angled bar attached to the 
    high pulley.
2. Grip the bar with palms facing down and 
    elbows tucked into your sides.
3. Push the bar down until your arms are 
    fully extended, squeezing your triceps.
4. Slowly return to the starting position, 
    resisting the pull.
5. Keep your elbows stationary throughout 
    the movement.'
WHERE ExerciseName = 'Triceps Pushdown (Cable)';

-- 31. Overhead Triceps Extension (Dumbbell)
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit or stand holding a dumbbell with both 
    hands above your head.
2. Keep your elbows close to your ears and 
    lower the dumbbell behind your head.
3. Extend your arms to lift the dumbbell 
    back to the starting position.
4. Avoid flaring your elbows or arching your 
    back.'
WHERE ExerciseName = 'Overhead Triceps Extension (Dumbbell)';

-- 32. Plank
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie face down and lift your body onto 
    your toes and forearms.
2. Keep your body in a straight line from 
    head to heels.
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
2. Lift your upper back off the ground by 
    contracting your abs.
3. Pause briefly at the top, then lower back
    down slowly.
4. Avoid pulling on your neck; keep your 
    chin slightly tucked.'
WHERE ExerciseName = 'Crunches';

-- 34. Russian Twist
UPDATE dbo.Exercises
SET Instructions = N'
1. Sit on the floor with knees bent and feet 
    lifted slightly off the ground.
2. Lean back slightly and hold a weight or 
    medicine ball in front of you.
3. Twist your torso to one side, then to the
    other, rotating from the waist.
4. Keep your core engaged and move in a 
    controlled manner.'
WHERE ExerciseName = 'Russian Twist';

-- 35. Flat Leg Raise
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie flat on your back with your hands 
    under your hips for support.
2. Keeping your legs straight, lift them up 
    until they form a 90-degree angle.
3. Slowly lower them back down without 
    letting your feet touch the ground.
4. Engage your core throughout the movement.'
WHERE ExerciseName = 'Flat Leg Raise';

-- 36. Bicycle Crunches
UPDATE dbo.Exercises
SET Instructions = N'
1. Lie on your back with your hands behind
    your head and legs lifted.
2. Bring one knee toward your chest while 
    twisting your opposite elbow toward it.
3. Alternate sides in a pedaling motion, 
    keeping your core tight.
4. Move slowly and deliberately for best 
    engagement.'
WHERE ExerciseName = 'Bicycle Crunches';












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