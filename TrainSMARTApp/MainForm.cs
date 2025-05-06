using System;
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

        List<int> selectedExerciseIDs = new List<int>();



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
            ShowMenu(panel_Menu_Profile);
        }

        private void cuiButton_Menu_History_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_History);
        }

        private void cuiButton_Menu_Workout_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Workout);
        }

        private void cuiButton_Menu_Exercises_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Exercises);
            LoadExerciseButtons(null, null);
        }

        private void cuiButton_Menu_Measure_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Measure);
        }










        // PROFILE MENU

        // HISTORY MENU

        // WORKOUT MENU

        private void cuiButton_Workout_AddTemplate_Click(object sender, EventArgs e)
        {
            isAddingExercises = false;
            ShowMenu(panel_WorkoutCreation);
        }


            // WORKOUT CREATION MENU

        private void cuiButton_WorkoutCreation_Exit_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Workout);
        }

        private void cuiButton_WorkoutCreation_Save_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton_WorkoutCreation_EditName_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton_WorkoutCreation_AddExercise_Click(object sender, EventArgs e)
        {
            isAddingExercises = true;
            ShowMenu(panel_Menu_Exercises);
            ShowHideSearchBar(panel_Exercises_Search, false);
            LoadExerciseButtons(null, null);
        }










        // EXERCISES MENU

        private void cuiButton_Exercises_Search_Click(object sender, EventArgs e)
        {
            ShowHideSearchBar(panel_Exercises_Search, true);
        }

        private void cuiButton_Exercises_GoBack_Click(object sender, EventArgs e)
        {
            ShowHideSearchBar(panel_Exercises_Search, false);
        }

        private void cuiButton_Exercises_Filter_Click(object sender, EventArgs e)
        {
            ShowHideFilter(cuiBorder_Exercises_Filter, flowLayoutPanel_Exercises);
        }


            // EXERCISE DETAILS

        private void cuiButton_ExerciseDetails_GoBack_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Exercises);
        }


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

        private void ShowMenu(Panel panel)
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
                ShowHideSearchBar(panel_Exercises_Search, false);
                ShowHideFilter(cuiBorder_Exercises_Filter, flowLayoutPanel_Exercises, "true");
            }

            var controls = new List<Control>
            {
                cuiButton_AddExercises_Exit,
                label_AddExercises_Title,
                label_AddExercises_Count,

                label_Exercises_Title,
                label_Exercises_Count,
            };

            foreach (var cntrl in controls)
            {
                if (cntrl.Name.Contains("Add"))
                    cntrl.Visible = isAddingExercises;
                else
                    cntrl.Visible = !isAddingExercises;
                cntrl.BringToFront();
            }
        }

        private void ShowMeasurementPanel()
        {
            // TODO: implementation
        }

        private void ShowHideSearchBar(Panel panel, bool isShown)
        {
            panel.Width = (isShown) ? 321 : 0;  // width in design is 441
            panel.BringToFront();

            cuiButton_AddExercises_Exit.Visible = !isShown;
            cuiButton_AddExercises_Exit.Width = !isShown ? 80 : 0;
        }

        private void ShowHideFilter(cuiBorder border, FlowLayoutPanel flowLayoutPanel, string isShown = "")
        {
            if (!string.IsNullOrWhiteSpace(isShown))
                isFilterShown = Convert.ToBoolean(isShown);
            isFilterShown = !isFilterShown;
            border.Height = (isFilterShown) ? 75 : 0;   // height in design is 93
            border.BringToFront();
            //flowLayoutPanel.Height = (isFilterShown) ? 370 : 460;
        }

        private void ShowExerciseDetails(Object sender, EventArgs e)
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
                    //cuiTextBox_ExerciseDetails_Instructions.Content = reader["Instructions"].ToString();

                    ShowMenu(panel_ExerciseDetails);
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



                        //Button btn = new Button
                        //{
                        //    Text = $"{name}\n({muscleGroup})",
                        //    Width = 360,
                        //    Height = 85,
                        //    Tag = id, // Store the ID in case you need it later
                        //    Font = new Font("SansSerif", 12.0f, FontStyle.Regular),
                        //    Margin = new Padding(3, 0, 3, 0),
                        //    TextAlign = ContentAlignment.MiddleLeft,
                        //    FlatStyle = FlatStyle.Flat,
                        //    FlatAppearance =
                        //    {
                        //        MouseDownBackColor = Color.FromArgb(84, 91, 94), BorderSize = 0,
                        //        MouseOverBackColor = Color.DimGray, BorderColor = Color.FromArgb(41, 50, 54),
                        //    },
                        //    BackColor = Color.Transparent,
                        //    ForeColor = Color.White,
                        //};

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

            label_Exercises_Count.Text = "(" + flowLayoutPanel_Exercises.Controls.Count.ToString() + ")";
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
                btn.NormalBackground = Color.Transparent;
                btn.HoverBackground = Color.Transparent;
            }
            else
            {
                selectedExerciseIDs.Add(id);
                btn.NormalBackground = Color.FromArgb(44, 79, 104);
                btn.HoverBackground = Color.FromArgb(44, 79, 104);
            }
            label_AddExercises_Count.Text = "(" + selectedExerciseIDs.Count + ")";
        }


    }
}
