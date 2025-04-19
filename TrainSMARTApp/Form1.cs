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
    public partial class LoginForm: Form
    {
        // for dragging the form
        private bool mouseDown;
        private Point lastLocation;





        public LoginForm()
        {
            InitializeComponent();
        }



        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel_Title.MouseDown += this.MouseDown;
            this.panel_Title.MouseMove += this.MouseMove;
            this.panel_Title.MouseUp += this.MouseUp;



            ShowMainControls();
        }










        // FORM CONTROLS

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










        // MAIN CONTROLS

        private void cuiButton_LogIn_Click(object sender, EventArgs e)
        {
            panel_Main.Width = 0;
        }

        private void cuiButton_Register_Click(object sender, EventArgs e)
        {

        }










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



        private void ShowMainControls()
        {
            int opacity = 90;
            Color color = Color.Black;

            panel_Main.Parent = pictureBox_Background;
            panel_Main.BackColor = Color.FromArgb(opacity, color);
            panel_Main.Width = 500;
            panel_Main.Visible = true;
            panel_Main.BringToFront();

            label_Welcome.Parent = panel_Main;
            label_Welcome.BackColor = Color.Transparent;
            label_Welcome.Location = new Point(70, 231);
            label_Welcome.BringToFront();

            label_Description.Parent = panel_Main;
            label_Description.BackColor = Color.Transparent;
            label_Description.Location = new Point(70, 267);
            label_Description.BringToFront();

            cuiButton_LogIn.Parent = panel_Main;
            cuiButton_LogIn.BackColor = Color.Transparent;
            cuiButton_LogIn.BringToFront();

            cuiButton_Register.Parent = panel_Main;
            cuiButton_Register.BackColor = Color.Transparent;
            cuiButton_Register.HoverBackground = Color.Transparent;
            cuiButton_Register.PressedBackground = Color.Transparent;
            cuiButton_Register.BringToFront();
        }
    }
}
