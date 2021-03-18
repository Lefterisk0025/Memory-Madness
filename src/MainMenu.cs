using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMadness
{
    public partial class MainMenu : Form
    {
        static public int maxCardsNum = 6;
        static public string username;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_UsernameError.Visible = false;
            label_ErrorSettings.Visible = false;
            Panel_Settings.Visible = false;
            Panel_MainMenu.Visible = false;

            //Settings Menu
            textBox_ImagesDir.Text = @"UI\default";
        }

        private void Button_EnterMainMenu_Click(object sender, EventArgs e)
        {
            if (!IsUsernameValid())
                return;

            label_UsernameError.Visible = false;
            Panel_Username.Visible = false;
            Panel_MainMenu.Visible = true;

            username = textBox_Username.Text;
            label_WelcomeMsg.Text = "Welcome to madness, " + username;                        
        }

        private bool IsUsernameValid()
        {
            if (String.IsNullOrEmpty(textBox_Username.Text))
            {
                label_UsernameError.Text = "Username must be filled out";
                label_UsernameError.Visible = true;
                return false;
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(textBox_Username.Text, @"^[a-zA-Z]+$"))
            {
                label_UsernameError.Text = "Username must contain only letters";
                label_UsernameError.Visible = true;
                return false;
            }
            label_UsernameError.Visible = false;
            return true;
        }

        private void Button_PlayNow_Click(object sender, EventArgs e)
        {
            Panel_MainMenu.Visible = false;
            Panel_Settings.Visible = true;
        }

        private void Button_Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Leaderboard(this).Show();            
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Button_Begin_Click(object sender, EventArgs e)
        {
            //Settings Valdation
            string[] imagesPaths = Directory.GetFiles(textBox_ImagesDir.Text, "*.png");          
            if (imagesPaths.Length == maxCardsNum)
            {
                new GameForm(imagesPaths, this).Show();
                this.Hide();
            }
            else
            {
                label_ErrorSettings.Visible = true;
                label_ErrorSettings.Text = "Invalid Directory";
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Panel_Settings.Visible = false;
            Panel_MainMenu.Visible = true;
        }

        private void Button_EditDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)                
                    textBox_ImagesDir.Text = folderBrowserDialog.SelectedPath;              
                else
                    textBox_ImagesDir.Text = @"UI\default";
            }
        }

        private void button_UseDefDir_Click(object sender, EventArgs e)
        {
            textBox_ImagesDir.Text = @"UI\default";
            label_ErrorSettings.Visible = false;
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Images required: 6\nPNG is the only supported extention");
        }
    }
}
