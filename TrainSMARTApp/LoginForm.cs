using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int opacity = 90;
        private Color pnlBgColor = Color.Black;

        // sql connection string
        private string connectionString = "Data Source=LAPTOP-R9RSTS0G\\SQLEXPRESS;Initial Catalog=UserDB;";





        private enum DisplayMode
        {
            Main,
            Register,
            LogIn
        }
        private DisplayMode currentMode = DisplayMode.Main;












        public LoginForm()
        {
            InitializeComponent();

            // panel sizes in design is 513, 753
            // pictureBox_Background location in design is -49, 0
        }





        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel_Title.MouseDown += this.MouseDown;
            this.panel_Title.MouseMove += this.MouseMove;
            this.panel_Title.MouseUp += this.MouseUp;

            // Load panels and controls then show default menu
            HideMenu(panel_Menu_Register);
            HideMenu(panel_Menu_LogIn);
            HideMenu(panel_Menu_Main);

            ShowMenu(panel_Menu_Register);
            ShowControls(panel_Menu_Register);
            HideMenu(panel_Menu_Register);

            ShowMenu(panel_Menu_LogIn); 
            ShowControls(panel_Menu_LogIn);
            HideMenu(panel_Menu_LogIn);

            ShowMenu(panel_Menu_Main); // default menu
            ShowControls(panel_Menu_Main);
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
            currentMode = DisplayMode.Main;
        }










        // MAIN CONTROLS

        private void cuiButton_Register_Click(object sender, EventArgs e)
        {
            HideMenu(panel_Menu_Main);
            ShowMenu(panel_Menu_Register);
            currentMode = DisplayMode.Register;
        }

        private void cuiButton_LogIn_Click(object sender, EventArgs e)
        {
            HideMenu(panel_Menu_Main);
            ShowMenu(panel_Menu_LogIn);
            currentMode = DisplayMode.LogIn;
        }











        // REGISTER CONTROLS
            // TODO: Upgrade password to be hashed when stored in database
        private void cuiButton_Register_SignUp_Click(object sender, EventArgs e)
        {
            string username = cuiTextBox_Register_Username.Text;
            string password = cuiTextBox_Register_Password.Text;
            string email = cuiTextBox_Register_Email.Text;

            if (!InputValidation())
                return;

            // You can add more validation here like email format, password strength, etc.

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // You should hash the password in a real app
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear fields after successful registration
                            cuiTextBox_Register_Username.Content = "";
                            cuiTextBox_Register_Password.Content = "";
                            cuiTextBox_Register_Email.Content = "";
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void cuiButton_Register_PrivacyPolicy_Click(object sender, EventArgs e)
        {

        }










        // LOG IN CONTROLS










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

            var labelPositions = new Dictionary<Label, Point>
            {
                { label_Main_Welcome, new Point(70, 231) },
                { label_Main_Description, new Point(70, 269) },
                { label_Register_SignUp, new Point(140, 125) },
                { label_Register_PrivacyPolicy, new Point(144, 504) },
                { label_Login_Login, new Point(140, 150) }
            };

            var cuiButtonPositions = new Dictionary<cuiButton, Point>
            {
                { cuiButton_Main_Login, new Point(277, 325) },
                { cuiButton_Main_Register, new Point(172, 325) },
                { cuiButton_Register_SignUp, new Point(144, 438) },
                { cuiButton_Register_PrivacyPolicy, new Point(350, 500) },
                { cuiButton_Login_ResetPass, new Point(168, 403) },
                { cuiButton_Login_Login, new Point(346, 402) }
            };

            var cuiTextBoxPositions= new Dictionary<cuiTextBox2, Point>
            {
                { cuiTextBox_Register_Username, new Point(144, 175) },
                { cuiTextBox_Register_Password, new Point(144, 260) },
                { cuiTextBox_Register_Email, new Point(144, 345) },
                { cuiTextBox_Login_Username, new Point(146, 206) },
                { cuiTextBox_Login_Password, new Point(146, 300) }
            };

            foreach (Control control in panel.Controls)
            {
                switch (control)
                {
                    case Label lbl:
                        lbl.Parent = panel;
                        lbl.BackColor = Color.Transparent;
                        if (labelPositions.TryGetValue(lbl, out Point lblPos))
                        {
                            lbl.Location = lblPos;
                        }
                        break;

                    case cuiButton cuiBtn:
                        cuiBtn.Parent = panel;
                        cuiBtn.BackColor = Color.Transparent;
                        if (cuiBtn == cuiButton_Main_Register ||
                            cuiBtn == cuiButton_Register_PrivacyPolicy ||
                            cuiBtn == cuiButton_Login_ResetPass)
                        {
                            cuiBtn.HoverBackground = Color.Transparent;
                            cuiBtn.PressedBackground = Color.Transparent;
                        }
                        if (cuiBtn == cuiButton_Main_Login ||
                            cuiBtn == cuiButton_Register_SignUp ||
                            cuiBtn == cuiButton_Login_Login)
                        {
                            cuiBtn.HoverBackground = Color.LightSkyBlue;
                            cuiBtn.PressedBackground = Color.FromArgb(101, 188, 255);
                        }
                        if (cuiButtonPositions.TryGetValue(cuiBtn, out Point cuiBtnPos))
                        {
                            cuiBtn.Location = cuiBtnPos;
                        }
                        break;

                    case cuiTextBox2 cuiTxtBx:
                        cuiTxtBx.Parent = panel;
                        cuiTxtBx.BackColor = Color.FromArgb(90, Color.FromArgb(68, 68, 77));
                        cuiTxtBx.BackgroundColor = Color.FromArgb(90, Color.FromArgb(68, 68, 77));
                        if (cuiTextBoxPositions.TryGetValue(cuiTxtBx, out Point cuiTxtBxPos))
                        {
                            cuiTxtBx.Location = cuiTxtBxPos;
                        }
                        break;
                }
                control.BringToFront();
            }
        }

        private bool InputValidation()
        {
            var cuiTxtBx = (currentMode == DisplayMode.Register)
                ? new List<cuiTextBox2>
                {
                    cuiTextBox_Register_Username,
                    cuiTextBox_Register_Password,
                    cuiTextBox_Register_Email
                }
                : new List<cuiTextBox2>
                {
                    cuiTextBox_Login_Username,
                    cuiTextBox_Login_Password
                };

            foreach (var txtBox in cuiTxtBx)
            {
                if (string.IsNullOrWhiteSpace(txtBox.Content) || txtBox.Content.Contains(" "))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBox.FocusBorderColor = Color.Red;
                    txtBox.Focus();

                    return false;
                }

                // TODO: Create error mode for the txt boxes




                //if (txtBox.Content.Contains(" "))
                //{
                //    MessageBox.Show(
                //        "Spaces are not allowed in the username or password.", "Validation Error",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Warning);
                //    return false;
                //}
            }
            return true;

            
        }

        private void HideError()
        {
            
        }

    }
}
