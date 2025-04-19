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
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.cuiButton_LogIn = new CuoreUI.Controls.cuiButton();
            this.cuiButton_Register = new CuoreUI.Controls.cuiButton();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Panel_Title.Controls.Add(this.button_Exit);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(513, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(0, 35);
            this.Panel_Title.TabIndex = 2;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(-43, 0);
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
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Welcome.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(45, 284);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(403, 40);
            this.label_Welcome.TabIndex = 5;
            this.label_Welcome.Text = "Welcome to TrainSMART";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Description.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(45, 324);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(280, 27);
            this.label_Description.TabIndex = 6;
            this.label_Description.Text = "Train smarter. Get results.";
            // 
            // cuiButton_LogIn
            // 
            this.cuiButton_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton_LogIn.CheckButton = false;
            this.cuiButton_LogIn.Checked = false;
            this.cuiButton_LogIn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_LogIn.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_LogIn.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_LogIn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_LogIn.Content = "LOG IN";
            this.cuiButton_LogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_LogIn.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_LogIn.ForeColor = System.Drawing.Color.White;
            this.cuiButton_LogIn.HoverBackground = System.Drawing.Color.LightSkyBlue;
            this.cuiButton_LogIn.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_LogIn.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_LogIn.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_LogIn.Image = null;
            this.cuiButton_LogIn.ImageAutoCenter = true;
            this.cuiButton_LogIn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_LogIn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_LogIn.Location = new System.Drawing.Point(368, 402);
            this.cuiButton_LogIn.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_LogIn.Name = "cuiButton_LogIn";
            this.cuiButton_LogIn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_LogIn.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_LogIn.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_LogIn.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_LogIn.OutlineThickness = 1.6F;
            this.cuiButton_LogIn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.cuiButton_LogIn.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_LogIn.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_LogIn.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_LogIn.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_LogIn.Size = new System.Drawing.Size(142, 52);
            this.cuiButton_LogIn.TabIndex = 7;
            this.cuiButton_LogIn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton_Register
            // 
            this.cuiButton_Register.BackColor = System.Drawing.SystemColors.WindowText;
            this.cuiButton_Register.CheckButton = false;
            this.cuiButton_Register.Checked = false;
            this.cuiButton_Register.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_Register.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_Register.Content = "REGISTER";
            this.cuiButton_Register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_Register.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cuiButton_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Register.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_Register.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_Register.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register.Image = null;
            this.cuiButton_Register.ImageAutoCenter = true;
            this.cuiButton_Register.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_Register.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_Register.Location = new System.Drawing.Point(226, 402);
            this.cuiButton_Register.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton_Register.Name = "cuiButton_Register";
            this.cuiButton_Register.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.cuiButton_Register.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_Register.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register.OutlineThickness = 1.6F;
            this.cuiButton_Register.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_Register.PressedForeColor = System.Drawing.Color.LightGray;
            this.cuiButton_Register.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_Register.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_Register.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiButton_Register.Size = new System.Drawing.Size(142, 52);
            this.cuiButton_Register.TabIndex = 8;
            this.cuiButton_Register.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(513, 788);
            this.panel_Main.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(513, 788);
            this.Controls.Add(this.cuiButton_LogIn);
            this.Controls.Add(this.cuiButton_Register);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.pictureBox_Background);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Description;
        private CuoreUI.Controls.cuiButton cuiButton_LogIn;
        private CuoreUI.Controls.cuiButton cuiButton_Register;
        private System.Windows.Forms.Panel panel_Main;
    }
}

