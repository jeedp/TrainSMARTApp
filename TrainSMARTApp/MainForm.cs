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
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private bool isWorkingOut;
        private bool isFilterShown;
        private bool isAddingExercises;
        private bool isAddingMeasurement;
        private bool isViewingWorkoutHistory;
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

            LoadUserWorkoutHistory(_loggedInUser);
            LoadUserWorkoutTemplates(_loggedInUser);
            LoadExerciseButtons(null, null);
            LoadWeeklyWorkoutChart(chart_Profile_WorkoutCount, _loggedInUser.UserID, connectionString);
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
            cuiTextBox_AddingMeasurement.KeyPress += KeyPressDigitOnly;

            label_Profile_Username.Text = _loggedInUser.Username;
            label_Profile_WorkoutCount.Text = _loggedInUser.WorkoutCount + (_loggedInUser.WorkoutCount == 1 ? " workout" : " workouts");
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
            LoadUserWorkoutHistory(_loggedInUser);
        }

        private void cuiButton_Menu_Workout_Click(object sender, EventArgs e)
        {
            if (isCreatingWorkoutTemplate)
                ClearWorkoutCreationTemplates();
            isWorkingOut = false;
            isAddingExercises = false;
            isViewingWorkoutTemplate = false;
            isCreatingWorkoutTemplate = false;
            ShowMenu(panel_Menu_Workout, cuiButton_Menu_Workout);
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
            var pnl = (isViewingWorkoutTemplate) ? panel_WorkoutTemplate : (isWorkingOut) ? panel_WorkingOut : panel_WorkoutCreation;
            ShowMenu(pnl, cuiButton_Menu_Workout);
            selectedExerciseIDs.Clear();
        }


        private void cuiButton_Workout_QuickStart_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_WorkingOut, cuiButton_Menu_Workout);     // TODO: IMPLEMENTATION
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

        private void cuiButton_AddExercise_Click(object sender, EventArgs e)
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
            var pnl = (isViewingWorkoutTemplate) ? panel_WorkoutTemplate : (isWorkingOut) ? panel_WorkingOut : panel_WorkoutCreation;
            ShowMenu(pnl, cuiButton_Menu_Workout);
            var flPnl = (isViewingWorkoutTemplate) ? flowLayoutPanel_WorkoutTemplate : (isWorkingOut) ? flowLayoutPanel_WorkingOut : flowLayoutPanel_WorkoutCreation;
            ExerciseConfirmAdd(flPnl);
        }

        private void cuiButton_AddExercise_Exit_Click(object sender, EventArgs e)
        {
            cuiButton_Workout_AddTemplate_Click(sender, e);
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

        private void cuiButton_WorkoutTemplate_Start_Click(object sender, EventArgs e)      // TODO: WORKING ON THIS
        {
            var templateId = (int)((cuiButton)sender).Tag;
            var control = (cuiButton)sender;
            isWorkingOut = true;
            isViewingWorkoutTemplate = false;
            ShowMenu(panel_WorkingOut, cuiButton_Menu_Workout);
            LoadTemplateExercises(flowLayoutPanel_WorkingOut, templateId, false);
            StartWorkoutTimer();
            var label =  control.Parent.Controls.Find("label_Note", true).FirstOrDefault() as Label;
            cuiTextBox_WorkingOut_Name.Content = textBox_WorkoutTemplate_Name.Text;
            if (label != null) cuiTextBox_WorkingOut_Note.Content = label.Text;
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


        // STARTING WORKOUT

        private void cuiButton_WorkingOut_EditName_Click(object sender, EventArgs e)
        {
            cuiTextBox_WorkingOut_Name.Focus();
        }

        private void cuiButton_WorkingOut_CancelWorkout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel workout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);   // TODO: Enhance
            if (result == DialogResult.Yes)
            {
                isWorkingOut = false;
                ResetWorkoutTimer();
                cuiButton_Menu_Workout_Click(sender, e);
            }
        }

        private void cuiButton_WorkingOut_Finish_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Finish workout?", "" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  // TODO: Enhance
            if (result == DialogResult.Yes)
            {
                isWorkingOut = false;
                ResetWorkoutTimer();
                LogWorkout(((cuiButton)sender).Tag);
                LoadWeeklyWorkoutChart(chart_Profile_WorkoutCount, _loggedInUser.UserID, connectionString);
                cuiButton_Menu_Workout_Click(sender, e);
            }
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
            var columnName = ((cuiButton)sender).Tag;
            var unit = RenameTitleAndChart(sender);
            ShowHideAddingMeasurementPanel(sender, e);
            ShowMenu(panel_Measurement, cuiButton_Menu_Measure);
            LoadMeasurements(_loggedInUser.UserID, columnName.ToString(), unit);
            LoadMeasurementChart(_loggedInUser.UserID, columnName.ToString());
            cuiButton_AddingMeasurement_Save.Tag = columnName;
        }

            // MEASUREMENT MENU
        private void cuiButton_AddingMeasurement_Click(object sender, EventArgs e)
        {
            ShowHideAddingMeasurementPanel(sender, e);
        }

                // ADDING MEASUREMENT
        private void cuiButton_AddingMeasurement_Save_Click(object sender, EventArgs e)
        {
            var columnName = cuiButton_AddingMeasurement_Save.Tag.ToString();
            if (SaveMeasurementField(_loggedInUser.UserID, columnName))
            {
                LoadMeasurements(_loggedInUser.UserID, columnName, cuiTextBox_AddingMeasurement.PlaceholderText);
                LoadMeasurementChart(_loggedInUser.UserID, columnName);
                ShowHideAddingMeasurementPanel(sender, e);
            }
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
                panel_WorkingOut,

                panel_Menu_Exercises,
                panel_ExerciseDetails,

                panel_Menu_Measure,
                panel_Measurement,
            };

            var longPanels = new HashSet<Panel>
            {
                panel_WorkoutCreation,
                panel_WorkoutTemplate,
                panel_WorkingOut,
                panel_ExerciseDetails,
            };

            foreach (var pnl in panels)
            {
                pnl.Visible = pnl == panel;
                pnl.Height = (pnl == panel) ? (longPanels.Contains(pnl) || (isAddingExercises && pnl == panel_Menu_Exercises)) ? 611 : 537 : 0;
            }
            isViewingWorkoutHistory = panel == panel_Menu_History;
            cuiButton_WorkoutTemplate_Start.Visible = panel == panel_WorkoutTemplate;

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
            cuiTextBox_AddingMeasurement.Content = "";

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


        private void ShowTemplateDetails(string note, bool isPrebuilt)
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
            var label = new Label
            {
                Name      = "label_Note",
                Text      = note,
                Dock      = DockStyle.Top,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(41, 50, 54),
            };

            panel.Controls.Add(label);
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
                    if (isViewingWorkoutTemplate || isWorkingOut)
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

            if (isViewingWorkoutTemplate)
            {

            }


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
                    string queryTemplate = @"
                        INSERT INTO WorkoutTemplates (UserID, TemplateName, Note, DateCreated) 
                        OUTPUT INSERTED.TemplateID 
                        VALUES (@UserID, @TemplateName, @Note, @DateCreated)";
                    SqlCommand cmdTemplate = new SqlCommand(queryTemplate, conn, transaction);
                    cmdTemplate.Parameters.AddWithValue("@UserID", _loggedInUser.UserID);
                    cmdTemplate.Parameters.AddWithValue("@TemplateName", templateName);
                    cmdTemplate.Parameters.AddWithValue("@Note", workoutNote);
                    cmdTemplate.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                    int templateId = (int)cmdTemplate.ExecuteScalar();

                    int exerciseOrder = 0;
                    foreach (Panel exercisePanel in flowLayoutPanel_WorkoutCreation.Controls.OfType<Panel>().Where(p => p.Height > 210))
                    {
                        int exerciseId = (int)exercisePanel.Tag;

                        if (!(exercisePanel.Tag is int))
                            MessageBox.Show("Exercise panel is missing a valid ExerciseID in its Tag.");    // TODO: REMOVE


                        int restSeconds = 60; // Default

                        // TODO: read rest time from a control inside exercisePanel

                        // 2. Insert WorkoutTemplateExercise
                        string queryExercise = @"
                            INSERT INTO WorkoutTemplateExercises 
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
                            object reps = int.TryParse(txtReps?.Text, out var r) ? (object)r : DBNull.Value;
                            object repsOnly = int.TryParse(txtRepsOnly?.Text, out var rO) ? (object)rO : DBNull.Value;
                            object time = int.TryParse(txtTime?.Text, out var t) ? (object)t : DBNull.Value;

                            // 3. Insert WorkoutTemplateExerciseSets
                            string querySet = @"
                                INSERT INTO WorkoutTemplateExerciseSets 
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
            //var previousSets = GetLastSetData(_loggedInUser.UserID, exerciseId);
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
                    foreach (Panel exercisePanel in flowLayoutPanel_WorkoutTemplate.Controls.OfType<Panel>().Where(p => p.Height > 210))
                    {
                        int exerciseId = (int)exercisePanel.Tag;

                        int restSeconds = 60; // Default

                        string queryExercise = @"
                            INSERT INTO WorkoutTemplateExercises 
                            (TemplateID, ExerciseID, RestSeconds, DisplayOrder) 
                            OUTPUT INSERTED.TemplateExerciseID 
                            VALUES (@TemplateID, @ExerciseID, @RestSeconds, @DisplayOrder)";
                        SqlCommand cmdExercise = new SqlCommand(queryExercise, conn, transaction);
                        cmdExercise.Parameters.AddWithValue("@TemplateID", templateId);
                        cmdExercise.Parameters.AddWithValue("@ExerciseID", exerciseId);
                        cmdExercise.Parameters.AddWithValue("@RestSeconds", restSeconds);
                        cmdExercise.Parameters.AddWithValue("@DisplayOrder", exerciseOrder++);

                        int templateExerciseId = (int)cmdExercise.ExecuteScalar();

                        //int setIndex = 0;
                        int setOrder = 0;
                        foreach (Panel setPanel in exercisePanel.Controls.OfType<Panel>().Where(p => p.Tag is int tag && tag >= 1000))
                        {

                            cuiTextBox2 txtWeight = setPanel.Controls.Find("cuiTextBox_Weight", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtReps = setPanel.Controls.Find("cuiTextBox_Reps", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtTime = setPanel.Controls.Find("cuiTextBox_Time", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtRepsOnly = setPanel.Controls.Find("cuiTextBox_RepsOnly", true).FirstOrDefault() as cuiTextBox2;

                            object weight = decimal.TryParse(txtWeight?.Content, out var w) ? (object)w : DBNull.Value;
                            object reps = int.TryParse(txtReps?.Content, out var r) ? (object)r : DBNull.Value;
                            object repsOnly = int.TryParse(txtRepsOnly?.Content, out var rO) ? (object)rO : DBNull.Value;
                            object time = int.TryParse(txtTime?.Content, out var t) ? (object)t : DBNull.Value;

                            string querySet = @"
                                INSERT INTO WorkoutTemplateExerciseSets 
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
                            //setIndex++;
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Template updated successfully!");      // TODO: REMOVE
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


        private void LoadTemplateExercises(FlowLayoutPanel flowLayoutPanel, int selectedTemplateId, bool isPrebuilt)
        {
            // Clear previously loaded exercises
            foreach (var ctrl in flowLayoutPanel.Controls.OfType<Panel>().ToList().Where(ctrl => ctrl is Panel { Tag: int } || ctrl.Height == 80))
            {
                flowLayoutPanel.Controls.Remove(ctrl);
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

                int indexToDisplay = 2;
                if (flowLayoutPanel == flowLayoutPanel_WorkingOut) indexToDisplay += 1;

                // Reader is now closed; safe to call LoadExerciseSets
                foreach (var (templateExerciseId, exerciseId, exerciseName) in templateExercises)
                {
                    var exercisePanel = CreateExercisePanel(exerciseId, exerciseName, isPrebuilt);
                    int addedRowHeight = LoadTemplateExerciseSets(conn, exercisePanel, templateExerciseId, exerciseName, isPrebuilt);
                    exercisePanel.Height += addedRowHeight;
                    flowLayoutPanel.Controls.Add(exercisePanel);
                    flowLayoutPanel.Controls.SetChildIndex(exercisePanel, flowLayoutPanel.Controls.Count - indexToDisplay); // Add above "Add Exercise" button
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
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal? weight = reader.IsDBNull(0) ? null : reader.GetDecimal(0);
                        int? reps = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                        int? repsOnly = reader.IsDBNull(2) ? null : reader.GetInt32(2);
                        int? time = reader.IsDBNull(3) ? null : reader.GetInt32(3);

                        // If previous set data exists, use it instead
                        if (setIndex < previousSets.Count)
                        {
                            var set = previousSets[setIndex];
                            weight = set.weight;
                            reps = set.reps;
                            repsOnly = set.repsOnly;
                            time = set.timeSeconds;
                        }
                        else
                        {
                            // Explicitly make everything null if no previous data
                            weight = null;
                            reps = null;
                            repsOnly = null;
                            time = null;
                        }

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
                SELECT wes.WeightLbs, wes.Reps, wes.RepsOnly, wes.TimeSeconds
                FROM WorkoutExerciseSets wes
                INNER JOIN WorkoutExercises we ON wes.WorkoutExerciseID = we.WorkoutExerciseID
                INNER JOIN Workouts w ON we.WorkoutID = w.WorkoutID
                WHERE w.UserID = @UserID
                  AND we.ExerciseID = @ExerciseID
                  AND (wes.WeightLbs IS NOT NULL OR wes.Reps IS NOT NULL OR wes.RepsOnly IS NOT NULL OR wes.TimeSeconds IS NOT NULL)
                  AND w.DatePerformed = (
                      SELECT MAX(w2.DatePerformed)
                      FROM Workouts w2
                      INNER JOIN WorkoutExercises we2 ON w2.WorkoutID = we2.WorkoutID
                      WHERE w2.UserID = @UserID AND we2.ExerciseID = @ExerciseID
                  )
                ORDER BY wes.SetOrder ASC";

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



        //private int StartWorkoutFromTemplate(int userId, int templateId)
        //{
        //    int workoutId = -1;

        //    using (var conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        // Step 1: Insert new workout
        //        string insertWorkoutQuery = @"
        //            INSERT INTO Workouts (UserID, TemplateID)
        //            OUTPUT INSERTED.WorkoutID
        //            VALUES (@UserID, @TemplateID)";

        //        using (var cmd = new SqlCommand(insertWorkoutQuery, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@UserID", userId);
        //            cmd.Parameters.AddWithValue("@TemplateID", templateId);

        //            workoutId = (int)cmd.ExecuteScalar();
        //        }

        //        // Step 2: Copy template exercises to WorkoutExercises
        //        string copyExercisesQuery = @"
        //            INSERT INTO WorkoutExercises (WorkoutID, ExerciseID, DisplayOrder)
        //            SELECT @WorkoutID, ExerciseID, DisplayOrder
        //            FROM WorkoutTemplateExercises
        //            WHERE TemplateID = @TemplateID";

        //        using (var cmd = new SqlCommand(copyExercisesQuery, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@WorkoutID", workoutId);
        //            cmd.Parameters.AddWithValue("@TemplateID", templateId);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }

        //    if (workoutId > 0)
        //        StartWorkoutTimer();

        //    return workoutId;
        //}


        private void LogWorkout(object templateId)
        {
            TimeSpan duration = DateTime.Now - workoutStartTime;
            int durationSeconds = (int)duration.TotalSeconds;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert into Workouts
                    string insertWorkoutQuery = @"
                        INSERT INTO Workouts (UserID, DatePerformed, DurationSeconds, TemplateID, Note)
                        OUTPUT INSERTED.WorkoutID
                        VALUES (@UserID, @DatePerformed, @DurationSeconds, @TemplateID, @Note)";

                    int workoutId;
                    using (SqlCommand cmd = new SqlCommand(insertWorkoutQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _loggedInUser.UserID);
                        cmd.Parameters.AddWithValue("@DatePerformed", DateTime.Now);
                        cmd.Parameters.AddWithValue("@DurationSeconds", durationSeconds);

                        // Optional fields, you can replace with actual values
                        object note = cuiTextBox_WorkingOut_Note.Content;        // Replace if user added a note

                        cmd.Parameters.AddWithValue("@TemplateID", templateId);
                        cmd.Parameters.AddWithValue("@Note", note);

                        workoutId = (int)cmd.ExecuteScalar();
                    }

                    // 2. For each exercise panel, insert into WorkoutExercises and WorkoutExerciseSets
                    int exerciseOrder = 0;
                    foreach (Panel exercisePanel in flowLayoutPanel_WorkingOut.Controls.OfType<Panel>().Where(p => p.Height > 210))
                    {
                        if (exercisePanel.Tag is not int exerciseId) continue;

                        string insertExerciseQuery = @"
                            INSERT INTO WorkoutExercises (WorkoutID, ExerciseID, DisplayOrder)
                            OUTPUT INSERTED.WorkoutExerciseID
                            VALUES (@WorkoutID, @ExerciseID, @DisplayOrder)";

                        int workoutExerciseId;
                        using (SqlCommand cmd = new SqlCommand(insertExerciseQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@WorkoutID", workoutId);
                            cmd.Parameters.AddWithValue("@ExerciseID", exerciseId);
                            cmd.Parameters.AddWithValue("@DisplayOrder", exerciseOrder++);

                            workoutExerciseId = (int)cmd.ExecuteScalar();
                        }

                        // 3. Insert COMPLETED sets
                        int setOrder = 0;
                        foreach (Panel setRow in exercisePanel.Controls.OfType<Panel>().Where(p => p.Tag is int tag && tag >= 1000 && p.BackColor == Color.FromArgb(43, 88, 68)))
                        {
                            cuiTextBox2 txtWeight = setRow.Controls.Find("cuiTextBox_Weight", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtReps = setRow.Controls.Find("cuiTextBox_Reps", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtTime = setRow.Controls.Find("cuiTextBox_Time", true).FirstOrDefault() as cuiTextBox2;
                            cuiTextBox2 txtRepsOnly = setRow.Controls.Find("cuiTextBox_RepsOnly", true).FirstOrDefault() as cuiTextBox2;

                            object weight = decimal.TryParse(txtWeight?.Content, out var w) ? (object)w : DBNull.Value;
                            object reps = int.TryParse(txtReps?.Content, out var r) ? (object)r : DBNull.Value;
                            object repsOnly = int.TryParse(txtRepsOnly?.Content, out var rO) ? (object)rO : DBNull.Value;
                            object time = int.TryParse(txtTime?.Content, out var t) ? (object)t : DBNull.Value;

                            bool allEmpty =
                                (weight == DBNull.Value || (decimal)weight == 0) &&
                                (reps == DBNull.Value || (int)reps == 0) &&
                                (repsOnly == DBNull.Value || (int)repsOnly == 0) &&
                                (time == DBNull.Value || (int)time == 0);

                            if (allEmpty) continue;

                            string insertSetQuery = @"
                                INSERT INTO WorkoutExerciseSets (WorkoutExerciseID, WeightLbs, Reps, RepsOnly, TimeSeconds, SetOrder)
                                VALUES (@WorkoutExerciseID, @WeightLbs, @Reps, @RepsOnly, @TimeSeconds, @SetOrder)";

                            using (SqlCommand cmd = new SqlCommand(insertSetQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@WorkoutExerciseID", workoutExerciseId);
                                cmd.Parameters.AddWithValue("@WeightLbs", weight);
                                cmd.Parameters.AddWithValue("@Reps", reps);
                                cmd.Parameters.AddWithValue("@RepsOnly", repsOnly);
                                cmd.Parameters.AddWithValue("@TimeSeconds", time);
                                cmd.Parameters.AddWithValue("@SetOrder", setOrder++);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 4. Update User WorkoutCount
                    string updateUserCountQuery = @"
                        UPDATE Users
                        SET WorkoutCount = WorkoutCount + 1
                        WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(updateUserCountQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _loggedInUser.UserID);
                        cmd.ExecuteNonQuery();
                    }


                    transaction.Commit();
                    MessageBox.Show("Workout logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error logging workout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadUserWorkoutHistory(User currentUser)
        {
            // Clear previously loaded workouts
            foreach (var ctrl in flowLayoutPanel_History.Controls.OfType<Control>().ToList())
            {
                if (ctrl is cuiButton { Tag: int } btn)
                {
                    flowLayoutPanel_History.Controls.Remove(btn);
                    btn.Dispose();
                }
            }

            using SqlConnection conn = new SqlConnection(connectionString);
            string query = @"
                SELECT W.WorkoutID, W.TemplateID, W.Note, W.DatePerformed, W.DurationSeconds, T.TemplateName
                FROM Workouts W
                LEFT JOIN WorkoutTemplates T ON W.TemplateID = T.TemplateID
                WHERE W.UserID = @UserID
                ORDER BY W.DatePerformed DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    object templateId = reader.IsDBNull(reader.GetOrdinal("TemplateID")) ? null : reader.GetInt32(reader.GetOrdinal("TemplateID"));
                    string note = reader.IsDBNull(reader.GetOrdinal("Note")) ? "" : reader.GetString(reader.GetOrdinal("Note"));
                    DateTime datePerformed = reader.GetDateTime(reader.GetOrdinal("DatePerformed"));
                    int durationSeconds = reader.IsDBNull(reader.GetOrdinal("DurationSeconds")) ? 0 : reader.GetInt32(reader.GetOrdinal("DurationSeconds"));
                    string templateName = reader.IsDBNull(reader.GetOrdinal("TemplateName")) ? "Custom Workout" : reader.GetString(reader.GetOrdinal("TemplateName"));

                    string durationFormatted = TimeSpan.FromSeconds(durationSeconds).ToString(@"hh\:mm\:ss");

                    string buttonText = $" {datePerformed:MMM dd, yyyy}                             Duration: {durationFormatted}";        // TODO: CONTINUE WORKING ON THIS

                    //cuiButton workoutBtn = new cuiButton
                    //{
                    //    Text = buttonText,
                    //    Tag = workoutId,
                    //    Width = 300,
                    //    Height = 80,
                    //    Margin = new Padding(5),
                    //    Font = new Font("Segoe UI", 9F),
                    //    BackColor = Color.FromArgb(30, 30, 30),
                    //    ForeColor = Color.White,
                    //    TextAlign = ContentAlignment.MiddleLeft
                    //};

                    //// Optional: Add a click event to load details
                    //workoutBtn.Click += (s, e) =>
                    //{
                    //    int id = (int)((Control)s).Tag;
                    //    LoadWorkoutDetails(id); // You'd define this method
                    //};

                    var workoutBtn = CreateTemplateButton((int)templateId, templateName, note, false, buttonText);

                    flowLayoutPanel_History.Controls.Add(workoutBtn);
                    flowLayoutPanel_History.Controls.SetChildIndex(workoutBtn, index++);
                }

                label_History_EmptyHistoryMsg.Visible = index == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load workout history:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadWeeklyWorkoutChart(Chart chart, int userId, string connectionString)
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            DATEADD(DAY, -DATEPART(WEEKDAY, DatePerformed) + 1, CAST(DatePerformed AS DATE)) AS WeekStart,
                COUNT(*) AS WorkoutCount
            FROM Workouts
            WHERE UserID = @UserID
            GROUP BY DATEADD(DAY, -DATEPART(WEEKDAY, DatePerformed) + 1, CAST(DatePerformed AS DATE))
            ORDER BY WeekStart";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            // Clear previous chart data
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Set up the chart area
            var chartArea = new ChartArea("MainArea");
            chartArea.AxisX.LabelStyle.Format = "M/d";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Weeks;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineColor = Color.Gray;
            chartArea.AxisY.MajorGrid.LineColor = Color.Gray;
            chartArea.BackColor = Color.Transparent; // Optional dark theme

            chart.ChartAreas.Add(chartArea);

            // Create the series
            var series = new Series("Workouts")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(134, 38, 249),
                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Int32,
                IsValueShownAsLabel = true
            };

            chart.Series.Add(series);

            // Bind the data
            series.Points.DataBind(dataTable.AsEnumerable(), "WeekStart", "WorkoutCount", null);

            // Optional styling
            chart.BackColor = Color.Transparent; // Optional dark background
            chart.Legends.Clear();
        }


        private bool SaveMeasurementField(int userId, string columnName)
        {
            string valueText = cuiTextBox_AddingMeasurement.Content.Trim();

            if (string.IsNullOrWhiteSpace(valueText))
            {
                MessageBox.Show("Please enter a value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidMeasurementColumn(columnName))
            {
                MessageBox.Show("Invalid column name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using SqlConnection conn = new SqlConnection(connectionString);
            string query = $@"
                INSERT INTO Measurements (UserID, {columnName})
                VALUES (@UserID, @Value)";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);

            if (decimal.TryParse(valueText, out decimal value))
                cmd.Parameters.AddWithValue("@Value", value);
            else if (int.TryParse(valueText, out int intValue))
                cmd.Parameters.AddWithValue("@Value", intValue);
            else
            {
                MessageBox.Show("Invalid numeric input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Measurement saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save measurement:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void LoadMeasurements(int userId, string columnName, string unit)
        {
            if (!IsValidMeasurementColumn(columnName))
            {
                MessageBox.Show("Invalid measurement column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $@"
                SELECT MeasurementDate, {columnName}
                FROM Measurements
                WHERE UserID = @UserID AND {columnName} IS NOT NULL
                ORDER BY MeasurementDate DESC";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                //flowLayoutPanel_Measurement.Controls.Clear();

                foreach (var ctrl in flowLayoutPanel_Measurement.Controls.OfType<Panel>().Where(p => p.Height == 30).ToList())
                {
                    flowLayoutPanel_Workout.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }

                int index = 1;
                while (reader.Read())
                {
                    DateTime date = reader.GetDateTime(0);
                    object rawValue = reader.GetValue(1);

                    decimal value;
                    if (rawValue is int intValue)
                        value = intValue;
                    else if (rawValue is decimal decValue)
                        value = decValue;
                    else if (rawValue is double dblValue)
                        value = (decimal)dblValue;
                    else
                        value = 0;


                    //Label lbl = new Label
                    //{
                    //    AutoSize = true,
                    //    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    //    ForeColor = Color.White,
                    //    Padding = new Padding(5),
                    //    Text = $"{date:MMM d}  {date:h:mm tt}     {value} {unit}"
                    //};

                    var pnl = CreateMeasurementHistoryPanel(date, value, unit);

                    flowLayoutPanel_Measurement.Controls.Add(pnl);
                    flowLayoutPanel_Measurement.Controls.SetChildIndex(pnl, index++);
                }

                label_Measurement_EmptyMeasurementsMsg.Visible = index == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading measurements:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadMeasurementChart(int userId, string columnName)
        {
            chart_Measurements.Series.Clear();


            chart_Measurements.Series.Clear();
            chart_Measurements.ChartAreas.Clear();

            // Setup ChartArea
            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent; // Dark background

            // Axis X Styling
            area.AxisX.MajorGrid.LineColor = Color.Gray;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisX.LineColor = Color.Gray;
            area.AxisX.LabelStyle.Format = "MMM dd";
            area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            // Axis Y Styling
            area.AxisY.MajorGrid.LineColor = Color.Gray;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisY.LineColor = Color.Gray;

            area.BorderColor = Color.Transparent;

            chart_Measurements.ChartAreas.Add(area);
            chart_Measurements.BackColor = Color.Transparent; // Match form background
            chart_Measurements.BorderlineColor = Color.Transparent;




            var series = new Series("Weight (lbs)")
            {
                ChartType   = SeriesChartType.Line,
                BorderWidth = 2,
                Color       = Color.FromArgb(89, 43, 154),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize  = 7,
            };

            string query = $@"
                SELECT MeasurementDate, {columnName}
                FROM Measurements
                WHERE UserID = @UserID AND {columnName} IS NOT NULL
                ORDER BY MeasurementDate ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        object rawValue = reader.GetValue(1);

                        decimal value;
                        if (rawValue is int intValue)
                            value = intValue;
                        else if (rawValue is decimal decValue)
                            value = decValue;
                        else if (rawValue is double dblValue)
                            value = (decimal)dblValue;
                        else
                            value = 0;

                        series.Points.AddXY(date, value);
                    }
                }
            }

            chart_Measurements.Series.Add(series);
            chart_Measurements.ChartAreas[0].AxisX.LabelStyle.Format = "MMM dd";
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


        private string RenameTitleAndChart(object sender)
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
            var txtBx = cuiTextBox_AddingMeasurement;
            txtBx.PlaceholderText = (btn.Content.Contains("Body")) ? "%" : (btn.Content.Contains("Caloric")) ? "kcal" : (btn.Content.Contains("Weight")) ? "lbs" : "cm";

            return txtBx.PlaceholderText;
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
                else if (isWorkingOut)
                    controls = new List<Control>        // TODO: enhance
                    {
                        panel_WorkingOut,
                        panel_WorkingOut_Title,
                        panel_WorkingOut_TemplateName,
                        flowLayoutPanel_WorkingOut,

                    };
                else
                    controls = new List<Control>
                    {
                        panel_WorkoutCreation,
                        panel_WorkoutCreation_Title,
                        panel_WorkoutCreation_TemplateName,
                        flowLayoutPanel_WorkoutCreation,
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
            label_WorkingOut_StopWatch.Text = elapsed.ToString(@"hh\:mm\:ss");
        }


        private void ResetWorkoutTimer()
        {
            if (workoutTimer != null)
                workoutTimer.Stop();

            //workoutStartTime = DateTime.Now; // reset to now
            label_WorkingOut_StopWatch.Text = "00:00:00";
        }


        private void ConfirmSet(object sender, EventArgs eventArgs)
        {
            var checkBox = (cuiCheckbox)sender;
            var setRow = checkBox.Parent as Panel;
            var countdownButton = cuiButton_WorkingOut_Timer;

            if (setRow != null)
            {
                var confirmedColor = Color.FromArgb(43, 88, 68);
                var defaultColor = Color.FromArgb(41, 50, 54);

                var targetColor = checkBox.Checked ? confirmedColor : defaultColor;
                checkBox.BackColor = targetColor;
                setRow.BackColor = targetColor;

                foreach (var txtBox in setRow.Controls.OfType<cuiTextBox2>())
                {
                    txtBox.Enabled = !checkBox.Checked;
                }

                if (checkBox.Checked)
                {
                    int restSeconds = 60; //setRow.Tag is int tagVal ? tagVal : 60;
                    StartCountdown(countdownButton, restSeconds);                       // TODO: ENHANCE
                }
                else
                {
                    // Checkbox unchecked — stop the timer and clear the label
                    if (countdownButton?.Tag is Timer existingTimer)
                    {
                        existingTimer.Stop();
                        existingTimer.Dispose();
                        countdownButton.Tag = null;
                    }

                    if (countdownButton != null)
                    {
                        var bgColor = Color.FromArgb(61, 70, 73);
                        countdownButton.Content = "--";
                        countdownButton.PressedBackground = bgColor;
                        countdownButton.NormalBackground = bgColor;
                        countdownButton.HoverBackground = bgColor;
                    }
                }
            }

        }


        private void StartCountdown(cuiButton countdownButton, int totalSeconds)
        {
            // Stop and dispose any existing timer
            if (countdownButton.Tag is Timer oldTimer)
            {
                oldTimer.Stop();
                oldTimer.Dispose();
            }

            Timer timer = new Timer { Interval = 1000 };
            int remaining = totalSeconds;

            timer.Tick += (s, e) =>
            {
                if (remaining <= 0)
                {
                    timer.Stop();
                    var bgColor = Color.FromArgb(61, 70, 73);
                    countdownButton.Content = "--";
                    countdownButton.PressedBackground = bgColor;
                    countdownButton.NormalBackground = bgColor;
                    countdownButton.HoverBackground = bgColor;
                }
                else
                {
                    var bgColor = Color.FromArgb(53, 167, 255);
                    countdownButton.Content = $"{remaining / 60:D2}:{remaining % 60:D2}";
                    countdownButton.PressedBackground = bgColor;
                    countdownButton.NormalBackground = bgColor;
                    countdownButton.HoverBackground = bgColor;
                    remaining--;
                }
            };

            // Store the timer in the label’s tag so it can be stopped later
            countdownButton.Tag = timer;
            countdownButton.Content = $"{totalSeconds / 60:D2}:{totalSeconds % 60:D2}";

            timer.Start();
        }


        private bool IsValidMeasurementColumn(string columnName)
        {
            string[] validColumns = {
                "WeightLbs", "BodyFatPercentage", "CaloricIntake", "NeckCm", "ShouldersCm", "ChestCm",
                "LeftBicepCm", "RightBicepCm", "LeftForearmCm", "RightForearmCm", "UpperAbsCm",
                "WaistCm", "LowerAbsCm", "HipsCm", "LeftThighCm", "RightThighCm", "LeftCalfCm", "RightCalfCm"
            };

            return validColumns.Contains(columnName);
        }


        //private int GetWorkoutCountForUser(int userId)
        //{
        //    int count = 0;
        //    string query = "SELECT COUNT(*) FROM Workouts WHERE UserID = @UserID";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@UserID", userId);

        //        try
        //        {
        //            conn.Open();
        //            count = (int)cmd.ExecuteScalar();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error retrieving workout count:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return count;
        //}


























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

                ForeColor         = Color.FromArgb(250, 87, 98),
                NormalForeColor   = Color.FromArgb(250, 87, 98),
                HoverForeColor    = Color.Red,
                PressedForeColor  = cuiButtonAddSet.PressedForeColor,
                BackColor         = cuiButtonAddSet.BackColor,
                NormalBackground  = cuiButtonAddSet.NormalBackground,
                HoverBackground   = cuiButtonAddSet.HoverBackground,
                PressedBackground = Color.FromArgb(67, 55, 59),
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


        private Panel CreateExerciseSetRow(Panel parent, int exerciseId, string exerciseName, int setNumber, object setTag, decimal? weight, int? reps, int? repsOnly, int? time)
        {
            var records = new object?[] { weight, reps, repsOnly, time };

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
                Text      = (records.All(r => r == null)) ? "-" : (timeOnlyExercises.Contains(exerciseName)) ? $"{time} sec" : (repsOnlyExercises.Contains(exerciseName)) ? $"{repsOnly} reps" : $"{weight.Value:G29} lbs × {reps}",
                Width     = 120,
                Location  = new Point(55, 16),
                Font      = new Font("SansSerif", 12),
                ForeColor = Color.FromArgb(191, 194, 195),
                TextAlign = (records.All(r => r == null)) ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft,
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

            var checkBox = new cuiCheckbox
            {
                Content               = "",
                Width                 = 40,
                Height                = 40, 
                Rounding              = 8,
                OutlineThickness      = 0,
                Location              = new Point(txtBxReps.Location.X + 70, txtBxReps.Location.Y), 
                BackColor             = Color.FromArgb(41, 50, 54), 
                UncheckedForeground   = Color.FromArgb(61, 70, 73),
                CheckedForeground     = Color.FromArgb(46, 205, 112),
                UncheckedOutlineColor = Color.FromArgb(61, 70, 73),
                CheckedOutlineColor   = Color.FromArgb(46, 205, 112),
            };
            checkBox.CheckedChanged += ConfirmSet;

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
            if (isWorkingOut) controls.Add(checkBox);

            foreach (var ctrl in controls)
            {
                setRow.Controls.Add(ctrl);
            }

            return setRow;
        }


        private cuiButton CreateTemplateButton(int templateId, string templateName, string note, bool isPrebuilt, string historyDetails = "")
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

            var lblHistory = new Label
            {
                Text      = historyDetails,
                Font      = new Font("SansSerif", 10),//, FontStyle.Italic),
                ForeColor = Color.FromArgb(147, 152, 154),
                Dock      = DockStyle.Top,
                Height    = 15,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            if (isViewingWorkoutHistory)
            {
                btnTemplate.Controls.Add(lblHistory);      
                btnTemplate.Height += 20;
                btnTemplate.TextOffset = new Point(0, 0);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(note))
                {
                    btnTemplate.Controls.Add(lblNote);      
                    btnTemplate.Height += 10;
                    btnTemplate.TextOffset = new Point(0, -5);
                }
                
            }

            // Optional: store additional info like note in Tag if needed

            btnTemplate.Click += (s, _) =>
            {
                var selectedTemplateId = (int)((cuiButton)s).Tag;
                LoadTemplateExercises(flowLayoutPanel_WorkoutTemplate, selectedTemplateId, isPrebuilt);
                ShowTemplateDetails(note, isPrebuilt);
                cuiButton_WorkoutTemplate_Start.BringToFront();
                cuiButton_WorkoutTemplate_GoBack.Tag = selectedTemplateId;
                cuiButton_WorkoutTemplate_Start.Tag = selectedTemplateId;
                cuiButton_WorkingOut_Finish.Tag = selectedTemplateId;
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


        private Panel CreateMeasurementHistoryPanel(DateTime date, decimal value, string unit)
        {
            var tag = flowLayoutPanel_Measurement.Controls.OfType<Panel>().Count(p => p.Height == 30) + 1;

            var panel = new Panel
            {
                Width       = 360,
                Height      = 30,
                Tag         = tag,
                Margin      = new Padding(3, 5, 3, 22),
                BackColor   = Color.Transparent,
                BorderStyle = BorderStyle.None,
            };

            var lblDate = new Label
            {
                AutoSize = true,
                Text      = $"{date:MMM d}",
                Font      = new Font("Sanserif", 14, FontStyle.Bold),
                Padding   = new Padding(15,5,5,5),
                ForeColor = Color.White,
                Dock      = DockStyle.Left,
            };
            
            var lblTime = new Label
            {
                AutoSize = true,
                Text      = $"{date:h:mm tt}",
                Font      = new Font("Sanserif", 14, FontStyle.Regular),
                Padding   = new Padding(5),
                ForeColor = Color.FromArgb(191, 194, 195),
                Dock      = DockStyle.Left,
            };
            
            var lblValue = new Label
            {
                AutoSize = true,
                Text        = $"{value:G29} {unit}",
                Font        = new Font("Sanserif", 14, FontStyle.Bold),
                Padding     = new Padding(5),
                ForeColor   = Color.FromArgb(191, 194, 195),
                //RightToLeft = RightToLeft.Yes,
                Dock        = DockStyle.Right,
            };

            panel.Controls.AddRange([lblTime, lblDate, lblValue]);

            return panel;
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
