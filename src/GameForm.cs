using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMadness
{
    public partial class GameForm : Form
    {
        private int matchNum1, matchNum2;
        private int matchCount = 0;
        private int[,] arrayOfNums;
        private int waitTimeBeforeStart = 2;

        //ScoreBoard
        private int time;
        private int attempts;
        private int score;

        private string[] imagesPaths;

        List<Card> cardsList = new List<Card>();
        Random rnd;
        PictureBox firstPictureBox;

        Form mainMenu;
        DBController dbController;

        public GameForm()
        {
            InitializeComponent();
        }
        public GameForm(string[] imagesPaths, Form MainMenu)
        {           
            InitializeComponent();

            this.imagesPaths = imagesPaths;
            this.mainMenu = MainMenu;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            arrayOfNums = new int[,] { { 1, 2 }, { 2, 2 }, { 3, 2 }, { 4, 2 }, { 5, 2 }, { 6, 2 } };

            panel_Score.Visible = false;
            dbController = new DBController();

            time = 0;
            attempts = 0;

            InitializeTable();

            timer1.Start();
        }

        private async void InitializeTable()
        {                                   
            panel_GameTable.Visible = true;
            //Iterate through all pictureboxes of Game Table (Panel)
            foreach (PictureBox pictureBox in panel_GameTable.Controls.OfType<PictureBox>())
            {                     
                //The 2d array arrayOfNums show a number and how many times it has been used. Each num can only be used 2 times
                //Tie a pictureBox with a num from arrayOfNums
                int x;
                bool isValid = false;
                do
                {
                    x = rnd.Next(1, MainMenu.maxCardsNum+1); //using static var maxCardsNum from MainMenu
                    if (arrayOfNums[x - 1, 1] != 0) 
                        isValid = true;
                }
                while (!isValid);
                //Initialize pictureBox and tie it with a card
                cardsList.Add(new Card(pictureBox.Name, x, imagesPaths[x-1]));
                arrayOfNums[x - 1, 1]--;

                pictureBox.BackgroundImage = Image.FromFile(imagesPaths[x - 1]);                    

                if (pictureBox != null)
                    pictureBox.MouseDown += CheckMatch;

            }
            await Task.Delay(waitTimeBeforeStart * 1000);
            foreach (PictureBox pictureBox in panel_GameTable.Controls.OfType<PictureBox>())                                    
                pictureBox.BackgroundImage = Image.FromFile(@"UI\back.png");
                            
        }

        private void CheckMatch(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            //Iterate cards list to find, by name, the card that is tied to the sender pictureBox
            foreach(Card card in cardsList)
            {
                if(pictureBox.Name.Equals(card.pictureBoxName))
                {
                    //The first match
                    if (matchNum1 == 0)
                    {
                        //Save the first pictureBox
                        firstPictureBox = pictureBox;
                        //Change the image 
                        pictureBox.BackgroundImage = Image.FromFile(card.imagePath);
                        //Set the first match number
                        matchNum1 = card.matchNum;
                        //Disable click event
                        pictureBox.MouseDown -= CheckMatch;
                        return;
                    }
                    //At the second turn its time for the second match
                    if (matchNum2 == 0)
                    {
                        pictureBox.BackgroundImage = Image.FromFile(card.imagePath);
                        matchNum2 = card.matchNum;
                        pictureBox.MouseDown -= CheckMatch;
                        break;
                    }
                }
            }

            attempts++;

            //Compare match numbers
            if (matchNum1 == matchNum2)
            {
                matchCount++;
                MessageBox.Show("Match found!");
            }                           
            else
            {
                MessageBox.Show("No match");
                firstPictureBox.BackgroundImage = Image.FromFile(@"UI\back.png");
                pictureBox.BackgroundImage = Image.FromFile(@"UI\back.png");

                pictureBox.MouseDown += CheckMatch;
                firstPictureBox.MouseDown += CheckMatch;
            }

            if (matchCount == MainMenu.maxCardsNum)
            {
                timer1.Stop();
                DisplayResults();
            }
                              
            //Initializate match numbers
            matchNum1 = 0;           
            matchNum2 = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void DisplayResults()
        {
            //Calculate score. Best score is 500 points, which requires 6 tries at 10 seconds
            int bonusAttempts = (22 - attempts) * 20; //10 points for each attempt = 320
            int bonusTime = (30 - time) * 9; //6 points for each second = 180
            if (bonusAttempts < 0) bonusAttempts = 0;
            if (bonusTime < 0) bonusTime = 0;
            score = bonusTime + bonusAttempts;

            if (score > 450)
                label_Message.Text = "Perfect!";
            else if (score > 350)
                label_Message.Text = "Marvelous!";
            else if (score > 250)
                label_Message.Text = "Great!";
            else if (score > 150)
                label_Message.Text = "Good!";
            else
                label_Message.Text = "You can do better!";

            label_Attempts.Text = "ttempts: " + attempts;
            label_Time.Text = "Time: " + time;
            label_Score.Text = "Score: " + score;

            panel_GameTable.Visible = false;
            panel_Score.Visible = true;
            //Add to DataBase
            dbController.Add(MainMenu.username, score);
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
