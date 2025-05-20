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
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static TrainSMARTApp.User;

namespace TrainSMARTApp
{
    public partial class MainForm: Form
    {
        // for dragging the form
        private bool _mouseDown;
        private Point _lastLocation;

        // for workout timer
        private Timer workoutTimer;
        private DateTime workoutStartTime;

        // sql connection string
        private string connectionString = "Data Source=LAPTOP-R9RSTS0G\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";

        private bool isFilterShown;
        private bool isAddingExercises;
        private bool isAddingMeasurement;
        private bool isViewingWorkoutTemplate;
        private bool isCreatingWorkoutTemplate;
        private bool isDeletingWorkoutTemplate;

        private int selectedTemplateIdToDelete = 0;

        private readonly User _loggedInUser;

        private List<int> selectedExerciseIDs = new List<int>();

        private HashSet<string> repsOnlyExercises = new HashSet<string>()
        {
            "V-Ups",
            "Sit-Up",
            "Burpee",
            "Push-Up",
            "Crunches",
            "Jump Rope",
            "Jump Squat",
            "Toe Touches",
            "Jumping Jacks",
            "Russian Twist",
            "Flat Leg Raise",
            "Rowing (Machine)",
            "Bicycle Crunches",
            "Mountain Climbers",
        };
        private HashSet<string> timeOnlyExercises = new HashSet<string>()
        {
            "Plank",
            "Stretching",
            "High Knees",
            "Stair Climber",
            "Hollow Body Hold",
            "Elliptical Trainer",
            "Cycling (Stationary)",
        };











        public MainForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // menu panels size in design (513, 661)
            // panel size in code (0, 537)

            // cuiGradientBorder_AboveMenu size (513, 10)
            // panel_Menus size (513, 82)

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    AddPrebuiltTemplatesForUser(_loggedInUser.UserID, connectionString);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panel_Form_Title.MouseDown += this.MouseDown;
            this.panel_Form_Title.MouseMove += this.MouseMove;
            this.panel_Form_Title.MouseUp += this.MouseUp;

            LoadUserWorkoutTemplates(_loggedInUser);
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
            isViewingWorkoutTemplate = false;
            isCreatingWorkoutTemplate = false;
            ShowMenu(panel_Menu_Workout, cuiButton_Menu_Workout);
            ClearWorkoutCreationTemplates();
            LoadUserWorkoutTemplates(_loggedInUser);
        }

        private void cuiButton_Menu_Exercises_Click(object sender, EventArgs e)
        {
            var (pnl, btn) = ExerciseDetailsPreviousPanel();
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
            var pnl = (isViewingWorkoutTemplate) ? panel_WorkoutTemplate : panel_WorkoutCreation;
            ShowMenu(pnl, cuiButton_Menu_Workout);
            selectedExerciseIDs.Clear();
        }


            // WORKOUT CREATION MENU

        private void cuiButton_WorkoutCreation_Exit_Click(object sender, EventArgs e)
        {
            isCreatingWorkoutTemplate = false;
            ShowHideTemplateDeletionPrompt(sender, e);
            ResetTextBoxes();
        }

        private void cuiButton_WorkoutCreation_Save_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            if (SaveExerciseTemplate())
                cuiButton_Menu_Workout_Click(sender, e);
        }

        private void cuiButton_WorkoutCreation_EditName_Click(object sender, EventArgs e)
        {
            cuiTextBox_WorkoutCreation_TemplateName.Focus();
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
            var pnl = (isViewingWorkoutTemplate) ? panel_WorkoutTemplate : panel_WorkoutCreation;
            ShowMenu(pnl, cuiButton_Menu_Workout);
            var flPnl = (isViewingWorkoutTemplate) ? flowLayoutPanel_WorkoutTemplate : flowLayoutPanel_WorkoutCreation;
            ExerciseConfirmAdd(flPnl);
        }


            // TEMPLATE 

        private void cuiButton_WorkoutTemplate_GoBack_Click(object sender, EventArgs e)
        {
            var templateId = (int)((cuiButton)sender).Tag;
            isViewingWorkoutTemplate = false;
            if (templateId > 5)
                UpdateExerciseTemplate(templateId);
            ShowMenu(panel_Menu_Workout, cuiButton_Menu_Workout);

            textBox_WorkoutTemplate_Name.ReadOnly = true;
            cuiBorder_WorkoutTemplate_Name.Visible = !textBox_WorkoutTemplate_Name.ReadOnly;
            textBox_WorkoutTemplate_Name.BackColor = Color.FromArgb(41, 50, 54);
        }

        private void cuiButton_WorkoutTemplate_Start_Click(object sender, EventArgs e)
        {
            StartWorkoutFromTemplate(_loggedInUser.UserID, (int)((cuiButton)sender).Tag);
        }

        private void cuiButton_WorkoutTemplate_Delete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Are you sure you want to delete this template? This action cannot be undone.", "Delete Template", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        
            // TEMPLATE DELETION PROMPT BUTTONS

        private void cuiButton_TemplateDeletion_Click(object sender, EventArgs e)
        {
            ShowHideTemplateDeletionPrompt(sender, e);
        }

        private void cuiButton_TemplateDeletion_Cancel_Click(object sender, EventArgs e)
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





            // GENERAL FUNCTIONS

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


        private void KeyDownLoseFocus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Enter or Keys.Escape)
            {
                e.SuppressKeyPress = true;
                ((Control)sender).Parent.Focus(); // Moves focus to parent

                if (sender is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.BackColor = Color.FromArgb(41, 50, 54);
                    if (textBox == textBox_WorkoutTemplate_Name)
                        cuiBorder_WorkoutTemplate_Name.Visible = !textBox_WorkoutTemplate_Name.ReadOnly;
                }
            }
        }











        // SHOWING PANELS

        private void ShowMenu(Panel panel, cuiButton button)
        {
            var panels = new List<Panel>
            {
                panel_Menu_Profile,
                panel_Menu_History,

                panel_Menu_Workout,
                panel_WorkoutCreation,
                panel_WorkoutTemplate,

                panel_Menu_Exercises,
                panel_ExerciseDetails,

                panel_Menu_Measure,
                panel_Measurement,
            };

            var longPanels = new HashSet<Panel>
            {
                panel_WorkoutCreation,
                panel_WorkoutTemplate,
                panel_ExerciseDetails,
            };

            foreach (var pnl in panels)
            {
                pnl.Visible = pnl == panel;
                pnl.Height = (pnl == panel) ? (longPanels.Contains(pnl) || (isAddingExercises && pnl == panel_Menu_Exercises)) ? 611 : 537 : 0;
            }
            cuiButton_WorkoutTemplate_Start.Visible = panel == panel_WorkoutTemplate;
            //panel_Menus.Height = (longPanels.Contains(panel)) ? 0 : 67;

            if (panel == panel_Menu_Exercises)
            {
                ShowHideExerciseFilter("true");
                ShowHideExerciseSearchBar(false);
            }
            ShowHideExerciseLabelsAndButtons();

            if (panel == panel_WorkoutCreation)
                ResetTextBoxes();

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
            if (sender is not cuiButton btn) return;

            label_AddingMeasurement_CurrentDate.Text = DateTime.Today.ToString("MM/dd/yy");
            isAddingMeasurement = btn == cuiButton_Measurement_AddMeasurement;

            ShowHideSubPanel(panel_Measurement_AddingMeasurement, isAddingMeasurement);
        }


        private void ShowHideExerciseSearchBar(bool isShown)
        {
            var panel = panel_Exercises_Search;
            panel.Width = (isShown) ? 321 : 0;  // width in design is 441
            panel.BringToFront();

            var cuiBtn = cuiButton_AddExercise_Exit;
            cuiBtn.Visible = !isShown;
            cuiBtn.Width = !isShown ? 80 : 0;

            cuiTextBox_Exercises_Search.Focus();
        }


        private void ShowHideExerciseFilter(string isShown = "")
        {
            var border = cuiBorder_Exercises_Filter;
            if (!string.IsNullOrWhiteSpace(isShown))
                isFilterShown = Convert.ToBoolean(isShown);
            isFilterShown = !isFilterShown;
            border.Height = (isFilterShown) ? 75 : 0;   // height in design is 93
            border.BringToFront();

            //if (isFilterShown) return;
            //foreach (var cb in cuiBorder_Exercises_Filter.Controls.OfType<cuiCheckbox>())
            //{
            //    cb.Checked = false;
            //}
        }


        private void ShowHideExerciseLabelsAndButtons()
        {
            var exerciseMenuControls = new List<Control>
            {
                cuiButton_AddExercise_ConfirmAdd,
                cuiButton_AddExercise_Exit,
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


        private bool ShowHideTemplateDeletionPrompt(object sender, EventArgs e)
        {
            var button = sender as cuiButton;

            var hasAddedExercises = flowLayoutPanel_WorkoutCreation.Controls.Count > 2;

            isDeletingWorkoutTemplate = 
                (button == cuiButton_WorkoutCreation_Exit && hasAddedExercises) ||
                button == cuiButton_WorkoutTemplate_Delete;

            ShowHideSubPanel(panel_TemplateDeletion, isDeletingWorkoutTemplate);

            if (button == cuiButton_TemplateDeletion_Delete && isViewingWorkoutTemplate)
            {
                foreach (Control panel in flowLayoutPanel_Workout.Controls)
                {
                    if (panel.Tag is not int tag || tag != selectedTemplateIdToDelete) continue;

                    var deleted = DeleteWorkoutTemplate(selectedTemplateIdToDelete);
                    if (!deleted) continue;

                    flowLayoutPanel_Workout.Controls.Remove(panel);
                    panel.Dispose();

                    break;
                }

                cuiButton_Menu_Workout_Click(sender, e);
                return true;
            }

            if (button == cuiButton_TemplateDeletion_Delete || (!hasAddedExercises && button == cuiButton_WorkoutCreation_Exit))
            {
                cuiButton_Menu_Workout_Click(sender, e);
                return true;
            }

            if (button == cuiButton_TemplateDeletion_Cancel)
                ShowHideSubPanel(panel_TemplateDeletion, false);

            return false;
        }


        private void ShowTemplateDetails(bool isPrebuilt)
        {
            isViewingWorkoutTemplate = true;
            ShowMenu(panel_WorkoutTemplate, cuiButton_Menu_Workout);

            cuiButton_WorkoutTemplate_Delete.Visible = !isPrebuilt;

            var panel = new Panel
            {
                Width       = 360,
                Height      = 80,
                Margin      = new Padding(3, 5, 3, 10),
                BackColor   = Color.Transparent,
                BorderStyle = BorderStyle.None,  
            };
            flowLayoutPanel_WorkoutTemplate.Controls.Add(panel);
        }





        




            // MAIN FUNCTIONS

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

                        var btn = CreateExerciseButton(exerciseId, exerciseName, muscleGroup);

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


        private void ExerciseConfirmAdd(FlowLayoutPanel flowLayoutPanel)
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

                    var panelExercise = CreateExercisePanel(exerciseId, exerciseName, false);

                    AddExerciseSetRow(panelExercise, exerciseName, false);

                    var index = 2;
                    if (isViewingWorkoutTemplate)
                        index = 3;

                    flowLayoutPanel.Controls.Add(panelExercise);
                    flowLayoutPanel.Controls.SetChildIndex(panelExercise, flowLayoutPanel.Controls.Count - index); // Add above "Add Exercise" button
                }
            }
            selectedExerciseIDs.Clear();
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";
            cuiTextBox_Exercises_Search.Content = "";
        }


        public int AddExerciseSetRow(Panel parent, string exerciseName, bool isPrebuilt, decimal? weight = null, int? reps = null, int? repsOnly = null, int? time = null)
        {
            var setNumber = parent.Controls.OfType<Panel>().Count();
            if (isPrebuilt) setNumber += 1;

            var setTag = (int)parent.Controls.OfType<Panel>().Count() + 999;

            var setRow= CreateExerciseSetRow(parent, (int)parent.Tag, exerciseName, setNumber, setTag, weight, reps, repsOnly, time);

            parent.Controls.Add(setRow);
            parent.Controls.SetChildIndex(setRow, parent.Controls.Count - 2); // Add above "Add Set" button

            return setRow.Height; 
        }


        private int RemoveExerciseSetRow(Panel parent)
        {
            var latestPanel = parent.Controls.OfType<Panel>().OrderByDescending(p => (int)p.Tag).FirstOrDefault();
            var setPanels = parent.Controls.OfType<Panel>().Where(p => (int)p.Tag > 999).ToList();
            var currentFlowLayoutPanel = parent.Parent;

            if (setPanels.Count <= 1)
                currentFlowLayoutPanel.Controls.Remove(parent);

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
                if (ctrl is Panel { Tag: int } panel)
                {
                    toRemove.Add(panel);
                }
            }

            foreach (var ctrl in toRemove)
            {
                flowLayoutPanel_WorkoutCreation.Controls.Remove(ctrl);
                ctrl.Dispose(); 
            }

            ResetTextBoxes();
        }


        private bool SaveExerciseTemplate()
        {
            if (flowLayoutPanel_WorkoutCreation.Controls.OfType<Panel>().Count() < 2) return false;

            var txtBoxName = cuiTextBox_WorkoutCreation_TemplateName.Content;
            var txtBoxNote = cuiTextBox_WorkoutCreation_Note.Content;

            string templateName = (!string.IsNullOrWhiteSpace(txtBoxName)) ? txtBoxName?.Trim() : "New workout template";
            string workoutNote = (!string.IsNullOrWhiteSpace(txtBoxNote)) ? txtBoxNote?.Trim() : "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert Workout Template
                    string queryTemplate = @"INSERT INTO WorkoutTemplates (UserID, TemplateName, Note, DateCreated) 
                                    OUTPUT INSERTED.TemplateID 
                                    VALUES (@UserID, @TemplateName, @Note, @DateCreated)";
                    SqlCommand cmdTemplate = new SqlCommand(queryTemplate, conn, transaction);
                    cmdTemplate.Parameters.AddWithValue("@UserID", _loggedInUser.UserID);
                    cmdTemplate.Parameters.AddWithValue("@TemplateName", templateName);
                    cmdTemplate.Parameters.AddWithValue("@Note", workoutNote);
                    cmdTemplate.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                    int templateId = (int)cmdTemplate.ExecuteScalar();

                    int exerciseOrder = 0;
                    foreach (Panel exercisePanel in flowLayoutPanel_WorkoutCreation.Controls.OfType<Panel>().Where(p => p.Height > 211))
                    {
                        int exerciseId = (int)exercisePanel.Tag;

                        if (!(exercisePanel.Tag is int))
                            MessageBox.Show("Exercise panel is missing a valid ExerciseID in its Tag.");


                        int restSeconds = 60; // Default

                        // TODO: read rest time from a control inside exercisePanel, if you have it

                        // 2. Insert WorkoutTemplateExercise
                        string queryExercise = @"INSERT INTO WorkoutTemplateExercises 
                                        (TemplateID, ExerciseID, RestSeconds, DisplayOrder) 
                                        OUTPUT INSERTED.TemplateExerciseID 
                                        VALUES (@TemplateID, @ExerciseID, @RestSeconds, @DisplayOrder)";
                        SqlCommand cmdExercise = new SqlCommand(queryExercise, conn, transaction);
                        cmdExercise.Parameters.AddWithValue("@TemplateID", templateId);
                        cmdExercise.Parameters.AddWithValue("@ExerciseID", exerciseId);
                        cmdExercise.Parameters.AddWithValue("@RestSeconds", restSeconds);
                        cmdExercise.Parameters.AddWithValue("@DisplayOrder", exerciseOrder++);

                        int templateExerciseId = (int)cmdExercise.ExecuteScalar();

                        // TEST
                        var setPanels = exercisePanel.Controls
                            .OfType<Panel>()
                            .Where(p => p.Height == 58 && p.Tag is >= 1000)
                            .ToList();

                        MessageBox.Show($"Found {setPanels.Count} sets for ExerciseID {exerciseId}");   // TODO: REMOVE

                        int setOrder = 0;
                        foreach (Panel setPanel in exercisePanel.Controls.OfType<Panel>().Where(p => p.Tag is >= 1000))
                        {
                            cuiTextBox2 txtWeight = setPanel.Controls.Find("cuiTextBox_Weight", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtReps = setPanel.Controls.Find("cuiTextBox_Reps", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtRepsOnly = setPanel.Controls.Find("cuiTextBox_RepsOnly", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtTime = setPanel.Controls.Find("cuiTextBox_Time", true).FirstOrDefault() as cuiTextBox2;

                            object weight = decimal.TryParse(txtWeight?.Text, out var w) ? (object)w : DBNull.Value;
                            object reps = decimal.TryParse(txtReps?.Text, out var r) ? (object)r : DBNull.Value;
                            object repsOnly = decimal.TryParse(txtReps?.Text, out var rO) ? (object)rO : DBNull.Value;
                            object time = int.TryParse(txtTime?.Text, out var t) ? (object)t : DBNull.Value;

                            // 3. Insert WorkoutTemplateExerciseSets
                            string querySet = @"INSERT INTO WorkoutTemplateExerciseSets 
                                        (TemplateExerciseID, WeightLbs, Reps, RepsOnly, TimeSeconds, SetOrder) 
                                        VALUES (@TemplateExerciseID, @WeightLbs, @Reps, @RepsOnly, @TimeSeconds, @SetOrder)";
                            SqlCommand cmdSet = new SqlCommand(querySet, conn, transaction);

                            cmdSet.Parameters.AddWithValue("@TemplateExerciseID", templateExerciseId);
                            cmdSet.Parameters.Add("@WeightLbs", SqlDbType.Decimal).Value = weight;
                            cmdSet.Parameters.AddWithValue("@Reps", reps);
                            cmdSet.Parameters.AddWithValue("@RepsOnly", repsOnly);
                            cmdSet.Parameters.AddWithValue("@TimeSeconds", time);
                            cmdSet.Parameters.AddWithValue("@SetOrder", setOrder++);

                            cmdSet.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Template saved successfully!");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving template: " + ex.Message);

                    return false;
                }
            }
        }


        private bool UpdateExerciseTemplate(int templateId)
        {
            var txtBoxName = textBox_WorkoutTemplate_Name.Text;

            string templateName = (!string.IsNullOrWhiteSpace(txtBoxName)) ? txtBoxName?.Trim() : "New workout template";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Update Workout Template Header
                    string updateTemplateQuery = @"
                        UPDATE WorkoutTemplates 
                        SET TemplateName = @TemplateName 
                        WHERE TemplateID = @TemplateID";
                    SqlCommand cmdUpdateTemplate = new SqlCommand(updateTemplateQuery, conn, transaction);
                    cmdUpdateTemplate.Parameters.AddWithValue("@TemplateName", templateName);
                    //cmdUpdateTemplate.Parameters.AddWithValue("@Note", workoutNote);
                    cmdUpdateTemplate.Parameters.AddWithValue("@TemplateID", templateId);
                    cmdUpdateTemplate.ExecuteNonQuery();

                    // 2. Delete existing exercises and sets
                    string deleteSetsQuery = @"
                        DELETE FROM WorkoutTemplateExerciseSets 
                        WHERE TemplateExerciseID 
                        IN (SELECT TemplateExerciseID 
                        FROM WorkoutTemplateExercises 
                        WHERE TemplateID = @TemplateID)";
                    SqlCommand deleteSets = new SqlCommand(deleteSetsQuery, conn, transaction);
                    deleteSets.Parameters.AddWithValue("@TemplateID", templateId);
                    deleteSets.ExecuteNonQuery();

                    string deleteExercisesQuery = @"
                        DELETE FROM WorkoutTemplateExercises 
                        WHERE TemplateID = @TemplateID";
                    SqlCommand deleteExercises = new SqlCommand(deleteExercisesQuery, conn, transaction);
                    deleteExercises.Parameters.AddWithValue("@TemplateID", templateId);
                    deleteExercises.ExecuteNonQuery();

                    // 3. Re-insert all exercises and sets
                    int exerciseOrder = 0;
                    foreach (Panel exercisePanel in flowLayoutPanel_WorkoutTemplate.Controls.OfType<Panel>().Where(p => p.Height > 211))
                    {
                        int exerciseId = (int)exercisePanel.Tag;

                        int restSeconds = 60; // Default

                        string queryExercise = @"INSERT INTO WorkoutTemplateExercises 
                                (TemplateID, ExerciseID, RestSeconds, DisplayOrder) 
                                OUTPUT INSERTED.TemplateExerciseID 
                                VALUES (@TemplateID, @ExerciseID, @RestSeconds, @DisplayOrder)";
                        SqlCommand cmdExercise = new SqlCommand(queryExercise, conn, transaction);
                        cmdExercise.Parameters.AddWithValue("@TemplateID", templateId);
                        cmdExercise.Parameters.AddWithValue("@ExerciseID", exerciseId);
                        cmdExercise.Parameters.AddWithValue("@RestSeconds", restSeconds);
                        cmdExercise.Parameters.AddWithValue("@DisplayOrder", exerciseOrder++);

                        int templateExerciseId = (int)cmdExercise.ExecuteScalar();

                        int setOrder = 0;
                        foreach (Panel setPanel in exercisePanel.Controls.OfType<Panel>().Where(p => p.Tag is int tag && tag >= 1000))
                        {
                            cuiTextBox2 txtWeight = setPanel.Controls.Find("cuiTextBox_Weight", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtReps = setPanel.Controls.Find("cuiTextBox_Reps", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtRepsOnly = setPanel.Controls.Find("cuiTextBox_RepsOnly", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtTime = setPanel.Controls.Find("cuiTextBox_Time", true).FirstOrDefault() as cuiTextBox2;

                            object weight = decimal.TryParse(txtWeight?.Content, out var w) ? (object)w : DBNull.Value;
                            object reps = decimal.TryParse(txtReps?.Content, out var r) ? (object)r : DBNull.Value;
                            object time = int.TryParse(txtTime?.Content, out var t) ? (object)t : DBNull.Value;
                            object repsOnly = decimal.TryParse(txtRepsOnly?.Content, out var rO) ? (object)rO : DBNull.Value;

                            MessageBox.Show($"{weight}");

                            string querySet = @"INSERT INTO WorkoutTemplateExerciseSets 
                                (TemplateExerciseID, WeightLbs, Reps, RepsOnly, TimeSeconds, SetOrder) 
                                VALUES (@TemplateExerciseID, @WeightLbs, @Reps, @RepsOnly, @TimeSeconds, @SetOrder)";
                            SqlCommand cmdSet = new SqlCommand(querySet, conn, transaction);

                            cmdSet.Parameters.AddWithValue("@TemplateExerciseID", templateExerciseId);
                            cmdSet.Parameters.Add("@WeightLbs", SqlDbType.Decimal).Value = weight;
                            cmdSet.Parameters.AddWithValue("@Reps", reps);
                            cmdSet.Parameters.AddWithValue("@RepsOnly", repsOnly);
                            cmdSet.Parameters.AddWithValue("@TimeSeconds", time);
                            cmdSet.Parameters.AddWithValue("@SetOrder", setOrder++);

                            cmdSet.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Template updated successfully!");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error updating template: " + ex.Message);
                    return false;
                }
            }
        }


        private void LoadUserWorkoutTemplates(User currentUser)
        {
            // Clear previously loaded templates
            foreach (var ctrl in flowLayoutPanel_Workout.Controls.OfType<Control>().ToList())
            {
                if (ctrl is cuiButton { Tag: int } btn)
                {
                    flowLayoutPanel_Workout.Controls.Remove(btn);
                    btn.Dispose();
                }
            }

            using SqlConnection conn = new SqlConnection(connectionString);
            string query = @"
                    SELECT TemplateID, TemplateName, Note, DateCreated, IsPrebuilt
                    FROM WorkoutTemplates
                    WHERE UserID = @UserID
                    ORDER BY DateCreated DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int templateId = reader.GetInt32(reader.GetOrdinal("TemplateID"));
                    string templateName = reader.GetString(reader.GetOrdinal("TemplateName"));
                    string note = reader.IsDBNull(reader.GetOrdinal("Note")) ? "" : reader.GetString(reader.GetOrdinal("Note"));
                    DateTime createdDate = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                    bool isPrebuilt = reader.GetBoolean(reader.GetOrdinal("IsPrebuilt"));   //  TODO: USE THIS TO TRIGGER UPDATE TEMPLATE

                    var cuiBtnTemplate = CreateTemplateButton(templateId, templateName, note, isPrebuilt);
                    flowLayoutPanel_Workout.Controls.Add(cuiBtnTemplate);

                    var index = flowLayoutPanel_Workout.Controls.OfType<cuiButton>().Count(b => b.Tag is int);
                    label_Workout_EmptyTemplateMsg.Visible = !(index > 5);

                    if (isPrebuilt)
                        index += 2;
                    
                    flowLayoutPanel_Workout.Controls.SetChildIndex(cuiBtnTemplate, index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load workout templates:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTemplateExercises(int selectedTemplateId, bool isPrebuilt)
        {
            // Clear previously loaded exercises
            foreach (var ctrl in flowLayoutPanel_WorkoutTemplate.Controls.OfType<Panel>().ToList().Where(ctrl => ctrl is Panel { Tag: int } || ctrl.Height == 80))
            {
                flowLayoutPanel_WorkoutTemplate.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Retrieve exercises in the selected template
                string exerciseQuery = @"
                    SELECT wte.TemplateExerciseID, wte.ExerciseID, e.ExerciseName
                    FROM WorkoutTemplateExercises wte
                    JOIN Exercises e ON wte.ExerciseID = e.ExerciseID
                    WHERE wte.TemplateID = @TemplateID
                    ORDER BY wte.DisplayOrder";

                var templateExercises = new List<(int TemplateExerciseId, int ExerciseId, string ExerciseName)>();

                using (SqlCommand cmd = new SqlCommand(exerciseQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TemplateID", selectedTemplateId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int templateExerciseId = reader.GetInt32(0);
                            int exerciseId = reader.GetInt32(1);
                            string exerciseName = reader.GetString(2);

                            templateExercises.Add((templateExerciseId, exerciseId, exerciseName));
                        }
                    }
                }

                // Reader is now closed; safe to call LoadExerciseSets
                foreach (var (templateExerciseId, exerciseId, exerciseName) in templateExercises)
                {
                    var exercisePanel = CreateExercisePanel(exerciseId, exerciseName, isPrebuilt);
                    int addedRowHeight = LoadTemplateExerciseSets(conn, exercisePanel, templateExerciseId, exerciseName, isPrebuilt);
                    exercisePanel.Height += addedRowHeight;
                    flowLayoutPanel_WorkoutTemplate.Controls.Add(exercisePanel);
                    flowLayoutPanel_WorkoutTemplate.Controls.SetChildIndex(exercisePanel, flowLayoutPanel_WorkoutTemplate.Controls.Count - 2); // Add above "Add Exercise" button
                }
            }
            cuiButton_WorkoutTemplate_AddExercise.Visible = selectedTemplateId > 5;
        }


        private int LoadTemplateExerciseSets(SqlConnection conn, Panel parentPanel, int templateExerciseId, string exerciseName, bool isPrebuilt)
        {
            int addedRowHeight = 0, i = 0; 
            var previousSets = GetLastSetData(_loggedInUser.UserID, (int)parentPanel.Tag);
            int setIndex = 0;

            string setQuery = @"
                SELECT WeightLbs, Reps, RepsOnly, TimeSeconds
                FROM WorkoutTemplateExerciseSets
                WHERE TemplateExerciseID = @TemplateExerciseID
                ORDER BY SetOrder";

            using (SqlCommand cmd = new SqlCommand(setQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TemplateExerciseID", templateExerciseId);
                using (SqlDataReader reader = cmd.ExecuteReader()) // TODO: THERE IS A PROBLEM WITH THIS
                {
                    while (reader.Read())
                    {
                        decimal? weight = reader.IsDBNull(0) ? null : reader.GetDecimal(0);
                        int? reps = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                        int? repsOnly = reader.IsDBNull(2) ? null : reader.GetInt32(2);
                        int? time = reader.IsDBNull(3) ? null : reader.GetInt32(3);

                        //if (setIndex < previousSets.Count)
                        //{
                        //    (weight, reps, repsOnly, time) = previousSets[setIndex];

                        //    //string text = "";

                        //    //if (weight != null && reps != null)
                        //    //    text = $"{weight} lbs × {reps}";
                        //    //else if (time != null)
                        //    //    text = $"{time} sec";
                        //}

                        addedRowHeight = AddExerciseSetRow(parentPanel, exerciseName, isPrebuilt, weight, reps, repsOnly, time);
                        setIndex++;
                        i++;
                    }
                }
            }
            return addedRowHeight * (i - 1);
        }


        private bool DeleteWorkoutTemplate(int selectedTemplateId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Delete sets associated with the exercises in the template
                    string deleteSetsQuery = @"
                        DELETE FROM WorkoutTemplateExerciseSets
                        WHERE TemplateExerciseID IN (
                            SELECT TemplateExerciseID FROM WorkoutTemplateExercises WHERE TemplateID = @TemplateID
                        )";
                    SqlCommand cmdDeleteSets = new SqlCommand(deleteSetsQuery, conn, transaction);
                    cmdDeleteSets.Parameters.AddWithValue("@TemplateID", selectedTemplateId);
                    cmdDeleteSets.ExecuteNonQuery();

                    // 2. Delete exercises from the template
                    string deleteExercisesQuery = "DELETE FROM WorkoutTemplateExercises WHERE TemplateID = @TemplateID";
                    SqlCommand cmdDeleteExercises = new SqlCommand(deleteExercisesQuery, conn, transaction);
                    cmdDeleteExercises.Parameters.AddWithValue("@TemplateID", selectedTemplateId);
                    cmdDeleteExercises.ExecuteNonQuery();

                    // 3. Delete the template itself
                    string deleteTemplateQuery = "DELETE FROM WorkoutTemplates WHERE TemplateID = @TemplateID";
                    SqlCommand cmdDeleteTemplate = new SqlCommand(deleteTemplateQuery, conn, transaction);
                    cmdDeleteTemplate.Parameters.AddWithValue("@TemplateID", selectedTemplateId);
                    cmdDeleteTemplate.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Template deleted successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error deleting template: " + ex.Message);
                    return false;
                }
            }
        }


        private List<(decimal? weight, int? reps, int? repsOnly, int? timeSeconds)> GetLastSetData(int userId, int exerciseId)
        {
            string query = @"
                SELECT wtes.WeightLbs, wtes.Reps, wtes.RepsOnly, wtes.TimeSeconds
                FROM WorkoutTemplateExerciseSets wtes
                INNER JOIN WorkoutTemplateExercises wte ON wtes.TemplateExerciseID = wte.TemplateExerciseID
                INNER JOIN WorkoutTemplates wt ON wte.TemplateID = wt.TemplateID
                WHERE wt.UserID = @UserID 
                  AND wte.ExerciseID = @ExerciseID
                  AND (wtes.WeightLbs IS NOT NULL OR wtes.Reps IS NOT NULL OR wtes.RepsOnly IS NOT NULL OR wtes.TimeSeconds IS NOT NULL)
                  AND wt.DateCreated = (
                      SELECT MAX(DateCreated)
                      FROM WorkoutTemplates wt2
                      INNER JOIN WorkoutTemplateExercises wte2 ON wt2.TemplateID = wte2.TemplateID
                      WHERE wt2.UserID = @UserID AND wte2.ExerciseID = @ExerciseID
                  )
                ORDER BY wtes.SetOrder ASC";

            var setDataList = new List<(decimal? weight, int? reps, int? repsOnly, int? timeSeconds)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ExerciseID", exerciseId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal? weight = reader.IsDBNull(0) ? null : reader.GetDecimal(0);
                        int? reps = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                        int? repsOnly = reader.IsDBNull(2) ? null : reader.GetInt32(2);
                        int? time = reader.IsDBNull(3) ? null : reader.GetInt32(3);

                        setDataList.Add((weight, reps, repsOnly, time));
                    }
                }
            }

            return setDataList;
        }


        private int StartWorkoutFromTemplate(int userId, int templateId)
        {
            int workoutId = -1;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Insert new workout
                string insertWorkoutQuery = @"
                    INSERT INTO Workouts (UserID, TemplateID)
                    OUTPUT INSERTED.WorkoutID
                    VALUES (@UserID, @TemplateID)";

                using (var cmd = new SqlCommand(insertWorkoutQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@TemplateID", templateId);

                    workoutId = (int)cmd.ExecuteScalar();
                }

                // Step 2: Copy template exercises to WorkoutExercises
                string copyExercisesQuery = @"
                    INSERT INTO WorkoutExercises (WorkoutID, ExerciseID, DisplayOrder)
                    SELECT @WorkoutID, ExerciseID, DisplayOrder
                    FROM WorkoutTemplateExercises
                    WHERE TemplateID = @TemplateID";

                using (var cmd = new SqlCommand(copyExercisesQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkoutID", workoutId);
                    cmd.Parameters.AddWithValue("@TemplateID", templateId);

                    cmd.ExecuteNonQuery();
                }
            }

            if (workoutId > 0)
                StartWorkoutTimer();

            return workoutId;
        }













        // HELPER FUNCTIONS
        private (Panel, cuiButton) ExerciseDetailsPreviousPanel()
        {
            Panel pnl;
            cuiButton btn;

            if (isCreatingWorkoutTemplate)
            {
                pnl = panel_WorkoutCreation;
                btn = cuiButton_Menu_Workout;
            }
            else if (isViewingWorkoutTemplate)
            {
                pnl = panel_WorkoutTemplate;
                btn = cuiButton_Menu_Workout;
            }
            else 
            {
                pnl = panel_Menu_Exercises;
                btn = cuiButton_Menu_Exercises;
            }

            return (pnl, btn);
        }


        private void ResetTextBoxes()
        {
            if (isCreatingWorkoutTemplate) return;
            cuiTextBox_WorkoutCreation_TemplateName.Content = "";
            cuiTextBox_WorkoutCreation_Note.Content = "";
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
                    flowLayoutPanel_Measurement,
                    panel_Measurement_Title,
                    cuiChartLine_Measurement,
                    cuiGradientBorder_Measurement,
                    textBox_Measurement_ChartName,
                };
            }
            if (panel == panel_TemplateDeletion)
            {
                if (isViewingWorkoutTemplate)
                    controls = new List<Control>
                    {
                        panel_WorkoutTemplate,
                        panel_WorkoutTemplate_Title,
                        textBox_WorkoutTemplate_Name,
                        flowLayoutPanel_WorkoutTemplate,
                        cuiButton_WorkoutTemplate_GoBack,
                        cuiButton_WorkoutTemplate_Delete,
                        cuiGradientBorder_WorkoutTemplate,
                    };
                else
                    controls = new List<Control>
                    {
                        flowLayoutPanel_WorkoutCreation,
                        panel_WorkoutCreation_Title,
                        panel_WorkoutCreation_TemplateName,
                        cuiButton_WorkoutCreation_Exit,
                        cuiButton_WorkoutCreation_Save,
                        cuiGradientBorder_WorkoutCreation,
                        cuiTextBox_WorkoutCreation_TemplateName,
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
                switch (ctrl)
                {
                    case cuiGradientBorder border:
                        border.PanelColor2 = (flag) ? Color.FromArgb(17, 20, 22): Color.FromArgb(35, 43, 47);
                        break;
                    case cuiTextBox2 textBox:
                        textBox.BackgroundColor = (flag) ? Color.FromArgb(17, 20, 22) : Color.FromArgb(41, 50, 54);
                        break;
                }
            }

            return;

            void InnerControls(Control ctrl)
            {
                foreach (Panel innerCtrl in ctrl.Controls.OfType<Panel>().Where(p => p.Height == 58 && p.Tag is >= 1000).ToList())
                {
                    innerCtrl.BackColor = (flag) ? Color.FromArgb(17, 20, 22) : Color.FromArgb(41, 50, 54); ;
                }
            }
        }


        private void DisableEnableControls(Panel panel, bool flag)
        {
            var controls = new List<Control>();
            if (panel == panel_Measurement_AddingMeasurement)
                controls = new List<Control> { cuiButton_Measurement_GoBack };
            if (panel == panel_TemplateDeletion)
            {
                if (isViewingWorkoutTemplate)
                    controls = new List<Control>
                    {
                        textBox_WorkoutTemplate_Name,
                        cuiButton_WorkoutTemplate_Start,
                        cuiButton_WorkoutTemplate_GoBack,
                        cuiButton_WorkoutTemplate_Delete,
                        cuiButton_WorkoutTemplate_AddExercise,
                    };
                else
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
            InnerControls(flowLayoutPanel_WorkoutTemplate);

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


        private void StartWorkoutTimer()
        {
            workoutStartTime = DateTime.Now;

            if (workoutTimer == null)
            {
                workoutTimer = new Timer();
                workoutTimer.Interval = 1000; // 1 second
                workoutTimer.Tick += WorkoutTimer_Tick;
            }

            workoutTimer.Start();
        }


        private void WorkoutTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - workoutStartTime;
            //label_WorkoutTimer.Text = elapsed.ToString(@"hh\:mm\:ss");
        }




















        // CREATING CONTROLS

        private cuiButton CreateExerciseButton(int exerciseId, string exerciseName, string muscleGroup)
        {
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
                btn.Click += ExerciseSelectToggle;
            else
                btn.Click += ShowExerciseDetails;

            return btn;
        }

        private Panel CreateExercisePanel(int exerciseId, string exerciseName, bool isPrebuilt)
        {
            // Main Panel
            var panelExercise = new Panel
            {
                Width       = 360,
                Height      = 211,
                Tag         = exerciseId,
                Margin      = new Padding(3, 5, 3, 10),
                BackColor   = Color.Transparent,
                BorderStyle = BorderStyle.None,  
            };

            // Exercise Name Button
            var cuiButtonExerciseName = new cuiButton
            {
                Content           = exerciseName,
                Font              = new Font("SansSerif", 14),// FontStyle.Bold),
                ForeColor         = Color.FromArgb(53, 167, 255),
                Dock              = DockStyle.Top,
                Height            = 60,
                Tag               = exerciseId,
                TextOffset        = new Point(0, -1), 

                BackColor         = Color.Transparent,
                HoverBackground   = Color.Transparent,
                HoverForeColor    = Color.LightSkyBlue,
                NormalBackground  = Color.Transparent,
                NormalForeColor   = Color.FromArgb(53, 167, 255),
                PressedBackground = Color.FromArgb(84, 91, 94),
                PressedForeColor  = Color.White,
            };
            cuiButtonExerciseName.Click += ShowExerciseDetails;

            // Labels
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
                Location  = new Point(lblPrevious.Location.X + 127, lblPrevious.Location.Y),
            };

            var lblReps = new Label
            {
                Text      = "REPS",
                Font      = lblWeight.Font,
                Width     = lblWeight.Width + 10,
                Height    = lblWeight.Height,
                ForeColor = lblWeight.ForeColor,
                TextAlign = lblWeight.TextAlign,
                Location  = new Point(lblWeight.Location.X + 64, lblWeight.Location.Y),
            };

            var lblTime = new Label
            {
                Text      = "TIME",
                Font      = lblWeight.Font,
                Width     = lblWeight.Width + 10,
                Height    = lblWeight.Height,
                ForeColor = lblWeight.ForeColor,
                TextAlign = lblWeight.TextAlign,
                Location  = new Point(lblWeight.Location.X + 25, lblWeight.Location.Y),
            };

            var lblRepsOnly = new Label
            {
                Text      = "REPS",
                Font      = lblTime.Font,
                Width     = lblTime.Width,
                Height    = lblTime.Height,
                ForeColor = lblTime.ForeColor,
                TextAlign = lblTime.TextAlign,
                Location  = new Point(lblTime.Location.X, lblTime.Location.Y),
            };


            // Buttons
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
                var addedRowHeight= AddExerciseSetRow(parent, exerciseName, isPrebuilt);
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

            panelCuiButtons.Controls.Add(cuiButtonAddSet);
            panelCuiButtons.Controls.Add(cuiButtonRemoveSet);

            var controls =
                (timeOnlyExercises.Contains(exerciseName))
                    ? new List<Control> { lblTime }
                    : (repsOnlyExercises.Contains(exerciseName))
                        ? new List<Control> { lblRepsOnly }
                        : new List<Control> { lblWeight, lblReps, };
            controls.AddRange(new List<Control>
            {
                cuiButtonExerciseName,
                lblSet,
                lblPrevious,
                panelCuiButtons
            });

            if (isPrebuilt)
            {
                controls.Remove(panelCuiButtons);
                panelExercise.Height -= panelCuiButtons.Height;
            }

            foreach (var ctrl in controls)
            {
                panelExercise.Controls.Add(ctrl);
            }
            return panelExercise;
        }


        private Panel CreateExerciseSetRow(Panel parent, int exerciseId, string exerciseName, int setNumber, object setTag, decimal? weight, decimal? reps, decimal? repsOnly, int? time)
        {
            var setRow = new Panel
            {
                Height    = 58,
                Width     = parent.Width,
                Dock      = DockStyle.Bottom,
                Tag       = setTag,
                BackColor = Color.Transparent,
            };

            var lblSet = new Label
            {
                Text      = setNumber.ToString(),
                Width     = 35,
                Location  = new Point(0,15),
                Font      = new Font("SansSerif", 13),
                ForeColor = Color.FromArgb(53, 167, 255),
                TextAlign = ContentAlignment.MiddleRight,
                //BackColor = Color.Transparent,
            };

            var lblPrevious = new Label
            {
                Text      = (timeOnlyExercises.Contains(exerciseName)) ? $"{time} sec" : (repsOnlyExercises.Contains(exerciseName)) ? $"{repsOnly} reps" : $"{weight.Value:G29} lbs × {reps}",
                Width     = 120,
                Location  = new Point(55, 16),
                Font      = new Font("SansSerif", 12),
                ForeColor = Color.FromArgb(191, 194, 195),
                TextAlign = ContentAlignment.MiddleLeft,
                //BackColor = Color.Transparent,
            };

            var txtBxWeight = new cuiTextBox2
            {
                Name                 = "cuiTextBox_Weight",
                Width                = 62,
                Height               = 40,
                Location             = new Point(179, 6), 
                Font                 = new Font("SansSerif", 12),
                Rounding             = new Padding(8),
                Margin               = new Padding(20,0,20,0),
                ForeColor            = Color.White,
                BackColor            = Color.Transparent,
                BackgroundColor      = Color.FromArgb(61, 70, 73),
                BorderColor          = Color.FromArgb(61, 70, 73),
                BorderSize           = 0,
                FocusBackgroundColor = Color.FromArgb(61, 70, 73),
                FocusBorderColor     = Color.FromArgb(61, 70, 73),
                PlaceholderColor     = Color.FromArgb(158, 163, 164),
                Enabled              = !isCreatingWorkoutTemplate,
            };
            txtBxWeight.KeyPress += KeyPressDigitOnly;

            var txtBxReps = new cuiTextBox2
            {
                Name                 = "cuiTextBox_Reps",
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

            var txtBxTime = new cuiTextBox2
            {
                Name                 = "cuiTextBox_Time",
                Width                = 132,
                Height               = 40,
                Location             = new Point(179, 6),
                Font                 = new Font("SansSerif", 12),
                Rounding             = new Padding(8),
                Margin               = new Padding(20, 0, 20, 0),
                ForeColor            = Color.White,
                BackColor            = Color.Transparent,
                BackgroundColor      = Color.FromArgb(61, 70, 73),
                BorderColor          = Color.FromArgb(61, 70, 73),
                BorderSize           = 0,
                FocusBackgroundColor = Color.FromArgb(61, 70, 73),
                FocusBorderColor     = Color.FromArgb(61, 70, 73),
                PlaceholderColor     = Color.FromArgb(158, 163, 164),
                Enabled              = txtBxWeight.Enabled,
            };
            txtBxTime.KeyPress += KeyPressDigitOnly;

            var txtBxRepsOnly = new cuiTextBox2
            {
                Name                 = "cuiTextBox_RepsOnly",
                Width                = txtBxTime.Width,
                Height               = txtBxTime.Height,
                Location             = txtBxTime.Location,
                Font                 = txtBxTime.Font,
                Rounding             = txtBxTime.Rounding,
                Margin               = txtBxTime.Margin,
                ForeColor            = txtBxTime.ForeColor,
                BackColor            = txtBxTime.BackColor,
                BackgroundColor      = txtBxTime.BackgroundColor,
                BorderColor          = txtBxTime.BorderColor,
                BorderSize           = txtBxTime.BorderSize,
                FocusBackgroundColor = txtBxTime.FocusBackgroundColor,
                FocusBorderColor     = txtBxTime.FocusBorderColor,
                PlaceholderColor     = txtBxTime.PlaceholderColor,
                Enabled              = txtBxTime.Enabled,
            };
            txtBxRepsOnly.KeyPress += KeyPressDigitOnly;

            // Add correct controls based on exercise type
            var controls =
                (timeOnlyExercises.Contains(exerciseName))
                    ? new List<Control> { txtBxTime }
                    : (repsOnlyExercises.Contains(exerciseName))
                        ? new List<Control> { txtBxRepsOnly }
                        : new List<Control> { txtBxWeight, txtBxReps };

            controls.AddRange(new List<Control>
            {
                lblSet,
                lblPrevious
            });

            foreach (var ctrl in controls)
            {
                setRow.Controls.Add(ctrl);
            }

            return setRow;
        }


        private cuiButton CreateTemplateButton(int templateId, string templateName, string note, bool isPrebuilt)
        {
            var btnTemplate = new cuiButton
            {
                Width             = 335,
                Height            = 75,
                Margin            = new Padding(15, 15, 15, 4),
                Font              = new Font("SansSerif", 14, FontStyle.Bold),
                Content           = $"{templateName}",// - {createdDate:MMM dd, yyyy}",
                Tag               = templateId,

                BackColor         = Color.Transparent,
                HoverBackground   = Color.Transparent,
                HoverForeColor    = Color.DimGray,
                HoverOutline      = Color.FromArgb(95, 102, 105),
                NormalBackground  = Color.Transparent,
                NormalForeColor   = Color.White,
                NormalOutline     = Color.FromArgb(95, 102, 105),
                PressedBackground = Color.FromArgb(84, 91, 94),
                PressedForeColor  = Color.White,
                PressedOutline    = Color.FromArgb(95, 102, 105),
                OutlineThickness  = 1.5f,
            };

            // TODO: MAKE THIS SHOW 
            var lblNote = new Label
            {
                Text      = note,
                Font      = new Font("SansSerif", 10, FontStyle.Italic),
                ForeColor = Color.FromArgb(147, 152, 154),
                Dock      = DockStyle.Bottom,
                Height    = 20,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            if (!string.IsNullOrWhiteSpace(note))
            {
                btnTemplate.Controls.Add(lblNote);      // TODO: Enhance
                btnTemplate.Height += 10;
                btnTemplate.TextOffset = new Point(0, -5);
            }

            // Optional: store additional info like note in Tag if needed

            btnTemplate.Click += (s, _) =>
            {
                var selectedTemplateId = (int)((cuiButton)s).Tag;
                LoadTemplateExercises(selectedTemplateId, isPrebuilt);
                ShowTemplateDetails(isPrebuilt);
                cuiButton_WorkoutTemplate_GoBack.Tag = selectedTemplateId;
                cuiButton_WorkoutTemplate_Start.Tag = selectedTemplateId;
                textBox_WorkoutTemplate_Name.Text = templateName;

                textBox_WorkoutTemplate_Name.Click += (_, _) =>
                {
                    textBox_WorkoutTemplate_Name.ReadOnly = true;
                    cuiBorder_WorkoutTemplate_Name.Visible = !textBox_WorkoutTemplate_Name.ReadOnly;
                    textBox_WorkoutTemplate_Name.BackColor = Color.FromArgb(41, 50, 54);
                };
                textBox_WorkoutTemplate_Name.DoubleClick += (_, _) =>
                {
                    textBox_WorkoutTemplate_Name.ReadOnly = false;
                    cuiBorder_WorkoutTemplate_Name.Visible = !textBox_WorkoutTemplate_Name.ReadOnly;
                    textBox_WorkoutTemplate_Name.BackColor = Color.FromArgb(63, 71, 75);
                    Focus();
                };
                cuiButton_WorkoutTemplate_Delete.Click += (sender, e) =>
                {
                    cuiButton_WorkoutTemplate_Delete.Tag = selectedTemplateId;
                    foreach (Control panel in flowLayoutPanel_Workout.Controls)
                    {
                        if (panel.Tag is not int tag || tag != selectedTemplateId) continue;
                        selectedTemplateIdToDelete = selectedTemplateId;
                        var confirmDelete = ShowHideTemplateDeletionPrompt(cuiButton_WorkoutTemplate_Delete, e);

                        if (!confirmDelete) return;
                        var deleted = DeleteWorkoutTemplate(selectedTemplateId);

                        if (!deleted) return;

                        flowLayoutPanel_Workout.Controls.Remove(panel);
                        panel.Dispose(); 

                        break;
                    }
                };
            };

            return btnTemplate;
        }




















        // ADD DEFAULT EXERCISES TO USER'S DATABASE

        public void AddPrebuiltTemplatesForUser(int userId, string connString)
        {
            var templates = new List<(string TemplateName, List<(string ExerciseName, int Sets)>)>
            {
                ("Workout B", new List<(string, int)>
                {
                    ("Squat (Barbell)", 5),
                    ("Overhead Press (Barbell)", 5),
                    ("Deadlift (Barbell)", 1),
                }),
                ("Workout A", new List<(string, int)>
                {
                    ("Squat (Barbell)", 5),
                    ("Bench Press (Barbell)", 5),
                    ("Bent Over Row (Barbell)", 5),
                }),
                ("Back and Biceps", new List<(string, int)>
                {
                    ("Deadlift (Barbell)", 3),
                    ("Seated Row (Cable)", 3),
                    ("Lat Pulldown (Cable)", 3),
                    ("Bicep Curl (Barbell)", 3),
                }),
                ("Chest and Triceps", new List<(string, int)>
                {
                    ("Bench Press (Barbell)", 3),
                    ("Incline Bench Press (Barbell)", 3),
                    ("Strict Military Press (Barbell)", 3),
                    ("Lateral Raise (Dumbbell)", 3),
                    ("Skullcrusher (Barbell)", 3),
                }),
                ("Legs", new List<(string, int)>
                {
                    ("Squat (Barbell)", 3),
                    ("Leg Extension (Machine)", 3),
                    ("Flat Leg Raise", 3),
                    ("Standing Calf Raise (Dumbbell)", 3),
                }),
            };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                foreach (var template in templates)
                {
                    string templateName = template.TemplateName;
                    var exercises = template.Item2;

                    // Check for existing prebuilt template
                    string checkQuery = @"SELECT COUNT(*) FROM WorkoutTemplates WHERE UserID = @UserID AND TemplateName = @TemplateName AND IsPrebuilt = 1";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserID", userId);
                        checkCmd.Parameters.AddWithValue("@TemplateName", templateName);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0) continue;
                    }

                    // Insert new template
                    string insertTemplate = @"INSERT INTO WorkoutTemplates (UserID, TemplateName, IsPrebuilt) OUTPUT INSERTED.TemplateID VALUES (@UserID, @TemplateName, 1)";
                    int templateId;
                    using (SqlCommand insertCmd = new SqlCommand(insertTemplate, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@UserID", userId);
                        insertCmd.Parameters.AddWithValue("@TemplateName", templateName);
                        templateId = (int)insertCmd.ExecuteScalar();
                    }

                    int displayOrder = 0;
                    foreach (var exercise in exercises)
                    {
                        string exerciseName = exercise.ExerciseName;
                        int sets = exercise.Sets;

                        // Get ExerciseID by name
                        string getExerciseIdQuery = "SELECT ExerciseID FROM Exercises WHERE ExerciseName = @Name";
                        int exerciseId;
                        using (SqlCommand getExerciseCmd = new SqlCommand(getExerciseIdQuery, conn))
                        {
                            getExerciseCmd.Parameters.AddWithValue("@Name", exerciseName);
                            object result = getExerciseCmd.ExecuteScalar();
                            if (result == null) continue; // Skip if exercise not found
                            exerciseId = (int)result;
                        }

                        // Insert WorkoutTemplateExercise
                        string insertExercise = @"INSERT INTO WorkoutTemplateExercises (TemplateID, ExerciseID, RestSeconds, DisplayOrder) OUTPUT INSERTED.TemplateExerciseID VALUES (@TemplateID, @ExerciseID, 60, @Order)";
                        int templateExerciseId;
                        using (SqlCommand insertExerciseCmd = new SqlCommand(insertExercise, conn))
                        {
                            insertExerciseCmd.Parameters.AddWithValue("@TemplateID", templateId);
                            insertExerciseCmd.Parameters.AddWithValue("@ExerciseID", exerciseId);
                            insertExerciseCmd.Parameters.AddWithValue("@Order", displayOrder++);
                            templateExerciseId = (int)insertExerciseCmd.ExecuteScalar();
                        }

                        // Insert sets
                        for (int i = 0; i < sets; i++)
                        {
                            string insertSet = @"INSERT INTO WorkoutTemplateExerciseSets (TemplateExerciseID, SetOrder) VALUES (@TemplateExerciseID, @SetOrder)";
                            using (SqlCommand insertSetCmd = new SqlCommand(insertSet, conn))
                            {
                                insertSetCmd.Parameters.AddWithValue("@TemplateExerciseID", templateExerciseId);
                                insertSetCmd.Parameters.AddWithValue("@SetOrder", i);
                                insertSetCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
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
