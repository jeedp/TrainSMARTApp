using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;

namespace TrainSMARTApp
{
    public partial class LoginForm: Form
    {
        // for dragging the form
        private bool mouseDown;
        private Point lastLocation;
        
        // panel/button transparency
        int opacity = 90;
        Color pnlBgColor = Color.Black;
        Color pnlTxtBxBgColor = Color.White;






        public LoginForm()
        {
            InitializeComponent();

            // panel sizes in design is 513, 753
        }





        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel_Title.MouseDown += this.MouseDown;
            this.panel_Title.MouseMove += this.MouseMove;
            this.panel_Title.MouseUp += this.MouseUp;



            ShowMenu(panel_Menu_Main); // default menu
            ShowControls(panel_Menu_Main);
            HideMenu(panel_Menu_Register);
            HideMenu(panel_Menu_LogIn);
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            HideMenu(panel_Menu_Register);
            HideMenu(panel_Menu_LogIn);
            ShowMenu(panel_Menu_Main);
            ShowControls(panel_Menu_Main);
        }










        // MAIN CONTROLS

        private void cuiButton_LogIn_Click(object sender, EventArgs e)
        {
            HideMenu(panel_Menu_Main);
            ShowMenu(panel_Menu_LogIn);
            ShowControls(panel_Menu_LogIn);
        }

        private void cuiButton_Register_Click(object sender, EventArgs e)
        {
            HideMenu(panel_Menu_Main);
            ShowMenu(panel_Menu_Register);
            ShowControls(panel_Menu_Register);
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



            // for showing menus
        private void HideMenu(Panel panel)
        {
            panel.Width = 0;
            panel.Visible = false;
            panel.SendToBack();
        }

        private void ShowMenu(Panel panel)
        {
            panel.Parent = pictureBox_Background;
            panel.BackColor = Color.FromArgb(opacity, pnlBgColor);
            panel.Width = 513;
            panel.Visible = true;
            panel.BringToFront();
        }

        private void ShowControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                switch (control)
                {
                    case Label lbl:
                        lbl.Parent = panel;
                        lbl.BackColor = Color.Transparent;

                        if (lbl == label_Main_Welcome)
                            lbl.Location = new Point(70, 231);
                        if (lbl == label_Main_Description)
                            lbl.Location = new Point(70, 269);
                        if (lbl == label_Register_SignUp)
                            lbl.Location = new Point(140, 125);
                        break;

                    case cuiButton cuiBtn:
                        cuiBtn.Parent = panel;
                        cuiBtn.BackColor = Color.Transparent;
                        cuiBtn.HoverBackground = Color.Transparent;
                        cuiBtn.PressedBackground = Color.Transparent;
                        break;

                    case cuiTextBox2 cuiTxtBx:
                        cuiTxtBx.Parent = panel;
                        cuiTxtBx.BackgroundColor = Color.FromArgb(10, Color.FromArgb(68, 68, 77));
                        if (cuiTxtBx == cuiTextBox_Register_Username)
                            cuiTxtBx.Location = new Point(146, 175);
                        if (cuiTxtBx == cuiTextBox_Register_Password)
                            cuiTxtBx.Location = new Point(146, 260);
                        if (cuiTxtBx == cuiTextBox_Register_Email)
                            cuiTxtBx.Location = new Point(146, 345);
                        break;
                }

                control.BringToFront();
            }
        }
        
    }
}
