using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_TD_Game
{
    public partial class tdGame : Form
    {
        public tdGame()
        {
            InitializeComponent();
        }
        //makes game more difficult
        public double difficultyModifier = 1.0;
        //resources for all of the different upgrades and towers
        public int permits = 1, tomes = 0, cores = 0;
        //level and health data
        public int level = 1, maxXP = 10, currentXP = 0, maxHP = 10, currentHP = 10;
        //archer stats
        public double baseArchersDamage = 1, baseArchersReload = 5, baseArchersTracking = 10, baseArchersSpeed = 5, baseArchersRange = 100, placedArchers = 0;

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 0.75;
            normalDifficultyButton.Visible = true;
            hardDifficultyButton.Visible = true;
            easyDifficultyButton.Visible = false;
        }

        private void normalDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 1.0;
            hardDifficultyButton.Visible = true;
            easyDifficultyButton.Visible = true;
            normalDifficultyButton.Visible = false;
        }

        private void hardDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 1.5;
            easyDifficultyButton.Visible = true;
            normalDifficultyButton.Visible = true;
            hardDifficultyButton.Visible = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //wall stats
        public double baseWallHealth = 25, baseWallHeight = 1, baseWallDamage = 1, placedWalls = 0;
        public double[,] archers = new double[50, 8], walls = new double[50, 5];



        public void disableAll()
        {
            abilitiesButton.Enabled = false;
            upgradesButton.Enabled = false;
            quitButton.Enabled = false;
            towersButton.Enabled = false;
            tutorialButton.Enabled = false;
            enemiesButton.Enabled = false;
            levelOneButton.Enabled = false;
            levelTwoButton.Enabled = false;
            levelThreeButton.Enabled = false;
            levelFourButton.Enabled = false;
            levelFiveButton.Enabled = false;
            levelSixButton.Enabled = false;
            levelSevenButton.Enabled = false;
            levelEightButton.Enabled = false;
            levelNineButton.Enabled = false;
            levelTenButton.Enabled = false;
            levelElevenButton.Enabled = false;
            levelTwelveButton.Enabled = false;
            levelThirteenButton.Enabled = false;
            levelFourteenButton.Enabled = false;
            levelFifteenButton.Enabled = false;
            createButton.Enabled = false;
            loadButton.Enabled = false;
        }

        public void enableAll()
        {
            abilitiesButton.Enabled = true;
            upgradesButton.Enabled = true;
            quitButton.Enabled = true;
            towersButton.Enabled = true;
            tutorialButton.Enabled = true;
            enemiesButton.Enabled = true;
            levelOneButton.Enabled = true;
            levelTwoButton.Enabled = true;
            levelThreeButton.Enabled = true;
            levelFourButton.Enabled = true;
            levelFiveButton.Enabled = true;
            levelSixButton.Enabled = true;
            levelSevenButton.Enabled = true;
            levelEightButton.Enabled = true;
            levelNineButton.Enabled = true;
            levelTenButton.Enabled = true;
            levelElevenButton.Enabled = true;
            levelTwelveButton.Enabled = true;
            levelThirteenButton.Enabled = true;
            levelFourteenButton.Enabled = true;
            levelFifteenButton.Enabled = true;
            createButton.Enabled = true;
            loadButton.Enabled = true;
        }

    }
}
