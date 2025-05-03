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

        private bool areFiltersShown = false;



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

            cuiTextBox_Exercises_Search.ContentChanged += DynamicExerciseSearchAndFilter;

            //LoadExerciseButtons();

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
            LoadExerciseButtons();
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


        // MEASURE MENU










        // HELPER METHODS 

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
                panel_Menu_Exercises,
                panel_Menu_Measure,
                panel_Measurement_Menu,

                panel_WorkoutCreation,
            };

            foreach (var pnl in panels)
            {
                pnl.Visible = pnl == panel;
                pnl.Height = (pnl == panel) ? (pnl == panel_WorkoutCreation) ? 611 : 537 : 0;
            }

            if (panel == panel_Menu_Exercises)
                ShowHideSearchBar(panel_Exercises_Search, false);
        }

        private void ShowMeasurementPanel()
        {
            // TODO: implementation
        }

        private void ShowHideSearchBar(Panel panel, bool isShown)
        {
            panel.Width = (isShown) ? 321 : 0;
        }

        private void ShowHideFilter(cuiBorder border, FlowLayoutPanel flowLayoutPanel)
        {
            areFiltersShown = !areFiltersShown;
            border.Height = (areFiltersShown) ? 100 : 0;
            flowLayoutPanel.Height = (areFiltersShown) ? 300 : 500;

        }

        private void LoadExerciseButtons(string search = "", string muscleGroupFilter = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Exercises WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND ExerciseName LIKE @Search";

                if (!string.IsNullOrEmpty(muscleGroupFilter) && muscleGroupFilter != "All")
                    query += " AND MuscleGroup = @MuscleGroup";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@Search", $"%{search}%");

                if (!string.IsNullOrEmpty(muscleGroupFilter) && muscleGroupFilter != "All")
                    cmd.Parameters.AddWithValue("@MuscleGroup", muscleGroupFilter);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    flowLayoutPanel_Exercises.Controls.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string muscleGroup = reader.IsDBNull(2) ? " " : reader.GetString(2);

                        cuiButton btn = new cuiButton
                        {
                            Content = $"{name}\n({muscleGroup})",
                            Width = 360,
                            Height = 85,
                            Tag = id, // Store the ID in case you need it later
                            Font = new Font("SansSerif", 13.8f, FontStyle.Bold),
                            TextOffset = new Point(0, -10),
                            RightToLeft = RightToLeft.Yes,
                            Margin = new Padding(3, 0, 3, 0),
                            BackColor = Color.Transparent,
                            ForeColor = Color.White,
                            HoverBackground = Color.Transparent,
                            HoverForeColor = Color.DimGray,
                            NormalBackground = Color.Transparent,
                            NormalForeColor = Color.White,
                            PressedBackground = Color.FromArgb(84, 91, 94),
                            PressedForeColor = Color.White,
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

                        btn.Click += (s, e) =>
                        {
                            // TODO: Enhance the button click event to show more details
                            MessageBox.Show($"Exercise: {name}\nMuscle Group: {muscleGroup}", "Exercise Info");
                        };

                        flowLayoutPanel_Exercises.Controls.Add(btn);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading exercises: " + ex.Message);
                }
            }
        }

        private void DynamicExerciseSearchAndFilter(object sender, EventArgs e)
        {
            string searchText = cuiTextBox_Exercises_Search.Content;
            string muscleGroupFilter = ""; // TODO: Get the selected muscle group filter
            LoadExerciseButtons(searchText, muscleGroupFilter);
        }
    }
}
