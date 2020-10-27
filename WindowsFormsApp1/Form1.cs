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
