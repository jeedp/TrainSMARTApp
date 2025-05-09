﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI;
using CuoreUI.Controls;

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
        private bool isCreatingWorkoutTemplate;

        private List<int> selectedExerciseIDs = new List<int>();



        public MainForm()
        {
            InitializeComponent();

            // menu panels size in design (513, 661)
            // panel size in code (0, 537)

            // cuiGradientBorder_AboveMenu size (513, 10)
            // panel_Menus size (513, 82)

            // TODO: add duplicate check
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
            ClearDynamicExercisePanels();
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
            ShowMenu(panel_Menu_Workout, cuiButton_Menu_Workout);
        }

        private void cuiButton_WorkoutCreation_Save_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            ClearDynamicExercisePanels();
        }

        private void cuiButton_WorkoutCreation_EditName_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton_WorkoutCreation_AddExercise_Click(object sender, EventArgs e)
        {
            isAddingExercises = true;
            ShowMenu(panel_Menu_Exercises, cuiButton_Menu_Exercises);
            ShowHideExerciseSearchBar(panel_Exercises_Search, false);
            LoadExerciseButtons(null, null);
        }


            // ADDING EXERCISES

        private void cuiButton_AddExercise_ConfirmAdd_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            ShowMenu(panel_WorkoutCreation, cuiButton_Menu_Workout);
            ExerciseConfirmAdd();
        }










        // EXERCISES MENU

        private void cuiButton_Exercises_Search_Click(object sender, EventArgs e)
        {
            ShowHideExerciseSearchBar(panel_Exercises_Search, true);
        }

        private void cuiButton_Exercises_GoBack_Click(object sender, EventArgs e)
        {
            ShowHideExerciseSearchBar(panel_Exercises_Search, false);
        }

        private void cuiButton_Exercises_Filter_Click(object sender, EventArgs e)
        {
            ShowHideExerciseFilter(cuiBorder_Exercises_Filter, flowLayoutPanel_Exercises);
        }


            // EXERCISE DETAILS



        // MEASURE MENU










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

            if (panel == panel_Menu_Exercises)
            {
                ShowHideExerciseFilter(cuiBorder_Exercises_Filter, flowLayoutPanel_Exercises, "true");
                ShowHideExerciseSearchBar(panel_Exercises_Search, false);
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


        private void ShowMeasurementPanel()
        {
            // TODO: implementation
        }


        private void ShowHideExerciseSearchBar(Panel panel, bool isShown)
        {
            panel.Width = (isShown) ? 321 : 0;  // width in design is 441
            panel.BringToFront();

            var cuiBtn = cuiButton_AddExercises_Exit;
            cuiBtn.Visible = !isShown;
            cuiBtn.Width = !isShown ? 80 : 0;
        }


        private void ShowHideExerciseFilter(cuiBorder border, FlowLayoutPanel flowLayoutPanel, string isShown = "")
        {
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
                    textBox_ExerciseDetails_Instructions.Text = reader["Instructions"].ToString();

                    ShowMenu(panel_ExerciseDetails, cuiButton_Menu_Exercises);
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
                        Width = 360,
                        Height = 150,
                        BackColor = Color.Transparent,
                        Margin = new Padding(3, 5, 3, 5),
                        Tag = exerciseId,

                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    var cuiButtonExerciseName = new cuiButton
                    {
                        Content = exerciseName,
                        Font = new Font("SansSerif", 14),// FontStyle.Bold),
                        ForeColor = Color.FromArgb(53, 167, 255),
                        Dock = DockStyle.Top,
                        Height = 60,
                        Tag = exerciseId,
                        TextOffset = new Point  // TODO: FIX
                        (
                            -180 + (exerciseName.Length > 35
                                        ? exerciseName.Length
                                        : exerciseName.Length > 21
                                            ? exerciseName.Length * 1
                                            : exerciseName.Length > 27
                                                ? exerciseName.Length * 2
                                                : exerciseName.Length > 23 
                                                    ? exerciseName.Length * 3 
                                                    : exerciseName.Length > 19
                                                        ? exerciseName.Length * 4
                                                        : exerciseName.Length > 15
                                                            ? exerciseName.Length * 5
                                                            : exerciseName.Length > 10
                                                                ? exerciseName.Length * 6
                                                                : exerciseName.Length * 7), 
                            0
                        ),

                        BackColor = Color.Transparent,
                        HoverBackground = Color.Transparent,
                        HoverForeColor = Color.LightSkyBlue,
                        NormalBackground = Color.Transparent,
                        NormalForeColor = Color.FromArgb(53, 167, 255),
                        PressedBackground = Color.FromArgb(84, 91, 94),
                        PressedForeColor = Color.White,
                    };
                    cuiButtonExerciseName.Click += ShowExerciseDetails;

                    var lblSet = new Label
                    {
                        Text = "Sets",
                        Width = 30,
                        ForeColor = Color.White,
                        Dock = DockStyle.Left,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    var lblPrevious = new Label
                    {
                        Text = "Previous",
                        Width = 60,
                        ForeColor = Color.White,
                        Dock = DockStyle.Left,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    var lblWeight = new Label
                    {
                        Text = "Weight",
                        Width = 60,
                        ForeColor = Color.White,
                        Dock = DockStyle.Right,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    var lblReps = new Label
                    {
                        Text = lblWeight.Text,
                        Width = lblWeight.Width,
                        ForeColor = lblWeight.ForeColor,
                        Dock = lblWeight.Dock,
                        TextAlign = lblWeight.TextAlign,
                    };

                    panelExercise.Controls.Add(cuiButtonExerciseName);
                    //panelExercise.Controls.Add(lblSet);
                    //panelExercise.Controls.Add(lblWeight);
                    //panelExercise.Controls.Add(lblReps);

                    AddExerciseSetRow(panelExercise);

                    var cuiButtonAddSet = new cuiButton
                    {
                        Content = "Add Set",
                        Font = new Font("SansSerif", 12), //FontStyle.Bold),
                        Dock = DockStyle.Bottom,
                        Height = 30,
                        Tag = panelExercise,
                        Margin = new Padding(3, 4, 3, 4),
                        Rounding = new Padding(4),

                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(53, 167, 255),
                        HoverBackground = Color.Transparent,
                        HoverForeColor = Color.LightSkyBlue,
                        NormalBackground = Color.Transparent,
                        NormalForeColor = Color.FromArgb(53, 167, 255),
                        PressedBackground = Color.FromArgb(42, 64, 78),
                        PressedForeColor = Color.White,
                    };
                    cuiButtonAddSet.Click += (s, e) =>
                    {
                        var parent = (Panel)((cuiButton)s).Tag;
                        var addedRowHeight = AddExerciseSetRow(parent);
                        panelExercise.Height += addedRowHeight; 
                    };
                    panelExercise.Controls.Add(cuiButtonAddSet);

                    flowLayoutPanel_WorkoutCreation.Controls.Add(panelExercise);
                    flowLayoutPanel_WorkoutCreation.Controls.SetChildIndex(panelExercise, flowLayoutPanel_WorkoutCreation.Controls.Count - 2); // Add above "Add Exercise" button
                }
            }
            selectedExerciseIDs.Clear();
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";
        }


        private int AddExerciseSetRow(Panel parent)
        {
            var setNumber = parent.Controls.OfType<Panel>().Count() + 1;

            var setRow = new Panel
            {
                Height = 50,
                Width = parent.Width,
                Dock = DockStyle.Bottom
            };

            var lblSet = new Label
            {
                Text = setNumber.ToString(),
                Width = 30,
                Dock = DockStyle.Left,
                Font = new Font("SansSerif", 11),
                ForeColor = Color.FromArgb(53, 167, 255),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            var txtWeight = new cuiTextBox2
            {
                Width                = 62,
                Height               = 40,
                Location             = new Point(180, 4), 
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
            };
            txtWeight.KeyPress += KeyPressDigitOnly;

            var txtReps = new cuiTextBox2
            {
                Width                = txtWeight.Width,
                Height               = txtWeight.Height,
                Location             = new Point(txtWeight.Location.X + 70, txtWeight.Location.Y),
                Font                 = txtWeight.Font,
                Rounding             = txtWeight.Rounding,
                Margin               = txtWeight.Margin,
                ForeColor            = txtWeight.ForeColor,
                BackColor            = txtWeight.BackColor,
                BackgroundColor      = txtWeight.BackgroundColor,
                BorderColor          = txtWeight.BorderColor,
                BorderSize           = txtWeight.BorderSize,
                FocusBackgroundColor = txtWeight.FocusBackgroundColor,
                FocusBorderColor     = txtWeight.FocusBorderColor,
                PlaceholderColor     = txtWeight.PlaceholderColor,
            };
            txtReps.KeyPress += KeyPressDigitOnly;

            setRow.Controls.Add(lblSet);
            setRow.Controls.Add(txtWeight);
            setRow.Controls.Add(txtReps);
            setRow.Padding = new Padding(0, 5, 0,5);
            setRow.BackColor = Color.FromArgb(50, 50, 50);

            parent.Controls.Add(setRow);
            parent.Controls.SetChildIndex(setRow, parent.Controls.Count - 2); // Add above "Add Set" button

            return setRow.Height; 
        }


        private void ClearDynamicExercisePanels()
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
    }
}
