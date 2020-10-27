using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TD_Game
{
    public partial class towerDefense : Form
    {
        public towerDefense()
        {
            InitializeComponent();
        }
        public double difficultyModifier = 1.0;
        public int permits = 1, tomes = 0, cores = 0;
        public int level = 1, maxXP = 10;
        public int baseBallistaDamage = 1, baseBallistaReload = 5, baseBallistaTracking = 10, baseBallistaSpeed = 5, baseBallistaRange = 100;

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

        public int baseWallHealth = 25, baseWallHeight = 1, baseWallDamage = 1;
        public void disableAll()
        {
            abilitiesButton.Enabled = false;
            upgradesButton.Enabled = false;
            quitButton.Enabled = false;
            towersButton.Enabled = false;
            tutorialButton.Enabled = false;
            enemiesButton.Enabled = false;
        }

        public void enableAll()
        {
            abilitiesButton.Enabled = true;
            upgradesButton.Enabled = true;
            quitButton.Enabled = true;
            towersButton.Enabled = true;
            tutorialButton.Enabled = true;
            enemiesButton.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
