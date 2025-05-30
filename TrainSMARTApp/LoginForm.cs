﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TrainSMARTApp.ValidationHelper;
using static TrainSMARTApp.User;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrainSMARTApp
{
    public partial class LoginForm: Form
    {
        // for dragging the form
        private bool _mouseDown;
        private Point _lastLocation;
        
        // panel/button transparency
        private int opacity = 90;
        private Color pnlBgColor = Color.Black;

        // sql connection string
        private string connectionString = "Data Source=LAPTOP-R9RSTS0G\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";





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

            // TODO: REMOVE AFTER TESTING
            //cuiTextBox_Login_Username.Content = "testUser";
            //cuiTextBox_Login_Password.Content = "testPassword";
            //var s = new object(); var e = EventArgs.Empty;
            //cuiButton_Login_Login_Click(s, e);

            // TODO: if user has not signed out, auto log in
        }





        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel_Title.MouseDown += this.MouseDown;
            this.panel_Title.MouseMove += this.MouseMove;
            this.panel_Title.MouseUp += this.MouseUp;

            // Load panels and controls then show default menu
            HideMenu(panel_Menu_Register);
            HideMenu(panel_Menu_Login);
            HideMenu(panel_Menu_Main);

            ShowMenu(panel_Menu_Register);
            ShowControls(panel_Menu_Register);
            HideMenu(panel_Menu_Register);

            ShowMenu(panel_Menu_Login); 
            ShowControls(panel_Menu_Login);
            HideMenu(panel_Menu_Login);

            ShowMenu(panel_Menu_Main); // default menu
            ShowControls(panel_Menu_Main);



            var textBoxes = new List<cuiTextBox2>
            {
                cuiTextBox_Register_Username,
                cuiTextBox_Register_Password,
                cuiTextBox_Register_Email,
                cuiTextBox_Login_Username,
                cuiTextBox_Login_Password
            };

            foreach (var txtBox in textBoxes)
            {
                txtBox.ContentChanged += HideTxtBoxError;
            }

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
            HideMenu(panel_Menu_Login);
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
            ShowMenu(panel_Menu_Login);
            currentMode = DisplayMode.LogIn;
        }











        // REGISTER CONTROLS
            // TODO: Upgrade password to be hashed when stored in database
        private void cuiButton_Register_SignUp_Click(object sender, EventArgs e)
        {
            string username = cuiTextBox_Register_Username.Content.Trim();
            string password = cuiTextBox_Register_Password.Content.Trim();
            string email = cuiTextBox_Register_Email.Content.Trim();

            if (!InputValidation()) return;

            string passwordHash = ComputeSha256Hash(password);        // 🔒 hash the password
            //string passwordHash = password;                             // For testing purposes, use plain text password

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    DuplicateCheck(conn, username, email);

                    // ✅ Insert new user
                    string insertQuery = @"
                        INSERT INTO Users (Username, PasswordHash, Email) 
                        OUTPUT INSERTED.UserID, INSERTED.Username, INSERTED.Email, INSERTED.WorkoutCount
                        VALUES (@Username, @PasswordHash, @Email)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        insertCmd.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = insertCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new User
                                {
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    WorkoutCount = reader.GetInt32(reader.GetOrdinal("WorkoutCount"))
                                };

                                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cuiTextBox_Register_Username.Content = "";
                                cuiTextBox_Register_Password.Content = "";
                                cuiTextBox_Register_Email.Content = "";

                                this.Hide();
                                MainForm nextForm = new MainForm(user);
                                nextForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cuiButton_Register_PrivacyPolicy_Click(object sender, EventArgs e)
        {
            string privacyPolicy = "Privacy Policy\n\n" +
                "We respect your privacy. Your data is stored securely and never shared without your consent.\n\n" +
                "By using this application, you agree to the collection and storage of your workout and health data for personalization and tracking purposes.\n\n" +
                "You may review or delete your data at any time from the settings menu.";

            MessageBox.Show(privacyPolicy, "Privacy Policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }










        // LOG IN CONTROLS
            // TODO: modify/enhance this method
        private void cuiButton_Login_ResetPass_Click(object sender, EventArgs e)
        {
            string username = cuiTextBox_Login_Username.Content.Trim();

            if (!InputValidation())
            {
                MessageBox.Show("Enter your username to reset password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        // TODO: send an email or show a reset panel
                        MessageBox.Show("A password reset link has been sent.", "Reset Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


            // TODO: enhance where user is able to also log in using email
        private void cuiButton_Login_Login_Click(object sender, EventArgs e)
        {
            string identifier = cuiTextBox_Login_Username.Content.Trim();
            string password = cuiTextBox_Login_Password.Content.Trim();

            if (!InputValidation())
            {
                MessageBox.Show(
                    "Sorry, couldn't log in! Please check your username and password",
                    "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = ComputeSha256Hash(password);      // Hashing method below
            //string hashedPassword = password;                           // For testing purposes, use plain text password

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 1 UserID, Username, Email, WorkoutCount
                    FROM Users
                    WHERE (Username = @Identifier OR Email = @Identifier) AND PasswordHash = @PasswordHash";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Identifier", identifier);
                cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        var user = new User
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            WorkoutCount = reader.GetInt32(reader.GetOrdinal("WorkoutCount"))
                        };

                        this.Hide();
                        MainForm nextForm = new MainForm(user);
                        nextForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // TODO: enhance
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


         








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
            var cuiTxtBox = (currentMode == DisplayMode.Register)
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

            var errorLabels = new Dictionary<cuiTextBox2, Label>
            {
                { cuiTextBox_Register_Username, label_Register_Username_Error },
                { cuiTextBox_Register_Password, label_Register_Password_Error },
                { cuiTextBox_Register_Email,    label_Register_Email_Error }
            };


            foreach (var txtBox in cuiTxtBox)
            {
                //if (txtBox == cuiTextBox_Register_Email && !ValidationHelper.IsValidEmail(txtBox.Content))
                //{
                //    IndicateError();
                //    return false;
                //}

                if (currentMode == DisplayMode.LogIn)
                {
                    if (txtBox == cuiTextBox_Login_Username && string.IsNullOrWhiteSpace(txtBox.Content) || txtBox.Content.Contains(" "))
                    {
                        IndicateError();
                        return false;
                    }

                    return true;
                }


                if (string.IsNullOrWhiteSpace(txtBox.Content) || txtBox.Content.Contains(" ") || (txtBox == cuiTextBox_Register_Email && !ValidationHelper.IsValidEmail(txtBox.Content)))
                {
                    IndicateError();
                    if (errorLabels.TryGetValue(txtBox, out var label))
                    {
                        label.Visible = true;
                    }
                    return false;
                }
                // TODO: offset textbox placeholder text (use labels) when focused

                continue;

                void IndicateError()
                {
                    txtBox.FocusBorderColor = Color.Red;
                    txtBox.Focus();
                }
            }
            return true;

        }


        private void DuplicateCheck(SqlConnection conn, string username, string email)
        {
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@Username", username);
                checkCmd.Parameters.AddWithValue("@Email", email);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Username or email already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }


        private void HideTxtBoxError(object sender, EventArgs e)
        {
            var errorLabels = new Dictionary<cuiTextBox2, Label>
            {
                { cuiTextBox_Register_Username, label_Register_Username_Error },
                { cuiTextBox_Register_Password, label_Register_Password_Error },
                { cuiTextBox_Register_Email,    label_Register_Email_Error }
            };

            var txtBox = (cuiTextBox2)sender;
            txtBox.FocusBorderColor = Color.FromArgb(53, 167, 255);

            if (errorLabels.TryGetValue(txtBox, out var label))
            {
                label.Visible = false;
            }

        }

        // Hashing method
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

    }
}
