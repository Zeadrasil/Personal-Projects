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
        //wall stats
        public double baseWallHealth = 25, baseWallHeight = 1, baseWallDamage = 1, placedWalls = 0;
        public double[,] archers = new double[50, 8], walls = new double[50, 5];
        private void hardDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 1.5;
            easyDifficultyButton.Visible = true;
            normalDifficultyButton.Visible = true;
            hardDifficultyButton.Visible = false;
        }


        private void normalDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 1.0;
            hardDifficultyButton.Visible = true;
            easyDifficultyButton.Visible = true;
            normalDifficultyButton.Visible = false;
        }

        private void easyDifficultyButton_Click(object sender, EventArgs e)
        {
            difficultyModifier = 0.75;
            normalDifficultyButton.Visible = true;
            hardDifficultyButton.Visible = true;
            easyDifficultyButton.Visible = false;
        }


        public void disableAll()
        {
            abilitiesButton.Enabled = false;
            upgradesButton.Enabled = false;
            quitButton.Enabled = false;
            towersButton.Enabled = false;
            tutorialButton.Enabled = false;
            enemiesButton.Enabled = false;
            level20Button.Enabled = false;
            level21Button.Enabled = false;
            level22Button.Enabled = false;
            level23Button.Enabled = false;
            level24Button.Enabled = false;
            level25Button.Enabled = false;
            level26Button.Enabled = false;
            level27Button.Enabled = false;
            level28Button.Enabled = false;
            level29Button.Enabled = false;
            level30Button.Enabled = false;
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
            levelSixteenButton.Enabled = false;
            levelSeventeenButton.Enabled = false;
            levelEighteenButton.Enabled = false;
            levelNineteenButton.Enabled = false;
        }

        public void enableAll()
        {
            abilitiesButton.Enabled = true;
            upgradesButton.Enabled = true;
            quitButton.Enabled = true;
            towersButton.Enabled = true;
            tutorialButton.Enabled = true;
            enemiesButton.Enabled = true;
            level20Button.Enabled = true;
            level21Button.Enabled = true;
            level22Button.Enabled = true;
            level23Button.Enabled = true;
            level24Button.Enabled = true;
            level25Button.Enabled = true;
            level26Button.Enabled = true;
            level27Button.Enabled = true;
            level28Button.Enabled = true;
            level29Button.Enabled = true;
            level30Button.Enabled = true;
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
            levelSixteenButton.Enabled = true;
            levelSeventeenButton.Enabled = true;
            levelEighteenButton.Enabled = true;
            levelNineteenButton.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
