using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI;
using CuoreUI.Controls;
using static TrainSMARTApp.User;

namespace TrainSMARTApp
{
    public partial class MainForm: Form
    {
        // for dragging the form
        private bool _mouseDown;
        private Point _lastLocation;

        // sql connection string
        private string connectionString = "Data Source=LAPTOP-R9RSTS0G\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";

        private bool isFilterShown;
        private bool isAddingExercises;
        private bool isAddingMeasurement;
        private bool isCreatingWorkoutTemplate;
        private bool isDeletingWorkoutTemplate;

        private List<int> selectedExerciseIDs = new List<int>();

        private readonly User _loggedInUser;





        public MainForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // menu panels size in design (513, 661)
            // panel size in code (0, 537)

            // cuiGradientBorder_AboveMenu size (513, 10)
            // panel_Menus size (513, 82)

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panel_Form_Title.MouseDown += this.MouseDown;
            this.panel_Form_Title.MouseMove += this.MouseMove;
            this.panel_Form_Title.MouseUp += this.MouseUp;

            LoadExerciseButtons(null, null);
            ShowMenu(panel_Menu_Profile, cuiButton_Menu_Profile);


            


            var filterCheckboxes = new List<cuiCheckbox>
            {
                cuiCheckbox_Filter_Chest,
                cuiCheckbox_Filter_Back,
                cuiCheckbox_Filter_Legs,
                cuiCheckbox_Filter_Shoulders,
                cuiCheckbox_Filter_Arms,
                cuiCheckbox_Filter_Core,
                cuiCheckbox_Filter_Olympic,
                cuiCheckbox_Filter_Cardio,
                cuiCheckbox_Filter_FullBody,
                cuiCheckbox_Filter_Other,
            };

            foreach (var cb in filterCheckboxes)
            {
                cb.CheckedChanged += DynamicExerciseSearchAndFilter;
            }

            cuiTextBox_Exercises_Search.ContentChanged += DynamicExerciseSearchAndFilter;

            label_Profile_Username.Text = _loggedInUser.Username;
            label_Profile_WorkoutCount.Text = _loggedInUser.WorkoutCount + (_loggedInUser.WorkoutCount > 0 ? " workout" : " workouts");
        }










        // FORM CONTROL(s)

        private void button_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }










        // MENU BUTTONS

        private void cuiButton_Menu_Profile_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Profile, cuiButton_Menu_Profile);
        }

        private void cuiButton_Menu_History_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_History, cuiButton_Menu_History);
        }

        private void cuiButton_Menu_Workout_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            isCreatingWorkoutTemplate = false;
            ShowMenu(panel_Menu_Workout, cuiButton_Menu_Workout);
            ClearWorkoutCreationTemplates();
        }

        private void cuiButton_Menu_Exercises_Click(object sender, EventArgs e)
        {
            var pnl = isCreatingWorkoutTemplate ? panel_WorkoutCreation : panel_Menu_Exercises;
            var btn = isAddingExercises ? cuiButton_Menu_Workout : cuiButton_Menu_Exercises;
            ShowMenu(pnl, btn);
            if (isAddingExercises) return;
            LoadExerciseButtons(null, null);
        }

        private void cuiButton_Menu_Measure_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Measure, cuiButton_Menu_Measure);
        }










        // PROFILE MENU

        // HISTORY MENU

        // WORKOUT MENU

        private void cuiButton_Workout_AddTemplate_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            isCreatingWorkoutTemplate = true;
            ShowMenu(panel_WorkoutCreation, cuiButton_Menu_Workout);
            selectedExerciseIDs.Clear();
        }


            // WORKOUT CREATION MENU

        private void cuiButton_WorkoutCreation_Exit_Click(object sender, EventArgs e)
        {
            var btn = sender as cuiButton;
            ShowHideTemplateDeletionPrompt(sender, e);
        }

        private void cuiButton_WorkoutCreation_Save_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            ClearWorkoutCreationTemplates();
        }

        private void cuiButton_WorkoutCreation_EditName_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton_WorkoutCreation_AddExercise_Click(object sender, EventArgs e)
        {
            isAddingExercises = true;
            ShowMenu(panel_Menu_Exercises, cuiButton_Menu_Exercises);
            ShowHideExerciseSearchBar(false);
            LoadExerciseButtons(null, null);
        }


                // ADDING EXERCISES

        private void cuiButton_AddExercise_ConfirmAdd_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            ShowMenu(panel_WorkoutCreation, cuiButton_Menu_Workout);
            ExerciseConfirmAdd();
        }


            // TEMPLATE 
        private void cuiButton_TemplateDeletion_Delete_Click(object sender, EventArgs e)
        {
            
        }









        // EXERCISES MENU

        private void cuiButton_Exercises_Search_Click(object sender, EventArgs e)
        {
            ShowHideExerciseSearchBar(true);
        }

        private void cuiButton_Exercises_GoBack_Click(object sender, EventArgs e)
        {
            ShowHideExerciseSearchBar(false);
        }

        private void cuiButton_Exercises_Filter_Click(object sender, EventArgs e)
        {
            ShowHideExerciseFilter();
        }


            // EXERCISE DETAILS



        // MEASURE MENU
        private void cuiButton_Measure_Measurements_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Measurement, cuiButton_Menu_Measure);
            RenameTitleAndChart(sender, e);
            ShowHideAddingMeasurementPanel(sender, e);
        }

            // MEASUREMENT MENU
        private void cuiButton_AddingMeasurement_Click(object sender, EventArgs e)
        {
            ShowHideAddingMeasurementPanel(sender, e);
        }

                // ADDING MEASUREMENT
        private void cuiButton_AddingMeasurement_Save_Click(object sender, EventArgs e)
        {
            ShowHideAddingMeasurementPanel(sender, e);
        }










        // METHODS & FUNCTIONS

            // for dragging the form
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private new void MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }


        private void ShowMenu(Panel panel, cuiButton button)
        {
            var panels = new List<Panel>
            {
                panel_Menu_Profile,
                panel_Menu_History,

                panel_Menu_Workout,
                panel_WorkoutCreation,

                panel_Menu_Exercises,
                panel_ExerciseDetails,

                panel_Menu_Measure,
                panel_Measurement,
            };

            var longPanels = new HashSet<Panel>
            {
                panel_WorkoutCreation,
                panel_ExerciseDetails,
            };

            foreach (var pnl in panels)
            {
                pnl.Visible = pnl == panel;
                pnl.Height = (pnl == panel) ? (longPanels.Contains(pnl) || (isAddingExercises && pnl == panel_Menu_Exercises)) ? 611 : 537 : 0;
            }
            //panel_Menus.Height = (longPanels.Contains(panel)) ? 0 : 67;

            if (panel == panel_Menu_Exercises)
            {
                ShowHideExerciseFilter("true");
                ShowHideExerciseSearchBar(false);
            }
            ShowHideExerciseLabelsAndButtons();

            var menuButtons = new List<cuiButton>
            {
                cuiButton_Menu_Profile,
                cuiButton_Menu_History,
                cuiButton_Menu_Workout,
                cuiButton_Menu_Exercises,
                cuiButton_Menu_Measure,
            };

            foreach (var btn in menuButtons)
            {
                (btn.NormalForeColor, btn.NormalImageTint) = (btn == button) ? (Color.White, Color.White) : (Color.FromArgb(127, 132, 134), Color.FromArgb(127, 132, 134));
            }
        }


        private void ShowHideSubPanel(Panel panel, bool flag)
        {
            // height in design is (425, 270)
            
            panel.Visible = flag;
            panel.Width = (flag) ? 319 : 0;
            panel.Height = (flag) ? 219 : 0;
            if (flag) 
                panel.BringToFront();
            else 
                panel.SendToBack();

            DarkenBackground(panel, flag);
            DisableEnableControls(panel, flag);
        }


        private void ShowHideAddingMeasurementPanel(object sender, EventArgs e)
        {
            if (!(sender is cuiButton btn)) return;

            label_AddingMeasurement_CurrentDate.Text = DateTime.Today.ToString("MM/dd/yy");
            isAddingMeasurement = btn == cuiButton_Measurement_AddMeasurement;

            ShowHideSubPanel(panel_Measurement_AddingMeasurement, isAddingMeasurement);
        }


        private void ShowHideExerciseSearchBar(bool isShown)
        {
            var panel = panel_Exercises_Search;
            panel.Width = (isShown) ? 321 : 0;  // width in design is 441
            panel.BringToFront();

            var cuiBtn = cuiButton_AddExercises_Exit;
            cuiBtn.Visible = !isShown;
            cuiBtn.Width = !isShown ? 80 : 0;
        }


        private void ShowHideExerciseFilter(string isShown = "")
        {
            var border = cuiBorder_Exercises_Filter;
            if (!string.IsNullOrWhiteSpace(isShown))
                isFilterShown = Convert.ToBoolean(isShown);
            isFilterShown = !isFilterShown;
            border.Height = (isFilterShown) ? 75 : 0;   // height in design is 93
            border.BringToFront();
        }


        private void ShowHideExerciseLabelsAndButtons()
        {
            var exerciseMenuControls = new List<Control>
            {
                cuiButton_AddExercise_ConfirmAdd,
                cuiButton_AddExercises_Exit,
                label_AddExercises_Title,
                label_AddExercises_Count,

                label_Exercises_Title,
                label_Exercises_Count,
            };

            foreach (var ctrl in exerciseMenuControls)
            {
                ctrl.Visible = ctrl.Name.Contains("Add") ? isAddingExercises : !isAddingExercises;
                ctrl.BringToFront();
            }
        }


        private void ShowExerciseDetails(object sender, EventArgs e)
        {
            var btn = sender as cuiButton;
            int exerciseId = (int)btn.Tag;

            string query = "SELECT * FROM Exercises WHERE ExerciseID = @ExerciseID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ExerciseID", exerciseId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    label_ExerciseDetails_Name.Text = reader["ExerciseName"].ToString();
                    textBox_ExerciseDetails_Instructions.Text =  reader["Instructions"].ToString();

                    ShowMenu(panel_ExerciseDetails, cuiButton_Menu_Exercises);
                    ResizeTextBoxToFitContents(textBox_ExerciseDetails_Instructions);
                }
            }
        }


        private void LoadExerciseButtons(string search, List<string> muscleGroups)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Exercises WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND ExerciseName LIKE @Search";

                if (muscleGroups != null && muscleGroups.Count > 0)
                {
                    var groupConditions = string.Join(" OR ", muscleGroups.Select((g, i) => $"MuscleGroup = @Group{i}"));
                    query += $" AND ({groupConditions})";
                }

                query += " ORDER BY ExerciseName ASC";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@Search", $"%{search}%");

                if (muscleGroups != null && muscleGroups.Count > 0)
                {
                    for (int i = 0; i < muscleGroups.Count; i++)
                        cmd.Parameters.AddWithValue($"@Group{i}", muscleGroups[i]);
                }

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    flowLayoutPanel_Exercises.Controls.Clear();

                    while (reader.Read())
                    {
                        int exerciseId = reader.GetInt32(0);
                        string exerciseName = reader.GetString(1);
                        string muscleGroup = reader.IsDBNull(2) ? " " : reader.GetString(2);

                        var btn = new cuiButton
                        {
                            Content           = $"{exerciseName}\n({muscleGroup})",
                            Width             = 360,
                            Height            = 85,
                            Tag               = exerciseId, 
                            Font              = new Font("SansSerif", 13.8f, FontStyle.Bold),
                            TextOffset        = new Point(0, -10),
                            Margin            = new Padding(3, 0, 3, 0),

                            BackColor         = Color.Transparent,
                            ForeColor         = Color.White,
                            HoverBackground   = Color.Transparent,
                            HoverForeColor    = Color.DimGray,
                            NormalBackground  = Color.Transparent,
                            NormalForeColor   = Color.White,
                            PressedBackground = Color.FromArgb(84, 91, 94),
                            PressedForeColor  = Color.White,
                        };

                        if (isAddingExercises)
                            btn.Click += ExerciseSelectToggle; // TODO: add exercise to workout
                        else
                            btn.Click += ShowExerciseDetails;

                        flowLayoutPanel_Exercises.Controls.Add(btn);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading exercises: " + ex.Message);
                }
            }

            var lbl = (isAddingExercises) ? label_AddExercises_Count : label_Exercises_Count;
            lbl.Text = (isAddingExercises) ? "(" + selectedExerciseIDs.Count.ToString() + ")" : "(" + flowLayoutPanel_Exercises.Controls.Count.ToString() + ")";
        }


        private void DynamicExerciseSearchAndFilter(object sender, EventArgs e)
        {
            string searchText = cuiTextBox_Exercises_Search.Content;
            var selectedGroups = new List<string>();

            if (cuiCheckbox_Filter_Chest.Checked) selectedGroups.Add("Chest");
            if (cuiCheckbox_Filter_Back.Checked) selectedGroups.Add("Back");
            if (cuiCheckbox_Filter_Legs.Checked) selectedGroups.Add("Legs");
            if (cuiCheckbox_Filter_Shoulders.Checked) selectedGroups.Add("Shoulders");
            if (cuiCheckbox_Filter_Arms.Checked) selectedGroups.Add("Arms");
            if (cuiCheckbox_Filter_Core.Checked) selectedGroups.Add("Core");
            if (cuiCheckbox_Filter_Olympic.Checked) selectedGroups.Add("Olympic");
            if (cuiCheckbox_Filter_Cardio.Checked) selectedGroups.Add("Cardio");
            if (cuiCheckbox_Filter_FullBody.Checked) selectedGroups.Add("Full body");
            if (cuiCheckbox_Filter_Other.Checked) selectedGroups.Add("Other");

            LoadExerciseButtons(searchText, selectedGroups);
        }


        private void ExerciseSelectToggle(object sender, EventArgs e)
        {
            var btn = sender as cuiButton;
            int id = (int)btn.Tag;

            if (selectedExerciseIDs.Contains(id))
            {
                selectedExerciseIDs.Remove(id);
                (btn.NormalBackground, btn.HoverBackground) = (Color.Transparent, Color.Transparent);
            }
            else
            {
                selectedExerciseIDs.Add(id);
                (btn.NormalBackground, btn.HoverBackground) = (Color.FromArgb(44, 79, 104), Color.FromArgb(44, 79, 104));
            }
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";
        }


        private void ExerciseConfirmAdd()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (int exerciseId in selectedExerciseIDs)
                {
                    string query = "SELECT ExerciseName FROM Exercises WHERE ExerciseID = @ExerciseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ExerciseID", exerciseId);

                    object result = cmd.ExecuteScalar();
                    string exerciseName = result?.ToString() ?? "Unknown Exercise";

                    var panelExercise = new Panel
                    {
                        Width     = 360,
                        Height    = 211,
                        BackColor = Color.Transparent,
                        Margin    = new Padding(3, 5, 3, 10),
                        Tag       = exerciseId,

                        BorderStyle = BorderStyle.FixedSingle,  // TODO: remove after test
                    };

                    var cuiButtonExerciseName = new cuiButton
                    {
                        Content           = exerciseName,
                        Font              = new Font("SansSerif", 14),// FontStyle.Bold),
                        ForeColor         = Color.FromArgb(53, 167, 255),
                        Dock              = DockStyle.Top,
                        Height            = 60,
                        Tag               = exerciseId,
                        TextOffset        = new Point(0, -1), 
                        //TextOffset        = new Point  // TODO: FIX
                        //(
                        //    -180 + (exerciseName.Length > 31
                        //                ? exerciseName.Length * 5 + 2
                        //                : exerciseName.Length > 24
                        //                    ? exerciseName.Length * 5
                        //                    : exerciseName.Length < 24 && exerciseName.Length > 20 
                        //                        ? exerciseName.Length * 5 + 4
                        //                        : exerciseName.Length > 19
                        //                            ? (exerciseName.Length * 5) - 4
                        //                            : exerciseName.Length > 15
                        //                                ? (exerciseName.Length * 5) + 4
                        //                                : exerciseName.Length > 10
                        //                                    ? exerciseName.Length * 6
                        //                                    : exerciseName.Length > 9
                        //                                        ? exerciseName.Length * 7
                        //                                        : exerciseName.Length * 8), 
                        //    0
                        //),

                        BackColor         = Color.Transparent,
                        HoverBackground   = Color.Transparent,
                        HoverForeColor    = Color.LightSkyBlue,
                        NormalBackground  = Color.Transparent,
                        NormalForeColor   = Color.FromArgb(53, 167, 255),
                        PressedBackground = Color.FromArgb(84, 91, 94),
                        PressedForeColor  = Color.White,
                    };
                    cuiButtonExerciseName.Click += ShowExerciseDetails;

                    var lblSet = new Label
                    {
                        Text      = "SET",
                        Font      = new Font("SansSerif", 9), //FontStyle.Bold),
                        Width     = 30,
                        Height    = 15,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location  = new Point(10, 73),
                    };

                    var lblPrevious = new Label
                    {
                        Text      = "PREVIOUS",
                        Font      = lblSet.Font, 
                        Width     = lblSet.Width + 40,
                        Height    = lblSet.Height,
                        ForeColor = lblSet.ForeColor,
                        TextAlign = lblSet.TextAlign,
                        Location  = new Point(lblSet.Location.X + 57, lblSet.Location.Y),
                    };

                    var lblWeight = new Label
                    {
                        Text      = "LBS",
                        Font      = lblSet.Font,
                        Width     = lblSet.Width,
                        Height    = lblSet.Height,
                        ForeColor = lblSet.ForeColor,
                        TextAlign = lblSet.TextAlign,
                        Location  = new Point(lblPrevious.Location.X + 125, lblPrevious.Location.Y),
                    };

                    var lblReps = new Label
                    {
                        Text      = "REPS",
                        Font      = lblWeight.Font,
                        Width     = lblWeight.Width + 10,
                        Height    = lblWeight.Height,
                        ForeColor = lblWeight.ForeColor,
                        TextAlign = lblWeight.TextAlign,
                        Location  = new Point(lblWeight.Location.X + 66, lblWeight.Location.Y),
                    };

                    var cuiButtonAddSet = new cuiButton
                    {
                        Content           = "ADD SET",
                        Width             = 180,
                        //Height            = 48,
                        Tag               = panelExercise,
                        Dock              = DockStyle.Right,
                        Font              = new Font("SansSerif", 11),// FontStyle.Bold),
                        Margin            = new Padding(3, 4, 3, 4),
                        Rounding          = new Padding(4),
                        TextOffset        = new Point(0, 4),

                        ForeColor         = Color.FromArgb(53, 167, 255),
                        NormalForeColor   = Color.FromArgb(53, 167, 255),
                        HoverForeColor    = Color.LightSkyBlue,
                        PressedForeColor  = Color.White,
                        BackColor         = Color.Transparent,
                        NormalBackground  = Color.Transparent,
                        HoverBackground   = Color.Transparent,
                        PressedBackground = Color.FromArgb(42, 64, 78),
                    };
                    cuiButtonAddSet.Click += (s, e) =>
                    {
                        var parent = (Panel)((cuiButton)s).Tag;
                        var addedRowHeight= AddExerciseSetRow(parent);
                        panelExercise.Height += addedRowHeight; 
                    };

                    var cuiButtonRemoveSet = new cuiButton
                    {
                        Content           = "REMOVE SET",
                        Width             = cuiButtonAddSet.Width, 
                        //Height            = cuiButtonAddSet.Height,
                        Tag               = cuiButtonAddSet.Tag,
                        Dock              = DockStyle.Left,
                        Font              = cuiButtonAddSet.Font,
                        Margin            = cuiButtonAddSet.Margin,
                        Rounding          = cuiButtonAddSet.Rounding,
                        TextOffset        = cuiButtonAddSet.TextOffset,

                        ForeColor         = Color.Crimson,
                        NormalForeColor   = Color.Crimson,
                        HoverForeColor    = Color.Red,
                        PressedForeColor  = cuiButtonAddSet.PressedForeColor,
                        BackColor         = cuiButtonAddSet.BackColor,
                        NormalBackground  = cuiButtonAddSet.NormalBackground,
                        HoverBackground   = cuiButtonAddSet.HoverBackground,
                        PressedBackground = Color.FromArgb(255, 89, 100),
                    };
                    cuiButtonRemoveSet.Click += (s, e) =>
                    {
                        var parent = (Panel)((cuiButton)s).Tag;
                        var subtractedRowHeight = RemoveExerciseSetRow(parent);
                        panelExercise.Height -= subtractedRowHeight;
                    };

                    var panelCuiButtons = new Panel
                    {
                        Height    = 48,
                        BackColor = Color.Transparent,
                        Margin    = new Padding(3, 4, 3, 4),
                        Dock      = DockStyle.Bottom,
                        Tag       = panelExercise.Tag,
                    };



                    // adding controls
                    var controls = new List<Control>
                    {
                        cuiButtonExerciseName,
                        lblSet,
                        lblPrevious,
                        lblWeight,
                        lblReps,
                        panelCuiButtons,
                    };
                    var cuiButtonsAddRemove = new List<Control>
                    {
                        cuiButtonAddSet,
                        cuiButtonRemoveSet,
                    };
                    foreach (var ctrl in controls)
                    {
                        panelExercise.Controls.Add(ctrl);    
                    }
                    foreach (var ctrl in cuiButtonsAddRemove)
                    {
                        panelCuiButtons.Controls.Add(ctrl);
                    }
                    AddExerciseSetRow(panelExercise);

                    flowLayoutPanel_WorkoutCreation.Controls.Add(panelExercise);
                    flowLayoutPanel_WorkoutCreation.Controls.SetChildIndex(panelExercise, flowLayoutPanel_WorkoutCreation.Controls.Count - 2); // Add above "Add Exercise" button
                }
            }
            selectedExerciseIDs.Clear();
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";

        }


        public int AddExerciseSetRow(Panel parent)
        {
            var setNumber = parent.Controls.OfType<Panel>().Count();
            var setTag = parent.Controls.OfType<Panel>().Count() + 1000;

            var setRow = new Panel
            {
                Height = 58,
                Width  = parent.Width,
                Dock   = DockStyle.Bottom,
                Tag    = setTag,
            };
            // TODO: add 'remove set' feature

            var lblSet = new Label
            {
                Text      = setNumber.ToString(),
                Width     = 35,
                Location  = new Point(0,15),
                Font      = new Font("SansSerif", 13),
                ForeColor = Color.FromArgb(53, 167, 255),
                TextAlign = ContentAlignment.MiddleRight,
            };

            var lblPrevious = new Label
            {
                Text      = "100 lbs × 12", // TODO: get previous data
                Width     = 120,
                Location  = new Point(55, 16),
                Font      = new Font("SansSerif", 12),
                ForeColor = Color.FromArgb(191, 194, 195),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            var txtBxWeight = new cuiTextBox2
            {
                Width                = 62,
                Height               = 40,
                Location             = new Point(179, 6), 
                Font                 = new Font("SansSerif", 12),
                Rounding             = new Padding(8),
                Margin               = new Padding(20,0,20,0),
                ForeColor            = Color.White,
                BackColor            = Color.FromArgb(61, 70, 73),
                BackgroundColor      = Color.FromArgb(61, 70, 73),
                BorderColor          = Color.FromArgb(61, 70, 73),
                BorderSize           = 0,
                FocusBackgroundColor = Color.FromArgb(61, 70, 73),
                FocusBorderColor     = Color.FromArgb(61, 70, 73),
                PlaceholderColor     = Color.FromArgb(158, 163, 164),
                Enabled              = false,
            };
            txtBxWeight.KeyPress += KeyPressDigitOnly;

            var txtBxReps = new cuiTextBox2
            {
                Width                = txtBxWeight.Width,
                Height               = txtBxWeight.Height,
                Location             = new Point(txtBxWeight.Location.X + 70, txtBxWeight.Location.Y),
                Font                 = txtBxWeight.Font,
                Rounding             = txtBxWeight.Rounding,
                Margin               = txtBxWeight.Margin,
                ForeColor            = txtBxWeight.ForeColor,
                BackColor            = txtBxWeight.BackColor,
                BackgroundColor      = txtBxWeight.BackgroundColor,
                BorderColor          = txtBxWeight.BorderColor,
                BorderSize           = txtBxWeight.BorderSize,
                FocusBackgroundColor = txtBxWeight.FocusBackgroundColor,
                FocusBorderColor     = txtBxWeight.FocusBorderColor,
                PlaceholderColor     = txtBxWeight.PlaceholderColor,
                Enabled              = txtBxWeight.Enabled,
            };
            txtBxReps.KeyPress += KeyPressDigitOnly;



            // adding the controls
            var controls = new List<Control>
            {
                lblSet,
                lblPrevious,
                txtBxWeight,
                txtBxReps,
            };
            foreach (var ctrl in controls)
            {
                setRow.Controls.Add(ctrl);
            }
            setRow.BackColor = Color.FromArgb(50, 50, 50);

            parent.Controls.Add(setRow);
            parent.Controls.SetChildIndex(setRow, parent.Controls.Count - 2); // Add above "Add Set" button

            return setRow.Height; 
        }


        private int RemoveExerciseSetRow(Panel parent)
        {
            var latestPanel = parent.Controls.OfType<Panel>().OrderByDescending(p => (int)p.Tag).FirstOrDefault();
            var x = parent.Controls.OfType<Panel>().Count() + 1;

            if (latestPanel != null)
            {
                parent.Controls.Remove(latestPanel);
                latestPanel.Dispose();
            }

            return latestPanel.Height;
        }


        private void ClearWorkoutCreationTemplates()
        {
            var toRemove = new List<Control>();

            foreach (Control ctrl in flowLayoutPanel_WorkoutCreation.Controls)
            {
                if (ctrl is Panel panel && panel.Tag is int)
                {
                    toRemove.Add(panel);
                }
            }

            foreach (var ctrl in toRemove)
            {
                flowLayoutPanel_WorkoutCreation.Controls.Remove(ctrl);
                ctrl.Dispose(); 
            }
        }


        private void KeyPressDigitOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((cuiTextBox2)sender).Text.IndexOf('.') > -1)   // prevents multiple decimal points
            {
                e.Handled = true;
            }
        }


        private void ResizeTextBoxToFitContents(TextBox textBox)
        {
            var size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            textBox.Height = size.Height + 10;
        }


        private void RenameTitleAndChart(object sender, EventArgs e)
        {
            var btn = sender as cuiButton;
            var controls = new List<Control>
            {
                label_Measurement_Name, 
                label_AddingMeasurement_Name,
                textBox_Measurement_ChartName, 
            };
            var noUnit = new List<Control>
            {
                cuiButton_Measure_BodyFatPercentage, 
                cuiButton_Measure_CaloricIntake
            };
            foreach (var ctrl in controls)
            {
                ctrl.Text = btn.Content + ((noUnit.Contains(btn) || ctrl == label_AddingMeasurement_Name) ? "" : (btn.Content.Contains("Weight")) ? " (lbs)" : " (cm)");
                if (ctrl == label_AddingMeasurement_Name && btn.Content.Contains("percentage")) 
                    ctrl.Text = btn.Content.Replace("percentage", "%");
            }
            var txtBx = cuiTextBox_Measurement_AddingMeasurement;
            txtBx.PlaceholderText = (btn.Content.Contains("Body")) ? "%" : (btn.Content.Contains("Caloric")) ? "kcal" : (btn.Content.Contains("Weight")) ? "lbs" : "cm";
        }


        private void AddMeasurement()
        {
            // TODO: IMPLEMENTATION
        }


        private void DarkenBackground(Panel panel, bool flag)
        {
            var controls = new List<Control>();

            if (panel == panel_Measurement_AddingMeasurement)
            {
                controls =  new List<Control>
                {
                    textBox_Measurement_ChartName,
                    flowLayoutPanel_Measurement,
                    panel_Measurement_Title,
                    cuiChartLine_Measurement,
                    cuiGradientBorder_Measurement,
                };
            }

            if (panel == panel_WorkoutCreation_TemplateDeletion)
            {
                controls = new List<Control>
                {
                    panel_WorkoutCreation_Title,
                    panel_WorkoutCreation_TemplateName,
                    flowLayoutPanel_WorkoutCreation,
                    cuiButton_WorkoutCreation_Exit,
                    cuiButton_WorkoutCreation_Save,
                    cuiGradientBorder_WorkoutCreation,
                };
            }
            controls.AddRange(new List<Control>
            {
                cuiGradientBorder_AboveMenu,
                panel_Form_Title, 
                panel_Menus, 
                button_Exit, 
            });

            foreach (var ctrl in controls)
            {
                ctrl.BackColor = (flag) ? Color.FromArgb(17, 20, 22) : Color.FromArgb(41, 50, 54); ;
                if (ctrl is cuiGradientBorder border) 
                    border.PanelColor2 = (flag) ? Color.FromArgb(17, 20, 22): Color.FromArgb(35, 43, 47);
            }
        }


        private void DisableEnableControls(Panel panel, bool flag)
        {
            var controls = new List<Control>();
            if (panel == panel_Measurement_AddingMeasurement)
                controls = new List<Control> { cuiButton_Measurement_GoBack };
            if (panel == panel_WorkoutCreation_TemplateDeletion)
            {
                controls = new List<Control>
                {
                    cuiButton_WorkoutCreation_Exit,
                    cuiButton_WorkoutCreation_Save,
                    cuiButton_WorkoutCreation_EditName,
                    cuiButton_WorkoutCreation_AddExercise,
                    cuiTextBox_WorkoutCreation_TemplateName,
                    cuiTextBox_WorkoutCreation_Note,
                };
            }

            foreach (var ctrl in controls)
            {
                ctrl.Enabled = !flag;
            }

            foreach (cuiButton ctrl in panel_Menus.Controls)
            {
                ctrl.Enabled = !flag;
            }

            InnerControls(flowLayoutPanel_WorkoutCreation);

            return;

            void InnerControls(Control ctrl)
            {
                foreach (Control innerCtrl in ctrl.Controls)
                {
                    switch (innerCtrl)
                    {
                        case Panel innerPanel:
                            InnerControls(innerPanel);
                            break;
                        case cuiButton btnCtrl:
                            btnCtrl.Enabled = !flag;
                            break;
                    }
                }
            }
        }


        private void ShowHideTemplateDeletionPrompt(object sender, EventArgs e)
        {
            var btn = sender as cuiButton;
            var hasAddedExercises = flowLayoutPanel_WorkoutCreation.Controls.Count > 2;
            isDeletingWorkoutTemplate = hasAddedExercises && btn == cuiButton_WorkoutCreation_Exit;
            ShowHideSubPanel(panel_WorkoutCreation_TemplateDeletion, isDeletingWorkoutTemplate);
            if (btn == cuiButton_TemplateDeletion_Delete || (!hasAddedExercises && btn == cuiButton_WorkoutCreation_Exit))
                cuiButton_Menu_Workout_Click(sender, e);
            else if (btn == cuiButton_TemplateDeletion_Cancel)
                ShowHideSubPanel(panel_WorkoutCreation_TemplateDeletion, isDeletingWorkoutTemplate);
        } 











        // TEST METHOD
        private void button_TEST_MASTER_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel_Exercises.Controls)
            {
                if (ctrl is cuiButton btn)
                {
                    int id = (int)btn.Tag;

                    if (selectedExerciseIDs.Contains(id))
                    {
                        selectedExerciseIDs.Remove(id);
                        (btn.NormalBackground, btn.HoverBackground) = (Color.Transparent, Color.Transparent);
                    }
                    else
                    {
                        selectedExerciseIDs.Add(id);
                        (btn.NormalBackground, btn.HoverBackground) = (Color.FromArgb(44, 79, 104), Color.FromArgb(44, 79, 104));
                    }
                }
            }
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";
        }

        
    }
}
