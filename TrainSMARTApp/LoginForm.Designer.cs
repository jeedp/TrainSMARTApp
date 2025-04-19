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
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.label_Main_Welcome = new System.Windows.Forms.Label();
            this.label_Main_Description = new System.Windows.Forms.Label();
            this.cuiButton_Main_LogIn = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Main_Register = new CuoreUI.Controls.cuiButton();
            this.panel_Menu_Main = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel_Menu_Register = new System.Windows.Forms.Panel();
            this.panel_Menu_LogIn = new System.Windows.Forms.Panel();
            this.label_Register_SignUp = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.panel_Menu_Main.SuspendLayout();
            this.panel_Menu_Register.SuspendLayout();
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
            this.label_Main_Welcome.Size = new System.Drawing.Size(403, 40);
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
            // cuiButton_Main_LogIn
            // 
            this.cuiButton_Main_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton_Main_LogIn.CheckButton = false;
            this.cuiButton_Main_LogIn.Checked = false;
            this.cuiButton_Main_LogIn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_LogIn.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Main_LogIn.Content = "LOG IN";
            this.cuiButton_Main_LogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Main_LogIn.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Main_LogIn.ForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.HoverBackground = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_Main_LogIn.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_LogIn.Image = null;
            this.cuiButton_Main_LogIn.ImageAutoCenter = true;
            this.cuiButton_Main_LogIn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_LogIn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_LogIn.Location = new System.Drawing.Point(368, 402);
            this.cuiButton_Main_LogIn.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Main_LogIn.Name = "cuiButton_Main_LogIn";
            this.cuiButton_Main_LogIn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_LogIn.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_LogIn.OutlineThickness = 1.6F;
            this.cuiButton_Main_LogIn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_Main_LogIn.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Main_LogIn.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Main_LogIn.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Main_LogIn.Size = new System.Drawing.Size(142, 52);
            this.cuiButton_Main_LogIn.TabIndex = 7;
            this.cuiButton_Main_LogIn.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Main_LogIn.Click += new System.EventHandler(this.cuiButton_LogIn_Click);
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
            this.cuiButton_Main_Register.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
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
            this.cuiButton_Main_Register.Size = new System.Drawing.Size(142, 52);
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
            this.panel_Menu_Main.Controls.Add(this.cuiButton_Main_LogIn);
            this.panel_Menu_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Main.Name = "panel_Menu_Main";
            this.panel_Menu_Main.Size = new System.Drawing.Size(0, 788);
            this.panel_Menu_Main.TabIndex = 9;
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
            // panel_Menu_Register
            // 
            this.panel_Menu_Register.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu_Register.Controls.Add(this.label_Register_SignUp);
            this.panel_Menu_Register.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Menu_Register.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_Register.Name = "panel_Menu_Register";
            this.panel_Menu_Register.Size = new System.Drawing.Size(513, 753);
            this.panel_Menu_Register.TabIndex = 10;
            // 
            // panel_Menu_LogIn
            // 
            this.panel_Menu_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu_LogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Menu_LogIn.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu_LogIn.Name = "panel_Menu_LogIn";
            this.panel_Menu_LogIn.Size = new System.Drawing.Size(0, 753);
            this.panel_Menu_LogIn.TabIndex = 11;
            // 
            // label_Register_SignUp
            // 
            this.label_Register_SignUp.AutoSize = true;
            this.label_Register_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_SignUp.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Register_SignUp.ForeColor = System.Drawing.Color.White;
            this.label_Register_SignUp.Location = new System.Drawing.Point(43, 209);
            this.label_Register_SignUp.Name = "label_Register_SignUp";
            this.label_Register_SignUp.Size = new System.Drawing.Size(133, 40);
            this.label_Register_SignUp.TabIndex = 12;
            this.label_Register_SignUp.Text = "Sign up";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(513, 788);
            this.Controls.Add(this.panel_Menu_LogIn);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private System.Windows.Forms.Label label_Main_Welcome;
        private System.Windows.Forms.Label label_Main_Description;
        private CuoreUI.Controls.cuiButton cuiButton_Main_LogIn;
        private CuoreUI.Controls.cuiButton cuiButton_Main_Register;
        private System.Windows.Forms.Panel panel_Menu_Main;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel_Menu_Register;
        private System.Windows.Forms.Panel panel_Menu_LogIn;
        private System.Windows.Forms.Label label_Register_SignUp;
    }
}

