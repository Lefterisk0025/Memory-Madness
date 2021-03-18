
namespace MemoryMadness
{
    partial class MainMenu
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
            this.logo = new System.Windows.Forms.Label();
            this.Panel_MainMenu = new System.Windows.Forms.Panel();
            this.label_WelcomeMsg = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Leaderboard = new System.Windows.Forms.Button();
            this.Button_PlayNow = new System.Windows.Forms.Button();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.label_ErrorSettings = new System.Windows.Forms.Label();
            this.textBox_ImagesDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_EditDir = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Begin = new System.Windows.Forms.Button();
            this.Panel_Username = new System.Windows.Forms.Panel();
            this.label_UsernameError = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_EnterMainMenu = new System.Windows.Forms.Button();
            this.button_UseDefDir = new System.Windows.Forms.Button();
            this.Panel_MainMenu.SuspendLayout();
            this.Panel_Settings.SuspendLayout();
            this.Panel_Username.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Rockwell", 30F);
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.logo.Location = new System.Drawing.Point(478, 52);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(395, 46);
            this.logo.TabIndex = 11;
            this.logo.Text = "MEMORY MADNESS";
            // 
            // Panel_MainMenu
            // 
            this.Panel_MainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_MainMenu.Controls.Add(this.label_WelcomeMsg);
            this.Panel_MainMenu.Controls.Add(this.Button_Exit);
            this.Panel_MainMenu.Controls.Add(this.Button_Leaderboard);
            this.Panel_MainMenu.Controls.Add(this.Button_PlayNow);
            this.Panel_MainMenu.Location = new System.Drawing.Point(442, 115);
            this.Panel_MainMenu.Name = "Panel_MainMenu";
            this.Panel_MainMenu.Size = new System.Drawing.Size(466, 518);
            this.Panel_MainMenu.TabIndex = 13;
            // 
            // label_WelcomeMsg
            // 
            this.label_WelcomeMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_WelcomeMsg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label_WelcomeMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.label_WelcomeMsg.Location = new System.Drawing.Point(0, 45);
            this.label_WelcomeMsg.Name = "label_WelcomeMsg";
            this.label_WelcomeMsg.Size = new System.Drawing.Size(466, 23);
            this.label_WelcomeMsg.TabIndex = 14;
            this.label_WelcomeMsg.Text = "Welcome to madness, MrAkazaas";
            this.label_WelcomeMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Exit.Location = new System.Drawing.Point(107, 271);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Exit.Size = new System.Drawing.Size(252, 54);
            this.Button_Exit.TabIndex = 13;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Leaderboard
            // 
            this.Button_Leaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Leaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_Leaderboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_Leaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_Leaderboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Leaderboard.Location = new System.Drawing.Point(107, 199);
            this.Button_Leaderboard.Name = "Button_Leaderboard";
            this.Button_Leaderboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Leaderboard.Size = new System.Drawing.Size(252, 54);
            this.Button_Leaderboard.TabIndex = 12;
            this.Button_Leaderboard.Text = "Leaderboard";
            this.Button_Leaderboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Leaderboard.UseVisualStyleBackColor = false;
            this.Button_Leaderboard.Click += new System.EventHandler(this.Button_Leaderboard_Click);
            // 
            // Button_PlayNow
            // 
            this.Button_PlayNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_PlayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_PlayNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_PlayNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_PlayNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_PlayNow.Location = new System.Drawing.Point(107, 127);
            this.Button_PlayNow.Name = "Button_PlayNow";
            this.Button_PlayNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_PlayNow.Size = new System.Drawing.Size(252, 54);
            this.Button_PlayNow.TabIndex = 11;
            this.Button_PlayNow.Text = "Play Now";
            this.Button_PlayNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_PlayNow.UseVisualStyleBackColor = false;
            this.Button_PlayNow.Click += new System.EventHandler(this.Button_PlayNow_Click);
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Settings.Controls.Add(this.button_UseDefDir);
            this.Panel_Settings.Controls.Add(this.button_Help);
            this.Panel_Settings.Controls.Add(this.label_ErrorSettings);
            this.Panel_Settings.Controls.Add(this.textBox_ImagesDir);
            this.Panel_Settings.Controls.Add(this.label3);
            this.Panel_Settings.Controls.Add(this.label1);
            this.Panel_Settings.Controls.Add(this.Button_EditDir);
            this.Panel_Settings.Controls.Add(this.Button_Back);
            this.Panel_Settings.Controls.Add(this.Button_Begin);
            this.Panel_Settings.Location = new System.Drawing.Point(442, 115);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(466, 366);
            this.Panel_Settings.TabIndex = 14;
            // 
            // button_Help
            // 
            this.button_Help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_Help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.button_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.Location = new System.Drawing.Point(400, 3);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(63, 30);
            this.button_Help.TabIndex = 27;
            this.button_Help.Text = "Help?";
            this.button_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // label_ErrorSettings
            // 
            this.label_ErrorSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ErrorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_ErrorSettings.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorSettings.Location = new System.Drawing.Point(104, 180);
            this.label_ErrorSettings.Name = "label_ErrorSettings";
            this.label_ErrorSettings.Size = new System.Drawing.Size(258, 17);
            this.label_ErrorSettings.TabIndex = 31;
            this.label_ErrorSettings.Text = "label2";
            this.label_ErrorSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_ImagesDir
            // 
            this.textBox_ImagesDir.Enabled = false;
            this.textBox_ImagesDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_ImagesDir.Location = new System.Drawing.Point(104, 102);
            this.textBox_ImagesDir.Name = "textBox_ImagesDir";
            this.textBox_ImagesDir.Size = new System.Drawing.Size(258, 29);
            this.textBox_ImagesDir.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(141, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Image\'s Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(171, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Settings";
            // 
            // Button_EditDir
            // 
            this.Button_EditDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_EditDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_EditDir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_EditDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_EditDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_EditDir.Location = new System.Drawing.Point(265, 144);
            this.Button_EditDir.Name = "Button_EditDir";
            this.Button_EditDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_EditDir.Size = new System.Drawing.Size(97, 30);
            this.Button_EditDir.TabIndex = 26;
            this.Button_EditDir.Text = "Edit";
            this.Button_EditDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_EditDir.UseVisualStyleBackColor = false;
            this.Button_EditDir.Click += new System.EventHandler(this.Button_EditDir_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Back.Location = new System.Drawing.Point(107, 279);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Back.Size = new System.Drawing.Size(252, 54);
            this.Button_Back.TabIndex = 14;
            this.Button_Back.Text = "Back";
            this.Button_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Begin
            // 
            this.Button_Begin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_Begin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_Begin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_Begin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Begin.Location = new System.Drawing.Point(107, 219);
            this.Button_Begin.Name = "Button_Begin";
            this.Button_Begin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Begin.Size = new System.Drawing.Size(252, 54);
            this.Button_Begin.TabIndex = 13;
            this.Button_Begin.Text = "Start Game";
            this.Button_Begin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Begin.UseVisualStyleBackColor = false;
            this.Button_Begin.Click += new System.EventHandler(this.Button_Begin_Click);
            // 
            // Panel_Username
            // 
            this.Panel_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Username.Controls.Add(this.label_UsernameError);
            this.Panel_Username.Controls.Add(this.textBox_Username);
            this.Panel_Username.Controls.Add(this.label5);
            this.Panel_Username.Controls.Add(this.Button_EnterMainMenu);
            this.Panel_Username.Location = new System.Drawing.Point(442, 242);
            this.Panel_Username.Name = "Panel_Username";
            this.Panel_Username.Size = new System.Drawing.Size(466, 205);
            this.Panel_Username.TabIndex = 15;
            // 
            // label_UsernameError
            // 
            this.label_UsernameError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_UsernameError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_UsernameError.ForeColor = System.Drawing.Color.Red;
            this.label_UsernameError.Location = new System.Drawing.Point(107, 102);
            this.label_UsernameError.Name = "label_UsernameError";
            this.label_UsernameError.Size = new System.Drawing.Size(252, 16);
            this.label_UsernameError.TabIndex = 31;
            this.label_UsernameError.Text = "Usercame can contain only letters";
            this.label_UsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Username.Location = new System.Drawing.Point(107, 70);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(252, 29);
            this.textBox_Username.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(110, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "How should we call you?";
            // 
            // Button_EnterMainMenu
            // 
            this.Button_EnterMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_EnterMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Button_EnterMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Button_EnterMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.Button_EnterMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_EnterMainMenu.Location = new System.Drawing.Point(107, 123);
            this.Button_EnterMainMenu.Name = "Button_EnterMainMenu";
            this.Button_EnterMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_EnterMainMenu.Size = new System.Drawing.Size(252, 54);
            this.Button_EnterMainMenu.TabIndex = 13;
            this.Button_EnterMainMenu.Text = "Enter";
            this.Button_EnterMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_EnterMainMenu.UseVisualStyleBackColor = false;
            this.Button_EnterMainMenu.Click += new System.EventHandler(this.Button_EnterMainMenu_Click);
            // 
            // button_UseDefDir
            // 
            this.button_UseDefDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_UseDefDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_UseDefDir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.button_UseDefDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.button_UseDefDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_UseDefDir.Location = new System.Drawing.Point(104, 144);
            this.button_UseDefDir.Name = "button_UseDefDir";
            this.button_UseDefDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_UseDefDir.Size = new System.Drawing.Size(155, 30);
            this.button_UseDefDir.TabIndex = 32;
            this.button_UseDefDir.Text = "Use Default";
            this.button_UseDefDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_UseDefDir.UseVisualStyleBackColor = false;
            this.button_UseDefDir.Click += new System.EventHandler(this.button_UseDefDir_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1351, 689);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Panel_Settings);
            this.Controls.Add(this.Panel_Username);
            this.Controls.Add(this.Panel_MainMenu);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1003, 714);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Madness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_MainMenu.ResumeLayout(false);
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.Panel_Username.ResumeLayout(false);
            this.Panel_Username.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel Panel_MainMenu;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Leaderboard;
        private System.Windows.Forms.Button Button_PlayNow;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Begin;
        private System.Windows.Forms.Button Button_EditDir;
        private System.Windows.Forms.TextBox textBox_ImagesDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_EnterMainMenu;
        private System.Windows.Forms.Label label_UsernameError;
        private System.Windows.Forms.Label label_WelcomeMsg;
        private System.Windows.Forms.Label label_ErrorSettings;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_UseDefDir;
    }
}

