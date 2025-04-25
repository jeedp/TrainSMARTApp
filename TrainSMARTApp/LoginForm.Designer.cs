namespace TrainSMARTApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.label_Main_Welcome = new System.Windows.Forms.Label();
            this.label_Main_Description = new System.Windows.Forms.Label();
            this.cuiButton_Main_Login = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Main_Register = new CuoreUI.Controls.cuiButton();
            this.panel_Menu_Main = new System.Windows.Forms.Panel();
            this.panel_Menu_Register = new System.Windows.Forms.Panel();
            this.label_Register_Email_Error = new System.Windows.Forms.Label();
            this.label_Register_Password_Error = new System.Windows.Forms.Label();
            this.label_Register_Username_Error = new System.Windows.Forms.Label();
            this.cuiButton_Register_PrivacyPolicy = new CuoreUI.Controls.cuiButton();
            this.label_Register_PrivacyPolicy = new System.Windows.Forms.Label();
            this.cuiButton_Register_SignUp = new CuoreUI.Controls.cuiButton();
            this.cuiTextBox_Register_Email = new CuoreUI.Controls.cuiTextBox2();
            this.cuiTextBox_Register_Username = new CuoreUI.Controls.cuiTextBox2();
            this.cuiTextBox_Register_Password = new CuoreUI.Controls.cuiTextBox2();
            this.label_Register_SignUp = new System.Windows.Forms.Label();
            this.panel_Menu_Login = new System.Windows.Forms.Panel();
            this.cuiButton_Login_ResetPass = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Login_Login = new CuoreUI.Controls.cuiButton();
            this.cuiTextBox_Login_Password = new CuoreUI.Controls.cuiTextBox2();
            this.cuiTextBox_Login_Username = new CuoreUI.Controls.cuiTextBox2();
            this.label_Login_Login = new System.Windows.Forms.Label();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.panel_Menu_Main.SuspendLayout();
            this.panel_Menu_Register.SuspendLayout();
            this.panel_Menu_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_Title.Controls.Add(this.button_Back);
            this.panel_Title.Controls.Add(this.button_Exit);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(513, 35);
            this.panel_Title.TabIndex = 2;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(0, 0);
            this.button_Back.Margin = new System.Windows.Forms.Padding(0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(43, 35);
            this.button_Back.TabIndex = 6;
            this.button_Back.TabStop = false;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(470, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(43, 35);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.TabStop = false;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox_Background
            // 
            this.pictureBox_Background.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Background.Image")));
            this.pictureBox_Background.Location = new System.Drawing.Point(-49, 0);
            this.pictureBox_Background.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Background.Name = "pictureBox_Background";
            this.pictureBox_Background.Size = new System.Drawing.Size(592, 854);
            this.pictureBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Background.TabIndex = 4;
            this.pictureBox_Background.TabStop = false;
            // 
            // label_Main_Welcome
            // 
            this.label_Main_Welcome.AutoSize = true;
            this.label_Main_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Main_Welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Main_Welcome.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Main_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Main_Welcome.Location = new System.Drawing.Point(45, 284);
            this.label_Main_Welcome.Name = "label_Main_Welcome";
            this.label_Main_Welcome.Size = new System.Drawing.Size(387, 38);
            this.label_Main_Welcome.TabIndex = 5;
            this.label_Main_Welcome.Text = "Welcome to TrainSMART";
            // 
            // label_Main_Description
            // 
            this.label_Main_Description.AutoSize = true;
            this.label_Main_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Main_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Main_Description.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Main_Description.ForeColor = System.Drawing.Color.White;
            this.label_Main_Description.Location = new System.Drawing.Point(47, 324);
            this.label_Main_Description.Name = "label_Main_Description";
            this.label_Main_Description.Size = new System.Drawing.Size(280, 27);
            this.label_Main_Description.TabIndex = 6;
            this.label_Main_Description.Text = "Train smarter. Get results.";
            // 
            // cuiButton_Main_Login
            // 
            this.cuiButton_Main_Login.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton_Main_Login.CheckButton = false;
            this.cuiButton_Main_Login.Checked = false;
            this.cuiButton_Main_Login.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_Login.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Login.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Login.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_Login.Content = "LOG IN";
            this.cuiButton_Main_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Main_Login.Font = new System.Drawing.Font("SansSerif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Main_Login.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Login.HoverBackground = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_Main_Login.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Login.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Login.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Login.Image = null;
            this.cuiButton_Main_Login.ImageAutoCenter = true;
            this.cuiButton_Main_Login.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Login.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Login.Location = new System.Drawing.Point(368, 402);
            this.cuiButton_Main_Login.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Main_Login.Name = "cuiButton_Main_Login";
            this.cuiButton_Main_Login.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_Login.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Login.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Login.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Login.OutlineThickness = 1.6F;
            this.cuiButton_Main_Login.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_Login.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Login.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Login.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Login.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Main_Login.Size = new System.Drawing.Size(143, 54);
            this.cuiButton_Main_Login.TabIndex = 7;
            this.cuiButton_Main_Login.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Login.Click += new System.EventHandler(this.cuiButton_LogIn_Click);
            // 
            // cuiButton_Main_Register
            // 
            this.cuiButton_Main_Register.BackColor = System.Drawing.SystemColors.WindowText;
            this.cuiButton_Main_Register.CheckButton = false;
            this.cuiButton_Main_Register.Checked = false;
            this.cuiButton_Main_Register.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_Register.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Register.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Register.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_Register.Content = "REGISTER";
            this.cuiButton_Main_Register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Main_Register.Font = new System.Drawing.Font("SansSerif", 12.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Main_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_Register.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Main_Register.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Register.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_Register.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Register.Image = null;
            this.cuiButton_Main_Register.ImageAutoCenter = true;
            this.cuiButton_Main_Register.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Register.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Register.Location = new System.Drawing.Point(226, 402);
            this.cuiButton_Main_Register.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Main_Register.Name = "cuiButton_Main_Register";
            this.cuiButton_Main_Register.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Main_Register.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_Register.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Register.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Register.OutlineThickness = 1.6F;
            this.cuiButton_Main_Register.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Main_Register.PressedForeColor = System.Drawing.Color.LightGray;
            this.cuiButton_Main_Register.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_Register.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_Register.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Main_Register.Size = new System.Drawing.Size(143, 54);
            this.cuiButton_Main_Register.TabIndex = 8;
            this.cuiButton_Main_Register.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_Register.Click += new System.EventHandler(this.cuiButton_Register_Click);
            // 
            // panel_Menu_Main
            // 
            this.panel_Menu_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu_Main.Controls.Add(this.label_Main_Description);
            this.panel_Menu_Main.Controls.Add(this.label_Main_Welcome);
            this.panel_Menu_Main.Controls.Add(this.cuiButton_Main_Register);
            this.panel_Menu_Main.Controls.Add(this.cuiButton_Main_Login);
            this.panel_Menu_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Main.Name = "panel_Menu_Main";
            this.panel_Menu_Main.Size = new System.Drawing.Size(0, 787);
            this.panel_Menu_Main.TabIndex = 9;
            // 
            // panel_Menu_Register
            // 
            this.panel_Menu_Register.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu_Register.Controls.Add(this.label_Register_Email_Error);
            this.panel_Menu_Register.Controls.Add(this.label_Register_Password_Error);
            this.panel_Menu_Register.Controls.Add(this.label_Register_Username_Error);
            this.panel_Menu_Register.Controls.Add(this.cuiButton_Register_PrivacyPolicy);
            this.panel_Menu_Register.Controls.Add(this.label_Register_PrivacyPolicy);
            this.panel_Menu_Register.Controls.Add(this.cuiButton_Register_SignUp);
            this.panel_Menu_Register.Controls.Add(this.cuiTextBox_Register_Email);
            this.panel_Menu_Register.Controls.Add(this.cuiTextBox_Register_Username);
            this.panel_Menu_Register.Controls.Add(this.cuiTextBox_Register_Password);
            this.panel_Menu_Register.Controls.Add(this.label_Register_SignUp);
            this.panel_Menu_Register.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Menu_Register.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.panel_Menu_Register.ForeColor = System.Drawing.Color.White;
            this.panel_Menu_Register.Location = new System.Drawing.Point(513, 35);
            this.panel_Menu_Register.Name = "panel_Menu_Register";
            this.panel_Menu_Register.Size = new System.Drawing.Size(0, 752);
            this.panel_Menu_Register.TabIndex = 10;
            // 
            // label_Register_Email_Error
            // 
            this.label_Register_Email_Error.AutoSize = true;
            this.label_Register_Email_Error.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_Email_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_Email_Error.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_Email_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.label_Register_Email_Error.Location = new System.Drawing.Point(209, 508);
            this.label_Register_Email_Error.Name = "label_Register_Email_Error";
            this.label_Register_Email_Error.Size = new System.Drawing.Size(179, 21);
            this.label_Register_Email_Error.TabIndex = 22;
            this.label_Register_Email_Error.Text = "Invalid email address";
            this.label_Register_Email_Error.Visible = false;
            // 
            // label_Register_Password_Error
            // 
            this.label_Register_Password_Error.AutoSize = true;
            this.label_Register_Password_Error.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_Password_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_Password_Error.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_Password_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.label_Register_Password_Error.Location = new System.Drawing.Point(209, 402);
            this.label_Register_Password_Error.Name = "label_Register_Password_Error";
            this.label_Register_Password_Error.Size = new System.Drawing.Size(233, 21);
            this.label_Register_Password_Error.TabIndex = 21;
            this.label_Register_Password_Error.Text = "Invalid password characters";
            this.label_Register_Password_Error.Visible = false;
            // 
            // label_Register_Username_Error
            // 
            this.label_Register_Username_Error.AutoSize = true;
            this.label_Register_Username_Error.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_Username_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_Username_Error.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_Username_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.label_Register_Username_Error.Location = new System.Drawing.Point(209, 298);
            this.label_Register_Username_Error.Name = "label_Register_Username_Error";
            this.label_Register_Username_Error.Size = new System.Drawing.Size(187, 21);
            this.label_Register_Username_Error.TabIndex = 20;
            this.label_Register_Username_Error.Text = "Username is required!";
            this.label_Register_Username_Error.Visible = false;
            // 
            // cuiButton_Register_PrivacyPolicy
            // 
            this.cuiButton_Register_PrivacyPolicy.BackColor = System.Drawing.SystemColors.WindowText;
            this.cuiButton_Register_PrivacyPolicy.CheckButton = false;
            this.cuiButton_Register_PrivacyPolicy.Checked = false;
            this.cuiButton_Register_PrivacyPolicy.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register_PrivacyPolicy.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register_PrivacyPolicy.Content = "PRIVACY POLICY";
            this.cuiButton_Register_PrivacyPolicy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Register_PrivacyPolicy.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Register_PrivacyPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Register_PrivacyPolicy.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register_PrivacyPolicy.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_PrivacyPolicy.Image = null;
            this.cuiButton_Register_PrivacyPolicy.ImageAutoCenter = true;
            this.cuiButton_Register_PrivacyPolicy.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Register_PrivacyPolicy.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Register_PrivacyPolicy.Location = new System.Drawing.Point(458, 614);
            this.cuiButton_Register_PrivacyPolicy.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Register_PrivacyPolicy.Name = "cuiButton_Register_PrivacyPolicy";
            this.cuiButton_Register_PrivacyPolicy.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register_PrivacyPolicy.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Register_PrivacyPolicy.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_PrivacyPolicy.OutlineThickness = 1.6F;
            this.cuiButton_Register_PrivacyPolicy.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register_PrivacyPolicy.PressedForeColor = System.Drawing.Color.LightGray;
            this.cuiButton_Register_PrivacyPolicy.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_PrivacyPolicy.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_PrivacyPolicy.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Register_PrivacyPolicy.Size = new System.Drawing.Size(142, 54);
            this.cuiButton_Register_PrivacyPolicy.TabIndex = 19;
            this.cuiButton_Register_PrivacyPolicy.TextOffset = new System.Drawing.Point(0, -10);
            this.cuiButton_Register_PrivacyPolicy.Click += new System.EventHandler(this.cuiButton_Register_PrivacyPolicy_Click);
            // 
            // label_Register_PrivacyPolicy
            // 
            this.label_Register_PrivacyPolicy.AutoSize = true;
            this.label_Register_PrivacyPolicy.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_PrivacyPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_PrivacyPolicy.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_PrivacyPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_Register_PrivacyPolicy.Location = new System.Drawing.Point(188, 620);
            this.label_Register_PrivacyPolicy.Name = "label_Register_PrivacyPolicy";
            this.label_Register_PrivacyPolicy.Size = new System.Drawing.Size(230, 40);
            this.label_Register_PrivacyPolicy.TabIndex = 18;
            this.label_Register_PrivacyPolicy.Text = "By signing in to TrainSMART,\r\nyou agree to our";
            this.label_Register_PrivacyPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cuiButton_Register_SignUp
            // 
            this.cuiButton_Register_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton_Register_SignUp.CheckButton = false;
            this.cuiButton_Register_SignUp.Checked = false;
            this.cuiButton_Register_SignUp.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register_SignUp.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register_SignUp.Content = "SIGN UP";
            this.cuiButton_Register_SignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Register_SignUp.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Register_SignUp.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.HoverBackground = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_Register_SignUp.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_SignUp.Image = null;
            this.cuiButton_Register_SignUp.ImageAutoCenter = true;
            this.cuiButton_Register_SignUp.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Register_SignUp.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Register_SignUp.Location = new System.Drawing.Point(193, 538);
            this.cuiButton_Register_SignUp.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Register_SignUp.Name = "cuiButton_Register_SignUp";
            this.cuiButton_Register_SignUp.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Register_SignUp.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_SignUp.OutlineThickness = 1.6F;
            this.cuiButton_Register_SignUp.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_Register_SignUp.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register_SignUp.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register_SignUp.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Register_SignUp.Size = new System.Drawing.Size(410, 55);
            this.cuiButton_Register_SignUp.TabIndex = 17;
            this.cuiButton_Register_SignUp.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Register_SignUp.Click += new System.EventHandler(this.cuiButton_Register_SignUp_Click);
            // 
            // cuiTextBox_Register_Email
            // 
            this.cuiTextBox_Register_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Email.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Email.BorderColor = System.Drawing.Color.Transparent;
            this.cuiTextBox_Register_Email.BorderSize = 2;
            this.cuiTextBox_Register_Email.Content = "";
            this.cuiTextBox_Register_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Register_Email.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Email.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiTextBox_Register_Email.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Register_Email.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Register_Email.Location = new System.Drawing.Point(193, 425);
            this.cuiTextBox_Register_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.cuiTextBox_Register_Email.Multiline = false;
            this.cuiTextBox_Register_Email.Name = "cuiTextBox_Register_Email";
            this.cuiTextBox_Register_Email.Padding = new System.Windows.Forms.Padding(24, 28, 24, 0);
            this.cuiTextBox_Register_Email.PasswordChar = false;
            this.cuiTextBox_Register_Email.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuiTextBox_Register_Email.PlaceholderText = "Email";
            this.cuiTextBox_Register_Email.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_Register_Email.Size = new System.Drawing.Size(410, 80);
            this.cuiTextBox_Register_Email.TabIndex = 16;
            this.cuiTextBox_Register_Email.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Register_Email.UnderlinedStyle = false;
            // 
            // cuiTextBox_Register_Username
            // 
            this.cuiTextBox_Register_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Username.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Username.BorderColor = System.Drawing.Color.Transparent;
            this.cuiTextBox_Register_Username.BorderSize = 2;
            this.cuiTextBox_Register_Username.Content = "";
            this.cuiTextBox_Register_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Register_Username.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Username.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiTextBox_Register_Username.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Register_Username.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Register_Username.Location = new System.Drawing.Point(193, 215);
            this.cuiTextBox_Register_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 21);
            this.cuiTextBox_Register_Username.Multiline = false;
            this.cuiTextBox_Register_Username.Name = "cuiTextBox_Register_Username";
            this.cuiTextBox_Register_Username.Padding = new System.Windows.Forms.Padding(24, 28, 24, 0);
            this.cuiTextBox_Register_Username.PasswordChar = false;
            this.cuiTextBox_Register_Username.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuiTextBox_Register_Username.PlaceholderText = "Username";
            this.cuiTextBox_Register_Username.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_Register_Username.Size = new System.Drawing.Size(410, 80);
            this.cuiTextBox_Register_Username.TabIndex = 14;
            this.cuiTextBox_Register_Username.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Register_Username.UnderlinedStyle = false;
            // 
            // cuiTextBox_Register_Password
            // 
            this.cuiTextBox_Register_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Password.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Password.BorderColor = System.Drawing.Color.Transparent;
            this.cuiTextBox_Register_Password.BorderSize = 2;
            this.cuiTextBox_Register_Password.Content = "";
            this.cuiTextBox_Register_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Register_Password.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Register_Password.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiTextBox_Register_Password.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Register_Password.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Register_Password.Location = new System.Drawing.Point(193, 321);
            this.cuiTextBox_Register_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 22);
            this.cuiTextBox_Register_Password.Multiline = false;
            this.cuiTextBox_Register_Password.Name = "cuiTextBox_Register_Password";
            this.cuiTextBox_Register_Password.Padding = new System.Windows.Forms.Padding(24, 28, 24, 0);
            this.cuiTextBox_Register_Password.PasswordChar = false;
            this.cuiTextBox_Register_Password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuiTextBox_Register_Password.PlaceholderText = "Password";
            this.cuiTextBox_Register_Password.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_Register_Password.Size = new System.Drawing.Size(410, 80);
            this.cuiTextBox_Register_Password.TabIndex = 15;
            this.cuiTextBox_Register_Password.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Register_Password.UnderlinedStyle = false;
            // 
            // label_Register_SignUp
            // 
            this.label_Register_SignUp.AutoSize = true;
            this.label_Register_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_SignUp.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_SignUp.ForeColor = System.Drawing.Color.White;
            this.label_Register_SignUp.Location = new System.Drawing.Point(45, 133);
            this.label_Register_SignUp.Name = "label_Register_SignUp";
            this.label_Register_SignUp.Size = new System.Drawing.Size(127, 38);
            this.label_Register_SignUp.TabIndex = 12;
            this.label_Register_SignUp.Text = "Sign up";
            // 
            // panel_Menu_Login
            // 
            this.panel_Menu_Login.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu_Login.Controls.Add(this.cuiButton_Login_ResetPass);
            this.panel_Menu_Login.Controls.Add(this.cuiButton_Login_Login);
            this.panel_Menu_Login.Controls.Add(this.cuiTextBox_Login_Password);
            this.panel_Menu_Login.Controls.Add(this.cuiTextBox_Login_Username);
            this.panel_Menu_Login.Controls.Add(this.label_Login_Login);
            this.panel_Menu_Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Menu_Login.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_Login.Name = "panel_Menu_Login";
            this.panel_Menu_Login.Size = new System.Drawing.Size(513, 752);
            this.panel_Menu_Login.TabIndex = 11;
            // 
            // cuiButton_Login_ResetPass
            // 
            this.cuiButton_Login_ResetPass.BackColor = System.Drawing.SystemColors.WindowText;
            this.cuiButton_Login_ResetPass.CheckButton = false;
            this.cuiButton_Login_ResetPass.Checked = false;
            this.cuiButton_Login_ResetPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Login_ResetPass.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Login_ResetPass.Content = "RESET PASSWORD";
            this.cuiButton_Login_ResetPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Login_ResetPass.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Login_ResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Login_ResetPass.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Login_ResetPass.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_ResetPass.Image = null;
            this.cuiButton_Login_ResetPass.ImageAutoCenter = true;
            this.cuiButton_Login_ResetPass.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_ResetPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_ResetPass.Location = new System.Drawing.Point(224, 496);
            this.cuiButton_Login_ResetPass.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Login_ResetPass.Name = "cuiButton_Login_ResetPass";
            this.cuiButton_Login_ResetPass.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Login_ResetPass.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Login_ResetPass.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_ResetPass.OutlineThickness = 1.6F;
            this.cuiButton_Login_ResetPass.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Login_ResetPass.PressedForeColor = System.Drawing.Color.LightGray;
            this.cuiButton_Login_ResetPass.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_ResetPass.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_ResetPass.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Login_ResetPass.Size = new System.Drawing.Size(240, 52);
            this.cuiButton_Login_ResetPass.TabIndex = 18;
            this.cuiButton_Login_ResetPass.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_ResetPass.Click += new System.EventHandler(this.cuiButton_Login_ResetPass_Click);
            // 
            // cuiButton_Login_Login
            // 
            this.cuiButton_Login_Login.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton_Login_Login.CheckButton = false;
            this.cuiButton_Login_Login.Checked = false;
            this.cuiButton_Login_Login.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Login_Login.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_Login.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_Login.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Login_Login.Content = "LOG IN";
            this.cuiButton_Login_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Login_Login.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Login_Login.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_Login.HoverBackground = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_Login_Login.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_Login.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_Login.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_Login.Image = null;
            this.cuiButton_Login_Login.ImageAutoCenter = true;
            this.cuiButton_Login_Login.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_Login.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_Login.Location = new System.Drawing.Point(464, 495);
            this.cuiButton_Login_Login.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Login_Login.Name = "cuiButton_Login_Login";
            this.cuiButton_Login_Login.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Login_Login.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_Login.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_Login.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_Login.OutlineThickness = 1.6F;
            this.cuiButton_Login_Login.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_Login_Login.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Login_Login.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Login_Login.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Login_Login.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Login_Login.Size = new System.Drawing.Size(143, 54);
            this.cuiButton_Login_Login.TabIndex = 17;
            this.cuiButton_Login_Login.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Login_Login.Click += new System.EventHandler(this.cuiButton_Login_Login_Click);
            // 
            // cuiTextBox_Login_Password
            // 
            this.cuiTextBox_Login_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Password.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Password.BorderColor = System.Drawing.Color.Transparent;
            this.cuiTextBox_Login_Password.BorderSize = 2;
            this.cuiTextBox_Login_Password.Content = "";
            this.cuiTextBox_Login_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Login_Password.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Password.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiTextBox_Login_Password.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Login_Password.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Login_Password.Location = new System.Drawing.Point(194, 369);
            this.cuiTextBox_Login_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 22);
            this.cuiTextBox_Login_Password.Multiline = false;
            this.cuiTextBox_Login_Password.Name = "cuiTextBox_Login_Password";
            this.cuiTextBox_Login_Password.Padding = new System.Windows.Forms.Padding(24, 34, 24, 0);
            this.cuiTextBox_Login_Password.PasswordChar = false;
            this.cuiTextBox_Login_Password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuiTextBox_Login_Password.PlaceholderText = "Password";
            this.cuiTextBox_Login_Password.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_Login_Password.Size = new System.Drawing.Size(410, 92);
            this.cuiTextBox_Login_Password.TabIndex = 16;
            this.cuiTextBox_Login_Password.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Login_Password.UnderlinedStyle = false;
            // 
            // cuiTextBox_Login_Username
            // 
            this.cuiTextBox_Login_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Username.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Username.BorderColor = System.Drawing.Color.Transparent;
            this.cuiTextBox_Login_Username.BorderSize = 2;
            this.cuiTextBox_Login_Username.Content = "";
            this.cuiTextBox_Login_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox_Login_Username.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(77)))));
            this.cuiTextBox_Login_Username.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiTextBox_Login_Username.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiTextBox_Login_Username.ForeColor = System.Drawing.Color.White;
            this.cuiTextBox_Login_Username.Location = new System.Drawing.Point(194, 253);
            this.cuiTextBox_Login_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 21);
            this.cuiTextBox_Login_Username.Multiline = false;
            this.cuiTextBox_Login_Username.Name = "cuiTextBox_Login_Username";
            this.cuiTextBox_Login_Username.Padding = new System.Windows.Forms.Padding(24, 34, 24, 0);
            this.cuiTextBox_Login_Username.PasswordChar = false;
            this.cuiTextBox_Login_Username.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuiTextBox_Login_Username.PlaceholderText = "Username or email";
            this.cuiTextBox_Login_Username.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiTextBox_Login_Username.Size = new System.Drawing.Size(410, 92);
            this.cuiTextBox_Login_Username.TabIndex = 15;
            this.cuiTextBox_Login_Username.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTextBox_Login_Username.UnderlinedStyle = false;
            // 
            // label_Login_Login
            // 
            this.label_Login_Login.AutoSize = true;
            this.label_Login_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Login_Login.Font = new System.Drawing.Font("SansSerif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Login_Login.ForeColor = System.Drawing.Color.White;
            this.label_Login_Login.Location = new System.Drawing.Point(187, 186);
            this.label_Login_Login.Name = "label_Login_Login";
            this.label_Login_Login.Size = new System.Drawing.Size(121, 43);
            this.label_Login_Login.TabIndex = 13;
            this.label_Login_Login.Text = "Log in";
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.EnhanceCorners = true;
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder.Rounding = 6;
            this.cuiFormRounder.TargetForm = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(513, 787);
            this.Controls.Add(this.panel_Menu_Login);
            this.Controls.Add(this.panel_Menu_Register);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Menu_Main);
            this.Controls.Add(this.pictureBox_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            this.panel_Menu_Main.ResumeLayout(false);
            this.panel_Menu_Main.PerformLayout();
            this.panel_Menu_Register.ResumeLayout(false);
            this.panel_Menu_Register.PerformLayout();
            this.panel_Menu_Login.ResumeLayout(false);
            this.panel_Menu_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private System.Windows.Forms.Label label_Main_Welcome;
        private System.Windows.Forms.Label label_Main_Description;
        private CuoreUI.Controls.cuiButton cuiButton_Main_Login;
        private CuoreUI.Controls.cuiButton cuiButton_Main_Register;
        private System.Windows.Forms.Panel panel_Menu_Main;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel_Menu_Register;
        private System.Windows.Forms.Panel panel_Menu_Login;
        private System.Windows.Forms.Label label_Register_SignUp;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Register_Username;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Register_Password;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Register_Email;
        private CuoreUI.Controls.cuiButton cuiButton_Register_SignUp;
        private CuoreUI.Controls.cuiButton cuiButton_Register_PrivacyPolicy;
        private System.Windows.Forms.Label label_Register_PrivacyPolicy;
        private CuoreUI.Controls.cuiButton cuiButton_Login_ResetPass;
        private CuoreUI.Controls.cuiButton cuiButton_Login_Login;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Login_Password;
        private CuoreUI.Controls.cuiTextBox2 cuiTextBox_Login_Username;
        private System.Windows.Forms.Label label_Login_Login;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private System.Windows.Forms.Label label_Register_Username_Error;
        private System.Windows.Forms.Label label_Register_Email_Error;
        private System.Windows.Forms.Label label_Register_Password_Error;
    }
}

