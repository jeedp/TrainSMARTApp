using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSMARTApp
{
    public partial class MainForm: Form
    {
        // for dragging the form
        private bool mouseDown;
        private Point lastLocation;





        public MainForm()
        {
            InitializeComponent();

            // menu panels size in design (513, 661)
            // panel size in code (0, 537)
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panel_Form_Title.MouseDown += this.MouseDown;
            this.panel_Form_Title.MouseMove += this.MouseMove;
            this.panel_Form_Title.MouseUp += this.MouseUp;
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
        }

        private void cuiButton_Menu_Measure_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_Menu_Measure);
        }










        // PROFILE MENU

        // HISTORY MENU

        // WORKOUT MENU

        // EXERCISES MENU

        // MEASURE MENU










        // HELPER METHODS 

            // for dragging the form
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private new void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ShowMenu(Panel panel)
        {
            var panels = new List<Panel>
            {
                panel_Menu_Profile,
                panel_Menu_History,
                panel_Menu_Workout,
                panel_Menu_Exercises,
                panel_Menu_Measure
            };

            foreach (var pnl in panels)
            {
                pnl.Visible = pnl == panel;
                pnl.Height = (pnl == panel) ? 537 : 0;
            }
        }

        private void ShowMeasurementPanel()
        {

        }
    }
}
