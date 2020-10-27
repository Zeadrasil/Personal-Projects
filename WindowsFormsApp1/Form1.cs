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
        public int permits = 1, tomes = 0, cores = 0;
        public int level = 1, maxXP = 10;
        public int baseBallistaDamage = 1, baseBallistaReload = 5, baseBallistaTracking = 10, baseBallistaSpeed = 5, baseBallistaRange = 100;
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
