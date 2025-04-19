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
        // dragging form
        private bool mouseDown;
        private Point lastLocation;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Panel_Title.MouseDown += this.MouseDown;
            this.Panel_Title.MouseMove += this.MouseMove;
            this.Panel_Title.MouseUp += this.MouseUp;

            // TRANSPARENT CONTROLS

            int opacity = 90;
            Color color = Color.Black;

            panel_Main.Parent = pictureBox_Background;
            panel_Main.BackColor = Color.FromArgb(opacity, color);
            panel_Main.Width = 500;
            panel_Main.BringToFront();

            label_Welcome.Parent = pictureBox_Background;
            label_Welcome.BackColor = Color.FromArgb(opacity, color);
            label_Welcome.Location = new Point(70, 231);
            label_Welcome.BringToFront();
            
            label_Description.Parent = pictureBox_Background;
            label_Description.BackColor = Color.FromArgb(opacity, color);
            label_Description.Location = new Point(70, 267);
            label_Description.BringToFront();

            cuiButton_LogIn.Parent = pictureBox_Background;
            cuiButton_LogIn.BackColor = Color.FromArgb(opacity, color);
            cuiButton_LogIn.BringToFront();

            cuiButton_Register.Parent = pictureBox_Background;
            cuiButton_Register.BackColor = Color.FromArgb(opacity, color);
            cuiButton_Register.HoverBackground = Color.Transparent;
            cuiButton_Register.PressedBackground = Color.Transparent;
            cuiButton_Register.BringToFront();
        }










        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }









        // HELPER METHODS 

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
    }
}
