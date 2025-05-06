namespace TrainSMARTApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_Menus = new System.Windows.Forms.Panel();
            this.cuiButton_Menu_Measure = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Menu_Exercises = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Menu_Workout = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Menu_History = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Menu_Profile = new CuoreUI.Controls.cuiButton();
            this.panel_Form_Title = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.cuiGradientBorder_AboveMenu = new CuoreUI.Controls.cuiGradientBorder();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.panel_Measurement = new System.Windows.Forms.Panel();
            this.cuiDataGridView_Measurement_WeightHistory = new CuoreUI.Controls.cuiDataGridView();
            this.cuiButton_Measurement_AddHistory = new CuoreUI.Controls.cuiButton();
            this.textBox_Measurement_ChartName = new System.Windows.Forms.TextBox();
            this.label_Measurement_History = new System.Windows.Forms.Label();
            this.cuiChartLine_Measurement_Weight = new CuoreUI.Controls.Charts.cuiChartLine();
            this.cuiGradientBorder_Measurement_ChartLineBorder = new CuoreUI.Controls.cuiGradientBorder();
            this.cuiGradientBorder_Measurement = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_Measurement_Title = new System.Windows.Forms.Panel();
            this.cuiButton_Measure_GoBack = new CuoreUI.Controls.cuiButton();
            this.label_Measurement_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel_WorkoutCreation = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_WorkoutCreation_TemplateName = new System.Windows.Forms.Panel();
            this.cuiTextBox_WorkoutCreation_Note = new CuoreUI.Controls.cuiTextBox2();
            this.cuiButton_WorkoutCreation_EditName = new CuoreUI.Controls.cuiButton();
            this.cuiTextBox_WorkoutCreation_TemplateName = new CuoreUI.Controls.cuiTextBox2();
            this.cuiButton_WorkoutCreation_AddExercise = new CuoreUI.Controls.cuiButton();
            this.panel_WorkoutCreation_Title = new System.Windows.Forms.Panel();
            this.cuiButton_WorkoutCreation_Save = new CuoreUI.Controls.cuiButton();
            this.cuiButton_WorkoutCreation_Exit = new CuoreUI.Controls.cuiButton();
            this.label_WorkoutCreation = new System.Windows.Forms.Label();
            this.cuiGradientBorder_WorkoutCreation = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_WorkoutCreation = new System.Windows.Forms.Panel();
            this.panel_Menu_Profile = new System.Windows.Forms.Panel();
            this.cuiGradientBorder_Profile = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_Profile_Title = new System.Windows.Forms.Panel();
            this.cuiButton_Profile_Settings = new CuoreUI.Controls.cuiButton();
            this.label_Profile_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Profile = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Profile_User = new System.Windows.Forms.Panel();
            this.label_Profile_Dashboard = new System.Windows.Forms.Label();
            this.label_Profile_WorkoutCount = new System.Windows.Forms.Label();
            this.label_Profile_Username = new System.Windows.Forms.Label();
            this.cuiPictureBox_Profile_User = new CuoreUI.Controls.cuiPictureBox();
            this.panel_Profile_WorkoutCount = new System.Windows.Forms.Panel();
            this.chart_Profile_WorkoutCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Menu_History = new System.Windows.Forms.Panel();
            this.cuiGradientBorder_History = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_History_Title = new System.Windows.Forms.Panel();
            this.cuiButton_History_Calendar = new CuoreUI.Controls.cuiButton();
            this.label_History_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_History = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Menu_Exercises = new System.Windows.Forms.Panel();
            this.cuiBorder_Exercises_Filter = new CuoreUI.Controls.cuiBorder();
            this.cuiGradientBorder2 = new CuoreUI.Controls.cuiGradientBorder();
            this.cuiCheckbox_Filter_Other = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Cardio = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Core = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Legs = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_FullBody = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Arms = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Back = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Olympic = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Shoulders = new CuoreUI.Controls.cuiCheckbox();
            this.cuiCheckbox_Filter_Chest = new CuoreUI.Controls.cuiCheckbox();
            this.cuiGradientBorder_Exercises = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_Exercises_Title = new System.Windows.Forms.Panel();
            this.label_Exercises_Count = new System.Windows.Forms.Label();
            this.panel_Exercises_Search = new System.Windows.Forms.Panel();
            this.cuiTextBox_Exercises_Search = new CuoreUI.Controls.cuiTextBox2();
            this.cuiButton_Exercises_GoBack = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Exercises_Search = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Exercises_Filter = new CuoreUI.Controls.cuiButton();
            this.label_Exercises_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Exercises = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Menu_Workout = new System.Windows.Forms.Panel();
            this.cuiGradientBorder_Workout = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_Workout_Title = new System.Windows.Forms.Panel();
            this.label_Workout_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Workout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Workout_QuickStart = new System.Windows.Forms.Panel();
            this.cuiButton_Workout_AddTemplate = new CuoreUI.Controls.cuiButton();
            this.label_Workout_MyTemplates = new System.Windows.Forms.Label();
            this.cuiButton_Workout_QuickStart = new CuoreUI.Controls.cuiButton();
            this.label_Workout_QuickStart = new System.Windows.Forms.Label();
            this.label_Workout_EmptyTemplateMsg = new System.Windows.Forms.Label();
            this.label_Workout_SampleTemplates = new System.Windows.Forms.Label();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton5 = new CuoreUI.Controls.cuiButton();
            this.panel_Menu_Measure = new System.Windows.Forms.Panel();
            this.cuiGradientBorder_Measure = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_Measure_Title = new System.Windows.Forms.Panel();
            this.label_Measure_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Measure = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Measurement_Core = new System.Windows.Forms.Label();
            this.cuiButton_Measure_Weight = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_BodyFatPercentage = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_CaloricIntake = new CuoreUI.Controls.cuiButton();
            this.label_Measurement_BodyPart = new System.Windows.Forms.Label();
            this.cuiButton_Measure_Neck = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_Shoulders = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_Chest = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_LeftBicep = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_RightBicep = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_LeftForearm = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_RightForearm = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_UpperAbs = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_Waist = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_LowerAbs = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_Hips = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_LeftThigh = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_RightThigh = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_LeftCalf = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Measure_RightCalf = new CuoreUI.Controls.cuiButton();
            this.panel_ExerciseDetails = new System.Windows.Forms.Panel();
            this.cuiGradientBorder_ExerciseDetails = new CuoreUI.Controls.cuiGradientBorder();
            this.panel_ExerciseDetails_Buttons = new System.Windows.Forms.Panel();
            this.cuiBorder_ExerciseDetail_Records = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder_ExerciseDetail_Charts = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder_ExerciseDetail_History = new CuoreUI.Controls.cuiBorder();
            this.cuiBorder_ExerciseDetail_About = new CuoreUI.Controls.cuiBorder();
            this.cuiButton_ExerciseDetails_Records = new CuoreUI.Controls.cuiButton();
            this.cuiButton_ExerciseDetails_Charts = new CuoreUI.Controls.cuiButton();
            this.cuiButton_ExerciseDetails_History = new CuoreUI.Controls.cuiButton();
            this.cuiButton_ExerciseDetails_About = new CuoreUI.Controls.cuiButton();
            this.panel_ExerciseDetails_Name = new System.Windows.Forms.Panel();
            this.cuiButton_ExerciseDetails_GoBack = new CuoreUI.Controls.cuiButton();
            this.label_ExerciseDetails_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ExerciseDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ExerciseDetails_Instruction = new System.Windows.Forms.Label();
            this.textBox_ExerciseDetails_Instructions = new System.Windows.Forms.TextBox();
            this.cuiButton_AddExercises_Exit = new CuoreUI.Controls.cuiButton();
            this.label_AddExercises_Count = new System.Windows.Forms.Label();
            this.label_AddExercises_Title = new System.Windows.Forms.Label();
            this.panel_Menus.SuspendLayout();
            this.panel_Form_Title.SuspendLayout();
            this.panel_Measurement.SuspendLayout();
            this.panel_Measurement_Title.SuspendLayout();
            this.flowLayoutPanel_WorkoutCreation.SuspendLayout();
            this.panel_WorkoutCreation_TemplateName.SuspendLayout();
            this.panel_WorkoutCreation_Title.SuspendLayout();
            this.panel_WorkoutCreation.SuspendLayout();
            this.panel_Menu_Profile.SuspendLayout();
            this.panel_Profile_Title.SuspendLayout();
            this.flowLayoutPanel_Profile.SuspendLayout();
            this.panel_Profile_User.SuspendLayout();
            this.panel_Profile_WorkoutCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Profile_WorkoutCount)).BeginInit();
            this.panel_Menu_History.SuspendLayout();
            this.panel_History_Title.SuspendLayout();
            this.panel_Menu_Exercises.SuspendLayout();
            this.cuiBorder_Exercises_Filter.SuspendLayout();
            this.panel_Exercises_Title.SuspendLayout();
            this.panel_Exercises_Search.SuspendLayout();
            this.panel_Menu_Workout.SuspendLayout();
            this.panel_Workout_Title.SuspendLayout();
            this.flowLayoutPanel_Workout.SuspendLayout();
            this.panel_Workout_QuickStart.SuspendLayout();
            this.panel_Menu_Measure.SuspendLayout();
            this.panel_Measure_Title.SuspendLayout();
            this.flowLayoutPanel_Measure.SuspendLayout();
            this.panel_ExerciseDetails.SuspendLayout();
            this.panel_ExerciseDetails_Buttons.SuspendLayout();
            this.panel_ExerciseDetails_Name.SuspendLayout();
            this.flowLayoutPanel_ExerciseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menus
            // 
            this.panel_Menus.Controls.Add(this.cuiButton_Menu_Measure);
            this.panel_Menus.Controls.Add(this.cuiButton_Menu_Exercises);
            this.panel_Menus.Controls.Add(this.cuiButton_Menu_Workout);
            this.panel_Menus.Controls.Add(this.cuiButton_Menu_History);
            this.panel_Menus.Controls.Add(this.cuiButton_Menu_Profile);
            this.panel_Menus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menus.Location = new System.Drawing.Point(0, 706);
            this.panel_Menus.Name = "panel_Menus";
            this.panel_Menus.Size = new System.Drawing.Size(513, 82);
            this.panel_Menus.TabIndex = 0;
            // 
            // cuiButton_Menu_Measure
            // 
            this.cuiButton_Menu_Measure.CheckButton = false;
            this.cuiButton_Menu_Measure.Checked = false;
            this.cuiButton_Menu_Measure.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Measure.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Measure.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Measure.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Measure.Content = "Measure";
            this.cuiButton_Menu_Measure.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Menu_Measure.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Menu_Measure.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Menu_Measure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Measure.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Measure.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Menu_Measure.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Menu_Measure.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Measure.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Menu_Measure.Image")));
            this.cuiButton_Menu_Measure.ImageAutoCenter = false;
            this.cuiButton_Menu_Measure.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Menu_Measure.ImageOffset = new System.Drawing.Point(28, -8);
            this.cuiButton_Menu_Measure.Location = new System.Drawing.Point(409, 0);
            this.cuiButton_Menu_Measure.Name = "cuiButton_Menu_Measure";
            this.cuiButton_Menu_Measure.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Menu_Measure.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Measure.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Measure.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Measure.OutlineThickness = 0F;
            this.cuiButton_Menu_Measure.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Measure.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Measure.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Measure.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Measure.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Menu_Measure.Size = new System.Drawing.Size(102, 82);
            this.cuiButton_Menu_Measure.TabIndex = 8;
            this.cuiButton_Menu_Measure.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Menu_Measure.Click += new System.EventHandler(this.cuiButton_Menu_Measure_Click);
            // 
            // cuiButton_Menu_Exercises
            // 
            this.cuiButton_Menu_Exercises.CheckButton = false;
            this.cuiButton_Menu_Exercises.Checked = false;
            this.cuiButton_Menu_Exercises.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Exercises.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Exercises.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Exercises.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Exercises.Content = "Exercises";
            this.cuiButton_Menu_Exercises.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Menu_Exercises.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Menu_Exercises.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Menu_Exercises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Exercises.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Exercises.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Menu_Exercises.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Menu_Exercises.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Exercises.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Menu_Exercises.Image")));
            this.cuiButton_Menu_Exercises.ImageAutoCenter = false;
            this.cuiButton_Menu_Exercises.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Menu_Exercises.ImageOffset = new System.Drawing.Point(28, -8);
            this.cuiButton_Menu_Exercises.Location = new System.Drawing.Point(307, 0);
            this.cuiButton_Menu_Exercises.Name = "cuiButton_Menu_Exercises";
            this.cuiButton_Menu_Exercises.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Menu_Exercises.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Exercises.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Exercises.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Exercises.OutlineThickness = 0F;
            this.cuiButton_Menu_Exercises.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Exercises.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Exercises.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Exercises.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Exercises.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Menu_Exercises.Size = new System.Drawing.Size(102, 82);
            this.cuiButton_Menu_Exercises.TabIndex = 7;
            this.cuiButton_Menu_Exercises.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Menu_Exercises.Click += new System.EventHandler(this.cuiButton_Menu_Exercises_Click);
            // 
            // cuiButton_Menu_Workout
            // 
            this.cuiButton_Menu_Workout.CheckButton = false;
            this.cuiButton_Menu_Workout.Checked = false;
            this.cuiButton_Menu_Workout.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Workout.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Workout.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Workout.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Workout.Content = "Workout";
            this.cuiButton_Menu_Workout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Menu_Workout.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Menu_Workout.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Menu_Workout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Workout.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Workout.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Menu_Workout.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Menu_Workout.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Workout.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Menu_Workout.Image")));
            this.cuiButton_Menu_Workout.ImageAutoCenter = false;
            this.cuiButton_Menu_Workout.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Menu_Workout.ImageOffset = new System.Drawing.Point(28, -8);
            this.cuiButton_Menu_Workout.Location = new System.Drawing.Point(204, 0);
            this.cuiButton_Menu_Workout.Name = "cuiButton_Menu_Workout";
            this.cuiButton_Menu_Workout.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Menu_Workout.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Workout.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Workout.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Workout.OutlineThickness = 0F;
            this.cuiButton_Menu_Workout.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Workout.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Workout.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Workout.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Workout.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Menu_Workout.Size = new System.Drawing.Size(103, 82);
            this.cuiButton_Menu_Workout.TabIndex = 6;
            this.cuiButton_Menu_Workout.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Menu_Workout.Click += new System.EventHandler(this.cuiButton_Menu_Workout_Click);
            // 
            // cuiButton_Menu_History
            // 
            this.cuiButton_Menu_History.CheckButton = false;
            this.cuiButton_Menu_History.Checked = false;
            this.cuiButton_Menu_History.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_History.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_History.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_History.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_History.Content = "History";
            this.cuiButton_Menu_History.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Menu_History.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Menu_History.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Menu_History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_History.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_History.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Menu_History.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Menu_History.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_History.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Menu_History.Image")));
            this.cuiButton_Menu_History.ImageAutoCenter = false;
            this.cuiButton_Menu_History.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Menu_History.ImageOffset = new System.Drawing.Point(28, -8);
            this.cuiButton_Menu_History.Location = new System.Drawing.Point(102, 0);
            this.cuiButton_Menu_History.Name = "cuiButton_Menu_History";
            this.cuiButton_Menu_History.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Menu_History.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_History.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_History.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_History.OutlineThickness = 0F;
            this.cuiButton_Menu_History.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_History.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_History.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_History.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_History.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Menu_History.Size = new System.Drawing.Size(102, 82);
            this.cuiButton_Menu_History.TabIndex = 5;
            this.cuiButton_Menu_History.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Menu_History.Click += new System.EventHandler(this.cuiButton_Menu_History_Click);
            // 
            // cuiButton_Menu_Profile
            // 
            this.cuiButton_Menu_Profile.CheckButton = false;
            this.cuiButton_Menu_Profile.Checked = false;
            this.cuiButton_Menu_Profile.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Profile.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Profile.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Profile.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Profile.Content = "Profile";
            this.cuiButton_Menu_Profile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Menu_Profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Menu_Profile.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Menu_Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Profile.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Profile.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Menu_Profile.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Menu_Profile.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Profile.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Menu_Profile.Image")));
            this.cuiButton_Menu_Profile.ImageAutoCenter = false;
            this.cuiButton_Menu_Profile.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Menu_Profile.ImageOffset = new System.Drawing.Point(28, -8);
            this.cuiButton_Menu_Profile.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_Menu_Profile.Name = "cuiButton_Menu_Profile";
            this.cuiButton_Menu_Profile.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Menu_Profile.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Profile.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.cuiButton_Menu_Profile.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Profile.OutlineThickness = 0F;
            this.cuiButton_Menu_Profile.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Menu_Profile.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Profile.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Menu_Profile.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Menu_Profile.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Menu_Profile.Size = new System.Drawing.Size(102, 82);
            this.cuiButton_Menu_Profile.TabIndex = 4;
            this.cuiButton_Menu_Profile.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Menu_Profile.Click += new System.EventHandler(this.cuiButton_Menu_Profile_Click);
            // 
            // panel_Form_Title
            // 
            this.panel_Form_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panel_Form_Title.Controls.Add(this.button_Exit);
            this.panel_Form_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Form_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Title.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Form_Title.Name = "panel_Form_Title";
            this.panel_Form_Title.Size = new System.Drawing.Size(513, 35);
            this.panel_Form_Title.TabIndex = 3;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(470, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(43, 35);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.TabStop = false;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // cuiGradientBorder_AboveMenu
            // 
            this.cuiGradientBorder_AboveMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiGradientBorder_AboveMenu.GradientAngle = 90F;
            this.cuiGradientBorder_AboveMenu.Location = new System.Drawing.Point(0, 696);
            this.cuiGradientBorder_AboveMenu.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_AboveMenu.Name = "cuiGradientBorder_AboveMenu";
            this.cuiGradientBorder_AboveMenu.OutlineThickness = 0F;
            this.cuiGradientBorder_AboveMenu.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_AboveMenu.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cuiGradientBorder_AboveMenu.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_AboveMenu.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_AboveMenu.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_AboveMenu.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_AboveMenu.TabIndex = 5;
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.EnhanceCorners = true;
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder.Rounding = 6;
            this.cuiFormRounder.TargetForm = this;
            // 
            // panel_Measurement
            // 
            this.panel_Measurement.Controls.Add(this.cuiDataGridView_Measurement_WeightHistory);
            this.panel_Measurement.Controls.Add(this.cuiButton_Measurement_AddHistory);
            this.panel_Measurement.Controls.Add(this.textBox_Measurement_ChartName);
            this.panel_Measurement.Controls.Add(this.label_Measurement_History);
            this.panel_Measurement.Controls.Add(this.cuiChartLine_Measurement_Weight);
            this.panel_Measurement.Controls.Add(this.cuiGradientBorder_Measurement_ChartLineBorder);
            this.panel_Measurement.Controls.Add(this.cuiGradientBorder_Measurement);
            this.panel_Measurement.Controls.Add(this.panel_Measurement_Title);
            this.panel_Measurement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Measurement.Location = new System.Drawing.Point(0, 706);
            this.panel_Measurement.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Measurement.Name = "panel_Measurement";
            this.panel_Measurement.Size = new System.Drawing.Size(513, 0);
            this.panel_Measurement.TabIndex = 14;
            // 
            // cuiDataGridView_Measurement_WeightHistory
            // 
            this.cuiDataGridView_Measurement_WeightHistory.AutoScroll = true;
            this.cuiDataGridView_Measurement_WeightHistory.Cell = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.Cell2 = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.CellBorder = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.CellHover = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.CellSelect = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.DataSource = null;
            this.cuiDataGridView_Measurement_WeightHistory.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiDataGridView_Measurement_WeightHistory.ForeColor = System.Drawing.Color.White;
            this.cuiDataGridView_Measurement_WeightHistory.HeaderColor = System.Drawing.Color.Transparent;
            this.cuiDataGridView_Measurement_WeightHistory.Location = new System.Drawing.Point(25, 527);
            this.cuiDataGridView_Measurement_WeightHistory.Name = "cuiDataGridView_Measurement_WeightHistory";
            this.cuiDataGridView_Measurement_WeightHistory.Rounding = 4;
            this.cuiDataGridView_Measurement_WeightHistory.Size = new System.Drawing.Size(462, 128);
            this.cuiDataGridView_Measurement_WeightHistory.TabIndex = 17;
            // 
            // cuiButton_Measurement_AddHistory
            // 
            this.cuiButton_Measurement_AddHistory.CheckButton = false;
            this.cuiButton_Measurement_AddHistory.Checked = false;
            this.cuiButton_Measurement_AddHistory.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measurement_AddHistory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measurement_AddHistory.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measurement_AddHistory.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measurement_AddHistory.Content = "";
            this.cuiButton_Measurement_AddHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measurement_AddHistory.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measurement_AddHistory.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measurement_AddHistory.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measurement_AddHistory.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_Measurement_AddHistory.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Measurement_AddHistory.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measurement_AddHistory.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Measurement_AddHistory.Image")));
            this.cuiButton_Measurement_AddHistory.ImageAutoCenter = true;
            this.cuiButton_Measurement_AddHistory.ImageExpand = new System.Drawing.Point(2, 2);
            this.cuiButton_Measurement_AddHistory.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measurement_AddHistory.Location = new System.Drawing.Point(445, 480);
            this.cuiButton_Measurement_AddHistory.Name = "cuiButton_Measurement_AddHistory";
            this.cuiButton_Measurement_AddHistory.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measurement_AddHistory.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measurement_AddHistory.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measurement_AddHistory.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measurement_AddHistory.OutlineThickness = 0F;
            this.cuiButton_Measurement_AddHistory.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measurement_AddHistory.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measurement_AddHistory.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_Measurement_AddHistory.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measurement_AddHistory.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Measurement_AddHistory.Size = new System.Drawing.Size(43, 41);
            this.cuiButton_Measurement_AddHistory.TabIndex = 16;
            this.cuiButton_Measurement_AddHistory.TextOffset = new System.Drawing.Point(0, 15);
            // 
            // textBox_Measurement_ChartName
            // 
            this.textBox_Measurement_ChartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.textBox_Measurement_ChartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Measurement_ChartName.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_Measurement_ChartName.ForeColor = System.Drawing.Color.White;
            this.textBox_Measurement_ChartName.Location = new System.Drawing.Point(77, 123);
            this.textBox_Measurement_ChartName.Name = "textBox_Measurement_ChartName";
            this.textBox_Measurement_ChartName.ReadOnly = true;
            this.textBox_Measurement_ChartName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Measurement_ChartName.Size = new System.Drawing.Size(377, 27);
            this.textBox_Measurement_ChartName.TabIndex = 12;
            this.textBox_Measurement_ChartName.Text = "Weight (lbs)";
            // 
            // label_Measurement_History
            // 
            this.label_Measurement_History.AutoSize = true;
            this.label_Measurement_History.BackColor = System.Drawing.Color.Transparent;
            this.label_Measurement_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measurement_History.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Measurement_History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Measurement_History.Location = new System.Drawing.Point(22, 497);
            this.label_Measurement_History.Name = "label_Measurement_History";
            this.label_Measurement_History.Size = new System.Drawing.Size(75, 17);
            this.label_Measurement_History.TabIndex = 13;
            this.label_Measurement_History.Text = "HISTORY";
            this.label_Measurement_History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiChartLine_Measurement_Weight
            // 
            this.cuiChartLine_Measurement_Weight.AutoMaxValue = false;
            this.cuiChartLine_Measurement_Weight.AxisColor = System.Drawing.Color.Gray;
            this.cuiChartLine_Measurement_Weight.ChartLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(43)))), ((int)(((byte)(154)))));
            this.cuiChartLine_Measurement_Weight.ChartPadding = 40;
            this.cuiChartLine_Measurement_Weight.CustomXAxis = new string[0];
            this.cuiChartLine_Measurement_Weight.DataPoints = new float[] {
        100F,
        90F,
        80F,
        75F,
        70F,
        65F,
        60F};
            this.cuiChartLine_Measurement_Weight.DayColor = System.Drawing.Color.DarkGray;
            this.cuiChartLine_Measurement_Weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.cuiChartLine_Measurement_Weight.GradientBackground = true;
            this.cuiChartLine_Measurement_Weight.Location = new System.Drawing.Point(40, 109);
            this.cuiChartLine_Measurement_Weight.Margin = new System.Windows.Forms.Padding(10);
            this.cuiChartLine_Measurement_Weight.MaxValue = 250F;
            this.cuiChartLine_Measurement_Weight.Name = "cuiChartLine_Measurement_Weight";
            this.cuiChartLine_Measurement_Weight.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(43)))), ((int)(((byte)(154)))));
            this.cuiChartLine_Measurement_Weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cuiChartLine_Measurement_Weight.ShortDates = true;
            this.cuiChartLine_Measurement_Weight.Size = new System.Drawing.Size(440, 309);
            this.cuiChartLine_Measurement_Weight.TabIndex = 11;
            this.cuiChartLine_Measurement_Weight.UseBezier = false;
            this.cuiChartLine_Measurement_Weight.UsePercent = false;
            // 
            // cuiGradientBorder_Measurement_ChartLineBorder
            // 
            this.cuiGradientBorder_Measurement_ChartLineBorder.GradientAngle = 0F;
            this.cuiGradientBorder_Measurement_ChartLineBorder.Location = new System.Drawing.Point(24, 105);
            this.cuiGradientBorder_Measurement_ChartLineBorder.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Measurement_ChartLineBorder.Name = "cuiGradientBorder_Measurement_ChartLineBorder";
            this.cuiGradientBorder_Measurement_ChartLineBorder.OutlineThickness = 1F;
            this.cuiGradientBorder_Measurement_ChartLineBorder.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measurement_ChartLineBorder.PanelColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measurement_ChartLineBorder.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiGradientBorder_Measurement_ChartLineBorder.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiGradientBorder_Measurement_ChartLineBorder.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Measurement_ChartLineBorder.Size = new System.Drawing.Size(463, 318);
            this.cuiGradientBorder_Measurement_ChartLineBorder.TabIndex = 10;
            // 
            // cuiGradientBorder_Measurement
            // 
            this.cuiGradientBorder_Measurement.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_Measurement.GradientAngle = -90F;
            this.cuiGradientBorder_Measurement.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_Measurement.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Measurement.Name = "cuiGradientBorder_Measurement";
            this.cuiGradientBorder_Measurement.OutlineThickness = 0F;
            this.cuiGradientBorder_Measurement.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measurement.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_Measurement.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measurement.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measurement.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Measurement.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_Measurement.TabIndex = 8;
            // 
            // panel_Measurement_Title
            // 
            this.panel_Measurement_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Measurement_Title.Controls.Add(this.cuiButton_Measure_GoBack);
            this.panel_Measurement_Title.Controls.Add(this.label_Measurement_Name);
            this.panel_Measurement_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Measurement_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Measurement_Title.Name = "panel_Measurement_Title";
            this.panel_Measurement_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_Measurement_Title.TabIndex = 7;
            // 
            // cuiButton_Measure_GoBack
            // 
            this.cuiButton_Measure_GoBack.CheckButton = false;
            this.cuiButton_Measure_GoBack.Checked = false;
            this.cuiButton_Measure_GoBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_GoBack.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_GoBack.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_GoBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_GoBack.Content = "";
            this.cuiButton_Measure_GoBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Measure_GoBack.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_GoBack.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_GoBack.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_GoBack.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_Measure_GoBack.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_GoBack.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_GoBack.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Measure_GoBack.Image")));
            this.cuiButton_Measure_GoBack.ImageAutoCenter = true;
            this.cuiButton_Measure_GoBack.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Measure_GoBack.ImageOffset = new System.Drawing.Point(-2, 0);
            this.cuiButton_Measure_GoBack.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_GoBack.Name = "cuiButton_Measure_GoBack";
            this.cuiButton_Measure_GoBack.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_GoBack.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_GoBack.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_GoBack.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_GoBack.OutlineThickness = 0F;
            this.cuiButton_Measure_GoBack.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_GoBack.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_GoBack.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_GoBack.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_GoBack.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Measure_GoBack.Size = new System.Drawing.Size(102, 80);
            this.cuiButton_Measure_GoBack.TabIndex = 8;
            this.cuiButton_Measure_GoBack.TextOffset = new System.Drawing.Point(0, 15);
            // 
            // label_Measurement_Name
            // 
            this.label_Measurement_Name.AutoSize = true;
            this.label_Measurement_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Measurement_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measurement_Name.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Measurement_Name.ForeColor = System.Drawing.Color.White;
            this.label_Measurement_Name.Location = new System.Drawing.Point(116, 27);
            this.label_Measurement_Name.Name = "label_Measurement_Name";
            this.label_Measurement_Name.Size = new System.Drawing.Size(106, 27);
            this.label_Measurement_Name.TabIndex = 7;
            this.label_Measurement_Name.Text = "Measure";
            this.label_Measurement_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_WorkoutCreation
            // 
            this.flowLayoutPanel_WorkoutCreation.AutoScroll = true;
            this.flowLayoutPanel_WorkoutCreation.Controls.Add(this.panel_WorkoutCreation_TemplateName);
            this.flowLayoutPanel_WorkoutCreation.Controls.Add(this.cuiButton_WorkoutCreation_AddExercise);
            this.flowLayoutPanel_WorkoutCreation.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel_WorkoutCreation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_WorkoutCreation.Location = new System.Drawing.Point(0, 90);
            this.flowLayoutPanel_WorkoutCreation.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_WorkoutCreation.Name = "flowLayoutPanel_WorkoutCreation";
            this.flowLayoutPanel_WorkoutCreation.Size = new System.Drawing.Size(513, 663);
            this.flowLayoutPanel_WorkoutCreation.TabIndex = 6;
            // 
            // panel_WorkoutCreation_TemplateName
            // 
            this.panel_WorkoutCreation_TemplateName.Controls.Add(this.cuiTextBox_WorkoutCreation_Note);
            this.panel_WorkoutCreation_TemplateName.Controls.Add(this.cuiButton_WorkoutCreation_EditName);
            this.panel_WorkoutCreation_TemplateName.Controls.Add(this.cuiTextBox_WorkoutCreation_TemplateName);
            this.panel_WorkoutCreation_TemplateName.Location = new System.Drawing.Point(3, 3);
            this.panel_WorkoutCreation_TemplateName.Name = "panel_WorkoutCreation_TemplateName";
            this.panel_WorkoutCreation_TemplateName.Size = new System.Drawing.Size(507, 220);
            this.panel_WorkoutCreation_TemplateName.TabIndex = 10;
            // 
            // cuiTextBox_WorkoutCreation_Note
            // 
            this.cuiTextBox_WorkoutCreation_Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cuiTextBox_WorkoutCreation_Note.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cuiTextBox_WorkoutCreation_Note.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_Note.BorderSize = 1;
            this.cuiTextBox_WorkoutCreation_Note.Content = "";
            this.cuiTextBox_WorkoutCreation_Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_WorkoutCreation_Note.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cuiTextBox_WorkoutCreation_Note.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_Note.Font = new System.Drawing.Font("SansSerif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_WorkoutCreation_Note.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_WorkoutCreation_Note.Location = new System.Drawing.Point(24, 143);
            this.cuiTextBox_WorkoutCreation_Note.Margin = new System.Windows.Forms.Padding(24, 24, 24, 20);
            this.cuiTextBox_WorkoutCreation_Note.Multiline = false;
            this.cuiTextBox_WorkoutCreation_Note.Name = "cuiTextBox_WorkoutCreation_Note";
            this.cuiTextBox_WorkoutCreation_Note.Padding = new System.Windows.Forms.Padding(20, 17, 20, 0);
            this.cuiTextBox_WorkoutCreation_Note.PasswordChar = false;
            this.cuiTextBox_WorkoutCreation_Note.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.cuiTextBox_WorkoutCreation_Note.PlaceholderText = "Workout Note";
            this.cuiTextBox_WorkoutCreation_Note.Rounding = new System.Windows.Forms.Padding(12);
            this.cuiTextBox_WorkoutCreation_Note.Size = new System.Drawing.Size(453, 64);
            this.cuiTextBox_WorkoutCreation_Note.TabIndex = 10;
            this.cuiTextBox_WorkoutCreation_Note.TextOffset = new System.Drawing.Size(-10, 0);
            this.cuiTextBox_WorkoutCreation_Note.UnderlinedStyle = false;
            // 
            // cuiButton_WorkoutCreation_EditName
            // 
            this.cuiButton_WorkoutCreation_EditName.CheckButton = false;
            this.cuiButton_WorkoutCreation_EditName.Checked = false;
            this.cuiButton_WorkoutCreation_EditName.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_EditName.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_EditName.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_EditName.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_EditName.Content = "";
            this.cuiButton_WorkoutCreation_EditName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_WorkoutCreation_EditName.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_WorkoutCreation_EditName.ForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_EditName.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_EditName.HoveredImageTint = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_WorkoutCreation_EditName.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_EditName.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_EditName.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_WorkoutCreation_EditName.Image")));
            this.cuiButton_WorkoutCreation_EditName.ImageAutoCenter = true;
            this.cuiButton_WorkoutCreation_EditName.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton_WorkoutCreation_EditName.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_EditName.Location = new System.Drawing.Point(432, 22);
            this.cuiButton_WorkoutCreation_EditName.Name = "cuiButton_WorkoutCreation_EditName";
            this.cuiButton_WorkoutCreation_EditName.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_EditName.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_EditName.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_WorkoutCreation_EditName.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_EditName.OutlineThickness = 0F;
            this.cuiButton_WorkoutCreation_EditName.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_EditName.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_EditName.PressedImageTint = System.Drawing.Color.DeepSkyBlue;
            this.cuiButton_WorkoutCreation_EditName.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_EditName.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_WorkoutCreation_EditName.Size = new System.Drawing.Size(72, 45);
            this.cuiButton_WorkoutCreation_EditName.TabIndex = 9;
            this.cuiButton_WorkoutCreation_EditName.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_EditName.Click += new System.EventHandler(this.cuiButton_WorkoutCreation_EditName_Click);
            // 
            // cuiTextBox_WorkoutCreation_TemplateName
            // 
            this.cuiTextBox_WorkoutCreation_TemplateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_TemplateName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_TemplateName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_TemplateName.BorderSize = 1;
            this.cuiTextBox_WorkoutCreation_TemplateName.Content = "";
            this.cuiTextBox_WorkoutCreation_TemplateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_WorkoutCreation_TemplateName.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_TemplateName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiTextBox_WorkoutCreation_TemplateName.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_WorkoutCreation_TemplateName.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_WorkoutCreation_TemplateName.Location = new System.Drawing.Point(24, 24);
            this.cuiTextBox_WorkoutCreation_TemplateName.Margin = new System.Windows.Forms.Padding(24, 24, 20, 20);
            this.cuiTextBox_WorkoutCreation_TemplateName.Multiline = false;
            this.cuiTextBox_WorkoutCreation_TemplateName.Name = "cuiTextBox_WorkoutCreation_TemplateName";
            this.cuiTextBox_WorkoutCreation_TemplateName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cuiTextBox_WorkoutCreation_TemplateName.PasswordChar = false;
            this.cuiTextBox_WorkoutCreation_TemplateName.PlaceholderColor = System.Drawing.Color.White;
            this.cuiTextBox_WorkoutCreation_TemplateName.PlaceholderText = "New workout template";
            this.cuiTextBox_WorkoutCreation_TemplateName.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_WorkoutCreation_TemplateName.Size = new System.Drawing.Size(424, 45);
            this.cuiTextBox_WorkoutCreation_TemplateName.TabIndex = 0;
            this.cuiTextBox_WorkoutCreation_TemplateName.TextOffset = new System.Drawing.Size(-50, 0);
            this.cuiTextBox_WorkoutCreation_TemplateName.UnderlinedStyle = false;
            // 
            // cuiButton_WorkoutCreation_AddExercise
            // 
            this.cuiButton_WorkoutCreation_AddExercise.CheckButton = false;
            this.cuiButton_WorkoutCreation_AddExercise.Checked = false;
            this.cuiButton_WorkoutCreation_AddExercise.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_AddExercise.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_AddExercise.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_AddExercise.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_AddExercise.Content = "ADD EXERCISE";
            this.cuiButton_WorkoutCreation_AddExercise.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_WorkoutCreation_AddExercise.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_WorkoutCreation_AddExercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_WorkoutCreation_AddExercise.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_AddExercise.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_AddExercise.HoverForeColor = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_WorkoutCreation_AddExercise.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_AddExercise.Image = null;
            this.cuiButton_WorkoutCreation_AddExercise.ImageAutoCenter = false;
            this.cuiButton_WorkoutCreation_AddExercise.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_AddExercise.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_AddExercise.Location = new System.Drawing.Point(3, 230);
            this.cuiButton_WorkoutCreation_AddExercise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cuiButton_WorkoutCreation_AddExercise.Name = "cuiButton_WorkoutCreation_AddExercise";
            this.cuiButton_WorkoutCreation_AddExercise.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_AddExercise.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_WorkoutCreation_AddExercise.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_AddExercise.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_AddExercise.OutlineThickness = 1.5F;
            this.cuiButton_WorkoutCreation_AddExercise.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.cuiButton_WorkoutCreation_AddExercise.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_AddExercise.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_AddExercise.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_AddExercise.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_WorkoutCreation_AddExercise.Size = new System.Drawing.Size(507, 50);
            this.cuiButton_WorkoutCreation_AddExercise.TabIndex = 22;
            this.cuiButton_WorkoutCreation_AddExercise.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_AddExercise.Click += new System.EventHandler(this.cuiButton_WorkoutCreation_AddExercise_Click);
            // 
            // panel_WorkoutCreation_Title
            // 
            this.panel_WorkoutCreation_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_WorkoutCreation_Title.Controls.Add(this.cuiButton_WorkoutCreation_Save);
            this.panel_WorkoutCreation_Title.Controls.Add(this.cuiButton_WorkoutCreation_Exit);
            this.panel_WorkoutCreation_Title.Controls.Add(this.label_WorkoutCreation);
            this.panel_WorkoutCreation_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_WorkoutCreation_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_WorkoutCreation_Title.Name = "panel_WorkoutCreation_Title";
            this.panel_WorkoutCreation_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_WorkoutCreation_Title.TabIndex = 7;
            // 
            // cuiButton_WorkoutCreation_Save
            // 
            this.cuiButton_WorkoutCreation_Save.CheckButton = false;
            this.cuiButton_WorkoutCreation_Save.Checked = false;
            this.cuiButton_WorkoutCreation_Save.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_Save.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_Save.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_Save.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_Save.Content = "SAVE";
            this.cuiButton_WorkoutCreation_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_WorkoutCreation_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiButton_WorkoutCreation_Save.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_WorkoutCreation_Save.ForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Save.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Save.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_WorkoutCreation_Save.HoverForeColor = System.Drawing.Color.DarkGray;
            this.cuiButton_WorkoutCreation_Save.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Save.Image = null;
            this.cuiButton_WorkoutCreation_Save.ImageAutoCenter = true;
            this.cuiButton_WorkoutCreation_Save.ImageExpand = new System.Drawing.Point(2, 2);
            this.cuiButton_WorkoutCreation_Save.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_Save.Location = new System.Drawing.Point(433, 0);
            this.cuiButton_WorkoutCreation_Save.Name = "cuiButton_WorkoutCreation_Save";
            this.cuiButton_WorkoutCreation_Save.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Save.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Save.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Save.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Save.OutlineThickness = 0F;
            this.cuiButton_WorkoutCreation_Save.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Save.PressedForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_WorkoutCreation_Save.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_WorkoutCreation_Save.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Save.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_WorkoutCreation_Save.Size = new System.Drawing.Size(80, 80);
            this.cuiButton_WorkoutCreation_Save.TabIndex = 17;
            this.cuiButton_WorkoutCreation_Save.TextOffset = new System.Drawing.Point(-7, 0);
            this.cuiButton_WorkoutCreation_Save.Click += new System.EventHandler(this.cuiButton_WorkoutCreation_Save_Click);
            // 
            // cuiButton_WorkoutCreation_Exit
            // 
            this.cuiButton_WorkoutCreation_Exit.CheckButton = false;
            this.cuiButton_WorkoutCreation_Exit.Checked = false;
            this.cuiButton_WorkoutCreation_Exit.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_Exit.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_Exit.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_WorkoutCreation_Exit.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_WorkoutCreation_Exit.Content = "";
            this.cuiButton_WorkoutCreation_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_WorkoutCreation_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_WorkoutCreation_Exit.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_WorkoutCreation_Exit.ForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Exit.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Exit.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_WorkoutCreation_Exit.HoverForeColor = System.Drawing.Color.DarkGray;
            this.cuiButton_WorkoutCreation_Exit.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Exit.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_WorkoutCreation_Exit.Image")));
            this.cuiButton_WorkoutCreation_Exit.ImageAutoCenter = true;
            this.cuiButton_WorkoutCreation_Exit.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton_WorkoutCreation_Exit.ImageOffset = new System.Drawing.Point(4, 0);
            this.cuiButton_WorkoutCreation_Exit.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_Exit.Name = "cuiButton_WorkoutCreation_Exit";
            this.cuiButton_WorkoutCreation_Exit.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Exit.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Exit.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_WorkoutCreation_Exit.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Exit.OutlineThickness = 0F;
            this.cuiButton_WorkoutCreation_Exit.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_WorkoutCreation_Exit.PressedForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_WorkoutCreation_Exit.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_WorkoutCreation_Exit.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_WorkoutCreation_Exit.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_WorkoutCreation_Exit.Size = new System.Drawing.Size(80, 80);
            this.cuiButton_WorkoutCreation_Exit.TabIndex = 16;
            this.cuiButton_WorkoutCreation_Exit.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_WorkoutCreation_Exit.Click += new System.EventHandler(this.cuiButton_Menu_Workout_Click);
            // 
            // label_WorkoutCreation
            // 
            this.label_WorkoutCreation.AutoSize = true;
            this.label_WorkoutCreation.BackColor = System.Drawing.Color.Transparent;
            this.label_WorkoutCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_WorkoutCreation.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_WorkoutCreation.ForeColor = System.Drawing.Color.White;
            this.label_WorkoutCreation.Location = new System.Drawing.Point(112, 27);
            this.label_WorkoutCreation.Name = "label_WorkoutCreation";
            this.label_WorkoutCreation.Size = new System.Drawing.Size(241, 27);
            this.label_WorkoutCreation.TabIndex = 7;
            this.label_WorkoutCreation.Text = "New workout template";
            this.label_WorkoutCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiGradientBorder_WorkoutCreation
            // 
            this.cuiGradientBorder_WorkoutCreation.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_WorkoutCreation.GradientAngle = -90F;
            this.cuiGradientBorder_WorkoutCreation.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_WorkoutCreation.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_WorkoutCreation.Name = "cuiGradientBorder_WorkoutCreation";
            this.cuiGradientBorder_WorkoutCreation.OutlineThickness = 0F;
            this.cuiGradientBorder_WorkoutCreation.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_WorkoutCreation.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_WorkoutCreation.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_WorkoutCreation.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_WorkoutCreation.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_WorkoutCreation.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_WorkoutCreation.TabIndex = 8;
            // 
            // panel_WorkoutCreation
            // 
            this.panel_WorkoutCreation.Controls.Add(this.cuiGradientBorder_WorkoutCreation);
            this.panel_WorkoutCreation.Controls.Add(this.panel_WorkoutCreation_Title);
            this.panel_WorkoutCreation.Controls.Add(this.flowLayoutPanel_WorkoutCreation);
            this.panel_WorkoutCreation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_WorkoutCreation.Location = new System.Drawing.Point(0, 35);
            this.panel_WorkoutCreation.Margin = new System.Windows.Forms.Padding(0);
            this.panel_WorkoutCreation.Name = "panel_WorkoutCreation";
            this.panel_WorkoutCreation.Size = new System.Drawing.Size(513, 0);
            this.panel_WorkoutCreation.TabIndex = 17;
            // 
            // panel_Menu_Profile
            // 
            this.panel_Menu_Profile.Controls.Add(this.cuiGradientBorder_Profile);
            this.panel_Menu_Profile.Controls.Add(this.panel_Profile_Title);
            this.panel_Menu_Profile.Controls.Add(this.flowLayoutPanel_Profile);
            this.panel_Menu_Profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menu_Profile.Location = new System.Drawing.Point(0, 696);
            this.panel_Menu_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu_Profile.Name = "panel_Menu_Profile";
            this.panel_Menu_Profile.Size = new System.Drawing.Size(513, 0);
            this.panel_Menu_Profile.TabIndex = 18;
            // 
            // cuiGradientBorder_Profile
            // 
            this.cuiGradientBorder_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_Profile.GradientAngle = -90F;
            this.cuiGradientBorder_Profile.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Profile.Name = "cuiGradientBorder_Profile";
            this.cuiGradientBorder_Profile.OutlineThickness = 0F;
            this.cuiGradientBorder_Profile.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Profile.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_Profile.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Profile.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Profile.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Profile.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_Profile.TabIndex = 8;
            // 
            // panel_Profile_Title
            // 
            this.panel_Profile_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Profile_Title.Controls.Add(this.cuiButton_Profile_Settings);
            this.panel_Profile_Title.Controls.Add(this.label_Profile_Title);
            this.panel_Profile_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Profile_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Profile_Title.Name = "panel_Profile_Title";
            this.panel_Profile_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_Profile_Title.TabIndex = 7;
            // 
            // cuiButton_Profile_Settings
            // 
            this.cuiButton_Profile_Settings.CheckButton = false;
            this.cuiButton_Profile_Settings.Checked = false;
            this.cuiButton_Profile_Settings.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Profile_Settings.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Profile_Settings.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Profile_Settings.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Profile_Settings.Content = "";
            this.cuiButton_Profile_Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Profile_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiButton_Profile_Settings.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Profile_Settings.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Profile_Settings.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Profile_Settings.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Profile_Settings.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Profile_Settings.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Profile_Settings.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Profile_Settings.Image")));
            this.cuiButton_Profile_Settings.ImageAutoCenter = true;
            this.cuiButton_Profile_Settings.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Profile_Settings.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Profile_Settings.Location = new System.Drawing.Point(411, 0);
            this.cuiButton_Profile_Settings.Name = "cuiButton_Profile_Settings";
            this.cuiButton_Profile_Settings.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Profile_Settings.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Profile_Settings.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Profile_Settings.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Profile_Settings.OutlineThickness = 0F;
            this.cuiButton_Profile_Settings.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Profile_Settings.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Profile_Settings.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Profile_Settings.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Profile_Settings.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Profile_Settings.Size = new System.Drawing.Size(102, 80);
            this.cuiButton_Profile_Settings.TabIndex = 8;
            this.cuiButton_Profile_Settings.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label_Profile_Title
            // 
            this.label_Profile_Title.AutoSize = true;
            this.label_Profile_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Profile_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Profile_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Profile_Title.ForeColor = System.Drawing.Color.White;
            this.label_Profile_Title.Location = new System.Drawing.Point(27, 27);
            this.label_Profile_Title.Name = "label_Profile_Title";
            this.label_Profile_Title.Size = new System.Drawing.Size(83, 27);
            this.label_Profile_Title.TabIndex = 7;
            this.label_Profile_Title.Text = "Profile";
            this.label_Profile_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Profile
            // 
            this.flowLayoutPanel_Profile.AutoScroll = true;
            this.flowLayoutPanel_Profile.Controls.Add(this.panel_Profile_User);
            this.flowLayoutPanel_Profile.Controls.Add(this.panel_Profile_WorkoutCount);
            this.flowLayoutPanel_Profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Profile.Location = new System.Drawing.Point(0, -566);
            this.flowLayoutPanel_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Profile.Name = "flowLayoutPanel_Profile";
            this.flowLayoutPanel_Profile.Size = new System.Drawing.Size(513, 566);
            this.flowLayoutPanel_Profile.TabIndex = 6;
            // 
            // panel_Profile_User
            // 
            this.panel_Profile_User.Controls.Add(this.label_Profile_Dashboard);
            this.panel_Profile_User.Controls.Add(this.label_Profile_WorkoutCount);
            this.panel_Profile_User.Controls.Add(this.label_Profile_Username);
            this.panel_Profile_User.Controls.Add(this.cuiPictureBox_Profile_User);
            this.panel_Profile_User.Location = new System.Drawing.Point(3, 3);
            this.panel_Profile_User.Name = "panel_Profile_User";
            this.panel_Profile_User.Size = new System.Drawing.Size(507, 150);
            this.panel_Profile_User.TabIndex = 0;
            // 
            // label_Profile_Dashboard
            // 
            this.label_Profile_Dashboard.AutoSize = true;
            this.label_Profile_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.label_Profile_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Profile_Dashboard.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Profile_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Profile_Dashboard.Location = new System.Drawing.Point(20, 118);
            this.label_Profile_Dashboard.Name = "label_Profile_Dashboard";
            this.label_Profile_Dashboard.Size = new System.Drawing.Size(104, 17);
            this.label_Profile_Dashboard.TabIndex = 11;
            this.label_Profile_Dashboard.Text = "DASHBOARD";
            this.label_Profile_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Profile_WorkoutCount
            // 
            this.label_Profile_WorkoutCount.AutoSize = true;
            this.label_Profile_WorkoutCount.BackColor = System.Drawing.Color.Transparent;
            this.label_Profile_WorkoutCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Profile_WorkoutCount.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Profile_WorkoutCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Profile_WorkoutCount.Location = new System.Drawing.Point(130, 56);
            this.label_Profile_WorkoutCount.Name = "label_Profile_WorkoutCount";
            this.label_Profile_WorkoutCount.Size = new System.Drawing.Size(107, 23);
            this.label_Profile_WorkoutCount.TabIndex = 10;
            this.label_Profile_WorkoutCount.Text = "0 workouts";
            this.label_Profile_WorkoutCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Profile_Username
            // 
            this.label_Profile_Username.AutoSize = true;
            this.label_Profile_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Profile_Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Profile_Username.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Profile_Username.ForeColor = System.Drawing.Color.White;
            this.label_Profile_Username.Location = new System.Drawing.Point(130, 25);
            this.label_Profile_Username.Name = "label_Profile_Username";
            this.label_Profile_Username.Size = new System.Drawing.Size(64, 27);
            this.label_Profile_Username.TabIndex = 9;
            this.label_Profile_Username.Text = "User";
            this.label_Profile_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiPictureBox_Profile_User
            // 
            this.cuiPictureBox_Profile_User.Content = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox_Profile_User.Content")));
            this.cuiPictureBox_Profile_User.CornerRadius = 8;
            this.cuiPictureBox_Profile_User.ImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.cuiPictureBox_Profile_User.Location = new System.Drawing.Point(16, 2);
            this.cuiPictureBox_Profile_User.Margin = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox_Profile_User.Name = "cuiPictureBox_Profile_User";
            this.cuiPictureBox_Profile_User.OutlineThickness = 1F;
            this.cuiPictureBox_Profile_User.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox_Profile_User.Rotation = 0;
            this.cuiPictureBox_Profile_User.Size = new System.Drawing.Size(110, 100);
            this.cuiPictureBox_Profile_User.TabIndex = 1;
            // 
            // panel_Profile_WorkoutCount
            // 
            this.panel_Profile_WorkoutCount.Controls.Add(this.chart_Profile_WorkoutCount);
            this.panel_Profile_WorkoutCount.Location = new System.Drawing.Point(3, 159);
            this.panel_Profile_WorkoutCount.Name = "panel_Profile_WorkoutCount";
            this.panel_Profile_WorkoutCount.Size = new System.Drawing.Size(507, 401);
            this.panel_Profile_WorkoutCount.TabIndex = 12;
            // 
            // chart_Profile_WorkoutCount
            // 
            this.chart_Profile_WorkoutCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.chart_Profile_WorkoutCount.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.chart_Profile_WorkoutCount.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chart_Profile_WorkoutCount.ChartAreas.Add(chartArea4);
            this.chart_Profile_WorkoutCount.Location = new System.Drawing.Point(51, 17);
            this.chart_Profile_WorkoutCount.Name = "chart_Profile_WorkoutCount";
            this.chart_Profile_WorkoutCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart_Profile_WorkoutCount.Series.Add(series4);
            this.chart_Profile_WorkoutCount.Size = new System.Drawing.Size(400, 300);
            this.chart_Profile_WorkoutCount.TabIndex = 0;
            this.chart_Profile_WorkoutCount.Text = "chart1";
            // 
            // panel_Menu_History
            // 
            this.panel_Menu_History.Controls.Add(this.cuiGradientBorder_History);
            this.panel_Menu_History.Controls.Add(this.panel_History_Title);
            this.panel_Menu_History.Controls.Add(this.flowLayoutPanel_History);
            this.panel_Menu_History.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menu_History.Location = new System.Drawing.Point(0, 696);
            this.panel_Menu_History.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu_History.Name = "panel_Menu_History";
            this.panel_Menu_History.Size = new System.Drawing.Size(513, 0);
            this.panel_Menu_History.TabIndex = 19;
            // 
            // cuiGradientBorder_History
            // 
            this.cuiGradientBorder_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_History.GradientAngle = -90F;
            this.cuiGradientBorder_History.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_History.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_History.Name = "cuiGradientBorder_History";
            this.cuiGradientBorder_History.OutlineThickness = 0F;
            this.cuiGradientBorder_History.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_History.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_History.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_History.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_History.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_History.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_History.TabIndex = 8;
            // 
            // panel_History_Title
            // 
            this.panel_History_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_History_Title.Controls.Add(this.cuiButton_History_Calendar);
            this.panel_History_Title.Controls.Add(this.label_History_Title);
            this.panel_History_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_History_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_History_Title.Name = "panel_History_Title";
            this.panel_History_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_History_Title.TabIndex = 7;
            // 
            // cuiButton_History_Calendar
            // 
            this.cuiButton_History_Calendar.CheckButton = false;
            this.cuiButton_History_Calendar.Checked = false;
            this.cuiButton_History_Calendar.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_History_Calendar.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_History_Calendar.Content = "";
            this.cuiButton_History_Calendar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_History_Calendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiButton_History_Calendar.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_History_Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_History_Calendar.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_History_Calendar.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_History_Calendar.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_History_Calendar.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_History_Calendar.Image")));
            this.cuiButton_History_Calendar.ImageAutoCenter = true;
            this.cuiButton_History_Calendar.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton_History_Calendar.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_History_Calendar.Location = new System.Drawing.Point(411, 0);
            this.cuiButton_History_Calendar.Name = "cuiButton_History_Calendar";
            this.cuiButton_History_Calendar.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_History_Calendar.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_History_Calendar.OutlineThickness = 0F;
            this.cuiButton_History_Calendar.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_History_Calendar.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_History_Calendar.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_History_Calendar.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_History_Calendar.Size = new System.Drawing.Size(102, 80);
            this.cuiButton_History_Calendar.TabIndex = 8;
            this.cuiButton_History_Calendar.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label_History_Title
            // 
            this.label_History_Title.AutoSize = true;
            this.label_History_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_History_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_History_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_History_Title.ForeColor = System.Drawing.Color.White;
            this.label_History_Title.Location = new System.Drawing.Point(27, 27);
            this.label_History_Title.Name = "label_History_Title";
            this.label_History_Title.Size = new System.Drawing.Size(92, 27);
            this.label_History_Title.TabIndex = 7;
            this.label_History_Title.Text = "History";
            this.label_History_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_History
            // 
            this.flowLayoutPanel_History.AutoScroll = true;
            this.flowLayoutPanel_History.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_History.Location = new System.Drawing.Point(0, -566);
            this.flowLayoutPanel_History.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_History.Name = "flowLayoutPanel_History";
            this.flowLayoutPanel_History.Size = new System.Drawing.Size(513, 566);
            this.flowLayoutPanel_History.TabIndex = 6;
            // 
            // panel_Menu_Exercises
            // 
            this.panel_Menu_Exercises.Controls.Add(this.cuiBorder_Exercises_Filter);
            this.panel_Menu_Exercises.Controls.Add(this.cuiGradientBorder_Exercises);
            this.panel_Menu_Exercises.Controls.Add(this.panel_Exercises_Title);
            this.panel_Menu_Exercises.Controls.Add(this.flowLayoutPanel_Exercises);
            this.panel_Menu_Exercises.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menu_Exercises.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_Exercises.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu_Exercises.Name = "panel_Menu_Exercises";
            this.panel_Menu_Exercises.Size = new System.Drawing.Size(513, 661);
            this.panel_Menu_Exercises.TabIndex = 20;
            // 
            // cuiBorder_Exercises_Filter
            // 
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiGradientBorder2);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Other);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Cardio);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Core);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Legs);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_FullBody);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Arms);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Back);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Olympic);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Shoulders);
            this.cuiBorder_Exercises_Filter.Controls.Add(this.cuiCheckbox_Filter_Chest);
            this.cuiBorder_Exercises_Filter.Location = new System.Drawing.Point(0, 90);
            this.cuiBorder_Exercises_Filter.Name = "cuiBorder_Exercises_Filter";
            this.cuiBorder_Exercises_Filter.OutlineThickness = 1F;
            this.cuiBorder_Exercises_Filter.PanelColor = System.Drawing.Color.Transparent;
            this.cuiBorder_Exercises_Filter.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiBorder_Exercises_Filter.Rounding = new System.Windows.Forms.Padding(10);
            this.cuiBorder_Exercises_Filter.Size = new System.Drawing.Size(488, 0);
            this.cuiBorder_Exercises_Filter.TabIndex = 0;
            // 
            // cuiGradientBorder2
            // 
            this.cuiGradientBorder2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiGradientBorder2.GradientAngle = -90F;
            this.cuiGradientBorder2.Location = new System.Drawing.Point(0, -10);
            this.cuiGradientBorder2.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder2.Name = "cuiGradientBorder2";
            this.cuiGradientBorder2.OutlineThickness = 0F;
            this.cuiGradientBorder2.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder2.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder2.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder2.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder2.Size = new System.Drawing.Size(488, 10);
            this.cuiGradientBorder2.TabIndex = 23;
            // 
            // cuiCheckbox_Filter_Other
            // 
            this.cuiCheckbox_Filter_Other.Checked = false;
            this.cuiCheckbox_Filter_Other.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Other.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Other.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Other.Content = "Other";
            this.cuiCheckbox_Filter_Other.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Other.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Other.Location = new System.Drawing.Point(393, 4);
            this.cuiCheckbox_Filter_Other.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Other.Name = "cuiCheckbox_Filter_Other";
            this.cuiCheckbox_Filter_Other.OutlineStyle = true;
            this.cuiCheckbox_Filter_Other.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Other.Rounding = 5;
            this.cuiCheckbox_Filter_Other.ShowSymbols = true;
            this.cuiCheckbox_Filter_Other.Size = new System.Drawing.Size(94, 25);
            this.cuiCheckbox_Filter_Other.TabIndex = 21;
            this.cuiCheckbox_Filter_Other.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Other.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Other.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Cardio
            // 
            this.cuiCheckbox_Filter_Cardio.Checked = false;
            this.cuiCheckbox_Filter_Cardio.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Cardio.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Cardio.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Cardio.Content = "Cardio";
            this.cuiCheckbox_Filter_Cardio.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Cardio.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Cardio.Location = new System.Drawing.Point(284, 54);
            this.cuiCheckbox_Filter_Cardio.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Cardio.Name = "cuiCheckbox_Filter_Cardio";
            this.cuiCheckbox_Filter_Cardio.OutlineStyle = true;
            this.cuiCheckbox_Filter_Cardio.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Cardio.Rounding = 5;
            this.cuiCheckbox_Filter_Cardio.ShowSymbols = true;
            this.cuiCheckbox_Filter_Cardio.Size = new System.Drawing.Size(98, 25);
            this.cuiCheckbox_Filter_Cardio.TabIndex = 20;
            this.cuiCheckbox_Filter_Cardio.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Cardio.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Cardio.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Core
            // 
            this.cuiCheckbox_Filter_Core.Checked = false;
            this.cuiCheckbox_Filter_Core.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Core.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Core.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Core.Content = "Core";
            this.cuiCheckbox_Filter_Core.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Core.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Core.Location = new System.Drawing.Point(284, 29);
            this.cuiCheckbox_Filter_Core.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Core.Name = "cuiCheckbox_Filter_Core";
            this.cuiCheckbox_Filter_Core.OutlineStyle = true;
            this.cuiCheckbox_Filter_Core.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Core.Rounding = 5;
            this.cuiCheckbox_Filter_Core.ShowSymbols = true;
            this.cuiCheckbox_Filter_Core.Size = new System.Drawing.Size(98, 25);
            this.cuiCheckbox_Filter_Core.TabIndex = 19;
            this.cuiCheckbox_Filter_Core.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Core.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Core.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Legs
            // 
            this.cuiCheckbox_Filter_Legs.Checked = false;
            this.cuiCheckbox_Filter_Legs.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Legs.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Legs.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Legs.Content = "Legs";
            this.cuiCheckbox_Filter_Legs.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Legs.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Legs.Location = new System.Drawing.Point(284, 4);
            this.cuiCheckbox_Filter_Legs.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Legs.Name = "cuiCheckbox_Filter_Legs";
            this.cuiCheckbox_Filter_Legs.OutlineStyle = true;
            this.cuiCheckbox_Filter_Legs.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Legs.Rounding = 5;
            this.cuiCheckbox_Filter_Legs.ShowSymbols = true;
            this.cuiCheckbox_Filter_Legs.Size = new System.Drawing.Size(98, 25);
            this.cuiCheckbox_Filter_Legs.TabIndex = 18;
            this.cuiCheckbox_Filter_Legs.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Legs.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Legs.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_FullBody
            // 
            this.cuiCheckbox_Filter_FullBody.Checked = false;
            this.cuiCheckbox_Filter_FullBody.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_FullBody.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_FullBody.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_FullBody.Content = "Full body";
            this.cuiCheckbox_Filter_FullBody.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_FullBody.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_FullBody.Location = new System.Drawing.Point(153, 54);
            this.cuiCheckbox_Filter_FullBody.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_FullBody.Name = "cuiCheckbox_Filter_FullBody";
            this.cuiCheckbox_Filter_FullBody.OutlineStyle = true;
            this.cuiCheckbox_Filter_FullBody.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_FullBody.Rounding = 5;
            this.cuiCheckbox_Filter_FullBody.ShowSymbols = true;
            this.cuiCheckbox_Filter_FullBody.Size = new System.Drawing.Size(120, 25);
            this.cuiCheckbox_Filter_FullBody.TabIndex = 17;
            this.cuiCheckbox_Filter_FullBody.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_FullBody.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_FullBody.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Arms
            // 
            this.cuiCheckbox_Filter_Arms.Checked = false;
            this.cuiCheckbox_Filter_Arms.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Arms.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Arms.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Arms.Content = "Arms";
            this.cuiCheckbox_Filter_Arms.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Arms.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Arms.Location = new System.Drawing.Point(153, 29);
            this.cuiCheckbox_Filter_Arms.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Arms.Name = "cuiCheckbox_Filter_Arms";
            this.cuiCheckbox_Filter_Arms.OutlineStyle = true;
            this.cuiCheckbox_Filter_Arms.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Arms.Rounding = 5;
            this.cuiCheckbox_Filter_Arms.ShowSymbols = true;
            this.cuiCheckbox_Filter_Arms.Size = new System.Drawing.Size(120, 25);
            this.cuiCheckbox_Filter_Arms.TabIndex = 16;
            this.cuiCheckbox_Filter_Arms.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Arms.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Arms.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Back
            // 
            this.cuiCheckbox_Filter_Back.Checked = false;
            this.cuiCheckbox_Filter_Back.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Back.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Back.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Back.Content = "Back";
            this.cuiCheckbox_Filter_Back.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Back.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Back.Location = new System.Drawing.Point(153, 4);
            this.cuiCheckbox_Filter_Back.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Back.Name = "cuiCheckbox_Filter_Back";
            this.cuiCheckbox_Filter_Back.OutlineStyle = true;
            this.cuiCheckbox_Filter_Back.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Back.Rounding = 5;
            this.cuiCheckbox_Filter_Back.ShowSymbols = true;
            this.cuiCheckbox_Filter_Back.Size = new System.Drawing.Size(120, 25);
            this.cuiCheckbox_Filter_Back.TabIndex = 15;
            this.cuiCheckbox_Filter_Back.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Back.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Back.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Olympic
            // 
            this.cuiCheckbox_Filter_Olympic.Checked = false;
            this.cuiCheckbox_Filter_Olympic.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Olympic.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Olympic.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Olympic.Content = "Olympic";
            this.cuiCheckbox_Filter_Olympic.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Olympic.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Olympic.Location = new System.Drawing.Point(21, 54);
            this.cuiCheckbox_Filter_Olympic.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Olympic.Name = "cuiCheckbox_Filter_Olympic";
            this.cuiCheckbox_Filter_Olympic.OutlineStyle = true;
            this.cuiCheckbox_Filter_Olympic.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Olympic.Rounding = 5;
            this.cuiCheckbox_Filter_Olympic.ShowSymbols = true;
            this.cuiCheckbox_Filter_Olympic.Size = new System.Drawing.Size(121, 25);
            this.cuiCheckbox_Filter_Olympic.TabIndex = 14;
            this.cuiCheckbox_Filter_Olympic.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Olympic.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Olympic.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Shoulders
            // 
            this.cuiCheckbox_Filter_Shoulders.Checked = false;
            this.cuiCheckbox_Filter_Shoulders.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Shoulders.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Shoulders.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Shoulders.Content = "Shoulders";
            this.cuiCheckbox_Filter_Shoulders.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Shoulders.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Shoulders.Location = new System.Drawing.Point(21, 29);
            this.cuiCheckbox_Filter_Shoulders.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Shoulders.Name = "cuiCheckbox_Filter_Shoulders";
            this.cuiCheckbox_Filter_Shoulders.OutlineStyle = true;
            this.cuiCheckbox_Filter_Shoulders.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Shoulders.Rounding = 5;
            this.cuiCheckbox_Filter_Shoulders.ShowSymbols = true;
            this.cuiCheckbox_Filter_Shoulders.Size = new System.Drawing.Size(121, 25);
            this.cuiCheckbox_Filter_Shoulders.TabIndex = 13;
            this.cuiCheckbox_Filter_Shoulders.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Shoulders.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Shoulders.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiCheckbox_Filter_Chest
            // 
            this.cuiCheckbox_Filter_Chest.Checked = false;
            this.cuiCheckbox_Filter_Chest.CheckedForeground = System.Drawing.SystemColors.MenuHighlight;
            this.cuiCheckbox_Filter_Chest.CheckedOutlineColor = System.Drawing.SystemColors.Highlight;
            this.cuiCheckbox_Filter_Chest.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Chest.Content = "Chest";
            this.cuiCheckbox_Filter_Chest.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiCheckbox_Filter_Chest.ForeColor = System.Drawing.Color.White;
            this.cuiCheckbox_Filter_Chest.Location = new System.Drawing.Point(21, 4);
            this.cuiCheckbox_Filter_Chest.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_Filter_Chest.Name = "cuiCheckbox_Filter_Chest";
            this.cuiCheckbox_Filter_Chest.OutlineStyle = true;
            this.cuiCheckbox_Filter_Chest.OutlineThickness = 1F;
            this.cuiCheckbox_Filter_Chest.Rounding = 5;
            this.cuiCheckbox_Filter_Chest.ShowSymbols = true;
            this.cuiCheckbox_Filter_Chest.Size = new System.Drawing.Size(121, 25);
            this.cuiCheckbox_Filter_Chest.TabIndex = 12;
            this.cuiCheckbox_Filter_Chest.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Chest.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_Filter_Chest.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cuiGradientBorder_Exercises
            // 
            this.cuiGradientBorder_Exercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_Exercises.GradientAngle = -90F;
            this.cuiGradientBorder_Exercises.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_Exercises.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Exercises.Name = "cuiGradientBorder_Exercises";
            this.cuiGradientBorder_Exercises.OutlineThickness = 0F;
            this.cuiGradientBorder_Exercises.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Exercises.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_Exercises.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Exercises.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Exercises.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Exercises.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_Exercises.TabIndex = 8;
            // 
            // panel_Exercises_Title
            // 
            this.panel_Exercises_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Exercises_Title.Controls.Add(this.label_AddExercises_Count);
            this.panel_Exercises_Title.Controls.Add(this.label_AddExercises_Title);
            this.panel_Exercises_Title.Controls.Add(this.cuiButton_AddExercises_Exit);
            this.panel_Exercises_Title.Controls.Add(this.label_Exercises_Count);
            this.panel_Exercises_Title.Controls.Add(this.panel_Exercises_Search);
            this.panel_Exercises_Title.Controls.Add(this.cuiButton_Exercises_Search);
            this.panel_Exercises_Title.Controls.Add(this.cuiButton_Exercises_Filter);
            this.panel_Exercises_Title.Controls.Add(this.label_Exercises_Title);
            this.panel_Exercises_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Exercises_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Exercises_Title.Name = "panel_Exercises_Title";
            this.panel_Exercises_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_Exercises_Title.TabIndex = 7;
            // 
            // label_Exercises_Count
            // 
            this.label_Exercises_Count.AutoSize = true;
            this.label_Exercises_Count.BackColor = System.Drawing.Color.Transparent;
            this.label_Exercises_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Exercises_Count.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Exercises_Count.ForeColor = System.Drawing.Color.White;
            this.label_Exercises_Count.Location = new System.Drawing.Point(170, 27);
            this.label_Exercises_Count.Name = "label_Exercises_Count";
            this.label_Exercises_Count.Size = new System.Drawing.Size(67, 27);
            this.label_Exercises_Count.TabIndex = 12;
            this.label_Exercises_Count.Text = "(200)";
            this.label_Exercises_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Exercises_Count.Visible = false;
            // 
            // panel_Exercises_Search
            // 
            this.panel_Exercises_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Exercises_Search.Controls.Add(this.cuiTextBox_Exercises_Search);
            this.panel_Exercises_Search.Controls.Add(this.cuiButton_Exercises_GoBack);
            this.panel_Exercises_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Exercises_Search.Location = new System.Drawing.Point(0, 0);
            this.panel_Exercises_Search.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel_Exercises_Search.Name = "panel_Exercises_Search";
            this.panel_Exercises_Search.Size = new System.Drawing.Size(0, 80);
            this.panel_Exercises_Search.TabIndex = 11;
            // 
            // cuiTextBox_Exercises_Search
            // 
            this.cuiTextBox_Exercises_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.cuiTextBox_Exercises_Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.cuiTextBox_Exercises_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.cuiTextBox_Exercises_Search.BorderSize = 1;
            this.cuiTextBox_Exercises_Search.Content = "";
            this.cuiTextBox_Exercises_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Exercises_Search.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.cuiTextBox_Exercises_Search.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.cuiTextBox_Exercises_Search.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Exercises_Search.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Exercises_Search.Location = new System.Drawing.Point(104, 4);
            this.cuiTextBox_Exercises_Search.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTextBox_Exercises_Search.Multiline = false;
            this.cuiTextBox_Exercises_Search.Name = "cuiTextBox_Exercises_Search";
            this.cuiTextBox_Exercises_Search.Padding = new System.Windows.Forms.Padding(27, 23, 27, 0);
            this.cuiTextBox_Exercises_Search.PasswordChar = false;
            this.cuiTextBox_Exercises_Search.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.cuiTextBox_Exercises_Search.PlaceholderText = "Search ";
            this.cuiTextBox_Exercises_Search.Rounding = new System.Windows.Forms.Padding(10);
            this.cuiTextBox_Exercises_Search.Size = new System.Drawing.Size(320, 72);
            this.cuiTextBox_Exercises_Search.TabIndex = 0;
            this.cuiTextBox_Exercises_Search.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Exercises_Search.UnderlinedStyle = false;
            // 
            // cuiButton_Exercises_GoBack
            // 
            this.cuiButton_Exercises_GoBack.CheckButton = false;
            this.cuiButton_Exercises_GoBack.Checked = false;
            this.cuiButton_Exercises_GoBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_GoBack.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_GoBack.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_GoBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_GoBack.Content = "";
            this.cuiButton_Exercises_GoBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Exercises_GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_Exercises_GoBack.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Exercises_GoBack.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_GoBack.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_GoBack.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_Exercises_GoBack.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_GoBack.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_GoBack.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Exercises_GoBack.Image")));
            this.cuiButton_Exercises_GoBack.ImageAutoCenter = true;
            this.cuiButton_Exercises_GoBack.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_Exercises_GoBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Exercises_GoBack.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_Exercises_GoBack.Name = "cuiButton_Exercises_GoBack";
            this.cuiButton_Exercises_GoBack.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_GoBack.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_GoBack.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Exercises_GoBack.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_GoBack.OutlineThickness = 0F;
            this.cuiButton_Exercises_GoBack.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_GoBack.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_GoBack.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_Exercises_GoBack.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_GoBack.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Exercises_GoBack.Size = new System.Drawing.Size(102, 80);
            this.cuiButton_Exercises_GoBack.TabIndex = 10;
            this.cuiButton_Exercises_GoBack.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Exercises_GoBack.Click += new System.EventHandler(this.cuiButton_Exercises_GoBack_Click);
            // 
            // cuiButton_Exercises_Search
            // 
            this.cuiButton_Exercises_Search.CheckButton = false;
            this.cuiButton_Exercises_Search.Checked = false;
            this.cuiButton_Exercises_Search.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_Search.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Search.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Search.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_Search.Content = "";
            this.cuiButton_Exercises_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Exercises_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiButton_Exercises_Search.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Exercises_Search.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Search.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Search.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Exercises_Search.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Search.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Search.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Exercises_Search.Image")));
            this.cuiButton_Exercises_Search.ImageAutoCenter = true;
            this.cuiButton_Exercises_Search.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton_Exercises_Search.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Exercises_Search.Location = new System.Drawing.Point(369, 0);
            this.cuiButton_Exercises_Search.Name = "cuiButton_Exercises_Search";
            this.cuiButton_Exercises_Search.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Search.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Search.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Exercises_Search.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Search.OutlineThickness = 0F;
            this.cuiButton_Exercises_Search.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Search.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Search.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Search.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Search.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Exercises_Search.Size = new System.Drawing.Size(72, 80);
            this.cuiButton_Exercises_Search.TabIndex = 10;
            this.cuiButton_Exercises_Search.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Exercises_Search.Click += new System.EventHandler(this.cuiButton_Exercises_Search_Click);
            // 
            // cuiButton_Exercises_Filter
            // 
            this.cuiButton_Exercises_Filter.CheckButton = false;
            this.cuiButton_Exercises_Filter.Checked = false;
            this.cuiButton_Exercises_Filter.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_Filter.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Filter.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Filter.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Exercises_Filter.Content = "";
            this.cuiButton_Exercises_Filter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Exercises_Filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiButton_Exercises_Filter.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Exercises_Filter.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Filter.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Filter.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Exercises_Filter.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Filter.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Filter.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Exercises_Filter.Image")));
            this.cuiButton_Exercises_Filter.ImageAutoCenter = true;
            this.cuiButton_Exercises_Filter.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton_Exercises_Filter.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cuiButton_Exercises_Filter.Location = new System.Drawing.Point(441, 0);
            this.cuiButton_Exercises_Filter.Name = "cuiButton_Exercises_Filter";
            this.cuiButton_Exercises_Filter.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Filter.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Exercises_Filter.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Exercises_Filter.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Filter.OutlineThickness = 0F;
            this.cuiButton_Exercises_Filter.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Exercises_Filter.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Filter.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Exercises_Filter.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Exercises_Filter.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Exercises_Filter.Size = new System.Drawing.Size(72, 80);
            this.cuiButton_Exercises_Filter.TabIndex = 9;
            this.cuiButton_Exercises_Filter.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Exercises_Filter.Click += new System.EventHandler(this.cuiButton_Exercises_Filter_Click);
            // 
            // label_Exercises_Title
            // 
            this.label_Exercises_Title.AutoSize = true;
            this.label_Exercises_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Exercises_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Exercises_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Exercises_Title.ForeColor = System.Drawing.Color.White;
            this.label_Exercises_Title.Location = new System.Drawing.Point(27, 27);
            this.label_Exercises_Title.Name = "label_Exercises_Title";
            this.label_Exercises_Title.Size = new System.Drawing.Size(120, 27);
            this.label_Exercises_Title.TabIndex = 7;
            this.label_Exercises_Title.Text = "Exercises";
            this.label_Exercises_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Exercises_Title.Visible = false;
            // 
            // flowLayoutPanel_Exercises
            // 
            this.flowLayoutPanel_Exercises.AutoScroll = true;
            this.flowLayoutPanel_Exercises.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Exercises.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanel_Exercises.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Exercises.Name = "flowLayoutPanel_Exercises";
            this.flowLayoutPanel_Exercises.Size = new System.Drawing.Size(513, 566);
            this.flowLayoutPanel_Exercises.TabIndex = 6;
            // 
            // panel_Menu_Workout
            // 
            this.panel_Menu_Workout.Controls.Add(this.cuiGradientBorder_Workout);
            this.panel_Menu_Workout.Controls.Add(this.panel_Workout_Title);
            this.panel_Menu_Workout.Controls.Add(this.flowLayoutPanel_Workout);
            this.panel_Menu_Workout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menu_Workout.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_Workout.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu_Workout.Name = "panel_Menu_Workout";
            this.panel_Menu_Workout.Size = new System.Drawing.Size(513, 0);
            this.panel_Menu_Workout.TabIndex = 21;
            // 
            // cuiGradientBorder_Workout
            // 
            this.cuiGradientBorder_Workout.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_Workout.GradientAngle = -90F;
            this.cuiGradientBorder_Workout.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_Workout.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Workout.Name = "cuiGradientBorder_Workout";
            this.cuiGradientBorder_Workout.OutlineThickness = 0F;
            this.cuiGradientBorder_Workout.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Workout.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_Workout.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Workout.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Workout.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Workout.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_Workout.TabIndex = 8;
            // 
            // panel_Workout_Title
            // 
            this.panel_Workout_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Workout_Title.Controls.Add(this.label_Workout_Title);
            this.panel_Workout_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Workout_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Workout_Title.Name = "panel_Workout_Title";
            this.panel_Workout_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_Workout_Title.TabIndex = 7;
            // 
            // label_Workout_Title
            // 
            this.label_Workout_Title.AutoSize = true;
            this.label_Workout_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Workout_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Workout_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Workout_Title.ForeColor = System.Drawing.Color.White;
            this.label_Workout_Title.Location = new System.Drawing.Point(27, 27);
            this.label_Workout_Title.Name = "label_Workout_Title";
            this.label_Workout_Title.Size = new System.Drawing.Size(106, 27);
            this.label_Workout_Title.TabIndex = 7;
            this.label_Workout_Title.Text = "Workout";
            this.label_Workout_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Workout
            // 
            this.flowLayoutPanel_Workout.AutoScroll = true;
            this.flowLayoutPanel_Workout.Controls.Add(this.panel_Workout_QuickStart);
            this.flowLayoutPanel_Workout.Controls.Add(this.label_Workout_EmptyTemplateMsg);
            this.flowLayoutPanel_Workout.Controls.Add(this.label_Workout_SampleTemplates);
            this.flowLayoutPanel_Workout.Controls.Add(this.cuiButton2);
            this.flowLayoutPanel_Workout.Controls.Add(this.cuiButton1);
            this.flowLayoutPanel_Workout.Controls.Add(this.cuiButton3);
            this.flowLayoutPanel_Workout.Controls.Add(this.cuiButton4);
            this.flowLayoutPanel_Workout.Controls.Add(this.cuiButton5);
            this.flowLayoutPanel_Workout.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel_Workout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Workout.Location = new System.Drawing.Point(0, -571);
            this.flowLayoutPanel_Workout.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Workout.Name = "flowLayoutPanel_Workout";
            this.flowLayoutPanel_Workout.Size = new System.Drawing.Size(513, 571);
            this.flowLayoutPanel_Workout.TabIndex = 6;
            // 
            // panel_Workout_QuickStart
            // 
            this.panel_Workout_QuickStart.Controls.Add(this.cuiButton_Workout_AddTemplate);
            this.panel_Workout_QuickStart.Controls.Add(this.label_Workout_MyTemplates);
            this.panel_Workout_QuickStart.Controls.Add(this.cuiButton_Workout_QuickStart);
            this.panel_Workout_QuickStart.Controls.Add(this.label_Workout_QuickStart);
            this.panel_Workout_QuickStart.Location = new System.Drawing.Point(0, 0);
            this.panel_Workout_QuickStart.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Workout_QuickStart.Name = "panel_Workout_QuickStart";
            this.panel_Workout_QuickStart.Size = new System.Drawing.Size(488, 190);
            this.panel_Workout_QuickStart.TabIndex = 0;
            // 
            // cuiButton_Workout_AddTemplate
            // 
            this.cuiButton_Workout_AddTemplate.CheckButton = false;
            this.cuiButton_Workout_AddTemplate.Checked = false;
            this.cuiButton_Workout_AddTemplate.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Workout_AddTemplate.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Workout_AddTemplate.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Workout_AddTemplate.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Workout_AddTemplate.Content = "";
            this.cuiButton_Workout_AddTemplate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Workout_AddTemplate.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Workout_AddTemplate.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_AddTemplate.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Workout_AddTemplate.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_Workout_AddTemplate.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_AddTemplate.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_AddTemplate.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_Workout_AddTemplate.Image")));
            this.cuiButton_Workout_AddTemplate.ImageAutoCenter = true;
            this.cuiButton_Workout_AddTemplate.ImageExpand = new System.Drawing.Point(2, 2);
            this.cuiButton_Workout_AddTemplate.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Workout_AddTemplate.Location = new System.Drawing.Point(420, 144);
            this.cuiButton_Workout_AddTemplate.Name = "cuiButton_Workout_AddTemplate";
            this.cuiButton_Workout_AddTemplate.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Workout_AddTemplate.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_AddTemplate.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Workout_AddTemplate.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_AddTemplate.OutlineThickness = 0F;
            this.cuiButton_Workout_AddTemplate.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Workout_AddTemplate.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_AddTemplate.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_Workout_AddTemplate.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_AddTemplate.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_Workout_AddTemplate.Size = new System.Drawing.Size(43, 41);
            this.cuiButton_Workout_AddTemplate.TabIndex = 15;
            this.cuiButton_Workout_AddTemplate.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_Workout_AddTemplate.Click += new System.EventHandler(this.cuiButton_Workout_AddTemplate_Click);
            // 
            // label_Workout_MyTemplates
            // 
            this.label_Workout_MyTemplates.AutoSize = true;
            this.label_Workout_MyTemplates.BackColor = System.Drawing.Color.Transparent;
            this.label_Workout_MyTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Workout_MyTemplates.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Workout_MyTemplates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Workout_MyTemplates.Location = new System.Drawing.Point(20, 150);
            this.label_Workout_MyTemplates.Name = "label_Workout_MyTemplates";
            this.label_Workout_MyTemplates.Size = new System.Drawing.Size(122, 17);
            this.label_Workout_MyTemplates.TabIndex = 14;
            this.label_Workout_MyTemplates.Text = "MY TEMPLATES";
            this.label_Workout_MyTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiButton_Workout_QuickStart
            // 
            this.cuiButton_Workout_QuickStart.CheckButton = false;
            this.cuiButton_Workout_QuickStart.Checked = false;
            this.cuiButton_Workout_QuickStart.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Workout_QuickStart.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Workout_QuickStart.Content = "START AN EMPTY WORKOUT";
            this.cuiButton_Workout_QuickStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Workout_QuickStart.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Workout_QuickStart.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.cuiButton_Workout_QuickStart.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_QuickStart.Image = null;
            this.cuiButton_Workout_QuickStart.ImageAutoCenter = true;
            this.cuiButton_Workout_QuickStart.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Workout_QuickStart.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Workout_QuickStart.Location = new System.Drawing.Point(23, 61);
            this.cuiButton_Workout_QuickStart.Name = "cuiButton_Workout_QuickStart";
            this.cuiButton_Workout_QuickStart.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Workout_QuickStart.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_QuickStart.OutlineThickness = 1.6F;
            this.cuiButton_Workout_QuickStart.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_Workout_QuickStart.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Workout_QuickStart.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Workout_QuickStart.Rounding = new System.Windows.Forms.Padding(5);
            this.cuiButton_Workout_QuickStart.Size = new System.Drawing.Size(438, 54);
            this.cuiButton_Workout_QuickStart.TabIndex = 13;
            this.cuiButton_Workout_QuickStart.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label_Workout_QuickStart
            // 
            this.label_Workout_QuickStart.AutoSize = true;
            this.label_Workout_QuickStart.BackColor = System.Drawing.Color.Transparent;
            this.label_Workout_QuickStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Workout_QuickStart.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Workout_QuickStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Workout_QuickStart.Location = new System.Drawing.Point(20, 19);
            this.label_Workout_QuickStart.Name = "label_Workout_QuickStart";
            this.label_Workout_QuickStart.Size = new System.Drawing.Size(109, 17);
            this.label_Workout_QuickStart.TabIndex = 12;
            this.label_Workout_QuickStart.Text = "QUICK START";
            this.label_Workout_QuickStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Workout_EmptyTemplateMsg
            // 
            this.label_Workout_EmptyTemplateMsg.AutoSize = true;
            this.label_Workout_EmptyTemplateMsg.BackColor = System.Drawing.Color.Transparent;
            this.label_Workout_EmptyTemplateMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Workout_EmptyTemplateMsg.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Workout_EmptyTemplateMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Workout_EmptyTemplateMsg.Location = new System.Drawing.Point(20, 200);
            this.label_Workout_EmptyTemplateMsg.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.label_Workout_EmptyTemplateMsg.Name = "label_Workout_EmptyTemplateMsg";
            this.label_Workout_EmptyTemplateMsg.Size = new System.Drawing.Size(424, 46);
            this.label_Workout_EmptyTemplateMsg.TabIndex = 16;
            this.label_Workout_EmptyTemplateMsg.Text = "You don\'t have any custom templates yet.\r\nTap the \'+\' button to create your first" +
    " template!\r\n";
            this.label_Workout_EmptyTemplateMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Workout_SampleTemplates
            // 
            this.label_Workout_SampleTemplates.AutoSize = true;
            this.label_Workout_SampleTemplates.BackColor = System.Drawing.Color.Transparent;
            this.label_Workout_SampleTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Workout_SampleTemplates.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Workout_SampleTemplates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Workout_SampleTemplates.Location = new System.Drawing.Point(20, 273);
            this.label_Workout_SampleTemplates.Margin = new System.Windows.Forms.Padding(20, 27, 3, 0);
            this.label_Workout_SampleTemplates.Name = "label_Workout_SampleTemplates";
            this.label_Workout_SampleTemplates.Size = new System.Drawing.Size(160, 17);
            this.label_Workout_SampleTemplates.TabIndex = 15;
            this.label_Workout_SampleTemplates.Text = "SAMPLE TEMPLATES";
            this.label_Workout_SampleTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton2.Content = "Legs";
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton2.ForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = false;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(20, 310);
            this.cuiButton2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 4);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton2.OutlineThickness = 1.5F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton2.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(447, 90);
            this.cuiButton2.TabIndex = 20;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton1.Content = "Chest and Triceps";
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = false;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(20, 424);
            this.cuiButton1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 4);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton1.OutlineThickness = 1.5F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton1.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(447, 90);
            this.cuiButton1.TabIndex = 21;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton3.Content = "Back and Biceps";
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton3.ForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = false;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(20, 538);
            this.cuiButton3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 4);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton3.OutlineThickness = 1.5F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton3.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(447, 90);
            this.cuiButton3.TabIndex = 22;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton4
            // 
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton4.Content = "Workout A";
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton4.ForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = false;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Location = new System.Drawing.Point(20, 652);
            this.cuiButton4.Margin = new System.Windows.Forms.Padding(20, 20, 20, 4);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton4.OutlineThickness = 1.5F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton4.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton4.Size = new System.Drawing.Size(447, 90);
            this.cuiButton4.TabIndex = 23;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton5
            // 
            this.cuiButton5.CheckButton = false;
            this.cuiButton5.Checked = false;
            this.cuiButton5.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton5.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton5.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton5.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton5.Content = "Workout B";
            this.cuiButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton5.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton5.ForeColor = System.Drawing.Color.White;
            this.cuiButton5.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton5.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton5.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton5.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton5.Image = null;
            this.cuiButton5.ImageAutoCenter = false;
            this.cuiButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.Location = new System.Drawing.Point(20, 766);
            this.cuiButton5.Margin = new System.Windows.Forms.Padding(20, 20, 20, 4);
            this.cuiButton5.Name = "cuiButton5";
            this.cuiButton5.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton5.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton5.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton5.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton5.OutlineThickness = 1.5F;
            this.cuiButton5.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton5.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton5.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton5.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.cuiButton5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton5.Size = new System.Drawing.Size(447, 90);
            this.cuiButton5.TabIndex = 24;
            this.cuiButton5.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // panel_Menu_Measure
            // 
            this.panel_Menu_Measure.Controls.Add(this.cuiGradientBorder_Measure);
            this.panel_Menu_Measure.Controls.Add(this.panel_Measure_Title);
            this.panel_Menu_Measure.Controls.Add(this.flowLayoutPanel_Measure);
            this.panel_Menu_Measure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Menu_Measure.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_Measure.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu_Measure.Name = "panel_Menu_Measure";
            this.panel_Menu_Measure.Size = new System.Drawing.Size(513, 0);
            this.panel_Menu_Measure.TabIndex = 22;
            // 
            // cuiGradientBorder_Measure
            // 
            this.cuiGradientBorder_Measure.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_Measure.GradientAngle = -90F;
            this.cuiGradientBorder_Measure.Location = new System.Drawing.Point(0, 80);
            this.cuiGradientBorder_Measure.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_Measure.Name = "cuiGradientBorder_Measure";
            this.cuiGradientBorder_Measure.OutlineThickness = 0F;
            this.cuiGradientBorder_Measure.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measure.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_Measure.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measure.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_Measure.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Measure.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_Measure.TabIndex = 8;
            // 
            // panel_Measure_Title
            // 
            this.panel_Measure_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_Measure_Title.Controls.Add(this.label_Measure_Title);
            this.panel_Measure_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Measure_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Measure_Title.Name = "panel_Measure_Title";
            this.panel_Measure_Title.Size = new System.Drawing.Size(513, 80);
            this.panel_Measure_Title.TabIndex = 7;
            // 
            // label_Measure_Title
            // 
            this.label_Measure_Title.AutoSize = true;
            this.label_Measure_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Measure_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Measure_Title.ForeColor = System.Drawing.Color.White;
            this.label_Measure_Title.Location = new System.Drawing.Point(27, 27);
            this.label_Measure_Title.Name = "label_Measure_Title";
            this.label_Measure_Title.Size = new System.Drawing.Size(106, 27);
            this.label_Measure_Title.TabIndex = 7;
            this.label_Measure_Title.Text = "Measure";
            this.label_Measure_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Measure
            // 
            this.flowLayoutPanel_Measure.AutoScroll = true;
            this.flowLayoutPanel_Measure.Controls.Add(this.label_Measurement_Core);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Weight);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_BodyFatPercentage);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_CaloricIntake);
            this.flowLayoutPanel_Measure.Controls.Add(this.label_Measurement_BodyPart);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Neck);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Shoulders);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Chest);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_LeftBicep);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_RightBicep);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_LeftForearm);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_RightForearm);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_UpperAbs);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Waist);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_LowerAbs);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_Hips);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_LeftThigh);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_RightThigh);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_LeftCalf);
            this.flowLayoutPanel_Measure.Controls.Add(this.cuiButton_Measure_RightCalf);
            this.flowLayoutPanel_Measure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Measure.Location = new System.Drawing.Point(0, -566);
            this.flowLayoutPanel_Measure.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Measure.Name = "flowLayoutPanel_Measure";
            this.flowLayoutPanel_Measure.Size = new System.Drawing.Size(513, 566);
            this.flowLayoutPanel_Measure.TabIndex = 6;
            // 
            // label_Measurement_Core
            // 
            this.label_Measurement_Core.AutoSize = true;
            this.label_Measurement_Core.BackColor = System.Drawing.Color.Transparent;
            this.label_Measurement_Core.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measurement_Core.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Measurement_Core.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Measurement_Core.Location = new System.Drawing.Point(22, 14);
            this.label_Measurement_Core.Margin = new System.Windows.Forms.Padding(22, 14, 0, 0);
            this.label_Measurement_Core.Name = "label_Measurement_Core";
            this.label_Measurement_Core.Size = new System.Drawing.Size(52, 17);
            this.label_Measurement_Core.TabIndex = 12;
            this.label_Measurement_Core.Text = "CORE";
            this.label_Measurement_Core.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiButton_Measure_Weight
            // 
            this.cuiButton_Measure_Weight.CheckButton = false;
            this.cuiButton_Measure_Weight.Checked = false;
            this.cuiButton_Measure_Weight.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Weight.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Weight.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Weight.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Weight.Content = "Weight";
            this.cuiButton_Measure_Weight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Weight.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Weight.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Weight.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Weight.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Weight.Image = null;
            this.cuiButton_Measure_Weight.ImageAutoCenter = false;
            this.cuiButton_Measure_Weight.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Weight.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Weight.Location = new System.Drawing.Point(3, 48);
            this.cuiButton_Measure_Weight.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.cuiButton_Measure_Weight.Name = "cuiButton_Measure_Weight";
            this.cuiButton_Measure_Weight.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Weight.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Weight.OutlineThickness = 0F;
            this.cuiButton_Measure_Weight.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Weight.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Weight.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Weight.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Weight.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Weight.TabIndex = 13;
            this.cuiButton_Measure_Weight.TextOffset = new System.Drawing.Point(-134, 1);
            // 
            // cuiButton_Measure_BodyFatPercentage
            // 
            this.cuiButton_Measure_BodyFatPercentage.CheckButton = false;
            this.cuiButton_Measure_BodyFatPercentage.Checked = false;
            this.cuiButton_Measure_BodyFatPercentage.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_BodyFatPercentage.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_BodyFatPercentage.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_BodyFatPercentage.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_BodyFatPercentage.Content = "Body fat percentage";
            this.cuiButton_Measure_BodyFatPercentage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_BodyFatPercentage.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_BodyFatPercentage.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_BodyFatPercentage.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_BodyFatPercentage.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_BodyFatPercentage.Image = null;
            this.cuiButton_Measure_BodyFatPercentage.ImageAutoCenter = false;
            this.cuiButton_Measure_BodyFatPercentage.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_BodyFatPercentage.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_BodyFatPercentage.Location = new System.Drawing.Point(3, 143);
            this.cuiButton_Measure_BodyFatPercentage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_BodyFatPercentage.Name = "cuiButton_Measure_BodyFatPercentage";
            this.cuiButton_Measure_BodyFatPercentage.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_BodyFatPercentage.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_BodyFatPercentage.OutlineThickness = 0F;
            this.cuiButton_Measure_BodyFatPercentage.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_BodyFatPercentage.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_BodyFatPercentage.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_BodyFatPercentage.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_BodyFatPercentage.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_BodyFatPercentage.TabIndex = 14;
            this.cuiButton_Measure_BodyFatPercentage.TextOffset = new System.Drawing.Point(-75, 1);
            // 
            // cuiButton_Measure_CaloricIntake
            // 
            this.cuiButton_Measure_CaloricIntake.CheckButton = false;
            this.cuiButton_Measure_CaloricIntake.Checked = false;
            this.cuiButton_Measure_CaloricIntake.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_CaloricIntake.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_CaloricIntake.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_CaloricIntake.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_CaloricIntake.Content = "Caloric intake";
            this.cuiButton_Measure_CaloricIntake.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_CaloricIntake.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_CaloricIntake.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_CaloricIntake.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_CaloricIntake.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_CaloricIntake.Image = null;
            this.cuiButton_Measure_CaloricIntake.ImageAutoCenter = false;
            this.cuiButton_Measure_CaloricIntake.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_CaloricIntake.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_CaloricIntake.Location = new System.Drawing.Point(3, 238);
            this.cuiButton_Measure_CaloricIntake.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_CaloricIntake.Name = "cuiButton_Measure_CaloricIntake";
            this.cuiButton_Measure_CaloricIntake.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_CaloricIntake.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_CaloricIntake.OutlineThickness = 0F;
            this.cuiButton_Measure_CaloricIntake.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_CaloricIntake.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_CaloricIntake.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_CaloricIntake.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_CaloricIntake.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_CaloricIntake.TabIndex = 15;
            this.cuiButton_Measure_CaloricIntake.TextOffset = new System.Drawing.Point(-103, 1);
            // 
            // label_Measurement_BodyPart
            // 
            this.label_Measurement_BodyPart.AutoSize = true;
            this.label_Measurement_BodyPart.BackColor = System.Drawing.Color.Transparent;
            this.label_Measurement_BodyPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measurement_BodyPart.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Measurement_BodyPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.label_Measurement_BodyPart.Location = new System.Drawing.Point(22, 359);
            this.label_Measurement_BodyPart.Margin = new System.Windows.Forms.Padding(22, 26, 0, 0);
            this.label_Measurement_BodyPart.Name = "label_Measurement_BodyPart";
            this.label_Measurement_BodyPart.Size = new System.Drawing.Size(95, 17);
            this.label_Measurement_BodyPart.TabIndex = 16;
            this.label_Measurement_BodyPart.Text = "BODY PART";
            this.label_Measurement_BodyPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiButton_Measure_Neck
            // 
            this.cuiButton_Measure_Neck.CheckButton = false;
            this.cuiButton_Measure_Neck.Checked = false;
            this.cuiButton_Measure_Neck.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Neck.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Neck.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Neck.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Neck.Content = "Neck";
            this.cuiButton_Measure_Neck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Neck.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Neck.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Neck.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Neck.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Neck.Image = null;
            this.cuiButton_Measure_Neck.ImageAutoCenter = false;
            this.cuiButton_Measure_Neck.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Neck.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Neck.Location = new System.Drawing.Point(3, 393);
            this.cuiButton_Measure_Neck.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.cuiButton_Measure_Neck.Name = "cuiButton_Measure_Neck";
            this.cuiButton_Measure_Neck.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Neck.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Neck.OutlineThickness = 0F;
            this.cuiButton_Measure_Neck.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Neck.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Neck.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Neck.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Neck.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Neck.TabIndex = 17;
            this.cuiButton_Measure_Neck.TextOffset = new System.Drawing.Point(-143, 1);
            // 
            // cuiButton_Measure_Shoulders
            // 
            this.cuiButton_Measure_Shoulders.CheckButton = false;
            this.cuiButton_Measure_Shoulders.Checked = false;
            this.cuiButton_Measure_Shoulders.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Shoulders.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Shoulders.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Shoulders.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Shoulders.Content = "Shoulders";
            this.cuiButton_Measure_Shoulders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Shoulders.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Shoulders.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Shoulders.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Shoulders.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Shoulders.Image = null;
            this.cuiButton_Measure_Shoulders.ImageAutoCenter = false;
            this.cuiButton_Measure_Shoulders.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Shoulders.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Shoulders.Location = new System.Drawing.Point(3, 488);
            this.cuiButton_Measure_Shoulders.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_Shoulders.Name = "cuiButton_Measure_Shoulders";
            this.cuiButton_Measure_Shoulders.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Shoulders.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Shoulders.OutlineThickness = 0F;
            this.cuiButton_Measure_Shoulders.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Shoulders.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Shoulders.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Shoulders.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Shoulders.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Shoulders.TabIndex = 18;
            this.cuiButton_Measure_Shoulders.TextOffset = new System.Drawing.Point(-120, 1);
            // 
            // cuiButton_Measure_Chest
            // 
            this.cuiButton_Measure_Chest.CheckButton = false;
            this.cuiButton_Measure_Chest.Checked = false;
            this.cuiButton_Measure_Chest.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Chest.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Chest.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Chest.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Chest.Content = "Chest";
            this.cuiButton_Measure_Chest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Chest.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Chest.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Chest.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Chest.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Chest.Image = null;
            this.cuiButton_Measure_Chest.ImageAutoCenter = false;
            this.cuiButton_Measure_Chest.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Chest.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Chest.Location = new System.Drawing.Point(3, 583);
            this.cuiButton_Measure_Chest.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_Chest.Name = "cuiButton_Measure_Chest";
            this.cuiButton_Measure_Chest.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Chest.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Chest.OutlineThickness = 0F;
            this.cuiButton_Measure_Chest.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Chest.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Chest.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Chest.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Chest.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Chest.TabIndex = 19;
            this.cuiButton_Measure_Chest.TextOffset = new System.Drawing.Point(-140, 1);
            // 
            // cuiButton_Measure_LeftBicep
            // 
            this.cuiButton_Measure_LeftBicep.CheckButton = false;
            this.cuiButton_Measure_LeftBicep.Checked = false;
            this.cuiButton_Measure_LeftBicep.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftBicep.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftBicep.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftBicep.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftBicep.Content = "Left bicep";
            this.cuiButton_Measure_LeftBicep.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_LeftBicep.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_LeftBicep.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftBicep.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_LeftBicep.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftBicep.Image = null;
            this.cuiButton_Measure_LeftBicep.ImageAutoCenter = false;
            this.cuiButton_Measure_LeftBicep.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftBicep.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftBicep.Location = new System.Drawing.Point(3, 678);
            this.cuiButton_Measure_LeftBicep.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_LeftBicep.Name = "cuiButton_Measure_LeftBicep";
            this.cuiButton_Measure_LeftBicep.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftBicep.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftBicep.OutlineThickness = 0F;
            this.cuiButton_Measure_LeftBicep.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_LeftBicep.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftBicep.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftBicep.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_LeftBicep.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_LeftBicep.TabIndex = 20;
            this.cuiButton_Measure_LeftBicep.TextOffset = new System.Drawing.Point(-122, 1);
            // 
            // cuiButton_Measure_RightBicep
            // 
            this.cuiButton_Measure_RightBicep.CheckButton = false;
            this.cuiButton_Measure_RightBicep.Checked = false;
            this.cuiButton_Measure_RightBicep.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightBicep.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightBicep.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightBicep.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightBicep.Content = "Right bicep";
            this.cuiButton_Measure_RightBicep.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_RightBicep.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_RightBicep.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightBicep.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_RightBicep.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightBicep.Image = null;
            this.cuiButton_Measure_RightBicep.ImageAutoCenter = false;
            this.cuiButton_Measure_RightBicep.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightBicep.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightBicep.Location = new System.Drawing.Point(3, 773);
            this.cuiButton_Measure_RightBicep.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_RightBicep.Name = "cuiButton_Measure_RightBicep";
            this.cuiButton_Measure_RightBicep.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightBicep.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightBicep.OutlineThickness = 0F;
            this.cuiButton_Measure_RightBicep.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_RightBicep.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightBicep.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightBicep.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_RightBicep.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_RightBicep.TabIndex = 21;
            this.cuiButton_Measure_RightBicep.TextOffset = new System.Drawing.Point(-115, 1);
            // 
            // cuiButton_Measure_LeftForearm
            // 
            this.cuiButton_Measure_LeftForearm.CheckButton = false;
            this.cuiButton_Measure_LeftForearm.Checked = false;
            this.cuiButton_Measure_LeftForearm.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftForearm.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftForearm.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftForearm.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftForearm.Content = "Left forearm";
            this.cuiButton_Measure_LeftForearm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_LeftForearm.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_LeftForearm.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftForearm.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_LeftForearm.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftForearm.Image = null;
            this.cuiButton_Measure_LeftForearm.ImageAutoCenter = false;
            this.cuiButton_Measure_LeftForearm.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftForearm.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftForearm.Location = new System.Drawing.Point(3, 868);
            this.cuiButton_Measure_LeftForearm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_LeftForearm.Name = "cuiButton_Measure_LeftForearm";
            this.cuiButton_Measure_LeftForearm.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftForearm.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftForearm.OutlineThickness = 0F;
            this.cuiButton_Measure_LeftForearm.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_LeftForearm.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftForearm.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftForearm.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_LeftForearm.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_LeftForearm.TabIndex = 22;
            this.cuiButton_Measure_LeftForearm.TextOffset = new System.Drawing.Point(-111, 1);
            // 
            // cuiButton_Measure_RightForearm
            // 
            this.cuiButton_Measure_RightForearm.CheckButton = false;
            this.cuiButton_Measure_RightForearm.Checked = false;
            this.cuiButton_Measure_RightForearm.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightForearm.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightForearm.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightForearm.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightForearm.Content = "Right forearm";
            this.cuiButton_Measure_RightForearm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_RightForearm.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_RightForearm.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightForearm.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_RightForearm.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightForearm.Image = null;
            this.cuiButton_Measure_RightForearm.ImageAutoCenter = false;
            this.cuiButton_Measure_RightForearm.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightForearm.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightForearm.Location = new System.Drawing.Point(3, 963);
            this.cuiButton_Measure_RightForearm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_RightForearm.Name = "cuiButton_Measure_RightForearm";
            this.cuiButton_Measure_RightForearm.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightForearm.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightForearm.OutlineThickness = 0F;
            this.cuiButton_Measure_RightForearm.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_RightForearm.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightForearm.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightForearm.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_RightForearm.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_RightForearm.TabIndex = 23;
            this.cuiButton_Measure_RightForearm.TextOffset = new System.Drawing.Point(-104, 1);
            // 
            // cuiButton_Measure_UpperAbs
            // 
            this.cuiButton_Measure_UpperAbs.CheckButton = false;
            this.cuiButton_Measure_UpperAbs.Checked = false;
            this.cuiButton_Measure_UpperAbs.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_UpperAbs.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_UpperAbs.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_UpperAbs.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_UpperAbs.Content = "Upper abs";
            this.cuiButton_Measure_UpperAbs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_UpperAbs.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_UpperAbs.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_UpperAbs.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_UpperAbs.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_UpperAbs.Image = null;
            this.cuiButton_Measure_UpperAbs.ImageAutoCenter = false;
            this.cuiButton_Measure_UpperAbs.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_UpperAbs.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_UpperAbs.Location = new System.Drawing.Point(3, 1058);
            this.cuiButton_Measure_UpperAbs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_UpperAbs.Name = "cuiButton_Measure_UpperAbs";
            this.cuiButton_Measure_UpperAbs.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_UpperAbs.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_UpperAbs.OutlineThickness = 0F;
            this.cuiButton_Measure_UpperAbs.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_UpperAbs.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_UpperAbs.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_UpperAbs.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_UpperAbs.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_UpperAbs.TabIndex = 24;
            this.cuiButton_Measure_UpperAbs.TextOffset = new System.Drawing.Point(-120, 1);
            // 
            // cuiButton_Measure_Waist
            // 
            this.cuiButton_Measure_Waist.CheckButton = false;
            this.cuiButton_Measure_Waist.Checked = false;
            this.cuiButton_Measure_Waist.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Waist.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Waist.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Waist.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Waist.Content = "Waist";
            this.cuiButton_Measure_Waist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Waist.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Waist.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Waist.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Waist.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Waist.Image = null;
            this.cuiButton_Measure_Waist.ImageAutoCenter = false;
            this.cuiButton_Measure_Waist.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Waist.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Waist.Location = new System.Drawing.Point(3, 1153);
            this.cuiButton_Measure_Waist.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_Waist.Name = "cuiButton_Measure_Waist";
            this.cuiButton_Measure_Waist.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Waist.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Waist.OutlineThickness = 0F;
            this.cuiButton_Measure_Waist.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Waist.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Waist.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Waist.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Waist.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Waist.TabIndex = 25;
            this.cuiButton_Measure_Waist.TextOffset = new System.Drawing.Point(-140, 1);
            // 
            // cuiButton_Measure_LowerAbs
            // 
            this.cuiButton_Measure_LowerAbs.CheckButton = false;
            this.cuiButton_Measure_LowerAbs.Checked = false;
            this.cuiButton_Measure_LowerAbs.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LowerAbs.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LowerAbs.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LowerAbs.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LowerAbs.Content = "Lower abs";
            this.cuiButton_Measure_LowerAbs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_LowerAbs.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_LowerAbs.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LowerAbs.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_LowerAbs.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LowerAbs.Image = null;
            this.cuiButton_Measure_LowerAbs.ImageAutoCenter = false;
            this.cuiButton_Measure_LowerAbs.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LowerAbs.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LowerAbs.Location = new System.Drawing.Point(3, 1248);
            this.cuiButton_Measure_LowerAbs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_LowerAbs.Name = "cuiButton_Measure_LowerAbs";
            this.cuiButton_Measure_LowerAbs.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LowerAbs.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LowerAbs.OutlineThickness = 0F;
            this.cuiButton_Measure_LowerAbs.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_LowerAbs.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LowerAbs.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LowerAbs.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_LowerAbs.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_LowerAbs.TabIndex = 26;
            this.cuiButton_Measure_LowerAbs.TextOffset = new System.Drawing.Point(-120, 1);
            // 
            // cuiButton_Measure_Hips
            // 
            this.cuiButton_Measure_Hips.CheckButton = false;
            this.cuiButton_Measure_Hips.Checked = false;
            this.cuiButton_Measure_Hips.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Hips.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Hips.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_Hips.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_Hips.Content = "Hips";
            this.cuiButton_Measure_Hips.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_Hips.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_Hips.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Hips.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_Hips.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Hips.Image = null;
            this.cuiButton_Measure_Hips.ImageAutoCenter = false;
            this.cuiButton_Measure_Hips.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Hips.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_Hips.Location = new System.Drawing.Point(3, 1343);
            this.cuiButton_Measure_Hips.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_Hips.Name = "cuiButton_Measure_Hips";
            this.cuiButton_Measure_Hips.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_Hips.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Hips.OutlineThickness = 0F;
            this.cuiButton_Measure_Hips.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_Hips.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_Hips.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_Hips.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_Hips.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_Hips.TabIndex = 27;
            this.cuiButton_Measure_Hips.TextOffset = new System.Drawing.Point(-146, 1);
            // 
            // cuiButton_Measure_LeftThigh
            // 
            this.cuiButton_Measure_LeftThigh.CheckButton = false;
            this.cuiButton_Measure_LeftThigh.Checked = false;
            this.cuiButton_Measure_LeftThigh.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftThigh.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftThigh.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftThigh.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftThigh.Content = "Left thigh";
            this.cuiButton_Measure_LeftThigh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_LeftThigh.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_LeftThigh.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftThigh.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_LeftThigh.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftThigh.Image = null;
            this.cuiButton_Measure_LeftThigh.ImageAutoCenter = false;
            this.cuiButton_Measure_LeftThigh.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftThigh.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftThigh.Location = new System.Drawing.Point(3, 1438);
            this.cuiButton_Measure_LeftThigh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_LeftThigh.Name = "cuiButton_Measure_LeftThigh";
            this.cuiButton_Measure_LeftThigh.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftThigh.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftThigh.OutlineThickness = 0F;
            this.cuiButton_Measure_LeftThigh.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_LeftThigh.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftThigh.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftThigh.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_LeftThigh.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_LeftThigh.TabIndex = 28;
            this.cuiButton_Measure_LeftThigh.TextOffset = new System.Drawing.Point(-124, 1);
            // 
            // cuiButton_Measure_RightThigh
            // 
            this.cuiButton_Measure_RightThigh.CheckButton = false;
            this.cuiButton_Measure_RightThigh.Checked = false;
            this.cuiButton_Measure_RightThigh.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightThigh.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightThigh.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightThigh.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightThigh.Content = "Right thigh";
            this.cuiButton_Measure_RightThigh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_RightThigh.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_RightThigh.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightThigh.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_RightThigh.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightThigh.Image = null;
            this.cuiButton_Measure_RightThigh.ImageAutoCenter = false;
            this.cuiButton_Measure_RightThigh.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightThigh.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightThigh.Location = new System.Drawing.Point(3, 1533);
            this.cuiButton_Measure_RightThigh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_RightThigh.Name = "cuiButton_Measure_RightThigh";
            this.cuiButton_Measure_RightThigh.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightThigh.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightThigh.OutlineThickness = 0F;
            this.cuiButton_Measure_RightThigh.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_RightThigh.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightThigh.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightThigh.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_RightThigh.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_RightThigh.TabIndex = 29;
            this.cuiButton_Measure_RightThigh.TextOffset = new System.Drawing.Point(-116, 1);
            // 
            // cuiButton_Measure_LeftCalf
            // 
            this.cuiButton_Measure_LeftCalf.CheckButton = false;
            this.cuiButton_Measure_LeftCalf.Checked = false;
            this.cuiButton_Measure_LeftCalf.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftCalf.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftCalf.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_LeftCalf.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_LeftCalf.Content = "Left calf";
            this.cuiButton_Measure_LeftCalf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_LeftCalf.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_LeftCalf.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftCalf.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_LeftCalf.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftCalf.Image = null;
            this.cuiButton_Measure_LeftCalf.ImageAutoCenter = false;
            this.cuiButton_Measure_LeftCalf.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftCalf.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_LeftCalf.Location = new System.Drawing.Point(3, 1628);
            this.cuiButton_Measure_LeftCalf.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_LeftCalf.Name = "cuiButton_Measure_LeftCalf";
            this.cuiButton_Measure_LeftCalf.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_LeftCalf.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftCalf.OutlineThickness = 0F;
            this.cuiButton_Measure_LeftCalf.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_LeftCalf.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_LeftCalf.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_LeftCalf.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_LeftCalf.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_LeftCalf.TabIndex = 30;
            this.cuiButton_Measure_LeftCalf.TextOffset = new System.Drawing.Point(-130, 1);
            // 
            // cuiButton_Measure_RightCalf
            // 
            this.cuiButton_Measure_RightCalf.CheckButton = false;
            this.cuiButton_Measure_RightCalf.Checked = false;
            this.cuiButton_Measure_RightCalf.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightCalf.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightCalf.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_Measure_RightCalf.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_Measure_RightCalf.Content = "Right calf";
            this.cuiButton_Measure_RightCalf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Measure_RightCalf.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Measure_RightCalf.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightCalf.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_Measure_RightCalf.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightCalf.Image = null;
            this.cuiButton_Measure_RightCalf.ImageAutoCenter = false;
            this.cuiButton_Measure_RightCalf.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightCalf.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Measure_RightCalf.Location = new System.Drawing.Point(3, 1723);
            this.cuiButton_Measure_RightCalf.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cuiButton_Measure_RightCalf.Name = "cuiButton_Measure_RightCalf";
            this.cuiButton_Measure_RightCalf.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Measure_RightCalf.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightCalf.OutlineThickness = 0F;
            this.cuiButton_Measure_RightCalf.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.cuiButton_Measure_RightCalf.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Measure_RightCalf.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Measure_RightCalf.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_Measure_RightCalf.Size = new System.Drawing.Size(485, 95);
            this.cuiButton_Measure_RightCalf.TabIndex = 31;
            this.cuiButton_Measure_RightCalf.TextOffset = new System.Drawing.Point(-124, 1);
            // 
            // panel_ExerciseDetails
            // 
            this.panel_ExerciseDetails.Controls.Add(this.cuiGradientBorder_ExerciseDetails);
            this.panel_ExerciseDetails.Controls.Add(this.panel_ExerciseDetails_Buttons);
            this.panel_ExerciseDetails.Controls.Add(this.panel_ExerciseDetails_Name);
            this.panel_ExerciseDetails.Controls.Add(this.flowLayoutPanel_ExerciseDetails);
            this.panel_ExerciseDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ExerciseDetails.Location = new System.Drawing.Point(0, 35);
            this.panel_ExerciseDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ExerciseDetails.Name = "panel_ExerciseDetails";
            this.panel_ExerciseDetails.Size = new System.Drawing.Size(513, 0);
            this.panel_ExerciseDetails.TabIndex = 23;
            // 
            // cuiGradientBorder_ExerciseDetails
            // 
            this.cuiGradientBorder_ExerciseDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGradientBorder_ExerciseDetails.GradientAngle = -90F;
            this.cuiGradientBorder_ExerciseDetails.Location = new System.Drawing.Point(0, 151);
            this.cuiGradientBorder_ExerciseDetails.Margin = new System.Windows.Forms.Padding(0);
            this.cuiGradientBorder_ExerciseDetails.Name = "cuiGradientBorder_ExerciseDetails";
            this.cuiGradientBorder_ExerciseDetails.OutlineThickness = 0F;
            this.cuiGradientBorder_ExerciseDetails.PanelColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_ExerciseDetails.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cuiGradientBorder_ExerciseDetails.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_ExerciseDetails.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiGradientBorder_ExerciseDetails.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_ExerciseDetails.Size = new System.Drawing.Size(513, 10);
            this.cuiGradientBorder_ExerciseDetails.TabIndex = 8;
            // 
            // panel_ExerciseDetails_Buttons
            // 
            this.panel_ExerciseDetails_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiBorder_ExerciseDetail_Records);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiBorder_ExerciseDetail_Charts);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiBorder_ExerciseDetail_History);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiBorder_ExerciseDetail_About);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiButton_ExerciseDetails_Records);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiButton_ExerciseDetails_Charts);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiButton_ExerciseDetails_History);
            this.panel_ExerciseDetails_Buttons.Controls.Add(this.cuiButton_ExerciseDetails_About);
            this.panel_ExerciseDetails_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ExerciseDetails_Buttons.Location = new System.Drawing.Point(0, 80);
            this.panel_ExerciseDetails_Buttons.Name = "panel_ExerciseDetails_Buttons";
            this.panel_ExerciseDetails_Buttons.Size = new System.Drawing.Size(513, 71);
            this.panel_ExerciseDetails_Buttons.TabIndex = 9;
            // 
            // cuiBorder_ExerciseDetail_Records
            // 
            this.cuiBorder_ExerciseDetail_Records.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_Records.Location = new System.Drawing.Point(387, 68);
            this.cuiBorder_ExerciseDetail_Records.Name = "cuiBorder_ExerciseDetail_Records";
            this.cuiBorder_ExerciseDetail_Records.OutlineThickness = 0F;
            this.cuiBorder_ExerciseDetail_Records.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiBorder_ExerciseDetail_Records.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_Records.Rounding = new System.Windows.Forms.Padding(2);
            this.cuiBorder_ExerciseDetail_Records.Size = new System.Drawing.Size(109, 10);
            this.cuiBorder_ExerciseDetail_Records.TabIndex = 13;
            this.cuiBorder_ExerciseDetail_Records.Visible = false;
            // 
            // cuiBorder_ExerciseDetail_Charts
            // 
            this.cuiBorder_ExerciseDetail_Charts.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_Charts.Location = new System.Drawing.Point(272, 68);
            this.cuiBorder_ExerciseDetail_Charts.Name = "cuiBorder_ExerciseDetail_Charts";
            this.cuiBorder_ExerciseDetail_Charts.OutlineThickness = 0F;
            this.cuiBorder_ExerciseDetail_Charts.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiBorder_ExerciseDetail_Charts.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_Charts.Rounding = new System.Windows.Forms.Padding(2);
            this.cuiBorder_ExerciseDetail_Charts.Size = new System.Drawing.Size(88, 10);
            this.cuiBorder_ExerciseDetail_Charts.TabIndex = 13;
            this.cuiBorder_ExerciseDetail_Charts.Visible = false;
            // 
            // cuiBorder_ExerciseDetail_History
            // 
            this.cuiBorder_ExerciseDetail_History.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_History.Location = new System.Drawing.Point(142, 68);
            this.cuiBorder_ExerciseDetail_History.Name = "cuiBorder_ExerciseDetail_History";
            this.cuiBorder_ExerciseDetail_History.OutlineThickness = 0F;
            this.cuiBorder_ExerciseDetail_History.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiBorder_ExerciseDetail_History.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_History.Rounding = new System.Windows.Forms.Padding(2);
            this.cuiBorder_ExerciseDetail_History.Size = new System.Drawing.Size(91, 10);
            this.cuiBorder_ExerciseDetail_History.TabIndex = 13;
            this.cuiBorder_ExerciseDetail_History.Visible = false;
            // 
            // cuiBorder_ExerciseDetail_About
            // 
            this.cuiBorder_ExerciseDetail_About.BackColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_About.Location = new System.Drawing.Point(24, 68);
            this.cuiBorder_ExerciseDetail_About.Name = "cuiBorder_ExerciseDetail_About";
            this.cuiBorder_ExerciseDetail_About.OutlineThickness = 0F;
            this.cuiBorder_ExerciseDetail_About.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiBorder_ExerciseDetail_About.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiBorder_ExerciseDetail_About.Rounding = new System.Windows.Forms.Padding(2);
            this.cuiBorder_ExerciseDetail_About.Size = new System.Drawing.Size(77, 10);
            this.cuiBorder_ExerciseDetail_About.TabIndex = 12;
            // 
            // cuiButton_ExerciseDetails_Records
            // 
            this.cuiButton_ExerciseDetails_Records.CheckButton = false;
            this.cuiButton_ExerciseDetails_Records.Checked = false;
            this.cuiButton_ExerciseDetails_Records.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Records.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_Records.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_Records.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Records.Content = "RECORDS";
            this.cuiButton_ExerciseDetails_Records.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_ExerciseDetails_Records.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_ExerciseDetails_Records.Font = new System.Drawing.Font("SansSerif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_ExerciseDetails_Records.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Records.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Records.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_Records.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_Records.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Records.Image = null;
            this.cuiButton_ExerciseDetails_Records.ImageAutoCenter = false;
            this.cuiButton_ExerciseDetails_Records.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_Records.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_Records.Location = new System.Drawing.Point(378, 0);
            this.cuiButton_ExerciseDetails_Records.Name = "cuiButton_ExerciseDetails_Records";
            this.cuiButton_ExerciseDetails_Records.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Records.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Records.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Records.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Records.OutlineThickness = 0F;
            this.cuiButton_ExerciseDetails_Records.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Records.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_Records.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_Records.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Records.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_ExerciseDetails_Records.Size = new System.Drawing.Size(126, 71);
            this.cuiButton_ExerciseDetails_Records.TabIndex = 8;
            this.cuiButton_ExerciseDetails_Records.TextOffset = new System.Drawing.Point(0, 4);
            // 
            // cuiButton_ExerciseDetails_Charts
            // 
            this.cuiButton_ExerciseDetails_Charts.CheckButton = false;
            this.cuiButton_ExerciseDetails_Charts.Checked = false;
            this.cuiButton_ExerciseDetails_Charts.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Charts.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_Charts.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_Charts.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Charts.Content = "CHARTS";
            this.cuiButton_ExerciseDetails_Charts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_ExerciseDetails_Charts.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_ExerciseDetails_Charts.Font = new System.Drawing.Font("SansSerif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_ExerciseDetails_Charts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Charts.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Charts.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_Charts.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_Charts.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Charts.Image = null;
            this.cuiButton_ExerciseDetails_Charts.ImageAutoCenter = false;
            this.cuiButton_ExerciseDetails_Charts.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_Charts.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_Charts.Location = new System.Drawing.Point(252, 0);
            this.cuiButton_ExerciseDetails_Charts.Name = "cuiButton_ExerciseDetails_Charts";
            this.cuiButton_ExerciseDetails_Charts.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Charts.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Charts.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_Charts.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Charts.OutlineThickness = 0F;
            this.cuiButton_ExerciseDetails_Charts.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_Charts.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_Charts.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_Charts.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_Charts.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_ExerciseDetails_Charts.Size = new System.Drawing.Size(126, 71);
            this.cuiButton_ExerciseDetails_Charts.TabIndex = 7;
            this.cuiButton_ExerciseDetails_Charts.TextOffset = new System.Drawing.Point(0, 4);
            // 
            // cuiButton_ExerciseDetails_History
            // 
            this.cuiButton_ExerciseDetails_History.CheckButton = false;
            this.cuiButton_ExerciseDetails_History.Checked = false;
            this.cuiButton_ExerciseDetails_History.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_History.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_History.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_History.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_History.Content = "HISTORY";
            this.cuiButton_ExerciseDetails_History.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_ExerciseDetails_History.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_ExerciseDetails_History.Font = new System.Drawing.Font("SansSerif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_ExerciseDetails_History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_History.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_History.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_History.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_History.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_History.Image = null;
            this.cuiButton_ExerciseDetails_History.ImageAutoCenter = false;
            this.cuiButton_ExerciseDetails_History.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_History.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_History.Location = new System.Drawing.Point(126, 0);
            this.cuiButton_ExerciseDetails_History.Name = "cuiButton_ExerciseDetails_History";
            this.cuiButton_ExerciseDetails_History.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_History.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_History.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_History.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_History.OutlineThickness = 0F;
            this.cuiButton_ExerciseDetails_History.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_History.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_History.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_History.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_History.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_ExerciseDetails_History.Size = new System.Drawing.Size(126, 71);
            this.cuiButton_ExerciseDetails_History.TabIndex = 6;
            this.cuiButton_ExerciseDetails_History.TextOffset = new System.Drawing.Point(0, 4);
            // 
            // cuiButton_ExerciseDetails_About
            // 
            this.cuiButton_ExerciseDetails_About.CheckButton = true;
            this.cuiButton_ExerciseDetails_About.Checked = false;
            this.cuiButton_ExerciseDetails_About.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_About.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_About.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_About.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_About.Content = "ABOUT";
            this.cuiButton_ExerciseDetails_About.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_ExerciseDetails_About.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_ExerciseDetails_About.Font = new System.Drawing.Font("SansSerif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_ExerciseDetails_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_About.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_About.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_About.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_About.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_About.Image = null;
            this.cuiButton_ExerciseDetails_About.ImageAutoCenter = false;
            this.cuiButton_ExerciseDetails_About.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_About.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_About.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_About.Name = "cuiButton_ExerciseDetails_About";
            this.cuiButton_ExerciseDetails_About.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_About.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_ExerciseDetails_About.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.cuiButton_ExerciseDetails_About.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_About.OutlineThickness = 0F;
            this.cuiButton_ExerciseDetails_About.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_About.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_About.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_About.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_About.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_ExerciseDetails_About.Size = new System.Drawing.Size(126, 71);
            this.cuiButton_ExerciseDetails_About.TabIndex = 5;
            this.cuiButton_ExerciseDetails_About.TextOffset = new System.Drawing.Point(0, 4);
            // 
            // panel_ExerciseDetails_Name
            // 
            this.panel_ExerciseDetails_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel_ExerciseDetails_Name.Controls.Add(this.cuiButton_ExerciseDetails_GoBack);
            this.panel_ExerciseDetails_Name.Controls.Add(this.label_ExerciseDetails_Name);
            this.panel_ExerciseDetails_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ExerciseDetails_Name.Location = new System.Drawing.Point(0, 0);
            this.panel_ExerciseDetails_Name.Name = "panel_ExerciseDetails_Name";
            this.panel_ExerciseDetails_Name.Size = new System.Drawing.Size(513, 80);
            this.panel_ExerciseDetails_Name.TabIndex = 7;
            // 
            // cuiButton_ExerciseDetails_GoBack
            // 
            this.cuiButton_ExerciseDetails_GoBack.CheckButton = false;
            this.cuiButton_ExerciseDetails_GoBack.Checked = false;
            this.cuiButton_ExerciseDetails_GoBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_ExerciseDetails_GoBack.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_GoBack.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_ExerciseDetails_GoBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_ExerciseDetails_GoBack.Content = "";
            this.cuiButton_ExerciseDetails_GoBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_ExerciseDetails_GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_ExerciseDetails_GoBack.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_ExerciseDetails_GoBack.ForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_GoBack.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_GoBack.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_ExerciseDetails_GoBack.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_GoBack.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_GoBack.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_ExerciseDetails_GoBack.Image")));
            this.cuiButton_ExerciseDetails_GoBack.ImageAutoCenter = true;
            this.cuiButton_ExerciseDetails_GoBack.ImageExpand = new System.Drawing.Point(6, 6);
            this.cuiButton_ExerciseDetails_GoBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_GoBack.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_ExerciseDetails_GoBack.Name = "cuiButton_ExerciseDetails_GoBack";
            this.cuiButton_ExerciseDetails_GoBack.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_GoBack.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_GoBack.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_GoBack.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_GoBack.OutlineThickness = 0F;
            this.cuiButton_ExerciseDetails_GoBack.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_ExerciseDetails_GoBack.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_ExerciseDetails_GoBack.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_ExerciseDetails_GoBack.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_ExerciseDetails_GoBack.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_ExerciseDetails_GoBack.Size = new System.Drawing.Size(102, 80);
            this.cuiButton_ExerciseDetails_GoBack.TabIndex = 11;
            this.cuiButton_ExerciseDetails_GoBack.TextOffset = new System.Drawing.Point(0, 15);
            this.cuiButton_ExerciseDetails_GoBack.Click += new System.EventHandler(this.cuiButton_Menu_Exercises_Click);
            // 
            // label_ExerciseDetails_Name
            // 
            this.label_ExerciseDetails_Name.AutoSize = true;
            this.label_ExerciseDetails_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_ExerciseDetails_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ExerciseDetails_Name.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_ExerciseDetails_Name.ForeColor = System.Drawing.Color.White;
            this.label_ExerciseDetails_Name.Location = new System.Drawing.Point(106, 27);
            this.label_ExerciseDetails_Name.Name = "label_ExerciseDetails_Name";
            this.label_ExerciseDetails_Name.Size = new System.Drawing.Size(241, 27);
            this.label_ExerciseDetails_Name.TabIndex = 7;
            this.label_ExerciseDetails_Name.Text = "New workout template";
            this.label_ExerciseDetails_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_ExerciseDetails
            // 
            this.flowLayoutPanel_ExerciseDetails.AutoScroll = true;
            this.flowLayoutPanel_ExerciseDetails.Controls.Add(this.label_ExerciseDetails_Instruction);
            this.flowLayoutPanel_ExerciseDetails.Controls.Add(this.textBox_ExerciseDetails_Instructions);
            this.flowLayoutPanel_ExerciseDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel_ExerciseDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_ExerciseDetails.Location = new System.Drawing.Point(0, 161);
            this.flowLayoutPanel_ExerciseDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_ExerciseDetails.Name = "flowLayoutPanel_ExerciseDetails";
            this.flowLayoutPanel_ExerciseDetails.Size = new System.Drawing.Size(513, 592);
            this.flowLayoutPanel_ExerciseDetails.TabIndex = 6;
            // 
            // label_ExerciseDetails_Instruction
            // 
            this.label_ExerciseDetails_Instruction.AutoSize = true;
            this.label_ExerciseDetails_Instruction.BackColor = System.Drawing.Color.Transparent;
            this.label_ExerciseDetails_Instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ExerciseDetails_Instruction.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_ExerciseDetails_Instruction.ForeColor = System.Drawing.Color.White;
            this.label_ExerciseDetails_Instruction.Location = new System.Drawing.Point(25, 20);
            this.label_ExerciseDetails_Instruction.Margin = new System.Windows.Forms.Padding(25, 20, 25, 5);
            this.label_ExerciseDetails_Instruction.Name = "label_ExerciseDetails_Instruction";
            this.label_ExerciseDetails_Instruction.Size = new System.Drawing.Size(144, 27);
            this.label_ExerciseDetails_Instruction.TabIndex = 14;
            this.label_ExerciseDetails_Instruction.Text = "Instructions";
            this.label_ExerciseDetails_Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ExerciseDetails_Instructions
            // 
            this.textBox_ExerciseDetails_Instructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.textBox_ExerciseDetails_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ExerciseDetails_Instructions.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_ExerciseDetails_Instructions.ForeColor = System.Drawing.Color.White;
            this.textBox_ExerciseDetails_Instructions.Location = new System.Drawing.Point(25, 52);
            this.textBox_ExerciseDetails_Instructions.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.textBox_ExerciseDetails_Instructions.Multiline = true;
            this.textBox_ExerciseDetails_Instructions.Name = "textBox_ExerciseDetails_Instructions";
            this.textBox_ExerciseDetails_Instructions.ReadOnly = true;
            this.textBox_ExerciseDetails_Instructions.Size = new System.Drawing.Size(463, 520);
            this.textBox_ExerciseDetails_Instructions.TabIndex = 13;
            this.textBox_ExerciseDetails_Instructions.Text = "@";
            // 
            // cuiButton_AddExercises_Exit
            // 
            this.cuiButton_AddExercises_Exit.CheckButton = false;
            this.cuiButton_AddExercises_Exit.Checked = false;
            this.cuiButton_AddExercises_Exit.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_AddExercises_Exit.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_AddExercises_Exit.CheckedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.cuiButton_AddExercises_Exit.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.cuiButton_AddExercises_Exit.Content = "";
            this.cuiButton_AddExercises_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_AddExercises_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.cuiButton_AddExercises_Exit.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_AddExercises_Exit.ForeColor = System.Drawing.Color.White;
            this.cuiButton_AddExercises_Exit.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_AddExercises_Exit.HoveredImageTint = System.Drawing.Color.DarkGray;
            this.cuiButton_AddExercises_Exit.HoverForeColor = System.Drawing.Color.DarkGray;
            this.cuiButton_AddExercises_Exit.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_AddExercises_Exit.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton_AddExercises_Exit.Image")));
            this.cuiButton_AddExercises_Exit.ImageAutoCenter = true;
            this.cuiButton_AddExercises_Exit.ImageExpand = new System.Drawing.Point(3, 3);
            this.cuiButton_AddExercises_Exit.ImageOffset = new System.Drawing.Point(4, 0);
            this.cuiButton_AddExercises_Exit.Location = new System.Drawing.Point(0, 0);
            this.cuiButton_AddExercises_Exit.Name = "cuiButton_AddExercises_Exit";
            this.cuiButton_AddExercises_Exit.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_AddExercises_Exit.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_AddExercises_Exit.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_AddExercises_Exit.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_AddExercises_Exit.OutlineThickness = 0F;
            this.cuiButton_AddExercises_Exit.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_AddExercises_Exit.PressedForeColor = System.Drawing.Color.DimGray;
            this.cuiButton_AddExercises_Exit.PressedImageTint = System.Drawing.Color.DimGray;
            this.cuiButton_AddExercises_Exit.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_AddExercises_Exit.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton_AddExercises_Exit.Size = new System.Drawing.Size(80, 80);
            this.cuiButton_AddExercises_Exit.TabIndex = 17;
            this.cuiButton_AddExercises_Exit.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_AddExercises_Exit.Click += new System.EventHandler(this.cuiButton_Workout_AddTemplate_Click);
            // 
            // label_AddExercises_Count
            // 
            this.label_AddExercises_Count.AutoSize = true;
            this.label_AddExercises_Count.BackColor = System.Drawing.Color.Transparent;
            this.label_AddExercises_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_AddExercises_Count.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_AddExercises_Count.ForeColor = System.Drawing.Color.White;
            this.label_AddExercises_Count.Location = new System.Drawing.Point(277, 27);
            this.label_AddExercises_Count.Name = "label_AddExercises_Count";
            this.label_AddExercises_Count.Size = new System.Drawing.Size(67, 27);
            this.label_AddExercises_Count.TabIndex = 19;
            this.label_AddExercises_Count.Text = "(200)";
            this.label_AddExercises_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_AddExercises_Count.Visible = false;
            // 
            // label_AddExercises_Title
            // 
            this.label_AddExercises_Title.AutoSize = true;
            this.label_AddExercises_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_AddExercises_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_AddExercises_Title.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_AddExercises_Title.ForeColor = System.Drawing.Color.White;
            this.label_AddExercises_Title.Location = new System.Drawing.Point(99, 27);
            this.label_AddExercises_Title.Name = "label_AddExercises_Title";
            this.label_AddExercises_Title.Size = new System.Drawing.Size(159, 27);
            this.label_AddExercises_Title.TabIndex = 18;
            this.label_AddExercises_Title.Text = "Add exercises";
            this.label_AddExercises_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_AddExercises_Title.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(513, 788);
            this.Controls.Add(this.panel_ExerciseDetails);
            this.Controls.Add(this.panel_Menu_Measure);
            this.Controls.Add(this.panel_Menu_Workout);
            this.Controls.Add(this.panel_Menu_Exercises);
            this.Controls.Add(this.panel_Menu_History);
            this.Controls.Add(this.panel_Menu_Profile);
            this.Controls.Add(this.panel_WorkoutCreation);
            this.Controls.Add(this.cuiGradientBorder_AboveMenu);
            this.Controls.Add(this.panel_Measurement);
            this.Controls.Add(this.panel_Form_Title);
            this.Controls.Add(this.panel_Menus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Menus.ResumeLayout(false);
            this.panel_Form_Title.ResumeLayout(false);
            this.panel_Measurement.ResumeLayout(false);
            this.panel_Measurement.PerformLayout();
            this.panel_Measurement_Title.ResumeLayout(false);
            this.panel_Measurement_Title.PerformLayout();
            this.flowLayoutPanel_WorkoutCreation.ResumeLayout(false);
            this.panel_WorkoutCreation_TemplateName.ResumeLayout(false);
            this.panel_WorkoutCreation_Title.ResumeLayout(false);
            this.panel_WorkoutCreation_Title.PerformLayout();
            this.panel_WorkoutCreation.ResumeLayout(false);
            this.panel_Menu_Profile.ResumeLayout(false);
            this.panel_Profile_Title.ResumeLayout(false);
            this.panel_Profile_Title.PerformLayout();
            this.flowLayoutPanel_Profile.ResumeLayout(false);
            this.panel_Profile_User.ResumeLayout(false);
            this.panel_Profile_User.PerformLayout();
            this.panel_Profile_WorkoutCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Profile_WorkoutCount)).EndInit();
            this.panel_Menu_History.ResumeLayout(false);
            this.panel_History_Title.ResumeLayout(false);
            this.panel_History_Title.PerformLayout();
            this.panel_Menu_Exercises.ResumeLayout(false);
            this.cuiBorder_Exercises_Filter.ResumeLayout(false);
            this.panel_Exercises_Title.ResumeLayout(false);
            this.panel_Exercises_Title.PerformLayout();
            this.panel_Exercises_Search.ResumeLayout(false);
            this.panel_Menu_Workout.ResumeLayout(false);
            this.panel_Workout_Title.ResumeLayout(false);
            this.panel_Workout_Title.PerformLayout();
            this.flowLayoutPanel_Workout.ResumeLayout(false);
            this.flowLayoutPanel_Workout.PerformLayout();
            this.panel_Workout_QuickStart.ResumeLayout(false);
            this.panel_Workout_QuickStart.PerformLayout();
            this.panel_Menu_Measure.ResumeLayout(false);
            this.panel_Measure_Title.ResumeLayout(false);
            this.panel_Measure_Title.PerformLayout();
            this.flowLayoutPanel_Measure.ResumeLayout(false);
            this.flowLayoutPanel_Measure.PerformLayout();
            this.panel_ExerciseDetails.ResumeLayout(false);
            this.panel_ExerciseDetails_Buttons.ResumeLayout(false);
            this.panel_ExerciseDetails_Name.ResumeLayout(false);
            this.panel_ExerciseDetails_Name.PerformLayout();
            this.flowLayoutPanel_ExerciseDetails.ResumeLayout(false);
            this.flowLayoutPanel_ExerciseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menus;
        private System.Windows.Forms.Panel panel_Form_Title;
        private System.Windows.Forms.Button button_Exit;
        private CuoreUI.Controls.cuiButton cuiButton_Menu_History;
        private CuoreUI.Controls.cuiButton cuiButton_Menu_Profile;
        private CuoreUI.Controls.cuiButton cuiButton_Menu_Measure;
        private CuoreUI.Controls.cuiButton cuiButton_Menu_Exercises;
        private CuoreUI.Controls.cuiButton cuiButton_Menu_Workout;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_AboveMenu;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private System.Windows.Forms.Panel panel_Measurement;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Measurement;
        private System.Windows.Forms.Panel panel_Measurement_Title;
        private System.Windows.Forms.Label label_Measurement_Name;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_GoBack;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Measurement_ChartLineBorder;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine_Measurement_Weight;
        private System.Windows.Forms.TextBox textBox_Measurement_ChartName;
        private System.Windows.Forms.Label label_Measurement_History;
        private CuoreUI.Controls.cuiButton cuiButton_Measurement_AddHistory;
        private CuoreUI.Controls.cuiDataGridView cuiDataGridView_Measurement_WeightHistory;
        private System.Windows.Forms.Panel panel_WorkoutCreation;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_WorkoutCreation;
        private System.Windows.Forms.Panel panel_WorkoutCreation_Title;
        private CuoreUI.Controls.cuiButton cuiButton_WorkoutCreation_Save;
        private CuoreUI.Controls.cuiButton cuiButton_WorkoutCreation_Exit;
        private System.Windows.Forms.Label label_WorkoutCreation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_WorkoutCreation;
        private System.Windows.Forms.Panel panel_WorkoutCreation_TemplateName;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_WorkoutCreation_Note;
        private CuoreUI.Controls.cuiButton cuiButton_WorkoutCreation_EditName;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_WorkoutCreation_TemplateName;
        private CuoreUI.Controls.cuiButton cuiButton_WorkoutCreation_AddExercise;
        private System.Windows.Forms.Panel panel_Menu_Profile;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Profile;
        private System.Windows.Forms.Panel panel_Profile_Title;
        private CuoreUI.Controls.cuiButton cuiButton_Profile_Settings;
        private System.Windows.Forms.Label label_Profile_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Profile;
        private System.Windows.Forms.Panel panel_Profile_User;
        private System.Windows.Forms.Label label_Profile_Dashboard;
        private System.Windows.Forms.Label label_Profile_WorkoutCount;
        private System.Windows.Forms.Label label_Profile_Username;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox_Profile_User;
        private System.Windows.Forms.Panel panel_Profile_WorkoutCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Profile_WorkoutCount;
        private System.Windows.Forms.Panel panel_Menu_Measure;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Measure;
        private System.Windows.Forms.Panel panel_Measure_Title;
        private System.Windows.Forms.Label label_Measure_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Measure;
        private System.Windows.Forms.Label label_Measurement_Core;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Weight;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_BodyFatPercentage;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_CaloricIntake;
        private System.Windows.Forms.Label label_Measurement_BodyPart;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Neck;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Shoulders;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Chest;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_LeftBicep;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_RightBicep;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_LeftForearm;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_RightForearm;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_UpperAbs;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Waist;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_LowerAbs;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_Hips;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_LeftThigh;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_RightThigh;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_LeftCalf;
        private CuoreUI.Controls.cuiButton cuiButton_Measure_RightCalf;
        private System.Windows.Forms.Panel panel_Menu_Workout;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Workout;
        private System.Windows.Forms.Panel panel_Workout_Title;
        private System.Windows.Forms.Label label_Workout_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Workout;
        private System.Windows.Forms.Panel panel_Workout_QuickStart;
        private CuoreUI.Controls.cuiButton cuiButton_Workout_AddTemplate;
        private System.Windows.Forms.Label label_Workout_MyTemplates;
        private CuoreUI.Controls.cuiButton cuiButton_Workout_QuickStart;
        private System.Windows.Forms.Label label_Workout_QuickStart;
        private System.Windows.Forms.Label label_Workout_EmptyTemplateMsg;
        private System.Windows.Forms.Label label_Workout_SampleTemplates;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton5;
        private System.Windows.Forms.Panel panel_Menu_Exercises;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Exercises;
        private System.Windows.Forms.Panel panel_Exercises_Title;
        private CuoreUI.Controls.cuiButton cuiButton_Exercises_Search;
        private CuoreUI.Controls.cuiButton cuiButton_Exercises_Filter;
        private System.Windows.Forms.Label label_Exercises_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Exercises;
        private System.Windows.Forms.Panel panel_Menu_History;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_History;
        private System.Windows.Forms.Panel panel_History_Title;
        private CuoreUI.Controls.cuiButton cuiButton_History_Calendar;
        private System.Windows.Forms.Label label_History_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_History;
        private System.Windows.Forms.Panel panel_Exercises_Search;
        private CuoreUI.Controls.cuiButton cuiButton_Exercises_GoBack;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Exercises_Search;
        private CuoreUI.Controls.cuiBorder cuiBorder_Exercises_Filter;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Other;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Cardio;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Core;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Legs;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_FullBody;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Arms;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Back;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Olympic;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Shoulders;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_Filter_Chest;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder2;
        private System.Windows.Forms.Label label_Exercises_Count;
        private System.Windows.Forms.Panel panel_ExerciseDetails;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_ExerciseDetails;
        private System.Windows.Forms.Panel panel_ExerciseDetails_Name;
        private System.Windows.Forms.Label label_ExerciseDetails_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ExerciseDetails;
        private CuoreUI.Controls.cuiButton cuiButton_ExerciseDetails_GoBack;
        private System.Windows.Forms.Panel panel_ExerciseDetails_Buttons;
        private CuoreUI.Controls.cuiButton cuiButton_ExerciseDetails_About;
        private CuoreUI.Controls.cuiBorder cuiBorder_ExerciseDetail_About;
        private CuoreUI.Controls.cuiButton cuiButton_ExerciseDetails_Records;
        private CuoreUI.Controls.cuiButton cuiButton_ExerciseDetails_Charts;
        private CuoreUI.Controls.cuiButton cuiButton_ExerciseDetails_History;
        private CuoreUI.Controls.cuiBorder cuiBorder_ExerciseDetail_Records;
        private CuoreUI.Controls.cuiBorder cuiBorder_ExerciseDetail_Charts;
        private CuoreUI.Controls.cuiBorder cuiBorder_ExerciseDetail_History;
        private System.Windows.Forms.Label label_ExerciseDetails_Instruction;
        private System.Windows.Forms.TextBox textBox_ExerciseDetails_Instructions;
        private System.Windows.Forms.Label label_AddExercises_Count;
        private System.Windows.Forms.Label label_AddExercises_Title;
        private CuoreUI.Controls.cuiButton cuiButton_AddExercises_Exit;
    }
}