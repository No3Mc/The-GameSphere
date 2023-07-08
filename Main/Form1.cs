using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameshop1
{
    public partial class Form1 : Form
    {
        Shop shop;
        public Form1()
        {
            InitializeComponent();
        }
        //count defined so the next and back button start with 0++ and --
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //pics should word when the previous button is pressed
            if (count > 0)
            {
                count--;
            }
            pictureBox2.Image = imageList2.Images[count];
            pictureBox1.Image = imageList1.Images[count];

            shop.StepToPreviousGame();
            DisplayGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //added games to be displayed in shop
            shop = new Shop();
            //Add games here....
            //22 games
            //11 xbox games
            XboxGame xboxGame = new XboxGame("Xbox One", "Elder Scrolls", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame1 = new XboxGame("Xbox Series X and Series S", "Fortnite", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame2 = new XboxGame("Xbox One", "Forza 5", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame3 = new XboxGame("Xbox Series X and Series S", "Gta V", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame4 = new XboxGame("Xbox One", "Halo", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame5 = new XboxGame("Xbox Series X and Series S", "Miencraft", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame6 = new XboxGame("Xbox One", "Pubg", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame7 = new XboxGame("Xbox Series X and Series S", "R6S", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame8 = new XboxGame("Xbox One", "Robolox", "Rockstar Games", new DateTime(2013, 9, 17), 150, Game.Condition.mint);
            XboxGame xboxGame9 = new XboxGame("Xbox Series X and Series S", "Wireframe", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            XboxGame xboxGame10 = new XboxGame("Xbox Series X and Series S", "Hitman 2", "Sledgehammer Games", new DateTime(2021, 9, 10), 520, Game.Condition.fair);
            //11 ps games details. For store
            PSGame pSGame = new PSGame("Play Station 5", "Spiderman", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame1 = new PSGame("Play Station 4", "Red Dead Redemtion 2", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame2 = new PSGame("Play Station 5", "Fifa 22", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame3 = new PSGame("Play Station 4", "Apex Legends", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame4 = new PSGame("Play Station 5", "NBA 2K22", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame5 = new PSGame("Play Station 4", "Far Cry 6", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame6 = new PSGame("Play Station 5", "Dying Light 2", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame7 = new PSGame("Play Station 4", "Cyberpunk 2077", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame8 = new PSGame("Play Station 5", "Call of Duty Modern Warfare", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame9 = new PSGame("Play Station 4", "Battlefield 2042", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);
            PSGame pSGame10 = new PSGame("Play Station 5", "Rocket League", "Rockstar North", new DateTime(2018, 10, 25), 600, Game.Condition.good);
            PSGame pSGame11 = new PSGame("Play Station 4", "ARK Survival Evolved", "IO Interactive", new DateTime(2018, 11, 9), 500, Game.Condition.poor);

            //to display the game pic
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList2.Images[0];
            //if (Gameshop1.XboxGame.("Hitman 2"))
            //{

            //}

            //games for xbox  added to be displayed in shop
            shop.AddGame(xboxGame);
            shop.AddGame(xboxGame1);
            shop.AddGame(xboxGame2);
            shop.AddGame(xboxGame3);
            shop.AddGame(xboxGame4);
            shop.AddGame(xboxGame5);
            shop.AddGame(xboxGame6);
            shop.AddGame(xboxGame7);
            shop.AddGame(xboxGame8);
            shop.AddGame(xboxGame9);
            shop.AddGame(xboxGame10);
            //games for PS added to be displayed in shop
            shop.AddGame(pSGame);
            shop.AddGame(pSGame1);
            shop.AddGame(pSGame2);
            shop.AddGame(pSGame3);
            shop.AddGame(pSGame4);
            shop.AddGame(pSGame5);
            shop.AddGame(pSGame6);
            shop.AddGame(pSGame7);
            shop.AddGame(pSGame8);
            shop.AddGame(pSGame9);
            shop.AddGame(pSGame10);
            DisplayGame();
        }
        private void DisplayGame()
        {
            //displays the game in textbox game
            labelCurrentGame.Text = string.Format("Viewing {0} of {1}", 
            shop.CurrentlyViewedGame + 1, shop.Numberofgames);
            textBoxGame.Text = shop.DescribeCurrentGame();
            //textBox1.Text = shop.DescribeCurrentGame();
            //textBox2.Text = shop.DescribeCurrentGame();
            //textBox3.Text = shop.DescribeCurrentGame();
            //textBox4.Text = shop.DescribeCurrentGame();
            //textBox5.Text = shop.DescribeCurrentGame();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //pics should word when the next button is pressed
            if (count < 22)
            {
                count++;
            }
            pictureBox1.Image = imageList1.Images[count];
            pictureBox2.Image = imageList2.Images[count];
            //pictureBox2.Image = imageList2.Images[count];
            //pictureBox3.Image = imageList3.Images[count];
            shop.StepToNextGame();
            DisplayGame();

        }

        private void textBoxGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //should show xbox games xb collections bt click
            XboxCollections xboxCollections = new XboxCollections();
            xboxCollections.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //should show ps games on ps collections bt click
            PSCollections pSCollections = new PSCollections();
            pSCollections.Show();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            //should open the adding games form where people can enter new games
            //AddG add = new AddG("");
            //AddG addForm = new AddG;
            //addForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
